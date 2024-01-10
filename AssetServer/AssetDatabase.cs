using RogueTraderUnityToolkit.Core;
using RogueTraderUnityToolkit.Unity;
using RogueTraderUnityToolkit.Unity.File;
using RogueTraderUnityToolkit.UnityGenerated;
using RogueTraderUnityToolkit.UnityGenerated.Types;
using RogueTraderUnityToolkit.UnityGenerated.Types.Engine;
using System.Collections.Concurrent;
using System.Diagnostics;
using System.IO.MemoryMappedFiles;
using AssetBundle = RogueTraderUnityToolkit.Unity.File.AssetBundle;
using AssetBundleMetadata = RogueTraderUnityToolkit.UnityGenerated.Types.Engine.AssetBundle;

namespace AssetServer;

public sealed class AssetDatabase
{
    public IEnumerable<AsciiString> Scenes => _sceneHashes.Keys;

    public AssetDatabase(List<FileInfo> files)
    {
        _loader.Load(files);
        Parallel.ForEach(_loader.Assets.Values.OfType<SerializedFile>(), PopulateScenesFromFile);
    }

    public void LoadScene(AsciiString sceneName,
        out GameObject root,
        out Dictionary<GameObject, List<GameObject>> scene,
        out Dictionary<GameObject, IUnityObject[]> sceneComponents)
    {
        root = default!;
        scene = [];
        sceneComponents = [];

        AsciiString containerName = _sceneHashes[sceneName];

        if (_loader.Assets.TryGetValue(containerName.ToString(), out ISerializedAsset? sceneContainer))
        {
            // Grab the first object we can find.
            SerializedFile file = (SerializedFile)sceneContainer;
            GameObject firstObject = ReadObjectsOfType(file, UnityObjectType.GameObject, num: 1).OfType<GameObject>().First();

            // Grab its transform.
            Transform firstObjectTransform = default!;
            foreach (PPtr<Component> pptr in firstObject.m_Component.Select(x => x.component))
            {
                IUnityObject component = ResolvePptr(file, pptr, out SerializedFile outFile);
                if (component is Transform transform)
                {
                    firstObjectTransform = transform;
                    file = outFile;
                    break;
                }
            }

            // Read its parents all the way until the root.
            while (firstObjectTransform.m_Father != default)
            {
                firstObjectTransform = (Transform)ResolvePptr(file, firstObjectTransform.m_Father, out file);
            }

            // Now recursively read self and children.
            GameObject tempRoot = (GameObject)ResolvePptr(file, firstObjectTransform.m_GameObject, out file);
            scene[tempRoot] = [];
            AddObjectAndChildren(scene, sceneComponents, file, tempRoot, firstObjectTransform.m_GameObject, out root);
            scene.Remove(tempRoot); // root self reference for coding simplicity
        }
    }

    private void AddObjectAndChildren(
        IDictionary<GameObject, List<GameObject>> scene,
        IDictionary<GameObject, IUnityObject[]> components,
        SerializedFile file,
        GameObject parent,
        PPtr<GameObject> selfPptr,
        out GameObject self)
    {
        self = (GameObject)ResolvePptr(file, selfPptr, out file);

        scene[self] = [];
        scene[parent].Add(self);

        List<IUnityObject> selfComponents = [];

        foreach (PPtr<Component> pptr in self.m_Component.Select(x => x.component))
        {
            IUnityObject component = ResolvePptr(file, pptr, out SerializedFile outFile);
            selfComponents.Add(component);

            // Only update the file on transform (since this is what we'll be looking up the next transform relative to.
            if (component is Transform)
            {
                file = outFile;
            }
        }

        components[self] = selfComponents.ToArray();

        foreach (PPtr<Transform> child in components[self].OfType<Transform>().First().m_Children)
        {
            Transform childTransform = (Transform)ResolvePptr(file, child, out file);
            AddObjectAndChildren(scene, components, file, self, childTransform.m_GameObject, out _);
        }
    }

    private IUnityObject ResolvePptr<T>(SerializedFile from, PPtr<T> pptr, out SerializedFile outFrom)
    {
        if (pptr.FileId != 0)
        {
            SerializedFileReferences reference = from.References[pptr.FileId - 1];
            string containerName = reference.PathUnity.ToString().Split('/').Last();

            bool found = _loader.Assets.TryGetValue(containerName, out ISerializedAsset? asset);
            Debug.Assert(found && asset != null);

            from = (SerializedFile)asset;
        }

        int objectIdx = _loader.PathIdToIdx[from][pptr.PathId];

        ref SerializedFileObjectInstance instance = ref from.ObjectInstances[objectIdx];
        ref SerializedFileObject obj = ref from.Objects[instance.TypeIdx];
        using Stream stream = from.Info.Open(from.Header.DataOffset + instance.Offset, instance.Size);
        EndianBinaryReader reader = new(stream, from.Header.IsBigEndian);

        bool knownType = GeneratedTypes.TryCreateType(obj.Info.Hash, obj.Info.Type, reader, out IUnityObject createdObj);
        Debug.Assert(knownType);
        Debug.Assert(reader.Remaining == 0);

        outFrom = from;
        return createdObj;
    }

    private void PopulateScenesFromFile(SerializedFile file)
    {
        List<IUnityObject> objects = ReadObjectsOfType(file, UnityObjectType.AssetBundle);

        foreach (AssetBundleMetadata metadata in objects.OfType<AssetBundleMetadata>())
        {
            foreach ((AsciiString name, AsciiString bundleName) in metadata.m_SceneHashes)
            {
                _sceneHashes.TryAdd(name, bundleName);
            }
        }
    }

    private static List<IUnityObject> ReadAllObjects(SerializedFile file) => ReadObjects(file, _ => true);

    private static List<IUnityObject> ReadObjectsOfType(SerializedFile file, UnityObjectType type, int num = int.MaxValue)
    {
        int found = 0;
        return ReadObjects(file, (obj) => obj.Info.Type == type && found++ < num);
    }

    private static List<IUnityObject> ReadObjects(SerializedFile file, Func<SerializedFileObject, bool> fnShouldRead)
    {
        using Stream stream = file.Info.Open(file.Header.DataOffset);
        EndianBinaryReader reader = new(stream, file.Header.IsBigEndian);

        List<IUnityObject> objects = [];

        for (int i = 0; i < file.ObjectInstances.Length; ++i)
        {
            ref SerializedFileObjectInstance instance = ref file.ObjectInstances[i];
            ref SerializedFileObject obj = ref file.Objects[instance.TypeIdx];

            if (!fnShouldRead(obj)) continue;

            reader.Position = (int)instance.Offset;

            bool knownType = GeneratedTypes.TryCreateType(obj.Info.Hash, obj.Info.Type, reader, out IUnityObject createdObj);
            Debug.Assert(knownType);

            long remaining = (instance.Offset + instance.Size) - reader.Position;
            Debug.Assert(remaining == 0);

            objects.Add(createdObj);
        }

        return objects;
    }

    private readonly AssetDatabaseLoader _loader = new();
    private readonly ConcurrentDictionary<AsciiString, AsciiString> _sceneHashes = [];
}

public sealed class AssetDatabaseLoader : IDisposable
{
    public IReadOnlyList<MemoryMappedFile> Files => _files;
    public IReadOnlyDictionary<string, ISerializedAsset> Assets => _assets;
    public IReadOnlyDictionary<ISerializedAsset, Dictionary<long, int>> PathIdToIdx => _pathIdToIdx;
    public IReadOnlyDictionary<ISerializedAsset, List<long>> IdxToPathId => _idxToPathId;

    public void Load(IEnumerable<FileInfo> files)
    {
        Parallel.ForEach(files, LoadFile);
        Parallel.ForEach(_assets.Values, CreatePathIdLookup);
    }

    private void LoadFile(FileInfo file)
    {
        if (!file.FullName.EndsWith(".scenes")) return;
        MemoryMappedFile fileHandle = MemoryMappedFile.CreateFromFile(file.FullName);
        _files.Add(fileHandle);

        SerializedAssetInfo info = new(
            parent: null,
            identifier: Path.GetFileName(file.FullName),
            file.Length,
            fnOpen: (offset, length) =>
            {
                try
                {
                    return fileHandle.CreateViewStream(offset, length);
                }
                catch (Exception ex)
                {
                    Log.Write($"Failed to open file {file.FullName}", ConsoleColor.Red);
                }

                return new NullStream();
            });

        if (AssetBundle.CanRead(info))
        {
            AssetBundle bundle = AssetBundle.Read(info);
            IRelocatableMemoryRegion[] bundleMemory = bundle.CreateRelocatableMemoryRegions();

            foreach (AssetBundleNode node in bundle.Manifest.Nodes)
            {
                SerializedAssetInfo bundleInfo = bundle.CreateAssetInfoForNode(node, bundleMemory);
                _assets[bundleInfo.Identifier] =
                    SerializedFile.CanRead(bundleInfo) ? SerializedFile.Read(bundleInfo) :
                        ResourceFile.Read(bundleInfo);
            }
        }
        else
        {
            _assets[info.Identifier] =
                SerializedFile.CanRead(info) ? SerializedFile.Read(info) :
                    ResourceFile.Read(info);
        }
    }

    private void CreatePathIdLookup(ISerializedAsset asset)
    {
        Dictionary<long, int> idxLookup = [];
        List<long> pathIdLookup = [];

        if (asset is SerializedFile file)
        {
            for (int i = 0; i < file.ObjectInstances.Length; ++i)
            {
                idxLookup.Add(file.ObjectInstances[i].Id, i);
                pathIdLookup.Add(file.ObjectInstances[i].Id);
            }
        }

        _pathIdToIdx[asset] = idxLookup;
        _idxToPathId[asset] = pathIdLookup;
    }

    public void Dispose()
    {
        foreach (MemoryMappedFile file in _files)
        {
            file.Dispose();
        }
    }

    private readonly List<MemoryMappedFile> _files = [];
    private readonly ConcurrentDictionary<string, ISerializedAsset> _assets = [];
    private readonly ConcurrentDictionary<ISerializedAsset, Dictionary<long, int>> _pathIdToIdx = [];
    private readonly ConcurrentDictionary<ISerializedAsset, List<long>> _idxToPathId = [];
}

public enum AssetDatabaseRequestType : byte
{
    Scene
};

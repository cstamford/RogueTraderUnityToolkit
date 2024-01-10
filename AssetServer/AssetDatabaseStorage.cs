using RogueTraderUnityToolkit.Core;
using RogueTraderUnityToolkit.Unity;
using RogueTraderUnityToolkit.Unity.File;
using RogueTraderUnityToolkit.UnityGenerated;
using System.Collections.Concurrent;
using System.IO.MemoryMappedFiles;

namespace AssetServer;

public static class AssetDatabaseStorage
{
    public static IReadOnlyDictionary<string, ISerializedAsset> Assets => _assets;
    public static IReadOnlyDictionary<ISerializedAsset, Dictionary<long, int>> PathIdToIdx => _pathIdToIdx;
    public static IReadOnlyDictionary<ISerializedAsset, List<long>> IdxToPathId => _idxToPathId;
    public static IReadOnlyDictionary<AssetDatabasePtr<IUnityObject>, IUnityObject> ReadCache => _readCache;

    public static void Load(IEnumerable<FileInfo> files)
    {
        Parallel.ForEach(files, LoadFile);
        Parallel.ForEach(_assets.Values, CreatePathIdLookup);
    }

    public static void AddAsset<T>(AssetDatabasePtr<T> ptr, IUnityObject obj) =>
        _readCache[ptr.Retype<IUnityObject>()] = obj;

    private static void LoadFile(FileInfo file)
    {
        MemoryMappedFile fileHandle = MemoryMappedFile.CreateFromFile(file.FullName);

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
                catch
                {
                    Log.Write($"Failed to open file {file.FullName}", ConsoleColor.Red);
                }

                return new NullStream();
            });

        if (AssetBundle.CanRead(info))
        {
            AssetBundle bundle = AssetBundle.Read(info);
            _assets[info.Identifier] = bundle;

            IRelocatableMemoryRegion[] bundleMemory = bundle.CreateRelocatableMemoryRegions();

            foreach (AssetBundleNode node in bundle.Manifest.Nodes)
            {
                SerializedAssetInfo bundleInfo = bundle.CreateAssetInfoForNode(node, bundleMemory);

                _assets[bundleInfo.Identifier] = SerializedFile.CanRead(bundleInfo) ?
                    SerializedFile.Read(bundleInfo) :
                    ResourceFile.Read(bundleInfo);
            }
        }
        else
        {
            _assets[info.Identifier] = SerializedFile.CanRead(info) ?
                SerializedFile.Read(info) :
                ResourceFile.Read(info);
        }
    }

    private static void CreatePathIdLookup(ISerializedAsset asset)
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

    private static readonly ConcurrentDictionary<string, ISerializedAsset> _assets = [];
    private static readonly ConcurrentDictionary<ISerializedAsset, Dictionary<long, int>> _pathIdToIdx = [];
    private static readonly ConcurrentDictionary<ISerializedAsset, List<long>> _idxToPathId = [];
    private static readonly ConcurrentDictionary<AssetDatabasePtr<IUnityObject>, IUnityObject> _readCache = [];
}

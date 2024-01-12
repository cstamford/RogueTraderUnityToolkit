using RogueTraderUnityToolkit.Core;
using RogueTraderUnityToolkit.Unity.File;
using RogueTraderUnityToolkit.UnityGenerated;
using RogueTraderUnityToolkit.UnityGenerated.Types.Engine;
using System.Diagnostics;

namespace AssetServer;

public readonly record struct AssetDatabasePtr<T>(SerializedFile File, long PathId)
{
    public AssetDatabasePtr(SerializedFile file, PPtr<T> pptr)
        : this(ResolvePPtrFileId(file, pptr.FileId), pptr.PathId)
    {
        _valid = pptr.PathId != 0;
    }

    public T Fetch(bool withByteArrays = true) => Fetch<T>(withByteArrays);

    public T2 Fetch<T2>(bool withByteArrays = true)
    {
        Debug.Assert(_valid);

        if (AssetDatabaseStorage.ReadCache.TryGetValue(Retype<IUnityObject>(), out IUnityObject? createdObject))
        {
            return (T2)createdObject;
        }

        int objectIdx = AssetDatabaseStorage.PathIdToIdx[File][PathId];

        ref SerializedFileObjectInstance instance = ref File.ObjectInstances[objectIdx];
        ref SerializedFileObject obj = ref File.Objects[instance.TypeIdx];
        using Stream stream = File.Info.Open(File.Header.DataOffset + instance.Offset, instance.Size);
        EndianBinaryReader reader = new(stream, File.Header.IsBigEndian);

        bool knownType = GeneratedTypes.TryCreateType(
            obj.Info.Hash,
            obj.Info.Type,
            reader,
            out createdObject,
            withByteArrays);

        Debug.Assert(knownType);
        Debug.Assert(reader.Remaining == 0 || createdObject is MonoBehaviour); // MonoBehaviour without game structs only does base class
        Debug.Assert(createdObject is T2);

        if (createdObject is GameObject or Transform)
        {
            // Cache small, commonly (re)accessed objects.
            AssetDatabaseStorage.AddAsset(this, createdObject);
        }

        return (T2)createdObject;
    }

    public AssetDatabasePtr<T2> Retype<T2>() => new(File, PathId);

    public static T Fetch(SerializedFile file, PPtr<T> pptr) => Fetch<T>(file, pptr);
    public static T2 Fetch<T2>(SerializedFile file, PPtr<T> pptr) => new AssetDatabasePtr<T>(file, pptr).Fetch<T2>();
    public bool Valid => _valid;

    private readonly bool _valid = true;

    private static SerializedFile ResolvePPtrFileId(SerializedFile file, int fileId)
    {
        if (fileId == 0) return file;

        SerializedFileReferences reference = file.References[fileId - 1];
        string containerName = reference.PathUnity.ToString().Split('/').Last();

        bool found = AssetDatabaseStorage.Assets.TryGetValue(containerName, out ISerializedAsset? asset);
        Debug.Assert(found && asset != null);

        return (SerializedFile)asset;
    }
}

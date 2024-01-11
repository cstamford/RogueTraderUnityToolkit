using RogueTraderUnityToolkit.Unity;
using RogueTraderUnityToolkit.Unity.File;
using RogueTraderUnityToolkit.UnityGenerated;

namespace AssetServer;

public static class AssetDatabaseExtensions
{
    public static IEnumerable<AssetDatabasePtr<T>> GetObjectPtrs<T>(
        this SerializedFile file,
        UnityObjectType type)
        => GetObjectPtrs(file, obj => obj.Info.Type == type).Select(x => x.Retype<T>());

    public static List<AssetDatabasePtr<IUnityObject>> GetObjectPtrs(
        this SerializedFile file,
        Func<SerializedFileObject, bool> fnShouldRead)
    {
        List<AssetDatabasePtr<IUnityObject>> ptrs = [];

        for (int i = 0; i < file.ObjectInstances.Length; ++i)
        {
            ref SerializedFileObjectInstance instance = ref file.ObjectInstances[i];
            ref SerializedFileObject obj = ref file.Objects[instance.TypeIdx];

            if (!fnShouldRead(obj)) continue;

            ptrs.Add(new(file, AssetDatabaseStorage.IdxToPathId[file][i]));
        }

        return ptrs;
    }

    public static AssetDatabasePtr<T> Ptr<T>(this SerializedFile file, PPtr<T> pptr) => new(file, pptr);

    public static int Size(this VertexAttributeFormat format) => format switch
    {
        VertexAttributeFormat.Float32 => 4,
        VertexAttributeFormat.Float16 => 2,
        VertexAttributeFormat.UNorm8 => 1,
        VertexAttributeFormat.SNorm8 => 1,
        VertexAttributeFormat.UNorm16 => 2,
        VertexAttributeFormat.SNorm16 => 2,
        VertexAttributeFormat.UInt8 => 1,
        VertexAttributeFormat.SInt8 => 1,
        VertexAttributeFormat.UInt16 => 2,
        VertexAttributeFormat.SInt16 => 2,
        VertexAttributeFormat.UInt32 => 4,
        VertexAttributeFormat.SInt32 => 4,
        _ => throw new()
    };
}

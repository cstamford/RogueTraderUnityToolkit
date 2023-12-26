using RogueTraderUnityToolkit.Helper;
using System.Buffers;

namespace RogueTraderUnityToolkit.Unity;

public record struct SerializedObjectType(
    SerializedObjectTypeInfo Info,
    SerializedObjectTypeTree Tree,
    SerializedObjectTypeDependency[] Dependencies)
{
    public static SerializedObjectType Read(EndianBinaryReader reader)
    {
        SerializedObjectTypeInfo info = SerializedObjectTypeInfo.Read(reader);
        SerializedObjectTypeTree tree = SerializedObjectTypeTree.Read(reader);
        SerializedObjectTypeDependency[] dependencies = reader.ReadArray(SerializedObjectTypeDependency.Read);

        return new(
            Info: info,
            Tree: tree,
            Dependencies: dependencies);
    }
}

public record struct SerializedObjectTypeInfo(
    UnityObjectType Type,
    bool IsStripped,
    ushort ScriptTypeIdx,
    SerializedHash? ScriptHash,
    SerializedHash Hash)
{
    public static SerializedObjectTypeInfo Read(EndianBinaryReader reader)
    {
        UnityObjectType type = (UnityObjectType)reader.ReadS32();
        bool isStripped = reader.ReadB8();
        ushort scriptTypeIdx = reader.ReadU16();

        bool hasScriptType = type == UnityObjectType.TypeRef || type == UnityObjectType.MonoBehaviour;

        if (!hasScriptType && scriptTypeIdx != 0xFFFF)
        {
            throw new Exception($"SerializedObjectTypeInfo: Has a custom scriptTypeIdx {scriptTypeIdx} with type {type}.");
        }

        SerializedHash? scriptHash = hasScriptType ? SerializedHash.Read(reader) : default;
        SerializedHash hash = SerializedHash.Read(reader);

        return new(
            Type: type,
            IsStripped: isStripped,
            ScriptTypeIdx: scriptTypeIdx,
            ScriptHash: scriptHash,
            Hash: hash);
    }
}

public record class SerializedObjectTypeTree(
    SerializedObjectParserNode[] Nodes)
{
    public static SerializedObjectTypeTree Read(EndianBinaryReader reader)
    {
        int nodesCount = reader.ReadS32();
        int bufferSize = reader.ReadS32();

        SerializedObjectTypeNode[] nodes = ArrayPool<SerializedObjectTypeNode>.Shared.Rent(nodesCount);

        for (int i = 0; i < nodesCount; ++i)
        {
            nodes[i] = SerializedObjectTypeNode.Read(reader);
        }

        byte[] buffer = ArrayPool<byte>.Shared.Rent(bufferSize);
        reader.ReadBytes(buffer.AsSpan()[..bufferSize]);

        // We construct a more useful (and smaller) representation for each node for parsing purposes.
        SerializedObjectParserNode[] compactNodes = new SerializedObjectParserNode[nodesCount];

        for (int i = 0; i < nodesCount; ++i)
        {
            compactNodes[i] = SerializedObjectParserNode.Create(i, buffer, nodes.AsSpan(0, nodesCount));
        }

        ArrayPool<SerializedObjectTypeNode>.Shared.Return(nodes);
        ArrayPool<byte>.Shared.Return(buffer);

        return new(Nodes: compactNodes);
    }

    public ref SerializedObjectParserNode this[int index] => ref Nodes[index];
    public ref SerializedObjectParserNode Root => ref Nodes[0];
    public int Length => Nodes.Length;

    public override string ToString() => Root.Dump(this);
}

public record struct SerializedObjectTypeNode(
    ushort Version,
    byte Level,
    SerializedObjectTypeFlags TypeFlags,
    uint OffsetTypeName,
    uint OffsetName,
    int Size,
    int Idx,
    SerializedObjectTypeMetaFlags MetaFlags,
    ulong Hash)
{
    public static SerializedObjectTypeNode Read(EndianBinaryReader reader)
    {
        ushort version = reader.ReadU16();
        byte level = reader.ReadByte();
        SerializedObjectTypeFlags typeFlags = (SerializedObjectTypeFlags)reader.ReadU8();
        uint offsetTypeName = reader.ReadU32();
        uint offsetName = reader.ReadU32();
        int size = reader.ReadS32();
        int idx = reader.ReadS32();
        SerializedObjectTypeMetaFlags metaFlags = (SerializedObjectTypeMetaFlags)reader.ReadU32();
        ulong hash = reader.ReadU64();

        return new(
            Version: version,
            Level: level,
            TypeFlags: typeFlags,
            OffsetTypeName: offsetTypeName,
            OffsetName: offsetName,
            Size: size,
            Idx: idx,
            MetaFlags: metaFlags,
            Hash: hash);
    }
}

public record struct SerializedObjectTypeDependency(int Type)
{
    public static SerializedObjectTypeDependency Read(EndianBinaryReader reader)
    {
        return new(reader.ReadS32());
    }
}

[Flags]
// sauce: UnityDataTools
public enum SerializedObjectTypeFlags : byte
{
    None = 0,
    IsArray = 1 << 0,
    IsManagedReference = 1 << 1,
    IsManagedReferenceRegistry = 1 << 2,
    IsArrayOfRefs = 1 << 3,
}

[Flags]
// sauce: UnityDataTools
public enum SerializedObjectTypeMetaFlags : uint
{
    None = 0,
    AlignBytes = 1 << 14,
    AnyChildUsesAlignBytes = 1 << 15,
}

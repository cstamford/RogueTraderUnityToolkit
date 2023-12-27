using RogueTraderUnityToolkit.Core;
using System.Buffers;

namespace RogueTraderUnityToolkit.Unity;

public readonly record struct ObjectTypeTree(
    ObjectParserNode[] Nodes)
{
    public static ObjectTypeTree Read(EndianBinaryReader reader)
    {
        int nodesCount = reader.ReadS32();
        int bufferSize = reader.ReadS32();

        ObjectTypeNode[] nodes = ArrayPool<ObjectTypeNode>.Shared.Rent(nodesCount);

        for (int i = 0; i < nodesCount; ++i)
        {
            nodes[i] = ObjectTypeNode.Read(reader);
        }

        byte[] buffer = ArrayPool<byte>.Shared.Rent(bufferSize);
        reader.ReadBytes(buffer.AsSpan()[..bufferSize]);

        // We construct a more useful (and smaller) representation for each node for parsing purposes.
        ObjectParserNode[] compactNodes = new ObjectParserNode[nodesCount];

        for (int i = 0; i < nodesCount; ++i)
        {
            compactNodes[i] = ObjectParserNode.Create(i, buffer, nodes.AsSpan(0, nodesCount));
        }

        ArrayPool<ObjectTypeNode>.Shared.Return(nodes);
        ArrayPool<byte>.Shared.Return(buffer);

        return new(Nodes: compactNodes);
    }

    public ref ObjectParserNode this[int index] => ref Nodes[index];
    public ref ObjectParserNode Root => ref Nodes[0];
    public int Length => Nodes.Length;

    public override string ToString() => Root.Dump(this);
}

public readonly record struct ObjectTypeNode(
    ushort Version,
    byte Level,
    ObjectTypeFlags TypeFlags,
    uint OffsetTypeName,
    uint OffsetName,
    int Size,
    int Idx,
    ObjectTypeMetaFlags MetaFlags,
    ulong Hash)
{
    public static ObjectTypeNode Read(EndianBinaryReader reader)
    {
        ushort version = reader.ReadU16();
        byte level = reader.ReadByte();
        ObjectTypeFlags typeFlags = (ObjectTypeFlags)reader.ReadU8();
        uint offsetTypeName = reader.ReadU32();
        uint offsetName = reader.ReadU32();
        int size = reader.ReadS32();
        int idx = reader.ReadS32();
        ObjectTypeMetaFlags metaFlags = (ObjectTypeMetaFlags)reader.ReadU32();
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

[Flags]
// sauce: UnityDataTools
public enum ObjectTypeFlags : byte
{
    None = 0,
    IsArray = 1 << 0,
    IsManagedReference = 1 << 1,
    IsManagedReferenceRegistry = 1 << 2,
    IsArrayOfRefs = 1 << 3
}

[Flags]
// sauce: UnityDataTools
public enum ObjectTypeMetaFlags : uint
{
    None = 0,
    AlignBytes = 1 << 14,
    AnyChildUsesAlignBytes = 1 << 15
}

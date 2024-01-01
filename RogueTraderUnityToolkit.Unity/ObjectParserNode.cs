using RogueTraderUnityToolkit.Core;
using System.Diagnostics;
using System.Text;

namespace RogueTraderUnityToolkit.Unity;

public readonly record struct ObjectParserNode(
    AsciiString Name,
    AsciiString TypeName,
    ObjectParserType Type,
    ObjectParserNodeFlags Flags,
    ushort Index,
    ushort FirstChildIdx,
    ushort FirstSiblingIdx,
    byte Level)
{
    public bool IsAlignTo4 => (Flags & ObjectParserNodeFlags.IsAlignTo4) != 0;
    public bool IsArray => (Flags & ObjectParserNodeFlags.IsArray) != 0;
    public bool IsRef => (Flags & ObjectParserNodeFlags.IsRef) != 0;
    public bool IsRefRegistry => (Flags & ObjectParserNodeFlags.IsRefRegistry) != 0;

    public bool IsLeaf => FirstChildIdx == 0;
    public bool IsPrimitive => IsLeaf && (Flags & ObjectParserNodeFlags.HasSize) != 0;
    public bool IsBuiltin => !IsLeaf && (Flags & ObjectParserNodeFlags.IsBuiltin) != 0;

    public byte Size => Type.Size();

    public static ObjectParserNode Create(
        int nodeIdx,
        ReadOnlyMemory<byte> localBuffer,
        Span<ObjectTypeNode> nodes)
    {
        ref ObjectTypeNode node = ref nodes[nodeIdx];

        ResolveFromNames(node, localBuffer,
            out AsciiString name,
            out AsciiString typeName,
            out ObjectParserType type);

        ResolveHierarchy(node, nodes, nodeIdx,
            out ushort firstChildIdx,
            out ushort firstSiblingIdx);

        ObjectParserNodeFlags flags = ResolveFlags(node, type);

        ObjectParserNode parserNode = new(
            Name: name,
            TypeName: typeName,
            Type: type,
            Flags: flags,
            Index: (ushort)nodeIdx,
            FirstChildIdx: firstChildIdx,
            FirstSiblingIdx: firstSiblingIdx,
            Level: node.Level);

        return parserNode;
    }

    private static void ResolveFromNames(
        in ObjectTypeNode node,
        ReadOnlyMemory<byte> localBuffer,
        out AsciiString name,
        out AsciiString typeName,
        out ObjectParserType type)
    {
        name = FetchName(node.OffsetName, localBuffer, out ReadOnlyMemory<byte> _);
        typeName = FetchName(node.OffsetTypeName, localBuffer, out ReadOnlyMemory<byte> typeNameBytes);

        ReadOnlySpan<byte> typeNameSpan = typeNameBytes.Span;

        if (!ObjectParserNodeUtil.TryGetType(typeNameSpan, out ObjectParserType compactType))
        {
            if (typeNameSpan.Length >= 5 && "PPtr<"u8.SequenceEqual(typeNameSpan[..5]))
            {
                compactType = ObjectParserType.PPTr;
            }
            else
            {
                compactType = node.Size switch
                {
                    8 => ObjectParserType.S64,
                    4 => ObjectParserType.S32,
                    2 => ObjectParserType.S16,
                    1 => ObjectParserType.S8,
                    _ => ObjectParserType.Complex
                };
            }
        }

        type = compactType;
    }

    private static AsciiString FetchName(
        uint offset,
        ReadOnlyMemory<byte> localBuffer,
        out ReadOnlyMemory<byte> bufferRead)
    {
        const uint inGlobalBuffer = 1u << 31;
        int realOffset = (int)(offset & ~inGlobalBuffer);

        if ((offset & inGlobalBuffer) == 0)
        {
            int nullTerminator = Util.FastFindByte(0, localBuffer.Span, realOffset);
            bufferRead = localBuffer[realOffset..nullTerminator];
        }
        else
        {
            bool found = UnityTypeNames.TryGetValue(realOffset, out bufferRead);
            Debug.Assert(found);
        }

        return AsciiStringPool.Fetch(bufferRead);
    }

    private static void ResolveHierarchy(
        in ObjectTypeNode node,
        Span<ObjectTypeNode> nodes,
        int idx,
        out ushort firstChildIdx,
        out ushort firstSiblingIdx)
    {
        int childIdx = 0;
        int siblingIdx = 0;

        int childLevel = node.Level + 1;
        int siblingLevel = node.Level;

        for (int i = idx + 1; i < nodes.Length; i++)
        {
            bool needChildIdx = childIdx == 0;
            bool needSiblingIdx = siblingIdx == 0;

            if (!needSiblingIdx) break;

            ref ObjectTypeNode otherNode = ref nodes[i];

            if (needChildIdx && otherNode.Level == childLevel) childIdx = i;
            if (needSiblingIdx && otherNode.Level == siblingLevel) siblingIdx = i;
        }

        firstChildIdx = (ushort)childIdx;
        firstSiblingIdx = (ushort)siblingIdx;
    }

    private static ObjectParserNodeFlags ResolveFlags(
        in ObjectTypeNode node,
        ObjectParserType type)
    {
        ObjectParserNodeFlags flags = ObjectParserNodeFlags.None;

        if ((node.MetaFlags & (ObjectTypeMetaFlags.AlignBytes | ObjectTypeMetaFlags.AnyChildUsesAlignBytes)) != 0)
        {
            flags |= ObjectParserNodeFlags.IsAlignTo4;
        }

        if ((node.TypeFlags & ObjectTypeFlags.IsArray) != 0)
        {
            flags |= ObjectParserNodeFlags.IsArray;
        }

        if ((node.TypeFlags & ObjectTypeFlags.IsManagedReference) != 0)
        {
            flags |= ObjectParserNodeFlags.IsRef;
        }

        if ((node.TypeFlags & ObjectTypeFlags.IsManagedReferenceRegistry) != 0)
        {
            flags |= ObjectParserNodeFlags.IsRefRegistry;
        }

        if ((int)type > (int)ObjectParserType.Complex)
        {
            flags |= ObjectParserNodeFlags.IsBuiltin;
        }

        if (node.Size > 0)
        {
            flags |= ObjectParserNodeFlags.HasSize;
        }

        return flags;
    }

    public override string ToString() => $"{Name.ToString()} ({TypeName.ToString()}) " +
                                         $"{Type}/{Size} " +
                                         $"level:{Level} " +
                                         $"idx:{Index} " +
                                         $"child:{FirstChildIdx} " +
                                         $"sibling:{FirstSiblingIdx} " +
                                         $"flags:{Flags})";
}

public enum ObjectParserType : byte
{
    U64,
    U32,
    U16,
    U8,

    S64,
    S32,
    S16,
    S8,

    F64,
    F32,

    Bool,
    Char,

    Complex,

    String,
    RefObjectTree,
    Vector,
    Map,
    PPTr
}

[Flags]
public enum ObjectParserNodeFlags : byte
{
    None = 0,
    IsAlignTo4 = 1 << 0,
    IsArray = 1 << 1,
    IsRef = 1 << 2,
    IsRefRegistry = 1 << 3,
    IsBuiltin = 1 << 4,
    HasSize = 1 << 5
}

public static class ObjectParserNodeUtil
{
    static ObjectParserNodeUtil()
    {
        _hashToType = new()
        {
            [Util.Hash("UInt64")] = ObjectParserType.U64,
            [Util.Hash("FileSize")] = ObjectParserType.U64,
            [Util.Hash("UInt32")] = ObjectParserType.U32,
            [Util.Hash("unsigned int")] = ObjectParserType.U32,
            [Util.Hash("UInt16")] = ObjectParserType.U16,
            [Util.Hash("UInt8")] = ObjectParserType.U8,

            [Util.Hash("SInt64")] = ObjectParserType.S64,
            [Util.Hash("SInt32")] = ObjectParserType.S32,
            [Util.Hash("int")] = ObjectParserType.S32,
            [Util.Hash("TypePtr")] = ObjectParserType.S32,
            [Util.Hash("SInt16")] = ObjectParserType.S16,
            [Util.Hash("SInt8")] = ObjectParserType.S8,

            [Util.Hash("double")] = ObjectParserType.F64,
            [Util.Hash("float")] = ObjectParserType.F32,

            [Util.Hash("bool")] = ObjectParserType.Bool,
            [Util.Hash("char")] = ObjectParserType.Char,

            [Util.Hash("string")] = ObjectParserType.String,
            [Util.Hash("ReferencedObject")] = ObjectParserType.RefObjectTree,

            //[Util.Hash("vector")] = ObjectParserType.Vector,
            //[Util.Hash("map")] = ObjectParserType.Map,
        };
    }

    public static bool TryGetType(ReadOnlySpan<byte> span, out ObjectParserType type) =>
        _hashToType.TryGetValue(Util.Hash(span), out type);

    public static string Dump(this ObjectParserNode node, ObjectTypeTree tree)
    {
        int width = Util.CharWidth(tree.Length);

        StringBuilder sb = new();
        sb.AppendLine(string.Format($"[{{0,{width}}}] {node}", node.Level));

        int startIdx = node.FirstChildIdx;
        int endIdx = node.FirstSiblingIdx != 0 ? node.FirstSiblingIdx : tree.Length;
        for (int i = startIdx; i < endIdx; ++i)
        {
            ref ObjectParserNode nextNode = ref tree[i];
            sb.AppendLine(string.Format($"[{{0,{width}}}]{new(' ', nextNode.Level * 4)} {nextNode}", i));
        }

        return sb.ToString();
    }

    private static readonly Dictionary<uint, ObjectParserType> _hashToType;
}

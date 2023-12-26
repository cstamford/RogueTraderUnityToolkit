using NeoSmart.Hashing.XXHash;
using RogueTraderUnityToolkit.Helper;
using System.Runtime.CompilerServices;
using System.Text;

namespace RogueTraderUnityToolkit.Unity;

public record struct SerializedObjectParserNode(
    string Name,
    string TypeName,
    SerializedObjectParserType Type,
    SerializedObjectParserNodeFlags Flags,
    ushort Index,
    ushort FirstChildIdx,
    ushort FirstSiblingIdx,
    byte Level)
{
    public readonly bool IsAlignTo4 => (Flags & SerializedObjectParserNodeFlags.IsAlignTo4) != 0;
    public readonly bool IsArray => (Flags & SerializedObjectParserNodeFlags.IsArray) != 0;
    public readonly bool IsRef => (Flags & SerializedObjectParserNodeFlags.IsRef) != 0;
    public readonly bool IsRefRegistry => (Flags & SerializedObjectParserNodeFlags.IsRefRegistry) != 0;

    public readonly bool IsLeaf => FirstChildIdx == 0;
    public readonly bool IsPrimitive => IsLeaf && (Flags & SerializedObjectParserNodeFlags.HasSize) != 0;
    public readonly bool IsBuiltin => !IsLeaf && (Flags & SerializedObjectParserNodeFlags.IsBuiltin) != 0;

    public readonly byte Size => Type.Size();

    public static SerializedObjectParserNode Create(
        int nodeIdx,
        ReadOnlyMemory<byte> localBuffer,
        Span<SerializedObjectTypeNode> nodes)
    {
        ref SerializedObjectTypeNode node = ref nodes[nodeIdx];

        ResolveFromNames(node, localBuffer,
            out string name,
            out string typeName,
            out SerializedObjectParserType type);

        ResolveHierarchy(node, nodes, nodeIdx,
            out ushort firstChildIdx,
            out ushort firstSiblingIdx);

        SerializedObjectParserNodeFlags flags = ResolveFlags(node, type);

        SerializedObjectParserNode parserNode = new(
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
        in SerializedObjectTypeNode node,
        ReadOnlyMemory<byte> localBuffer,
        out string name,
        out string typeName,
        out SerializedObjectParserType type)
    {
        name = FetchName(node.OffsetName, localBuffer, out ReadOnlyMemory<byte> _);
        typeName = FetchName(node.OffsetTypeName, localBuffer, out ReadOnlyMemory<byte> typeNameBytes);

        if (!SerializedObjectParserNodeUtil.HashToType.TryGetValue(
            SerializedObjectParserNodeUtil.Hash(typeNameBytes.Span),
            out SerializedObjectParserType compactType))
        {
            compactType = node.Size switch
            {
                8 => SerializedObjectParserType.S64,
                4 => SerializedObjectParserType.S32,
                2 => SerializedObjectParserType.S16,
                1 => SerializedObjectParserType.S8,
                _ => SerializedObjectParserType.Complex,
            };
        }

        type = compactType;
    }

    private static string FetchName(
        uint offset,
        ReadOnlyMemory<byte> localBuffer,
        out ReadOnlyMemory<byte> bufferRead)
    {
        const uint inGlobalBuffer = 1u << 31;
        int realOffset = (int)(offset & ~inGlobalBuffer);

        if ((offset & inGlobalBuffer) != 0)
        {
            bufferRead = SerializedTypeNames.OffsetLookupBytes[realOffset];
            return SerializedTypeNames.OffsetLookup[realOffset];
        }

        int nullTerminator = Util.FastFindNull(localBuffer.Span, realOffset);
        bufferRead = localBuffer[realOffset..nullTerminator];
        return AssetStringPool.Fetch(bufferRead);
    }

    private static void ResolveHierarchy(
        in SerializedObjectTypeNode node,
        Span<SerializedObjectTypeNode> nodes,
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

            ref SerializedObjectTypeNode otherNode = ref nodes[i];

            if (needChildIdx && otherNode.Level == childLevel) childIdx = i;
            if (needSiblingIdx && otherNode.Level == siblingLevel) siblingIdx = i;
        }

        firstChildIdx = (ushort)childIdx;
        firstSiblingIdx = (ushort)siblingIdx;
    }

    private static SerializedObjectParserNodeFlags ResolveFlags(
        in SerializedObjectTypeNode node,
        SerializedObjectParserType type)
    {
        SerializedObjectParserNodeFlags flags = SerializedObjectParserNodeFlags.None;

        if ((node.MetaFlags & (SerializedObjectTypeMetaFlags.AlignBytes | SerializedObjectTypeMetaFlags.AnyChildUsesAlignBytes)) != 0)
        {
            flags |= SerializedObjectParserNodeFlags.IsAlignTo4;
        }

        if ((node.TypeFlags & SerializedObjectTypeFlags.IsArray) != 0)
        {
            flags |= SerializedObjectParserNodeFlags.IsArray;
        }

        if ((node.TypeFlags & SerializedObjectTypeFlags.IsManagedReference) != 0)
        {
            flags |= SerializedObjectParserNodeFlags.IsRef;
        }

        if ((node.TypeFlags & SerializedObjectTypeFlags.IsManagedReferenceRegistry) != 0)
        {
            flags |= SerializedObjectParserNodeFlags.IsRefRegistry;
        }

        if ((int)type > (int)SerializedObjectParserType.Complex)
        {
            flags |= SerializedObjectParserNodeFlags.IsBuiltin;
        }    

        if (node.Size > 0)
        {
            flags |= SerializedObjectParserNodeFlags.HasSize;
        }

        return flags;
    }

    public override readonly string ToString() 
        => $"[{Index}] {Name} ({TypeName} {Type}/{Size} child:{FirstChildIdx} sibling:{FirstSiblingIdx} flags:{Flags})";
}

public static class SerializedObjectParserNodeUtil
{
    public static IReadOnlyDictionary<uint, SerializedObjectParserType> HashToType => _hashToType;

    static SerializedObjectParserNodeUtil()
    {
        _hashToType = new()
        {
            [Hash("UInt64")] = SerializedObjectParserType.U64,
            [Hash("FileSize")] = SerializedObjectParserType.U64,
            [Hash("UInt32")] = SerializedObjectParserType.U32,
            [Hash("unsigned int")] = SerializedObjectParserType.U32,
            [Hash("UInt16")] = SerializedObjectParserType.U16,
            [Hash("UInt8")] = SerializedObjectParserType.U8,

            [Hash("SInt64")] = SerializedObjectParserType.S64,
            [Hash("SInt32")] = SerializedObjectParserType.S32,
            [Hash("int")] = SerializedObjectParserType.S32,
            [Hash("TypePtr")] = SerializedObjectParserType.S32,
            [Hash("SInt16")] = SerializedObjectParserType.S16,
            [Hash("SInt8")] = SerializedObjectParserType.S8,

            [Hash("double")] = SerializedObjectParserType.F64,
            [Hash("float")] = SerializedObjectParserType.F32,

            [Hash("bool")] = SerializedObjectParserType.Bool,
            [Hash("char")] = SerializedObjectParserType.Char,

            [Hash("string")] = SerializedObjectParserType.String,
            [Hash("ReferencedObject")] = SerializedObjectParserType.RefObjectTree,
        };
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static uint Hash(string str) => Hash(Encoding.ASCII.GetBytes(str));

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static uint Hash(ReadOnlySpan<byte> str) => XXHash32.Hash(str);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static byte Size(this SerializedObjectParserType type) => type switch
    {
        SerializedObjectParserType.U64 => 8,
        SerializedObjectParserType.U32 => 4,
        SerializedObjectParserType.U16 => 2,
        SerializedObjectParserType.U8 => 1,
        SerializedObjectParserType.S64 => 8,
        SerializedObjectParserType.S32 => 4,
        SerializedObjectParserType.S16 => 2,
        SerializedObjectParserType.S8 => 1,
        SerializedObjectParserType.F64 => 8,
        SerializedObjectParserType.F32 => 4,
        SerializedObjectParserType.Bool => 1,
        SerializedObjectParserType.Char => 1,
        _ => 0
    };

    public static string Dump(this SerializedObjectParserNode node, SerializedObjectTypeTree tree)
    {
        int width = Util.CharWidth(tree.Length);

        StringBuilder sb = new();
        sb.AppendLine(string.Format($"[{{0,{width}}}] {node}", node.Level));

        int startIdx = node.FirstChildIdx;
        int endIdx = node.FirstSiblingIdx != 0 ? node.FirstSiblingIdx : tree.Length;
        for (int i = startIdx; i < endIdx; ++i)
        {
            ref SerializedObjectParserNode nextNode = ref tree[i];
            sb.AppendLine(string.Format($"[{{0,{width}}}]{new string(' ', nextNode.Level * 4)} {nextNode}", i));
        }

        return sb.ToString();
    }

    private static readonly Dictionary<uint, SerializedObjectParserType> _hashToType;
}

public enum SerializedObjectParserType : byte
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
}

[Flags]
public enum SerializedObjectParserNodeFlags : byte
{
    None = 0,
    IsAlignTo4 = 1 << 0,
    IsArray = 1 << 1,
    IsRef = 1 << 2,
    IsRefRegistry = 1 << 3,
    IsBuiltin = 1 << 4,
    HasSize = 1 << 5
}

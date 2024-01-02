using RogueTraderUnityToolkit.Core;
using System.Diagnostics;
using System.Text;

namespace RogueTraderUnityToolkit.Unity.TypeTree;

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

        Debug.Assert(!parserNode.IsPrimitive || parserNode.Size > 0);

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

        if (!ObjectParserNodeUtil.TryGetType(typeName, out ObjectParserType compactType))
        {
            compactType = ObjectParserType.Complex;
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

        return AsciiStringPool.Fetch(bufferRead.Span);
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
    // Primitive types
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

    // Complex types
    Complex,

    // Builtin types
    ReferencedObject,
    PPTr,
    String,
    Vector,
    Map,
    Pair
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
    public static bool TryGetType(AsciiString typeName, out ObjectParserType type)
    {
        if (!_stringToType.TryGetValue(typeName, out type))
        {
            if (false /*TODO span.Length >= 5 && "PPtr<"u8.SequenceEqual(span[..5])*/)
            {
                type = ObjectParserType.PPTr;
            }
            else
            {
                return false;
            }
        }

        return true;
    }

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

    public static IEnumerable<(ObjectParserType, AsciiString[])> TypeAliases => _typeMap
        .Select(x => (x.Key, x.Value));

    private static readonly Dictionary<ObjectParserType, AsciiString[]> _typeMap = new()
    {
        [ObjectParserType.U64] = [
            AsciiStringPool.Fetch("UInt64"u8),
            AsciiStringPool.Fetch("FileSize"u8)],
        [ObjectParserType.U32] = [
            AsciiStringPool.Fetch("UInt32"u8),
            AsciiStringPool.Fetch("unsigned int"u8)],
        [ObjectParserType.U16] = [
            AsciiStringPool.Fetch("UInt16"u8)],
        [ObjectParserType.U8] = [
            AsciiStringPool.Fetch("UInt8"u8)],
        [ObjectParserType.S64] = [
            AsciiStringPool.Fetch("SInt64"u8)],
        [ObjectParserType.S32] = [
            AsciiStringPool.Fetch("SInt32"u8),
            AsciiStringPool.Fetch("int"u8),
            AsciiStringPool.Fetch("Type*"u8)],
        [ObjectParserType.S16] = [
            AsciiStringPool.Fetch("SInt16"u8)],
        [ObjectParserType.S8] = [
            AsciiStringPool.Fetch("SInt8"u8)],
        [ObjectParserType.F64] = [
            AsciiStringPool.Fetch("double"u8)],
        [ObjectParserType.F32] = [
            AsciiStringPool.Fetch("float"u8)],
        [ObjectParserType.Bool] = [
            AsciiStringPool.Fetch("bool"u8)],
        [ObjectParserType.Char] = [
            AsciiStringPool.Fetch("char"u8)],
        [ObjectParserType.ReferencedObject] = [
            AsciiStringPool.Fetch("ReferencedObject"u8)],
        [ObjectParserType.String] = [
            AsciiStringPool.Fetch("string"u8)]
    };

    private static readonly Dictionary<AsciiString, ObjectParserType> _stringToType = _typeMap
        .SelectMany(pair => pair.Value, (pair, str) => new { str, pair.Key })
        .ToDictionary(item => item.str, item => item.Key);
}

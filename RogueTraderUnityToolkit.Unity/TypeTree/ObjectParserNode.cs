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

    public byte Size => Type.Size();

    public static ObjectParserNode Create(
        in ObjectTypeNode node,
        int nodeIdx,
        ReadOnlySpan<byte> localBuffer,
        ReadOnlySpan<byte> nodeLevels)
    {
        ResolveFromNames(node, localBuffer,
            out AsciiString name,
            out AsciiString typeName,
            out ObjectParserType type);

        ObjectParserNodeUtil.ResolveHierarchy(
            nodeIdx,
            node.Level,
            nodeLevels,
            out ushort firstChildIdx,
            out ushort firstSiblingIdx);

        ObjectParserNodeFlags flags = ObjectParserNodeUtil.GetParserFlags(
            node.Size,
            node.TypeFlags,
            node.MetaFlags);

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
        ReadOnlySpan<byte> localBuffer,
        out AsciiString name,
        out AsciiString typeName,
        out ObjectParserType type)
    {
        name = FetchName(node.OffsetName, localBuffer);
        typeName = FetchName(node.OffsetTypeName, localBuffer);

        if (!ObjectParserNodeUtil.TryGetType(typeName, out ObjectParserType compactType))
        {
            compactType = ObjectParserType.Complex;
        }

        type = compactType;
    }

    private static AsciiString FetchName(
        uint offset,
        ReadOnlySpan<byte> localBuffer)
    {
        const uint inGlobalBuffer = 1u << 31;
        int realOffset = (int)(offset & ~inGlobalBuffer);

        ReadOnlySpan<byte> buffer;

        if ((offset & inGlobalBuffer) == 0)
        {
            int nullTerminator = Util.FastFindByte(0, localBuffer, realOffset);
            buffer = localBuffer[realOffset..nullTerminator];
        }
        else
        {
            bool found = UnityTypeNames.TryGetValue(realOffset, out ReadOnlyMemory<byte> memory);
            Debug.Assert(found);
            buffer = memory.Span;
        }

        return AsciiString.From(buffer);
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

    Complex
}

[Flags]
public enum ObjectParserNodeFlags : byte
{
    None = 0,
    IsAlignTo4 = 1 << 0,
    IsArray = 1 << 1,
    IsRef = 1 << 2,
    IsRefRegistry = 1 << 3,
    HasSize = 1 << 4
}

public static class ObjectParserNodeUtil
{
    public static bool TryGetType(AsciiString typeName, out ObjectParserType type) =>
        _stringToType.TryGetValue(typeName, out type);

    public static ObjectParserNodeFlags GetParserFlags(
        int size,
        ObjectTypeFlags typeFlag,
        ObjectTypeMetaFlags metaFlags)
    {
        ObjectParserNodeFlags flags = ObjectParserNodeFlags.None;

        if ((metaFlags & (ObjectTypeMetaFlags.AlignBytes | ObjectTypeMetaFlags.AnyChildUsesAlignBytes)) != 0)
        {
            flags |= ObjectParserNodeFlags.IsAlignTo4;
        }

        if ((typeFlag & ObjectTypeFlags.IsArray) != 0)
        {
            flags |= ObjectParserNodeFlags.IsArray;
        }

        if ((typeFlag & ObjectTypeFlags.IsManagedReference) != 0)
        {
            flags |= ObjectParserNodeFlags.IsRef;
        }

        if ((typeFlag & ObjectTypeFlags.IsManagedReferenceRegistry) != 0)
        {
            flags |= ObjectParserNodeFlags.IsRefRegistry;
        }

        if (size > 0)
        {
            flags |= ObjectParserNodeFlags.HasSize;
        }

        return flags;
    }

    public static void ResolveHierarchy(
        int nodeIdx,
        byte nodeLevel,
        ReadOnlySpan<byte> allNodeLevels,
        out ushort firstChildIdx,
        out ushort firstSiblingIdx)
    {
        int childIdx = 0;
        int siblingIdx = 0;

        int childLevel = nodeLevel + 1;
        int siblingLevel = nodeLevel;

        for (int i = nodeIdx + 1; i < allNodeLevels.Length; i++)
        {
            bool needChildIdx = childIdx == 0;
            bool needSiblingIdx = siblingIdx == 0;

            if (!needSiblingIdx) break;

            int otherNodeLevel = allNodeLevels[i];

            if (needChildIdx && otherNodeLevel == childLevel) childIdx = i;
            if (needSiblingIdx && otherNodeLevel == siblingLevel) siblingIdx = i;
        }

        firstChildIdx = (ushort)childIdx;
        firstSiblingIdx = (ushort)siblingIdx;
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

    public static Dictionary<ObjectParserType, AsciiString[]> TypeMap => _typeMap;

    private static readonly Dictionary<ObjectParserType, AsciiString[]> _typeMap = new()
    {
        [ObjectParserType.U64] = [
            AsciiString.From("UInt64"u8),
            AsciiString.From("FileSize"u8)],
        [ObjectParserType.U32] = [
            AsciiString.From("unsigned int"u8),
            AsciiString.From("UInt32"u8)],
        [ObjectParserType.U16] = [
            AsciiString.From("UInt16"u8)],
        [ObjectParserType.U8] = [
            AsciiString.From("UInt8"u8)],
        [ObjectParserType.S64] = [
            AsciiString.From("SInt64"u8)],
        [ObjectParserType.S32] = [
            AsciiString.From("int"u8),
            AsciiString.From("SInt32"u8),
            AsciiString.From("Type*"u8)],
        [ObjectParserType.S16] = [
            AsciiString.From("SInt16"u8)],
        [ObjectParserType.S8] = [
            AsciiString.From("SInt8"u8)],
        [ObjectParserType.F64] = [
            AsciiString.From("double"u8)],
        [ObjectParserType.F32] = [
            AsciiString.From("float"u8)],
        [ObjectParserType.Bool] = [
            AsciiString.From("bool"u8)],
        [ObjectParserType.Char] = [
            AsciiString.From("char"u8)]
    };

    private static readonly Dictionary<AsciiString, ObjectParserType> _stringToType = _typeMap
        .SelectMany(pair => pair.Value, (pair, str) => new { str, pair.Key })
        .ToDictionary(item => item.str, item => item.Key);
}

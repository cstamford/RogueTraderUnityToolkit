using RogueTraderUnityToolkit.Core;
using System.Diagnostics;
using System.Text;

namespace RogueTraderUnityToolkit.Unity.TypeTree;

public sealed class ObjectParserDebug(Func<int> fnReadParserOffset) : ObjectTypeTreeReaderBase
{
    public override void BeginTree(
        in ObjectTypeTree tree)
    {
        _indentStack.Push(_indent);
        Log.Write(_indent++ * _spacesPerIndent, "BeginTree", ConsoleColor.Green);
    }

    public override void EndTree(
        in ObjectTypeTree tree)
    {
        _indent = _indentStack.Pop();
        Log.Write(_indent * _spacesPerIndent, "EndTree", ConsoleColor.Green);

        if (_indentStack.Count == 0)
        {
            _lastOffset = 0;
        }
    }

    public override void BeginNode(
        in ObjectParserNode node,
        in ObjectTypeTree tree)
    {
        _indent = node.Level;

        string nodeString = node.ToString();
        string nodeNameString = node.Name.ToString();
        int nodeNameIdx = nodeString.IndexOf(nodeNameString, StringComparison.Ordinal);
        Debug.Assert(nodeNameIdx != -1);

        Log.Write(_indent * _spacesPerIndent,
            new LogEntry(nodeString[..nodeNameIdx], _col),
            new LogEntry(nodeNameString, ConsoleColor.White),
            new LogEntry(nodeString[(nodeNameIdx + node.Name.Length)..], _col));
    }

    public override void ReadPrimitive(
        in ObjectParserNode node,
        in ObjectParserReader nodeReader)
    {
        string value = ReadPrimitiveAsString(nodeReader, node);
        Log.Write((_indent + 1) * _spacesPerIndent,
            new LogEntry("ReadPrimitive", ConsoleColor.Blue),
            new LogEntry($" {Range()} => ", _col),
            new LogEntry(value, ConsoleColor.Blue));
    }

    public override void ReadPrimitiveArray(
        in ObjectParserNode node,
        in ObjectParserNode dataNode,
        in ObjectParserReader nodeReader,
        int arrayLength)
    {
        const int maxLen = 4;
        string str = ReadPrimitiveArrayAsString(nodeReader, node, arrayLength, maxLen);

        int remainingElements = arrayLength - maxLen;
        int remainingBytes = 0;

        if (remainingElements > 0)
        {
            str += " ...";
            remainingBytes = remainingElements * dataNode.Size;
        }

        Log.Write((_indent + 1) * _spacesPerIndent,
            new LogEntry($"ReadPrimitiveArray", ConsoleColor.DarkYellow),
            new LogEntry($" {dataNode.Type}[{arrayLength}]"),
            new LogEntry($" {Range(remainingBytes)} => [", _col),
            new LogEntry(str, ConsoleColor.DarkYellow),
            new LogEntry($"]", _col));
    }

    public override void ReadComplexArray(
        in ObjectParserNode node,
        in ObjectParserNode dataNode,
        int arrayLength)
    {
        Log.Write((_indent + 1) * _spacesPerIndent,
            new LogEntry($"ReadComplexArray", ConsoleColor.Yellow),
            new LogEntry($" {dataNode.TypeName}[{arrayLength}]", _col),
            new LogEntry($" {Range()} => [", _col),
            new LogEntry($"(nodes follow)", ConsoleColor.Yellow),
            new LogEntry($"]", _col));
    }

    public override void ReadReferencedObject(
        in ObjectParserNode node,
        long refId,
        AsciiString cls,
        AsciiString ns,
        AsciiString asm)
    {
        Log.Write((_indent + 1) * _spacesPerIndent,
            new LogEntry($"ReadReferencedObject", ConsoleColor.Green),
            new LogEntry($" {Range()} => [", _col),
            new LogEntry($"{refId} {asm}:{ns}.{cls}", ConsoleColor.Green),
            new LogEntry($"]", _col));
    }

    public override void Align(
        in ObjectParserNode node,
        int alignedBytes)
    {
        bool didAlign = alignedBytes != 0;
        Log.Write(_indent * _spacesPerIndent,
            new LogEntry($"{node.TypeName} Align4", didAlign ? ConsoleColor.Magenta : _col),
            new LogEntry(didAlign ? $" {Range()}" : string.Empty, _col));
    }

    private int _indent;
    private readonly Stack<int> _indentStack = [];
    private const int _spacesPerIndent = 4;
    private const ConsoleColor _col = ConsoleColor.DarkGray;
    private int _lastOffset;

    private int Offset => fnReadParserOffset();

    private string Range(int remaining = 0)
    {
        string message = remaining == 0 ?
            $"<{_lastOffset}..{Offset}>" :
            $"<{_lastOffset}..{Offset}+{remaining}..>";

        if (Offset == _lastOffset)
        {
            message += " (PEEKING)";
        }

        _lastOffset = Offset;
        return message;
    }

    private static unsafe string ReadPrimitiveArrayAsString(
        ObjectParserReader reader,
        in ObjectParserNode node,
        int arrayLength,
        int readLength = -1,
        string separator = ", ")
    {
        ObjectParserType type = reader.Type;
        int sizePerElement = type.Size();
        int chunkSize = sizePerElement * Math.Min(256, readLength != -1 ? readLength : 64);
        byte* buffer = stackalloc byte[chunkSize + sizePerElement];
        buffer = Memory.AlignTo(buffer, sizePerElement);

        StringBuilder sb = new();

        reader.ReadPrimitiveArray(node, arrayLength, new(buffer, chunkSize), (start, end) =>
        {
            for (int i = 0; i < end - start; ++i)
            {
                byte* elem = buffer + i * sizePerElement;

                sb.Append(type switch
                {
                    ObjectParserType.U64 => (*(ulong*)elem).ToString(),
                    ObjectParserType.U32 => (*(uint*)elem).ToString(),
                    ObjectParserType.U16 => (*(ushort*)elem).ToString(),
                    ObjectParserType.U8 => (*elem).ToString(),
                    ObjectParserType.S64 => (*(long*)elem).ToString(),
                    ObjectParserType.S32 => (*(int*)elem).ToString(),
                    ObjectParserType.S16 => (*(short*)elem).ToString(),
                    ObjectParserType.S8 => (*(sbyte*)elem).ToString(),
                    ObjectParserType.F64 => (*(double*)elem).ToString("R"),
                    ObjectParserType.F32 => (*(float*)elem).ToString("R"),
                    ObjectParserType.Bool => (*elem != 0) ? "true" : "false",
                    ObjectParserType.Char => Convert.ToChar(*(elem)).ToString(),
                    _ => string.Empty
                });

                sb.Append(separator);
            }

            return end != readLength;
        });

        if (sb.Length != 0) // remove trailing separator
        {
            sb.Length -= separator.Length;
        }

        return sb.ToString();
    }

    private static string ReadPrimitiveAsString(
        ObjectParserReader reader,
        in ObjectParserNode node) => node.Type switch
    {
        ObjectParserType.U64 => reader.ReadU64(node).ToString(),
        ObjectParserType.U32 => reader.ReadU32(node).ToString(),
        ObjectParserType.U16 => reader.ReadU16(node).ToString(),
        ObjectParserType.U8 => reader.ReadU8(node).ToString(),
        ObjectParserType.S64 => reader.ReadS64(node).ToString(),
        ObjectParserType.S32 => reader.ReadS32(node).ToString(),
        ObjectParserType.S16 => reader.ReadS16(node).ToString(),
        ObjectParserType.S8 => reader.ReadS8(node).ToString(),
        ObjectParserType.F64 => reader.ReadF64(node).ToString("R"),
        ObjectParserType.F32 => reader.ReadF32(node).ToString("R"),
        ObjectParserType.Bool => reader.ReadBool(node) ? "true" : "false",
        ObjectParserType.Char => reader.ReadChar(node).ToString(),
        _ => string.Empty
    };
};

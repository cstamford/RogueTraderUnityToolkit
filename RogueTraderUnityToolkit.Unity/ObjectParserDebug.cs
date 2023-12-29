using RogueTraderUnityToolkit.Core;
using System.Diagnostics;

namespace RogueTraderUnityToolkit.Unity;

public sealed class ObjectParserDebug(
    Func<int> fnReadParserOffset)
    : IObjectTypeTreeReader
{
    public void BeginTree(
        in ObjectTypeTree tree)
    {
        _indentStack.Push(_indent);
        Log.Write(_indent++ * _spacesPerIndent, "BeginTree", ConsoleColor.Green);
    }

    public void EndTree(
        in ObjectTypeTree tree)
    {
        _indent = _indentStack.Pop();
        Log.Write(_indent * _spacesPerIndent, "EndTree", ConsoleColor.Green);   
        
        if (_indentStack.Count == 0)
        {
            _lastOffset = 0;
        }
    }

    public void Visit(
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

    public void ReadPrimitive(
        in ObjectParserNode node,
        in ObjectParserReader nodeReader)
    {
        string value = nodeReader.ReadPrimitiveAsString(node);
        Log.Write((_indent + 1) * _spacesPerIndent,
            new LogEntry("ReadPrimitive", ConsoleColor.Blue),
            new LogEntry($" {Range()} => ", _col),
            new LogEntry(value, ConsoleColor.Blue));
    }

    public void ReadPrimitiveArray(
        in ObjectParserNode node,
        in ObjectParserNode dataNode,
        in ObjectParserReader nodeReader,
        int arrayLength)
    {
        const int maxLen = 4;
        string str = nodeReader.ReadPrimitiveArrayAsString(node, arrayLength, maxLen);

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

    public void ReadComplexArray(
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

    public void ReadString(
        in ObjectParserNode node,
        in ObjectParserReader nodeReader,
        int stringLength)
    {
        const int maxLen = 32;
        string str = nodeReader.ReadString(node, stringLength, maxLen).ToString();

        int remainingElements = stringLength - maxLen;
        int remainingBytes = 0;

        if (remainingElements > 0)
        {
            str += " ...";
            remainingBytes = remainingElements;
        }

        Log.Write((_indent + 1) * _spacesPerIndent,
            new LogEntry($"ReadString", ConsoleColor.Cyan),
            new LogEntry($" char[{stringLength}]", _col),
            new LogEntry($" {Range(remainingBytes)} => \"", _col),
            new LogEntry(str, ConsoleColor.Cyan),
            new LogEntry($"\"", _col));
    }

    public void ReadRefObjectRegistry(
        in ObjectParserNode node,
        long refId,
        AsciiString cls,
        AsciiString ns,
        AsciiString asm)
    {
        Log.Write((_indent + 1) * _spacesPerIndent,
            new LogEntry($"ReadRefObjectRegistry", ConsoleColor.Green),
            new LogEntry($" {Range()} => [", _col),
            new LogEntry($"{refId} {asm}:{ns}.{cls}", ConsoleColor.Green),
            new LogEntry($"]", _col));
    }

    public void Align(
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

        Debug.Assert(Offset > _lastOffset);
        _lastOffset = Offset;

        return message;
    }
};

// Wraps ObjectDebugReader to allow easy toggling of conditional logging
public sealed class ObjectParserDebugWrapper(
    Func<int> fnReadParserOffset)
    : IObjectTypeTreeReader
{
    public void BeginTree(
        in ObjectTypeTree tree)
    {
        if (Enabled) _reader.BeginTree(tree);
    }

    public void EndTree(
        in ObjectTypeTree tree)
    {
        if (Enabled) _reader.EndTree(tree);
    }

    public void Visit(
        in ObjectParserNode node,
        in ObjectTypeTree tree)
    {
        if (Enabled) _reader.Visit(node, tree);
    }

    public void ReadPrimitive(
        in ObjectParserNode node,
        in ObjectParserReader nodeReader)
    {
        if (Enabled) _reader.ReadPrimitive(node, nodeReader);
    }

    public void ReadPrimitiveArray(
        in ObjectParserNode node,
        in ObjectParserNode dataNode,
        in ObjectParserReader nodeReader,
        int arrayLength)
    {
        if (Enabled) _reader.ReadPrimitiveArray(node, dataNode, nodeReader, arrayLength);
    }

    public void ReadComplexArray(
        in ObjectParserNode node,
        in ObjectParserNode dataNode,
        int arrayLength)
    {
        if (Enabled) _reader.ReadComplexArray(node, dataNode, arrayLength);
    }

    public void ReadString(
        in ObjectParserNode node,
        in ObjectParserReader nodeReader,
        int stringLength)
    {
        if (Enabled) _reader.ReadString(node, nodeReader, stringLength);
    }

    public void ReadRefObjectRegistry(
        in ObjectParserNode node,
        long refId,
        AsciiString cls,
        AsciiString ns,
        AsciiString asm)
    {
        if (Enabled) _reader.ReadRefObjectRegistry(node, refId, cls, ns, asm);
    }

    public void Align(
        in ObjectParserNode node,
        int alignedBytes)
    {
        if (Enabled) _reader.Align(node, alignedBytes);
    }

    private bool Enabled => true /* insert debug conditions here, like: _depth > 1*/;

    private readonly ObjectParserDebug _reader = new(fnReadParserOffset);
};

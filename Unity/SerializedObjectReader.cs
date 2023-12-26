using RogueTraderUnityToolkit.Helper;
using System.Diagnostics;
using System.Xml.Linq;

namespace RogueTraderUnityToolkit.Unity;

public interface ISerializedObjectReader
{
    public void BeginTree(
        in SerializedObjectTypeTree tree);

    public void EndTree(
        in SerializedObjectTypeTree tree);

    public void Visit(
        in SerializedObjectParserNode node,
        in SerializedObjectTypeTree tree);

    public void ReadPrimitive(
        in SerializedObjectParserNode node,
        in SerializedObjectParserNodeReader nodeReader);

    public void ReadPrimitiveArray(
        in SerializedObjectParserNode node,
        in SerializedObjectParserNode dataNode,
        in SerializedObjectParserNodeReader nodeReader,
        int arrayLength);

    public void ReadComplexArray(
        in SerializedObjectParserNode node,
        in SerializedObjectParserNode dataNode,
        int arrayLength);

    public void ReadString(
        in SerializedObjectParserNode node,
        in SerializedObjectParserNodeReader nodeReader,
        int stringLength);

    public void ReadRefObjectRegistry(
        in SerializedObjectParserNode node,
        long refId, string cls, string ns, string asm);

    public void Align(
        in SerializedObjectParserNode node,
        int alignedBytes);
};

public sealed class SerializedObjectMultiReader(
    ISerializedObjectReader[] readers) : ISerializedObjectReader
{
    public void BeginTree(
        in SerializedObjectTypeTree tree)
    {
        foreach (ISerializedObjectReader reader in readers) { reader.BeginTree(tree); }
    }

    public void EndTree(
        in SerializedObjectTypeTree tree)
    {
        foreach (ISerializedObjectReader reader in readers) { reader.EndTree(tree); }
    }

    public void Visit(
        in SerializedObjectParserNode node,
        in SerializedObjectTypeTree tree)
    {
        foreach (ISerializedObjectReader reader in readers) { reader.Visit(node, tree); }
    }

    public void ReadPrimitive(
        in SerializedObjectParserNode node,
        in SerializedObjectParserNodeReader nodeReader)
    {
        foreach (ISerializedObjectReader reader in readers) { reader.ReadPrimitive(node, nodeReader); };
    }

    public void ReadPrimitiveArray(
        in SerializedObjectParserNode node,
        in SerializedObjectParserNode dataNode,
        in SerializedObjectParserNodeReader nodeReader,
        int arrayLength)
    {
        foreach (ISerializedObjectReader reader in readers) { reader.ReadPrimitiveArray(node, dataNode, nodeReader, arrayLength); };
    }

    public void ReadComplexArray(
        in SerializedObjectParserNode node,
        in SerializedObjectParserNode dataNode,
        int arrayLength)
    {
        foreach (ISerializedObjectReader reader in readers) { reader.ReadComplexArray(node, dataNode, arrayLength); };
    }

    public void ReadString(
        in SerializedObjectParserNode node,
        in SerializedObjectParserNodeReader nodeReader,
        int stringLength)
    {
        foreach (ISerializedObjectReader reader in readers) { reader.ReadString(node, nodeReader, stringLength); };
    }

    public void ReadRefObjectRegistry(
        in SerializedObjectParserNode node,
        long refId, string cls, string ns, string asm)
    {
        foreach (ISerializedObjectReader reader in readers) { reader.ReadRefObjectRegistry(node, refId, cls, ns, asm); };
    }

    public void Align(
        in SerializedObjectParserNode node,
        int alignedBytes)
    {
        foreach (ISerializedObjectReader reader in readers) { reader.Align(node, alignedBytes); }
    }
}

public sealed class SerializedObjectDebugReader(
    Func<int> fnReadParserOffset) : ISerializedObjectReader
{
    public void BeginTree(
        in SerializedObjectTypeTree tree)
    {
        _indentStack.Push(_indent);
        LogDebug.Write(_indent++ * _spacesPerIndent, "BeginTree", ConsoleColor.Green);
    }

    public void EndTree(
        in SerializedObjectTypeTree tree)
    {
        _indent = _indentStack.Pop();
        LogDebug.Write(_indent * _spacesPerIndent, "EndTree", ConsoleColor.Green);   
        
        if (_indentStack.Count == 0)
        {
            _lastOffset = 0;
        }
    }

    public void Visit(
        in SerializedObjectParserNode node,
        in SerializedObjectTypeTree tree)
    {
        _indent = node.Level;

        string nodeString = node.ToString();
        int nodeNameIdx = nodeString.IndexOf(node.Name);
        Debug.Assert(nodeNameIdx != -1);

        LogDebug.Write(_indent * _spacesPerIndent,
            new LogEntry(nodeString[..nodeNameIdx], _col),
            new LogEntry(node.Name, ConsoleColor.White),
            new LogEntry(nodeString[(nodeNameIdx + node.Name.Length)..], _col));
    }

    public void ReadPrimitive(
        in SerializedObjectParserNode node,
        in SerializedObjectParserNodeReader nodeReader)
    {
        string value = nodeReader.ReadPrimitiveAsString(node);
        LogDebug.Write((_indent + 1) * _spacesPerIndent,
            new LogEntry("ReadPrimitive", ConsoleColor.Blue),
            new LogEntry($" {Range()} => ", _col),
            new LogEntry(value, ConsoleColor.Blue));
    }

    public void ReadPrimitiveArray(
        in SerializedObjectParserNode node,
        in SerializedObjectParserNode dataNode,
        in SerializedObjectParserNodeReader nodeReader,
        int arrayLength)
    {
        int maxLen = 4;
        string str = nodeReader.ReadPrimitiveArrayAsString(node, arrayLength, maxLen);

        int remainingElements = arrayLength - maxLen;
        int remainingBytes = 0;

        if (remainingElements > 0)
        {
            str += " ...";
            remainingBytes = remainingElements * dataNode.Size;
        }

        LogDebug.Write((_indent + 1) * _spacesPerIndent,
            new LogEntry("ReadPrimitiveArray", ConsoleColor.DarkYellow),
            new LogEntry($" {dataNode.Type}[{arrayLength}]"),
            new LogEntry($" {Range(remainingBytes)} => [", _col),
            new LogEntry(str, ConsoleColor.DarkYellow),
            new LogEntry("]", _col));
    }

    public void ReadComplexArray(
        in SerializedObjectParserNode node,
        in SerializedObjectParserNode dataNode,
        int arrayLength)
    {
        LogDebug.Write((_indent + 1) * _spacesPerIndent,
            new LogEntry("ReadComplexArray", ConsoleColor.Yellow),
            new LogEntry($" {dataNode.TypeName}[{arrayLength}]", _col),
            new LogEntry($" {Range()} => [", _col),
            new LogEntry("(nodes follow)", ConsoleColor.Yellow),
            new LogEntry("]", _col));
    }

    public void ReadString(
        in SerializedObjectParserNode node,
        in SerializedObjectParserNodeReader nodeReader,
        int stringLength)
    {
        int maxLen = 32;
        string str = nodeReader.ReadString(node, stringLength, maxLen);

        int remainingElements = stringLength - maxLen;
        int remainingBytes = 0;

        if (remainingElements > 0)
        {
            str += " ...";
            remainingBytes = remainingElements;
        }

        LogDebug.Write((_indent + 1) * _spacesPerIndent,
            new LogEntry($"ReadString", ConsoleColor.Cyan),
            new LogEntry($" char[{stringLength}]", _col),
            new LogEntry($" {Range(remainingBytes)} => \"", _col),
            new LogEntry(str, ConsoleColor.Cyan),
            new LogEntry($"\"", _col));
    }

    public void ReadRefObjectRegistry(
        in SerializedObjectParserNode node,
        long refId, string cls, string ns, string asm)
    {
        LogDebug.Write((_indent + 1) * _spacesPerIndent,
            new LogEntry($"ReadRefObjectRegistry", ConsoleColor.White),
            new LogEntry($" {Range()} => [", _col),
            new LogEntry($"{refId} {asm}:{ns}.{cls}", ConsoleColor.White),
            new LogEntry($"]", _col));
    }

    public void Align(
        in SerializedObjectParserNode node,
        int alignedBytes)
    {
        bool didAlign = alignedBytes != 0;
        LogDebug.Write(_indent * _spacesPerIndent,
            new LogEntry($"{node.TypeName} Align4", didAlign ? ConsoleColor.Magenta : _col),
            new LogEntry(didAlign ? $" {Range()}" : string.Empty, _col));
    }

    private int Offset => fnReadParserOffset();
    private int _lastOffset = 0;

    private string Range(int remaining = 0)
    {
        string message = remaining == 0 ?
            $"<{_lastOffset}..{Offset}>" :
            $"<{_lastOffset}..{Offset}+{remaining}..>";

        Debug.Assert(Offset > _lastOffset);
        _lastOffset = Offset;

        return message;
    }

    private const int _spacesPerIndent = 4;
    private const ConsoleColor _col = ConsoleColor.DarkGray;

    private int _indent = 0;
    private readonly Stack<int> _indentStack = [];
};

// Wraps SerializedObjectDebugReader to allow easy toggling of conditional logging
public sealed class SerializedObjectConditionalDebugReader(
    Func<int> fnReadParserOffset) : ISerializedObjectReader
{
    public void BeginTree(
        in SerializedObjectTypeTree tree)
    {
        ++_depth;
        if (Enabled) _reader.BeginTree(tree);
    }

    public void EndTree(
        in SerializedObjectTypeTree tree)
    {
        if (Enabled) _reader.EndTree(tree);
        --_depth;
    }

    public void Visit(
        in SerializedObjectParserNode node,
        in SerializedObjectTypeTree tree)
    {
        if (Enabled) _reader.Visit(node, tree);
    }

    public void ReadPrimitive(
        in SerializedObjectParserNode node,
        in SerializedObjectParserNodeReader nodeReader)
    {
        if (Enabled) _reader.ReadPrimitive(node, nodeReader);
    }

    public void ReadPrimitiveArray(
        in SerializedObjectParserNode node,
        in SerializedObjectParserNode dataNode,
        in SerializedObjectParserNodeReader nodeReader,
        int arrayLength)
    {
        if (Enabled) _reader.ReadPrimitiveArray(node, dataNode, nodeReader, arrayLength);
    }

    public void ReadComplexArray(
        in SerializedObjectParserNode node,
        in SerializedObjectParserNode dataNode,
        int arrayLength)
    {
        if (Enabled) _reader.ReadComplexArray(node, dataNode, arrayLength);
    }

    public void ReadString(
        in SerializedObjectParserNode node,
        in SerializedObjectParserNodeReader nodeReader,
        int stringLength)
    {
        if (Enabled) _reader.ReadString(node, nodeReader, stringLength);
    }

    public void ReadRefObjectRegistry(
        in SerializedObjectParserNode node,
        long refId, string cls, string ns, string asm)
    {
        if (Enabled) _reader.ReadRefObjectRegistry(node, refId, cls, ns, asm);
    }

    public void Align(
        in SerializedObjectParserNode node,
        int alignedBytes)
    {
        if (Enabled) _reader.Align(node, alignedBytes);
    }

    private bool Enabled => true /* insert debug conditions here, like: _depth > 1*/;
    private int _depth = 0;

    private readonly SerializedObjectDebugReader _reader = new(fnReadParserOffset);
};

public sealed class SerializedObjectNullReader : ISerializedObjectReader
{
    public void BeginTree(
      in SerializedObjectTypeTree tree)
    { } 

    public void EndTree(
        in SerializedObjectTypeTree tree)
    { }

    public void Visit(
        in SerializedObjectParserNode node,
        in SerializedObjectTypeTree tree)
    { }

    public void ReadPrimitive(
        in SerializedObjectParserNode node,
        in SerializedObjectParserNodeReader nodeReader)
    { }

    public void ReadPrimitiveArray(
        in SerializedObjectParserNode node,
        in SerializedObjectParserNode dataNode,
        in SerializedObjectParserNodeReader nodeReader,
        int arrayLength)
    { }

    public void ReadComplexArray(
        in SerializedObjectParserNode node,
        in SerializedObjectParserNode dataNode,
        int arrayLength)
    { }

    public void ReadString(
        in SerializedObjectParserNode node,
        in SerializedObjectParserNodeReader nodeReader,
        int stringLength)
    { }

    public void ReadRefObjectRegistry(
        in SerializedObjectParserNode node,
        long refId, string cls, string ns, string asm)
    { }

    public void Align(
        in SerializedObjectParserNode node,
        int alignedBytes)
    { }
}

using RogueTraderUnityToolkit.Core;
using RogueTraderUnityToolkit.Unity;
using System.Buffers;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace RogueTraderUnityToolkit.Readers;

public sealed class TypeTreeTextExporter
    : IObjectTypeTreeReader
{
    public Stream Stream
    {
        set => _writer = new(value);
    }
    
    public void BeginTree(
        in ObjectTypeTree tree)
    {
        if (_treeNodeStacks.Count == 0)
        {
            _builder.Buffer = ArrayPool<byte>.Shared.Rent(1024);
        }
        
        _treeNodeStacks.Push([]);
        _treeArrayStacks.Push([]);
    }

    public void EndTree(
        in ObjectTypeTree tree)
    {
        Stack<NodeFrame> prevNodeStack = _treeNodeStacks.Pop();
        Stack<ArrayFrame> prevArrayStack = _treeArrayStacks.Pop();

        if (_treeNodeStacks.Count == 0)
        {
            _treeNodeStacks.Clear();
            _treeArrayStacks.Clear();
            _arrayIndices.Clear();
            
            ArrayPool<byte>.Shared.Return(_builder.Buffer);
            _builder.Index = 0;
            
            return;
        }

        PopNodeFramesForStack(prevNodeStack, 0, out NodeFrame _);
        PopArrayFramesForStack(prevArrayStack, 0, out ArrayFrame _);
    }

    [MethodImpl(MethodImplOptions.AggressiveOptimization)]
    public void Visit(
        in ObjectParserNode node,
        in ObjectTypeTree tree)
    {
        if (PopNodeFrames(node, out NodeFrame nodeFrame))
        {
            _builder.Index = nodeFrame.BuilderIndex;
            _builder.Append(':');
            _builder.Append(node.Name);
        }
        else
        {
            _builder.Append('$');
            _builder.Append('[');
            _builder.Append(node.TypeName);
            _builder.Append(']');
        }

        if (PopArrayFrames(node, out ArrayFrame arrayFrame) &&
            node.Index == arrayFrame.ArrayDataNodeIndex)
        {
            _builder.Append('[');
            _builder.Append(_arrayIndices[arrayFrame.ArrayIndexListOffset]++);
            _builder.Append(']');
        }

        TreeNodeStack.Push(new(
            BuilderIndex: (ushort)_builder.Index,
            NodeLevel: node.Level));
    }

    public void ReadPrimitive(
        in ObjectParserNode node,
        in ObjectParserReader nodeReader)
    {
        _writer.Write(_builder.Buffer.AsSpan(0, _builder.Index));
        _writer.Write('$');
        _writer.Write(_typePoolEntries[node.Type]);
        _writer.Write(' ');
        _writer.Write('=');
        _writer.Write(' ');

        switch (node.Type)
        {
            case ObjectParserType.U64:
                _writer.Write(nodeReader.ReadU64(node));
                break;

            case ObjectParserType.U32:
                _writer.Write(nodeReader.ReadU32(node));
                break;

            case ObjectParserType.U16:
                _writer.Write(nodeReader.ReadU16(node));
                break;

            case ObjectParserType.U8:
                _writer.Write(nodeReader.ReadU8(node));
                break;

            case ObjectParserType.S64:
                _writer.Write(nodeReader.ReadS64(node));
                break;

            case ObjectParserType.S32:
                _writer.Write(nodeReader.ReadS32(node));
                break;

            case ObjectParserType.S16:
                _writer.Write(nodeReader.ReadS16(node));
                break;

            case ObjectParserType.S8:
                _writer.Write(nodeReader.ReadS8(node));
                break;

            case ObjectParserType.F64:
                _writer.Write(nodeReader.ReadF64(node));
                break;

            case ObjectParserType.F32:
                _writer.Write(nodeReader.ReadF32(node));
                break;

            case ObjectParserType.Bool:
                _writer.Write(nodeReader.ReadBool(node));
                break;

            case ObjectParserType.Char:
                _writer.Write(nodeReader.ReadChar(node));
                break;

            default:
                Debug.Assert(false);
                break;
        }

        _writer.Write('\n');
    }

    public void ReadPrimitiveArray(
        in ObjectParserNode node,
        in ObjectParserNode dataNode,
        in ObjectParserReader nodeReader,
        int arrayLength)
    {
        _writer.Write(_builder.Buffer.AsSpan(0, _builder.Index));
        _writer.Write('$');
        _writer.Write(_typePoolEntries[node.Type]);
        _writer.Write('<');
        _writer.Write(arrayLength);
        _writer.Write('>');
        _writer.Write(' ');
        _writer.Write('=');
        _writer.Write(' ');
        _writer.Write(_dataNotIncluded);
        _writer.Write('\n');
    }

    public void ReadComplexArray(
        in ObjectParserNode node,
        in ObjectParserNode dataNode,
        int arrayLength)
    {
        TreeArrayStack.Push(new(
            ArrayDataNodeIndex: dataNode.Index,
            ArrayNodeLevel: node.Level,
            ArrayIndexListOffset: (byte)_arrayIndices.Count));

        _arrayIndices.Add(0);
    }

    public void ReadString(
        in ObjectParserNode node,
        in ObjectParserReader nodeReader,
        int stringLength)
    {
        _writer.Write(_builder.Buffer.AsSpan(0, _builder.Index));
        _writer.Write('$');
        _writer.Write(_typePoolEntries[node.Type]);
        _writer.Write('<');
        _writer.Write(stringLength);
        _writer.Write('>');
        _writer.Write(' ');
        _writer.Write('=');
        _writer.Write(' ');
        _writer.Write('\"');
        _writer.Write(nodeReader.ReadString(node, stringLength, readLength: 128));
        _writer.Write('\"');
        _writer.Write('\n');
    }

    public void ReadRefObjectRegistry(
        in ObjectParserNode node,
        long refId,
        StringPool.Entry cls,
        StringPool.Entry ns,
        StringPool.Entry asm)
    {
        _writer.Write(_builder.Buffer.AsSpan(0, _builder.Index));
        _writer.Write('$');
        _writer.Write(_typePoolEntries[node.Type]);
        _writer.Write(' ');
        _writer.Write('=');
        _writer.Write(' ');
        _writer.Write('[');
        _writer.Write(' ');
        _writer.Write(refId);
        _writer.Write(',');
        _writer.Write(' ');
        _writer.Write(asm);
        _writer.Write(',');
        _writer.Write(' ');
        _writer.Write(ns);
        _writer.Write(',');
        _writer.Write(' ');
        _writer.Write(cls);
        _writer.Write(' ');
        _writer.Write(']');
        _writer.Write('\n');
    }

    public void Align(
        in ObjectParserNode node,
        int alignedBytes)
    { }
    
    private Stack<NodeFrame> TreeNodeStack => _treeNodeStacks.Peek();
    private Stack<ArrayFrame> TreeArrayStack => _treeArrayStacks.Peek();
    
    private FastTextWriter _writer;

    private readonly FastStringBuilder _builder = new();
    private readonly Stack<Stack<NodeFrame>> _treeNodeStacks = [];
    private readonly Stack<Stack<ArrayFrame>> _treeArrayStacks = [];
    private readonly List<uint> _arrayIndices = [];

    private static StringPool.Entry _dataNotIncluded = StringPool.Fetch("[ (data not included) ]");

    private static Dictionary<ObjectParserType, StringPool.Entry> _typePoolEntries =
        Enum.GetValues<ObjectParserType>()
            .Zip(Enum.GetNames<ObjectParserType>(), (value, name) => (value, StringPool.Fetch(name)))
            .ToDictionary();

    private bool PopNodeFrames(
        in ObjectParserNode node,
        out NodeFrame frame)
    {
        return PopNodeFramesForStack(TreeNodeStack, node.Level, out frame);
    }

    private static bool PopNodeFramesForStack(
        Stack<NodeFrame> treeStack,
        int nodeLevel,
        out NodeFrame frame)
    {
        bool hasFrame;

        while (true)
        {
            hasFrame = treeStack.TryPeek(out frame);
            if (!hasFrame) break;
            if (nodeLevel > frame.NodeLevel) break;
            treeStack.Pop();
        }

        return hasFrame;
    }

    private bool PopArrayFrames(
        in ObjectParserNode node,
        out ArrayFrame frame)
    {
        return PopArrayFramesForStack(TreeArrayStack, node.Level, out frame);
    }

    private static bool PopArrayFramesForStack(
        Stack<ArrayFrame> arrayStack,
        int nodeLevel,
        out ArrayFrame frame)
    {
        bool hasFrame;

        while (true)
        {
            hasFrame = arrayStack.TryPeek(out frame);
            if (!hasFrame) break;
            if (nodeLevel > frame.ArrayNodeLevel) break;
            arrayStack.Pop();
        }

        return hasFrame;
    }
    
    private record struct NodeFrame(
        ushort BuilderIndex,
        byte NodeLevel);

    private record struct ArrayFrame(
        ushort ArrayDataNodeIndex,
        byte ArrayNodeLevel,
        byte ArrayIndexListOffset);
}


using RogueTraderUnityToolkit.Unity;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text;

namespace RogueTraderUnityToolkit.Readers;

public sealed class TypeTreeTextReader(
    TextWriter writer,
    Action fnFinishedOne)
    : IObjectTypeTreeReader
{
    public void BeginTree(
        in ObjectTypeTree tree)
    {
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
            fnFinishedOne();

            _treeNodeStacks.Clear();
            _treeArrayStacks.Clear();
            _arrayIndices.Clear();
            _localBuilder.Length = 0;

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
            _localBuilder.Length = nodeFrame.LocalBuilderLength;
            _localBuilder.Append(':');
            _localBuilder.Append(node.Name);
        }
        else
        {
            _localBuilder.Append('$');
            _localBuilder.Append('[');
            _localBuilder.Append(node.TypeName);
            _localBuilder.Append(']');
        }

        if (PopArrayFrames(node, out ArrayFrame arrayFrame) &&
            node.Index == arrayFrame.ArrayDataNodeIndex)
        {
            _localBuilder.Append('[');
            _localBuilder.Append(_arrayIndices[arrayFrame.ArrayIndexListOffset]++);
            _localBuilder.Append(']');
        }

        TreeNodeStack.Push(new(LocalBuilderLength: _localBuilder.Length, NodeLevel: node.Level));
    }

    public void ReadPrimitive(
        in ObjectParserNode node,
        in ObjectParserReader nodeReader)
    {
        writer.Write(_localBuilder);
        writer.Write('$');
        writer.Write(node.Type);
        writer.Write(" = ");

        switch (node.Type)
        {
            case ObjectParserType.U64:
                writer.Write(nodeReader.ReadU64(node));
                break;

            case ObjectParserType.U32:
                writer.Write(nodeReader.ReadU32(node));
                break;

            case ObjectParserType.U16:
                writer.Write(nodeReader.ReadU16(node));
                break;

            case ObjectParserType.U8:
                writer.Write(nodeReader.ReadU8(node));
                break;

            case ObjectParserType.S64:
                writer.Write(nodeReader.ReadS64(node));
                break;

            case ObjectParserType.S32:
                writer.Write(nodeReader.ReadS32(node));
                break;

            case ObjectParserType.S16:
                writer.Write(nodeReader.ReadS16(node));
                break;

            case ObjectParserType.S8:
                writer.Write(nodeReader.ReadS8(node));
                break;

            case ObjectParserType.F64:
                writer.Write(nodeReader.ReadF64(node));
                break;

            case ObjectParserType.F32:
                writer.Write(nodeReader.ReadF32(node));
                break;

            case ObjectParserType.Bool:
                writer.Write(nodeReader.ReadBool(node));
                break;

            case ObjectParserType.Char:
                writer.Write(nodeReader.ReadChar(node));
                break;

            default:
                Debug.Assert(false);
                break;
        }

        writer.Write('\n');
    }

    public void ReadPrimitiveArray(
        in ObjectParserNode node,
        in ObjectParserNode dataNode,
        in ObjectParserReader nodeReader,
        int arrayLength)
    {
        const int maxLenPrimArray = 16;
        int trimmed = arrayLength - maxLenPrimArray;

        writer.Write(_localBuilder);
        writer.Write('$');
        writer.Write(node.Type);
        writer.Write('<');
        writer.Write(arrayLength);
        writer.Write('>');
        writer.Write(" = [");
        writer.Write(nodeReader.ReadPrimitiveArrayAsString(node, arrayLength, maxLenPrimArray));
        writer.Write(']');
        if (trimmed > 0) writer.Write($"... <{trimmed} skipped>");
        writer.Write('\n');
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
        const int maxLenString = 256;
        int trimmed = stringLength - maxLenString;

        writer.Write(_localBuilder);
        writer.Write('$');
        writer.Write(node.Type);
        writer.Write('<');
        writer.Write(stringLength);
        writer.Write('>');
        writer.Write(" = \"");
        writer.Write(nodeReader.ReadString(node, stringLength, maxLenString));
        writer.Write('\"');
        if (trimmed > 0) writer.Write($" <{trimmed} skipped>");
        writer.Write('\n');
    }

    public void ReadRefObjectRegistry(
        in ObjectParserNode node,
        long refId, string cls, string ns, string asm)
    {
        writer.Write(_localBuilder);
        writer.Write('$');
        writer.Write(node.Type);
        writer.Write($" = [rid:{refId:X}, managed:\"{asm}:{ns}.{cls}\"]");
        writer.Write('\n');
    }

    public void Align(
        in ObjectParserNode node,
        int alignedBytes)
    { }

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
        int LocalBuilderLength,
        byte NodeLevel);

    private record struct ArrayFrame(
        ushort ArrayDataNodeIndex,
        byte ArrayNodeLevel,
        byte ArrayIndexListOffset);

    private Stack<NodeFrame> TreeNodeStack => _treeNodeStacks.Peek();
    private Stack<ArrayFrame> TreeArrayStack => _treeArrayStacks.Peek();

    private readonly Stack<Stack<NodeFrame>> _treeNodeStacks = [];
    private readonly Stack<Stack<ArrayFrame>> _treeArrayStacks = [];
    private readonly List<int> _arrayIndices = [];
    private readonly StringBuilder _localBuilder = new();
}

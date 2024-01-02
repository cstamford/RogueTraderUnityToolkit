using RogueTraderUnityToolkit.Core;
using System.Diagnostics;

namespace RogueTraderUnityToolkit.Unity.TypeTree;

// Inherit from this if you need to read everything.
public interface IObjectTypeTreeReader
{
    public void BeginTree(
        in ObjectTypeTree tree);

    public void EndTree(
        in ObjectTypeTree tree);

    public void BeginNode(
        in ObjectParserNode node,
        in ObjectTypeTree tree);

    public void EndNode(
        in ObjectParserNode node,
        in ObjectTypeTree tree);

    public void ReadPrimitive(
        in ObjectParserNode node,
        in ObjectParserReader nodeReader);

    public void ReadPrimitiveArray(
        in ObjectParserNode node,
        in ObjectParserNode dataNode,
        in ObjectParserReader nodeReader,
        int arrayLength);

    public void ReadComplexArray(
        in ObjectParserNode node,
        in ObjectParserNode dataNode,
        int arrayLength);

    public void ReadString(
        in ObjectParserNode node,
        in ObjectParserReader nodeReader,
        int stringLength);

    public void ReadPPtr(
        in ObjectParserNode node,
        in ObjectParserReader nodeReader,
        AsciiString typeName);

    public void ReadReferencedObject(
        in ObjectParserNode node,
        long refId,
        AsciiString cls,
        AsciiString ns,
        AsciiString asm);

    public void Align(
        in ObjectParserNode node,
        int alignedBytes);
};

// Inherit from this if you want absolutely nothing, but want to be insulated against API changes.
// It's always safe not to call the base functions if you inherit from this.
public abstract class ObjectTypeTreeReaderBase : IObjectTypeTreeReader
{
    public virtual void BeginTree(
        in ObjectTypeTree tree)
    { }

    public virtual void EndTree(
        in ObjectTypeTree tree)
    { }

    public virtual void BeginNode(
        in ObjectParserNode node,
        in ObjectTypeTree tree)
    { }

    public virtual void EndNode(
        in ObjectParserNode node,
        in ObjectTypeTree tree)
    { }

    public virtual void ReadPrimitive(
        in ObjectParserNode node,
        in ObjectParserReader nodeReader)
    { }

    public virtual void ReadPrimitiveArray(
        in ObjectParserNode node,
        in ObjectParserNode dataNode,
        in ObjectParserReader nodeReader,
        int arrayLength)
    { }

    public virtual void ReadComplexArray(
        in ObjectParserNode node,
        in ObjectParserNode dataNode,
        int arrayLength)
    { }

    public virtual void ReadString(
        in ObjectParserNode node,
        in ObjectParserReader nodeReader,
        int stringLength)
    { }

    public virtual void ReadPPtr(
        in ObjectParserNode node,
        in ObjectParserReader nodeReader,
        AsciiString typeName)
    { }

    public virtual void ReadReferencedObject(
        in ObjectParserNode node,
        long refId,
        AsciiString cls,
        AsciiString ns,
        AsciiString asm)
    { }

    public virtual void Align(
        in ObjectParserNode node,
        int alignedBytes)
    { }
}

// Inherit from this for some essential stuff (tree depth/index, array indices)
public abstract class ObjectTypeTreeBasicReader : ObjectTypeTreeReaderBase
{
    public override void BeginTree(
        in ObjectTypeTree tree)
    {
        ++_treeDepth;
        _trees.Add(tree);

        Debug.Assert(_treeDepth is 1 or 2);
        _treeIdx = _treeDepth == 1 ? 0 : _trees.Count - 1;
    }

    public override void EndTree(
        in ObjectTypeTree tree)
    {
        --_treeDepth;

        // exiting root
        if (_treeDepth == 0)
        {
            Debug.Assert(_nodeStack.Count == 0);

            _arrayStack.Clear();
            _arrayIndices.Clear();
            _trees.Clear();
            _hasNonZeroArrayIdx = false;
        }
        // exiting embedded tree
        else if (_treeDepth == 1)
        {
            _treeIdx = 0;
            _baseNodeLevel = 0;
        }
    }

    public override void BeginNode(
        in ObjectParserNode node,
        in ObjectTypeTree tree)
    {
        _nodeStack.Push(new(NodeIdx: node.Index, TreeIdx: TreeIdx));

        if (_arrayStack.TryPeek(out ArrayFrame array) &&
            node.Index == array.ArrayDataNodeIndex)
        {
            uint idx = _arrayIndices[array.ArrayIndexListOffset];
            _arrayIndices[array.ArrayIndexListOffset] = ++idx;
            _hasNonZeroArrayIdx |= idx > 0;
        }

        Debug.Assert(_hasNonZeroArrayIdx == CheckForNonZeroArrayIndex());
        Debug.Assert(_trees[TreeIdx] == tree);
    }

    public override void EndNode(
        in ObjectParserNode node,
        in ObjectTypeTree tree)
    {
        _nodeStack.Pop();

        if (_arrayStack.TryPeek(out ArrayFrame top) &&
            _baseNodeLevel + node.Level <= top.ArrayNodeLevel)
        {
            _arrayStack.Pop();
            _hasNonZeroArrayIdx = CheckForNonZeroArrayIndex();
        }
    }

    public override void ReadComplexArray(
        in ObjectParserNode node,
        in ObjectParserNode dataNode,
        int arrayLength)
    {
        if (arrayLength == 0) return;

        _arrayStack.Push(new(
            ArrayDataNodeIndex: dataNode.Index,
            ArrayNodeLevel: (byte)(_baseNodeLevel + node.Level),
            ArrayIndexListOffset: (byte)_arrayIndices.Count));

        _arrayIndices.Add(~0u);
    }

    public override void ReadReferencedObject(
        in ObjectParserNode node,
        long refId,
        AsciiString cls,
        AsciiString ns,
        AsciiString asm)
    {
        _baseNodeLevel = (byte)(node.Level + 1);
    }

    protected int TreeDepth => _treeDepth;
    protected ushort TreeIdx => (ushort)_treeIdx;

    protected readonly record struct NodeFrame(ushort NodeIdx, ushort TreeIdx);
    protected Stack<NodeFrame> NodeStack => _nodeStack;

    protected ref ObjectParserNode GetNode(in NodeFrame frame) => ref _trees[frame.TreeIdx][frame.NodeIdx];

    protected ushort ArrayDataNodeIdx => _arrayStack.Peek().ArrayDataNodeIndex;
    protected uint ArrayIndex => _arrayIndices[_arrayStack.Peek().ArrayIndexListOffset];
    protected bool IsFirstArrayIndex => !_hasNonZeroArrayIdx;

    private bool CheckForNonZeroArrayIndex()
    {
        foreach (ArrayFrame frame in _arrayStack)
        {
            if (_arrayIndices[frame.ArrayIndexListOffset] != 0) return true;
        }

        return false;
    }

    private readonly record struct ArrayFrame(
        ushort ArrayDataNodeIndex,
        byte ArrayNodeLevel,
        byte ArrayIndexListOffset);

    private readonly Stack<NodeFrame> _nodeStack = [];
    private readonly Stack<ArrayFrame> _arrayStack = [];
    private readonly List<uint> _arrayIndices = [];
    private readonly List<ObjectTypeTree> _trees = [];

    private int _treeDepth;
    private int _treeIdx;
    private bool _hasNonZeroArrayIdx;
    private byte _baseNodeLevel;
}

// Does nothing.
public sealed class ObjectTypeTreeNullReader : ObjectTypeTreeReaderBase;

// Forwards calls onto multiple readers.
public sealed class ObjectTypeTreeMultiReader(params IObjectTypeTreeReader[] readers) : IObjectTypeTreeReader
{
    public void BeginTree(
        in ObjectTypeTree tree)
    {
        foreach (IObjectTypeTreeReader reader in readers) { reader.BeginTree(tree); }
    }

    public void EndTree(
        in ObjectTypeTree tree)
    {
        foreach (IObjectTypeTreeReader reader in readers) { reader.EndTree(tree); }
    }

    public void BeginNode(
        in ObjectParserNode node,
        in ObjectTypeTree tree)
    {
        foreach (IObjectTypeTreeReader reader in readers) { reader.BeginNode(node, tree); }
    }

    public void EndNode(
        in ObjectParserNode node,
        in ObjectTypeTree tree)
    {
        foreach (IObjectTypeTreeReader reader in readers) { reader.EndNode(node, tree); }
    }

    public void ReadPrimitive(
        in ObjectParserNode node,
        in ObjectParserReader nodeReader)
    {
        foreach (IObjectTypeTreeReader reader in readers) { reader.ReadPrimitive(node, nodeReader); }
    }

    public void ReadPrimitiveArray(
        in ObjectParserNode node,
        in ObjectParserNode dataNode,
        in ObjectParserReader nodeReader,
        int arrayLength)
    {
        foreach (IObjectTypeTreeReader reader in readers) { reader.ReadPrimitiveArray(node, dataNode, nodeReader, arrayLength); }
    }

    public void ReadComplexArray(
        in ObjectParserNode node,
        in ObjectParserNode dataNode,
        int arrayLength)
    {
        foreach (IObjectTypeTreeReader reader in readers) { reader.ReadComplexArray(node, dataNode, arrayLength); }
    }

    public void ReadString(
        in ObjectParserNode node,
        in ObjectParserReader nodeReader,
        int stringLength)
    {
        foreach (IObjectTypeTreeReader reader in readers) { reader.ReadString(node, nodeReader, stringLength); }
    }

    public void ReadPPtr(
        in ObjectParserNode node,
        in ObjectParserReader nodeReader,
        AsciiString typeName)
    {
        foreach (IObjectTypeTreeReader reader in readers) { reader.ReadPPtr(node, nodeReader, typeName); }
    }

    public void ReadReferencedObject(
        in ObjectParserNode node,
        long refId,
        AsciiString cls,
        AsciiString ns,
        AsciiString asm)
    {
        foreach (IObjectTypeTreeReader reader in readers) { reader.ReadReferencedObject(node, refId, cls, ns, asm); }
    }

    public void Align(
        in ObjectParserNode node,
        int alignedBytes)
    {
        foreach (IObjectTypeTreeReader reader in readers) { reader.Align(node, alignedBytes); }
    }
}

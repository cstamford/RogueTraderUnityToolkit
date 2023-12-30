using RogueTraderUnityToolkit.Core;

namespace RogueTraderUnityToolkit.Unity;

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

    public void ReadRefObjectRegistry(
        in ObjectParserNode node,
        long refId,
        AsciiString cls,
        AsciiString ns,
        AsciiString asm);

    public void Align(
        in ObjectParserNode node,
        int alignedBytes);
};

public sealed class ObjectTypeTreeNullReader : IObjectTypeTreeReader
{
    public void BeginTree(
        in ObjectTypeTree tree)
    { } 

    public void EndTree(
        in ObjectTypeTree tree)
    { }

    public void BeginNode(
        in ObjectParserNode node,
        in ObjectTypeTree tree)
    { }
    
    public void EndNode(
        in ObjectParserNode node,
        in ObjectTypeTree tree)
    { }
    
    public void ReadPrimitive(
        in ObjectParserNode node,
        in ObjectParserReader nodeReader)
    { }

    public void ReadPrimitiveArray(
        in ObjectParserNode node,
        in ObjectParserNode dataNode,
        in ObjectParserReader nodeReader,
        int arrayLength)
    { }

    public void ReadComplexArray(
        in ObjectParserNode node,
        in ObjectParserNode dataNode,
        int arrayLength)
    { }

    public void ReadString(
        in ObjectParserNode node,
        in ObjectParserReader nodeReader,
        int stringLength)
    { }

    public void ReadRefObjectRegistry(
        in ObjectParserNode node,
        long refId,
        AsciiString cls,
        AsciiString ns,
        AsciiString asm)
    { }

    public void Align(
        in ObjectParserNode node,
        int alignedBytes)
    { }
}

public sealed class ObjectTypeTreeMultiReader(
    params IObjectTypeTreeReader[] readers) 
    : IObjectTypeTreeReader
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

    public void ReadRefObjectRegistry(
        in ObjectParserNode node,
        long refId,
        AsciiString cls,
        AsciiString ns,
        AsciiString asm)
    {
        foreach (IObjectTypeTreeReader reader in readers) { reader.ReadRefObjectRegistry(node, refId, cls, ns, asm); }
    }

    public void Align(
        in ObjectParserNode node,
        int alignedBytes)
    {
        foreach (IObjectTypeTreeReader reader in readers) { reader.Align(node, alignedBytes); }
    }
}

public abstract class ObjectTypeTreeStackReader<TNodeFrame>
    : IObjectTypeTreeReader
{
    public virtual void BeginTree(
        in ObjectTypeTree tree)
    {
        _treeNodeStacks.Push([]);
        _treeArrayStacks.Push([]);
        
        _treeIdx = ++_treeDepth == 1 ? 0 : _treeIdx + 1;
    }

    public virtual void EndTree(
        in ObjectTypeTree tree)
    {
        --_treeDepth;
        
        _treeNodeStacks.Pop();
        _treeArrayStacks.Pop();

        if (_treeDepth == 0)
        {
            _treeNodeStacks.Clear();
            _treeArrayStacks.Clear();
            _arrayIndices.Clear();
        }
    }

    public virtual void BeginNode(
        in ObjectParserNode node,
        in ObjectTypeTree tree)
    {
        /* inheritor must implement node stack pushing */

        if (TryPopArrayFrames(node.Level, out ArrayFrame arrayFrame) &&
            node.Index == arrayFrame.ArrayDataNodeIndex)
        {
            ++_arrayIndices[arrayFrame.ArrayIndexListOffset];
        }
    }

    public virtual void EndNode(
        in ObjectParserNode node,
        in ObjectTypeTree tree)
    {
        /* inheritor must implement node stack popping */
    }

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
    {
        if (arrayLength == 0) return;
 
        TreeArrayStack.Push(new(
            ArrayDataNodeIndex: dataNode.Index,
            ArrayNodeLevel: node.Level,
            ArrayIndexListOffset: (byte)_arrayIndices.Count));

        _arrayIndices.Add(~0u);
    }

    public virtual void ReadString(
        in ObjectParserNode node,
        in ObjectParserReader nodeReader,
        int stringLength)
    { }

    public virtual void ReadRefObjectRegistry(
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

    protected bool IsFirstArrayIndex
    {
        get
        {
            // I bet you want to LINQ this, don't you? I bet you do. I did!
            // Turns out LINQ allocates a full copy of a stack every time you do this. WTF.
            foreach (ArrayFrame frame in TreeArrayStack)
            {
                if (_arrayIndices[frame.ArrayIndexListOffset] != 0) return false;
            }

            return true;
        }
    }
    
    protected int TreeDepth => _treeDepth;
    protected int TreeIdx => _treeIdx;
    protected uint TopmostArrayIndex => _arrayIndices[TreeArrayStack.Peek().ArrayIndexListOffset];
    protected Stack<TNodeFrame> TreeNodeStack => _treeNodeStacks.Peek();
    protected Stack<ArrayFrame> TreeArrayStack => _treeArrayStacks.Peek();
    
    protected bool TryPopNodeFrames(int target, out TNodeFrame fit)
    {
        Stack<TNodeFrame> stack = TreeNodeStack;

        if (stack.Count == 0)
        {
            fit = default!;
            return false;
        }

        while (stack.Count > target) { fit = stack.Pop(); }

        fit = stack.Peek();
        return true;
    }

    protected bool TryPopArrayFrames(int target, out ArrayFrame fit)
    {
        Stack<ArrayFrame> stack = TreeArrayStack;

        if (stack.Count == 0)
        {
            fit = default;
            return false;
        }

        while (TreeArrayStack.TryPeek(out fit) && target <= fit.ArrayNodeLevel)
        {
            TreeArrayStack.Pop();
        }

        return true;
    }

    protected record struct ArrayFrame(
        ushort ArrayDataNodeIndex,
        byte ArrayNodeLevel,
        byte ArrayIndexListOffset);

    private int _treeDepth;
    private int _treeIdx;
    private readonly Stack<Stack<TNodeFrame>> _treeNodeStacks = [];
    private readonly Stack<Stack<ArrayFrame>> _treeArrayStacks = [];
    private readonly List<uint> _arrayIndices = [];
}

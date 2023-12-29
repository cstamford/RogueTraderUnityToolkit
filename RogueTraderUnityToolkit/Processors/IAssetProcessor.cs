using RogueTraderUnityToolkit.Core;
using RogueTraderUnityToolkit.Unity;

namespace RogueTraderUnityToolkit.Processors;

public interface IAssetProcessor
{
    public void Process(
        Args args,
        AssetBundle bundle,
        ISerializedAsset asset,
        out int assetCountProcessed,
        out int assetCountSkipped,
        out int assetCountFailed);

    public void End(Args args, ISerializedAsset[] assets);
}

public abstract class AssetProcessorTypeTreeReader<TNodeFrame>
    : IObjectTypeTreeReader
{
    public virtual void BeginTree(
        in ObjectTypeTree tree)
    {
        _treeNodeStacks.Push([]);
        _treeArrayStacks.Push([]);
    }

    public virtual void EndTree(
        in ObjectTypeTree tree)
    {
        Stack<TNodeFrame> prevNodeStack = _treeNodeStacks.Pop();
        Stack<ArrayFrame> prevArrayStack = _treeArrayStacks.Pop();

        if (prevNodeStack.Count == 0)
        {
            _treeNodeStacks.Clear();
            _treeArrayStacks.Clear();
            _arrayIndices.Clear();
            
            return;
        }
        
        prevNodeStack.Clear();
        prevArrayStack.Clear();
    }

    public virtual void Visit(
        in ObjectParserNode node,
        in ObjectTypeTree tree)
    {
        /* inheritor must implement node stacks */
        
        if (TryPopArrayFrames(node.Level, out ArrayFrame arrayFrame) &&
            node.Index == arrayFrame.ArrayDataNodeIndex)
        {
            ++_arrayIndices[arrayFrame.ArrayIndexListOffset];
        }
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

    protected bool IsFirstTree => _treeNodeStacks.Count == 1;
    protected Stack<TNodeFrame> TreeNodeStack => _treeNodeStacks.Peek();
    protected Stack<ArrayFrame> TreeArrayStack => _treeArrayStacks.Peek();
    
    protected uint GetIndex(in ArrayFrame frame) => _arrayIndices[frame.ArrayIndexListOffset];
    
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
    
    private readonly Stack<Stack<TNodeFrame>> _treeNodeStacks = [];
    private readonly Stack<Stack<ArrayFrame>> _treeArrayStacks = [];
    
    private readonly List<uint> _arrayIndices = [];
}

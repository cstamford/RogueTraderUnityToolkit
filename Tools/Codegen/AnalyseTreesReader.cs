using RogueTraderUnityToolkit.Core;
using RogueTraderUnityToolkit.Unity;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text;

namespace Codegen;

public sealed class AnalyseTreesReader(
    AnalyseTreesPathAllocator allocator,
    Dictionary<UnityObjectType, PerTypeTreeData> data)
    : ObjectTypeTreeBasicReader, IAnalyseTreeReader
{
    public void StartFile(
        SerializedFile file)
    { }

    public void StartObject(
        UnityObjectType type)
    {
        _data = data[type];
        _data.IncObjectCount(1);

        foreach (AnalyseTreesMemoryHandle handle in _borrowedMemory)
        {
            if (_pinnedMemory.Contains(handle)) continue;
            allocator.Return(handle);
        }
        
        _pathCache.Clear();
        _borrowedMemory.Clear();
        _pinnedMemory.Clear();
    }

    [MethodImpl(MethodImplOptions.AggressiveOptimization)]
    public override void EndNode(
        in ObjectParserNode node,
        in ObjectTypeTree tree)
    {
        base.EndNode(node, tree);

        if (IsFirstArrayIndex)
        {
            AnalyseTreesNodePath path = CalculatePath(node, tree);
            
            if (_data.PathRefs.TryGetValue(path, out int existingCount))
            {
                _data.PathRefs[path] = existingCount + 1;
            }
            else
            {
                _data.PathRefs.Add(path, 1);
                _pinnedMemory.Add(path.Allocation.Handle);
            }
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveOptimization)]
    private AnalyseTreesNodePath CalculatePath(
        in ObjectParserNode node,
        in ObjectTypeTree tree)
    {
        NodeFrame ourFrame = new(node.Index, TreeIdx);
        if (_pathCache.TryGetValue(ourFrame, out AnalyseTreesNodePath path)) return path;
        
        AnalyseTreesNodePathEntry us = new(node);
        
        Span<NodeFrame> indices = stackalloc NodeFrame[NodeStack.Count];
        AnalyseTreesAllocation allocation = allocator.Rent(NodeStack.Count);
        _borrowedMemory.Add(allocation.Handle);
        
        int parentIdx = NodeStack.Count - 1;
        
        foreach (NodeFrame nodeFrame in NodeStack)
        {
            ref ObjectParserNode treeNode = ref GetNode(nodeFrame);
            allocation[parentIdx] = new(treeNode);
            indices[parentIdx] = nodeFrame;
            --parentIdx;
        }

        // The path is now in the form [ parent ..., self ].
        AnalyseTreesNodePath ourPath = new(allocation, us);
        Debug.Assert(ourPath.Parents.Length == NodeStack.Count);
        
        ConstructPathForParents(allocation, indices);
        ConstructPathForLeafSiblings(node, tree, ourPath);
        _pathCache.Add(ourFrame, ourPath);
        
        return ourPath;
    }

    [MethodImpl(MethodImplOptions.AggressiveOptimization)]
    private void ConstructPathForParents(
        AnalyseTreesAllocation alloc,
        ReadOnlySpan<NodeFrame> indices)
    {
        for (int i = 0; i < indices.Length; ++i)
        {
            int nodeArraySelfIdx = indices.Length - i - 1;
            NodeFrame nodeFrame = indices[nodeArraySelfIdx];

            if (_pathCache.TryGetValue(nodeFrame, out AnalyseTreesNodePath _))
            {
                // Parent path already done by another sibling.
                return;
            }

            AnalyseTreesNodePathEntry us = alloc[nodeArraySelfIdx];
            AnalyseTreesAllocation ourParents = alloc[..nodeArraySelfIdx];
            _pathCache.Add(nodeFrame, new(ourParents, us));
        }
    }
    
    [MethodImpl(MethodImplOptions.AggressiveOptimization)]
    private void ConstructPathForLeafSiblings(
        in ObjectParserNode node,
        in ObjectTypeTree tree,
        in AnalyseTreesNodePath basePath)
    {
        int nodeIdx = node.Index;
        int siblingIdx = node.FirstSiblingIdx;
 
        while (IsDirectSibling(tree, nodeIdx, siblingIdx))
        {
            ref ObjectParserNode siblingNode = ref tree[siblingIdx];
            if (siblingNode.FirstChildIdx != 0) break;
            
            AnalyseTreesNodePathEntry siblingEntry = new(siblingNode);
            _pathCache.Add(new(siblingNode.Index, TreeIdx), basePath with { Self = siblingEntry });

            nodeIdx = siblingIdx;
            siblingIdx = siblingNode.FirstSiblingIdx;
        }
        
        return;

        static bool IsDirectSibling(
            in ObjectTypeTree tree,
            int nodeIdx,
            int siblingIdx)
        {
            int nodeLevel = tree[nodeIdx].Level;
            while (nodeIdx < siblingIdx && tree[++nodeIdx].Level > nodeLevel) { }
            return nodeIdx == siblingIdx;
        }
    }
    
    private PerTypeTreeData _data = default!;
    
    private readonly Dictionary<NodeFrame, AnalyseTreesNodePath> _pathCache = [];
    private readonly List<AnalyseTreesMemoryHandle> _borrowedMemory = [];
    private readonly HashSet<AnalyseTreesMemoryHandle> _pinnedMemory = [];
}

public readonly record struct AnalyseTreesNodePathEntry(
    AsciiString Name,
    AsciiString TypeName,
    ObjectParserType Type,
    ObjectParserNodeFlags Flags)
{
    public AnalyseTreesNodePathEntry(
        in ObjectParserNode node)
        : this(node.Name, node.TypeName, node.Type, node.Flags)
    { }
    
    public override string ToString() => Name.ToString();
}

public record struct AnalyseTreesNodePath(
    AnalyseTreesAllocation Allocation,
    AnalyseTreesNodePathEntry Self)
    : IComparable<AnalyseTreesNodePath>
{
    public ReadOnlyMemory<AnalyseTreesNodePathEntry> Parents => Allocation.Memory;

    public bool Equals(AnalyseTreesNodePath rhs)
    {
        if (Self.Name != rhs.Self.Name) return false;
        if (Parents.Length != rhs.Parents.Length) return false;

        ReadOnlySpan<AnalyseTreesNodePathEntry> lhsSpan = Parents.Span;
        ReadOnlySpan<AnalyseTreesNodePathEntry> rhsSpan = rhs.Parents.Span;

        for (int i = 0; i < Parents.Length; i++)
        {
            if (lhsSpan[i].Name != rhsSpan[i].Name) return false;
        }

        return true;
    }

    public int CompareTo(AnalyseTreesNodePath rhs)
        => string.Compare(ToString(), rhs.ToString(), StringComparison.Ordinal);

    public override int GetHashCode() => _hashCode == 0 ? MakeHashCode() : _hashCode;
    
    private int _hashCode;

    private int MakeHashCode()
    {
        HashCode hash = new();
        foreach (AnalyseTreesNodePathEntry entry in Parents.Span)
        {
            hash.Add(entry.Name);
        }
        hash.Add(Self);
        _hashCode = hash.ToHashCode();
        return _hashCode;
    }
    
    public override string ToString()
    {
        StringBuilder sb = new();
        foreach (AnalyseTreesNodePathEntry entry in Parents.Span)
        {
            sb.Append(entry.ToString());
            sb.Append('/');
        }
        sb.Append(Self.ToString());
        return sb.ToString();
    }
}

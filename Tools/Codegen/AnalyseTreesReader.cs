using RogueTraderUnityToolkit.Core;
using RogueTraderUnityToolkit.Unity;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text;

namespace Codegen;

public sealed class AnalyseTreesReader 
    : ObjectTypeTreeStackReader<ushort>
{
    public AnalyseTreesReader(
        AnalyseTreesPathAllocator allocator,
        IReadOnlyDictionary<UnityObjectType, PerTypeTreeData> data)
    {
        _allocator = allocator;
        _allData = data;
    }

    public void StartFile(SerializedFileTypeReference[] references)
    {
        _references = references;
    }

    public void StartObject(UnityObjectType type)
    {
        _data = _allData[type];
        _pathCache.Clear();

        foreach (AnalyseTreesMemoryHandle handle in _borrowedMemory)
        {
            if (_pinnedMemory.Contains(handle)) continue;
            _allocator.Return(handle);
        }
        
        _borrowedMemory.Clear();
        _pinnedMemory.Clear();
    }
    
    public override void BeginTree(
        in ObjectTypeTree tree)
    {
        base.BeginTree(tree);
        _data.IncObjectCount(1);
    }

    public override void BeginNode(
        in ObjectParserNode node,
        in ObjectTypeTree tree)
    {
        base.BeginNode(node, tree);
        TreeNodeStack.Push(node.Index);
    }

    [MethodImpl(MethodImplOptions.AggressiveOptimization)]
    public override void EndNode(
        in ObjectParserNode node,
        in ObjectTypeTree tree)
    {
        base.EndNode(node, tree);

        if (TreeDepth == 1 && IsFirstArrayIndex)
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

        TreeNodeStack.Pop();
    }

    public override void ReadRefObjectRegistry(
        in ObjectParserNode node,
        long refId,
        AsciiString cls,
        AsciiString ns,
        AsciiString asm)
    {
        base.ReadRefObjectRegistry(in node, refId, cls, ns, asm);

        SerializedFileTypeReference reference = _references.First(x =>
            x.Class == cls &&
            x.Namespace == ns &&
            x.Assembly == asm);
        
        _data = _allData[reference.Info.Type];
    }

    [MethodImpl(MethodImplOptions.AggressiveOptimization)]
    private AnalyseTreesNodePath CalculatePath(
        in ObjectParserNode node,
        in ObjectTypeTree tree)
    {
        ushort ourIdx = node.Index;
        if (_pathCache.TryGetValue(ourIdx, out AnalyseTreesNodePath path)) return path;

        AnalyseTreesNodePathEntry us = new(node.Name, node.TypeName, node.Type);

        int parentCount = TreeNodeStack.Count - 1;
        Span<ushort> indices = stackalloc ushort[parentCount];

        AnalyseTreesAllocation allocation = _allocator.Rent(parentCount);
        _borrowedMemory.Add(allocation.Handle);

        int pathIdx = parentCount - 1;
        
        foreach (ushort nodeIndex in TreeNodeStack)
        {
            if (nodeIndex == ourIdx) continue;
            ref ObjectParserNode treeNode = ref tree[nodeIndex];
            allocation[pathIdx] = new(treeNode.Name, treeNode.TypeName, treeNode.Type);
            indices[pathIdx] = nodeIndex;
            --pathIdx;
        }

        // The path is now in the form [ parent ..., self ].
        AnalyseTreesNodePath ourPath = new(allocation, us);
        Debug.Assert(ourPath.Parents.Length == TreeNodeStack.Count - 1);
        
        ConstructPathForParents(allocation, indices);
        ConstructPathForLeafSiblings(node, tree, ourPath);
        _pathCache.Add(node.Index, ourPath);
        
        return ourPath;
    }

    [MethodImpl(MethodImplOptions.AggressiveOptimization)]
    private void ConstructPathForParents(
        AnalyseTreesAllocation alloc,
        ReadOnlySpan<ushort> indices)
    {
        for (int i = 0; i < indices.Length; ++i)
        {
            int nodeArraySelfIdx = indices.Length - i - 1;
            ushort nodeIdx = indices[nodeArraySelfIdx];

            if (_pathCache.TryGetValue(nodeIdx, out AnalyseTreesNodePath _))
            {
                // Parent path already done by another sibling.
                return;
            }

            AnalyseTreesNodePathEntry us = alloc[nodeArraySelfIdx];
            AnalyseTreesAllocation ourParents = alloc.Slice(0, nodeArraySelfIdx);
            _pathCache.Add(nodeIdx, new(ourParents, us));
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
            
            AnalyseTreesNodePathEntry siblingEntry = new(siblingNode.Name, siblingNode.TypeName, siblingNode.Type);
            _pathCache.Add(siblingNode.Index, basePath with { Self = siblingEntry });

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
    private SerializedFileTypeReference[] _references = default!;

    private readonly IReadOnlyDictionary<UnityObjectType, PerTypeTreeData> _allData;
    private readonly Dictionary<ushort, AnalyseTreesNodePath> _pathCache = [];
    private readonly List<AnalyseTreesMemoryHandle> _borrowedMemory = [];
    private readonly HashSet<AnalyseTreesMemoryHandle> _pinnedMemory = [];
    private readonly AnalyseTreesPathAllocator _allocator;
}

public readonly record struct AnalyseTreesNodePathEntry(
    AsciiString Name,
    AsciiString TypeName,
    ObjectParserType Type)
{
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

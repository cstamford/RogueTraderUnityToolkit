using RogueTraderUnityToolkit.Core;
using RogueTraderUnityToolkit.Unity;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text;

namespace Codegen;

public interface ITreeReader : IObjectTypeTreeReader
{
    public void StartFile(SerializedFile file);
    public void StartObject(UnityObjectType type);
}

public sealed class TreeReader(
    TreePathAllocator allocator,
    Dictionary<UnityObjectType, PerTypeTreeData> data)
    : ObjectTypeTreeBasicReader, ITreeReader
{
    public void StartFile(
        SerializedFile file)
    { }

    public void StartObject(
        UnityObjectType type)
    {
        _data = data[type];
        _data.IncObjectCount(1);

        foreach (TreePathMemoryHandle handle in _borrowedMemory)
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
            TreePath path = CalculatePath(node, tree);

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
    private TreePath CalculatePath(
        in ObjectParserNode node,
        in ObjectTypeTree tree)
    {
        NodeFrame ourFrame = new(node.Index, TreeIdx);
        if (_pathCache.TryGetValue(ourFrame, out TreePath path)) return path;

        TreePathEntry us = new(node);

        Span<NodeFrame> indices = stackalloc NodeFrame[NodeStack.Count];
        TreePathAllocation allocation = allocator.Rent(NodeStack.Count);
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
        TreePath ourPath = new(allocation, us);
        Debug.Assert(ourPath.Parents.Length == NodeStack.Count);

        ConstructPathForParents(allocation, indices);
        ConstructPathForLeafSiblings(node, tree, ourPath);
        _pathCache.Add(ourFrame, ourPath);

        return ourPath;
    }

    [MethodImpl(MethodImplOptions.AggressiveOptimization)]
    private void ConstructPathForParents(
        TreePathAllocation alloc,
        ReadOnlySpan<NodeFrame> indices)
    {
        for (int i = 0; i < indices.Length; ++i)
        {
            int nodeArraySelfIdx = indices.Length - i - 1;
            NodeFrame nodeFrame = indices[nodeArraySelfIdx];

            if (_pathCache.TryGetValue(nodeFrame, out TreePath _))
            {
                // Parent path already done by another sibling.
                return;
            }

            TreePathEntry us = alloc[nodeArraySelfIdx];
            TreePathAllocation ourParents = alloc[..nodeArraySelfIdx];
            _pathCache.Add(nodeFrame, new(ourParents, us));
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveOptimization)]
    private void ConstructPathForLeafSiblings(
        in ObjectParserNode node,
        in ObjectTypeTree tree,
        in TreePath basePath)
    {
        int nodeIdx = node.Index;
        int siblingIdx = node.FirstSiblingIdx;

        while (IsDirectSibling(tree, nodeIdx, siblingIdx))
        {
            ref ObjectParserNode siblingNode = ref tree[siblingIdx];
            if (siblingNode.FirstChildIdx != 0) break;

            TreePathEntry siblingEntry = new(siblingNode);
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

    private readonly Dictionary<NodeFrame, TreePath> _pathCache = [];
    private readonly List<TreePathMemoryHandle> _borrowedMemory = [];
    private readonly HashSet<TreePathMemoryHandle> _pinnedMemory = [];
}

public sealed class TreeReaderDebug(Stream stream) : ObjectTypeTreeBasicReader, ITreeReader
{
    public void StartFile(
        SerializedFile file)
    {
        _writer.WriteLine($"#### {file.Info.Identifier} ####");
    }

    public void StartObject(
        UnityObjectType type)
    {
        _writer.WriteLine();
        _writer.WriteLine($"** {type} **");
    }

    public override void BeginNode(
        in ObjectParserNode node,
        in ObjectTypeTree tree)
    {
        base.BeginNode(node, tree);

        if (IsFirstArrayIndex)
        {
            _writer.WriteLine($"{' '.Repeat(_nodeLevel * 4)}{node.ToString()}");
        }

        ++_nodeLevel;
    }

    [MethodImpl(MethodImplOptions.AggressiveOptimization)]
    public override void EndNode(
        in ObjectParserNode node,
        in ObjectTypeTree tree)
    {
        base.EndNode(node, tree);
        --_nodeLevel;
    }

    private readonly TextWriter _writer = new StreamWriter(stream) { AutoFlush = true };
    private int _nodeLevel;
}

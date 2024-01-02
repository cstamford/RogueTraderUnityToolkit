using RogueTraderUnityToolkit.Core;
using RogueTraderUnityToolkit.Unity;
using RogueTraderUnityToolkit.Unity.File;
using RogueTraderUnityToolkit.Unity.TypeTree;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Codegen;

public interface ITreeReader : IObjectTypeTreeReader
{
    public void StartFile(SerializedFile file);
    public void FinishFile(SerializedFile file);

    public void StartObject(UnityObjectType type);
    public void FinishObject(UnityObjectType type);
}

public sealed class TreeReader(
    TreePathAllocator allocator,
    Dictionary<TreePathObject, int> data)
    : ObjectTypeTreeBasicReader, ITreeReader
{
    public void StartFile(SerializedFile file) {}
    public void FinishFile(SerializedFile file) {}

    public void StartObject(UnityObjectType type)
    {
        Debug.Assert(_paths.Count == 0);
        Debug.Assert(_allocations.Count == 0);
        Debug.Assert(_visited.Count == 0);
    }

    public void FinishObject(UnityObjectType type)
    {
        TreePathObject obj = new(type, _paths);

        if (data.TryAdd(obj, 1))
        {
            // These paths are unique, so we surrender our memory and paths collection to them.
            _paths = [];
        }
        else
        {
            // Increment refcount for this tree type.
            data[obj] += 1;

            // These paths are a duplicate (exact match of another type), so we free all of our
            // memory and clear our paths, but keep the capacity around.

            foreach (TreePathMemoryHandle handle in _allocations)
            {
                allocator.Return(handle);
            }

            _paths.Clear();
        }

        _allocations.Clear();
        _visited.Clear();
    }

    [MethodImpl(MethodImplOptions.AggressiveOptimization)]
    public override void EndNode(
        in ObjectParserNode node,
        in ObjectTypeTree tree)
    {
        base.EndNode(node, tree);

        if (IsFirstArrayIndex && node.FirstChildIdx == 0)
        {
            TreePathEntry us = new(node);
            NodeFrame ourFrame = new(node.Index, TreeIdx);

            Debug.Assert(!_visited.Contains(ourFrame));

            Span<NodeFrame> indices = stackalloc NodeFrame[NodeStack.Count];
            TreePathAllocation allocation = allocator.Rent(NodeStack.Count);
            _allocations.Add(allocation.Handle);

            int parentIdx = NodeStack.Count - 1;

            foreach (NodeFrame nodeFrame in NodeStack)
            {
                ref ObjectParserNode treeNode = ref GetNode(nodeFrame);
                allocation[parentIdx] = new(treeNode);
                indices[parentIdx] = nodeFrame;
                --parentIdx;
            }

            ConstructPathForParents(allocation, indices);

            _paths.Add(new(allocation, us));
            _visited.Add(ourFrame);
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    private void ConstructPathForParents(
        TreePathAllocation alloc,
        ReadOnlySpan<NodeFrame> indices)
    {
        for (int i = 0; i < indices.Length; ++i)
        {
            int nodeArraySelfIdx = indices.Length - i - 1;
            NodeFrame nodeFrame = indices[nodeArraySelfIdx];

            // Parent path already done by another sibling.
            if (_visited.Contains(nodeFrame)) return;

            TreePathEntry us = alloc[nodeArraySelfIdx];
            TreePathAllocation ourParents = alloc[..nodeArraySelfIdx];
            _paths.Add(new(ourParents, us));
            _visited.Add(nodeFrame);
        }
    }

    private List<TreePath> _paths = [];
    private readonly List<TreePathMemoryHandle> _allocations = [];
    private readonly HashSet<NodeFrame> _visited = [];
}

public sealed class TreeReaderDebug(Stream stream) : ObjectTypeTreeBasicReader, ITreeReader
{
    public void StartFile(SerializedFile file) =>_writer.WriteLine($"#### {file.Info.Identifier} ####");
    public void FinishFile(SerializedFile file) => _writer.WriteLine();
    public void StartObject(UnityObjectType type) => _writer.WriteLine($"** {type} **");
    public void FinishObject(UnityObjectType type) => _writer.WriteLine();

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

using RogueTraderUnityToolkit.Core;
using RogueTraderUnityToolkit.Unity.File;
using RogueTraderUnityToolkit.Unity.TypeTree;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Codegen;

public interface ITreeReader : IObjectTypeTreeReader
{
    public void StartFile(SerializedFile file);
    public void FinishFile(SerializedFile file);

    public void StartObject(in SerializedFileObjectInfo objectInfo);
    public void FinishObject(in SerializedFileObjectInfo objectInfo);
}

public sealed class TreeReader(
    TreePathAllocator allocator,
    Dictionary<TreePathObject, int> data)
    : ObjectTypeTreeBasicReader, ITreeReader
{
    public void StartFile(SerializedFile file) {}
    public void FinishFile(SerializedFile file) {}

    public void StartObject(in SerializedFileObjectInfo info)
    {
        Debug.Assert(_paths.Count == 0);
        Debug.Assert(_allocations.Count == 0);
        Debug.Assert(_visited.Count == 0);
    }

    public void FinishObject(in SerializedFileObjectInfo info)
    {
        DebugEnsureCorrectness(_paths);

        TreePathObject obj = new(info.Type, info.ScriptHash, info.Hash, _paths);

        if (data.TryAdd(obj, 1))
        {
            // These paths are unique, so we surrender our memory and paths collection to them.
            _paths = [];
        }
        else
        {
            DebugEnsureUniqueness(obj, data.Keys.First(x => x == obj));

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
            NodeFrame ourFrame = new(node.Index, TreeIdx);
            Debug.Assert(!_visited.Contains(ourFrame));

            TreePathAllocation allocation = allocator.Rent(NodeStack.Count + 1);
            _allocations.Add(allocation.Handle);
            allocation[^1] = new(node);

            ConstructPathForParents(allocation);

            _paths.Add(new(allocation, new(ourFrame.NodeIdx, ourFrame.TreeIdx)));
            _visited.Add(ourFrame);
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    private void ConstructPathForParents(
        TreePathAllocation allocation)
    {
        Span<NodeFrame> parentIndices = stackalloc NodeFrame[NodeStack.Count];
        int parentIdx = NodeStack.Count - 1;

        foreach (NodeFrame nodeFrame in NodeStack)
        {
            ref ObjectParserNode treeNode = ref GetNode(nodeFrame);
            allocation[parentIdx] = new(treeNode);
            parentIndices[parentIdx] = nodeFrame;
            --parentIdx;
        }

        for (int i = 0; i < parentIndices.Length; ++i)
        {
            // We read from stack in reverse order, so we reverse again.
            int reverseIndex = parentIndices.Length - i - 1;
            NodeFrame nodeFrame = parentIndices[reverseIndex];

            if (_visited.Contains(nodeFrame))
            {
                // Already done by another sibling!
                return;
            }

            _paths.Add(new(
                allocation[..(parentIndices.Length - i)],
                new(nodeFrame.NodeIdx, nodeFrame.TreeIdx)));

            _visited.Add(nodeFrame);
        }
    }

    [Conditional("DEBUG_VERBOSE")]
    private void DebugEnsureCorrectness(IReadOnlyList<TreePath> paths)
    {
        List<TreePath> ordered = paths.Order().ToList();

        int idx = 0;

        for (int i = 0; i < Trees.Count; ++i)
        {
            int startIdx = idx;

            ObjectTypeTree tree = Trees[i];
            Debug.Assert(ordered[idx].Order.TreeId == i);

            for (int j = 0; j < tree.Nodes.Length; ++j)
            {
                TreePath path = ordered[idx];
                ObjectParserNode node = tree[j];

                Debug.Assert(path.Order.NodeId == node.Index);
                Debug.Assert(path.Last.Name == node.Name);
                Debug.Assert(path.Last.TypeName == node.TypeName);
                Debug.Assert(path.Last.Type == node.Type);

                ++idx;
            }

            Debug.Assert(idx == startIdx + tree.Nodes.Length,
                "We skipped over some nodes while reading!");
        }

        Debug.Assert(idx == ordered.Count,
            $"We didn't fully read all trees!");
    }

    [Conditional("DEBUG_VERBOSE")]
    private void DebugEnsureUniqueness(TreePathObject ourObj, TreePathObject theirObj)
    {
        List<TreePath> ourPathsOrdered = ourObj.Paths.Order().ToList();
        List<TreePath> theirPathsOrdered = theirObj.Paths.Order().ToList();

        bool pathsEqual = ourPathsOrdered.SequenceEqual(theirPathsOrdered);

        if (!pathsEqual)
        {
            Log.Write($"ourObj:{ourObj.GetHashCode()} theirObj:{theirObj.GetHashCode()}");

            if (ourObj.Equals(theirObj))
            {
                Log.Write("Object equality but paths differ.",ConsoleColor.Red);
            }

            if (ourObj.Type != theirObj.Type)
            {
                Log.Write($"Type differs. ourObj:{ourObj.Type}, theirObj:{theirObj.Type}", ConsoleColor.Red);
            }

            if (ourObj.ScriptHash != theirObj.ScriptHash)
            {
                Log.Write($"ScriptHash differs. ourObj:{ourObj.ScriptHash}, theirObj:{theirObj.ScriptHash}", ConsoleColor.Red);
            }

            if (ourObj.Hash != theirObj.Hash)
            {
                Log.Write($"Hash differs. ourObj:{ourObj.Hash}, theirObj:{theirObj.Hash}", ConsoleColor.Red);
            }

            for (int i = 0; i < Math.Max(ourPathsOrdered.Count, theirPathsOrdered.Count); i++)
            {
                bool ourObjHasPath = i < ourPathsOrdered.Count;
                bool theirObjHasPath = i < theirPathsOrdered.Count;

                if (ourObjHasPath && theirObjHasPath)
                {
                    if (!ourPathsOrdered[i].Equals(theirPathsOrdered[i]))
                    {
                        Log.Write($"Paths differ at index {i}. ourObj:{ourPathsOrdered[i]}, theirObj:{theirPathsOrdered[i]}", ConsoleColor.Yellow);
                    }
                }
                else if (ourObjHasPath)
                {
                    Log.Write($"Path only in ourObj at index {i}: {ourPathsOrdered[i]}", ConsoleColor.Yellow);
                }
                else // theirObjHasPath
                {
                    Log.Write($"Path only in theirObj at index {i}: {theirPathsOrdered[i]}", ConsoleColor.Yellow);
                }
            }
        }

        Debug.Assert(pathsEqual, "We were unable to insert our paths into the collection but they were not equal!");
    }

    private List<TreePath> _paths = [];
    private readonly List<TreePathMemoryHandle> _allocations = [];
    private readonly HashSet<NodeFrame> _visited = [];
}

public sealed class TreeReaderDebug(Stream stream) : ObjectTypeTreeBasicReader, ITreeReader
{
    public void StartFile(SerializedFile file) =>_writer.WriteLine($"#### {file.Info.Identifier} ####");
    public void FinishFile(SerializedFile file) => _writer.WriteLine();
    public void StartObject(in SerializedFileObjectInfo info) => _writer.WriteLine($"** {info} **");
    public void FinishObject(in SerializedFileObjectInfo info) => _writer.WriteLine();

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

using RogueTraderUnityToolkit.Core;
using RogueTraderUnityToolkit.Unity;
using RogueTraderUnityToolkit.Unity.TypeTree;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace RogueTraderUnityToolkit.Tree;

public sealed class TreeReader(
    TreePathAllocator allocator,
    Dictionary<TreePathObject, int> data)
    : ObjectTypeTreeBasicReader, ITreeReader
{
    public void StartObject(
        UnityObjectType type,
        Hash128 scriptHash,
        Hash128 hash)
    {
        // Clear on start, not end, so we can more easily debug issues with past reads.
        _allocations.Clear();
        _visited.Clear();
        _paths.Clear();
    }

    public void FinishObject(
        UnityObjectType type,
        Hash128 scriptHash,
        Hash128 hash)
    {
        // At this point, the paths collection should be completely correct and represent an object.
        TreeReaderDebug.EnsureCorrectness(_paths, Trees);
        TreePathObject obj = new(type, scriptHash, hash, _paths);

        // If we can insert fully, it's a unique set of paths.
        if (data.TryAdd(obj, 1))
        {
            _paths = []; // give ownership to dictionary version
            return;
        }

        // We've clashed with another entry, so we need to update our ref count and free our resources.
        TreeReaderDebug.EnsureUniqueness(obj, data.Keys.First(x => x == obj));
        data[obj] += 1;

        foreach (TreePathMemoryHandle handle in _allocations)
        {
            allocator.Return(handle);
        }
    }

    public override void BeginTree(
        in ObjectTypeTree tree)
    {
        base.BeginTree(tree);

        // Helps to avoid several reallocations on large trees
        _paths.Capacity = Math.Max(_paths.Capacity, tree.Nodes.Length);
    }

    [MethodImpl(MethodImplOptions.AggressiveOptimization)]
    public override void EndNode(
        in ObjectParserNode node,
        in ObjectTypeTree tree)
    {
        NodeFrame ourFrame = NodeStack.Peek();
        base.EndNode(node, tree);

        if (IsFirstArrayIndex && node.FirstChildIdx == 0)
        {
            TreePathAllocation allocation = allocator.Rent(NodeStack.Count + 1);
            _allocations.Add(allocation.Handle);

            Span<TreePathEntry> entries = allocation.Span;
            ExtractFrames(entries[..^1]);
            entries[^1] = PathEntry(ourFrame);

            DebugCheckOneVisitPerLeaf(ourFrame);
            _paths.Add(Path(ourFrame, allocation));

            int idx = 1;
            foreach (NodeFrame frame in NodeStack)
            {
                if (_visited.Contains(frame)) break;
                _paths.Add(Path(frame, allocation[..^idx++]));
                _visited.Add(frame);
            }
        }
    }

    private List<TreePath> _paths = [];
    private readonly List<TreePathMemoryHandle> _allocations = [];
    private readonly HashSet<NodeFrame> _visited = [];

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private TreePath Path(in NodeFrame frame, in TreePathAllocation allocation) => new(allocation, new(frame.NodeIdx, (byte)frame.TreeIdx));

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private TreePathEntry PathEntry(in NodeFrame frame) => PathEntry(GetNode(frame));

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static TreePathEntry PathEntry(in ObjectParserNode node) => new(node.Name, node.TypeName, node.Type, node.Flags);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void ExtractFrames(Span<TreePathEntry> storage)
    {
        int idx = 0;
        foreach (NodeFrame frame in NodeStack)
        {
            storage[^++idx] = PathEntry(frame);
        }
    }

    [Conditional("DEBUG")]
    private void DebugCheckOneVisitPerLeaf(NodeFrame frame)
    {
        // We don't need to add our frame to the visited set since each leaf node should only be called once.
        Debug.Assert(!_visited.Contains(frame));
        _visited.Add(frame);
    }
}

// Define TREE_READER_DEBUG if you're making changes to the node ordering or want to debug
// a lack of determinism in the output of the analysis process.
public static class TreeReaderDebug
{
    [Conditional("TREE_READER_DEBUG")]
    public static void EnsureCorrectness(
        IReadOnlyList<TreePath> paths,
        IReadOnlyList<ObjectTypeTree> trees)
    {
        List<TreePath> ordered = paths.Order().ToList();

        int idx = 0;

        for (int i = 0; i < trees.Count; ++i)
        {
            int startIdx = idx;

            ObjectTypeTree tree = trees[i];
            Debug.Assert(ordered[idx].Metadata.TreeId == i);

            for (int j = 0; j < tree.Nodes.Length; ++j)
            {
                TreePath path = ordered[idx];
                ObjectParserNode node = tree[j];

                Debug.Assert(path.Metadata.NodeId == node.Index);
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

    [Conditional("TREE_READER_DEBUG")]
    public static void EnsureUniqueness(TreePathObject ourObj, TreePathObject theirObj)
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
}

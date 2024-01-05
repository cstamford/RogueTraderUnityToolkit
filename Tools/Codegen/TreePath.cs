using RogueTraderUnityToolkit.Core;
using RogueTraderUnityToolkit.Unity.TypeTree;
using System.Diagnostics;
using System.Text;

namespace Codegen;

public readonly record struct TreePathEntry(
    AsciiString Name,
    AsciiString TypeName,
    ObjectParserType Type,
    ObjectParserNodeFlags Flags)
{
    public override string ToString() => Name.ToString();
}

public readonly record struct TreePath(
    TreePathAllocation Allocation,
    TreePathMetadata Metadata)
    : IEquatable<string>, IComparable<TreePath>
{
    public ReadOnlySpan<TreePathEntry> Data => Allocation.Memory.Span;
    public int Length => Data.Length;
    public int Hash => _hash;

    public TreePathEntry this[int idx] => Data[idx];
    public TreePathEntry First => this[0];
    public TreePathEntry Last => this[^1];

    public override int GetHashCode() => _hash;

    public TreePath Slice(int offset) => Slice(offset, Length - offset);
    public TreePath Slice(int offset, int length) => this with { Allocation = Allocation.Slice(offset, length) };

    public bool StartsWith(TreePath path) => Length >= path.Length && Data[..path.Length].SequenceEqual(path.Data);
    public bool EndsWith(TreePath path) => Length >= path.Length && Data[(Length - path.Length)..].SequenceEqual(path.Data);

    public static bool operator ==(TreePath lhs, string? rhs) => Equals(lhs, rhs);
    public static bool operator !=(TreePath lhs, string? rhs) => !Equals(lhs, rhs);

    public bool Equals(TreePath rhs) => Equals(this, rhs);
    public bool Equals(string? rhs) => Equals(this, rhs);

    public int CompareTo(TreePath other) => Metadata.CompareTo(other.Metadata);

    private readonly int _hash = CalculateHash(Metadata, Allocation.Memory.Span);

    private int StartsWithString(string path, out bool success) => StartsWithString(path, 0, 0, out success);
    private int StartsWithString(string path, int pathIndex, int entryIndex, out bool success)
    {
        Debug.Assert(path.Length <= 1024);

        Span<byte> pathSpan = stackalloc byte[path.Length];
        Encoding.ASCII.GetBytes(path, pathSpan);

        while (pathIndex < pathSpan.Length && entryIndex < Length)
        {
            int slashIndex = pathSpan[pathIndex..].IndexOf((byte)'/');
            ReadOnlySpan<byte> currentPathSegment = slashIndex >= 0
                ? pathSpan.Slice(pathIndex, slashIndex)
                : pathSpan[pathIndex..];

            if (!this[entryIndex].Name.Bytes.SequenceEqual(currentPathSegment))
            {
                success = false;
                return entryIndex;
            }

            // Move to the next segment
            ++entryIndex;
            pathIndex += currentPathSegment.Length;

            // Skip the slash if we're not at the end of the path
            if (slashIndex >= 0)
            {
                pathIndex++;
            }
        }

        // Check if we've compared all the segments in the path
        success = entryIndex == Length && pathIndex >= pathSpan.Length;
        return entryIndex;
    }

    private static bool Equals(TreePath lhs, TreePath rhs) =>
        lhs.Metadata == rhs.Metadata &&
        lhs.Data.Length == rhs.Data.Length &&
        lhs.Data.SequenceEqual(rhs.Data);

    private static bool Equals(TreePath lhs, string? rhs) =>
        rhs != null &&
        lhs.StartsWithString(rhs, out bool success) == lhs.Length &&
        success;

    private static int CalculateHash(
        TreePathMetadata metadata,
        ReadOnlySpan<TreePathEntry> data)
    {
        HashCode hash = new();
        hash.Add(metadata);
        foreach (TreePathEntry entry in data)
        {
            hash.Add(entry);
        }
        return hash.ToHashCode();
    }

    // Debugger doesn't display properly if we use an elaborate method, so this will do...
    public override string ToString() => string.Join('/', Data.ToArray().Select(x => x.ToString()));
}

public readonly record struct TreePathMetadata(
    ushort NodeId,
    byte TreeId)
    : IComparable<TreePathMetadata>
{
    public int CompareTo(TreePathMetadata rhs)
    {
        int treeIdComparison = TreeId.CompareTo(rhs.TreeId);
        if (treeIdComparison != 0) return treeIdComparison;
        return NodeId.CompareTo(rhs.NodeId);
    }

    public override string ToString() => $"{NodeId}/{TreeId}";
}

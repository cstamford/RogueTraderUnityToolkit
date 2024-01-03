using RogueTraderUnityToolkit.Core;
using RogueTraderUnityToolkit.Unity.TypeTree;
using System.Diagnostics;
using System.Text;

namespace Codegen;

public readonly record struct TreePathEntry(
    AsciiString Name,
    AsciiString TypeName,
    ObjectParserType Type)
{
    public TreePathEntry(
        in ObjectParserNode node)
        : this(node.Name, node.TypeName, node.Type)
    { }

    public override string ToString() => Name.ToString();
}

public readonly record struct TreePath(TreePathAllocation Allocation)
    : IEquatable<string>
{
    public ReadOnlySpan<TreePathEntry> Data => Allocation.Memory.Span;
    public int Length => Data.Length;
    public int Hash => _hash;


    public TreePathEntry this[int idx] => Data[idx];

    public TreePath this[string path]
    {
        get
        {
            int startWithCount = StartWithCount(path, out bool success);
            return success ? Slice(startWithCount) : throw new();
        }
    }

    public override int GetHashCode() => _hash;

    public TreePath Slice(int offset) => Slice(offset, Length - offset);
    public TreePath Slice(int offset, int length) => new(Allocation.Slice(offset, length));

    public bool StartsWith(TreePath rhs) => Length >= rhs.Length && Data[..rhs.Length].SequenceEqual(rhs.Data);
    public bool StartsWith(TreePathEntry rhs) => this[0] == rhs;
    public bool StartsWith(string path) => StartWithCount(path, out bool success) > 0 && success;

    public static bool operator ==(TreePath lhs, string? rhs) => Equals(lhs, rhs);
    public static bool operator !=(TreePath lhs, string? rhs) => !Equals(lhs, rhs);

    public bool Equals(TreePath rhs) => Equals(this, rhs);
    public bool Equals(string? rhs) => Equals(this, rhs);

    private readonly int _hash = CalculateHash(Allocation.Memory.Span);

    private int StartWithCount(string path, out bool success)
    {
        Debug.Assert(path.Length <= 1024);

        Span<byte> pathSpan = stackalloc byte[path.Length];
        Encoding.ASCII.GetBytes(path, pathSpan);

        int pathIndex = 0;
        int entryIndex = 0;

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
        lhs.Data.Length == rhs.Data.Length &&
        lhs.Data.SequenceEqual(rhs.Data);

    private static bool Equals(TreePath lhs, string? rhs) =>
        rhs != null &&
        lhs.StartWithCount(rhs, out bool success) == lhs.Length &&
        success;

    private static int CalculateHash(ReadOnlySpan<TreePathEntry> data)
    {
        HashCode hash = new();
        foreach (TreePathEntry entry in data)
        {
            hash.Add(entry);
        }
        return hash.ToHashCode();
    }

    public override string ToString()
    {
        StringBuilder sb = new();

        foreach (TreePathEntry entry in Data)
        {
            sb.Append(entry.Name.ToString());
            sb.Append('/');
        }

        sb.Length -= 1; // trailing slash
        return sb.ToString();
    }

}

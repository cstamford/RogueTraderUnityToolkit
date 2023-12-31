using RogueTraderUnityToolkit.Core;
using RogueTraderUnityToolkit.Unity;
using System.Diagnostics;
using System.Text;

namespace Codegen;

public readonly record struct TreePathEntry(
    AsciiString Name,
    AsciiString TypeName,
    ObjectParserType Type,
    ObjectParserNodeFlags Flags)
{
    public TreePathEntry(
        in ObjectParserNode node)
        : this(node.Name, node.TypeName, node.Type, node.Flags)
    { }

    public override string ToString() => Name.ToString();
}

public readonly record struct TreePath(
    TreePathAllocation Allocation,
    TreePathEntry Self,
    int HashCode)
    : IComparable<TreePath>
{
    public TreePath(
        TreePathAllocation allocation,
        TreePathEntry self)
        : this(allocation, self, 0)
    {
        HashCode hash = new();
        foreach (TreePathEntry entry in Parents.Span)
        {
            hash.Add(entry);
        }
        hash.Add(Self);
        HashCode = hash.ToHashCode();
    }
    
    public ReadOnlyMemory<TreePathEntry> Parents => Allocation.Memory;

    public bool Equals(TreePath rhs) => 
        Self == rhs.Self && Parents.Span.SequenceEqual(rhs.Parents.Span);

    public bool StartsWith(TreePathEntry entry) =>
        entry == (Parents.Length == 0 ? Self : Parents.Span[0]);

    public TreePath Slice(int offset) => Slice(offset, Parents.Length + 1 - offset);

    public TreePath Slice(int offset, int length)
    {
        int selfIdx = offset + length;
        int currentSelfIdx = Parents.Length + 1;
        Debug.Assert(selfIdx <= currentSelfIdx);

        TreePathAllocation alloc = Allocation.Slice(offset, length - 1);
        TreePathEntry self = offset + length == currentSelfIdx ? Self : Allocation[selfIdx];
        return new(alloc, self);
    }
    
    public TreePathEntry this[int idx] => idx == Parents.Length ? Self : Allocation[idx];

    public int CompareTo(TreePath rhs)
    {
        TreePathEntry lhsRoot = Parents.Length == 0 ? Self : Parents.Span[0];
        TreePathEntry rhsRoot = rhs.Parents.Length == 0 ? rhs.Self : rhs.Parents.Span[0];

        // Different type trees on the root, so they should be ordered separately.
        int comparison = lhsRoot.TypeName.CompareTo(rhsRoot.TypeName);
        if (comparison != 0) return comparison;
        
        // Otherwise, go full string comparison.
        return string.CompareOrdinal(ToString(), rhs.ToString());
    }
    
    public override int GetHashCode() => HashCode;
    
    public override string ToString()
    {
        StringBuilder sb = new();
        foreach (TreePathEntry entry in Parents.Span)
        {
            sb.Append(entry.ToString());
            sb.Append('/');
        }
        sb.Append(Self.ToString());
        return sb.ToString();
    }
}

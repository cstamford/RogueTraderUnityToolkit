using RogueTraderUnityToolkit.Core;
using RogueTraderUnityToolkit.Unity.TypeTree;
using System.Diagnostics;

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

public readonly record struct TreePath(
    TreePathAllocation Allocation,
    TreePathEntry Self)
{
    public ReadOnlyMemory<TreePathEntry> Parents => Allocation.Memory;

    public int Hash => _hash;
    public int Length => Parents.Length + 1;

    public bool Equals(TreePath rhs) => Self == rhs.Self && Parents.Span.SequenceEqual(rhs.Parents.Span);
    public override int GetHashCode() => _hash;

    public TreePath Slice(int offset) => Slice(offset, Length - offset);

    public TreePath Slice(int offset, int length)
    {
        int selfIdx = offset + length;
        int currentSelfIdx = Length;
        Debug.Assert(selfIdx <= currentSelfIdx);

        TreePathAllocation alloc = Allocation.Slice(offset, length - 1);
        TreePathEntry self = offset + length == currentSelfIdx ? Self : Allocation[selfIdx];
        return new(alloc, self);
    }

    public TreePathEntry this[int idx] => idx == Parents.Length ? Self : Allocation[idx];

    private readonly int _hash = CalculateHash(Allocation.Memory.Span, Self);

    private static int CalculateHash(
        ReadOnlySpan<TreePathEntry> parents,
        in TreePathEntry self)
    {
        HashCode hash = new();
        foreach (TreePathEntry entry in parents)
        {
            hash.Add(entry);
        }
        hash.Add(self);
        return hash.ToHashCode();
    }

    public override string ToString() => string.Join('/', [.. Parents.ToArray().Select(x => x.ToString()), Self]);
}

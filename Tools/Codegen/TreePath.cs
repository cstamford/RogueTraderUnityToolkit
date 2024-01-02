using RogueTraderUnityToolkit.Core;
using RogueTraderUnityToolkit.Unity.TypeTree;
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
{
    public ReadOnlySpan<TreePathEntry> Data => Allocation.Memory.Span;
    public int Length => Data.Length;
    public int Hash => _hash;

    public bool Equals(TreePath rhs) => Data.Length == rhs.Data.Length && Data.SequenceEqual(rhs.Data);
    public override int GetHashCode() => _hash;

    public TreePath Slice(int offset) => Slice(offset, Length - offset);
    public TreePath Slice(int offset, int length) => new(Allocation.Slice(offset, length));

    public bool BeginsWith(TreePath rhs) => Length >= rhs.Length && Data[..rhs.Length].SequenceEqual(rhs.Data);
    public bool BeginsWith(TreePathEntry rhs) => this[0] == rhs;

    public TreePathEntry this[int idx] => Data[idx];

    private readonly int _hash = CalculateHash(Allocation.Memory.Span);

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

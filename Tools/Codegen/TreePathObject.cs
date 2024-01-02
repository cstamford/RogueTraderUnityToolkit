using RogueTraderUnityToolkit.Unity;
using System.Diagnostics;

namespace Codegen;

public readonly record struct TreePathObject
{
    public UnityObjectType Type => _type;
    public IEnumerable<TreePath> Paths => _paths;

    public TreePathObject(
        UnityObjectType type,
        List<TreePath> paths)
    {
        _type = type;
        _paths = paths;
        _hash = CalculateHash(type, paths);
    }

    public bool Equals(TreePathObject rhs)
    {
#if DEBUG_VERBOSE
        //Debug.Assert(_hash == CalculateHash(_type, _paths), "Hash changed after creation.");
        //Debug.Assert(rhs._hash == CalculateHash(rhs._type, rhs._paths), "Hash changed after creation.");
#endif

        Debug.Assert(_hash == rhs._hash || !CheckEqualitySlow(_paths, rhs._paths),
            $"Two tree objects with the same hash are not equivalent. This breaks our invariant.");

        return _type == rhs._type && _hash == rhs._hash;
    }

    public override int GetHashCode() => _hash;

    private readonly UnityObjectType _type;
    private readonly List<TreePath> _paths;
    private readonly int _hash;

    private static int CalculateHash(
        UnityObjectType type,
        List<TreePath> paths)
    {
        HashCode hash = new();
        hash.Add(type);

        int pathsHash = 0;

        foreach (TreePath path in paths)
        {
            // Use an aggregate hash code that is order-independent.
            pathsHash ^= path.GetHashCode();
        }

        hash.Add(pathsHash);
        return hash.ToHashCode();
    }

    // Order independent equality - but slow!
    private static bool CheckEqualitySlow(
        List<TreePath> lhs,
        List<TreePath> rhs)
    {
        HashSet<TreePath> set1 = [..lhs];
        HashSet<TreePath> set2 = [..rhs];
        return set1.SetEquals(set2);
    }
}

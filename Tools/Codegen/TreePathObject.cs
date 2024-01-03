using RogueTraderUnityToolkit.Unity;
using RogueTraderUnityToolkit.Unity.File;
using System.Diagnostics;

namespace Codegen;

public readonly record struct TreePathObject
{
    public UnityObjectType Type => _type;
    public Hash128 ScriptHash => _scriptHash;
    public Hash128 Hash => _hash;
    public IEnumerable<TreePath> Paths => _paths;

    public TreePathObject(
        UnityObjectType type,
        in Hash128 scriptHash,
        in Hash128 hash,
        List<TreePath> paths)
    {
        _type = type;
        _scriptHash = scriptHash;
        _hash = hash;
        _paths = paths;
        _hashCode = CalculateHash(type, scriptHash, hash, paths);
    }

    public bool Equals(TreePathObject rhs)
    {
        Debug.Assert(_hash == rhs._hash || !CheckEqualitySlow(_paths, rhs._paths),
            $"Two tree objects with the same hash are not equivalent. This breaks our invariant.");

        return
            _hash == rhs._hash &&
            _type == rhs._type &&
            _scriptHash == rhs._scriptHash;
    }

    public override int GetHashCode() => _hashCode;

    private readonly UnityObjectType _type;
    private readonly Hash128 _scriptHash;
    private readonly Hash128 _hash;
    private readonly List<TreePath> _paths;

    private readonly int _hashCode;

    private static int CalculateHash(
        UnityObjectType type,
        in Hash128 scriptHash,
        in Hash128 hash,
        List<TreePath> paths)
    {
        HashCode hashcode = new();

        hashcode.Add(type);
        hashcode.Add(scriptHash);
        hashcode.Add(hash);

        int pathsHash = 0;

        foreach (TreePath path in paths)
        {
            // Use an aggregate hashcode code that is order-independent.
            pathsHash ^= path.GetHashCode();
        }

        hashcode.Add(pathsHash);

        return hashcode.ToHashCode();
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

using RogueTraderUnityToolkit.Unity;
using System.Diagnostics;

namespace Codegen;

public readonly record struct TreePathObject
{
    public UnityObjectType Type => _type;
    public Hash128 ScriptHash => _scriptHash;
    public Hash128 Hash => _hash;
    public IReadOnlyList<TreePath> Paths => _paths;

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

    public bool Equals(TreePathObject rhs) =>
        _hashCode == rhs._hashCode &&
        _paths.Count == rhs._paths.Count &&
        /* note: we don't compare the paths for equality directly as it's very slow */
        _type == rhs._type &&
        _scriptHash == rhs._scriptHash &&
        _hash == rhs._hash;

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

        foreach (TreePath path in paths)
        {
            hashcode.Add(path.GetHashCode());
        }

        return hashcode.ToHashCode();
    }
}

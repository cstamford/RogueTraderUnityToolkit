using RogueTraderUnityToolkit.Core;
using RogueTraderUnityToolkit.Unity.TypeTree;
using System.Diagnostics;

namespace Codegen;

public class Codegen
{
    public Codegen(TreeReport report)
    {
        // Construct all primitive types.
        foreach ((ObjectParserType type, AsciiString[] aliases) in ObjectParserNodeUtil.TypeAliases)
        {
            foreach (AsciiString alias in aliases)
            {
                CodegenPrimitiveType primitiveType = new(alias, type);
                Log.Write($"Constructed primitive type {primitiveType.Name} for {type}");
                AddType(primitiveType);
            }
        }

        // Every entry represents a unique "object", which has a type and a collection of paths.
        // The type is the UnityObjectType of the serialized file object it came from.
        // There will be at least one of these for every UnityObjectType we've read.
        foreach ((TreePathObject pathObject, int pathObjectRefs) in report.AllPathObjects)
        {
            // Grab all the children, ordering by length. (the first entry will be the root node).
            IEnumerable<TreePath> pathChildren = pathObject.Paths.OrderBy(x => x.Length);
            Debug.Assert(pathChildren.First().Length == 1, "Root is not root? (ordering problem?)");
            Debug.Assert(pathChildren.All(x => x.BeginsWith(pathChildren.First())), "Paths not beginning with root?");

            // Create the type, which will recursively create its subtypes.
            ICodegenType rootType = ConstructTypeRecursively(pathChildren.First(), pathChildren);
            Log.Write($"Constructed {rootType.Name} ({rootType})");
        }
    }

    private ICodegenType ConstructTypeRecursively(
        TreePath root,
        IEnumerable<TreePath> children)
    {
        Debug.Assert(root.Length == 1);
        Debug.Assert(children.First() == root);
        children = children.Skip(1); // skip root

        if (children.Any())
        {
            // If we have any children left, snip them off at the root!
            Debug.Assert(children.All(x => x.BeginsWith(root) && x.Length >= 2));
            children = children.Select(x => x[1..]);
        }

        // Check if this type has been created before.
        if (_typesIndexLookup.TryGetValue(root[^1].TypeName, out int rootTypeIdx))
        {
            return MergeType(_types[rootTypeIdx], root, children);
        }

        // If a type reaches this point, it MUST have children, or we have some sort of bug. (or: data is weird).
        Debug.Assert(children.Any(), $"We have a non-builtin type {root} with no children.");

        // Check all immediate children, constructing fields from them.
        List<ICodegenField> fields = [];
        foreach (TreePath child in children.Where(x => x.Length == 1))
        {
            Debug.Assert(child.Length == 1);
            ICodegenType childType = ConstructTypeRecursively(child, children.Where(x => x.BeginsWith(child)));
            fields.Add(new CodegenField(childType, child[^1].Name));
        }

        CodegenStructureType rootType = new(root[^1].TypeName, fields);
        Debug.Assert(rootType.Fields.Count != 0, $"Complex type with no fields? {rootType}");
        AddType(rootType);
        return rootType;
    }

    private ICodegenType MergeType(
        ICodegenType type,
        TreePath root,
        IEnumerable<TreePath> children)
    {
        return type;

        // TODO.

        /*
                     IEnumerable<TreePath> rootChildren = pathChildren.Skip(1) // skip root
            .Select(x => x[1..]); // slice past root on all

        // Kick off the recursive build of
        if (_typesIndexLookup.TryGetValue(type, out int existingTypeIdx))
        {
            ICodegenType existingType = _types[existingTypeIdx];
            if (existingType is CodegenPrimitive) continue; // Fully created earlier!
            Debug.Assert(existingType is not CodegenStruct);
        }


        // Split the type into any subtypes it may have.
        // Types which are templated, for example, have the same type name but different types.
        foreach (((TreePath subtype, int subtypeRefs), IEnumerable<(TreePath, int)> rootChildren) in objects
            .Where(root => root.Item1.Length == 1) // select all roots
            .Select(root => (root, objects
                .Where(child => child.Item1 != root.Item1 && child.Item1.BeginsWith(root.Item1))
                .ToArray())))
        {
            Debug.Assert(rootChildren.All(x => x.Item1.Length >= 2));

            // Split again! This time, we're splitting based on refc.

        }
        */
    }

    private int AddType(ICodegenType type)
    {
        int typeIdx = _types.Count;
        _typesIndexLookup[type.Name] = typeIdx;
        _types.Add(type);
        return typeIdx;
    }

    public void WriteStructures(string path)
    {
        // TODO
    }

    private readonly List<ICodegenType> _types = [];
    private readonly Dictionary<AsciiString, int> _typesIndexLookup = [];
}

using RogueTraderUnityToolkit.Core;
using RogueTraderUnityToolkit.Unity;
using RogueTraderUnityToolkit.Unity.TypeTree;
using System.Diagnostics;

namespace Codegen;

public class Codegen
{
    public Codegen(TreeReport report)
    {
        foreach ((ObjectParserType type, AsciiString[] aliases) in ObjectParserNodeUtil.TypeAliases)
        {
            foreach (AsciiString alias in aliases)
            {
                CodegenBuiltInType builtInType = new(alias, type);
                Log.Write($"Constructed primitive type {builtInType.Name} for {type}");
                AddType(builtInType);
            }
        }

        // Every entry represents a unique "object", which has a type and a collection of paths.
        // The type is the UnityObjectType of the serialized file object it came from.
        // There will be at least one of these for every UnityObjectType we've read.
        foreach ((UnityObjectType type, IEnumerable<TreePathObject> pathObjects)
            in report.AllPathObjects
            .GroupBy(x => x.Key.Type)
            .Select(x => (x.Key, x
                .Select(y => (y.Key, y.Value))
                .OrderBy(y => y.Value)
                .Select(y => y.Key))))
        {
            int num = 0;

            // Each of these is one unique object layout. We have to make one type per entry.
            // They're ordered by refs, so the "main" objects come first.
            foreach (TreePathObject pathObject in pathObjects)
            {
                // Grab all the children, ordering by length. (the first entry will be the root node).
                IEnumerable<TreePath> children = pathObject.Paths.OrderBy(x => x.Length);
                TreePath root = children.First();

                Debug.Assert(root.Length == 1, "Root is not root? (ordering problem?)");
                Debug.Assert(children.All(x => x.StartsWith(root)), "Paths not beginning with root?");

                // Append a number to fragments of this type so they have a unique name.
                AsciiString typeName = root[^1].TypeName;
                if (num++ > 0) typeName = AsciiString.From($"{typeName}_{num}");

                // Create the type, which will recursively create its subtypes.
                ICodegenType rootType = ConstructTypeRecursively(typeName, root, children);

#if DEBUG_VERBOSE
                Log.Write(num > 1 ? 4 : 0, $"Constructed {rootType}", ConsoleColor.DarkGray);
#endif
            }

            Log.Write($"Constructed {num} objects for type {type}", num > 1 ? ConsoleColor.DarkCyan : Log.DefaultColor);
        }
    }

    private ICodegenType ConstructTypeRecursively(
        AsciiString typeName,
        TreePath root,
        IEnumerable<TreePath> children)
    {
        Debug.Assert(root.Length == 1);
        Debug.Assert(children.First() == root);
        children = children.Skip(1); // skip root

        if (children.Any())
        {
            // If we have any children left, snip them off at the root!
            Debug.Assert(children.All(x => x.StartsWith(root) && x.Length >= 2));
            children = children.Select(x => x[1..]);
        }

        // Check if this type has been created before.
        if (TryFindType(typeName, out ICodegenType type))
        {
#if DEBUG_VERBOSE
            Log.Write(4, $"Found existing type {type}", ConsoleColor.DarkGreen);
#endif
            return MergeType(type, root, children);
        }
        else
        {
#if DEBUG_VERBOSE
            Log.Write(4, $"Didn't find type {typeName}", ConsoleColor.DarkRed);
#endif
        }

        // If a type reaches this point, it MUST have children, or we have some sort of bug. (or: data is weird).
        Debug.Assert(children.Any(), $"We have a non-builtin type {root} with no children.");

        // Special type handling! :) (arrays, etc, this handles the wrap-around).
        if (TryConstructSpecialType(root, children, out ICodegenType specialType))
        {
            return specialType;
        }

        // Check all immediate children, constructing fields from them.
        List<ICodegenField> fields = [];
        foreach (TreePath child in children.Where(x => x.Length == 1))
        {
            Debug.Assert(child.Length == 1);
            ICodegenType childType = ConstructTypeRecursively(child[^1].TypeName, child, children.Where(x => x.StartsWith(child)));
            fields.Add(new CodegenField(childType, child[^1].Name));
        }

        CodegenStructureType rootType = new(typeName, fields);
        Debug.Assert(rootType.Fields.Count != 0, $"Complex type with no fields? {rootType}");

        AddType(rootType);
        return rootType;
    }

    private bool TryConstructSpecialType(
        TreePath root,
        IEnumerable<TreePath> children,
        out ICodegenType type)
    {
        Debug.Assert(root.Length == 1);
        Debug.Assert(children.All(x => !x.StartsWith(root) && x.Length >= 1));

        AsciiString rootName = root[^1].Name;
        AsciiString rootTypeName = root[^1].TypeName;

        bool isPPtr = rootTypeName.StartsWith("PPtr<");
        bool isDirectArray = rootTypeName == "vector" || rootTypeName == "staticvector";
        bool isIndirectArray = children.Count(x => x.Length == 1) == 1 && children.First()[^1].Name == "Array";
        bool isMap = rootTypeName == "map";

        ICodegenType? specialType = null;

        // pptr => { m_FileID, m_PathID }
        if (isPPtr)
        {
            Debug.Assert(children.Count() == 2);
            Debug.Assert(children.Count(x => x == "m_FileID") == 1);
            Debug.Assert(children.Count(x => x == "m_PathID") == 1);
            specialType = new CodegenPPtrType( rootTypeName, rootTypeName[5..^1]);
        }
        // map -> { array { data (pair), size ... } }
        else if (isMap)
        {
            Debug.Assert(children.Count(x => x == "Array") == 1);
            Debug.Assert(children.Count(x => x == "Array/data") == 1);
            Debug.Assert(children.Count(x => x == "Array/data/first") == 1);
            Debug.Assert(children.Count(x => x == "Array/data/second") == 1);
            Debug.Assert(children.Count(x => x == "Array/size") == 1);

            TreePath mapKey = children.First(x => x == "Array/data/first");
            TreePath mapValue = children.First(x => x == "Array/data/second");

            ICodegenType mapKeyType = ConstructTypeRecursively(
                mapKey[^1].TypeName,
                mapKey[2..],
                children.Where(x => x.StartsWith(mapKey)).Select(x => x[2..]));

            ICodegenType mapValueType = ConstructTypeRecursively(
                mapValue[^1].TypeName,
                mapValue[2..],
                children.Where(x => x.StartsWith(mapValue)).Select(x => x[2..]));

            specialType = new CodegenMapType(
                AsciiString.From($"Map<{mapKeyType.Name}, {mapValueType.Name}>"),
                mapKeyType, mapValueType);
        }
        // isDirectArray: vector -> { array { data, size ... } } where data is primitive type
        // isIndirectArray: (typename) -> array -> { data, size ... } } where data is a complex type
        else if (isDirectArray || isIndirectArray)
        {
            if (isIndirectArray)
            {
                root = children.First();

                Debug.Assert(root[^1].TypeName == "Array");
                Debug.Assert(children.Count(x => x == "Array/data") == 1);
                Debug.Assert(children.Count(x => x == "Array/size") == 1);

                children = children
                    .Where(x => x.StartsWith(root))
                    .Skip(1)
                    .Select(x => x[1..]);
            }

            TreePath arrayDataPath = children.First(x => x[^1].Name == "data");

            ICodegenType arrayDataType = ConstructTypeRecursively(
                arrayDataPath[^1].TypeName,
                arrayDataPath,
                children.Where(x => x.StartsWith(arrayDataPath)));

            specialType = new CodegenArrayType(
                AsciiString.From($"Array<{arrayDataType.Name}>"),
                arrayDataType);
        }

        // We should have handled arrays already, so if we reach this point, it's a bug.

        Debug.Assert(rootName != "Array");
        Debug.Assert(rootTypeName != "Array");

        if (specialType != null)
        {
            // Now that we've resolved the special type, our name should take into account type and be unique.
            // It's entirely possible that we've already created this type before. If we have, return that one first.

            if (!TryFindType(specialType.Name, out type))
            {
                AddType(specialType);
                type = specialType;
            }

            return true;
        }

        type = default!;
        return false;
    }

    private ICodegenType MergeType(
        ICodegenType type,
        TreePath root,
        IEnumerable<TreePath> children)
    {
        // TODO: this is just an assert job, to double check everything is OK.
        return type;
    }

    private void AddType(
        ICodegenType type)
    {
        int typeIdx = _types.Count;
        _typesIndexLookup.Add(type.Name, typeIdx);
        _types.Add(type);

#if DEBUG_VERBOSE
        Log.Write(4, $"[{typeIdx}] = {type}", ConsoleColor.DarkYellow);
#endif
    }

    private bool TryFindType(
        AsciiString name,
        out ICodegenType type)
    {
        if (_typesIndexLookup.TryGetValue(name, out int typeIdx))
        {
            type = _types[typeIdx];
            return true;
        }

        type = default!;
        return false;
    }

    public void WriteStructures(string path)
    {
        // TODO
    }

    private readonly List<ICodegenType> _types = [];
    private readonly Dictionary<AsciiString, int> _typesIndexLookup = [];
}

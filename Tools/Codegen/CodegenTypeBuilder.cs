using RogueTraderUnityToolkit.Core;
using RogueTraderUnityToolkit.Unity.TypeTree;
using System.Diagnostics;

namespace Codegen;

public class CodegenTypeBuilder
{
    public IReadOnlyList<ICodegenType> Types => _types;
    public IReadOnlyDictionary<AsciiString, int> TypesIndexLookup => _typesIndexLookup;

    public CodegenTypeBuilder()
    {
        foreach ((ObjectParserType type, AsciiString[] aliases) in ObjectParserNodeUtil.TypeAliases)
        {
            foreach (AsciiString alias in aliases)
            {
                CodegenBuiltInType builtInType = new(alias, type);
                LogVerbose(0, $"Constructed primitive type {builtInType.Name} for {type}");
                AddType(builtInType);
            }
        }
    }

    public ICodegenType ReadTreeObject(
        TreePathObject obj,
        AsciiString typeName,
        Func<IReadOnlyList<ICodegenField>, CodegenStructureType> fnMakeStruc)
    {
        TreePath root = obj.Paths[0];
        Debug.Assert(root.Length == 1);

        Debug.Assert(root.Length == 1, "Root is not root? (ordering problem?)");
        Debug.Assert(obj.Paths.All(x => x.StartsWith(root)), "Paths not beginning with root?");

        // Create the type, which will recursively create its subtypes.
        ICodegenType rootType = ConstructTypeRecursively(typeName, root, obj.Paths, fnMakeStruc);
        LogVerbose(0, $"Constructed {rootType}", ConsoleColor.DarkGray);

        return rootType;
    }

    private ICodegenType ConstructTypeRecursively(
        AsciiString typeName,
        TreePath root,
        IEnumerable<TreePath> children,
        Func<IReadOnlyList<ICodegenField>, CodegenStructureType>? fnMakeStruc = null)
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
            return MergeType(type, root, children);
        }

        // If we don't have any children, we shouldn't reach this point (in theory, though we do in practice).
        // We expect all leafs to be built-in/primitive types, or in other words, already added.
        if (children.Any())
        {
            // Special type handling! :) (arrays, etc, this handles the wrap-around).
            if (TryConstructSpecialType(root, children, out ICodegenType specialType))
            {
                return specialType;
            }

            List<ICodegenField> fields = [];

            // Check all immediate children, constructing fields from them.
            foreach (TreePath child in children.Where(x => x.Length == 1))
            {
                Debug.Assert(child.Length == 1);
                ICodegenType childType = ConstructTypeRecursively(child.Last.TypeName, child, children.Where(x => x.StartsWith(child)));
                fields.Add(new CodegenField(childType, child.Last.Name, child.Metadata.Flags));
            }

            CodegenStructureType strucType = fnMakeStruc?.Invoke(fields) ?? new(typeName, fields);
            Debug.Assert(strucType.Fields.Count != 0, $"Complex type with no fields? {strucType}");
            type = strucType;
        }
        else
        {
            Log.Write($"Non-builtin type {root} with no children. This is probably weird data.", ConsoleColor.Yellow);
            type = new CodegenForwardDeclType(typeName);
        }

        // We do a final check here to ensure that our type hasn't been added already.
        // This is necessary to resolve circular dependencies (e.g. A -> B -> C -> D -> B), which are present on some pointer types.
        if (TryFindType(typeName, out ICodegenType circularRefType))
        {
            Log.Write($"Circular dependency detected: {type} vs {circularRefType}", ConsoleColor.Yellow);
            return MergeType(circularRefType, root, children);
        }

        AddType(type);
        return type;
    }

    private bool TryConstructSpecialType(
        TreePath root,
        IEnumerable<TreePath> children,
        out ICodegenType type)
    {
        Debug.Assert(root.Length == 1);
        Debug.Assert(children.All(x => !x.StartsWith(root) && x.Length >= 1));

        AsciiString rootName = root.Last.Name;
        AsciiString rootTypeName = root.Last.TypeName;

        bool isPPtr = rootTypeName.StartsWith("PPtr<");
        bool isString = rootTypeName == "string";
        bool isDirectArray = rootTypeName == "vector" || rootTypeName == "staticvector";
        bool isIndirectArray = children.Count(x => x.Length == 1) == 1 && children.First() == "Array";
        bool isMap = rootTypeName == "map";
        bool isReferencedObjectRegistry = rootTypeName == "ManagedReferencesRegistry";
        bool isHash128 = rootTypeName == "Hash128";

        ICodegenType? specialType = null;

        // pptr -> { m_FileID, m_PathID }
        if (isPPtr)
        {
            Debug.Assert(children.Count() == 2);
            Debug.Assert(children.Count(x => x == "m_FileID") == 1);
            Debug.Assert(children.Count(x => x == "m_PathID") == 1);

            AsciiString typeName = rootTypeName[5..^1];
            if (typeName.StartsWith('$')) typeName = typeName[1..]; // idk what $ means
            specialType = new CodegenPPtrType(typeName);
        }
        // string -> (nested string, or char array)
        else if (isString)
        {
            Debug.Assert(children.Count(x => x.Length == 1) == 1);
            TreePath firstChild = children.First(x => x.Length == 1);

            // Strings can be nested.
            // If we hit one, just call ourselves recursively on it, which solves the problem.
            if (firstChild.First.TypeName == "string")
            {
                return TryConstructSpecialType(
                    firstChild,
                    children.Where(x => x.StartsWith(firstChild)).Skip(1).Select(x => x[1..]),
                    out type);
            }

            Debug.Assert(children.Count(x => x == "Array") == 1);
            Debug.Assert(children.Count(x => x == "Array/data") == 1);
            Debug.Assert(children.Count(x => x == "Array/size") == 1);

            specialType = new CodegenStringType();
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
                mapKey.Last.TypeName,
                mapKey[2..],
                children.Where(x => x.StartsWith(mapKey)).Select(x => x[2..]));

            ICodegenType mapValueType = ConstructTypeRecursively(
                mapValue.Last.TypeName,
                mapValue[2..],
                children.Where(x => x.StartsWith(mapValue)).Select(x => x[2..]));

            specialType = new CodegenMapType(mapKeyType, mapValueType);
        }
        // isDirectArray: vector -> { array { data, size ... } } where data is primitive type
        // isIndirectArray: (typename) -> array -> { data, size ... } } where data is a complex type
        else if (isDirectArray || isIndirectArray)
        {
            if (isIndirectArray)
            {
                root = children.First();

                Debug.Assert(root.Last.TypeName == "Array");
                Debug.Assert(children.Count(x => x == "Array/data") == 1);
                Debug.Assert(children.Count(x => x == "Array/size") == 1);

                children = children
                    .Where(x => x.StartsWith(root))
                    .Skip(1)
                    .Select(x => x[1..]);
            }

            TreePath arrayDataPath = children.First(x => x.Last.Name == "data");

            ICodegenType arrayDataType = ConstructTypeRecursively(
                arrayDataPath.Last.TypeName,
                arrayDataPath,
                children.Where(x => x.StartsWith(arrayDataPath)));

            specialType = new CodegenArrayType(arrayDataType);
        }
        // registry -> { a bunch of Bases of unique types ... }
        else if (isReferencedObjectRegistry)
        {
            List<ICodegenType> embeddedTypes = [];

            foreach (TreePath refRoot in children.Where(x => x == "Base"))
            {
                Debug.Assert(refRoot.Length == 1);
                embeddedTypes.Add(ConstructTypeRecursively(
                    refRoot.Last.TypeName,
                    refRoot,
                    children.Where(x =>
                        x.Metadata.TreeId == refRoot.Metadata.TreeId &&
                        x.StartsWith(refRoot))));
            }

            specialType = new CodegenRefRegistryType(embeddedTypes);
        }
        // this one has 16 1-byte fields using array syntax - wtf?
        else if (isHash128)
        {
            Debug.Assert(children.All(x => x.Last.Name.StartsWith("bytes[")));
            Debug.Assert(children.Count() == 16);

            specialType = new CodegenHash128Type();
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
        TreePath _,
        IEnumerable<TreePath> children)
    {
        if (type is CodegenStructureType struc)
        {
            // TODO These asserts fail. Sometimes there are same type names with different fields.
            // TODO This probably related to the hash manifest thing in TreeAnalysis.
            // TODO I think we will have to fragment each type by their field count...
            //
            // Debug.Assert(children.Count(x => x.Length == 1) == struc.Fields.Count);
            // Debug.Assert(children
            //    .Where(x => x.Length == 1)
            //    .All(x => struc.Fields
            //        .Any(y => x.First.Name == y.Name)));
        }

        return type;
    }

    private void AddType(
        ICodegenType type)
    {
        int typeIdx = _types.Count;
        _typesIndexLookup.Add(type.Name, typeIdx);
        _types.Add(type);
        LogVerbose(4, $"[{typeIdx}] = {type}", ConsoleColor.DarkYellow);
    }

    private bool TryFindType(
        AsciiString name,
        out ICodegenType type)
    {
        if (_typesIndexLookup.TryGetValue(name, out int typeIdx))
        {
            type = _types[typeIdx];
            LogVerbose(4, $"Found existing type {type} at [{typeIdx}] for {name}", ConsoleColor.DarkGreen);
            return true;
        }

        type = default!;
        LogVerbose(4, $"Didn't find type {name}", ConsoleColor.DarkRed);
        return false;
    }

    [Conditional("DEBUG_VERBOSE")]
    private void LogVerbose(int indent, string msg, ConsoleColor color = Log.DefaultColor) =>
        Log.Write(indent, msg, color);

    private readonly List<ICodegenType> _types = [];
    private readonly Dictionary<AsciiString, int> _typesIndexLookup = [];
}

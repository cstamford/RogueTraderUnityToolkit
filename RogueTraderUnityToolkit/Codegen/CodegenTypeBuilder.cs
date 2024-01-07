using RogueTraderUnityToolkit.Core;
using RogueTraderUnityToolkit.Tree;
using RogueTraderUnityToolkit.Unity.TypeTree;
using System.Diagnostics;

namespace RogueTraderUnityToolkit.Codegen;

public static class CodegenTypeBuilder
{
    static CodegenTypeBuilder()
    {
        foreach ((ObjectParserType type, AsciiString[] aliases) in ObjectParserNodeUtil.TypeAliases)
        {
            foreach (AsciiString alias in aliases)
            {
                CodegenPrimitiveType primitive = new(alias, type);
                _primitives.Add(alias, primitive);
            }
        }
    }

    public static CodegenRootType ReadTreeObject(
        TreePathObject obj,
        AsciiString typeName,
        Func<IReadOnlyList<CodegenStructureField>, CodegenStructureType> fnMakeStruc)
    {
        TreePath root = obj.Paths[0];
        Debug.Assert(root.Length == 1);

        Debug.Assert(root.Length == 1, "Root is not root? (ordering problem?)");
        Debug.Assert(obj.Paths.All(x => x.StartsWith(root)), "Paths not beginning with root?");

        CodegenType type = ConstructType(typeName, root, obj.Paths, fnMakeStruc);

        if (type is CodegenForwardDeclType)
        {
            // This can happen, sometimes, when the type is empty (optimized out in release, probably).
            // We just make an empty root type to hold it.
            return (CodegenRootType)fnMakeStruc(Array.Empty<CodegenStructureField>());
        }

        return (CodegenRootType)type;
    }

    private static CodegenType ConstructType(
        AsciiString typeName,
        TreePath root,
        IEnumerable<TreePath> children,
        Func<IReadOnlyList<CodegenStructureField>, CodegenStructureType>? fnMakeStruc = null)
    {
        Debug.Assert(root.Length == 1, "Root must be length 1");
        Debug.Assert(children.First() == root, "Children must include the root");
        Debug.Assert(children.All(x => x.StartsWith(root)), "All children must start with the root");

        children = children.Skip(1); // skip root

        if (children.Any())
        {
            // Snip off the root from all the children, so they're all length 1 or greater.
            Debug.Assert(children.All(x => x.Length >= 2));
            children = children.Select(x => x[1..]);
        }

        // Special type handling! :) (primitives, arrays, etc, this handles the wrap-around).
        if (TryConstructSpecialType(root, [.. children], out CodegenType specialType))
        {
            // This type won't be added to the type database: it's a built in.
            return specialType;
        }

        if (children.Any())
        {
            List<CodegenStructureField> fields = [];

            // Check all immediate children, constructing fields from them.
            foreach (TreePath child in children.Where(x => x.Length == 1))
            {
                Debug.Assert(child.Length == 1);
                CodegenType childType = ConstructType(child.Last.TypeName, child, [.. children.Where(x => x.StartsWith(child))]);
                fields.Add(new CodegenStructureField(childType, child.Last.Name,
                    (child.Last.Flags & ObjectParserNodeFlags.IsAlignTo4) != 0));
            }

            Debug.Assert(fields.Count != 0, $"Complex type with no fields?");

            return fnMakeStruc != null ?
                fnMakeStruc(fields) :
                new CodegenStructureType(typeName, fields);
        }

        // If we don't have any children, we shouldn't reach this point (in theory, though we do in practice).
        // We expect all leafs to be built-in/primitive types, or in other words, already added.

        Log.Write($"Non-builtin type {root} with no children. This is probably weird data.", ConsoleColor.Yellow);
        return new CodegenForwardDeclType(typeName);
    }

    private static bool TryConstructSpecialType(
        TreePath root,
        IEnumerable<TreePath> children,
        out CodegenType type)
    {
        Debug.Assert(root.Length == 1);
        Debug.Assert(children.All(x => !x.StartsWith(root) && x.Length >= 1));

        if (_primitives.TryGetValue(root.Last.TypeName, out CodegenPrimitiveType? primitive))
        {
            type = primitive;
            return true;
        }

        AsciiString rootName = root.Last.Name;
        AsciiString rootTypeName = root.Last.TypeName;

        bool isPPtr = rootTypeName.StartsWith("PPtr<");
        bool isString = rootTypeName == "string";
        bool isDirectArray = rootTypeName == "vector" || rootTypeName == "staticvector";
        bool isIndirectArray = children.Count(x => x.Length == 1) == 1 && children.First() == "Array";
        bool isTypelessDataArray = rootTypeName == "TypelessData";
        bool isMap = rootTypeName == "map";
        bool isReferencedObjectRegistry = rootTypeName == "ManagedReferencesRegistry";
        bool isHash128 = rootTypeName == "Hash128";

        CodegenType? specialType = null;

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

            CodegenType mapKeyType = ConstructType(
                mapKey.Last.TypeName,
                mapKey[2..],
                children.Where(x => x.StartsWith(mapKey)).Select(x => x[2..]));

            CodegenType mapValueType = ConstructType(
                mapValue.Last.TypeName,
                mapValue[2..],
                children.Where(x => x.StartsWith(mapValue)).Select(x => x[2..]));

            specialType = new CodegenMapType(mapKeyType, mapValueType);
        }
        // isDirectArray: vector -> { array { data, size ... } } where data is primitive type
        // isIndirectArray: (typename) -> array -> { data, size ... } } where data is a complex type
        // typelessdata -> { size, u8 ... }, where data is u8
        else if (isDirectArray || isIndirectArray || isTypelessDataArray)
        {
            if (isIndirectArray)
            {
                root = children.First();

                Debug.Assert(!isIndirectArray || root.Last.TypeName == "Array");
                Debug.Assert(!isIndirectArray || children.Count(x => x == "Array/data") == 1);
                Debug.Assert(!isIndirectArray || children.Count(x => x == "Array/size") == 1);

                children = children
                    .Where(x => x.StartsWith(root))
                    .Skip(1)
                    .Select(x => x[1..]);
            }

            TreePath arrayDataPath = children.First(x => x.Last.Name == "data");

            CodegenType arrayDataType = ConstructType(
                arrayDataPath.Last.TypeName,
                arrayDataPath,
                children.Where(x => x.StartsWith(arrayDataPath)));

            specialType = new CodegenArrayType(arrayDataType);
        }
        // registry -> { a bunch of Bases of unique types ... }
        else if (isReferencedObjectRegistry)
        {
            List<CodegenType> embeddedTypes = [];

            foreach (TreePath refRoot in children.Where(x => x == "Base"))
            {
                Debug.Assert(refRoot.Length == 1);
                embeddedTypes.Add(ConstructType(
                    refRoot.Last.TypeName,
                    refRoot,
                    children.Where(x =>
                        x.Metadata.TreeId == refRoot.Metadata.TreeId &&
                        x.StartsWith(refRoot))));
            }

            specialType = new CodegenRefRegistryType(embeddedTypes);
        }
        // we use this in core code a lot, so we have to alias it
        else if (isHash128)
        {
            Debug.Assert(children.All(x => x.Last.Name.StartsWith("bytes[")));
            Debug.Assert(children.Count() == 16);

            specialType = new CodegenHash128Type();
        }

        Debug.Assert(rootName != "Array" && rootTypeName != "Array",
            "We should have handled arrays already");

        if (specialType != null)
        {
            type = specialType;
            return true;
        }

        type = default!;
        return false;
    }

    private static readonly Dictionary<AsciiString, CodegenPrimitiveType> _primitives = [];
}

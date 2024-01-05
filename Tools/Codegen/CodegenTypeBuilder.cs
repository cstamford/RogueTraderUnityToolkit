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
        ICodegenType rootType = ConstructType(typeName, root, obj.Paths, fnMakeStruc);
        LogVerbose(0, $"Constructed {rootType}", ConsoleColor.DarkGray);

        return rootType;
    }

    private ICodegenType ConstructType(
        AsciiString typeName,
        TreePath root,
        IEnumerable<TreePath> children,
        Func<IReadOnlyList<ICodegenField>, CodegenStructureType>? fnMakeStruc = null)
    {
        // Grab this for later - it's necessary to merge types, if needed.
        IEnumerable<TreePath> originalChildren = children;

        // We expect our input such that: root (level 1) + all children (level 2+).
        Debug.Assert(root.Length == 1);
        Debug.Assert(children.First() == root);
        children = children.Skip(1); // skip root

        // If we have any children left, snip off the root.
        if (children.Any())
        {
            Debug.Assert(children.All(x => x.StartsWith(root) && x.Length >= 2));
            children = children.Select(x => x[1..]);
        }

        // Special type handling! :) (arrays, etc, this handles the wrap-around).
        if (TryConstructSpecialType(root, children, out ICodegenType specialType))
        {
            // This type won't be added to the type database: it's a built in.
            return specialType;
        }

        // Check if this type has been created before.
        if (TryFindType(typeName, out ICodegenType type))
        {
            // This may return an existing type (if a match) or a type alias (if not).
            return MergeType(typeName, type, root, children, originalChildren);
        }

        // If we don't have any children, we shouldn't reach this point (in theory, though we do in practice).
        // We expect all leafs to be built-in/primitive types, or in other words, already added.
        if (children.Any())
        {
            List<ICodegenField> fields = [];

            // Check all immediate children, constructing fields from them.
            foreach (TreePath child in children.Where(x => x.Length == 1))
            {
                Debug.Assert(child.Length == 1);
                ICodegenType childType = ConstructType(child.Last.TypeName, child, children.Where(x => x.StartsWith(child)));

                // TODO: This is bad! We're putting the flags on the field. This type will be cached and that cached copy returned,
                // TODO: but it will still have the flags from the original version. These flags are object-unique, not type-unique.
                // TODO: For now, I've used the aliasing system to hack around it so all reads are (mostly) correctly aligned.
                // TODO: However, the alignment is only correct one level deep.
                // TODO: To fix this, I need to add the align flag to each individual path entry, and calculate align per-field when we create it.
                // TODO: This is actually pretty easy to do - I can just put the parser flag node on the entry.
                // TODO: Note to self: Align goes AFTER each field read, not before.
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
            return MergeType(typeName, circularRefType, root, children, originalChildren);
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
        bool isTypelessDataArray = rootTypeName == "TypelessData";
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

            ICodegenType mapKeyType = ConstructType(
                mapKey.Last.TypeName,
                mapKey[2..],
                children.Where(x => x.StartsWith(mapKey)).Select(x => x[2..]));

            ICodegenType mapValueType = ConstructType(
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

            ICodegenType arrayDataType = ConstructType(
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

        // We should have handled arrays already, so if we reach this point, it's a bug.

        Debug.Assert(rootName != "Array");
        Debug.Assert(rootTypeName != "Array");

        if (specialType != null)
        {
            type = specialType;
            return true;
        }

        type = default!;
        return false;
    }

    private ICodegenType MergeType(
        AsciiString typeName,
        ICodegenType type,
        TreePath root,
        IEnumerable<TreePath> children,
        IEnumerable<TreePath> originalChildren)
    {
        if (type is CodegenStructureType struc)
        {
            // Great! We're a direct match. :)
            if (struc.Equals(children)) return type;

            // Find any aliases this type might already have.
            if (_typeAliases.TryGetValue(type.Name, out List<CodegenStructureType>? aliasTypes))
            {
                ICodegenType? match = aliasTypes.FirstOrDefault(x => x.Equals(children));

                if (match != null)
                {
                    LogVerbose(0, $"Found alias for {typeName}! Original: {type}, alias: {match}.", ConsoleColor.Green);
                    return match;
                }
            }
            else
            {
                aliasTypes = [];
                _typeAliases.Add(typeName, aliasTypes);
            }

            // This is the worst outcome. We will have to generate a new name for it, then create it and return that alias.
            AsciiString newTypeName = AsciiString.From($"{typeName}{aliasTypes.Count}");
            Log.Write($"Aliasing {typeName} to {newTypeName}", ConsoleColor.DarkYellow);
            CodegenStructureType aliasType = (CodegenStructureType)ConstructType(newTypeName, root, originalChildren);
            aliasTypes.Add(aliasType);
            return aliasType;
        }

        Debug.Assert(type is CodegenBuiltInType, $"We should never reach this point with a non-primitive type, but we got {type}");

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
    private readonly Dictionary<AsciiString, List<CodegenStructureType>> _typeAliases = [];
}

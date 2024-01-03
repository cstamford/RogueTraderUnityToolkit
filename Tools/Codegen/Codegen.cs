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

        foreach ((UnityObjectType type, IEnumerable<TreePathObject> objs) in report.AllPathObjects
            .GroupBy(x => x.Key.Type)
            .Select(x => (x.Key, x.Select(y => y.Key))))
        {
            bool isGameType = type == UnityObjectType.MonoBehaviour;
            Debug.Assert(isGameType || objs.Count() == 1);

            // Game script types have a bunch of fragments - only process the one with the lowest field count as the base object.
            TreePathObject obj = isGameType ? objs.MinBy(x => x.Paths.Count) : objs.First();
            AsciiString objName = AsciiString.From(obj.Type.ToString());
            ICodegenType codegenType = ReadTreeObject(obj, objName, CodegenTypeFlags.IsEngineType);
            _baseGameType = isGameType ? codegenType : _baseGameType;
        }

        Debug.Assert(_baseGameType != null);
    }

    public void ReadGameStructures(
        TreeReport report,
        Dictionary<Hash128, AsciiString> scriptTypeNames)
    {
        foreach ((TreePathObject obj, int _) in report.AllPathObjects
            .Where(x => x.Key.Type == UnityObjectType.MonoBehaviour))
        {
            if (scriptTypeNames.TryGetValue(obj.ScriptHash, out AsciiString scriptName))
            {
                ReadTreeObject(obj, scriptName, CodegenTypeFlags.IsGameType);
                continue;
            }

            Log.Write($"Could not resolve game script type for {obj.ScriptHash}", ConsoleColor.Yellow);
        }
    }

    public void WriteStructures(string path)
    {
        CodegenCSharpWriter writer = new(_types, _typesIndexLookup);

        List<AsciiString> allMissingTypes = [];
        HashSet<ICodegenType> visited = [];

        HashSet<AsciiString> rootTypes = Enum.GetValues<UnityObjectType>()
            .Select(x => AsciiString.From(x.ToString()))
            .ToHashSet();

        IEnumerable<ICodegenType> rootStructures = _types
            .Select((x, i) => (x, i))
            .Where(x => rootTypes.Contains(x.x.Name))
            .OrderBy(x => x.x.Name)
            .Select(x => _types[x.i]);

        foreach (ICodegenType rootType in rootStructures)
        {
            Debug.Assert(rootType is CodegenStructureType);

            bool isGameType = (rootType.Flags & CodegenTypeFlags.IsGameType) != 0;
            string rootTypeSubDir = isGameType ? "Game" : "Engine";
            string rootTypeDir = Path.Combine(path, rootTypeSubDir);
            Directory.CreateDirectory(rootTypeDir);

            string rootTypeFile = Path.Combine(rootTypeDir, $"{rootType.Name}.cs");
            using StreamWriter rootTypeWriter = File.CreateText(rootTypeFile);

            writer.WriteHeader(rootTypeWriter, $"Generated.{rootTypeSubDir}", isGameType ? ["Engine"] : []);
            writer.WriteType(rootTypeWriter, rootType, out AsciiString[] missingTypes);

            allMissingTypes.AddRange(missingTypes);
            visited.Add(rootType);
        }

        string referencedTypesFile = Path.Combine(path, $"ReferencedTypes.cs");
        using StreamWriter referencedTypesWriter = File.CreateText(referencedTypesFile);
        writer.WriteHeader(referencedTypesWriter, "Generated", ["Engine"]);

        foreach (ICodegenType otherType in _types.Where(x => !visited.Contains(x)))
        {
            writer.WriteType(referencedTypesWriter, otherType, out AsciiString[] missingTypes);
            allMissingTypes.AddRange(missingTypes);
            visited.Add(otherType);
        }

        allMissingTypes = [..allMissingTypes.Distinct()];

        if (allMissingTypes.Count > 0)
        {
            Log.WriteSingle($"Writing missing types: ", ConsoleColor.Yellow);
            Log.WriteSingle(string.Join(", ", allMissingTypes.Take(3).Select(x => x.ToString())), ConsoleColor.Yellow);
            Log.Write(allMissingTypes.Count > 3 ? $", {allMissingTypes.Count - 3} more..." : "", ConsoleColor.Yellow);

            foreach (AsciiString typeName in allMissingTypes)
            {
                writer.WriteType(referencedTypesWriter, new CodegenForwardDeclType(typeName), out _);
            }
        }

        Debug.Assert(visited.Count == _types.Count);
    }

    private ICodegenType ReadTreeObject(
        TreePathObject obj,
        AsciiString typeName,
        CodegenTypeFlags flags)
    {
        // Grab all the children, ordering by length. (the first entry will be the root node).
        IEnumerable<TreePath> children = obj.Paths.OrderBy(x => x.Length);
        TreePath root = children.First();

        Debug.Assert(root.Length == 1, "Root is not root? (ordering problem?)");
        Debug.Assert(children.All(x => x.StartsWith(root)), "Paths not beginning with root?");

        // Create the type, which will recursively create its subtypes.
        ICodegenType rootType = ConstructTypeRecursively(typeName, root, children, flags);
        LogVerbose(0, $"Constructed {rootType}", ConsoleColor.DarkGray);

        return rootType;
    }

    private ICodegenType ConstructTypeRecursively(
        AsciiString typeName,
        TreePath root,
        IEnumerable<TreePath> children,
        CodegenTypeFlags flags = CodegenTypeFlags.None)
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
                fields.Add(new CodegenField(childType, child.Last.Name));
            }

            CodegenStructureType rootType = new(typeName, fields, flags);
            Debug.Assert(rootType.Fields.Count != 0, $"Complex type with no fields? {rootType}");
            type = rootType;
        }
        else
        {
            Log.Write($"Non-builtin type {root} with no children. This is probably weird data.", ConsoleColor.Yellow);
            type = new CodegenForwardDeclType(typeName);
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
            children = children.Distinct(); // ensure we trim duplicate paths, since we get one per entry

            foreach ((AsciiString embeddedTypeName, TreePath embeddedTypeRoot) in children
                .Where(x => x == "Base")
                .GroupBy(x => x.Last.TypeName)
                .Select(x => (x.Key, x.First())))
            {
                embeddedTypes.Add(ConstructTypeRecursively(
                    embeddedTypeName,
                    embeddedTypeRoot,
                    children.Where(x => x.StartsWith(embeddedTypeRoot))));
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
    private void LogVerbose(int indent, string msg, ConsoleColor color) => Log.Write(indent, msg, color);

    private readonly List<ICodegenType> _types = [];
    private readonly Dictionary<AsciiString, int> _typesIndexLookup = [];
    private readonly ICodegenType _baseGameType = default!;
}

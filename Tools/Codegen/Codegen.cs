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

        foreach (TreePathObject pathObject in report.AllPathObjects.Keys)
        {
            // Grab all the children, ordering by length. (the first entry will be the root node).
            IEnumerable<TreePath> children = pathObject.Paths.OrderBy(x => x.Length);
            TreePath root = children.First();

            Debug.Assert(root.Length == 1, "Root is not root? (ordering problem?)");
            Debug.Assert(children.All(x => x.StartsWith(root)), "Paths not beginning with root?");

            AsciiString typeName = root.Last.TypeName;

            if (pathObject.Type == UnityObjectType.MonoBehaviour)
            {
                // TODO: Script names are stored in MonoScript
                continue;
            }

            if (pathObject.Type != UnityObjectType.MonoScript)
            {
                // TODO: First steps...
                continue;
            }

            // Create the type, which will recursively create its subtypes.
            ICodegenType rootType = ConstructTypeRecursively(typeName, root, children);
            LogVerbose(0, $"Constructed {rootType}", ConsoleColor.DarkGray);
        }
    }

    public void WriteStructures(string path)
    {
        CodegenCSharpWriter writer = new(_types, _typesIndexLookup);

        HashSet<ICodegenType> visited = [];

        HashSet<AsciiString> rootTypes = Enum.GetValues<UnityObjectType>()
            .Select(x => AsciiString.From(x.ToString()))
            .ToHashSet();

        IEnumerable<ICodegenType> rootStructures = _types
            .Select((x, i) => (x, i))
            .Where(x => rootTypes.Contains(x.x.Name))
            .OrderBy(x => x.x.Name)
            .Select(x => _types[x.i]);

        List<AsciiString> allMissingTypes = [];

        foreach (ICodegenType rootType in rootStructures)
        {
            Debug.Assert(rootType is CodegenStructureType);

            string rootTypeFile = Path.Combine(path, $"{rootType.Name}.cs");
            using StreamWriter rootTypeWriter = File.CreateText(rootTypeFile);

            writer.WriteHeader(rootTypeWriter);
            writer.WriteType(rootTypeWriter, rootType, out AsciiString[] missingTypes);

            allMissingTypes.AddRange(missingTypes);
            visited.Add(rootType);

            foreach (ICodegenType fragment in _types
                .Where(x => x.Name.StartsWith($"{rootType.Name}_")))
            {
                writer.WriteType(rootTypeWriter, fragment, out missingTypes);

                allMissingTypes.AddRange(missingTypes);
                visited.Add(fragment);
            }
        }

        string referencedTypesFile = Path.Combine(path, $"ReferencedTypes.cs");
        using StreamWriter referencedTypesWriter = File.CreateText(referencedTypesFile);
        writer.WriteHeader(referencedTypesWriter);

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

            CodegenStructureType rootType = new(typeName, fields);
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
        bool isDirectArray = rootTypeName == "vector" || rootTypeName == "staticvector";
        bool isIndirectArray = children.Count(x => x.Length == 1) == 1 && children.First() == "Array";
        bool isMap = rootTypeName == "map";
        bool isReferencedObjectRegistry = rootTypeName == "ManagedReferencesRegistry";
        bool isHash128 = rootTypeName == "Hash128";

        ICodegenType? specialType = null;

        // pptr => { m_FileID, m_PathID }
        if (isPPtr)
        {
            Debug.Assert(children.Count() == 2);
            Debug.Assert(children.Count(x => x == "m_FileID") == 1);
            Debug.Assert(children.Count(x => x == "m_PathID") == 1);

            AsciiString typeName = rootTypeName[5..^1];
            if (typeName.StartsWith('$')) typeName = typeName[1..]; // idk what $ means
            specialType = new CodegenPPtrType(typeName);
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
}

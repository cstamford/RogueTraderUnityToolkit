using RogueTraderUnityToolkit.Core;
using RogueTraderUnityToolkit.Unity;
using System.Diagnostics;

namespace Codegen;

public class Codegen(ComplexTypeReport complexTypes)
{
    public void Analyse()
    {
        // Construct all primitive types.
        foreach (ObjectParserType parserType in Enum.GetValues<ObjectParserType>())
        {
            CodegenPrimitive primitive = ConstructPrimitiveType(parserType);
            Log.Write($"Constructed primitive type {primitive.Name} ({primitive.CSharpType})");
        }

        Dictionary<TreePath, int> paths = complexTypes.AllPaths;

        // Construct all root types, e.g. path length == 1 (parents length == 0).
        foreach ((TreePath root, int rootRefs) in paths.Where(x => x.Key.Parents.Length == 0))
        {
            // Select all the fields that start with this field. Basically, our overlapping/interested set.
            Debug.Assert(rootRefs > 0, "Why does a root have no references? (how did it get here?)");
            KeyValuePair<TreePath, int>[] fields = [..paths.Where(x => x.Key != root && x.Key.StartsWith(root.Self))];

            // TODO: Sometimes the base has fewer references than some paths including base.
            // I think this is a bug related to arrays.
            Debug.Assert(fields.All(x => x.Value <= rootRefs), "Why does a child have more refs than its root?");

            // Select all the fields that reference this root path every time it has been references.
            // They are our root's guaranteed (100%) fields.
            TreePath[] rootBaseFields = fields
                .Where(x => true /* TODO x.Value == rootRefs*/)
                .Select(x => x.Key.Slice(1))
                .Order()
                .ToArray();

            if (rootBaseFields.Length == 0)
            {
                // If we reach this point, our type won't have any fields - but its children will. Weird, but OK.
                Log.Write($"Complex type {root.Self.TypeName} had 0 base fields, " +
                          $"{fields.Length} total fields, " +
                          $"and was referenced {rootRefs} times");
            }

            // Select all the data that is NOT fully referenced, and group it by the reference count.
            // This maps nicely (albeit, not always accurately) to inheritance hierarchies.
            // TODO: Sometimes two different subgroups of objects have the same refcount.

            IEnumerable<TreePath[]> rootSubobjects = fields
                .Where(x => false /* TODO x.Value < rootRefs */)
                .GroupBy(x => x.Value)
                .OrderByDescending(x => x.Key)
                .Select(x => x.Select(y => y.Key.Slice(1)).Order().ToArray());

            ICodegenType rootType = ConstructType(root.Self.TypeName, rootBaseFields);
            IEnumerable<ICodegenType> subTypes = rootSubobjects
                .Select((x, i) => ConstructType(AsciiString.From($"{rootType.Name}_SubType{i}"), x));

            Log.Write($"Constructed complex type {rootType.Name} with subTypes = [ " +
                      $"{string.Join(", ", subTypes.Select(x => x.Name.ToString()))} " +
                      $"]");
        }
    }

    public void WriteStructures(string rootDir)
    {
        foreach (CodegenStruct type in _types.OfType<CodegenStruct>())
        {
            // TODO
        }
    }

    private CodegenPrimitive ConstructPrimitiveType(
        ObjectParserType type,
        CodegenTypeFlags flags = CodegenTypeFlags.None)
    {
        CodegenPrimitive primitiveType = new(type, flags);

        _parserTypeIndexLookup.Add(type, _types.Count);
        _types.Add(primitiveType);

        return primitiveType;
    }

    private ICodegenType ConstructType(
        AsciiString name,
        TreePath[] paths,
        CodegenTypeFlags flags = CodegenTypeFlags.None)
    {
        if (_typesIndexLookup.TryGetValue(name, out int typeIdx))
        {
            ICodegenType existingType = _types[typeIdx];

            // TODO: We still need to verify that existing fields match what we currently have.
            // TODO: We might have to merge, though I feel like we shouldn't...

            return existingType;
        }

        List<ICodegenField> fields = [];

        foreach (TreePath path in paths
            .Where(x => x.Parents.Length == 0))
        {
            TreePathEntry pathEntry = path.Self;
            ICodegenType? fieldType = null;

            // Complex type. We need to gather its children, and either merge them into the existing type,
            // or use them to recursively create a new type.
            if (pathEntry.Type == ObjectParserType.Complex)
            {
                TreePath[] pathChildren = paths
                    .Where(x => x.Parents.Length == 1 && x[0] == pathEntry)
                    .Select(x => x.Slice(1))
                    .ToArray();

                if (pathChildren.Length == 0)
                {
                    bool isBuiltin = (pathEntry.Flags & ObjectParserNodeFlags.IsBuiltin) != 0;
                    Debug.Assert(!isBuiltin, "Builtins should follow the primitive parsing path.");

                    // TODO: Handle array. But tbh, it will go builtin soon so just leave it for now.
                    bool isArray = (pathEntry.Flags & ObjectParserNodeFlags.IsArray) != 0;
                    //Debug.Assert(isArray, "Complex field with no children that isn't an empty array!?");
                }
                else
                {
                    fieldType = ConstructType(pathEntry.TypeName, pathChildren);
                }
            }
            // Primitive type. They're already created!
            else
            {
                int idx = _parserTypeIndexLookup[pathEntry.Type];
                fieldType = _types[idx];
            }

            if (fieldType == null)
            {
                Console.WriteLine($"Could not resolve field {pathEntry} from {name}.", ConsoleColor.Yellow);
                continue;
            }

            CodegenField field = new(pathEntry.Name, fieldType, CodegenFieldFlags.None);
            fields.Add(field);
        }

        CodegenStruct type = new(name, fields.ToArray(), flags);

        _typesIndexLookup.Add(name, _types.Count);
        _types.Add(type);

        return type;
    }

    private readonly List<ICodegenType> _types = [];
    private readonly Dictionary<AsciiString, int> _typesIndexLookup = [];
    private readonly Dictionary<ObjectParserType, int> _parserTypeIndexLookup = [];
}

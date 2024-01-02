using RogueTraderUnityToolkit.Core;
using RogueTraderUnityToolkit.Unity.TypeTree;

namespace Codegen;

public class Codegen(TreeReport report)
{
    public void Analyse()
    {
        // Construct all primitive types.
        foreach (ObjectParserType parserType in Enum.GetValues<ObjectParserType>())
        {
            CodegenPrimitive primitive = ConstructPrimitiveType(parserType);
            Log.Write($"Constructed primitive type {primitive.Name} ({primitive.CSharpType})");
        }

        //  TODO


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
                    // Empty complex type. There are some of these in data.
                    // TODO: Deal with them
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

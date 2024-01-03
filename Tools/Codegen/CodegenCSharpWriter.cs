using RogueTraderUnityToolkit.Core;

namespace Codegen;

public readonly struct CodegenCSharpWriter(
    IReadOnlyList<ICodegenType> types,
    IReadOnlyDictionary<AsciiString, int> typesIndexLookup)
{
    public void WriteHeader(TextWriter writer)
    {
        writer.WriteLine($"namespace RogueTraderUnityToolkit.UnityStructures.Generated;");
        writer.WriteLine();
    }

    public void WriteType(ICodegenType type, TextWriter writer)
    {
        writer.WriteLine($"/* {type} */");
        writer.WriteLine($"internal struct {type.Name}");
        writer.WriteLine("{");
        writer.WriteLine("    /* raw fields:");

        if (type is CodegenStructureType struc)
        {
            foreach (ICodegenField field in struc.Fields)
            {
                writer.WriteLine($"    {field.Type.Name} {field.Name}");
            }
        }

        writer.WriteLine($"    */");
        writer.WriteLine("}");
        writer.WriteLine();
    }
}

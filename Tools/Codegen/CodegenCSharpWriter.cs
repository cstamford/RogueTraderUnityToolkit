using RogueTraderUnityToolkit.Core;
using System.Diagnostics;

namespace Codegen;

public readonly struct CodegenCSharpWriter(
    IReadOnlyList<ICodegenType> types,
    IReadOnlyDictionary<AsciiString, int> typesIndexLookup)
{
    public void WriteHeader(TextWriter writer)
    {
        writer.Write(0, $"namespace RogueTraderUnityToolkit.UnityStructures.Generated;");
        writer.Write(0, "");
        writer.Write(0, "using RogueTraderUnityToolkit.Core;");
        writer.Write(0, "using RogueTraderUnityToolkit.Unity.File;");
        writer.Write(0, "");
    }

    public void WriteType(TextWriter writer, ICodegenType type, out AsciiString[] missingTypes)
    {
        Debug.Assert(_missingTypes.Count == 0);

        if (type is CodegenBuiltInType)
        {
            missingTypes = [];
            return;
        }

        if (type is CodegenStructureType struc)
        {
            Debug.Assert(struc.Fields.Any());

            string strucType = struc.Fields.All(x => x.Type is CodegenBuiltInType) ? "readonly record struct" : "record class";

            writer.Write(0, $"/* {type} */");
            writer.Write(0, $"public {strucType} {type.Name}");
            writer.Write(0, "{");

            foreach (ICodegenField field in struc.Fields)
            {
                writer.Write(4, $"{GetFieldTypeNameRecursive(field.Type)} {field.Name};");
            }

            writer.Write(4, $"static {type.Name} Read(EndianBinaryReader reader)");
            writer.Write(4, "{");

            List<string> varNames = [];

            foreach (ICodegenField field in struc.Fields)
            {
                string fieldTypeName = GetFieldTypeNameRecursive(field.Type);

                string fieldRead = field.Type switch
                {
                    CodegenBuiltInType readBuiltIn => $"{fieldTypeName} {field.Name} = reader.Read{readBuiltIn.Type}();",
                    CodegenStructureType readStruc => $"{fieldTypeName} {field.Name} = {readStruc.Name}.Read(reader);",
                    _ => string.Empty
                };

                writer.Write(8, fieldRead == string.Empty ? $"// no read logic for {field.Type.Name} {field.Name}" : fieldRead);
                varNames.Add(fieldRead == string.Empty ? "default" : field.Name.ToString());
            }

            writer.Write(8, $"return new({string.Join($",\n{' '.Repeat(12)}", varNames)});");
            writer.Write(4, "}");
            writer.Write(0, "}");
            writer.Write(0, "");
        }

        missingTypes = _missingTypes.ToArray();
        _missingTypes.Clear();
    }

    private readonly HashSet<AsciiString> _missingTypes = [];

    private string GetFieldTypeNameRecursive(ICodegenType type) => type switch
    {
        CodegenArrayType array => $"{GetFieldTypeNameRecursive(array.DataType)}[]",
        CodegenBuiltInType builtin =>  builtin.CSharpType switch
        {
            { } t when t == typeof(ulong) => "ulong",
            { } t when t == typeof(uint) => "uint",
            { } t when t == typeof(ushort) => "ushort",
            { } t when t == typeof(byte) => "byte",
            { } t when t == typeof(long) => "long",
            { } t when t == typeof(int) => "int",
            { } t when t == typeof(short) => "short",
            { } t when t == typeof(sbyte) => "sbyte",
            { } t when t == typeof(double) => "double",
            { } t when t == typeof(float) => "float",
            { } t when t == typeof(bool) => "bool",
            { } t when t == typeof(char) => "char",
            { } t when t == typeof(string) => "AsciiString",
            _ => throw new()
        },
        CodegenMapType map => $"Dictionary<{GetFieldTypeNameRecursive(map.KeyType)}, {GetFieldTypeNameRecursive(map.ValueType)}>",
        CodegenPPtrType pptr => $"PPtr<{GetTypeNameFromReference(pptr.TypeName)}>",
        _ => type.Name.ToString()
    };

    private string GetTypeNameFromReference(AsciiString typeName)
    {
        if (!typesIndexLookup.TryGetValue(typeName, out int typeIdx))
        {
            _missingTypes.Add(typeName);
            return typeName.ToString();
        }

        return types[typeIdx].Name.ToString();
    }
}

public static class CodegenCSharpWriterExtensions
{
    public static void Write(this TextWriter writer, int indent, string str)
    {
        writer.WriteLine($"{' '.Repeat(indent)}{str}");
    }

    public static void WriteSingle(this TextWriter writer, int indent, string str)
    {
        writer.Write($"{' '.Repeat(indent)}{str}");
    }
}

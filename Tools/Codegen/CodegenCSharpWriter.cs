using RogueTraderUnityToolkit.Core;
using System.Diagnostics;

namespace Codegen;

public readonly partial struct CodegenCSharpWriter(
    IReadOnlyList<ICodegenType> types,
    IReadOnlyDictionary<AsciiString, int> typesIndexLookup)
{
    public void WriteHeader(
        TextWriter writer,
        string inNamespace,
        IEnumerable<string> usingNamespace)
    {
        writer.WriteSingle(0, $"namespace RogueTraderUnityToolkit.UnityGenerated.Types");
        writer.Write(0, string.IsNullOrEmpty(inNamespace) ? ";" : $".{inNamespace};");
        writer.Write(0, "");
        writer.Write(0, "using Core;");
        writer.Write(0, "using Unity;");

        foreach (string usingNs in usingNamespace.Where(x => !string.IsNullOrEmpty(x)))
        {
            writer.Write(0, $"using {usingNs};");
        }

        writer.Write(0, "");
    }

    public void WriteType(
        TextWriter writer,
        ICodegenType type,
        out AsciiString[] missingTypes)
    {
        Debug.Assert(_missingTypes.Count == 0);

        if (type is CodegenStructureType struc)
        {
            Debug.Assert(struc.Fields.Any());

            string strucType = struc.Fields.All(x => x.Type is CodegenBuiltInType) ? "readonly record struct" : "record class";

            string typeName = SanitizeName(type.Name.ToString());

            string[] fieldNames = new string[struc.Fields.Count];
            string[] fieldVarNames = new string[struc.Fields.Count];
            string[] fieldTypeNames = new string[struc.Fields.Count];

            // Calculate the sanitized field names for each field.
            for (int i = 0; i < fieldTypeNames.Length; ++i)
            {
                fieldNames[i] = SanitizeName($"{struc.Fields[i].Name}");
                fieldVarNames[i] = SanitizeName($"_{struc.Fields[i].Name}");
                fieldTypeNames[i] = GetFieldTypeName(struc.Fields[i].Type);
            }

            // Some types have the same field name as the field's type name, which is a compile error.
            // If that is the case, we just recalculate them with an extra underscore.
            for (int i = 0; i < fieldTypeNames.Length; ++i)
            {
                if (fieldTypeNames.Any(x => x == fieldNames[i]))
                {
                    fieldNames[i] = SanitizeName($"_{struc.Fields[i].Name}");
                    fieldVarNames[i] = SanitizeName($"__{struc.Fields[i].Name}");
                }
            }

            writer.Write(0, $"/* {type} */");

            writer.Write(0, $"public {strucType} {typeName}(");

            writer.WriteSingle(4, string.Join(
                $",\n{' '.Repeat(4)}",
                struc.Fields.Select((_, i) => $"{fieldTypeNames[i]} {fieldNames[i]} /* {struc.Fields[i].Flags} */")));
            writer.WriteSingle(0, ")");

            if (struc is CodegenEngineStructureType rootStruc)
            {
                writer.Write(0, " : IUnityObject");
                writer.Write(0, "{");
                writer.WriteSingle(4, $"public static Hash128 Hash => new(");
                writer.WriteSingle(0, $"{rootStruc.Hash.Uint0}, ");
                writer.WriteSingle(0, $"{rootStruc.Hash.Uint1}, ");
                writer.WriteSingle(0, $"{rootStruc.Hash.Uint2}, ");
                writer.Write(0, $"{rootStruc.Hash.Uint3});");
            }
            else
            {
                writer.Write(0, "\n{");
            }

            writer.Write(4, $"public static {typeName} Read(EndianBinaryReader reader)");
            writer.Write(4, "{");

            for (int i = 0; i < fieldTypeNames.Length; ++i)
            {
                if ((struc.Fields[i].Flags & TreePathFlags.NeedsAlign) != 0)
                {
                    writer.Write(8, Align(fieldNames[i]));
                }

                writer.Write(8, $"{fieldTypeNames[i]} {fieldVarNames[i]} = {GetFieldTypeReader(struc.Fields[i].Type)};");
            }

            writer.Write(8, "");
            writer.Write(8, $"return new({string.Join($",\n{' '.Repeat(12)}", fieldVarNames)});");
            writer.Write(4, "}");
            writer.Write(0, "}");
            writer.Write(0, "");
        }

        if (type is CodegenForwardDeclType)
        {
            writer.Write(0, $"/* forward decl {type} (no type info) */");
            writer.Write(0, $"public record struct {SanitizeName(type.Name.ToString())};");
        }

        missingTypes = _missingTypes.ToArray();
        _missingTypes.Clear();
    }

    public static string Align(string name) => $"reader.AlignTo(4); /* {name} */";

    private readonly HashSet<AsciiString> _missingTypes = [];

    private static readonly HashSet<string> _csharpKeywords =
    [
        "abstract", "as", "base", "bool", "break", "byte", "case", "catch", "char", "checked", "class",
        "const", "continue", "decimal", "default", "delegate", "do", "double", "else", "enum", "event",
        "explicit", "extern", "false", "finally", "fixed", "float", "for", "foreach", "goto", "if",
        "implicit", "in", "int", "interface", "internal", "is", "lock", "long", "namespace", "new",
        "null", "object", "operator", "out", "override", "params", "private", "protected", "public",
        "readonly", "ref", "return", "sbyte", "sealed", "short", "sizeof", "stackalloc", "static",
        "string", "struct", "switch", "this", "throw", "true", "try", "typeof", "uint", "ulong",
        "unchecked", "unsafe", "ushort", "using", "virtual", "void", "volatile", "while", "add",
        "alias", "ascending", "async", "await", "by", "descending", "dynamic", "equals", "from", "get",
        "global", "group", "into", "join", "let", "nameof", "on", "orderby", "partial", "remove",
        "select", "set", "value", "var", "when", "where", "yield"
    ];

    private string GetFieldTypeName(ICodegenType type) => type switch
    {
        CodegenArrayType array => $"{GetFieldTypeName(array.DataType)}[]",
        CodegenBuiltInType builtin => builtin.CSharpType switch
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
        CodegenMapType map => $"Dictionary<{GetFieldTypeName(map.KeyType)}, {GetFieldTypeName(map.ValueType)}>",
        CodegenRefRegistryType _ => "RefRegistry",
        CodegenPPtrType pptr => $"PPtr<{GetTypeNameFromReference(pptr.TypeName)}>",
        _ => SanitizeName(type.Name.ToString())
    };

    private string GetFieldTypeReader(ICodegenType type) => type switch
    {
        CodegenArrayType array => $"BuiltInArray<{GetFieldTypeName(array.DataType)}>.Read(reader)",
        CodegenBuiltInType builtIn => $"reader.Read{builtIn.Type}()",
        CodegenMapType map => $"BuiltInMap<{GetFieldTypeName(map.KeyType)}, {GetFieldTypeName(map.ValueType)}>.Read(reader)",
        CodegenRefRegistryType registry => $"default! /* {registry} */",
        CodegenStringType => "BuiltInString.Read(reader)",
        CodegenForwardDeclType decl => $"default! /* {decl} */",
        _ => $"{GetFieldTypeName(type)}.Read(reader)"
    };

    private string GetTypeNameFromReference(AsciiString typeName)
    {
        if (!typesIndexLookup.TryGetValue(typeName, out int typeIdx))
        {
            _missingTypes.Add(typeName);
            return SanitizeName(typeName.ToString());
        }

        return SanitizeName(types[typeIdx].Name.ToString());
    }

    private static string SanitizeName(string str) =>
        SanitizeCSharpKeywords(
            SanitizeArrayNames().Replace(str, "_$1") // transform [n] to _n
                .Replace(' ', '_')
                .Replace("`", "_") // type variants (like TypeName`1)
                .Replace("<", "__") // compiler generated field like <length>k__BackingField
                .Replace(">", "__") // see above
                .Replace("?", "__")); // some field have weird formatting, like Base/m_??ancelButtonLabel (it's a special C)

    private static string SanitizeCSharpKeywords(string name) => _csharpKeywords.Contains(name) ? "@" + name : name;

    [System.Text.RegularExpressions.GeneratedRegex(@"\[\s*(\d+)\s*\]")]
    private static partial System.Text.RegularExpressions.Regex SanitizeArrayNames();
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

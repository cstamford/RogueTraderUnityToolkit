using RogueTraderUnityToolkit.Core;
using System.Diagnostics;
using System.Text;

namespace RogueTraderUnityToolkit.Codegen;

public readonly partial struct CodegenCSharpWriter
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
        writer.Write(0, "using System.Text;");
        writer.Write(0, "using Unity;");

        foreach (string usingNs in usingNamespace.Where(x => !string.IsNullOrEmpty(x)))
        {
            writer.Write(0, $"using {usingNs};");
        }

        writer.Write(0, "");
    }

    public void WriteType(TextWriter writer, CodegenType type)
    {
        if (type is CodegenStructureType struc)
        {
            string[] fieldNames = new string[struc.Fields.Count];
            string[] fieldVarNames = new string[struc.Fields.Count];
            string[] fieldTypeNames = new string[struc.Fields.Count];

            // Calculate the sanitized field names for each field.
            for (int i = 0; i < struc.Fields.Count; ++i)
            {
                fieldNames[i] = GetFieldName(struc.Fields[i]);
                fieldVarNames[i] = $"{fieldNames[i]}_";
                fieldTypeNames[i] = GetFieldTypeName(struc.Fields[i].Type);
            }

            string strucType = struc is not CodegenRootType &&
                struc.Fields.All(x => x.Type is CodegenPrimitiveType)
                ? "readonly record struct"
                : "record class";

            string typeName = SanitizeName(type.Name.ToString());
            string fieldList = string.Join($",\n{' '.Repeat(4)}", fieldNames.Select((fieldName, i) => $"{fieldTypeNames[i]} {fieldName}"));

            writer.Write(0, $"/* {type} */");
            writer.WriteSingle(0, $"public {strucType} {typeName} (");
            writer.WriteSingle(4, $"{fieldList}) : ");

            if (struc is CodegenRootType root)
            {
                writer.Write(0, root.IsEngineType ? "IUnityEngineStructure" : "IUnityGameStructure");
                writer.Write(0, "{");
                writer.Write(4, $"public static UnityObjectType ObjectType => UnityObjectType.{root.Type};");
                writer.Write(4, $"public static Hash128 Hash => new(\"{root.Hash}\");");
            }
            else
            {
                writer.Write(0, "IUnityStructure");
                writer.Write(0, "{");
            }

            writer.WriteSingle(4, $"public static {typeName} Read(EndianBinaryReader reader)");

            if (struc.Fields.Count > 0)
            {
                writer.Write(0, "");
                writer.Write(4, "{");

                for (int i = 0; i < struc.Fields.Count; ++i)
                {
                    writer.Write(8, $"{fieldTypeNames[i]} {fieldVarNames[i]} = {GetFieldTypeReader(struc.Fields[i].Type)};");
                    if (struc.Fields[i].NeedsAlign) writer.Write(8, Align(fieldNames[i]));
                }

                writer.Write(8, "");
                writer.Write(8, $"return new({string.Join($",\n{' '.Repeat(12)}", fieldVarNames)});");
                writer.Write(4, "}");
                writer.Write(0, "");
                writer.Write(4, $"public override string ToString() => $\"{struc.Name}\\n{{ToString(4)}}\";");
                writer.Write(0, "");

                string[] fieldToStringFunc = struc.Fields.Select((_, i) => $"ToString_Field{i}").ToArray();

                writer.Write(4, "public string ToString(int indent)");
                writer.Write(4, "{");
                writer.Write(8, "StringBuilder sb = new();");
                writer.Write(8, "string indent_ = ' '.Repeat(indent);");
                writer.Write(0, "");
                writer.Write(0, string.Join($"\n", fieldToStringFunc.Select(x => $"{' '.Repeat(8)}{x}(sb, indent, indent_);")));
                writer.Write(0, "");
                writer.Write(8, "return sb.ToString();");
                writer.Write(4, "}");
                writer.Write(0, "");

                StringBuilder fieldToStringSb = new();

                for (int i = 0; i < struc.Fields.Count; ++i)
                {
                    writer.Write(4, $"public void {fieldToStringFunc[i]}(StringBuilder sb, int indent, string indent_)");
                    writer.Write(4, "{");
                    EmitToStringForType(8, struc.Fields[i].Type, fieldToStringSb, fieldNames[i]);
                    writer.Write(0, fieldToStringSb.ToString());
                    writer.Write(4, "}");

                    if (i != struc.Fields.Count - 1) writer.Write(0, "");
                    fieldToStringSb.Length = 0;
                }
            }
            else
            {
                writer.Write(0, " => default;");
            }

            writer.Write(0, "}");
            writer.Write(0, "");
        }

        if (type is CodegenForwardDeclType)
        {
            writer.Write(0, $"/* forward decl {type} (no type info) */");
            writer.Write(0, $"public record struct {SanitizeName(type.Name.ToString())};");
        }
    }

    public static string Align(string name) => $"reader.AlignTo(4); /* {name} */";

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

    private static string GetFieldName(CodegenStructureField field) =>
        SanitizeName(field.Name == field.Type.Name ? $"{field.Name}_" : field.Name.ToString());

    private static string GetFieldTypeName(CodegenType type) => type switch
    {
        CodegenArrayType array => $"{GetFieldTypeName(array.DataType)}[]",
        CodegenPrimitiveType builtin => builtin.CSharpType switch
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
        CodegenPPtrType pptr => $"PPtr<{SanitizeName(pptr.NameT.ToString())}>",
        CodegenStringType _ => $"AsciiString",
        _ => SanitizeName(type.Name.ToString())
    };

    private static string GetFieldTypeReader(CodegenType type) => type switch
    {
        CodegenArrayType array => $"BuiltInArray<{GetFieldTypeName(array.DataType)}>.Read(reader)",
        CodegenPrimitiveType builtIn => $"reader.Read{builtIn.Type}()",
        CodegenMapType map => $"BuiltInMap<{GetFieldTypeName(map.KeyType)}, {GetFieldTypeName(map.ValueType)}>.Read(reader)",
        CodegenRefRegistryType registry => $"default! /* {registry} */",
        CodegenStringType => "BuiltInString.Read(reader)",
        CodegenForwardDeclType decl => $"default! /* {decl} */",
        _ => $"{GetFieldTypeName(type)}.Read(reader)"
    };

    private static string SanitizeName(string str) =>
        SanitizeCSharpKeywords(str)
            .Replace(' ', '_')
            .Replace("`", "_") // type variants (like TypeName`1)
            .Replace("<", "__") // compiler generated field like <length>k__BackingField
            .Replace(">", "__") // see above
            .Replace("?", "__"); // some field have weird formatting, like Base/m_??ancelButtonLabel (it's a special C)

    private static string SanitizeCSharpKeywords(string name)
    {
        name = _csharpKeywords.Contains(name) ? "@" + name : name;
        name = SanitizeArrayNames().Replace(name, "_$1"); // transform [n] to _n
        name = SanitizeReferences().Replace(name, "_$1Ref_"); // transform (...&) to _...Ref_
        return name;
    }

    private static void EmitToStringForType(int indent, CodegenType type, StringBuilder sb, string name) =>
        EmitToStringForTypeImpl(type, sb, name, name, "indent_", 2, indent);

    // This function is kind of ridiculous. If you value your sanity, stay away!
    private static void EmitToStringForTypeImpl(
        CodegenType type,
        StringBuilder sb,
        string name,
        string accessor,
        string indentVarAccessor,
        int indentIncrease,
        int depth)
    {
        string indent = ' '.Repeat(depth);

        if (type is CodegenPrimitiveType
            or CodegenHash128Type
            or CodegenStringType
            or CodegenPPtrType)
        {
            string connector = name[^1] == ' ' ? string.Empty : ": ";
            sb.Append($"{indent}sb.AppendLine($\"{{{indentVarAccessor}}}{name}{connector}{AddStringQuotes(type, $"{{{accessor}}}")}\");");
        }
        else if (type is CodegenStructureType struc)
        {
            string connector = name[^1] == ' ' ? string.Empty : ": ";
            sb.Append($"{indent}sb.Append($\"{{{indentVarAccessor}}}{name}{connector}{{{{ ");

            if (struc.Fields.Count <= 4 && struc.Fields.All(x => x.Type is CodegenPrimitiveType))
            {
                sb.Append(string.Join(", ", struc.Fields.Select(GetFieldName).Select(x => $"{x}: {{{accessor}.{x}}}")));
            }
            else
            {
                sb.Append($"\\n{{{accessor}.ToString(indent+{indentIncrease})}}{{{indentVarAccessor}}}");
            }

            sb.Append("}}\\n\");");
        }
        else if (type is CodegenArrayType or CodegenMapType)
        {
            string foreachCnt = $"_{indentIncrease}i";
            string foreachVar = $"_{indentIncrease}";
            string foreachVarType;
            string foreachIndexAccessor;
            string foreachValueAccessor;
            string foreachLengthAccessor;
            CodegenType foreachDataType;

            if (type is CodegenArrayType array)
            {
                foreachVarType = GetFieldTypeName(array.DataType);
                foreachIndexAccessor = $"[{{{foreachCnt}}}] = ";
                foreachValueAccessor = foreachVar;
                foreachLengthAccessor = $"{accessor}.Length";
                foreachDataType = array.DataType;
            }
            else if (type is CodegenMapType map)
            {
                foreachVarType = $"KeyValuePair<{GetFieldTypeName(map.KeyType)}, {GetFieldTypeName(map.ValueType)}>";
                foreachIndexAccessor = $"[{AddStringQuotes(map.KeyType, $"{{{foreachVar}.Key}}")}] = ";
                foreachValueAccessor = $"{foreachVar}.Value";
                foreachLengthAccessor = $"{accessor}.Count";
                foreachDataType = map.ValueType;
            }
            else throw new(); // suppress compiler uninitialized warning

            sb.AppendLine($"{indent}sb.Append($\"{{{indentVarAccessor}}}{name}[{{{foreachLengthAccessor}}}] = {{{{\");");
            sb.AppendLine($"{indent}if ({foreachLengthAccessor} > 0) sb.AppendLine();");
            sb.AppendLine($"{indent}int {foreachCnt} = 0;");
            sb.AppendLine($"{indent}foreach ({foreachVarType} {foreachVar} in {accessor})");
            sb.AppendLine($"{indent}{{");

            EmitToStringForTypeImpl(foreachDataType,
                sb,
                foreachIndexAccessor,
                foreachValueAccessor,
                $"indent_ + ' '.Repeat({indentIncrease})",
                indentIncrease + 2,
                depth + 4);

            sb.AppendLine();
            sb.AppendLine($"{indent}    if (++{foreachCnt} >= 128) break;");
            sb.AppendLine($"{indent}}}");
            sb.AppendLine($"{indent}if ({foreachLengthAccessor} > 0) sb.Append({indentVarAccessor});");
            sb.Append($"{indent}sb.AppendLine(\"}}\");");
        }
        else
        {
            sb.Append($"{indent}sb.AppendLine($\"{{{indentVarAccessor}}}{name}: [[unimplemented]]\");");
        }

        return;

        static string AddStringQuotes(CodegenType type, string accessor)
        {
            return type is CodegenStringType ? $"\\\"{accessor}\\\"" : accessor;
        }
    }

    [System.Text.RegularExpressions.GeneratedRegex(@"\[\s*(\d+)\s*\]")]
    private static partial System.Text.RegularExpressions.Regex SanitizeArrayNames();

    [System.Text.RegularExpressions.GeneratedRegex(@"\((\w+)&\)")]
    private static partial System.Text.RegularExpressions.Regex SanitizeReferences();
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

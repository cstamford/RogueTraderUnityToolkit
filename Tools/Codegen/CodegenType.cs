using RogueTraderUnityToolkit.Core;
using RogueTraderUnityToolkit.Unity.TypeTree;

namespace Codegen;

public interface ICodegenType
{
    AsciiString Name { get; }
}

public record class CodegenBuiltInType(
    AsciiString Name,
    ObjectParserType Type) : ICodegenType
{
    public Type CSharpType => Type switch
    {
        ObjectParserType.U64 => typeof(ulong),
        ObjectParserType.U32 => typeof(uint),
        ObjectParserType.U16 => typeof(ushort),
        ObjectParserType.U8 => typeof(byte),
        ObjectParserType.S64 => typeof(long),
        ObjectParserType.S32 => typeof(int),
        ObjectParserType.S16 => typeof(short),
        ObjectParserType.S8 => typeof(uint),
        ObjectParserType.F64 => typeof(double),
        ObjectParserType.F32 => typeof(float),
        ObjectParserType.Bool => typeof(bool),
        ObjectParserType.Char => typeof(char),
        ObjectParserType.Complex => typeof(object),
        ObjectParserType.ReferencedObject => typeof(object), // ruh row?
        ObjectParserType.String => typeof(string),
        _ => throw new()
    };

    public override string ToString() => CSharpType.ToString();
}

public record class CodegenStructureType(
    AsciiString Name,
    IReadOnlyList<ICodegenField> Fields) : ICodegenType
{
    public override string ToString() => $"${Name} ({Fields.Count} fields)";
}

public record class CodegenArrayType(
    AsciiString Name,
    ICodegenType DataType) : ICodegenType
{
    public override string ToString() => $"#{Name}";
}

public record class CodegenMapType(
    AsciiString Name,
    ICodegenType KeyType,
    ICodegenType ValueType) : ICodegenType
{
    public override string ToString() => $"#{Name}";
}

public record class CodegenPPtrType(
    AsciiString Name,
    AsciiString TypeName) : ICodegenType
{
    public override string ToString() => $"#{Name}";
}

public record class CodegenEmptyType(AsciiString Name) : ICodegenType
{
    public override string ToString() => $"!{Name} (EMPTY TYPE)";
}

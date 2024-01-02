using RogueTraderUnityToolkit.Core;
using RogueTraderUnityToolkit.Unity.TypeTree;

namespace Codegen;

public interface ICodegenType
{
    AsciiString Name { get; }
}

public record class CodegenPrimitiveType(AsciiString Name, ObjectParserType Type) : ICodegenType
{
    public override string ToString() => CSharpType.ToString();

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
        ObjectParserType.Complex => throw new NotImplementedException(),
        ObjectParserType.ReferencedObject => throw new NotImplementedException(),
        ObjectParserType.PPTr => throw new NotImplementedException(),
        ObjectParserType.String => throw new NotImplementedException(),
        ObjectParserType.Vector => throw new NotImplementedException(),
        ObjectParserType.Map => throw new NotImplementedException(),
        ObjectParserType.Pair => throw new NotImplementedException(),
        _ => throw new()
    };
}

public record class CodegenStructureType(AsciiString Name, IReadOnlyList<ICodegenField> Fields) : ICodegenType
{
    public override string ToString() => $"${Name} ({Fields.Count} fields)";
}

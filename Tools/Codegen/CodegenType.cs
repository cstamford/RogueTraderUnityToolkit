using RogueTraderUnityToolkit.Core;
using RogueTraderUnityToolkit.Unity;

namespace Codegen;

public interface ICodegenType
{
    AsciiString Name { get; }
    ICodegenField[] Fields { get; }
    CodegenTypeFlags Flags { get; }
}

public record class CodegenPrimitive(
    ObjectParserType Type,
    CodegenTypeFlags Flags) : ICodegenType
{
    public AsciiString Name => _name;
    public ICodegenField[] Fields => Array.Empty<ICodegenField>();

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
        ObjectParserType.String => typeof(string),
        ObjectParserType.RefObjectTree => typeof(object), /* TODO */
        ObjectParserType.Vector => typeof(object), /* TODO */
        ObjectParserType.Map => typeof(object), /* TODO */
        ObjectParserType.PPTr => typeof(object), /* TODO */
        _ => throw new()
    };

    private readonly AsciiString _name = AsciiString.From(Type);
}

public record class CodegenStruct(
    AsciiString Name,
    ICodegenField[] Fields,
    CodegenTypeFlags Flags)
    : ICodegenType
{
    
}

[Flags]
public enum CodegenTypeFlags
{
    None = 0
}

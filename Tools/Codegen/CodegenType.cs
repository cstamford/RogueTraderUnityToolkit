using RogueTraderUnityToolkit.Core;
using RogueTraderUnityToolkit.Unity.TypeTree;

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

    public Type CSharpType => default;

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

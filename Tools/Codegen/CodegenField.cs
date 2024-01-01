using RogueTraderUnityToolkit.Core;

namespace Codegen;

public interface ICodegenField
{
    AsciiString Name { get; }
    ICodegenType Type { get; }
    CodegenFieldFlags Flags { get; }
}

public record class CodegenField(
    AsciiString Name,
    ICodegenType Type,
    CodegenFieldFlags Flags) : ICodegenField
{

}

[Flags]
public enum CodegenFieldFlags
{
    None = 0,
    Array = 1 << 0
}

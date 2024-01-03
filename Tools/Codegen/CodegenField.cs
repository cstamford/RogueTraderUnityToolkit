using RogueTraderUnityToolkit.Core;

namespace Codegen;

public interface ICodegenField
{
    ICodegenType Type { get; }
    AsciiString Name { get; }
}

public readonly record struct CodegenField(
    ICodegenType Type,
    AsciiString Name) : ICodegenField
{
    public override string ToString() => $"{Type} {Name}";
}

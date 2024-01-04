using RogueTraderUnityToolkit.Core;

namespace Codegen;

public interface ICodegenField
{
    ICodegenType Type { get; }
    AsciiString Name { get; }
    TreePathFlags Flags { get; }
}

public readonly record struct CodegenField(
    ICodegenType Type,
    AsciiString Name,
    TreePathFlags Flags) : ICodegenField
{
    public override string ToString() => $"{Type} {Name} {Flags}";
}

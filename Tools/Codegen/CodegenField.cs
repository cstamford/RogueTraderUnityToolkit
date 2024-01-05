using RogueTraderUnityToolkit.Core;

namespace Codegen;

public interface ICodegenField
{
    ICodegenType Type { get; }
    AsciiString Name { get; }
    bool NeedsAlign { get; }
}

public readonly record struct CodegenField(
    ICodegenType Type,
    AsciiString Name,
    bool NeedsAlign) : ICodegenField
{
    public override string ToString() => $"{Type} {Name} {NeedsAlign}";
}

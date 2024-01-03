using RogueTraderUnityToolkit.Core;
using RogueTraderUnityToolkit.Unity.TypeTree;

namespace Codegen;

public interface ICodegenType
{
    AsciiString Name { get; }
    CodegenTypeFlags Flags { get; }
}

[Flags]
public enum CodegenTypeFlags
{
    None = 0,
    IsEngineType = 1 << 0,
    IsGameType = 1 << 1,
    IsBuiltInType = 1 << 2
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
        ObjectParserType.S8 => typeof(sbyte),
        ObjectParserType.F64 => typeof(double),
        ObjectParserType.F32 => typeof(float),
        ObjectParserType.Bool => typeof(bool),
        ObjectParserType.Char => typeof(char),
        _ => throw new()
    };

    public CodegenTypeFlags Flags => CodegenTypeFlags.IsBuiltInType;
    public override string ToString() => CSharpType.ToString();
}

public record class CodegenStructureType(
    AsciiString Name,
    IReadOnlyList<ICodegenField> Fields,
    CodegenTypeFlags Flags) : ICodegenType
{
    public override string ToString() => $"${Name} ({Fields.Count} fields) ({Flags})";
}

public record class CodegenPPtrType(
    AsciiString TypeName) : ICodegenType
{
    public AsciiString Name { get; } = AsciiString.From($"PPtr<{TypeName}>");
    public CodegenTypeFlags Flags => CodegenTypeFlags.IsBuiltInType;
    public override string ToString() => Name.ToString();
}

public record class CodegenStringType : ICodegenType
{
    public AsciiString Name { get; } = AsciiString.From($"AsciiString");
    public CodegenTypeFlags Flags => CodegenTypeFlags.IsBuiltInType;
    public override string ToString() => Name.ToString();
}

public record class CodegenArrayType(
    ICodegenType DataType) : ICodegenType
{
    public AsciiString Name { get; } = AsciiString.From($"Array<{DataType.Name}>");
    public CodegenTypeFlags Flags => CodegenTypeFlags.IsBuiltInType;
    public override string ToString() => Name.ToString();
}

public record class CodegenMapType(
    ICodegenType KeyType,
    ICodegenType ValueType) : ICodegenType
{
    public AsciiString Name { get; } = AsciiString.From($"Map<{KeyType.Name}, {ValueType.Name}>");
    public CodegenTypeFlags Flags => CodegenTypeFlags.IsBuiltInType;
    public override string ToString() => Name.ToString();
}

public record class CodegenRefRegistryType(
    IReadOnlyList<ICodegenType> Types) : ICodegenType
{
    public AsciiString Name { get; } = AsciiString.From($"RefRegistry_{_nextRefRegistry++}");
    public CodegenTypeFlags Flags => CodegenTypeFlags.IsBuiltInType;
    private static int _nextRefRegistry = 0;
    public override string ToString() => Name.ToString();
}

public record class CodegenHash128Type : ICodegenType
{
    public AsciiString Name { get; } = AsciiString.From("Hash128");
    public CodegenTypeFlags Flags => CodegenTypeFlags.IsBuiltInType;
    public override string ToString() => Name.ToString();
}

public record class CodegenForwardDeclType(
    AsciiString Name) : ICodegenType
{
    public CodegenTypeFlags Flags => CodegenTypeFlags.None;
    public override string ToString() => $"?{Name}";
}

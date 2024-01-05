using RogueTraderUnityToolkit.Core;
using RogueTraderUnityToolkit.Unity;
using RogueTraderUnityToolkit.Unity.TypeTree;

namespace Codegen;

public record class CodegenType(AsciiString Name);

public record class CodegenStructureType(
    AsciiString Name,
    IReadOnlyList<CodegenStructureField> Fields)
    : CodegenType(Name)
{
    public virtual bool Equals(CodegenStructureType? rhs) => rhs != null && Name == rhs.Name && Fields.SequenceEqual(rhs.Fields);

    public override int GetHashCode()
    {
        HashCode hash = new();
        hash.Add(Name);
        foreach (CodegenStructureField field in Fields) hash.Add(field);
        return hash.ToHashCode();
    }

    public override string ToString() => $"${Name} ({Fields.Count} fields)";
}

public sealed record class CodegenRootType(
    AsciiString Name,
    IReadOnlyList<CodegenStructureField> Fields,
    Hash128 Hash,
    bool IsEngineType)
    : CodegenStructureType(Name, Fields)
{
    public bool Equals(CodegenRootType? rhs) => base.Equals(rhs) && Hash == rhs.Hash && IsEngineType == rhs.IsEngineType;
    public override int GetHashCode() => HashCode.Combine(base.GetHashCode(), Hash, IsEngineType);
    public override string ToString() => $"${Name} ({Fields.Count} fields) {Hash}";
}

public record class CodegenPrimitiveType(AsciiString Name, ObjectParserType Type)
    : CodegenType(Name)
{
    public bool CompatibleWith(IEnumerable<TreePath> children) =>
        children.Count() == 1 && children.First().Last.Type == Type;

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

    public override string ToString() => CSharpType.ToString();
}

public record class CodegenPPtrType(AsciiString NameT)
    : CodegenType(AsciiString.From($"PPtr<{NameT}>"))
{
    public override string ToString() => Name.ToString();
}

public record class CodegenStringType()
    : CodegenType(AsciiString.From("AsciiString"))
{
    public override string ToString() => Name.ToString();
}

public record class CodegenArrayType(CodegenType DataType)
    : CodegenType(AsciiString.From($"Array<{DataType.Name}>"))
{
    public override string ToString() => Name.ToString();
}

public record class CodegenMapType(CodegenType KeyType, CodegenType ValueType)
    : CodegenType(AsciiString.From($"Map<{KeyType.Name}, {ValueType.Name}>"))
{
    public override string ToString() => Name.ToString();
}

public record class CodegenRefRegistryType(IReadOnlyList<CodegenType> Types)
    : CodegenType(AsciiString.From($"RefRegistry"))
{
    public override string ToString() => Name.ToString();
}

public record class CodegenHash128Type()
    : CodegenType(AsciiString.From("Hash128"))
{
    public override string ToString() => Name.ToString();
}

public record class CodegenForwardDeclType( AsciiString Name)
    : CodegenType(Name)
{
    public override string ToString() => $"?{Name}";
}

public record class CodegenStructureField(CodegenType Type, AsciiString Name, bool NeedsAlign)
{
    public override string ToString() => $"{Type} {Name} {NeedsAlign}";
}

namespace RogueTraderUnityToolkit.UnityGenerated.Types.Engine;

using Core;
using System.Text;
using Unity;

/* $PhysicMaterial (6 fields) PhysicMaterial ABE3FF3FE0CC7651F45F5F867D42FAF2 */
public record class PhysicMaterial (
    AsciiString m_Name,
    float dynamicFriction,
    float staticFriction,
    float bounciness,
    int frictionCombine,
    int bounceCombine) : IUnityEngineStructure
{
    public static UnityObjectType ObjectType => UnityObjectType.PhysicMaterial;
    public static Hash128 Hash => new("ABE3FF3FE0CC7651F45F5F867D42FAF2");
    public static PhysicMaterial Read(EndianBinaryReader reader)
    {
        AsciiString m_Name_ = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_Name */
        float dynamicFriction_ = reader.ReadF32();
        float staticFriction_ = reader.ReadF32();
        float bounciness_ = reader.ReadF32();
        int frictionCombine_ = reader.ReadS32();
        int bounceCombine_ = reader.ReadS32();
        
        return new(m_Name_,
            dynamicFriction_,
            staticFriction_,
            bounciness_,
            frictionCombine_,
            bounceCombine_);
    }

    public override string ToString() => $"PhysicMaterial\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();
        string indent_ = ' '.Repeat(indent);

        ToString_Field0(sb, indent, indent_);
        ToString_Field1(sb, indent, indent_);
        ToString_Field2(sb, indent, indent_);
        ToString_Field3(sb, indent, indent_);
        ToString_Field4(sb, indent, indent_);
        ToString_Field5(sb, indent, indent_);

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_Name: \"{m_Name}\"");
    }

    public void ToString_Field1(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}dynamicFriction: {dynamicFriction}");
    }

    public void ToString_Field2(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}staticFriction: {staticFriction}");
    }

    public void ToString_Field3(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}bounciness: {bounciness}");
    }

    public void ToString_Field4(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}frictionCombine: {frictionCombine}");
    }

    public void ToString_Field5(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}bounceCombine: {bounceCombine}");
    }
}


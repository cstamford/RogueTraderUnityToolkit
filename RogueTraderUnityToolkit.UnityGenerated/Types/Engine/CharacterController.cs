namespace RogueTraderUnityToolkit.UnityGenerated.Types.Engine;

using Core;
using System.Text;
using Unity;

/* $CharacterController (15 fields) CharacterController 659FEC10CCCBE8CDBE1413BC8C64405A */
public record class CharacterController (
    PPtr<GameObject> m_GameObject,
    PPtr<PhysicMaterial> m_Material,
    BitField m_IncludeLayers,
    BitField m_ExcludeLayers,
    int m_LayerOverridePriority,
    bool m_IsTrigger,
    bool m_ProvidesContacts,
    bool m_Enabled,
    float m_Height,
    float m_Radius,
    float m_SlopeLimit,
    float m_StepOffset,
    float m_SkinWidth,
    float m_MinMoveDistance,
    Vector3f m_Center) : IUnityEngineStructure
{
    public static UnityObjectType ObjectType => UnityObjectType.CharacterController;
    public static Hash128 Hash => new("659FEC10CCCBE8CDBE1413BC8C64405A");
    public static CharacterController Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> m_GameObject_ = PPtr<GameObject>.Read(reader);
        PPtr<PhysicMaterial> m_Material_ = PPtr<PhysicMaterial>.Read(reader);
        BitField m_IncludeLayers_ = BitField.Read(reader);
        BitField m_ExcludeLayers_ = BitField.Read(reader);
        int m_LayerOverridePriority_ = reader.ReadS32();
        bool m_IsTrigger_ = reader.ReadBool();
        bool m_ProvidesContacts_ = reader.ReadBool();
        reader.AlignTo(4); /* m_ProvidesContacts */
        bool m_Enabled_ = reader.ReadBool();
        reader.AlignTo(4); /* m_Enabled */
        float m_Height_ = reader.ReadF32();
        float m_Radius_ = reader.ReadF32();
        float m_SlopeLimit_ = reader.ReadF32();
        float m_StepOffset_ = reader.ReadF32();
        float m_SkinWidth_ = reader.ReadF32();
        float m_MinMoveDistance_ = reader.ReadF32();
        Vector3f m_Center_ = Vector3f.Read(reader);
        
        return new(m_GameObject_,
            m_Material_,
            m_IncludeLayers_,
            m_ExcludeLayers_,
            m_LayerOverridePriority_,
            m_IsTrigger_,
            m_ProvidesContacts_,
            m_Enabled_,
            m_Height_,
            m_Radius_,
            m_SlopeLimit_,
            m_StepOffset_,
            m_SkinWidth_,
            m_MinMoveDistance_,
            m_Center_);
    }

    public override string ToString() => $"CharacterController\n{ToString(4)}";

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
        ToString_Field6(sb, indent, indent_);
        ToString_Field7(sb, indent, indent_);
        ToString_Field8(sb, indent, indent_);
        ToString_Field9(sb, indent, indent_);
        ToString_Field10(sb, indent, indent_);
        ToString_Field11(sb, indent, indent_);
        ToString_Field12(sb, indent, indent_);
        ToString_Field13(sb, indent, indent_);
        ToString_Field14(sb, indent, indent_);

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_GameObject: {m_GameObject}");
    }

    public void ToString_Field1(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_Material: {m_Material}");
    }

    public void ToString_Field2(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_IncludeLayers: {{ m_Bits: {m_IncludeLayers.m_Bits} }}\n");
    }

    public void ToString_Field3(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_ExcludeLayers: {{ m_Bits: {m_ExcludeLayers.m_Bits} }}\n");
    }

    public void ToString_Field4(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_LayerOverridePriority: {m_LayerOverridePriority}");
    }

    public void ToString_Field5(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_IsTrigger: {m_IsTrigger}");
    }

    public void ToString_Field6(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_ProvidesContacts: {m_ProvidesContacts}");
    }

    public void ToString_Field7(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_Enabled: {m_Enabled}");
    }

    public void ToString_Field8(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_Height: {m_Height}");
    }

    public void ToString_Field9(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_Radius: {m_Radius}");
    }

    public void ToString_Field10(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_SlopeLimit: {m_SlopeLimit}");
    }

    public void ToString_Field11(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_StepOffset: {m_StepOffset}");
    }

    public void ToString_Field12(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_SkinWidth: {m_SkinWidth}");
    }

    public void ToString_Field13(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_MinMoveDistance: {m_MinMoveDistance}");
    }

    public void ToString_Field14(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_Center: {{ x: {m_Center.x}, y: {m_Center.y}, z: {m_Center.z} }}\n");
    }
}


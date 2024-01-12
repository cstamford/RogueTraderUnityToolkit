namespace RogueTraderUnityToolkit.UnityGenerated.Types.Engine;

using Core;
using System.Text;
using Unity;

/* $CapsuleCollider (12 fields) CapsuleCollider 7F292722CDCEB8EE3ADBA6CA301420FC */
public record class CapsuleCollider (
    PPtr<GameObject> m_GameObject,
    PPtr<PhysicMaterial> m_Material,
    BitField m_IncludeLayers,
    BitField m_ExcludeLayers,
    int m_LayerOverridePriority,
    bool m_IsTrigger,
    bool m_ProvidesContacts,
    bool m_Enabled,
    float m_Radius,
    float m_Height,
    int m_Direction,
    Vector3f m_Center) : IUnityEngineStructure
{
    public static UnityObjectType ObjectType => UnityObjectType.CapsuleCollider;
    public static Hash128 Hash => new("7F292722CDCEB8EE3ADBA6CA301420FC");
    public static CapsuleCollider Read(EndianBinaryReader reader)
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
        float m_Radius_ = reader.ReadF32();
        float m_Height_ = reader.ReadF32();
        int m_Direction_ = reader.ReadS32();
        Vector3f m_Center_ = Vector3f.Read(reader);
        
        return new(m_GameObject_,
            m_Material_,
            m_IncludeLayers_,
            m_ExcludeLayers_,
            m_LayerOverridePriority_,
            m_IsTrigger_,
            m_ProvidesContacts_,
            m_Enabled_,
            m_Radius_,
            m_Height_,
            m_Direction_,
            m_Center_);
    }

    public override string ToString() => $"CapsuleCollider\n{ToString(4)}";

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
        sb.AppendLine($"{indent_}m_Radius: {m_Radius}");
    }

    public void ToString_Field9(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_Height: {m_Height}");
    }

    public void ToString_Field10(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_Direction: {m_Direction}");
    }

    public void ToString_Field11(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_Center: {{ x: {m_Center.x}, y: {m_Center.y}, z: {m_Center.z} }}\n");
    }
}


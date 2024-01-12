namespace RogueTraderUnityToolkit.UnityGenerated.Types.Engine;

using Core;
using System.Text;
using Unity;

/* $TerrainCollider (9 fields) TerrainCollider 25904926B57B4F72A0D8ADEA16C2DCE3 */
public record class TerrainCollider (
    PPtr<GameObject> m_GameObject,
    PPtr<PhysicMaterial> m_Material,
    BitField m_IncludeLayers,
    BitField m_ExcludeLayers,
    int m_LayerOverridePriority,
    bool m_ProvidesContacts,
    bool m_Enabled,
    PPtr<TerrainData> m_TerrainData,
    bool m_EnableTreeColliders) : IUnityEngineStructure
{
    public static UnityObjectType ObjectType => UnityObjectType.TerrainCollider;
    public static Hash128 Hash => new("25904926B57B4F72A0D8ADEA16C2DCE3");
    public static TerrainCollider Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> m_GameObject_ = PPtr<GameObject>.Read(reader);
        PPtr<PhysicMaterial> m_Material_ = PPtr<PhysicMaterial>.Read(reader);
        BitField m_IncludeLayers_ = BitField.Read(reader);
        BitField m_ExcludeLayers_ = BitField.Read(reader);
        int m_LayerOverridePriority_ = reader.ReadS32();
        bool m_ProvidesContacts_ = reader.ReadBool();
        reader.AlignTo(4); /* m_ProvidesContacts */
        bool m_Enabled_ = reader.ReadBool();
        reader.AlignTo(4); /* m_Enabled */
        PPtr<TerrainData> m_TerrainData_ = PPtr<TerrainData>.Read(reader);
        bool m_EnableTreeColliders_ = reader.ReadBool();
        
        return new(m_GameObject_,
            m_Material_,
            m_IncludeLayers_,
            m_ExcludeLayers_,
            m_LayerOverridePriority_,
            m_ProvidesContacts_,
            m_Enabled_,
            m_TerrainData_,
            m_EnableTreeColliders_);
    }

    public override string ToString() => $"TerrainCollider\n{ToString(4)}";

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
        sb.AppendLine($"{indent_}m_ProvidesContacts: {m_ProvidesContacts}");
    }

    public void ToString_Field6(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_Enabled: {m_Enabled}");
    }

    public void ToString_Field7(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_TerrainData: {m_TerrainData}");
    }

    public void ToString_Field8(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_EnableTreeColliders: {m_EnableTreeColliders}");
    }
}


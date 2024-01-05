namespace RogueTraderUnityToolkit.UnityGenerated.Types.Engine;

using Core;
using System.Text;
using Unity;

/* $TerrainCollider (9 fields) 25904926B57B4F72A0D8ADEA16C2DCE3 */
public record class TerrainCollider(
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
    public static Hash128 Hash => new(630212902, 3044757362, 2698554858, 381869283);

    public static TerrainCollider Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        PPtr<PhysicMaterial> _m_Material = PPtr<PhysicMaterial>.Read(reader);
        BitField _m_IncludeLayers = BitField.Read(reader);
        BitField _m_ExcludeLayers = BitField.Read(reader);
        int _m_LayerOverridePriority = reader.ReadS32();
        bool _m_ProvidesContacts = reader.ReadBool();
        reader.AlignTo(4); /* m_ProvidesContacts */
        bool _m_Enabled = reader.ReadBool();
        reader.AlignTo(4); /* m_Enabled */
        PPtr<TerrainData> _m_TerrainData = PPtr<TerrainData>.Read(reader);
        bool _m_EnableTreeColliders = reader.ReadBool();
        
        return new(_m_GameObject,
            _m_Material,
            _m_IncludeLayers,
            _m_ExcludeLayers,
            _m_LayerOverridePriority,
            _m_ProvidesContacts,
            _m_Enabled,
            _m_TerrainData,
            _m_EnableTreeColliders);
    }

    public override string ToString() => $"TerrainCollider\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_GameObject: ");
        sb.AppendLine(m_GameObject.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Material: ");
        sb.AppendLine(m_Material.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_IncludeLayers: ");
        sb.AppendLine();
        sb.Append(m_IncludeLayers.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_ExcludeLayers: ");
        sb.AppendLine();
        sb.Append(m_ExcludeLayers.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_LayerOverridePriority: ");
        sb.AppendLine(m_LayerOverridePriority.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_ProvidesContacts: ");
        sb.AppendLine(m_ProvidesContacts.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Enabled: ");
        sb.AppendLine(m_Enabled.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_TerrainData: ");
        sb.AppendLine(m_TerrainData.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_EnableTreeColliders: ");
        sb.AppendLine(m_EnableTreeColliders.ToString());

        return sb.ToString();
    }
}


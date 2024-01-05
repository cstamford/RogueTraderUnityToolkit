namespace RogueTraderUnityToolkit.UnityGenerated.Types.Engine;

using Core;
using System.Text;
using Unity;

/* $CapsuleCollider (12 fields) 7F292722CDCEB8EE3ADBA6CA301420FC */
public record class CapsuleCollider(
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
    public static Hash128 Hash => new(2133403426, 3452877038, 987473610, 806625532);

    public static CapsuleCollider Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        PPtr<PhysicMaterial> _m_Material = PPtr<PhysicMaterial>.Read(reader);
        BitField _m_IncludeLayers = BitField.Read(reader);
        BitField _m_ExcludeLayers = BitField.Read(reader);
        int _m_LayerOverridePriority = reader.ReadS32();
        bool _m_IsTrigger = reader.ReadBool();
        bool _m_ProvidesContacts = reader.ReadBool();
        reader.AlignTo(4); /* m_ProvidesContacts */
        bool _m_Enabled = reader.ReadBool();
        reader.AlignTo(4); /* m_Enabled */
        float _m_Radius = reader.ReadF32();
        float _m_Height = reader.ReadF32();
        int _m_Direction = reader.ReadS32();
        Vector3f _m_Center = Vector3f.Read(reader);
        
        return new(_m_GameObject,
            _m_Material,
            _m_IncludeLayers,
            _m_ExcludeLayers,
            _m_LayerOverridePriority,
            _m_IsTrigger,
            _m_ProvidesContacts,
            _m_Enabled,
            _m_Radius,
            _m_Height,
            _m_Direction,
            _m_Center);
    }

    public override string ToString() => $"CapsuleCollider\n{ToString(4)}";

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
        sb.Append("m_IsTrigger: ");
        sb.AppendLine(m_IsTrigger.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_ProvidesContacts: ");
        sb.AppendLine(m_ProvidesContacts.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Enabled: ");
        sb.AppendLine(m_Enabled.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Radius: ");
        sb.AppendLine(m_Radius.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Height: ");
        sb.AppendLine(m_Height.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Direction: ");
        sb.AppendLine(m_Direction.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Center: ");
        sb.AppendLine();
        sb.Append(m_Center.ToString(indent+4));

        return sb.ToString();
    }
}


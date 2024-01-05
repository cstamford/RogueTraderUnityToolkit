namespace RogueTraderUnityToolkit.UnityGenerated.Types.Engine;

using Core;
using System.Text;
using Unity;

/* $CharacterController (15 fields) 659FEC10CCCBE8CDBE1413BC8C64405A */
public record class CharacterController(
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
    public static Hash128 Hash => new(1704979472, 3435915469, 3188986812, 2355380314);

    public static CharacterController Read(EndianBinaryReader reader)
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
        float _m_Height = reader.ReadF32();
        float _m_Radius = reader.ReadF32();
        float _m_SlopeLimit = reader.ReadF32();
        float _m_StepOffset = reader.ReadF32();
        float _m_SkinWidth = reader.ReadF32();
        float _m_MinMoveDistance = reader.ReadF32();
        Vector3f _m_Center = Vector3f.Read(reader);
        
        return new(_m_GameObject,
            _m_Material,
            _m_IncludeLayers,
            _m_ExcludeLayers,
            _m_LayerOverridePriority,
            _m_IsTrigger,
            _m_ProvidesContacts,
            _m_Enabled,
            _m_Height,
            _m_Radius,
            _m_SlopeLimit,
            _m_StepOffset,
            _m_SkinWidth,
            _m_MinMoveDistance,
            _m_Center);
    }

    public override string ToString() => $"CharacterController\n{ToString(4)}";

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
        sb.Append("m_Height: ");
        sb.AppendLine(m_Height.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Radius: ");
        sb.AppendLine(m_Radius.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_SlopeLimit: ");
        sb.AppendLine(m_SlopeLimit.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_StepOffset: ");
        sb.AppendLine(m_StepOffset.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_SkinWidth: ");
        sb.AppendLine(m_SkinWidth.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_MinMoveDistance: ");
        sb.AppendLine(m_MinMoveDistance.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Center: ");
        sb.AppendLine();
        sb.Append(m_Center.ToString(indent+4));

        return sb.ToString();
    }
}


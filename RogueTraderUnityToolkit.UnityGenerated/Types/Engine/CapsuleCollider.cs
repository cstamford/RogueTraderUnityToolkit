namespace RogueTraderUnityToolkit.UnityGenerated.Types.Engine;

using Core;
using Unity;

/* $CapsuleCollider (12 fields) 7F292722CDCEB8EE3ADBA6CA301420FC */
public record class CapsuleCollider(
    PPtr<GameObject> m_GameObject /* None */,
    PPtr<PhysicMaterial> m_Material /* None */,
    BitField m_IncludeLayers /* None */,
    BitField m_ExcludeLayers /* None */,
    int m_LayerOverridePriority /* None */,
    bool m_IsTrigger /* None */,
    bool m_ProvidesContacts /* None */,
    bool m_Enabled /* NeedsAlign */,
    float m_Radius /* NeedsAlign */,
    float m_Height /* None */,
    int m_Direction /* None */,
    Vector3f m_Center /* None */) : IUnityObject
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
        reader.AlignTo(4); /* m_Enabled */
        bool _m_Enabled = reader.ReadBool();
        reader.AlignTo(4); /* m_Radius */
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
}


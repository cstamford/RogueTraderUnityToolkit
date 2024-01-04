namespace RogueTraderUnityToolkit.UnityGenerated.Types.Engine;

using Core;
using Unity;

/* $BoxCollider (10 fields) 9EF330076498F7F0DE7391D10B15E1AB */
public record class BoxCollider(
    PPtr<GameObject> m_GameObject /* None */,
    PPtr<PhysicMaterial> m_Material /* None */,
    BitField m_IncludeLayers /* None */,
    BitField m_ExcludeLayers /* None */,
    int m_LayerOverridePriority /* None */,
    bool m_IsTrigger /* None */,
    bool m_ProvidesContacts /* None */,
    bool m_Enabled /* NeedsAlign */,
    Vector3f m_Size /* NeedsAlign */,
    Vector3f m_Center /* None */) : IUnityObject
{
    public static Hash128 Hash => new(2666737671, 1687746544, 3732115921, 185983403);
    public static BoxCollider Read(EndianBinaryReader reader)
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
        reader.AlignTo(4); /* m_Size */
        Vector3f _m_Size = Vector3f.Read(reader);
        Vector3f _m_Center = Vector3f.Read(reader);
        
        return new(_m_GameObject,
            _m_Material,
            _m_IncludeLayers,
            _m_ExcludeLayers,
            _m_LayerOverridePriority,
            _m_IsTrigger,
            _m_ProvidesContacts,
            _m_Enabled,
            _m_Size,
            _m_Center);
    }
}


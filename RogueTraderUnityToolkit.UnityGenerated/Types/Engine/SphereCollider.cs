namespace RogueTraderUnityToolkit.UnityGenerated.Types.Engine;

using Core;
using Unity;

/* $SphereCollider (10 fields) 934A53EA78AF77F5FCEAB6AF9EFB2C38 */
public record class SphereCollider(
    PPtr<GameObject> m_GameObject /* None */,
    PPtr<PhysicMaterial> m_Material /* None */,
    BitField m_IncludeLayers /* None */,
    BitField m_ExcludeLayers /* None */,
    int m_LayerOverridePriority /* None */,
    bool m_IsTrigger /* None */,
    bool m_ProvidesContacts /* None */,
    bool m_Enabled /* NeedsAlign */,
    float m_Radius /* NeedsAlign */,
    Vector3f m_Center /* None */) : IUnityObject
{
    public static Hash128 Hash => new(2471121898, 2024765429, 4243240623, 2667260984);
    public static SphereCollider Read(EndianBinaryReader reader)
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
            _m_Center);
    }
}


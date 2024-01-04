namespace RogueTraderUnityToolkit.UnityGenerated.Types.Engine;

using Core;
using Unity;

/* $MeshCollider (11 fields) D2B33489530AD4ABF8EDF3976BC1BFC2 */
public record class MeshCollider(
    PPtr<GameObject> m_GameObject /* None */,
    PPtr<PhysicMaterial> m_Material /* None */,
    BitField m_IncludeLayers /* None */,
    BitField m_ExcludeLayers /* None */,
    int m_LayerOverridePriority /* None */,
    bool m_IsTrigger /* None */,
    bool m_ProvidesContacts /* None */,
    bool m_Enabled /* NeedsAlign */,
    bool m_Convex /* NeedsAlign */,
    int m_CookingOptions /* NeedsAlign */,
    PPtr<Mesh> m_Mesh /* NeedsAlign */) : IUnityObject
{
    public static Hash128 Hash => new(3534959753, 1393218731, 4176343959, 1807859650);
    public static MeshCollider Read(EndianBinaryReader reader)
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
        reader.AlignTo(4); /* m_Convex */
        bool _m_Convex = reader.ReadBool();
        reader.AlignTo(4); /* m_CookingOptions */
        int _m_CookingOptions = reader.ReadS32();
        reader.AlignTo(4); /* m_Mesh */
        PPtr<Mesh> _m_Mesh = PPtr<Mesh>.Read(reader);
        
        return new(_m_GameObject,
            _m_Material,
            _m_IncludeLayers,
            _m_ExcludeLayers,
            _m_LayerOverridePriority,
            _m_IsTrigger,
            _m_ProvidesContacts,
            _m_Enabled,
            _m_Convex,
            _m_CookingOptions,
            _m_Mesh);
    }
}


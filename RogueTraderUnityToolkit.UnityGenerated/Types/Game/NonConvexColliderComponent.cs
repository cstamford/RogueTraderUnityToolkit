namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $NonConvexColliderComponent (8 fields) 6586F20039905331E2A69779FD15DB9B/784D84BA4E73D6AD1148AD02BC47A696 */
public record class NonConvexColliderComponent(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<MeshCollider>[] m_colliders /* NeedsAlign */,
    byte m_isTrigger /* None */,
    PPtr<PhysicMaterial> m_material /* NeedsAlign */,
    PPtr<NonConvexColliderAsset> m_colliderAsset /* None */)
{
    public static NonConvexColliderComponent Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_colliders */
        PPtr<MeshCollider>[] _m_colliders = BuiltInArray<PPtr<MeshCollider>>.Read(reader);
        byte _m_isTrigger = reader.ReadU8();
        reader.AlignTo(4); /* m_material */
        PPtr<PhysicMaterial> _m_material = PPtr<PhysicMaterial>.Read(reader);
        PPtr<NonConvexColliderAsset> _m_colliderAsset = PPtr<NonConvexColliderAsset>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_colliders,
            _m_isTrigger,
            _m_material,
            _m_colliderAsset);
    }
}


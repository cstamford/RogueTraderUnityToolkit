namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $PBDSkinnedBody (24 fields) 22D570D3B25052B5F8D96E54FCA23336/6ED0188BFAAFD51D19780B2A611A6116 */
public record class PBDSkinnedBody(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    byte m_IsStatic /* NeedsAlign */,
    float m_Restitution /* NeedsAlign */,
    float m_Friction /* None */,
    float m_TeleportDistanceTreshold /* None */,
    PPtr<PBDColliderBase>[] m_LocalColliders /* None */,
    Particle[] m_Particles /* None */,
    Constraint[] m_Constraints /* None */,
    int2 m_DisconnectedConstraintsOffsetCount /* None */,
    int m_BodyInitializationMode /* None */,
    byte m_UseGlobalGravity /* None */,
    byte m_UseGlobalWind /* NeedsAlign */,
    int[] m_ParentMap /* NeedsAlign */,
    PPtr<SkinnedMeshRenderer>[] m_SkinnedMeshRenderers /* NeedsAlign */,
    PPtr<MeshFilter>[] m_MeshFilters /* None */,
    PPtr<MeshRenderer>[] m_MeshRenderers /* None */,
    PPtr<Transform>[] m_Bones /* None */,
    Matrix4x4f[] m_Bindposes /* None */,
    int[] m_BoneIndicesMap /* NeedsAlign */,
    int2 m_BoneIndicesMapOffsetCount /* NeedsAlign */,
    int[] m_BonesPerVertex /* None */)
{
    public static PBDSkinnedBody Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_IsStatic */
        byte _m_IsStatic = reader.ReadU8();
        reader.AlignTo(4); /* m_Restitution */
        float _m_Restitution = reader.ReadF32();
        float _m_Friction = reader.ReadF32();
        float _m_TeleportDistanceTreshold = reader.ReadF32();
        PPtr<PBDColliderBase>[] _m_LocalColliders = BuiltInArray<PPtr<PBDColliderBase>>.Read(reader);
        Particle[] _m_Particles = BuiltInArray<Particle>.Read(reader);
        Constraint[] _m_Constraints = BuiltInArray<Constraint>.Read(reader);
        int2 _m_DisconnectedConstraintsOffsetCount = int2.Read(reader);
        int _m_BodyInitializationMode = reader.ReadS32();
        byte _m_UseGlobalGravity = reader.ReadU8();
        reader.AlignTo(4); /* m_UseGlobalWind */
        byte _m_UseGlobalWind = reader.ReadU8();
        reader.AlignTo(4); /* m_ParentMap */
        int[] _m_ParentMap = BuiltInArray<int>.Read(reader);
        reader.AlignTo(4); /* m_SkinnedMeshRenderers */
        PPtr<SkinnedMeshRenderer>[] _m_SkinnedMeshRenderers = BuiltInArray<PPtr<SkinnedMeshRenderer>>.Read(reader);
        PPtr<MeshFilter>[] _m_MeshFilters = BuiltInArray<PPtr<MeshFilter>>.Read(reader);
        PPtr<MeshRenderer>[] _m_MeshRenderers = BuiltInArray<PPtr<MeshRenderer>>.Read(reader);
        PPtr<Transform>[] _m_Bones = BuiltInArray<PPtr<Transform>>.Read(reader);
        Matrix4x4f[] _m_Bindposes = BuiltInArray<Matrix4x4f>.Read(reader);
        reader.AlignTo(4); /* m_BoneIndicesMap */
        int[] _m_BoneIndicesMap = BuiltInArray<int>.Read(reader);
        reader.AlignTo(4); /* m_BoneIndicesMapOffsetCount */
        int2 _m_BoneIndicesMapOffsetCount = int2.Read(reader);
        int[] _m_BonesPerVertex = BuiltInArray<int>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_IsStatic,
            _m_Restitution,
            _m_Friction,
            _m_TeleportDistanceTreshold,
            _m_LocalColliders,
            _m_Particles,
            _m_Constraints,
            _m_DisconnectedConstraintsOffsetCount,
            _m_BodyInitializationMode,
            _m_UseGlobalGravity,
            _m_UseGlobalWind,
            _m_ParentMap,
            _m_SkinnedMeshRenderers,
            _m_MeshFilters,
            _m_MeshRenderers,
            _m_Bones,
            _m_Bindposes,
            _m_BoneIndicesMap,
            _m_BoneIndicesMapOffsetCount,
            _m_BonesPerVertex);
    }
}


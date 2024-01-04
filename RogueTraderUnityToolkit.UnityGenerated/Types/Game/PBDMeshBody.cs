namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $PBDMeshBody (24 fields) F557FF017DFAFC143437D1DE376291DD/512B90A8D598960D3AB8768EBC8FDF99 */
public record class PBDMeshBody(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    byte m_IsStatic /* NeedsAlign */,
    float m_Restitution /* NeedsAlign */,
    float m_Friction /* None */,
    float m_TeleportDistanceTreshold /* None */,
    PPtr<PBDColliderBase>[] m_LocalColliders /* None */,
    Particle m_Particles /* None */,
    Constraint m_Constraints /* None */,
    int2 m_DisconnectedConstraintsOffsetCount /* None */,
    int m_BodyInitializationMode /* None */,
    byte m_UseGlobalGravity /* None */,
    byte m_UseGlobalWind /* NeedsAlign */,
    byte m_RecalculateNormalsAndTangentsOnEveryFrame /* NeedsAlign */,
    AABB m_SimulatedBounds /* NeedsAlign */,
    int[] m_ParentList /* None */,
    int[] m_VertexTriangleMap /* NeedsAlign */,
    int[] m_VertexTriangleMapOffsetCount /* NeedsAlign */,
    Vector3f[] m_Vertices /* NeedsAlign */,
    Vector3f[] m_Normals /* NeedsAlign */,
    Vector2f[] m_Uv /* NeedsAlign */,
    Vector4f[] m_Tangents /* NeedsAlign */)
{
    public static PBDMeshBody Read(EndianBinaryReader reader)
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
        Particle _m_Particles = Particle.Read(reader);
        Constraint _m_Constraints = Constraint.Read(reader);
        int2 _m_DisconnectedConstraintsOffsetCount = int2.Read(reader);
        int _m_BodyInitializationMode = reader.ReadS32();
        byte _m_UseGlobalGravity = reader.ReadU8();
        reader.AlignTo(4); /* m_UseGlobalWind */
        byte _m_UseGlobalWind = reader.ReadU8();
        reader.AlignTo(4); /* m_RecalculateNormalsAndTangentsOnEveryFrame */
        byte _m_RecalculateNormalsAndTangentsOnEveryFrame = reader.ReadU8();
        reader.AlignTo(4); /* m_SimulatedBounds */
        AABB _m_SimulatedBounds = AABB.Read(reader);
        int[] _m_ParentList = BuiltInArray<int>.Read(reader);
        reader.AlignTo(4); /* m_VertexTriangleMap */
        int[] _m_VertexTriangleMap = BuiltInArray<int>.Read(reader);
        reader.AlignTo(4); /* m_VertexTriangleMapOffsetCount */
        int[] _m_VertexTriangleMapOffsetCount = BuiltInArray<int>.Read(reader);
        reader.AlignTo(4); /* m_Vertices */
        Vector3f[] _m_Vertices = BuiltInArray<Vector3f>.Read(reader);
        reader.AlignTo(4); /* m_Normals */
        Vector3f[] _m_Normals = BuiltInArray<Vector3f>.Read(reader);
        reader.AlignTo(4); /* m_Uv */
        Vector2f[] _m_Uv = BuiltInArray<Vector2f>.Read(reader);
        reader.AlignTo(4); /* m_Tangents */
        Vector4f[] _m_Tangents = BuiltInArray<Vector4f>.Read(reader);
        
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
            _m_RecalculateNormalsAndTangentsOnEveryFrame,
            _m_SimulatedBounds,
            _m_ParentList,
            _m_VertexTriangleMap,
            _m_VertexTriangleMapOffsetCount,
            _m_Vertices,
            _m_Normals,
            _m_Uv,
            _m_Tangents);
    }
}


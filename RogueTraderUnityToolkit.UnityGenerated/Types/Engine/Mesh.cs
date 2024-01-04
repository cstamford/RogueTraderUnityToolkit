namespace RogueTraderUnityToolkit.UnityGenerated.Types.Engine;

using Core;
using Unity;

/* $Mesh (24 fields) 29D58FC1C0BF1DF7BFCDB3F9CDA78EB9 */
public record class Mesh(
    AsciiString m_Name /* None */,
    SubMesh[] m_SubMeshes /* NeedsAlign */,
    BlendShapeData m_Shapes /* NeedsAlign */,
    Matrix4x4f[] m_BindPose /* NeedsAlign */,
    uint[] m_BoneNameHashes /* NeedsAlign */,
    uint m_RootBoneNameHash /* NeedsAlign */,
    MinMaxAABB[] m_BonesAABB /* None */,
    VariableBoneCountWeights m_VariableBoneCountWeights /* NeedsAlign */,
    byte m_MeshCompression /* NeedsAlign */,
    bool m_IsReadable /* None */,
    bool m_KeepVertices /* None */,
    bool m_KeepIndices /* None */,
    int m_IndexFormat /* NeedsAlign */,
    byte[] m_IndexBuffer /* None */,
    VertexData m_VertexData /* NeedsAlign */,
    CompressedMesh m_CompressedMesh /* NeedsAlign */,
    AABB m_LocalAABB /* NeedsAlign */,
    int m_MeshUsageFlags /* None */,
    int m_CookingOptions /* None */,
    byte[] m_BakedConvexCollisionMesh /* None */,
    byte[] m_BakedTriangleCollisionMesh /* NeedsAlign */,
    float m_MeshMetrics_0 /* NeedsAlign */,
    float m_MeshMetrics_1 /* None */,
    StreamingInfo m_StreamData /* NeedsAlign */) : IUnityObject
{
    public static Hash128 Hash => new(701861825, 3233750519, 3217929209, 3450310329);
    public static Mesh Read(EndianBinaryReader reader)
    {
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_SubMeshes */
        SubMesh[] _m_SubMeshes = BuiltInArray<SubMesh>.Read(reader);
        reader.AlignTo(4); /* m_Shapes */
        BlendShapeData _m_Shapes = BlendShapeData.Read(reader);
        reader.AlignTo(4); /* m_BindPose */
        Matrix4x4f[] _m_BindPose = BuiltInArray<Matrix4x4f>.Read(reader);
        reader.AlignTo(4); /* m_BoneNameHashes */
        uint[] _m_BoneNameHashes = BuiltInArray<uint>.Read(reader);
        reader.AlignTo(4); /* m_RootBoneNameHash */
        uint _m_RootBoneNameHash = reader.ReadU32();
        MinMaxAABB[] _m_BonesAABB = BuiltInArray<MinMaxAABB>.Read(reader);
        reader.AlignTo(4); /* m_VariableBoneCountWeights */
        VariableBoneCountWeights _m_VariableBoneCountWeights = VariableBoneCountWeights.Read(reader);
        reader.AlignTo(4); /* m_MeshCompression */
        byte _m_MeshCompression = reader.ReadU8();
        bool _m_IsReadable = reader.ReadBool();
        bool _m_KeepVertices = reader.ReadBool();
        bool _m_KeepIndices = reader.ReadBool();
        reader.AlignTo(4); /* m_IndexFormat */
        int _m_IndexFormat = reader.ReadS32();
        byte[] _m_IndexBuffer = BuiltInArray<byte>.Read(reader);
        reader.AlignTo(4); /* m_VertexData */
        VertexData _m_VertexData = VertexData.Read(reader);
        reader.AlignTo(4); /* m_CompressedMesh */
        CompressedMesh _m_CompressedMesh = CompressedMesh.Read(reader);
        reader.AlignTo(4); /* m_LocalAABB */
        AABB _m_LocalAABB = AABB.Read(reader);
        int _m_MeshUsageFlags = reader.ReadS32();
        int _m_CookingOptions = reader.ReadS32();
        byte[] _m_BakedConvexCollisionMesh = BuiltInArray<byte>.Read(reader);
        reader.AlignTo(4); /* m_BakedTriangleCollisionMesh */
        byte[] _m_BakedTriangleCollisionMesh = BuiltInArray<byte>.Read(reader);
        reader.AlignTo(4); /* m_MeshMetrics_0 */
        float _m_MeshMetrics_0 = reader.ReadF32();
        float _m_MeshMetrics_1 = reader.ReadF32();
        reader.AlignTo(4); /* m_StreamData */
        StreamingInfo _m_StreamData = StreamingInfo.Read(reader);
        
        return new(_m_Name,
            _m_SubMeshes,
            _m_Shapes,
            _m_BindPose,
            _m_BoneNameHashes,
            _m_RootBoneNameHash,
            _m_BonesAABB,
            _m_VariableBoneCountWeights,
            _m_MeshCompression,
            _m_IsReadable,
            _m_KeepVertices,
            _m_KeepIndices,
            _m_IndexFormat,
            _m_IndexBuffer,
            _m_VertexData,
            _m_CompressedMesh,
            _m_LocalAABB,
            _m_MeshUsageFlags,
            _m_CookingOptions,
            _m_BakedConvexCollisionMesh,
            _m_BakedTriangleCollisionMesh,
            _m_MeshMetrics_0,
            _m_MeshMetrics_1,
            _m_StreamData);
    }
}


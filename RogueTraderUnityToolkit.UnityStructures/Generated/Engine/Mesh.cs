namespace RogueTraderUnityToolkit.UnityStructures.Generated.Engine;

using Core;
using Unity.BuiltInTypes;

/* $Mesh (24 fields) (IsEngineType) */
public record class Mesh(
    AsciiString m_Name,
    SubMesh[] m_SubMeshes,
    BlendShapeData m_Shapes,
    Matrix4x4f[] m_BindPose,
    uint[] m_BoneNameHashes,
    uint m_RootBoneNameHash,
    MinMaxAABB[] m_BonesAABB,
    VariableBoneCountWeights m_VariableBoneCountWeights,
    byte m_MeshCompression,
    bool m_IsReadable,
    bool m_KeepVertices,
    bool m_KeepIndices,
    int m_IndexFormat,
    byte[] m_IndexBuffer,
    VertexData m_VertexData,
    CompressedMesh m_CompressedMesh,
    AABB m_LocalAABB,
    int m_MeshUsageFlags,
    int m_CookingOptions,
    byte[] m_BakedConvexCollisionMesh,
    byte[] m_BakedTriangleCollisionMesh,
    float m_MeshMetrics_0,
    float m_MeshMetrics_1,
    StreamingInfo m_StreamData)
{
    public static Mesh Read(EndianBinaryReader reader)
    {
        AsciiString m_Name = String.Read(reader);
        SubMesh[] m_SubMeshes = Array<SubMesh>.Read(reader);
        BlendShapeData m_Shapes = BlendShapeData.Read(reader);
        Matrix4x4f[] m_BindPose = Array<Matrix4x4f>.Read(reader);
        uint[] m_BoneNameHashes = Array<uint>.Read(reader);
        uint m_RootBoneNameHash = reader.ReadU32();
        MinMaxAABB[] m_BonesAABB = Array<MinMaxAABB>.Read(reader);
        VariableBoneCountWeights m_VariableBoneCountWeights = VariableBoneCountWeights.Read(reader);
        byte m_MeshCompression = reader.ReadU8();
        bool m_IsReadable = reader.ReadBool();
        bool m_KeepVertices = reader.ReadBool();
        bool m_KeepIndices = reader.ReadBool();
        int m_IndexFormat = reader.ReadS32();
        byte[] m_IndexBuffer = Array<byte>.Read(reader);
        VertexData m_VertexData = VertexData.Read(reader);
        CompressedMesh m_CompressedMesh = CompressedMesh.Read(reader);
        AABB m_LocalAABB = AABB.Read(reader);
        int m_MeshUsageFlags = reader.ReadS32();
        int m_CookingOptions = reader.ReadS32();
        byte[] m_BakedConvexCollisionMesh = Array<byte>.Read(reader);
        byte[] m_BakedTriangleCollisionMesh = Array<byte>.Read(reader);
        float m_MeshMetrics_0 = reader.ReadF32();
        float m_MeshMetrics_1 = reader.ReadF32();
        StreamingInfo m_StreamData = StreamingInfo.Read(reader);
        
        return new(m_Name,
            m_SubMeshes,
            m_Shapes,
            m_BindPose,
            m_BoneNameHashes,
            m_RootBoneNameHash,
            m_BonesAABB,
            m_VariableBoneCountWeights,
            m_MeshCompression,
            m_IsReadable,
            m_KeepVertices,
            m_KeepIndices,
            m_IndexFormat,
            m_IndexBuffer,
            m_VertexData,
            m_CompressedMesh,
            m_LocalAABB,
            m_MeshUsageFlags,
            m_CookingOptions,
            m_BakedConvexCollisionMesh,
            m_BakedTriangleCollisionMesh,
            m_MeshMetrics_0,
            m_MeshMetrics_1,
            m_StreamData);
    }
}


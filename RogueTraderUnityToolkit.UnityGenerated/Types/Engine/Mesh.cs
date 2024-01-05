namespace RogueTraderUnityToolkit.UnityGenerated.Types.Engine;

using Core;
using System.Text;
using Unity;

/* $Mesh (24 fields) 29D58FC1C0BF1DF7BFCDB3F9CDA78EB9 */
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
    StreamingInfo m_StreamData) : IUnityEngineStructure
{
    public static Hash128 Hash => new(701861825, 3233750519, 3217929209, 3450310329);

    public static Mesh Read(EndianBinaryReader reader)
    {
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_Name */
        SubMesh[] _m_SubMeshes = BuiltInArray<SubMesh>.Read(reader);
        reader.AlignTo(4); /* m_SubMeshes */
        BlendShapeData _m_Shapes = BlendShapeData.Read(reader);
        reader.AlignTo(4); /* m_Shapes */
        Matrix4x4f[] _m_BindPose = BuiltInArray<Matrix4x4f>.Read(reader);
        reader.AlignTo(4); /* m_BindPose */
        uint[] _m_BoneNameHashes = BuiltInArray<uint>.Read(reader);
        reader.AlignTo(4); /* m_BoneNameHashes */
        uint _m_RootBoneNameHash = reader.ReadU32();
        MinMaxAABB[] _m_BonesAABB = BuiltInArray<MinMaxAABB>.Read(reader);
        reader.AlignTo(4); /* m_BonesAABB */
        VariableBoneCountWeights _m_VariableBoneCountWeights = VariableBoneCountWeights.Read(reader);
        reader.AlignTo(4); /* m_VariableBoneCountWeights */
        byte _m_MeshCompression = reader.ReadU8();
        bool _m_IsReadable = reader.ReadBool();
        bool _m_KeepVertices = reader.ReadBool();
        bool _m_KeepIndices = reader.ReadBool();
        reader.AlignTo(4); /* m_KeepIndices */
        int _m_IndexFormat = reader.ReadS32();
        byte[] _m_IndexBuffer = BuiltInArray<byte>.Read(reader);
        reader.AlignTo(4); /* m_IndexBuffer */
        VertexData _m_VertexData = VertexData.Read(reader);
        reader.AlignTo(4); /* m_VertexData */
        CompressedMesh _m_CompressedMesh = CompressedMesh.Read(reader);
        reader.AlignTo(4); /* m_CompressedMesh */
        AABB _m_LocalAABB = AABB.Read(reader);
        int _m_MeshUsageFlags = reader.ReadS32();
        int _m_CookingOptions = reader.ReadS32();
        byte[] _m_BakedConvexCollisionMesh = BuiltInArray<byte>.Read(reader);
        reader.AlignTo(4); /* m_BakedConvexCollisionMesh */
        byte[] _m_BakedTriangleCollisionMesh = BuiltInArray<byte>.Read(reader);
        reader.AlignTo(4); /* m_BakedTriangleCollisionMesh */
        float _m_MeshMetrics_0 = reader.ReadF32();
        float _m_MeshMetrics_1 = reader.ReadF32();
        reader.AlignTo(4); /* m_MeshMetrics_1 */
        StreamingInfo _m_StreamData = StreamingInfo.Read(reader);
        reader.AlignTo(4); /* m_StreamData */
        
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

    public override string ToString() => $"Mesh\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Name: ");
        sb.AppendLine(m_Name.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_SubMeshes: ");
        sb.AppendLine(m_SubMeshes.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Shapes: ");
        sb.AppendLine();
        sb.Append(m_Shapes.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_BindPose: ");
        sb.AppendLine(m_BindPose.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_BoneNameHashes: ");
        sb.AppendLine(m_BoneNameHashes.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_RootBoneNameHash: ");
        sb.AppendLine(m_RootBoneNameHash.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_BonesAABB: ");
        sb.AppendLine(m_BonesAABB.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_VariableBoneCountWeights: ");
        sb.AppendLine();
        sb.Append(m_VariableBoneCountWeights.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_MeshCompression: ");
        sb.AppendLine(m_MeshCompression.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_IsReadable: ");
        sb.AppendLine(m_IsReadable.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_KeepVertices: ");
        sb.AppendLine(m_KeepVertices.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_KeepIndices: ");
        sb.AppendLine(m_KeepIndices.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_IndexFormat: ");
        sb.AppendLine(m_IndexFormat.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_IndexBuffer: ");
        sb.AppendLine(m_IndexBuffer.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_VertexData: ");
        sb.AppendLine();
        sb.Append(m_VertexData.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_CompressedMesh: ");
        sb.AppendLine();
        sb.Append(m_CompressedMesh.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_LocalAABB: ");
        sb.AppendLine();
        sb.Append(m_LocalAABB.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_MeshUsageFlags: ");
        sb.AppendLine(m_MeshUsageFlags.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_CookingOptions: ");
        sb.AppendLine(m_CookingOptions.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_BakedConvexCollisionMesh: ");
        sb.AppendLine(m_BakedConvexCollisionMesh.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_BakedTriangleCollisionMesh: ");
        sb.AppendLine(m_BakedTriangleCollisionMesh.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_MeshMetrics_0: ");
        sb.AppendLine(m_MeshMetrics_0.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_MeshMetrics_1: ");
        sb.AppendLine(m_MeshMetrics_1.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_StreamData: ");
        sb.AppendLine();
        sb.Append(m_StreamData.ToString(indent+4));

        return sb.ToString();
    }
}


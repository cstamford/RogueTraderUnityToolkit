namespace RogueTraderUnityToolkit.UnityGenerated.Types.Engine;

using Core;
using System.Text;
using Unity;

/* $Mesh (24 fields) Mesh 29D58FC1C0BF1DF7BFCDB3F9CDA78EB9 */
public record class Mesh (
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
    public static UnityObjectType ObjectType => UnityObjectType.Mesh;
    public static Hash128 Hash => new("29D58FC1C0BF1DF7BFCDB3F9CDA78EB9");
    public static Mesh Read(EndianBinaryReader reader)
    {
        AsciiString m_Name_ = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_Name */
        SubMesh[] m_SubMeshes_ = BuiltInArray<SubMesh>.Read(reader);
        reader.AlignTo(4); /* m_SubMeshes */
        BlendShapeData m_Shapes_ = BlendShapeData.Read(reader);
        reader.AlignTo(4); /* m_Shapes */
        Matrix4x4f[] m_BindPose_ = BuiltInArray<Matrix4x4f>.Read(reader);
        reader.AlignTo(4); /* m_BindPose */
        uint[] m_BoneNameHashes_ = BuiltInArray<uint>.Read(reader);
        reader.AlignTo(4); /* m_BoneNameHashes */
        uint m_RootBoneNameHash_ = reader.ReadU32();
        MinMaxAABB[] m_BonesAABB_ = BuiltInArray<MinMaxAABB>.Read(reader);
        reader.AlignTo(4); /* m_BonesAABB */
        VariableBoneCountWeights m_VariableBoneCountWeights_ = VariableBoneCountWeights.Read(reader);
        reader.AlignTo(4); /* m_VariableBoneCountWeights */
        byte m_MeshCompression_ = reader.ReadU8();
        bool m_IsReadable_ = reader.ReadBool();
        bool m_KeepVertices_ = reader.ReadBool();
        bool m_KeepIndices_ = reader.ReadBool();
        reader.AlignTo(4); /* m_KeepIndices */
        int m_IndexFormat_ = reader.ReadS32();
        byte[] m_IndexBuffer_ = BuiltInArray<byte>.Read(reader);
        reader.AlignTo(4); /* m_IndexBuffer */
        VertexData m_VertexData_ = VertexData.Read(reader);
        reader.AlignTo(4); /* m_VertexData */
        CompressedMesh m_CompressedMesh_ = CompressedMesh.Read(reader);
        reader.AlignTo(4); /* m_CompressedMesh */
        AABB m_LocalAABB_ = AABB.Read(reader);
        int m_MeshUsageFlags_ = reader.ReadS32();
        int m_CookingOptions_ = reader.ReadS32();
        byte[] m_BakedConvexCollisionMesh_ = BuiltInArray<byte>.Read(reader);
        reader.AlignTo(4); /* m_BakedConvexCollisionMesh */
        byte[] m_BakedTriangleCollisionMesh_ = BuiltInArray<byte>.Read(reader);
        reader.AlignTo(4); /* m_BakedTriangleCollisionMesh */
        float m_MeshMetrics_0_ = reader.ReadF32();
        float m_MeshMetrics_1_ = reader.ReadF32();
        reader.AlignTo(4); /* m_MeshMetrics_1 */
        StreamingInfo m_StreamData_ = StreamingInfo.Read(reader);
        reader.AlignTo(4); /* m_StreamData */
        
        return new(m_Name_,
            m_SubMeshes_,
            m_Shapes_,
            m_BindPose_,
            m_BoneNameHashes_,
            m_RootBoneNameHash_,
            m_BonesAABB_,
            m_VariableBoneCountWeights_,
            m_MeshCompression_,
            m_IsReadable_,
            m_KeepVertices_,
            m_KeepIndices_,
            m_IndexFormat_,
            m_IndexBuffer_,
            m_VertexData_,
            m_CompressedMesh_,
            m_LocalAABB_,
            m_MeshUsageFlags_,
            m_CookingOptions_,
            m_BakedConvexCollisionMesh_,
            m_BakedTriangleCollisionMesh_,
            m_MeshMetrics_0_,
            m_MeshMetrics_1_,
            m_StreamData_);
    }

    public override string ToString() => $"Mesh\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();
        string indent_ = ' '.Repeat(indent);

        ToString_Field0(sb, indent, indent_);
        ToString_Field1(sb, indent, indent_);
        ToString_Field2(sb, indent, indent_);
        ToString_Field3(sb, indent, indent_);
        ToString_Field4(sb, indent, indent_);
        ToString_Field5(sb, indent, indent_);
        ToString_Field6(sb, indent, indent_);
        ToString_Field7(sb, indent, indent_);
        ToString_Field8(sb, indent, indent_);
        ToString_Field9(sb, indent, indent_);
        ToString_Field10(sb, indent, indent_);
        ToString_Field11(sb, indent, indent_);
        ToString_Field12(sb, indent, indent_);
        ToString_Field13(sb, indent, indent_);
        ToString_Field14(sb, indent, indent_);
        ToString_Field15(sb, indent, indent_);
        ToString_Field16(sb, indent, indent_);
        ToString_Field17(sb, indent, indent_);
        ToString_Field18(sb, indent, indent_);
        ToString_Field19(sb, indent, indent_);
        ToString_Field20(sb, indent, indent_);
        ToString_Field21(sb, indent, indent_);
        ToString_Field22(sb, indent, indent_);
        ToString_Field23(sb, indent, indent_);

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_Name: \"{m_Name}\"");
    }

    public void ToString_Field1(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_SubMeshes[{m_SubMeshes.Length}] = {{");
        if (m_SubMeshes.Length > 0) sb.AppendLine();
        int _4i = 0;
        foreach (SubMesh _4 in m_SubMeshes)
        {
            sb.Append($"{indent_ + ' '.Repeat(4)}[{_4i}] = {{ \n{_4.ToString(indent+8)}{indent_ + ' '.Repeat(4)}}}\n");
            ++_4i;
        }
        if (m_SubMeshes.Length > 0) sb.Append(indent_);
        sb.AppendLine("}");
    }

    public void ToString_Field2(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_Shapes: {{ \n{m_Shapes.ToString(indent+4)}{indent_}}}\n");
    }

    public void ToString_Field3(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_BindPose[{m_BindPose.Length}] = {{");
        if (m_BindPose.Length > 0) sb.AppendLine();
        int _4i = 0;
        foreach (Matrix4x4f _4 in m_BindPose)
        {
            sb.Append($"{indent_ + ' '.Repeat(4)}[{_4i}] = {{ \n{_4.ToString(indent+8)}{indent_ + ' '.Repeat(4)}}}\n");
            ++_4i;
        }
        if (m_BindPose.Length > 0) sb.Append(indent_);
        sb.AppendLine("}");
    }

    public void ToString_Field4(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_BoneNameHashes[{m_BoneNameHashes.Length}] = {{");
        if (m_BoneNameHashes.Length > 0) sb.AppendLine();
        int _4i = 0;
        foreach (uint _4 in m_BoneNameHashes)
        {
            sb.AppendLine($"{indent_ + ' '.Repeat(4)}[{_4i}] = {_4}");
            ++_4i;
        }
        if (m_BoneNameHashes.Length > 0) sb.Append(indent_);
        sb.AppendLine("}");
    }

    public void ToString_Field5(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_RootBoneNameHash: {m_RootBoneNameHash}");
    }

    public void ToString_Field6(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_BonesAABB[{m_BonesAABB.Length}] = {{");
        if (m_BonesAABB.Length > 0) sb.AppendLine();
        int _4i = 0;
        foreach (MinMaxAABB _4 in m_BonesAABB)
        {
            sb.Append($"{indent_ + ' '.Repeat(4)}[{_4i}] = {{ \n{_4.ToString(indent+8)}{indent_ + ' '.Repeat(4)}}}\n");
            ++_4i;
        }
        if (m_BonesAABB.Length > 0) sb.Append(indent_);
        sb.AppendLine("}");
    }

    public void ToString_Field7(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_VariableBoneCountWeights: {{ \n{m_VariableBoneCountWeights.ToString(indent+4)}{indent_}}}\n");
    }

    public void ToString_Field8(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_MeshCompression: {m_MeshCompression}");
    }

    public void ToString_Field9(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_IsReadable: {m_IsReadable}");
    }

    public void ToString_Field10(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_KeepVertices: {m_KeepVertices}");
    }

    public void ToString_Field11(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_KeepIndices: {m_KeepIndices}");
    }

    public void ToString_Field12(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_IndexFormat: {m_IndexFormat}");
    }

    public void ToString_Field13(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_IndexBuffer[{m_IndexBuffer.Length}] = {{");
        if (m_IndexBuffer.Length > 0) sb.AppendLine();
        int _4i = 0;
        foreach (byte _4 in m_IndexBuffer)
        {
            sb.AppendLine($"{indent_ + ' '.Repeat(4)}[{_4i}] = {_4}");
            ++_4i;
        }
        if (m_IndexBuffer.Length > 0) sb.Append(indent_);
        sb.AppendLine("}");
    }

    public void ToString_Field14(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_VertexData: {{ \n{m_VertexData.ToString(indent+4)}{indent_}}}\n");
    }

    public void ToString_Field15(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_CompressedMesh: {{ \n{m_CompressedMesh.ToString(indent+4)}{indent_}}}\n");
    }

    public void ToString_Field16(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_LocalAABB: {{ \n{m_LocalAABB.ToString(indent+4)}{indent_}}}\n");
    }

    public void ToString_Field17(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_MeshUsageFlags: {m_MeshUsageFlags}");
    }

    public void ToString_Field18(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_CookingOptions: {m_CookingOptions}");
    }

    public void ToString_Field19(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_BakedConvexCollisionMesh[{m_BakedConvexCollisionMesh.Length}] = {{");
        if (m_BakedConvexCollisionMesh.Length > 0) sb.AppendLine();
        int _4i = 0;
        foreach (byte _4 in m_BakedConvexCollisionMesh)
        {
            sb.AppendLine($"{indent_ + ' '.Repeat(4)}[{_4i}] = {_4}");
            ++_4i;
        }
        if (m_BakedConvexCollisionMesh.Length > 0) sb.Append(indent_);
        sb.AppendLine("}");
    }

    public void ToString_Field20(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_BakedTriangleCollisionMesh[{m_BakedTriangleCollisionMesh.Length}] = {{");
        if (m_BakedTriangleCollisionMesh.Length > 0) sb.AppendLine();
        int _4i = 0;
        foreach (byte _4 in m_BakedTriangleCollisionMesh)
        {
            sb.AppendLine($"{indent_ + ' '.Repeat(4)}[{_4i}] = {_4}");
            ++_4i;
        }
        if (m_BakedTriangleCollisionMesh.Length > 0) sb.Append(indent_);
        sb.AppendLine("}");
    }

    public void ToString_Field21(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_MeshMetrics_0: {m_MeshMetrics_0}");
    }

    public void ToString_Field22(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_MeshMetrics_1: {m_MeshMetrics_1}");
    }

    public void ToString_Field23(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_StreamData: {{ \n{m_StreamData.ToString(indent+4)}{indent_}}}\n");
    }
}


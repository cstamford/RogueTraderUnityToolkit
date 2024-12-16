namespace RogueTraderUnityToolkit.UnityGenerated.Types.Engine;

using Core;
using System.Text;
using Unity;

/* $ParticleSystemRenderer (57 fields) ParticleSystemRenderer 28FC782F1510F920711F90C4C01CBE20 */
public record class ParticleSystemRenderer (
    PPtr<GameObject> m_GameObject,
    bool m_Enabled,
    byte m_CastShadows,
    byte m_ReceiveShadows,
    byte m_DynamicOccludee,
    byte m_StaticShadowCaster,
    byte m_MotionVectors,
    byte m_LightProbeUsage,
    byte m_ReflectionProbeUsage,
    byte m_RayTracingMode,
    byte m_RayTraceProcedural,
    uint m_RenderingLayerMask,
    int m_RendererPriority,
    ushort m_LightmapIndex,
    ushort m_LightmapIndexDynamic,
    Vector4f m_LightmapTilingOffset,
    Vector4f m_LightmapTilingOffsetDynamic,
    PPtr<Material>[] m_Materials,
    StaticBatchInfo m_StaticBatchInfo,
    PPtr<Transform> m_StaticBatchRoot,
    PPtr<Transform> m_ProbeAnchor,
    PPtr<GameObject> m_LightProbeVolumeOverride,
    int m_SortingLayerID,
    short m_SortingLayer,
    short m_SortingOrder,
    ushort m_RenderMode,
    byte m_MeshDistribution,
    byte m_SortMode,
    float m_MinParticleSize,
    float m_MaxParticleSize,
    float m_CameraVelocityScale,
    float m_VelocityScale,
    float m_LengthScale,
    float m_SortingFudge,
    float m_NormalDirection,
    float m_ShadowBias,
    int m_RenderAlignment,
    Vector3f m_Pivot,
    Vector3f m_Flip,
    bool m_EnableGPUInstancing,
    bool m_ApplyActiveColorSpace,
    bool m_AllowRoll,
    bool m_FreeformStretching,
    bool m_RotateWithStretchDirection,
    bool m_UseCustomVertexStreams,
    byte[] m_VertexStreams,
    bool m_UseCustomTrailVertexStreams,
    byte[] m_TrailVertexStreams,
    PPtr<Mesh> m_Mesh,
    PPtr<Mesh> m_Mesh1,
    PPtr<Mesh> m_Mesh2,
    PPtr<Mesh> m_Mesh3,
    float m_MeshWeighting,
    float m_MeshWeighting1,
    float m_MeshWeighting2,
    float m_MeshWeighting3,
    int m_MaskInteraction) : IUnityEngineStructure
{
    public static UnityObjectType ObjectType => UnityObjectType.ParticleSystemRenderer;
    public static Hash128 Hash => new("28FC782F1510F920711F90C4C01CBE20");
    public static ParticleSystemRenderer Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> m_GameObject_ = PPtr<GameObject>.Read(reader);
        bool m_Enabled_ = reader.ReadBool();
        byte m_CastShadows_ = reader.ReadU8();
        byte m_ReceiveShadows_ = reader.ReadU8();
        byte m_DynamicOccludee_ = reader.ReadU8();
        byte m_StaticShadowCaster_ = reader.ReadU8();
        byte m_MotionVectors_ = reader.ReadU8();
        byte m_LightProbeUsage_ = reader.ReadU8();
        byte m_ReflectionProbeUsage_ = reader.ReadU8();
        byte m_RayTracingMode_ = reader.ReadU8();
        byte m_RayTraceProcedural_ = reader.ReadU8();
        reader.AlignTo(4); /* m_RayTraceProcedural */
        uint m_RenderingLayerMask_ = reader.ReadU32();
        int m_RendererPriority_ = reader.ReadS32();
        ushort m_LightmapIndex_ = reader.ReadU16();
        ushort m_LightmapIndexDynamic_ = reader.ReadU16();
        Vector4f m_LightmapTilingOffset_ = Vector4f.Read(reader);
        Vector4f m_LightmapTilingOffsetDynamic_ = Vector4f.Read(reader);
        PPtr<Material>[] m_Materials_ = BuiltInArray<PPtr<Material>>.Read(reader);
        reader.AlignTo(4); /* m_Materials */
        StaticBatchInfo m_StaticBatchInfo_ = StaticBatchInfo.Read(reader);
        PPtr<Transform> m_StaticBatchRoot_ = PPtr<Transform>.Read(reader);
        PPtr<Transform> m_ProbeAnchor_ = PPtr<Transform>.Read(reader);
        PPtr<GameObject> m_LightProbeVolumeOverride_ = PPtr<GameObject>.Read(reader);
        reader.AlignTo(4); /* m_LightProbeVolumeOverride */
        int m_SortingLayerID_ = reader.ReadS32();
        short m_SortingLayer_ = reader.ReadS16();
        short m_SortingOrder_ = reader.ReadS16();
        reader.AlignTo(4); /* m_SortingOrder */
        ushort m_RenderMode_ = reader.ReadU16();
        byte m_MeshDistribution_ = reader.ReadU8();
        byte m_SortMode_ = reader.ReadU8();
        float m_MinParticleSize_ = reader.ReadF32();
        float m_MaxParticleSize_ = reader.ReadF32();
        float m_CameraVelocityScale_ = reader.ReadF32();
        float m_VelocityScale_ = reader.ReadF32();
        float m_LengthScale_ = reader.ReadF32();
        float m_SortingFudge_ = reader.ReadF32();
        float m_NormalDirection_ = reader.ReadF32();
        float m_ShadowBias_ = reader.ReadF32();
        int m_RenderAlignment_ = reader.ReadS32();
        Vector3f m_Pivot_ = Vector3f.Read(reader);
        Vector3f m_Flip_ = Vector3f.Read(reader);
        bool m_EnableGPUInstancing_ = reader.ReadBool();
        bool m_ApplyActiveColorSpace_ = reader.ReadBool();
        bool m_AllowRoll_ = reader.ReadBool();
        bool m_FreeformStretching_ = reader.ReadBool();
        bool m_RotateWithStretchDirection_ = reader.ReadBool();
        reader.AlignTo(4); /* m_RotateWithStretchDirection */
        bool m_UseCustomVertexStreams_ = reader.ReadBool();
        reader.AlignTo(4); /* m_UseCustomVertexStreams */
        byte[] m_VertexStreams_ = BuiltInArray<byte>.Read(reader);
        reader.AlignTo(4); /* m_VertexStreams */
        bool m_UseCustomTrailVertexStreams_ = reader.ReadBool();
        reader.AlignTo(4); /* m_UseCustomTrailVertexStreams */
        byte[] m_TrailVertexStreams_ = BuiltInArray<byte>.Read(reader);
        reader.AlignTo(4); /* m_TrailVertexStreams */
        PPtr<Mesh> m_Mesh_ = PPtr<Mesh>.Read(reader);
        PPtr<Mesh> m_Mesh1_ = PPtr<Mesh>.Read(reader);
        PPtr<Mesh> m_Mesh2_ = PPtr<Mesh>.Read(reader);
        PPtr<Mesh> m_Mesh3_ = PPtr<Mesh>.Read(reader);
        float m_MeshWeighting_ = reader.ReadF32();
        float m_MeshWeighting1_ = reader.ReadF32();
        float m_MeshWeighting2_ = reader.ReadF32();
        float m_MeshWeighting3_ = reader.ReadF32();
        int m_MaskInteraction_ = reader.ReadS32();
        
        return new(m_GameObject_,
            m_Enabled_,
            m_CastShadows_,
            m_ReceiveShadows_,
            m_DynamicOccludee_,
            m_StaticShadowCaster_,
            m_MotionVectors_,
            m_LightProbeUsage_,
            m_ReflectionProbeUsage_,
            m_RayTracingMode_,
            m_RayTraceProcedural_,
            m_RenderingLayerMask_,
            m_RendererPriority_,
            m_LightmapIndex_,
            m_LightmapIndexDynamic_,
            m_LightmapTilingOffset_,
            m_LightmapTilingOffsetDynamic_,
            m_Materials_,
            m_StaticBatchInfo_,
            m_StaticBatchRoot_,
            m_ProbeAnchor_,
            m_LightProbeVolumeOverride_,
            m_SortingLayerID_,
            m_SortingLayer_,
            m_SortingOrder_,
            m_RenderMode_,
            m_MeshDistribution_,
            m_SortMode_,
            m_MinParticleSize_,
            m_MaxParticleSize_,
            m_CameraVelocityScale_,
            m_VelocityScale_,
            m_LengthScale_,
            m_SortingFudge_,
            m_NormalDirection_,
            m_ShadowBias_,
            m_RenderAlignment_,
            m_Pivot_,
            m_Flip_,
            m_EnableGPUInstancing_,
            m_ApplyActiveColorSpace_,
            m_AllowRoll_,
            m_FreeformStretching_,
            m_RotateWithStretchDirection_,
            m_UseCustomVertexStreams_,
            m_VertexStreams_,
            m_UseCustomTrailVertexStreams_,
            m_TrailVertexStreams_,
            m_Mesh_,
            m_Mesh1_,
            m_Mesh2_,
            m_Mesh3_,
            m_MeshWeighting_,
            m_MeshWeighting1_,
            m_MeshWeighting2_,
            m_MeshWeighting3_,
            m_MaskInteraction_);
    }

    public override string ToString() => $"ParticleSystemRenderer\n{ToString(4)}";

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
        ToString_Field24(sb, indent, indent_);
        ToString_Field25(sb, indent, indent_);
        ToString_Field26(sb, indent, indent_);
        ToString_Field27(sb, indent, indent_);
        ToString_Field28(sb, indent, indent_);
        ToString_Field29(sb, indent, indent_);
        ToString_Field30(sb, indent, indent_);
        ToString_Field31(sb, indent, indent_);
        ToString_Field32(sb, indent, indent_);
        ToString_Field33(sb, indent, indent_);
        ToString_Field34(sb, indent, indent_);
        ToString_Field35(sb, indent, indent_);
        ToString_Field36(sb, indent, indent_);
        ToString_Field37(sb, indent, indent_);
        ToString_Field38(sb, indent, indent_);
        ToString_Field39(sb, indent, indent_);
        ToString_Field40(sb, indent, indent_);
        ToString_Field41(sb, indent, indent_);
        ToString_Field42(sb, indent, indent_);
        ToString_Field43(sb, indent, indent_);
        ToString_Field44(sb, indent, indent_);
        ToString_Field45(sb, indent, indent_);
        ToString_Field46(sb, indent, indent_);
        ToString_Field47(sb, indent, indent_);
        ToString_Field48(sb, indent, indent_);
        ToString_Field49(sb, indent, indent_);
        ToString_Field50(sb, indent, indent_);
        ToString_Field51(sb, indent, indent_);
        ToString_Field52(sb, indent, indent_);
        ToString_Field53(sb, indent, indent_);
        ToString_Field54(sb, indent, indent_);
        ToString_Field55(sb, indent, indent_);
        ToString_Field56(sb, indent, indent_);

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_GameObject: {m_GameObject}");
    }

    public void ToString_Field1(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_Enabled: {m_Enabled}");
    }

    public void ToString_Field2(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_CastShadows: {m_CastShadows}");
    }

    public void ToString_Field3(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_ReceiveShadows: {m_ReceiveShadows}");
    }

    public void ToString_Field4(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_DynamicOccludee: {m_DynamicOccludee}");
    }

    public void ToString_Field5(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_StaticShadowCaster: {m_StaticShadowCaster}");
    }

    public void ToString_Field6(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_MotionVectors: {m_MotionVectors}");
    }

    public void ToString_Field7(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_LightProbeUsage: {m_LightProbeUsage}");
    }

    public void ToString_Field8(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_ReflectionProbeUsage: {m_ReflectionProbeUsage}");
    }

    public void ToString_Field9(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_RayTracingMode: {m_RayTracingMode}");
    }

    public void ToString_Field10(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_RayTraceProcedural: {m_RayTraceProcedural}");
    }

    public void ToString_Field11(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_RenderingLayerMask: {m_RenderingLayerMask}");
    }

    public void ToString_Field12(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_RendererPriority: {m_RendererPriority}");
    }

    public void ToString_Field13(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_LightmapIndex: {m_LightmapIndex}");
    }

    public void ToString_Field14(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_LightmapIndexDynamic: {m_LightmapIndexDynamic}");
    }

    public void ToString_Field15(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_LightmapTilingOffset: {{ x: {m_LightmapTilingOffset.x}, y: {m_LightmapTilingOffset.y}, z: {m_LightmapTilingOffset.z}, w: {m_LightmapTilingOffset.w} }}\n");
    }

    public void ToString_Field16(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_LightmapTilingOffsetDynamic: {{ x: {m_LightmapTilingOffsetDynamic.x}, y: {m_LightmapTilingOffsetDynamic.y}, z: {m_LightmapTilingOffsetDynamic.z}, w: {m_LightmapTilingOffsetDynamic.w} }}\n");
    }

    public void ToString_Field17(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_Materials[{m_Materials.Length}] = {{");
        if (m_Materials.Length > 0) sb.AppendLine();
        int _4i = 0;
        foreach (PPtr<Material> _4 in m_Materials)
        {
            sb.AppendLine($"{indent_ + ' '.Repeat(4)}[{_4i}] = {_4}");
            ++_4i;
        }
        if (m_Materials.Length > 0) sb.Append(indent_);
        sb.AppendLine("}");
    }

    public void ToString_Field18(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_StaticBatchInfo: {{ firstSubMesh: {m_StaticBatchInfo.firstSubMesh}, subMeshCount: {m_StaticBatchInfo.subMeshCount} }}\n");
    }

    public void ToString_Field19(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_StaticBatchRoot: {m_StaticBatchRoot}");
    }

    public void ToString_Field20(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_ProbeAnchor: {m_ProbeAnchor}");
    }

    public void ToString_Field21(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_LightProbeVolumeOverride: {m_LightProbeVolumeOverride}");
    }

    public void ToString_Field22(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_SortingLayerID: {m_SortingLayerID}");
    }

    public void ToString_Field23(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_SortingLayer: {m_SortingLayer}");
    }

    public void ToString_Field24(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_SortingOrder: {m_SortingOrder}");
    }

    public void ToString_Field25(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_RenderMode: {m_RenderMode}");
    }

    public void ToString_Field26(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_MeshDistribution: {m_MeshDistribution}");
    }

    public void ToString_Field27(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_SortMode: {m_SortMode}");
    }

    public void ToString_Field28(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_MinParticleSize: {m_MinParticleSize}");
    }

    public void ToString_Field29(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_MaxParticleSize: {m_MaxParticleSize}");
    }

    public void ToString_Field30(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_CameraVelocityScale: {m_CameraVelocityScale}");
    }

    public void ToString_Field31(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_VelocityScale: {m_VelocityScale}");
    }

    public void ToString_Field32(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_LengthScale: {m_LengthScale}");
    }

    public void ToString_Field33(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_SortingFudge: {m_SortingFudge}");
    }

    public void ToString_Field34(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_NormalDirection: {m_NormalDirection}");
    }

    public void ToString_Field35(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_ShadowBias: {m_ShadowBias}");
    }

    public void ToString_Field36(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_RenderAlignment: {m_RenderAlignment}");
    }

    public void ToString_Field37(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_Pivot: {{ x: {m_Pivot.x}, y: {m_Pivot.y}, z: {m_Pivot.z} }}\n");
    }

    public void ToString_Field38(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_Flip: {{ x: {m_Flip.x}, y: {m_Flip.y}, z: {m_Flip.z} }}\n");
    }

    public void ToString_Field39(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_EnableGPUInstancing: {m_EnableGPUInstancing}");
    }

    public void ToString_Field40(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_ApplyActiveColorSpace: {m_ApplyActiveColorSpace}");
    }

    public void ToString_Field41(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_AllowRoll: {m_AllowRoll}");
    }

    public void ToString_Field42(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_FreeformStretching: {m_FreeformStretching}");
    }

    public void ToString_Field43(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_RotateWithStretchDirection: {m_RotateWithStretchDirection}");
    }

    public void ToString_Field44(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_UseCustomVertexStreams: {m_UseCustomVertexStreams}");
    }

    public void ToString_Field45(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_VertexStreams[{m_VertexStreams.Length}] = {{");
        if (m_VertexStreams.Length > 0) sb.AppendLine();
        int _4i = 0;
        foreach (byte _4 in m_VertexStreams)
        {
            sb.AppendLine($"{indent_ + ' '.Repeat(4)}[{_4i}] = {_4}");
            ++_4i;
        }
        if (m_VertexStreams.Length > 0) sb.Append(indent_);
        sb.AppendLine("}");
    }

    public void ToString_Field46(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_UseCustomTrailVertexStreams: {m_UseCustomTrailVertexStreams}");
    }

    public void ToString_Field47(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_TrailVertexStreams[{m_TrailVertexStreams.Length}] = {{");
        if (m_TrailVertexStreams.Length > 0) sb.AppendLine();
        int _4i = 0;
        foreach (byte _4 in m_TrailVertexStreams)
        {
            sb.AppendLine($"{indent_ + ' '.Repeat(4)}[{_4i}] = {_4}");
            ++_4i;
        }
        if (m_TrailVertexStreams.Length > 0) sb.Append(indent_);
        sb.AppendLine("}");
    }

    public void ToString_Field48(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_Mesh: {m_Mesh}");
    }

    public void ToString_Field49(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_Mesh1: {m_Mesh1}");
    }

    public void ToString_Field50(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_Mesh2: {m_Mesh2}");
    }

    public void ToString_Field51(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_Mesh3: {m_Mesh3}");
    }

    public void ToString_Field52(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_MeshWeighting: {m_MeshWeighting}");
    }

    public void ToString_Field53(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_MeshWeighting1: {m_MeshWeighting1}");
    }

    public void ToString_Field54(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_MeshWeighting2: {m_MeshWeighting2}");
    }

    public void ToString_Field55(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_MeshWeighting3: {m_MeshWeighting3}");
    }

    public void ToString_Field56(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_MaskInteraction: {m_MaskInteraction}");
    }
}


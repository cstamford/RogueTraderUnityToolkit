namespace RogueTraderUnityToolkit.UnityGenerated.Types.Engine;

using Core;
using System.Text;
using Unity;

/* $SkinnedMeshRenderer (34 fields) SkinnedMeshRenderer 8AC1773BE8BCA8C0DB0398B67F6BF972 */
public record class SkinnedMeshRenderer (
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
    int m_Quality,
    bool m_UpdateWhenOffscreen,
    bool m_SkinnedMotionVectors,
    PPtr<Mesh> m_Mesh,
    PPtr<Transform>[] m_Bones,
    float[] m_BlendShapeWeights,
    PPtr<Transform> m_RootBone,
    AABB m_AABB,
    bool m_DirtyAABB) : IUnityEngineStructure
{
    public static UnityObjectType ObjectType => UnityObjectType.SkinnedMeshRenderer;
    public static Hash128 Hash => new("8AC1773BE8BCA8C0DB0398B67F6BF972");
    public static SkinnedMeshRenderer Read(EndianBinaryReader reader)
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
        int m_Quality_ = reader.ReadS32();
        bool m_UpdateWhenOffscreen_ = reader.ReadBool();
        bool m_SkinnedMotionVectors_ = reader.ReadBool();
        reader.AlignTo(4); /* m_SkinnedMotionVectors */
        PPtr<Mesh> m_Mesh_ = PPtr<Mesh>.Read(reader);
        PPtr<Transform>[] m_Bones_ = BuiltInArray<PPtr<Transform>>.Read(reader);
        reader.AlignTo(4); /* m_Bones */
        float[] m_BlendShapeWeights_ = BuiltInArray<float>.Read(reader);
        reader.AlignTo(4); /* m_BlendShapeWeights */
        PPtr<Transform> m_RootBone_ = PPtr<Transform>.Read(reader);
        AABB m_AABB_ = AABB.Read(reader);
        bool m_DirtyAABB_ = reader.ReadBool();
        reader.AlignTo(4); /* m_DirtyAABB */
        
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
            m_Quality_,
            m_UpdateWhenOffscreen_,
            m_SkinnedMotionVectors_,
            m_Mesh_,
            m_Bones_,
            m_BlendShapeWeights_,
            m_RootBone_,
            m_AABB_,
            m_DirtyAABB_);
    }

    public override string ToString() => $"SkinnedMeshRenderer\n{ToString(4)}";

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
        sb.AppendLine($"{indent_}m_Quality: {m_Quality}");
    }

    public void ToString_Field26(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_UpdateWhenOffscreen: {m_UpdateWhenOffscreen}");
    }

    public void ToString_Field27(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_SkinnedMotionVectors: {m_SkinnedMotionVectors}");
    }

    public void ToString_Field28(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_Mesh: {m_Mesh}");
    }

    public void ToString_Field29(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_Bones[{m_Bones.Length}] = {{");
        if (m_Bones.Length > 0) sb.AppendLine();
        int _4i = 0;
        foreach (PPtr<Transform> _4 in m_Bones)
        {
            sb.AppendLine($"{indent_ + ' '.Repeat(4)}[{_4i}] = {_4}");
            ++_4i;
        }
        if (m_Bones.Length > 0) sb.Append(indent_);
        sb.AppendLine("}");
    }

    public void ToString_Field30(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_BlendShapeWeights[{m_BlendShapeWeights.Length}] = {{");
        if (m_BlendShapeWeights.Length > 0) sb.AppendLine();
        int _4i = 0;
        foreach (float _4 in m_BlendShapeWeights)
        {
            sb.AppendLine($"{indent_ + ' '.Repeat(4)}[{_4i}] = {_4}");
            ++_4i;
        }
        if (m_BlendShapeWeights.Length > 0) sb.Append(indent_);
        sb.AppendLine("}");
    }

    public void ToString_Field31(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_RootBone: {m_RootBone}");
    }

    public void ToString_Field32(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_AABB: {{ \n{m_AABB.ToString(indent+4)}{indent_}}}\n");
    }

    public void ToString_Field33(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_DirtyAABB: {m_DirtyAABB}");
    }
}


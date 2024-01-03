namespace RogueTraderUnityToolkit.Unity.Generated.Engine;

using Core;

/* $SkinnedMeshRenderer (34 fields) (IsEngineType) */
public record class SkinnedMeshRenderer(
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
    bool m_DirtyAABB)
{
    public static SkinnedMeshRenderer Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> m_GameObject = PPtr<GameObject>.Read(reader);
        bool m_Enabled = reader.ReadBool();
        byte m_CastShadows = reader.ReadU8();
        byte m_ReceiveShadows = reader.ReadU8();
        byte m_DynamicOccludee = reader.ReadU8();
        byte m_StaticShadowCaster = reader.ReadU8();
        byte m_MotionVectors = reader.ReadU8();
        byte m_LightProbeUsage = reader.ReadU8();
        byte m_ReflectionProbeUsage = reader.ReadU8();
        byte m_RayTracingMode = reader.ReadU8();
        byte m_RayTraceProcedural = reader.ReadU8();
        uint m_RenderingLayerMask = reader.ReadU32();
        int m_RendererPriority = reader.ReadS32();
        ushort m_LightmapIndex = reader.ReadU16();
        ushort m_LightmapIndexDynamic = reader.ReadU16();
        Vector4f m_LightmapTilingOffset = Vector4f.Read(reader);
        Vector4f m_LightmapTilingOffsetDynamic = Vector4f.Read(reader);
        PPtr<Material>[] m_Materials = Array<PPtr<Material>>.Read(reader);
        StaticBatchInfo m_StaticBatchInfo = StaticBatchInfo.Read(reader);
        PPtr<Transform> m_StaticBatchRoot = PPtr<Transform>.Read(reader);
        PPtr<Transform> m_ProbeAnchor = PPtr<Transform>.Read(reader);
        PPtr<GameObject> m_LightProbeVolumeOverride = PPtr<GameObject>.Read(reader);
        int m_SortingLayerID = reader.ReadS32();
        short m_SortingLayer = reader.ReadS16();
        short m_SortingOrder = reader.ReadS16();
        int m_Quality = reader.ReadS32();
        bool m_UpdateWhenOffscreen = reader.ReadBool();
        bool m_SkinnedMotionVectors = reader.ReadBool();
        PPtr<Mesh> m_Mesh = PPtr<Mesh>.Read(reader);
        PPtr<Transform>[] m_Bones = Array<PPtr<Transform>>.Read(reader);
        float[] m_BlendShapeWeights = Array<float>.Read(reader);
        PPtr<Transform> m_RootBone = PPtr<Transform>.Read(reader);
        AABB m_AABB = AABB.Read(reader);
        bool m_DirtyAABB = reader.ReadBool();
        
        return new(m_GameObject,
            m_Enabled,
            m_CastShadows,
            m_ReceiveShadows,
            m_DynamicOccludee,
            m_StaticShadowCaster,
            m_MotionVectors,
            m_LightProbeUsage,
            m_ReflectionProbeUsage,
            m_RayTracingMode,
            m_RayTraceProcedural,
            m_RenderingLayerMask,
            m_RendererPriority,
            m_LightmapIndex,
            m_LightmapIndexDynamic,
            m_LightmapTilingOffset,
            m_LightmapTilingOffsetDynamic,
            m_Materials,
            m_StaticBatchInfo,
            m_StaticBatchRoot,
            m_ProbeAnchor,
            m_LightProbeVolumeOverride,
            m_SortingLayerID,
            m_SortingLayer,
            m_SortingOrder,
            m_Quality,
            m_UpdateWhenOffscreen,
            m_SkinnedMotionVectors,
            m_Mesh,
            m_Bones,
            m_BlendShapeWeights,
            m_RootBone,
            m_AABB,
            m_DirtyAABB);
    }
}


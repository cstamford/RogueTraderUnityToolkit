namespace RogueTraderUnityToolkit.UnityStructures.Generated.Engine;

using Core;
using Unity.BuiltInTypes;

/* $LineRenderer (31 fields) (IsEngineType) */
public record class LineRenderer(
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
    Vector3f[] m_Positions,
    LineParameters m_Parameters,
    int m_MaskInteraction,
    bool m_UseWorldSpace,
    bool m_Loop,
    bool m_ApplyActiveColorSpace)
{
    public static LineRenderer Read(EndianBinaryReader reader)
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
        Vector3f[] m_Positions = Array<Vector3f>.Read(reader);
        LineParameters m_Parameters = LineParameters.Read(reader);
        int m_MaskInteraction = reader.ReadS32();
        bool m_UseWorldSpace = reader.ReadBool();
        bool m_Loop = reader.ReadBool();
        bool m_ApplyActiveColorSpace = reader.ReadBool();
        
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
            m_Positions,
            m_Parameters,
            m_MaskInteraction,
            m_UseWorldSpace,
            m_Loop,
            m_ApplyActiveColorSpace);
    }
}


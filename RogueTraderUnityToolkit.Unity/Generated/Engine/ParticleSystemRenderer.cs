namespace RogueTraderUnityToolkit.Unity.Generated.Engine;

using Core;

/* $ParticleSystemRenderer (55 fields) (IsEngineType) */
public record class ParticleSystemRenderer(
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
    bool m_UseCustomVertexStreams,
    bool m_EnableGPUInstancing,
    bool m_ApplyActiveColorSpace,
    bool m_AllowRoll,
    bool m_FreeformStretching,
    bool m_RotateWithStretchDirection,
    byte[] m_VertexStreams,
    PPtr<Mesh> m_Mesh,
    PPtr<Mesh> m_Mesh1,
    PPtr<Mesh> m_Mesh2,
    PPtr<Mesh> m_Mesh3,
    float m_MeshWeighting,
    float m_MeshWeighting1,
    float m_MeshWeighting2,
    float m_MeshWeighting3,
    int m_MaskInteraction)
{
    public static ParticleSystemRenderer Read(EndianBinaryReader reader)
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
        ushort m_RenderMode = reader.ReadU16();
        byte m_MeshDistribution = reader.ReadU8();
        byte m_SortMode = reader.ReadU8();
        float m_MinParticleSize = reader.ReadF32();
        float m_MaxParticleSize = reader.ReadF32();
        float m_CameraVelocityScale = reader.ReadF32();
        float m_VelocityScale = reader.ReadF32();
        float m_LengthScale = reader.ReadF32();
        float m_SortingFudge = reader.ReadF32();
        float m_NormalDirection = reader.ReadF32();
        float m_ShadowBias = reader.ReadF32();
        int m_RenderAlignment = reader.ReadS32();
        Vector3f m_Pivot = Vector3f.Read(reader);
        Vector3f m_Flip = Vector3f.Read(reader);
        bool m_UseCustomVertexStreams = reader.ReadBool();
        bool m_EnableGPUInstancing = reader.ReadBool();
        bool m_ApplyActiveColorSpace = reader.ReadBool();
        bool m_AllowRoll = reader.ReadBool();
        bool m_FreeformStretching = reader.ReadBool();
        bool m_RotateWithStretchDirection = reader.ReadBool();
        byte[] m_VertexStreams = Array<byte>.Read(reader);
        PPtr<Mesh> m_Mesh = PPtr<Mesh>.Read(reader);
        PPtr<Mesh> m_Mesh1 = PPtr<Mesh>.Read(reader);
        PPtr<Mesh> m_Mesh2 = PPtr<Mesh>.Read(reader);
        PPtr<Mesh> m_Mesh3 = PPtr<Mesh>.Read(reader);
        float m_MeshWeighting = reader.ReadF32();
        float m_MeshWeighting1 = reader.ReadF32();
        float m_MeshWeighting2 = reader.ReadF32();
        float m_MeshWeighting3 = reader.ReadF32();
        int m_MaskInteraction = reader.ReadS32();
        
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
            m_RenderMode,
            m_MeshDistribution,
            m_SortMode,
            m_MinParticleSize,
            m_MaxParticleSize,
            m_CameraVelocityScale,
            m_VelocityScale,
            m_LengthScale,
            m_SortingFudge,
            m_NormalDirection,
            m_ShadowBias,
            m_RenderAlignment,
            m_Pivot,
            m_Flip,
            m_UseCustomVertexStreams,
            m_EnableGPUInstancing,
            m_ApplyActiveColorSpace,
            m_AllowRoll,
            m_FreeformStretching,
            m_RotateWithStretchDirection,
            m_VertexStreams,
            m_Mesh,
            m_Mesh1,
            m_Mesh2,
            m_Mesh3,
            m_MeshWeighting,
            m_MeshWeighting1,
            m_MeshWeighting2,
            m_MeshWeighting3,
            m_MaskInteraction);
    }
}


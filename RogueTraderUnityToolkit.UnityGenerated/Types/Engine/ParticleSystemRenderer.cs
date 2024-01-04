namespace RogueTraderUnityToolkit.UnityGenerated.Types.Engine;

using Core;
using Unity;

/* $ParticleSystemRenderer (55 fields) BD86D2D2ED9B6B6865ECFCD70C8C364F */
public record class ParticleSystemRenderer(
    PPtr<GameObject> m_GameObject /* None */,
    bool m_Enabled /* None */,
    byte m_CastShadows /* None */,
    byte m_ReceiveShadows /* None */,
    byte m_DynamicOccludee /* None */,
    byte m_StaticShadowCaster /* None */,
    byte m_MotionVectors /* None */,
    byte m_LightProbeUsage /* None */,
    byte m_ReflectionProbeUsage /* None */,
    byte m_RayTracingMode /* None */,
    byte m_RayTraceProcedural /* None */,
    uint m_RenderingLayerMask /* NeedsAlign */,
    int m_RendererPriority /* None */,
    ushort m_LightmapIndex /* None */,
    ushort m_LightmapIndexDynamic /* None */,
    Vector4f m_LightmapTilingOffset /* None */,
    Vector4f m_LightmapTilingOffsetDynamic /* None */,
    PPtr<Material>[] m_Materials /* None */,
    StaticBatchInfo m_StaticBatchInfo /* NeedsAlign */,
    PPtr<Transform> m_StaticBatchRoot /* None */,
    PPtr<Transform> m_ProbeAnchor /* None */,
    PPtr<GameObject> m_LightProbeVolumeOverride /* None */,
    int m_SortingLayerID /* NeedsAlign */,
    short m_SortingLayer /* None */,
    short m_SortingOrder /* None */,
    ushort m_RenderMode /* NeedsAlign */,
    byte m_MeshDistribution /* None */,
    byte m_SortMode /* None */,
    float m_MinParticleSize /* None */,
    float m_MaxParticleSize /* None */,
    float m_CameraVelocityScale /* None */,
    float m_VelocityScale /* None */,
    float m_LengthScale /* None */,
    float m_SortingFudge /* None */,
    float m_NormalDirection /* None */,
    float m_ShadowBias /* None */,
    int m_RenderAlignment /* None */,
    Vector3f m_Pivot /* None */,
    Vector3f m_Flip /* None */,
    bool m_UseCustomVertexStreams /* None */,
    bool m_EnableGPUInstancing /* None */,
    bool m_ApplyActiveColorSpace /* None */,
    bool m_AllowRoll /* None */,
    bool m_FreeformStretching /* None */,
    bool m_RotateWithStretchDirection /* None */,
    byte[] m_VertexStreams /* NeedsAlign */,
    PPtr<Mesh> m_Mesh /* NeedsAlign */,
    PPtr<Mesh> m_Mesh1 /* None */,
    PPtr<Mesh> m_Mesh2 /* None */,
    PPtr<Mesh> m_Mesh3 /* None */,
    float m_MeshWeighting /* None */,
    float m_MeshWeighting1 /* None */,
    float m_MeshWeighting2 /* None */,
    float m_MeshWeighting3 /* None */,
    int m_MaskInteraction /* None */) : IUnityObject
{
    public static Hash128 Hash => new(3179729618, 3986385768, 1710030039, 210515535);
    public static ParticleSystemRenderer Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        bool _m_Enabled = reader.ReadBool();
        byte _m_CastShadows = reader.ReadU8();
        byte _m_ReceiveShadows = reader.ReadU8();
        byte _m_DynamicOccludee = reader.ReadU8();
        byte _m_StaticShadowCaster = reader.ReadU8();
        byte _m_MotionVectors = reader.ReadU8();
        byte _m_LightProbeUsage = reader.ReadU8();
        byte _m_ReflectionProbeUsage = reader.ReadU8();
        byte _m_RayTracingMode = reader.ReadU8();
        byte _m_RayTraceProcedural = reader.ReadU8();
        reader.AlignTo(4); /* m_RenderingLayerMask */
        uint _m_RenderingLayerMask = reader.ReadU32();
        int _m_RendererPriority = reader.ReadS32();
        ushort _m_LightmapIndex = reader.ReadU16();
        ushort _m_LightmapIndexDynamic = reader.ReadU16();
        Vector4f _m_LightmapTilingOffset = Vector4f.Read(reader);
        Vector4f _m_LightmapTilingOffsetDynamic = Vector4f.Read(reader);
        PPtr<Material>[] _m_Materials = BuiltInArray<PPtr<Material>>.Read(reader);
        reader.AlignTo(4); /* m_StaticBatchInfo */
        StaticBatchInfo _m_StaticBatchInfo = StaticBatchInfo.Read(reader);
        PPtr<Transform> _m_StaticBatchRoot = PPtr<Transform>.Read(reader);
        PPtr<Transform> _m_ProbeAnchor = PPtr<Transform>.Read(reader);
        PPtr<GameObject> _m_LightProbeVolumeOverride = PPtr<GameObject>.Read(reader);
        reader.AlignTo(4); /* m_SortingLayerID */
        int _m_SortingLayerID = reader.ReadS32();
        short _m_SortingLayer = reader.ReadS16();
        short _m_SortingOrder = reader.ReadS16();
        reader.AlignTo(4); /* m_RenderMode */
        ushort _m_RenderMode = reader.ReadU16();
        byte _m_MeshDistribution = reader.ReadU8();
        byte _m_SortMode = reader.ReadU8();
        float _m_MinParticleSize = reader.ReadF32();
        float _m_MaxParticleSize = reader.ReadF32();
        float _m_CameraVelocityScale = reader.ReadF32();
        float _m_VelocityScale = reader.ReadF32();
        float _m_LengthScale = reader.ReadF32();
        float _m_SortingFudge = reader.ReadF32();
        float _m_NormalDirection = reader.ReadF32();
        float _m_ShadowBias = reader.ReadF32();
        int _m_RenderAlignment = reader.ReadS32();
        Vector3f _m_Pivot = Vector3f.Read(reader);
        Vector3f _m_Flip = Vector3f.Read(reader);
        bool _m_UseCustomVertexStreams = reader.ReadBool();
        bool _m_EnableGPUInstancing = reader.ReadBool();
        bool _m_ApplyActiveColorSpace = reader.ReadBool();
        bool _m_AllowRoll = reader.ReadBool();
        bool _m_FreeformStretching = reader.ReadBool();
        bool _m_RotateWithStretchDirection = reader.ReadBool();
        reader.AlignTo(4); /* m_VertexStreams */
        byte[] _m_VertexStreams = BuiltInArray<byte>.Read(reader);
        reader.AlignTo(4); /* m_Mesh */
        PPtr<Mesh> _m_Mesh = PPtr<Mesh>.Read(reader);
        PPtr<Mesh> _m_Mesh1 = PPtr<Mesh>.Read(reader);
        PPtr<Mesh> _m_Mesh2 = PPtr<Mesh>.Read(reader);
        PPtr<Mesh> _m_Mesh3 = PPtr<Mesh>.Read(reader);
        float _m_MeshWeighting = reader.ReadF32();
        float _m_MeshWeighting1 = reader.ReadF32();
        float _m_MeshWeighting2 = reader.ReadF32();
        float _m_MeshWeighting3 = reader.ReadF32();
        int _m_MaskInteraction = reader.ReadS32();
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_CastShadows,
            _m_ReceiveShadows,
            _m_DynamicOccludee,
            _m_StaticShadowCaster,
            _m_MotionVectors,
            _m_LightProbeUsage,
            _m_ReflectionProbeUsage,
            _m_RayTracingMode,
            _m_RayTraceProcedural,
            _m_RenderingLayerMask,
            _m_RendererPriority,
            _m_LightmapIndex,
            _m_LightmapIndexDynamic,
            _m_LightmapTilingOffset,
            _m_LightmapTilingOffsetDynamic,
            _m_Materials,
            _m_StaticBatchInfo,
            _m_StaticBatchRoot,
            _m_ProbeAnchor,
            _m_LightProbeVolumeOverride,
            _m_SortingLayerID,
            _m_SortingLayer,
            _m_SortingOrder,
            _m_RenderMode,
            _m_MeshDistribution,
            _m_SortMode,
            _m_MinParticleSize,
            _m_MaxParticleSize,
            _m_CameraVelocityScale,
            _m_VelocityScale,
            _m_LengthScale,
            _m_SortingFudge,
            _m_NormalDirection,
            _m_ShadowBias,
            _m_RenderAlignment,
            _m_Pivot,
            _m_Flip,
            _m_UseCustomVertexStreams,
            _m_EnableGPUInstancing,
            _m_ApplyActiveColorSpace,
            _m_AllowRoll,
            _m_FreeformStretching,
            _m_RotateWithStretchDirection,
            _m_VertexStreams,
            _m_Mesh,
            _m_Mesh1,
            _m_Mesh2,
            _m_Mesh3,
            _m_MeshWeighting,
            _m_MeshWeighting1,
            _m_MeshWeighting2,
            _m_MeshWeighting3,
            _m_MaskInteraction);
    }
}


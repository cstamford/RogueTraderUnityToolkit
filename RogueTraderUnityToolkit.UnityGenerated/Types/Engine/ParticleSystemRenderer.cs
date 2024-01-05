namespace RogueTraderUnityToolkit.UnityGenerated.Types.Engine;

using Core;
using System.Text;
using Unity;

/* $ParticleSystemRenderer (55 fields) BD86D2D2ED9B6B6865ECFCD70C8C364F */
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
    int m_MaskInteraction) : IUnityEngineStructure
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
        reader.AlignTo(4); /* m_RayTraceProcedural */
        uint _m_RenderingLayerMask = reader.ReadU32();
        int _m_RendererPriority = reader.ReadS32();
        ushort _m_LightmapIndex = reader.ReadU16();
        ushort _m_LightmapIndexDynamic = reader.ReadU16();
        Vector4f _m_LightmapTilingOffset = Vector4f.Read(reader);
        Vector4f _m_LightmapTilingOffsetDynamic = Vector4f.Read(reader);
        PPtr<Material>[] _m_Materials = BuiltInArray<PPtr<Material>>.Read(reader);
        reader.AlignTo(4); /* m_Materials */
        StaticBatchInfo _m_StaticBatchInfo = StaticBatchInfo.Read(reader);
        PPtr<Transform> _m_StaticBatchRoot = PPtr<Transform>.Read(reader);
        PPtr<Transform> _m_ProbeAnchor = PPtr<Transform>.Read(reader);
        PPtr<GameObject> _m_LightProbeVolumeOverride = PPtr<GameObject>.Read(reader);
        reader.AlignTo(4); /* m_LightProbeVolumeOverride */
        int _m_SortingLayerID = reader.ReadS32();
        short _m_SortingLayer = reader.ReadS16();
        short _m_SortingOrder = reader.ReadS16();
        reader.AlignTo(4); /* m_SortingOrder */
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
        reader.AlignTo(4); /* m_RotateWithStretchDirection */
        byte[] _m_VertexStreams = BuiltInArray<byte>.Read(reader);
        reader.AlignTo(4); /* m_VertexStreams */
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

    public override string ToString() => $"ParticleSystemRenderer\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_GameObject: ");
        sb.AppendLine(m_GameObject.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Enabled: ");
        sb.AppendLine(m_Enabled.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_CastShadows: ");
        sb.AppendLine(m_CastShadows.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_ReceiveShadows: ");
        sb.AppendLine(m_ReceiveShadows.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_DynamicOccludee: ");
        sb.AppendLine(m_DynamicOccludee.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_StaticShadowCaster: ");
        sb.AppendLine(m_StaticShadowCaster.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_MotionVectors: ");
        sb.AppendLine(m_MotionVectors.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_LightProbeUsage: ");
        sb.AppendLine(m_LightProbeUsage.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_ReflectionProbeUsage: ");
        sb.AppendLine(m_ReflectionProbeUsage.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_RayTracingMode: ");
        sb.AppendLine(m_RayTracingMode.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_RayTraceProcedural: ");
        sb.AppendLine(m_RayTraceProcedural.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_RenderingLayerMask: ");
        sb.AppendLine(m_RenderingLayerMask.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_RendererPriority: ");
        sb.AppendLine(m_RendererPriority.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_LightmapIndex: ");
        sb.AppendLine(m_LightmapIndex.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_LightmapIndexDynamic: ");
        sb.AppendLine(m_LightmapIndexDynamic.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_LightmapTilingOffset: ");
        sb.AppendLine();
        sb.Append(m_LightmapTilingOffset.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_LightmapTilingOffsetDynamic: ");
        sb.AppendLine();
        sb.Append(m_LightmapTilingOffsetDynamic.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Materials: ");
        sb.AppendLine(m_Materials.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_StaticBatchInfo: ");
        sb.AppendLine();
        sb.Append(m_StaticBatchInfo.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_StaticBatchRoot: ");
        sb.AppendLine(m_StaticBatchRoot.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_ProbeAnchor: ");
        sb.AppendLine(m_ProbeAnchor.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_LightProbeVolumeOverride: ");
        sb.AppendLine(m_LightProbeVolumeOverride.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_SortingLayerID: ");
        sb.AppendLine(m_SortingLayerID.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_SortingLayer: ");
        sb.AppendLine(m_SortingLayer.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_SortingOrder: ");
        sb.AppendLine(m_SortingOrder.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_RenderMode: ");
        sb.AppendLine(m_RenderMode.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_MeshDistribution: ");
        sb.AppendLine(m_MeshDistribution.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_SortMode: ");
        sb.AppendLine(m_SortMode.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_MinParticleSize: ");
        sb.AppendLine(m_MinParticleSize.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_MaxParticleSize: ");
        sb.AppendLine(m_MaxParticleSize.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_CameraVelocityScale: ");
        sb.AppendLine(m_CameraVelocityScale.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_VelocityScale: ");
        sb.AppendLine(m_VelocityScale.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_LengthScale: ");
        sb.AppendLine(m_LengthScale.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_SortingFudge: ");
        sb.AppendLine(m_SortingFudge.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_NormalDirection: ");
        sb.AppendLine(m_NormalDirection.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_ShadowBias: ");
        sb.AppendLine(m_ShadowBias.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_RenderAlignment: ");
        sb.AppendLine(m_RenderAlignment.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Pivot: ");
        sb.AppendLine();
        sb.Append(m_Pivot.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Flip: ");
        sb.AppendLine();
        sb.Append(m_Flip.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_UseCustomVertexStreams: ");
        sb.AppendLine(m_UseCustomVertexStreams.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_EnableGPUInstancing: ");
        sb.AppendLine(m_EnableGPUInstancing.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_ApplyActiveColorSpace: ");
        sb.AppendLine(m_ApplyActiveColorSpace.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_AllowRoll: ");
        sb.AppendLine(m_AllowRoll.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_FreeformStretching: ");
        sb.AppendLine(m_FreeformStretching.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_RotateWithStretchDirection: ");
        sb.AppendLine(m_RotateWithStretchDirection.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_VertexStreams: ");
        sb.AppendLine(m_VertexStreams.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Mesh: ");
        sb.AppendLine(m_Mesh.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Mesh1: ");
        sb.AppendLine(m_Mesh1.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Mesh2: ");
        sb.AppendLine(m_Mesh2.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Mesh3: ");
        sb.AppendLine(m_Mesh3.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_MeshWeighting: ");
        sb.AppendLine(m_MeshWeighting.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_MeshWeighting1: ");
        sb.AppendLine(m_MeshWeighting1.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_MeshWeighting2: ");
        sb.AppendLine(m_MeshWeighting2.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_MeshWeighting3: ");
        sb.AppendLine(m_MeshWeighting3.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_MaskInteraction: ");
        sb.AppendLine(m_MaskInteraction.ToString());

        return sb.ToString();
    }
}


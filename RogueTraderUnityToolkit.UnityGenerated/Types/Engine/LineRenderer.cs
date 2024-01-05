namespace RogueTraderUnityToolkit.UnityGenerated.Types.Engine;

using Core;
using System.Text;
using Unity;

/* $LineRenderer (31 fields) A0B0FD92D7AD874BD18245CC455ED5DB */
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
    bool m_ApplyActiveColorSpace) : IUnityEngineStructure
{
    public static Hash128 Hash => new(2695953810, 3618473803, 3514975692, 1163843035);

    public static LineRenderer Read(EndianBinaryReader reader)
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
        Vector3f[] _m_Positions = BuiltInArray<Vector3f>.Read(reader);
        reader.AlignTo(4); /* m_Positions */
        LineParameters _m_Parameters = LineParameters.Read(reader);
        reader.AlignTo(4); /* m_Parameters */
        int _m_MaskInteraction = reader.ReadS32();
        bool _m_UseWorldSpace = reader.ReadBool();
        bool _m_Loop = reader.ReadBool();
        bool _m_ApplyActiveColorSpace = reader.ReadBool();
        
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
            _m_Positions,
            _m_Parameters,
            _m_MaskInteraction,
            _m_UseWorldSpace,
            _m_Loop,
            _m_ApplyActiveColorSpace);
    }

    public override string ToString() => $"LineRenderer\n{ToString(4)}";

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
        sb.Append("m_Positions: ");
        sb.AppendLine(m_Positions.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Parameters: ");
        sb.AppendLine();
        sb.Append(m_Parameters.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_MaskInteraction: ");
        sb.AppendLine(m_MaskInteraction.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_UseWorldSpace: ");
        sb.AppendLine(m_UseWorldSpace.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Loop: ");
        sb.AppendLine(m_Loop.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_ApplyActiveColorSpace: ");
        sb.AppendLine(m_ApplyActiveColorSpace.ToString());

        return sb.ToString();
    }
}


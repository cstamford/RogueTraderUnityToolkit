namespace RogueTraderUnityToolkit.UnityGenerated.Types.Engine;

using Core;
using System.Text;
using Unity;

/* $MeshRenderer (27 fields) BB8F7BE0F9B8E7E1091FDF53AA6D624E */
public record class MeshRenderer(
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
    PPtr<Mesh> m_AdditionalVertexStreams,
    PPtr<Mesh> m_EnlightenVertexStream) : IUnityEngineStructure
{
    public static Hash128 Hash => new(3146742752, 4189644769, 153083731, 2859295310);

    public static MeshRenderer Read(EndianBinaryReader reader)
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
        PPtr<Mesh> _m_AdditionalVertexStreams = PPtr<Mesh>.Read(reader);
        PPtr<Mesh> _m_EnlightenVertexStream = PPtr<Mesh>.Read(reader);
        
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
            _m_AdditionalVertexStreams,
            _m_EnlightenVertexStream);
    }

    public override string ToString() => $"MeshRenderer\n{ToString(4)}";

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
        sb.Append("m_AdditionalVertexStreams: ");
        sb.AppendLine(m_AdditionalVertexStreams.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_EnlightenVertexStream: ");
        sb.AppendLine(m_EnlightenVertexStream.ToString());

        return sb.ToString();
    }
}


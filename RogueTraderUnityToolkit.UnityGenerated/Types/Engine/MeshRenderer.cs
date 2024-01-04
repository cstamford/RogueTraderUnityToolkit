namespace RogueTraderUnityToolkit.UnityGenerated.Types.Engine;

using Core;
using Unity;

/* $MeshRenderer (27 fields) BB8F7BE0F9B8E7E1091FDF53AA6D624E */
public record class MeshRenderer(
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
    PPtr<Mesh> m_AdditionalVertexStreams /* NeedsAlign */,
    PPtr<Mesh> m_EnlightenVertexStream /* None */) : IUnityObject
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
        reader.AlignTo(4); /* m_AdditionalVertexStreams */
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
}


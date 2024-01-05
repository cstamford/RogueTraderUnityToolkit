namespace RogueTraderUnityToolkit.UnityGenerated.Types.Engine;

using Core;
using System.Text;
using Unity;

/* $SpriteRenderer (36 fields) E497D5B25AAC382993CBD87ED14CB37E */
public record class SpriteRenderer(
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
    PPtr<Sprite> m_Sprite,
    ColorRGBA_0 m_Color,
    bool m_FlipX,
    bool m_FlipY,
    int m_DrawMode,
    Vector2f m_Size,
    float m_AdaptiveModeThreshold,
    int m_SpriteTileMode,
    bool m_WasSpriteAssigned,
    int m_MaskInteraction,
    int m_SpriteSortPoint) : IUnityEngineStructure
{
    public static Hash128 Hash => new(3835155890, 1521236009, 2479609982, 3511464830);

    public static SpriteRenderer Read(EndianBinaryReader reader)
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
        PPtr<Sprite> _m_Sprite = PPtr<Sprite>.Read(reader);
        ColorRGBA_0 _m_Color = ColorRGBA_0.Read(reader);
        reader.AlignTo(4); /* m_Color */
        bool _m_FlipX = reader.ReadBool();
        bool _m_FlipY = reader.ReadBool();
        reader.AlignTo(4); /* m_FlipY */
        int _m_DrawMode = reader.ReadS32();
        Vector2f _m_Size = Vector2f.Read(reader);
        float _m_AdaptiveModeThreshold = reader.ReadF32();
        int _m_SpriteTileMode = reader.ReadS32();
        bool _m_WasSpriteAssigned = reader.ReadBool();
        reader.AlignTo(4); /* m_WasSpriteAssigned */
        int _m_MaskInteraction = reader.ReadS32();
        int _m_SpriteSortPoint = reader.ReadS32();
        
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
            _m_Sprite,
            _m_Color,
            _m_FlipX,
            _m_FlipY,
            _m_DrawMode,
            _m_Size,
            _m_AdaptiveModeThreshold,
            _m_SpriteTileMode,
            _m_WasSpriteAssigned,
            _m_MaskInteraction,
            _m_SpriteSortPoint);
    }

    public override string ToString() => $"SpriteRenderer\n{ToString(4)}";

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
        sb.Append("m_Sprite: ");
        sb.AppendLine(m_Sprite.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Color: ");
        sb.AppendLine();
        sb.Append(m_Color.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_FlipX: ");
        sb.AppendLine(m_FlipX.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_FlipY: ");
        sb.AppendLine(m_FlipY.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_DrawMode: ");
        sb.AppendLine(m_DrawMode.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Size: ");
        sb.AppendLine();
        sb.Append(m_Size.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_AdaptiveModeThreshold: ");
        sb.AppendLine(m_AdaptiveModeThreshold.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_SpriteTileMode: ");
        sb.AppendLine(m_SpriteTileMode.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_WasSpriteAssigned: ");
        sb.AppendLine(m_WasSpriteAssigned.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_MaskInteraction: ");
        sb.AppendLine(m_MaskInteraction.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_SpriteSortPoint: ");
        sb.AppendLine(m_SpriteSortPoint.ToString());

        return sb.ToString();
    }
}


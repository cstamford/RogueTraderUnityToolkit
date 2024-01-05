namespace RogueTraderUnityToolkit.UnityGenerated.Types.Engine;

using Core;
using System.Text;
using Unity;

/* $SkinnedMeshRenderer (34 fields) 8AC1773BE8BCA8C0DB0398B67F6BF972 */
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
    bool m_DirtyAABB) : IUnityEngineStructure
{
    public static Hash128 Hash => new(2327934779, 3904678080, 3674446006, 2137782642);

    public static SkinnedMeshRenderer Read(EndianBinaryReader reader)
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
        int _m_Quality = reader.ReadS32();
        bool _m_UpdateWhenOffscreen = reader.ReadBool();
        bool _m_SkinnedMotionVectors = reader.ReadBool();
        reader.AlignTo(4); /* m_SkinnedMotionVectors */
        PPtr<Mesh> _m_Mesh = PPtr<Mesh>.Read(reader);
        PPtr<Transform>[] _m_Bones = BuiltInArray<PPtr<Transform>>.Read(reader);
        reader.AlignTo(4); /* m_Bones */
        float[] _m_BlendShapeWeights = BuiltInArray<float>.Read(reader);
        reader.AlignTo(4); /* m_BlendShapeWeights */
        PPtr<Transform> _m_RootBone = PPtr<Transform>.Read(reader);
        AABB _m_AABB = AABB.Read(reader);
        bool _m_DirtyAABB = reader.ReadBool();
        reader.AlignTo(4); /* m_DirtyAABB */
        
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
            _m_Quality,
            _m_UpdateWhenOffscreen,
            _m_SkinnedMotionVectors,
            _m_Mesh,
            _m_Bones,
            _m_BlendShapeWeights,
            _m_RootBone,
            _m_AABB,
            _m_DirtyAABB);
    }

    public override string ToString() => $"SkinnedMeshRenderer\n{ToString(4)}";

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
        sb.Append("m_Quality: ");
        sb.AppendLine(m_Quality.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_UpdateWhenOffscreen: ");
        sb.AppendLine(m_UpdateWhenOffscreen.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_SkinnedMotionVectors: ");
        sb.AppendLine(m_SkinnedMotionVectors.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Mesh: ");
        sb.AppendLine(m_Mesh.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Bones: ");
        sb.AppendLine(m_Bones.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_BlendShapeWeights: ");
        sb.AppendLine(m_BlendShapeWeights.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_RootBone: ");
        sb.AppendLine(m_RootBone.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_AABB: ");
        sb.AppendLine();
        sb.Append(m_AABB.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_DirtyAABB: ");
        sb.AppendLine(m_DirtyAABB.ToString());

        return sb.ToString();
    }
}


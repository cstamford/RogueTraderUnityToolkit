namespace RogueTraderUnityToolkit.UnityGenerated.Types.Engine;

using Core;
using System.Text;
using Unity;

/* $Terrain (35 fields) 913BC14CC1927ED00BCD8F7304EBFB4F */
public record class Terrain(
    PPtr<GameObject> m_GameObject,
    byte m_Enabled,
    PPtr<TerrainData> m_TerrainData,
    float m_TreeDistance,
    float m_TreeBillboardDistance,
    float m_TreeCrossFadeLength,
    int m_TreeMaximumFullLODCount,
    float m_DetailObjectDistance,
    float m_DetailObjectDensity,
    float m_HeightmapPixelError,
    float m_SplatMapDistance,
    int m_HeightmapMaximumLOD,
    int m_ShadowCastingMode,
    bool m_DrawHeightmap,
    bool m_DrawInstanced,
    bool m_DrawTreesAndFoliage,
    bool m_StaticShadowCaster,
    bool m_IgnoreQualitySettings,
    int m_ReflectionProbeUsage,
    PPtr<Material> m_MaterialTemplate,
    ushort m_LightmapIndex,
    ushort m_LightmapIndexDynamic,
    Vector4f m_LightmapTilingOffset,
    Vector4f m_LightmapTilingOffsetDynamic,
    Hash128 m_ExplicitProbeSetHash,
    bool m_BakeLightProbesForTrees,
    bool m_PreserveTreePrototypeLayers,
    Vector4f m_DynamicUVST,
    Vector4f m_ChunkDynamicUVST,
    int m_GroupingID,
    uint m_RenderingLayerMask,
    bool m_AllowAutoConnect,
    bool m_EnableHeightmapRayTracing,
    bool m_EnableTreesAndDetailsRayTracing,
    int m_TreeMotionVectorModeOverride) : IUnityEngineStructure
{
    public static Hash128 Hash => new(2436612428, 3247603408, 198020979, 82574159);

    public static Terrain Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Enabled */
        PPtr<TerrainData> _m_TerrainData = PPtr<TerrainData>.Read(reader);
        float _m_TreeDistance = reader.ReadF32();
        float _m_TreeBillboardDistance = reader.ReadF32();
        float _m_TreeCrossFadeLength = reader.ReadF32();
        int _m_TreeMaximumFullLODCount = reader.ReadS32();
        float _m_DetailObjectDistance = reader.ReadF32();
        float _m_DetailObjectDensity = reader.ReadF32();
        float _m_HeightmapPixelError = reader.ReadF32();
        float _m_SplatMapDistance = reader.ReadF32();
        int _m_HeightmapMaximumLOD = reader.ReadS32();
        int _m_ShadowCastingMode = reader.ReadS32();
        bool _m_DrawHeightmap = reader.ReadBool();
        bool _m_DrawInstanced = reader.ReadBool();
        bool _m_DrawTreesAndFoliage = reader.ReadBool();
        bool _m_StaticShadowCaster = reader.ReadBool();
        reader.AlignTo(4); /* m_StaticShadowCaster */
        bool _m_IgnoreQualitySettings = reader.ReadBool();
        reader.AlignTo(4); /* m_IgnoreQualitySettings */
        int _m_ReflectionProbeUsage = reader.ReadS32();
        PPtr<Material> _m_MaterialTemplate = PPtr<Material>.Read(reader);
        ushort _m_LightmapIndex = reader.ReadU16();
        ushort _m_LightmapIndexDynamic = reader.ReadU16();
        Vector4f _m_LightmapTilingOffset = Vector4f.Read(reader);
        Vector4f _m_LightmapTilingOffsetDynamic = Vector4f.Read(reader);
        Hash128 _m_ExplicitProbeSetHash = Hash128.Read(reader);
        bool _m_BakeLightProbesForTrees = reader.ReadBool();
        bool _m_PreserveTreePrototypeLayers = reader.ReadBool();
        reader.AlignTo(4); /* m_PreserveTreePrototypeLayers */
        Vector4f _m_DynamicUVST = Vector4f.Read(reader);
        Vector4f _m_ChunkDynamicUVST = Vector4f.Read(reader);
        reader.AlignTo(4); /* m_ChunkDynamicUVST */
        int _m_GroupingID = reader.ReadS32();
        uint _m_RenderingLayerMask = reader.ReadU32();
        bool _m_AllowAutoConnect = reader.ReadBool();
        bool _m_EnableHeightmapRayTracing = reader.ReadBool();
        bool _m_EnableTreesAndDetailsRayTracing = reader.ReadBool();
        reader.AlignTo(4); /* m_EnableTreesAndDetailsRayTracing */
        int _m_TreeMotionVectorModeOverride = reader.ReadS32();
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_TerrainData,
            _m_TreeDistance,
            _m_TreeBillboardDistance,
            _m_TreeCrossFadeLength,
            _m_TreeMaximumFullLODCount,
            _m_DetailObjectDistance,
            _m_DetailObjectDensity,
            _m_HeightmapPixelError,
            _m_SplatMapDistance,
            _m_HeightmapMaximumLOD,
            _m_ShadowCastingMode,
            _m_DrawHeightmap,
            _m_DrawInstanced,
            _m_DrawTreesAndFoliage,
            _m_StaticShadowCaster,
            _m_IgnoreQualitySettings,
            _m_ReflectionProbeUsage,
            _m_MaterialTemplate,
            _m_LightmapIndex,
            _m_LightmapIndexDynamic,
            _m_LightmapTilingOffset,
            _m_LightmapTilingOffsetDynamic,
            _m_ExplicitProbeSetHash,
            _m_BakeLightProbesForTrees,
            _m_PreserveTreePrototypeLayers,
            _m_DynamicUVST,
            _m_ChunkDynamicUVST,
            _m_GroupingID,
            _m_RenderingLayerMask,
            _m_AllowAutoConnect,
            _m_EnableHeightmapRayTracing,
            _m_EnableTreesAndDetailsRayTracing,
            _m_TreeMotionVectorModeOverride);
    }

    public override string ToString() => $"Terrain\n{ToString(4)}";

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
        sb.Append("m_TerrainData: ");
        sb.AppendLine(m_TerrainData.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_TreeDistance: ");
        sb.AppendLine(m_TreeDistance.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_TreeBillboardDistance: ");
        sb.AppendLine(m_TreeBillboardDistance.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_TreeCrossFadeLength: ");
        sb.AppendLine(m_TreeCrossFadeLength.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_TreeMaximumFullLODCount: ");
        sb.AppendLine(m_TreeMaximumFullLODCount.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_DetailObjectDistance: ");
        sb.AppendLine(m_DetailObjectDistance.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_DetailObjectDensity: ");
        sb.AppendLine(m_DetailObjectDensity.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_HeightmapPixelError: ");
        sb.AppendLine(m_HeightmapPixelError.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_SplatMapDistance: ");
        sb.AppendLine(m_SplatMapDistance.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_HeightmapMaximumLOD: ");
        sb.AppendLine(m_HeightmapMaximumLOD.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_ShadowCastingMode: ");
        sb.AppendLine(m_ShadowCastingMode.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_DrawHeightmap: ");
        sb.AppendLine(m_DrawHeightmap.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_DrawInstanced: ");
        sb.AppendLine(m_DrawInstanced.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_DrawTreesAndFoliage: ");
        sb.AppendLine(m_DrawTreesAndFoliage.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_StaticShadowCaster: ");
        sb.AppendLine(m_StaticShadowCaster.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_IgnoreQualitySettings: ");
        sb.AppendLine(m_IgnoreQualitySettings.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_ReflectionProbeUsage: ");
        sb.AppendLine(m_ReflectionProbeUsage.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_MaterialTemplate: ");
        sb.AppendLine(m_MaterialTemplate.ToString());

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
        sb.Append("m_ExplicitProbeSetHash: ");
        sb.AppendLine(m_ExplicitProbeSetHash.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_BakeLightProbesForTrees: ");
        sb.AppendLine(m_BakeLightProbesForTrees.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_PreserveTreePrototypeLayers: ");
        sb.AppendLine(m_PreserveTreePrototypeLayers.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_DynamicUVST: ");
        sb.AppendLine();
        sb.Append(m_DynamicUVST.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_ChunkDynamicUVST: ");
        sb.AppendLine();
        sb.Append(m_ChunkDynamicUVST.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_GroupingID: ");
        sb.AppendLine(m_GroupingID.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_RenderingLayerMask: ");
        sb.AppendLine(m_RenderingLayerMask.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_AllowAutoConnect: ");
        sb.AppendLine(m_AllowAutoConnect.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_EnableHeightmapRayTracing: ");
        sb.AppendLine(m_EnableHeightmapRayTracing.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_EnableTreesAndDetailsRayTracing: ");
        sb.AppendLine(m_EnableTreesAndDetailsRayTracing.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_TreeMotionVectorModeOverride: ");
        sb.AppendLine(m_TreeMotionVectorModeOverride.ToString());

        return sb.ToString();
    }
}


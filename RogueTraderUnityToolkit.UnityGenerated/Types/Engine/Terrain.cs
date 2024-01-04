namespace RogueTraderUnityToolkit.UnityGenerated.Types.Engine;

using Core;
using Unity;

/* $Terrain (35 fields) 913BC14CC1927ED00BCD8F7304EBFB4F */
public record class Terrain(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<TerrainData> m_TerrainData /* NeedsAlign */,
    float m_TreeDistance /* None */,
    float m_TreeBillboardDistance /* None */,
    float m_TreeCrossFadeLength /* None */,
    int m_TreeMaximumFullLODCount /* None */,
    float m_DetailObjectDistance /* None */,
    float m_DetailObjectDensity /* None */,
    float m_HeightmapPixelError /* None */,
    float m_SplatMapDistance /* None */,
    int m_HeightmapMaximumLOD /* None */,
    int m_ShadowCastingMode /* None */,
    bool m_DrawHeightmap /* None */,
    bool m_DrawInstanced /* None */,
    bool m_DrawTreesAndFoliage /* None */,
    bool m_StaticShadowCaster /* None */,
    bool m_IgnoreQualitySettings /* NeedsAlign */,
    int m_ReflectionProbeUsage /* NeedsAlign */,
    PPtr<Material> m_MaterialTemplate /* None */,
    ushort m_LightmapIndex /* None */,
    ushort m_LightmapIndexDynamic /* None */,
    Vector4f m_LightmapTilingOffset /* None */,
    Vector4f m_LightmapTilingOffsetDynamic /* None */,
    Hash128 m_ExplicitProbeSetHash /* None */,
    bool m_BakeLightProbesForTrees /* None */,
    bool m_PreserveTreePrototypeLayers /* None */,
    Vector4f m_DynamicUVST /* NeedsAlign */,
    Vector4f m_ChunkDynamicUVST /* None */,
    int m_GroupingID /* NeedsAlign */,
    uint m_RenderingLayerMask /* None */,
    bool m_AllowAutoConnect /* None */,
    bool m_EnableHeightmapRayTracing /* None */,
    bool m_EnableTreesAndDetailsRayTracing /* None */,
    int m_TreeMotionVectorModeOverride /* NeedsAlign */) : IUnityObject
{
    public static Hash128 Hash => new(2436612428, 3247603408, 198020979, 82574159);
    public static Terrain Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_TerrainData */
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
        reader.AlignTo(4); /* m_IgnoreQualitySettings */
        bool _m_IgnoreQualitySettings = reader.ReadBool();
        reader.AlignTo(4); /* m_ReflectionProbeUsage */
        int _m_ReflectionProbeUsage = reader.ReadS32();
        PPtr<Material> _m_MaterialTemplate = PPtr<Material>.Read(reader);
        ushort _m_LightmapIndex = reader.ReadU16();
        ushort _m_LightmapIndexDynamic = reader.ReadU16();
        Vector4f _m_LightmapTilingOffset = Vector4f.Read(reader);
        Vector4f _m_LightmapTilingOffsetDynamic = Vector4f.Read(reader);
        Hash128 _m_ExplicitProbeSetHash = Hash128.Read(reader);
        bool _m_BakeLightProbesForTrees = reader.ReadBool();
        bool _m_PreserveTreePrototypeLayers = reader.ReadBool();
        reader.AlignTo(4); /* m_DynamicUVST */
        Vector4f _m_DynamicUVST = Vector4f.Read(reader);
        Vector4f _m_ChunkDynamicUVST = Vector4f.Read(reader);
        reader.AlignTo(4); /* m_GroupingID */
        int _m_GroupingID = reader.ReadS32();
        uint _m_RenderingLayerMask = reader.ReadU32();
        bool _m_AllowAutoConnect = reader.ReadBool();
        bool _m_EnableHeightmapRayTracing = reader.ReadBool();
        bool _m_EnableTreesAndDetailsRayTracing = reader.ReadBool();
        reader.AlignTo(4); /* m_TreeMotionVectorModeOverride */
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
}


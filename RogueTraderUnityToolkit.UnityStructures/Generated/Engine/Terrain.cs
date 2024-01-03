namespace RogueTraderUnityToolkit.UnityStructures.Generated.Engine;

using Core;
using Unity.BuiltInTypes;

/* $Terrain (35 fields) (IsEngineType) */
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
    int m_TreeMotionVectorModeOverride)
{
    public static Terrain Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> m_GameObject = PPtr<GameObject>.Read(reader);
        byte m_Enabled = reader.ReadU8();
        PPtr<TerrainData> m_TerrainData = PPtr<TerrainData>.Read(reader);
        float m_TreeDistance = reader.ReadF32();
        float m_TreeBillboardDistance = reader.ReadF32();
        float m_TreeCrossFadeLength = reader.ReadF32();
        int m_TreeMaximumFullLODCount = reader.ReadS32();
        float m_DetailObjectDistance = reader.ReadF32();
        float m_DetailObjectDensity = reader.ReadF32();
        float m_HeightmapPixelError = reader.ReadF32();
        float m_SplatMapDistance = reader.ReadF32();
        int m_HeightmapMaximumLOD = reader.ReadS32();
        int m_ShadowCastingMode = reader.ReadS32();
        bool m_DrawHeightmap = reader.ReadBool();
        bool m_DrawInstanced = reader.ReadBool();
        bool m_DrawTreesAndFoliage = reader.ReadBool();
        bool m_StaticShadowCaster = reader.ReadBool();
        bool m_IgnoreQualitySettings = reader.ReadBool();
        int m_ReflectionProbeUsage = reader.ReadS32();
        PPtr<Material> m_MaterialTemplate = PPtr<Material>.Read(reader);
        ushort m_LightmapIndex = reader.ReadU16();
        ushort m_LightmapIndexDynamic = reader.ReadU16();
        Vector4f m_LightmapTilingOffset = Vector4f.Read(reader);
        Vector4f m_LightmapTilingOffsetDynamic = Vector4f.Read(reader);
        Hash128 m_ExplicitProbeSetHash = Hash128.Read(reader);
        bool m_BakeLightProbesForTrees = reader.ReadBool();
        bool m_PreserveTreePrototypeLayers = reader.ReadBool();
        Vector4f m_DynamicUVST = Vector4f.Read(reader);
        Vector4f m_ChunkDynamicUVST = Vector4f.Read(reader);
        int m_GroupingID = reader.ReadS32();
        uint m_RenderingLayerMask = reader.ReadU32();
        bool m_AllowAutoConnect = reader.ReadBool();
        bool m_EnableHeightmapRayTracing = reader.ReadBool();
        bool m_EnableTreesAndDetailsRayTracing = reader.ReadBool();
        int m_TreeMotionVectorModeOverride = reader.ReadS32();
        
        return new(m_GameObject,
            m_Enabled,
            m_TerrainData,
            m_TreeDistance,
            m_TreeBillboardDistance,
            m_TreeCrossFadeLength,
            m_TreeMaximumFullLODCount,
            m_DetailObjectDistance,
            m_DetailObjectDensity,
            m_HeightmapPixelError,
            m_SplatMapDistance,
            m_HeightmapMaximumLOD,
            m_ShadowCastingMode,
            m_DrawHeightmap,
            m_DrawInstanced,
            m_DrawTreesAndFoliage,
            m_StaticShadowCaster,
            m_IgnoreQualitySettings,
            m_ReflectionProbeUsage,
            m_MaterialTemplate,
            m_LightmapIndex,
            m_LightmapIndexDynamic,
            m_LightmapTilingOffset,
            m_LightmapTilingOffsetDynamic,
            m_ExplicitProbeSetHash,
            m_BakeLightProbesForTrees,
            m_PreserveTreePrototypeLayers,
            m_DynamicUVST,
            m_ChunkDynamicUVST,
            m_GroupingID,
            m_RenderingLayerMask,
            m_AllowAutoConnect,
            m_EnableHeightmapRayTracing,
            m_EnableTreesAndDetailsRayTracing,
            m_TreeMotionVectorModeOverride);
    }
}


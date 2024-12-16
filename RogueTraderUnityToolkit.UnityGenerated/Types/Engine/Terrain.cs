namespace RogueTraderUnityToolkit.UnityGenerated.Types.Engine;

using Core;
using System.Text;
using Unity;

/* $Terrain (36 fields) Terrain 0C62301AC09C5AD16AEB068D40D462CD */
public record class Terrain (
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
    int m_HeightmapMinimumLODSimplification,
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
    public static UnityObjectType ObjectType => UnityObjectType.Terrain;
    public static Hash128 Hash => new("0C62301AC09C5AD16AEB068D40D462CD");
    public static Terrain Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> m_GameObject_ = PPtr<GameObject>.Read(reader);
        byte m_Enabled_ = reader.ReadU8();
        reader.AlignTo(4); /* m_Enabled */
        PPtr<TerrainData> m_TerrainData_ = PPtr<TerrainData>.Read(reader);
        float m_TreeDistance_ = reader.ReadF32();
        float m_TreeBillboardDistance_ = reader.ReadF32();
        float m_TreeCrossFadeLength_ = reader.ReadF32();
        int m_TreeMaximumFullLODCount_ = reader.ReadS32();
        float m_DetailObjectDistance_ = reader.ReadF32();
        float m_DetailObjectDensity_ = reader.ReadF32();
        float m_HeightmapPixelError_ = reader.ReadF32();
        float m_SplatMapDistance_ = reader.ReadF32();
        int m_HeightmapMinimumLODSimplification_ = reader.ReadS32();
        int m_HeightmapMaximumLOD_ = reader.ReadS32();
        int m_ShadowCastingMode_ = reader.ReadS32();
        bool m_DrawHeightmap_ = reader.ReadBool();
        bool m_DrawInstanced_ = reader.ReadBool();
        bool m_DrawTreesAndFoliage_ = reader.ReadBool();
        bool m_StaticShadowCaster_ = reader.ReadBool();
        reader.AlignTo(4); /* m_StaticShadowCaster */
        bool m_IgnoreQualitySettings_ = reader.ReadBool();
        reader.AlignTo(4); /* m_IgnoreQualitySettings */
        int m_ReflectionProbeUsage_ = reader.ReadS32();
        PPtr<Material> m_MaterialTemplate_ = PPtr<Material>.Read(reader);
        ushort m_LightmapIndex_ = reader.ReadU16();
        ushort m_LightmapIndexDynamic_ = reader.ReadU16();
        Vector4f m_LightmapTilingOffset_ = Vector4f.Read(reader);
        Vector4f m_LightmapTilingOffsetDynamic_ = Vector4f.Read(reader);
        Hash128 m_ExplicitProbeSetHash_ = Hash128.Read(reader);
        bool m_BakeLightProbesForTrees_ = reader.ReadBool();
        bool m_PreserveTreePrototypeLayers_ = reader.ReadBool();
        reader.AlignTo(4); /* m_PreserveTreePrototypeLayers */
        Vector4f m_DynamicUVST_ = Vector4f.Read(reader);
        Vector4f m_ChunkDynamicUVST_ = Vector4f.Read(reader);
        reader.AlignTo(4); /* m_ChunkDynamicUVST */
        int m_GroupingID_ = reader.ReadS32();
        uint m_RenderingLayerMask_ = reader.ReadU32();
        bool m_AllowAutoConnect_ = reader.ReadBool();
        bool m_EnableHeightmapRayTracing_ = reader.ReadBool();
        bool m_EnableTreesAndDetailsRayTracing_ = reader.ReadBool();
        reader.AlignTo(4); /* m_EnableTreesAndDetailsRayTracing */
        int m_TreeMotionVectorModeOverride_ = reader.ReadS32();
        
        return new(m_GameObject_,
            m_Enabled_,
            m_TerrainData_,
            m_TreeDistance_,
            m_TreeBillboardDistance_,
            m_TreeCrossFadeLength_,
            m_TreeMaximumFullLODCount_,
            m_DetailObjectDistance_,
            m_DetailObjectDensity_,
            m_HeightmapPixelError_,
            m_SplatMapDistance_,
            m_HeightmapMinimumLODSimplification_,
            m_HeightmapMaximumLOD_,
            m_ShadowCastingMode_,
            m_DrawHeightmap_,
            m_DrawInstanced_,
            m_DrawTreesAndFoliage_,
            m_StaticShadowCaster_,
            m_IgnoreQualitySettings_,
            m_ReflectionProbeUsage_,
            m_MaterialTemplate_,
            m_LightmapIndex_,
            m_LightmapIndexDynamic_,
            m_LightmapTilingOffset_,
            m_LightmapTilingOffsetDynamic_,
            m_ExplicitProbeSetHash_,
            m_BakeLightProbesForTrees_,
            m_PreserveTreePrototypeLayers_,
            m_DynamicUVST_,
            m_ChunkDynamicUVST_,
            m_GroupingID_,
            m_RenderingLayerMask_,
            m_AllowAutoConnect_,
            m_EnableHeightmapRayTracing_,
            m_EnableTreesAndDetailsRayTracing_,
            m_TreeMotionVectorModeOverride_);
    }

    public override string ToString() => $"Terrain\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();
        string indent_ = ' '.Repeat(indent);

        ToString_Field0(sb, indent, indent_);
        ToString_Field1(sb, indent, indent_);
        ToString_Field2(sb, indent, indent_);
        ToString_Field3(sb, indent, indent_);
        ToString_Field4(sb, indent, indent_);
        ToString_Field5(sb, indent, indent_);
        ToString_Field6(sb, indent, indent_);
        ToString_Field7(sb, indent, indent_);
        ToString_Field8(sb, indent, indent_);
        ToString_Field9(sb, indent, indent_);
        ToString_Field10(sb, indent, indent_);
        ToString_Field11(sb, indent, indent_);
        ToString_Field12(sb, indent, indent_);
        ToString_Field13(sb, indent, indent_);
        ToString_Field14(sb, indent, indent_);
        ToString_Field15(sb, indent, indent_);
        ToString_Field16(sb, indent, indent_);
        ToString_Field17(sb, indent, indent_);
        ToString_Field18(sb, indent, indent_);
        ToString_Field19(sb, indent, indent_);
        ToString_Field20(sb, indent, indent_);
        ToString_Field21(sb, indent, indent_);
        ToString_Field22(sb, indent, indent_);
        ToString_Field23(sb, indent, indent_);
        ToString_Field24(sb, indent, indent_);
        ToString_Field25(sb, indent, indent_);
        ToString_Field26(sb, indent, indent_);
        ToString_Field27(sb, indent, indent_);
        ToString_Field28(sb, indent, indent_);
        ToString_Field29(sb, indent, indent_);
        ToString_Field30(sb, indent, indent_);
        ToString_Field31(sb, indent, indent_);
        ToString_Field32(sb, indent, indent_);
        ToString_Field33(sb, indent, indent_);
        ToString_Field34(sb, indent, indent_);
        ToString_Field35(sb, indent, indent_);

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_GameObject: {m_GameObject}");
    }

    public void ToString_Field1(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_Enabled: {m_Enabled}");
    }

    public void ToString_Field2(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_TerrainData: {m_TerrainData}");
    }

    public void ToString_Field3(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_TreeDistance: {m_TreeDistance}");
    }

    public void ToString_Field4(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_TreeBillboardDistance: {m_TreeBillboardDistance}");
    }

    public void ToString_Field5(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_TreeCrossFadeLength: {m_TreeCrossFadeLength}");
    }

    public void ToString_Field6(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_TreeMaximumFullLODCount: {m_TreeMaximumFullLODCount}");
    }

    public void ToString_Field7(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_DetailObjectDistance: {m_DetailObjectDistance}");
    }

    public void ToString_Field8(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_DetailObjectDensity: {m_DetailObjectDensity}");
    }

    public void ToString_Field9(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_HeightmapPixelError: {m_HeightmapPixelError}");
    }

    public void ToString_Field10(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_SplatMapDistance: {m_SplatMapDistance}");
    }

    public void ToString_Field11(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_HeightmapMinimumLODSimplification: {m_HeightmapMinimumLODSimplification}");
    }

    public void ToString_Field12(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_HeightmapMaximumLOD: {m_HeightmapMaximumLOD}");
    }

    public void ToString_Field13(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_ShadowCastingMode: {m_ShadowCastingMode}");
    }

    public void ToString_Field14(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_DrawHeightmap: {m_DrawHeightmap}");
    }

    public void ToString_Field15(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_DrawInstanced: {m_DrawInstanced}");
    }

    public void ToString_Field16(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_DrawTreesAndFoliage: {m_DrawTreesAndFoliage}");
    }

    public void ToString_Field17(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_StaticShadowCaster: {m_StaticShadowCaster}");
    }

    public void ToString_Field18(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_IgnoreQualitySettings: {m_IgnoreQualitySettings}");
    }

    public void ToString_Field19(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_ReflectionProbeUsage: {m_ReflectionProbeUsage}");
    }

    public void ToString_Field20(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_MaterialTemplate: {m_MaterialTemplate}");
    }

    public void ToString_Field21(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_LightmapIndex: {m_LightmapIndex}");
    }

    public void ToString_Field22(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_LightmapIndexDynamic: {m_LightmapIndexDynamic}");
    }

    public void ToString_Field23(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_LightmapTilingOffset: {{ x: {m_LightmapTilingOffset.x}, y: {m_LightmapTilingOffset.y}, z: {m_LightmapTilingOffset.z}, w: {m_LightmapTilingOffset.w} }}\n");
    }

    public void ToString_Field24(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_LightmapTilingOffsetDynamic: {{ x: {m_LightmapTilingOffsetDynamic.x}, y: {m_LightmapTilingOffsetDynamic.y}, z: {m_LightmapTilingOffsetDynamic.z}, w: {m_LightmapTilingOffsetDynamic.w} }}\n");
    }

    public void ToString_Field25(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_ExplicitProbeSetHash: {m_ExplicitProbeSetHash}");
    }

    public void ToString_Field26(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_BakeLightProbesForTrees: {m_BakeLightProbesForTrees}");
    }

    public void ToString_Field27(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_PreserveTreePrototypeLayers: {m_PreserveTreePrototypeLayers}");
    }

    public void ToString_Field28(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_DynamicUVST: {{ x: {m_DynamicUVST.x}, y: {m_DynamicUVST.y}, z: {m_DynamicUVST.z}, w: {m_DynamicUVST.w} }}\n");
    }

    public void ToString_Field29(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_ChunkDynamicUVST: {{ x: {m_ChunkDynamicUVST.x}, y: {m_ChunkDynamicUVST.y}, z: {m_ChunkDynamicUVST.z}, w: {m_ChunkDynamicUVST.w} }}\n");
    }

    public void ToString_Field30(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_GroupingID: {m_GroupingID}");
    }

    public void ToString_Field31(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_RenderingLayerMask: {m_RenderingLayerMask}");
    }

    public void ToString_Field32(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_AllowAutoConnect: {m_AllowAutoConnect}");
    }

    public void ToString_Field33(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_EnableHeightmapRayTracing: {m_EnableHeightmapRayTracing}");
    }

    public void ToString_Field34(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_EnableTreesAndDetailsRayTracing: {m_EnableTreesAndDetailsRayTracing}");
    }

    public void ToString_Field35(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_TreeMotionVectorModeOverride: {m_TreeMotionVectorModeOverride}");
    }
}


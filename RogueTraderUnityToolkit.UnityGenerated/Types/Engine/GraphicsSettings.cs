namespace RogueTraderUnityToolkit.UnityGenerated.Types.Engine;

using Core;
using System.Text;
using Unity;

/* $GraphicsSettings (27 fields) GraphicsSettings 7E5F623B5483022F45905339A4042992 */
public record class GraphicsSettings (
    BuiltinShaderSettings m_Deferred,
    BuiltinShaderSettings m_DeferredReflections,
    BuiltinShaderSettings m_ScreenSpaceShadows,
    BuiltinShaderSettings m_DepthNormals,
    BuiltinShaderSettings m_MotionVectors,
    BuiltinShaderSettings m_LightHalo,
    BuiltinShaderSettings m_LensFlare,
    int m_VideoShadersIncludeMode,
    PPtr<Shader>[] m_AlwaysIncludedShaders,
    PPtr<ShaderVariantCollection>[] m_PreloadedShaders,
    int m_PreloadShadersBatchTimeLimit,
    PPtr<Material> m_SpritesDefaultMaterial,
    PPtr<MonoBehaviour> m_CustomRenderPipeline,
    int m_TransparencySortMode,
    Vector3f m_TransparencySortAxis,
    TierGraphicsSettings m_TierSettings_Tier1,
    TierGraphicsSettings m_TierSettings_Tier2,
    TierGraphicsSettings m_TierSettings_Tier3,
    PlatformShaderDefines[] m_ShaderDefinesPerShaderCompiler,
    bool m_LightsUseLinearIntensity,
    bool m_LightsUseColorTemperature,
    uint m_DefaultRenderingLayerMask,
    bool m_LogWhenShaderIsCompiled,
    Dictionary<AsciiString, PPtr<Object>> m_SRPDefaultSettings,
    int m_LightProbeOutsideHullStrategy,
    bool m_CameraRelativeLightCulling,
    bool m_CameraRelativeShadowCulling) : IUnityEngineStructure
{
    public static UnityObjectType ObjectType => UnityObjectType.GraphicsSettings;
    public static Hash128 Hash => new("7E5F623B5483022F45905339A4042992");
    public static GraphicsSettings Read(EndianBinaryReader reader)
    {
        BuiltinShaderSettings m_Deferred_ = BuiltinShaderSettings.Read(reader);
        BuiltinShaderSettings m_DeferredReflections_ = BuiltinShaderSettings.Read(reader);
        BuiltinShaderSettings m_ScreenSpaceShadows_ = BuiltinShaderSettings.Read(reader);
        BuiltinShaderSettings m_DepthNormals_ = BuiltinShaderSettings.Read(reader);
        BuiltinShaderSettings m_MotionVectors_ = BuiltinShaderSettings.Read(reader);
        BuiltinShaderSettings m_LightHalo_ = BuiltinShaderSettings.Read(reader);
        BuiltinShaderSettings m_LensFlare_ = BuiltinShaderSettings.Read(reader);
        int m_VideoShadersIncludeMode_ = reader.ReadS32();
        PPtr<Shader>[] m_AlwaysIncludedShaders_ = BuiltInArray<PPtr<Shader>>.Read(reader);
        reader.AlignTo(4); /* m_AlwaysIncludedShaders */
        PPtr<ShaderVariantCollection>[] m_PreloadedShaders_ = BuiltInArray<PPtr<ShaderVariantCollection>>.Read(reader);
        reader.AlignTo(4); /* m_PreloadedShaders */
        int m_PreloadShadersBatchTimeLimit_ = reader.ReadS32();
        PPtr<Material> m_SpritesDefaultMaterial_ = PPtr<Material>.Read(reader);
        PPtr<MonoBehaviour> m_CustomRenderPipeline_ = PPtr<MonoBehaviour>.Read(reader);
        int m_TransparencySortMode_ = reader.ReadS32();
        Vector3f m_TransparencySortAxis_ = Vector3f.Read(reader);
        TierGraphicsSettings m_TierSettings_Tier1_ = TierGraphicsSettings.Read(reader);
        reader.AlignTo(4); /* m_TierSettings_Tier1 */
        TierGraphicsSettings m_TierSettings_Tier2_ = TierGraphicsSettings.Read(reader);
        reader.AlignTo(4); /* m_TierSettings_Tier2 */
        TierGraphicsSettings m_TierSettings_Tier3_ = TierGraphicsSettings.Read(reader);
        reader.AlignTo(4); /* m_TierSettings_Tier3 */
        PlatformShaderDefines[] m_ShaderDefinesPerShaderCompiler_ = BuiltInArray<PlatformShaderDefines>.Read(reader);
        reader.AlignTo(4); /* m_ShaderDefinesPerShaderCompiler */
        bool m_LightsUseLinearIntensity_ = reader.ReadBool();
        bool m_LightsUseColorTemperature_ = reader.ReadBool();
        reader.AlignTo(4); /* m_LightsUseColorTemperature */
        uint m_DefaultRenderingLayerMask_ = reader.ReadU32();
        bool m_LogWhenShaderIsCompiled_ = reader.ReadBool();
        reader.AlignTo(4); /* m_LogWhenShaderIsCompiled */
        Dictionary<AsciiString, PPtr<Object>> m_SRPDefaultSettings_ = BuiltInMap<AsciiString, PPtr<Object>>.Read(reader);
        reader.AlignTo(4); /* m_SRPDefaultSettings */
        int m_LightProbeOutsideHullStrategy_ = reader.ReadS32();
        bool m_CameraRelativeLightCulling_ = reader.ReadBool();
        bool m_CameraRelativeShadowCulling_ = reader.ReadBool();
        
        return new(m_Deferred_,
            m_DeferredReflections_,
            m_ScreenSpaceShadows_,
            m_DepthNormals_,
            m_MotionVectors_,
            m_LightHalo_,
            m_LensFlare_,
            m_VideoShadersIncludeMode_,
            m_AlwaysIncludedShaders_,
            m_PreloadedShaders_,
            m_PreloadShadersBatchTimeLimit_,
            m_SpritesDefaultMaterial_,
            m_CustomRenderPipeline_,
            m_TransparencySortMode_,
            m_TransparencySortAxis_,
            m_TierSettings_Tier1_,
            m_TierSettings_Tier2_,
            m_TierSettings_Tier3_,
            m_ShaderDefinesPerShaderCompiler_,
            m_LightsUseLinearIntensity_,
            m_LightsUseColorTemperature_,
            m_DefaultRenderingLayerMask_,
            m_LogWhenShaderIsCompiled_,
            m_SRPDefaultSettings_,
            m_LightProbeOutsideHullStrategy_,
            m_CameraRelativeLightCulling_,
            m_CameraRelativeShadowCulling_);
    }

    public override string ToString() => $"GraphicsSettings\n{ToString(4)}";

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

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_Deferred: {{ \n{m_Deferred.ToString(indent+4)}{indent_}}}\n");
    }

    public void ToString_Field1(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_DeferredReflections: {{ \n{m_DeferredReflections.ToString(indent+4)}{indent_}}}\n");
    }

    public void ToString_Field2(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_ScreenSpaceShadows: {{ \n{m_ScreenSpaceShadows.ToString(indent+4)}{indent_}}}\n");
    }

    public void ToString_Field3(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_DepthNormals: {{ \n{m_DepthNormals.ToString(indent+4)}{indent_}}}\n");
    }

    public void ToString_Field4(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_MotionVectors: {{ \n{m_MotionVectors.ToString(indent+4)}{indent_}}}\n");
    }

    public void ToString_Field5(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_LightHalo: {{ \n{m_LightHalo.ToString(indent+4)}{indent_}}}\n");
    }

    public void ToString_Field6(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_LensFlare: {{ \n{m_LensFlare.ToString(indent+4)}{indent_}}}\n");
    }

    public void ToString_Field7(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_VideoShadersIncludeMode: {m_VideoShadersIncludeMode}");
    }

    public void ToString_Field8(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_AlwaysIncludedShaders[{m_AlwaysIncludedShaders.Length}] = {{");
        if (m_AlwaysIncludedShaders.Length > 0) sb.AppendLine();
        int _4i = 0;
        foreach (PPtr<Shader> _4 in m_AlwaysIncludedShaders)
        {
            sb.AppendLine($"{indent_ + ' '.Repeat(4)}[{_4i}] = {_4}");
            ++_4i;
        }
        if (m_AlwaysIncludedShaders.Length > 0) sb.Append(indent_);
        sb.AppendLine("}");
    }

    public void ToString_Field9(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_PreloadedShaders[{m_PreloadedShaders.Length}] = {{");
        if (m_PreloadedShaders.Length > 0) sb.AppendLine();
        int _4i = 0;
        foreach (PPtr<ShaderVariantCollection> _4 in m_PreloadedShaders)
        {
            sb.AppendLine($"{indent_ + ' '.Repeat(4)}[{_4i}] = {_4}");
            ++_4i;
        }
        if (m_PreloadedShaders.Length > 0) sb.Append(indent_);
        sb.AppendLine("}");
    }

    public void ToString_Field10(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_PreloadShadersBatchTimeLimit: {m_PreloadShadersBatchTimeLimit}");
    }

    public void ToString_Field11(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_SpritesDefaultMaterial: {m_SpritesDefaultMaterial}");
    }

    public void ToString_Field12(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_CustomRenderPipeline: {m_CustomRenderPipeline}");
    }

    public void ToString_Field13(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_TransparencySortMode: {m_TransparencySortMode}");
    }

    public void ToString_Field14(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_TransparencySortAxis: {{ x: {m_TransparencySortAxis.x}, y: {m_TransparencySortAxis.y}, z: {m_TransparencySortAxis.z} }}\n");
    }

    public void ToString_Field15(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_TierSettings_Tier1: {{ \n{m_TierSettings_Tier1.ToString(indent+4)}{indent_}}}\n");
    }

    public void ToString_Field16(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_TierSettings_Tier2: {{ \n{m_TierSettings_Tier2.ToString(indent+4)}{indent_}}}\n");
    }

    public void ToString_Field17(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_TierSettings_Tier3: {{ \n{m_TierSettings_Tier3.ToString(indent+4)}{indent_}}}\n");
    }

    public void ToString_Field18(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_ShaderDefinesPerShaderCompiler[{m_ShaderDefinesPerShaderCompiler.Length}] = {{");
        if (m_ShaderDefinesPerShaderCompiler.Length > 0) sb.AppendLine();
        int _4i = 0;
        foreach (PlatformShaderDefines _4 in m_ShaderDefinesPerShaderCompiler)
        {
            sb.Append($"{indent_ + ' '.Repeat(4)}[{_4i}] = {{ \n{_4.ToString(indent+8)}{indent_ + ' '.Repeat(4)}}}\n");
            ++_4i;
        }
        if (m_ShaderDefinesPerShaderCompiler.Length > 0) sb.Append(indent_);
        sb.AppendLine("}");
    }

    public void ToString_Field19(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_LightsUseLinearIntensity: {m_LightsUseLinearIntensity}");
    }

    public void ToString_Field20(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_LightsUseColorTemperature: {m_LightsUseColorTemperature}");
    }

    public void ToString_Field21(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_DefaultRenderingLayerMask: {m_DefaultRenderingLayerMask}");
    }

    public void ToString_Field22(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_LogWhenShaderIsCompiled: {m_LogWhenShaderIsCompiled}");
    }

    public void ToString_Field23(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_SRPDefaultSettings[{m_SRPDefaultSettings.Count}] = {{");
        if (m_SRPDefaultSettings.Count > 0) sb.AppendLine();
        int _4i = 0;
        foreach (KeyValuePair<AsciiString, PPtr<Object>> _4 in m_SRPDefaultSettings)
        {
            sb.AppendLine($"{indent_ + ' '.Repeat(4)}[\"{_4.Key}\"] = {_4.Value}");
            ++_4i;
        }
        if (m_SRPDefaultSettings.Count > 0) sb.Append(indent_);
        sb.AppendLine("}");
    }

    public void ToString_Field24(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_LightProbeOutsideHullStrategy: {m_LightProbeOutsideHullStrategy}");
    }

    public void ToString_Field25(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_CameraRelativeLightCulling: {m_CameraRelativeLightCulling}");
    }

    public void ToString_Field26(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_CameraRelativeShadowCulling: {m_CameraRelativeShadowCulling}");
    }
}


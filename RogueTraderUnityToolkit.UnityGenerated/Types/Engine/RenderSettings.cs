namespace RogueTraderUnityToolkit.UnityGenerated.Types.Engine;

using Core;
using System.Text;
using Unity;

/* $RenderSettings (28 fields) RenderSettings 9520A2E624C07FC4E386C12E60F9E821 */
public record class RenderSettings (
    bool m_Fog,
    ColorRGBA_1 m_FogColor,
    int m_FogMode,
    float m_FogDensity,
    float m_LinearFogStart,
    float m_LinearFogEnd,
    ColorRGBA_1 m_AmbientSkyColor,
    ColorRGBA_1 m_AmbientEquatorColor,
    ColorRGBA_1 m_AmbientGroundColor,
    float m_AmbientIntensity,
    int m_AmbientMode,
    ColorRGBA_1 m_SubtractiveShadowColor,
    PPtr<Material> m_SkyboxMaterial,
    float m_HaloStrength,
    float m_FlareStrength,
    float m_FlareFadeSpeed,
    PPtr<Texture2D> m_HaloTexture,
    PPtr<Texture2D> m_SpotCookie,
    int m_DefaultReflectionMode,
    int m_DefaultReflectionResolution,
    int m_ReflectionBounces,
    float m_ReflectionIntensity,
    PPtr<Texture> m_CustomReflection,
    SphericalHarmonicsL2 m_AmbientProbe,
    PPtr<Cubemap> m_GeneratedSkyboxReflection,
    PPtr<Light> m_Sun,
    ColorRGBA_1 m_IndirectSpecularColor,
    bool m_UseRadianceAmbientProbe) : IUnityEngineStructure
{
    public static UnityObjectType ObjectType => UnityObjectType.RenderSettings;
    public static Hash128 Hash => new("9520A2E624C07FC4E386C12E60F9E821");
    public static RenderSettings Read(EndianBinaryReader reader)
    {
        bool m_Fog_ = reader.ReadBool();
        reader.AlignTo(4); /* m_Fog */
        ColorRGBA_1 m_FogColor_ = ColorRGBA_1.Read(reader);
        int m_FogMode_ = reader.ReadS32();
        float m_FogDensity_ = reader.ReadF32();
        float m_LinearFogStart_ = reader.ReadF32();
        float m_LinearFogEnd_ = reader.ReadF32();
        ColorRGBA_1 m_AmbientSkyColor_ = ColorRGBA_1.Read(reader);
        ColorRGBA_1 m_AmbientEquatorColor_ = ColorRGBA_1.Read(reader);
        ColorRGBA_1 m_AmbientGroundColor_ = ColorRGBA_1.Read(reader);
        float m_AmbientIntensity_ = reader.ReadF32();
        int m_AmbientMode_ = reader.ReadS32();
        reader.AlignTo(4); /* m_AmbientMode */
        ColorRGBA_1 m_SubtractiveShadowColor_ = ColorRGBA_1.Read(reader);
        PPtr<Material> m_SkyboxMaterial_ = PPtr<Material>.Read(reader);
        float m_HaloStrength_ = reader.ReadF32();
        float m_FlareStrength_ = reader.ReadF32();
        float m_FlareFadeSpeed_ = reader.ReadF32();
        PPtr<Texture2D> m_HaloTexture_ = PPtr<Texture2D>.Read(reader);
        PPtr<Texture2D> m_SpotCookie_ = PPtr<Texture2D>.Read(reader);
        int m_DefaultReflectionMode_ = reader.ReadS32();
        int m_DefaultReflectionResolution_ = reader.ReadS32();
        int m_ReflectionBounces_ = reader.ReadS32();
        float m_ReflectionIntensity_ = reader.ReadF32();
        PPtr<Texture> m_CustomReflection_ = PPtr<Texture>.Read(reader);
        SphericalHarmonicsL2 m_AmbientProbe_ = SphericalHarmonicsL2.Read(reader);
        PPtr<Cubemap> m_GeneratedSkyboxReflection_ = PPtr<Cubemap>.Read(reader);
        PPtr<Light> m_Sun_ = PPtr<Light>.Read(reader);
        ColorRGBA_1 m_IndirectSpecularColor_ = ColorRGBA_1.Read(reader);
        bool m_UseRadianceAmbientProbe_ = reader.ReadBool();
        
        return new(m_Fog_,
            m_FogColor_,
            m_FogMode_,
            m_FogDensity_,
            m_LinearFogStart_,
            m_LinearFogEnd_,
            m_AmbientSkyColor_,
            m_AmbientEquatorColor_,
            m_AmbientGroundColor_,
            m_AmbientIntensity_,
            m_AmbientMode_,
            m_SubtractiveShadowColor_,
            m_SkyboxMaterial_,
            m_HaloStrength_,
            m_FlareStrength_,
            m_FlareFadeSpeed_,
            m_HaloTexture_,
            m_SpotCookie_,
            m_DefaultReflectionMode_,
            m_DefaultReflectionResolution_,
            m_ReflectionBounces_,
            m_ReflectionIntensity_,
            m_CustomReflection_,
            m_AmbientProbe_,
            m_GeneratedSkyboxReflection_,
            m_Sun_,
            m_IndirectSpecularColor_,
            m_UseRadianceAmbientProbe_);
    }

    public override string ToString() => $"RenderSettings\n{ToString(4)}";

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

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_Fog: {m_Fog}");
    }

    public void ToString_Field1(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_FogColor: {{ r: {m_FogColor.r}, g: {m_FogColor.g}, b: {m_FogColor.b}, a: {m_FogColor.a} }}\n");
    }

    public void ToString_Field2(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_FogMode: {m_FogMode}");
    }

    public void ToString_Field3(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_FogDensity: {m_FogDensity}");
    }

    public void ToString_Field4(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_LinearFogStart: {m_LinearFogStart}");
    }

    public void ToString_Field5(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_LinearFogEnd: {m_LinearFogEnd}");
    }

    public void ToString_Field6(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_AmbientSkyColor: {{ r: {m_AmbientSkyColor.r}, g: {m_AmbientSkyColor.g}, b: {m_AmbientSkyColor.b}, a: {m_AmbientSkyColor.a} }}\n");
    }

    public void ToString_Field7(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_AmbientEquatorColor: {{ r: {m_AmbientEquatorColor.r}, g: {m_AmbientEquatorColor.g}, b: {m_AmbientEquatorColor.b}, a: {m_AmbientEquatorColor.a} }}\n");
    }

    public void ToString_Field8(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_AmbientGroundColor: {{ r: {m_AmbientGroundColor.r}, g: {m_AmbientGroundColor.g}, b: {m_AmbientGroundColor.b}, a: {m_AmbientGroundColor.a} }}\n");
    }

    public void ToString_Field9(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_AmbientIntensity: {m_AmbientIntensity}");
    }

    public void ToString_Field10(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_AmbientMode: {m_AmbientMode}");
    }

    public void ToString_Field11(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_SubtractiveShadowColor: {{ r: {m_SubtractiveShadowColor.r}, g: {m_SubtractiveShadowColor.g}, b: {m_SubtractiveShadowColor.b}, a: {m_SubtractiveShadowColor.a} }}\n");
    }

    public void ToString_Field12(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_SkyboxMaterial: {m_SkyboxMaterial}");
    }

    public void ToString_Field13(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_HaloStrength: {m_HaloStrength}");
    }

    public void ToString_Field14(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_FlareStrength: {m_FlareStrength}");
    }

    public void ToString_Field15(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_FlareFadeSpeed: {m_FlareFadeSpeed}");
    }

    public void ToString_Field16(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_HaloTexture: {m_HaloTexture}");
    }

    public void ToString_Field17(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_SpotCookie: {m_SpotCookie}");
    }

    public void ToString_Field18(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_DefaultReflectionMode: {m_DefaultReflectionMode}");
    }

    public void ToString_Field19(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_DefaultReflectionResolution: {m_DefaultReflectionResolution}");
    }

    public void ToString_Field20(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_ReflectionBounces: {m_ReflectionBounces}");
    }

    public void ToString_Field21(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_ReflectionIntensity: {m_ReflectionIntensity}");
    }

    public void ToString_Field22(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_CustomReflection: {m_CustomReflection}");
    }

    public void ToString_Field23(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_AmbientProbe: {{ \n{m_AmbientProbe.ToString(indent+4)}{indent_}}}\n");
    }

    public void ToString_Field24(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_GeneratedSkyboxReflection: {m_GeneratedSkyboxReflection}");
    }

    public void ToString_Field25(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_Sun: {m_Sun}");
    }

    public void ToString_Field26(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_IndirectSpecularColor: {{ r: {m_IndirectSpecularColor.r}, g: {m_IndirectSpecularColor.g}, b: {m_IndirectSpecularColor.b}, a: {m_IndirectSpecularColor.a} }}\n");
    }

    public void ToString_Field27(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_UseRadianceAmbientProbe: {m_UseRadianceAmbientProbe}");
    }
}


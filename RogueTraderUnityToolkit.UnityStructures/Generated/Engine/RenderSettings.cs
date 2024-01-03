namespace RogueTraderUnityToolkit.UnityStructures.Generated.Engine;

using Core;
using Unity.BuiltInTypes;

/* $RenderSettings (28 fields) (IsEngineType) */
public record class RenderSettings(
    bool m_Fog,
    ColorRGBA m_FogColor,
    int m_FogMode,
    float m_FogDensity,
    float m_LinearFogStart,
    float m_LinearFogEnd,
    ColorRGBA m_AmbientSkyColor,
    ColorRGBA m_AmbientEquatorColor,
    ColorRGBA m_AmbientGroundColor,
    float m_AmbientIntensity,
    int m_AmbientMode,
    ColorRGBA m_SubtractiveShadowColor,
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
    ColorRGBA m_IndirectSpecularColor,
    bool m_UseRadianceAmbientProbe)
{
    public static RenderSettings Read(EndianBinaryReader reader)
    {
        bool m_Fog = reader.ReadBool();
        ColorRGBA m_FogColor = ColorRGBA.Read(reader);
        int m_FogMode = reader.ReadS32();
        float m_FogDensity = reader.ReadF32();
        float m_LinearFogStart = reader.ReadF32();
        float m_LinearFogEnd = reader.ReadF32();
        ColorRGBA m_AmbientSkyColor = ColorRGBA.Read(reader);
        ColorRGBA m_AmbientEquatorColor = ColorRGBA.Read(reader);
        ColorRGBA m_AmbientGroundColor = ColorRGBA.Read(reader);
        float m_AmbientIntensity = reader.ReadF32();
        int m_AmbientMode = reader.ReadS32();
        ColorRGBA m_SubtractiveShadowColor = ColorRGBA.Read(reader);
        PPtr<Material> m_SkyboxMaterial = PPtr<Material>.Read(reader);
        float m_HaloStrength = reader.ReadF32();
        float m_FlareStrength = reader.ReadF32();
        float m_FlareFadeSpeed = reader.ReadF32();
        PPtr<Texture2D> m_HaloTexture = PPtr<Texture2D>.Read(reader);
        PPtr<Texture2D> m_SpotCookie = PPtr<Texture2D>.Read(reader);
        int m_DefaultReflectionMode = reader.ReadS32();
        int m_DefaultReflectionResolution = reader.ReadS32();
        int m_ReflectionBounces = reader.ReadS32();
        float m_ReflectionIntensity = reader.ReadF32();
        PPtr<Texture> m_CustomReflection = PPtr<Texture>.Read(reader);
        SphericalHarmonicsL2 m_AmbientProbe = SphericalHarmonicsL2.Read(reader);
        PPtr<Cubemap> m_GeneratedSkyboxReflection = PPtr<Cubemap>.Read(reader);
        PPtr<Light> m_Sun = PPtr<Light>.Read(reader);
        ColorRGBA m_IndirectSpecularColor = ColorRGBA.Read(reader);
        bool m_UseRadianceAmbientProbe = reader.ReadBool();
        
        return new(m_Fog,
            m_FogColor,
            m_FogMode,
            m_FogDensity,
            m_LinearFogStart,
            m_LinearFogEnd,
            m_AmbientSkyColor,
            m_AmbientEquatorColor,
            m_AmbientGroundColor,
            m_AmbientIntensity,
            m_AmbientMode,
            m_SubtractiveShadowColor,
            m_SkyboxMaterial,
            m_HaloStrength,
            m_FlareStrength,
            m_FlareFadeSpeed,
            m_HaloTexture,
            m_SpotCookie,
            m_DefaultReflectionMode,
            m_DefaultReflectionResolution,
            m_ReflectionBounces,
            m_ReflectionIntensity,
            m_CustomReflection,
            m_AmbientProbe,
            m_GeneratedSkyboxReflection,
            m_Sun,
            m_IndirectSpecularColor,
            m_UseRadianceAmbientProbe);
    }
}


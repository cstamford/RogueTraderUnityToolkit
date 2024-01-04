namespace RogueTraderUnityToolkit.UnityGenerated.Types.Engine;

using Core;
using Unity;

/* $RenderSettings (28 fields) 9520A2E624C07FC4E386C12E60F9E821 */
public record class RenderSettings(
    bool m_Fog /* None */,
    ColorRGBA m_FogColor /* NeedsAlign */,
    int m_FogMode /* None */,
    float m_FogDensity /* None */,
    float m_LinearFogStart /* None */,
    float m_LinearFogEnd /* None */,
    ColorRGBA m_AmbientSkyColor /* None */,
    ColorRGBA m_AmbientEquatorColor /* None */,
    ColorRGBA m_AmbientGroundColor /* None */,
    float m_AmbientIntensity /* None */,
    int m_AmbientMode /* None */,
    ColorRGBA m_SubtractiveShadowColor /* NeedsAlign */,
    PPtr<Material> m_SkyboxMaterial /* None */,
    float m_HaloStrength /* None */,
    float m_FlareStrength /* None */,
    float m_FlareFadeSpeed /* None */,
    PPtr<Texture2D> m_HaloTexture /* None */,
    PPtr<Texture2D> m_SpotCookie /* None */,
    int m_DefaultReflectionMode /* None */,
    int m_DefaultReflectionResolution /* None */,
    int m_ReflectionBounces /* None */,
    float m_ReflectionIntensity /* None */,
    PPtr<Texture> m_CustomReflection /* None */,
    SphericalHarmonicsL2 m_AmbientProbe /* None */,
    PPtr<Cubemap> m_GeneratedSkyboxReflection /* None */,
    PPtr<Light> m_Sun /* None */,
    ColorRGBA m_IndirectSpecularColor /* None */,
    bool m_UseRadianceAmbientProbe /* None */) : IUnityObject
{
    public static Hash128 Hash => new(2501944038, 616595396, 3817259310, 1626990625);
    public static RenderSettings Read(EndianBinaryReader reader)
    {
        bool _m_Fog = reader.ReadBool();
        reader.AlignTo(4); /* m_FogColor */
        ColorRGBA _m_FogColor = ColorRGBA.Read(reader);
        int _m_FogMode = reader.ReadS32();
        float _m_FogDensity = reader.ReadF32();
        float _m_LinearFogStart = reader.ReadF32();
        float _m_LinearFogEnd = reader.ReadF32();
        ColorRGBA _m_AmbientSkyColor = ColorRGBA.Read(reader);
        ColorRGBA _m_AmbientEquatorColor = ColorRGBA.Read(reader);
        ColorRGBA _m_AmbientGroundColor = ColorRGBA.Read(reader);
        float _m_AmbientIntensity = reader.ReadF32();
        int _m_AmbientMode = reader.ReadS32();
        reader.AlignTo(4); /* m_SubtractiveShadowColor */
        ColorRGBA _m_SubtractiveShadowColor = ColorRGBA.Read(reader);
        PPtr<Material> _m_SkyboxMaterial = PPtr<Material>.Read(reader);
        float _m_HaloStrength = reader.ReadF32();
        float _m_FlareStrength = reader.ReadF32();
        float _m_FlareFadeSpeed = reader.ReadF32();
        PPtr<Texture2D> _m_HaloTexture = PPtr<Texture2D>.Read(reader);
        PPtr<Texture2D> _m_SpotCookie = PPtr<Texture2D>.Read(reader);
        int _m_DefaultReflectionMode = reader.ReadS32();
        int _m_DefaultReflectionResolution = reader.ReadS32();
        int _m_ReflectionBounces = reader.ReadS32();
        float _m_ReflectionIntensity = reader.ReadF32();
        PPtr<Texture> _m_CustomReflection = PPtr<Texture>.Read(reader);
        SphericalHarmonicsL2 _m_AmbientProbe = SphericalHarmonicsL2.Read(reader);
        PPtr<Cubemap> _m_GeneratedSkyboxReflection = PPtr<Cubemap>.Read(reader);
        PPtr<Light> _m_Sun = PPtr<Light>.Read(reader);
        ColorRGBA _m_IndirectSpecularColor = ColorRGBA.Read(reader);
        bool _m_UseRadianceAmbientProbe = reader.ReadBool();
        
        return new(_m_Fog,
            _m_FogColor,
            _m_FogMode,
            _m_FogDensity,
            _m_LinearFogStart,
            _m_LinearFogEnd,
            _m_AmbientSkyColor,
            _m_AmbientEquatorColor,
            _m_AmbientGroundColor,
            _m_AmbientIntensity,
            _m_AmbientMode,
            _m_SubtractiveShadowColor,
            _m_SkyboxMaterial,
            _m_HaloStrength,
            _m_FlareStrength,
            _m_FlareFadeSpeed,
            _m_HaloTexture,
            _m_SpotCookie,
            _m_DefaultReflectionMode,
            _m_DefaultReflectionResolution,
            _m_ReflectionBounces,
            _m_ReflectionIntensity,
            _m_CustomReflection,
            _m_AmbientProbe,
            _m_GeneratedSkyboxReflection,
            _m_Sun,
            _m_IndirectSpecularColor,
            _m_UseRadianceAmbientProbe);
    }
}


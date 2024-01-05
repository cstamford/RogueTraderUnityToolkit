namespace RogueTraderUnityToolkit.UnityGenerated.Types.Engine;

using Core;
using System.Text;
using Unity;

/* $RenderSettings (28 fields) 9520A2E624C07FC4E386C12E60F9E821 */
public record class RenderSettings(
    bool m_Fog,
    ColorRGBA_0 m_FogColor,
    int m_FogMode,
    float m_FogDensity,
    float m_LinearFogStart,
    float m_LinearFogEnd,
    ColorRGBA_0 m_AmbientSkyColor,
    ColorRGBA_0 m_AmbientEquatorColor,
    ColorRGBA_0 m_AmbientGroundColor,
    float m_AmbientIntensity,
    int m_AmbientMode,
    ColorRGBA_0 m_SubtractiveShadowColor,
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
    ColorRGBA_0 m_IndirectSpecularColor,
    bool m_UseRadianceAmbientProbe) : IUnityEngineStructure
{
    public static Hash128 Hash => new(2501944038, 616595396, 3817259310, 1626990625);

    public static RenderSettings Read(EndianBinaryReader reader)
    {
        bool _m_Fog = reader.ReadBool();
        reader.AlignTo(4); /* m_Fog */
        ColorRGBA_0 _m_FogColor = ColorRGBA_0.Read(reader);
        int _m_FogMode = reader.ReadS32();
        float _m_FogDensity = reader.ReadF32();
        float _m_LinearFogStart = reader.ReadF32();
        float _m_LinearFogEnd = reader.ReadF32();
        ColorRGBA_0 _m_AmbientSkyColor = ColorRGBA_0.Read(reader);
        ColorRGBA_0 _m_AmbientEquatorColor = ColorRGBA_0.Read(reader);
        ColorRGBA_0 _m_AmbientGroundColor = ColorRGBA_0.Read(reader);
        float _m_AmbientIntensity = reader.ReadF32();
        int _m_AmbientMode = reader.ReadS32();
        reader.AlignTo(4); /* m_AmbientMode */
        ColorRGBA_0 _m_SubtractiveShadowColor = ColorRGBA_0.Read(reader);
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
        ColorRGBA_0 _m_IndirectSpecularColor = ColorRGBA_0.Read(reader);
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

    public override string ToString() => $"RenderSettings\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Fog: ");
        sb.AppendLine(m_Fog.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_FogColor: ");
        sb.AppendLine();
        sb.Append(m_FogColor.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_FogMode: ");
        sb.AppendLine(m_FogMode.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_FogDensity: ");
        sb.AppendLine(m_FogDensity.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_LinearFogStart: ");
        sb.AppendLine(m_LinearFogStart.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_LinearFogEnd: ");
        sb.AppendLine(m_LinearFogEnd.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_AmbientSkyColor: ");
        sb.AppendLine();
        sb.Append(m_AmbientSkyColor.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_AmbientEquatorColor: ");
        sb.AppendLine();
        sb.Append(m_AmbientEquatorColor.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_AmbientGroundColor: ");
        sb.AppendLine();
        sb.Append(m_AmbientGroundColor.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_AmbientIntensity: ");
        sb.AppendLine(m_AmbientIntensity.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_AmbientMode: ");
        sb.AppendLine(m_AmbientMode.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_SubtractiveShadowColor: ");
        sb.AppendLine();
        sb.Append(m_SubtractiveShadowColor.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_SkyboxMaterial: ");
        sb.AppendLine(m_SkyboxMaterial.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_HaloStrength: ");
        sb.AppendLine(m_HaloStrength.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_FlareStrength: ");
        sb.AppendLine(m_FlareStrength.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_FlareFadeSpeed: ");
        sb.AppendLine(m_FlareFadeSpeed.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_HaloTexture: ");
        sb.AppendLine(m_HaloTexture.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_SpotCookie: ");
        sb.AppendLine(m_SpotCookie.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_DefaultReflectionMode: ");
        sb.AppendLine(m_DefaultReflectionMode.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_DefaultReflectionResolution: ");
        sb.AppendLine(m_DefaultReflectionResolution.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_ReflectionBounces: ");
        sb.AppendLine(m_ReflectionBounces.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_ReflectionIntensity: ");
        sb.AppendLine(m_ReflectionIntensity.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_CustomReflection: ");
        sb.AppendLine(m_CustomReflection.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_AmbientProbe: ");
        sb.AppendLine();
        sb.Append(m_AmbientProbe.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_GeneratedSkyboxReflection: ");
        sb.AppendLine(m_GeneratedSkyboxReflection.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Sun: ");
        sb.AppendLine(m_Sun.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_IndirectSpecularColor: ");
        sb.AppendLine();
        sb.Append(m_IndirectSpecularColor.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_UseRadianceAmbientProbe: ");
        sb.AppendLine(m_UseRadianceAmbientProbe.ToString());

        return sb.ToString();
    }
}


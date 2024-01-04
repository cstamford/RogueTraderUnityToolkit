namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $SceneLightConfig (23 fields) E064D7C989418445247C9F26956EA9C2/145C5DE12BF469D5073BCB67D6858890 */
public record class SceneLightConfig(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    Vector3f MainLightRotation /* NeedsAlign */,
    ColorRGBA MainLightColor /* None */,
    float MainLightIntensity /* None */,
    float MainLightIndirectIntensity /* None */,
    float MainLightShadowStrength /* None */,
    ColorRGBA SkyAmbientColor /* None */,
    ColorRGBA EquatorAmbientColor /* None */,
    ColorRGBA GroundAmbientColor /* None */,
    PPtr<Material> SkyboxMaterial /* None */,
    ColorRGBA SkyboxColor /* None */,
    ColorRGBA SkyboxSkyTint /* None */,
    ColorRGBA SkyboxGround /* None */,
    float SkyboxExposure /* None */,
    float SkyboxRotation /* None */,
    ColorRGBA FogColor /* None */,
    float FogStartDistance /* None */,
    float FogEndDistance /* None */,
    PPtr<VolumeProfile> PpProfile /* None */,
    PPtr<Material>[] ArCombatGridOverrideMaterials /* None */)
{
    public static SceneLightConfig Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* MainLightRotation */
        Vector3f _MainLightRotation = Vector3f.Read(reader);
        ColorRGBA _MainLightColor = ColorRGBA.Read(reader);
        float _MainLightIntensity = reader.ReadF32();
        float _MainLightIndirectIntensity = reader.ReadF32();
        float _MainLightShadowStrength = reader.ReadF32();
        ColorRGBA _SkyAmbientColor = ColorRGBA.Read(reader);
        ColorRGBA _EquatorAmbientColor = ColorRGBA.Read(reader);
        ColorRGBA _GroundAmbientColor = ColorRGBA.Read(reader);
        PPtr<Material> _SkyboxMaterial = PPtr<Material>.Read(reader);
        ColorRGBA _SkyboxColor = ColorRGBA.Read(reader);
        ColorRGBA _SkyboxSkyTint = ColorRGBA.Read(reader);
        ColorRGBA _SkyboxGround = ColorRGBA.Read(reader);
        float _SkyboxExposure = reader.ReadF32();
        float _SkyboxRotation = reader.ReadF32();
        ColorRGBA _FogColor = ColorRGBA.Read(reader);
        float _FogStartDistance = reader.ReadF32();
        float _FogEndDistance = reader.ReadF32();
        PPtr<VolumeProfile> _PpProfile = PPtr<VolumeProfile>.Read(reader);
        PPtr<Material>[] _ArCombatGridOverrideMaterials = BuiltInArray<PPtr<Material>>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _MainLightRotation,
            _MainLightColor,
            _MainLightIntensity,
            _MainLightIndirectIntensity,
            _MainLightShadowStrength,
            _SkyAmbientColor,
            _EquatorAmbientColor,
            _GroundAmbientColor,
            _SkyboxMaterial,
            _SkyboxColor,
            _SkyboxSkyTint,
            _SkyboxGround,
            _SkyboxExposure,
            _SkyboxRotation,
            _FogColor,
            _FogStartDistance,
            _FogEndDistance,
            _PpProfile,
            _ArCombatGridOverrideMaterials);
    }
}


namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $OwlcatAdditionalLightData (17 fields) D7BC93139FC0CF9D9F95D6E6E4FBD976/9B597E05B8664C0DDE3398C1C7BE6788 */
public record class OwlcatAdditionalLightData(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    byte m_UsePipelineSettings /* NeedsAlign */,
    float m_InnerRadius /* NeedsAlign */,
    int m_FalloffType /* None */,
    byte m_SnapSpecularToInnerRadius /* None */,
    int m_LightLayerMask /* NeedsAlign */,
    byte m_VolumetricLighting /* None */,
    float m_VolumetricIntensity /* NeedsAlign */,
    byte m_VolumetricShadows /* None */,
    Vector2f m_LightCookieSize /* NeedsAlign */,
    Vector2f m_LightCookieOffset /* None */,
    int m_ShadowmapUpdateMode /* None */,
    byte m_ShadowmapAlwaysDrawDynamicShadowCasters /* None */,
    byte m_ShadowmapUpdateOnLightMovement /* NeedsAlign */)
{
    public static OwlcatAdditionalLightData Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_UsePipelineSettings */
        byte _m_UsePipelineSettings = reader.ReadU8();
        reader.AlignTo(4); /* m_InnerRadius */
        float _m_InnerRadius = reader.ReadF32();
        int _m_FalloffType = reader.ReadS32();
        byte _m_SnapSpecularToInnerRadius = reader.ReadU8();
        reader.AlignTo(4); /* m_LightLayerMask */
        int _m_LightLayerMask = reader.ReadS32();
        byte _m_VolumetricLighting = reader.ReadU8();
        reader.AlignTo(4); /* m_VolumetricIntensity */
        float _m_VolumetricIntensity = reader.ReadF32();
        byte _m_VolumetricShadows = reader.ReadU8();
        reader.AlignTo(4); /* m_LightCookieSize */
        Vector2f _m_LightCookieSize = Vector2f.Read(reader);
        Vector2f _m_LightCookieOffset = Vector2f.Read(reader);
        int _m_ShadowmapUpdateMode = reader.ReadS32();
        byte _m_ShadowmapAlwaysDrawDynamicShadowCasters = reader.ReadU8();
        reader.AlignTo(4); /* m_ShadowmapUpdateOnLightMovement */
        byte _m_ShadowmapUpdateOnLightMovement = reader.ReadU8();
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_UsePipelineSettings,
            _m_InnerRadius,
            _m_FalloffType,
            _m_SnapSpecularToInnerRadius,
            _m_LightLayerMask,
            _m_VolumetricLighting,
            _m_VolumetricIntensity,
            _m_VolumetricShadows,
            _m_LightCookieSize,
            _m_LightCookieOffset,
            _m_ShadowmapUpdateMode,
            _m_ShadowmapAlwaysDrawDynamicShadowCasters,
            _m_ShadowmapUpdateOnLightMovement);
    }
}


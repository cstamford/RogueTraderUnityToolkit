namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $WeatherProfile (11 fields) C52D301527C42EFA010CEAC60615E992/82A480853CA46DE674170E859DCC81B3 */
public record class WeatherProfile(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    SeasonalData m_SeasonalData /* NeedsAlign */,
    WeatherMinMaxArray m_InclemencyIntensityRanges /* NeedsAlign */,
    PPtr<WeatherLayer>[] m_Layers /* NeedsAlign */,
    PPtr<WeatherCustomEntitySettings>[] m_CustomEffects /* None */,
    WeatherDirectionalLightSettings m_DirectionalLightSettings /* None */,
    PPtr<WindProfile> m_WindProfile /* NeedsAlign */,
    VFXLocationWeatherDataProfile m_BakeProfile /* None */)
{
    public static WeatherProfile Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_SeasonalData */
        SeasonalData _m_SeasonalData = SeasonalData.Read(reader);
        reader.AlignTo(4); /* m_InclemencyIntensityRanges */
        WeatherMinMaxArray _m_InclemencyIntensityRanges = WeatherMinMaxArray.Read(reader);
        reader.AlignTo(4); /* m_Layers */
        PPtr<WeatherLayer>[] _m_Layers = BuiltInArray<PPtr<WeatherLayer>>.Read(reader);
        PPtr<WeatherCustomEntitySettings>[] _m_CustomEffects = BuiltInArray<PPtr<WeatherCustomEntitySettings>>.Read(reader);
        WeatherDirectionalLightSettings _m_DirectionalLightSettings = WeatherDirectionalLightSettings.Read(reader);
        reader.AlignTo(4); /* m_WindProfile */
        PPtr<WindProfile> _m_WindProfile = PPtr<WindProfile>.Read(reader);
        VFXLocationWeatherDataProfile _m_BakeProfile = VFXLocationWeatherDataProfile.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_SeasonalData,
            _m_InclemencyIntensityRanges,
            _m_Layers,
            _m_CustomEffects,
            _m_DirectionalLightSettings,
            _m_WindProfile,
            _m_BakeProfile);
    }
}


namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $WindProfile (11 fields) 87394293443ED78DF20B95E270CF80DC/0F5CA8461B4426B90F1E32E4A148F374 */
public record class WindProfile(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    SeasonalData m_SeasonalData /* NeedsAlign */,
    WeatherMinMaxArray WindIntensityRanges /* NeedsAlign */,
    WeatherArray WindLerpValues /* NeedsAlign */,
    NoiseSettings StrengthNoiseSettings /* NeedsAlign */,
    NoiseSettings ShiftNoiseSettings /* None */,
    float StrengthNoiseWeight /* None */,
    float StrengthNoiseContrast /* None */)
{
    public static WindProfile Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_SeasonalData */
        SeasonalData _m_SeasonalData = SeasonalData.Read(reader);
        reader.AlignTo(4); /* WindIntensityRanges */
        WeatherMinMaxArray _WindIntensityRanges = WeatherMinMaxArray.Read(reader);
        reader.AlignTo(4); /* WindLerpValues */
        WeatherArray _WindLerpValues = WeatherArray.Read(reader);
        reader.AlignTo(4); /* StrengthNoiseSettings */
        NoiseSettings _StrengthNoiseSettings = NoiseSettings.Read(reader);
        NoiseSettings _ShiftNoiseSettings = NoiseSettings.Read(reader);
        float _StrengthNoiseWeight = reader.ReadF32();
        float _StrengthNoiseContrast = reader.ReadF32();
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_SeasonalData,
            _WindIntensityRanges,
            _WindLerpValues,
            _StrengthNoiseSettings,
            _ShiftNoiseSettings,
            _StrengthNoiseWeight,
            _StrengthNoiseContrast);
    }
}


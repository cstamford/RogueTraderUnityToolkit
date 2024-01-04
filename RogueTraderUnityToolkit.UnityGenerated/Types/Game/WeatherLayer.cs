namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $WeatherLayer (9 fields) C9C85D093A50C23C3321A668ABCEE28E/24A882311643E26FA925D04EB1687509 */
public record class WeatherLayer(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    FogSettings FogSettings /* NeedsAlign */,
    DecalSettings DecalSettings /* NeedsAlign */,
    PostProcessVolumeSettings PostProcessVolumeSettings /* NeedsAlign */,
    WeatherEffect[] Effects /* NeedsAlign */,
    PPtr<WeatherCustomEntitySettings>[] CustomEffects /* NeedsAlign */)
{
    public static WeatherLayer Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* FogSettings */
        FogSettings _FogSettings = FogSettings.Read(reader);
        reader.AlignTo(4); /* DecalSettings */
        DecalSettings _DecalSettings = DecalSettings.Read(reader);
        reader.AlignTo(4); /* PostProcessVolumeSettings */
        PostProcessVolumeSettings _PostProcessVolumeSettings = PostProcessVolumeSettings.Read(reader);
        reader.AlignTo(4); /* Effects */
        WeatherEffect[] _Effects = BuiltInArray<WeatherEffect>.Read(reader);
        reader.AlignTo(4); /* CustomEffects */
        PPtr<WeatherCustomEntitySettings>[] _CustomEffects = BuiltInArray<PPtr<WeatherCustomEntitySettings>>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _FogSettings,
            _DecalSettings,
            _PostProcessVolumeSettings,
            _Effects,
            _CustomEffects);
    }
}


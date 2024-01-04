namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $WeatherThunderSettings (8 fields) E837845F225E181AA6CDCC6081EF979C/C1FC1A32DCCE02C705DDF6776C372B46 */
public record class WeatherThunderSettings(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    AnimationCurve EmissionRateMinOverIntensity /* NeedsAlign */,
    AnimationCurve EmissionRateMaxOverIntensity /* NeedsAlign */,
    AnimationCurve AlphaOverIntensity /* NeedsAlign */,
    PPtr<ParticleSystem> ThunderPrefab /* NeedsAlign */)
{
    public static WeatherThunderSettings Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* EmissionRateMinOverIntensity */
        AnimationCurve _EmissionRateMinOverIntensity = AnimationCurve.Read(reader);
        reader.AlignTo(4); /* EmissionRateMaxOverIntensity */
        AnimationCurve _EmissionRateMaxOverIntensity = AnimationCurve.Read(reader);
        reader.AlignTo(4); /* AlphaOverIntensity */
        AnimationCurve _AlphaOverIntensity = AnimationCurve.Read(reader);
        reader.AlignTo(4); /* ThunderPrefab */
        PPtr<ParticleSystem> _ThunderPrefab = PPtr<ParticleSystem>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _EmissionRateMinOverIntensity,
            _EmissionRateMaxOverIntensity,
            _AlphaOverIntensity,
            _ThunderPrefab);
    }
}


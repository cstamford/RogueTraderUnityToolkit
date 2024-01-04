namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $WeatherLightningBoltSettings (8 fields) 7E345894C3B1E6D1BAC0511310D8FE55/F124F283D1A8B01C9369717DDF9154AA */
public record class WeatherLightningBoltSettings(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    AnimationCurve EmissionRateMinOverIntensity /* NeedsAlign */,
    AnimationCurve EmissionRateMaxOverIntensity /* NeedsAlign */,
    BitField RaycastMask /* NeedsAlign */,
    PPtr<GameObject> LightningBoltPrefab /* None */)
{
    public static WeatherLightningBoltSettings Read(EndianBinaryReader reader)
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
        reader.AlignTo(4); /* RaycastMask */
        BitField _RaycastMask = BitField.Read(reader);
        PPtr<GameObject> _LightningBoltPrefab = PPtr<GameObject>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _EmissionRateMinOverIntensity,
            _EmissionRateMaxOverIntensity,
            _RaycastMask,
            _LightningBoltPrefab);
    }
}


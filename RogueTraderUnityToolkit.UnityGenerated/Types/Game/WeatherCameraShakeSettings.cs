namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $WeatherCameraShakeSettings (7 fields) 10C2E22C340D55E56599572C0ECB962A/6E024BA62AD342DCA3915668FD0D9DC5 */
public record class WeatherCameraShakeSettings(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<CameraShakeFx> CameraShakeFxPrefab /* NeedsAlign */,
    AnimationCurve AmplitudeOverIntensity /* None */,
    AnimationCurve FreqOverIntensity /* NeedsAlign */)
{
    public static WeatherCameraShakeSettings Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* CameraShakeFxPrefab */
        PPtr<CameraShakeFx> _CameraShakeFxPrefab = PPtr<CameraShakeFx>.Read(reader);
        AnimationCurve _AmplitudeOverIntensity = AnimationCurve.Read(reader);
        reader.AlignTo(4); /* FreqOverIntensity */
        AnimationCurve _FreqOverIntensity = AnimationCurve.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _CameraShakeFxPrefab,
            _AmplitudeOverIntensity,
            _FreqOverIntensity);
    }
}


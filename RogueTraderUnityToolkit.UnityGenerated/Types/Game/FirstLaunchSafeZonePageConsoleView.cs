namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $FirstLaunchSafeZonePageConsoleView (6 fields) 42AE35E50752AF2379BFCB4FD857AEC1/0FC59225E79DDE65383F0F162A76C670 */
public record class FirstLaunchSafeZonePageConsoleView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<SettingsEntitySliderConsoleView> m_OffsetSlider /* NeedsAlign */,
    PPtr<RectTransform> m_Frame /* None */)
{
    public static FirstLaunchSafeZonePageConsoleView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_OffsetSlider */
        PPtr<SettingsEntitySliderConsoleView> _m_OffsetSlider = PPtr<SettingsEntitySliderConsoleView>.Read(reader);
        PPtr<RectTransform> _m_Frame = PPtr<RectTransform>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_OffsetSlider,
            _m_Frame);
    }
}


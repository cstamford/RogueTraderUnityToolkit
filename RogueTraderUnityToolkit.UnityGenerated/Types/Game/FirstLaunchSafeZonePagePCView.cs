namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $FirstLaunchSafeZonePagePCView (6 fields) E80B3A326B903A425B74CF30C63285A3/725A1CF1DE47D2E51DC57BE6467F3355 */
public record class FirstLaunchSafeZonePagePCView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<SettingsEntitySliderPCView> m_OffsetSlider /* NeedsAlign */,
    PPtr<RectTransform> m_Frame /* None */)
{
    public static FirstLaunchSafeZonePagePCView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_OffsetSlider */
        PPtr<SettingsEntitySliderPCView> _m_OffsetSlider = PPtr<SettingsEntitySliderPCView>.Read(reader);
        PPtr<RectTransform> _m_Frame = PPtr<RectTransform>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_OffsetSlider,
            _m_Frame);
    }
}


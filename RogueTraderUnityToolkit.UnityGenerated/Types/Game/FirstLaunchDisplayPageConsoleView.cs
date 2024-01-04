namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $FirstLaunchDisplayPageConsoleView (11 fields) D0B27F47A38C38CBE6F092C2F85986D9/98C062763C04D76327B600087C3FCEBB */
public record class FirstLaunchDisplayPageConsoleView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<InfoSectionView> m_InfoView /* NeedsAlign */,
    PPtr<SettingsEntitySliderGammaCorrectionConsoleView> m_SettingsEntitySliderGammaCorrectionConsoleView /* None */,
    PPtr<SettingsEntitySliderGammaCorrectionConsoleView> m_SettingsEntitySliderBrightnessConsoleView /* None */,
    PPtr<SettingsEntitySliderGammaCorrectionConsoleView> m_SettingsEntitySliderContrastConsoleView /* None */,
    PPtr<TextMeshProUGUI> m_DisplayImageText_1 /* None */,
    PPtr<TextMeshProUGUI> m_DisplayImageText_2 /* None */,
    PPtr<TextMeshProUGUI> m_DisplayImageText_3 /* None */)
{
    public static FirstLaunchDisplayPageConsoleView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_InfoView */
        PPtr<InfoSectionView> _m_InfoView = PPtr<InfoSectionView>.Read(reader);
        PPtr<SettingsEntitySliderGammaCorrectionConsoleView> _m_SettingsEntitySliderGammaCorrectionConsoleView = PPtr<SettingsEntitySliderGammaCorrectionConsoleView>.Read(reader);
        PPtr<SettingsEntitySliderGammaCorrectionConsoleView> _m_SettingsEntitySliderBrightnessConsoleView = PPtr<SettingsEntitySliderGammaCorrectionConsoleView>.Read(reader);
        PPtr<SettingsEntitySliderGammaCorrectionConsoleView> _m_SettingsEntitySliderContrastConsoleView = PPtr<SettingsEntitySliderGammaCorrectionConsoleView>.Read(reader);
        PPtr<TextMeshProUGUI> _m_DisplayImageText_1 = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<TextMeshProUGUI> _m_DisplayImageText_2 = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<TextMeshProUGUI> _m_DisplayImageText_3 = PPtr<TextMeshProUGUI>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_InfoView,
            _m_SettingsEntitySliderGammaCorrectionConsoleView,
            _m_SettingsEntitySliderBrightnessConsoleView,
            _m_SettingsEntitySliderContrastConsoleView,
            _m_DisplayImageText_1,
            _m_DisplayImageText_2,
            _m_DisplayImageText_3);
    }
}


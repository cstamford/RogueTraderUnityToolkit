namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $FirstLaunchDisplayPagePCView (11 fields) B9CB0840FCB114E0E8E7114154194BBF/65A752BAC577B4DA5E9F5A66D84FD993 */
public record class FirstLaunchDisplayPagePCView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<InfoSectionView> m_InfoView /* NeedsAlign */,
    PPtr<SettingsEntitySliderGammaCorrectionPCView> m_SettingsEntitySliderGammaCorrectionPCView /* None */,
    PPtr<SettingsEntitySliderGammaCorrectionPCView> m_SettingsEntitySliderBrightnessPCView /* None */,
    PPtr<SettingsEntitySliderGammaCorrectionPCView> m_SettingsEntitySliderContrastPCView /* None */,
    PPtr<TextMeshProUGUI> m_DisplayImageText_1 /* None */,
    PPtr<TextMeshProUGUI> m_DisplayImageText_2 /* None */,
    PPtr<TextMeshProUGUI> m_DisplayImageText_3 /* None */)
{
    public static FirstLaunchDisplayPagePCView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_InfoView */
        PPtr<InfoSectionView> _m_InfoView = PPtr<InfoSectionView>.Read(reader);
        PPtr<SettingsEntitySliderGammaCorrectionPCView> _m_SettingsEntitySliderGammaCorrectionPCView = PPtr<SettingsEntitySliderGammaCorrectionPCView>.Read(reader);
        PPtr<SettingsEntitySliderGammaCorrectionPCView> _m_SettingsEntitySliderBrightnessPCView = PPtr<SettingsEntitySliderGammaCorrectionPCView>.Read(reader);
        PPtr<SettingsEntitySliderGammaCorrectionPCView> _m_SettingsEntitySliderContrastPCView = PPtr<SettingsEntitySliderGammaCorrectionPCView>.Read(reader);
        PPtr<TextMeshProUGUI> _m_DisplayImageText_1 = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<TextMeshProUGUI> _m_DisplayImageText_2 = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<TextMeshProUGUI> _m_DisplayImageText_3 = PPtr<TextMeshProUGUI>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_InfoView,
            _m_SettingsEntitySliderGammaCorrectionPCView,
            _m_SettingsEntitySliderBrightnessPCView,
            _m_SettingsEntitySliderContrastPCView,
            _m_DisplayImageText_1,
            _m_DisplayImageText_2,
            _m_DisplayImageText_3);
    }
}


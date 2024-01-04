namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $FirstLaunchAccessibilityPageConsoleView (9 fields) D7182396FAC966AD4F485367A8A062FF/B420CB7C268A01D27BE32D57775BEEE1 */
public record class FirstLaunchAccessibilityPageConsoleView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<InfoSectionView> m_InfoView /* NeedsAlign */,
    PPtr<SettingsEntitySliderFontSizeConsoleView> m_SettingsEntitySliderFontSizeConsoleView /* None */,
    PPtr<SettingsEntitySliderConsoleView> m_SettingsEntitySliderProtanopiaConsoleView /* None */,
    PPtr<SettingsEntitySliderConsoleView> m_SettingsEntitySliderDeuteranopiaConsoleView /* None */,
    PPtr<SettingsEntitySliderConsoleView> m_SettingsEntitySliderTritanopiaConsoleView /* None */)
{
    public static FirstLaunchAccessibilityPageConsoleView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_InfoView */
        PPtr<InfoSectionView> _m_InfoView = PPtr<InfoSectionView>.Read(reader);
        PPtr<SettingsEntitySliderFontSizeConsoleView> _m_SettingsEntitySliderFontSizeConsoleView = PPtr<SettingsEntitySliderFontSizeConsoleView>.Read(reader);
        PPtr<SettingsEntitySliderConsoleView> _m_SettingsEntitySliderProtanopiaConsoleView = PPtr<SettingsEntitySliderConsoleView>.Read(reader);
        PPtr<SettingsEntitySliderConsoleView> _m_SettingsEntitySliderDeuteranopiaConsoleView = PPtr<SettingsEntitySliderConsoleView>.Read(reader);
        PPtr<SettingsEntitySliderConsoleView> _m_SettingsEntitySliderTritanopiaConsoleView = PPtr<SettingsEntitySliderConsoleView>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_InfoView,
            _m_SettingsEntitySliderFontSizeConsoleView,
            _m_SettingsEntitySliderProtanopiaConsoleView,
            _m_SettingsEntitySliderDeuteranopiaConsoleView,
            _m_SettingsEntitySliderTritanopiaConsoleView);
    }
}


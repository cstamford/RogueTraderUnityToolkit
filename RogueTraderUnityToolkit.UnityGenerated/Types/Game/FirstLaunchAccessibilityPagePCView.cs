namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $FirstLaunchAccessibilityPagePCView (9 fields) E30864C8F25F38A40EB0F3550B2BCC76/0C88A176227F3DB7726C123093F5A2F5 */
public record class FirstLaunchAccessibilityPagePCView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<InfoSectionView> m_InfoView /* NeedsAlign */,
    PPtr<SettingsEntitySliderFontSizePCView> m_SettingsEntitySliderFontSizePCView /* None */,
    PPtr<SettingsEntitySliderPCView> m_SettingsEntitySliderProtanopiaPCView /* None */,
    PPtr<SettingsEntitySliderPCView> m_SettingsEntitySliderDeuteranopiaPCView /* None */,
    PPtr<SettingsEntitySliderPCView> m_SettingsEntitySliderTritanopiaPCView /* None */)
{
    public static FirstLaunchAccessibilityPagePCView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_InfoView */
        PPtr<InfoSectionView> _m_InfoView = PPtr<InfoSectionView>.Read(reader);
        PPtr<SettingsEntitySliderFontSizePCView> _m_SettingsEntitySliderFontSizePCView = PPtr<SettingsEntitySliderFontSizePCView>.Read(reader);
        PPtr<SettingsEntitySliderPCView> _m_SettingsEntitySliderProtanopiaPCView = PPtr<SettingsEntitySliderPCView>.Read(reader);
        PPtr<SettingsEntitySliderPCView> _m_SettingsEntitySliderDeuteranopiaPCView = PPtr<SettingsEntitySliderPCView>.Read(reader);
        PPtr<SettingsEntitySliderPCView> _m_SettingsEntitySliderTritanopiaPCView = PPtr<SettingsEntitySliderPCView>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_InfoView,
            _m_SettingsEntitySliderFontSizePCView,
            _m_SettingsEntitySliderProtanopiaPCView,
            _m_SettingsEntitySliderDeuteranopiaPCView,
            _m_SettingsEntitySliderTritanopiaPCView);
    }
}


namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $FirstLaunchSettingsConsoleView (17 fields) 684449D103995DD9BA0284622449F0B8/2A56AF23A277E4082A96067E87981F50 */
public record class FirstLaunchSettingsConsoleView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<FadeAnimator> m_Animator /* NeedsAlign */,
    PPtr<CanvasGroup> m_AdditionalCanvasGroup /* None */,
    ScreenUnit m_PhotosensitivityUnit /* None */,
    PPtr<SettingsMenuSelectorConsoleView> m_MenuSelector /* NeedsAlign */,
    PPtr<FirstLaunchLanguagePageConsoleView> m_LanguagePageConsoleView /* None */,
    PPtr<FirstLaunchSafeZonePageConsoleView> m_SafeZonePageConsoleView /* None */,
    PPtr<FirstLaunchDisplayPageConsoleView> m_DisplayPageConsoleView /* None */,
    PPtr<FirstLaunchAccessibilityPageConsoleView> m_AccessibilityPageConsoleView /* None */,
    PPtr<ConsoleHint> m_PrevHint /* None */,
    PPtr<ConsoleHint> m_NextHint /* None */,
    PPtr<ConsoleHint> m_HorizontalDPadHint /* None */,
    PPtr<ConsoleHint> m_VerticalDPadHint /* None */,
    PPtr<ConsoleHintsWidget> m_ConsoleHintsWidget /* None */)
{
    public static FirstLaunchSettingsConsoleView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_Animator */
        PPtr<FadeAnimator> _m_Animator = PPtr<FadeAnimator>.Read(reader);
        PPtr<CanvasGroup> _m_AdditionalCanvasGroup = PPtr<CanvasGroup>.Read(reader);
        ScreenUnit _m_PhotosensitivityUnit = ScreenUnit.Read(reader);
        reader.AlignTo(4); /* m_MenuSelector */
        PPtr<SettingsMenuSelectorConsoleView> _m_MenuSelector = PPtr<SettingsMenuSelectorConsoleView>.Read(reader);
        PPtr<FirstLaunchLanguagePageConsoleView> _m_LanguagePageConsoleView = PPtr<FirstLaunchLanguagePageConsoleView>.Read(reader);
        PPtr<FirstLaunchSafeZonePageConsoleView> _m_SafeZonePageConsoleView = PPtr<FirstLaunchSafeZonePageConsoleView>.Read(reader);
        PPtr<FirstLaunchDisplayPageConsoleView> _m_DisplayPageConsoleView = PPtr<FirstLaunchDisplayPageConsoleView>.Read(reader);
        PPtr<FirstLaunchAccessibilityPageConsoleView> _m_AccessibilityPageConsoleView = PPtr<FirstLaunchAccessibilityPageConsoleView>.Read(reader);
        PPtr<ConsoleHint> _m_PrevHint = PPtr<ConsoleHint>.Read(reader);
        PPtr<ConsoleHint> _m_NextHint = PPtr<ConsoleHint>.Read(reader);
        PPtr<ConsoleHint> _m_HorizontalDPadHint = PPtr<ConsoleHint>.Read(reader);
        PPtr<ConsoleHint> _m_VerticalDPadHint = PPtr<ConsoleHint>.Read(reader);
        PPtr<ConsoleHintsWidget> _m_ConsoleHintsWidget = PPtr<ConsoleHintsWidget>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_Animator,
            _m_AdditionalCanvasGroup,
            _m_PhotosensitivityUnit,
            _m_MenuSelector,
            _m_LanguagePageConsoleView,
            _m_SafeZonePageConsoleView,
            _m_DisplayPageConsoleView,
            _m_AccessibilityPageConsoleView,
            _m_PrevHint,
            _m_NextHint,
            _m_HorizontalDPadHint,
            _m_VerticalDPadHint,
            _m_ConsoleHintsWidget);
    }
}


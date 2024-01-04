namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $FirstLaunchSettingsPCView (17 fields) AC64B863F1097F909D7EF6C8BF87BAF5/BB48091D9038C9F48179AF8A06375033 */
public record class FirstLaunchSettingsPCView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<FadeAnimator> m_Animator /* NeedsAlign */,
    PPtr<CanvasGroup> m_AdditionalCanvasGroup /* None */,
    ScreenUnit m_PhotosensitivityUnit /* None */,
    PPtr<SettingsMenuSelectorPCView> m_MenuSelector /* NeedsAlign */,
    PPtr<FirstLaunchLanguagePagePCView> m_LanguagePagePCView /* None */,
    PPtr<FirstLaunchDisplayPagePCView> m_DisplayPagePCView /* None */,
    PPtr<FirstLaunchAccessibilityPagePCView> m_AccessibilityPagePCView /* None */,
    PPtr<OwlcatButton> m_BackButton /* None */,
    PPtr<OwlcatButton> m_ResetToDefaultButton /* None */,
    PPtr<OwlcatButton> m_ContinueButton /* None */,
    PPtr<TextMeshProUGUI> m_BackText /* None */,
    PPtr<TextMeshProUGUI> m_ResetToDefaultText /* None */,
    PPtr<TextMeshProUGUI> m_ContinueText /* None */)
{
    public static FirstLaunchSettingsPCView Read(EndianBinaryReader reader)
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
        PPtr<SettingsMenuSelectorPCView> _m_MenuSelector = PPtr<SettingsMenuSelectorPCView>.Read(reader);
        PPtr<FirstLaunchLanguagePagePCView> _m_LanguagePagePCView = PPtr<FirstLaunchLanguagePagePCView>.Read(reader);
        PPtr<FirstLaunchDisplayPagePCView> _m_DisplayPagePCView = PPtr<FirstLaunchDisplayPagePCView>.Read(reader);
        PPtr<FirstLaunchAccessibilityPagePCView> _m_AccessibilityPagePCView = PPtr<FirstLaunchAccessibilityPagePCView>.Read(reader);
        PPtr<OwlcatButton> _m_BackButton = PPtr<OwlcatButton>.Read(reader);
        PPtr<OwlcatButton> _m_ResetToDefaultButton = PPtr<OwlcatButton>.Read(reader);
        PPtr<OwlcatButton> _m_ContinueButton = PPtr<OwlcatButton>.Read(reader);
        PPtr<TextMeshProUGUI> _m_BackText = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<TextMeshProUGUI> _m_ResetToDefaultText = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<TextMeshProUGUI> _m_ContinueText = PPtr<TextMeshProUGUI>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_Animator,
            _m_AdditionalCanvasGroup,
            _m_PhotosensitivityUnit,
            _m_MenuSelector,
            _m_LanguagePagePCView,
            _m_DisplayPagePCView,
            _m_AccessibilityPagePCView,
            _m_BackButton,
            _m_ResetToDefaultButton,
            _m_ContinueButton,
            _m_BackText,
            _m_ResetToDefaultText,
            _m_ContinueText);
    }
}


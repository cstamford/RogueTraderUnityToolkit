namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $TutorialBigWindowConsoleView (35 fields) BE656A0F7023D27F75C58997B76B6AFA/D174D23444A9C54CD16BFCF625829D6F */
public record class TutorialBigWindowConsoleView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<TextMeshProUGUI> m_Title /* NeedsAlign */,
    PPtr<GameObject> m_ImageContainer /* None */,
    PPtr<Image> m_Image /* None */,
    PPtr<VideoPlayerHelper> m_VideoPlayerHelper /* None */,
    PPtr<Sprite> m_DefaultSprite /* None */,
    PPtr<TextMeshProUGUI> m_TriggerText /* None */,
    PPtr<TextMeshProUGUI> m_TutorialText /* None */,
    PPtr<TextMeshProUGUI> m_SolutionText /* None */,
    PPtr<OwlcatToggle> m_DontShowToggle /* None */,
    PPtr<TextMeshProUGUI> m_DontShowLabel /* None */,
    PPtr<WindowAnimator> m_WindowAnimator /* None */,
    PPtr<ScrollRectExtended> m_BodyScrollRect /* None */,
    PPtr<RectTransform> m_BodyContentRectTransform /* None */,
    PPtr<ConsoleHint> m_ToggleHint /* None */,
    PPtr<ConsoleHint> m_GlossaryHint /* None */,
    PPtr<ConsoleHint> m_CloseGlossaryHint /* None */,
    PPtr<ConsoleHint> m_EncyclopediaHint /* None */,
    PPtr<OwlcatMultiButton> m_FirstGlossaryFocus /* None */,
    PPtr<OwlcatMultiButton> m_SecondGlossaryFocus /* None */,
    float m_TitleDefaultConsoleFontSize /* None */,
    float m_TriggerDefaultSize /* None */,
    float m_MainTextsDefaultConsoleFontSize /* None */,
    PPtr<GameObject> m_PagesBlock /* None */,
    PPtr<PageNavigationConsole> m_PageNavigation /* None */,
    PPtr<TextMeshProUGUI> m_PageNavigationText /* None */,
    PPtr<ScrollRectExtended> m_ScrollRect /* None */,
    PPtr<TextMeshProUGUI> m_ConfirmButtonText /* None */,
    PPtr<ConsoleHint> m_ConfirmHint /* None */,
    PPtr<ConsoleHint> m_PreviousHint /* None */,
    PPtr<ConsoleHint> m_CloseWindowHint /* None */,
    NavigationParameters m_NavigationParameters /* None */)
{
    public static TutorialBigWindowConsoleView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_Title */
        PPtr<TextMeshProUGUI> _m_Title = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<GameObject> _m_ImageContainer = PPtr<GameObject>.Read(reader);
        PPtr<Image> _m_Image = PPtr<Image>.Read(reader);
        PPtr<VideoPlayerHelper> _m_VideoPlayerHelper = PPtr<VideoPlayerHelper>.Read(reader);
        PPtr<Sprite> _m_DefaultSprite = PPtr<Sprite>.Read(reader);
        PPtr<TextMeshProUGUI> _m_TriggerText = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<TextMeshProUGUI> _m_TutorialText = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<TextMeshProUGUI> _m_SolutionText = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<OwlcatToggle> _m_DontShowToggle = PPtr<OwlcatToggle>.Read(reader);
        PPtr<TextMeshProUGUI> _m_DontShowLabel = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<WindowAnimator> _m_WindowAnimator = PPtr<WindowAnimator>.Read(reader);
        PPtr<ScrollRectExtended> _m_BodyScrollRect = PPtr<ScrollRectExtended>.Read(reader);
        PPtr<RectTransform> _m_BodyContentRectTransform = PPtr<RectTransform>.Read(reader);
        PPtr<ConsoleHint> _m_ToggleHint = PPtr<ConsoleHint>.Read(reader);
        PPtr<ConsoleHint> _m_GlossaryHint = PPtr<ConsoleHint>.Read(reader);
        PPtr<ConsoleHint> _m_CloseGlossaryHint = PPtr<ConsoleHint>.Read(reader);
        PPtr<ConsoleHint> _m_EncyclopediaHint = PPtr<ConsoleHint>.Read(reader);
        PPtr<OwlcatMultiButton> _m_FirstGlossaryFocus = PPtr<OwlcatMultiButton>.Read(reader);
        PPtr<OwlcatMultiButton> _m_SecondGlossaryFocus = PPtr<OwlcatMultiButton>.Read(reader);
        float _m_TitleDefaultConsoleFontSize = reader.ReadF32();
        float _m_TriggerDefaultSize = reader.ReadF32();
        float _m_MainTextsDefaultConsoleFontSize = reader.ReadF32();
        PPtr<GameObject> _m_PagesBlock = PPtr<GameObject>.Read(reader);
        PPtr<PageNavigationConsole> _m_PageNavigation = PPtr<PageNavigationConsole>.Read(reader);
        PPtr<TextMeshProUGUI> _m_PageNavigationText = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<ScrollRectExtended> _m_ScrollRect = PPtr<ScrollRectExtended>.Read(reader);
        PPtr<TextMeshProUGUI> _m_ConfirmButtonText = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<ConsoleHint> _m_ConfirmHint = PPtr<ConsoleHint>.Read(reader);
        PPtr<ConsoleHint> _m_PreviousHint = PPtr<ConsoleHint>.Read(reader);
        PPtr<ConsoleHint> _m_CloseWindowHint = PPtr<ConsoleHint>.Read(reader);
        NavigationParameters _m_NavigationParameters = NavigationParameters.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_Title,
            _m_ImageContainer,
            _m_Image,
            _m_VideoPlayerHelper,
            _m_DefaultSprite,
            _m_TriggerText,
            _m_TutorialText,
            _m_SolutionText,
            _m_DontShowToggle,
            _m_DontShowLabel,
            _m_WindowAnimator,
            _m_BodyScrollRect,
            _m_BodyContentRectTransform,
            _m_ToggleHint,
            _m_GlossaryHint,
            _m_CloseGlossaryHint,
            _m_EncyclopediaHint,
            _m_FirstGlossaryFocus,
            _m_SecondGlossaryFocus,
            _m_TitleDefaultConsoleFontSize,
            _m_TriggerDefaultSize,
            _m_MainTextsDefaultConsoleFontSize,
            _m_PagesBlock,
            _m_PageNavigation,
            _m_PageNavigationText,
            _m_ScrollRect,
            _m_ConfirmButtonText,
            _m_ConfirmHint,
            _m_PreviousHint,
            _m_CloseWindowHint,
            _m_NavigationParameters);
    }
}


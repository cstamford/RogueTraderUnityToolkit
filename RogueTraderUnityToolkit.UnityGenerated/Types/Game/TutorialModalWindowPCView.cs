namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $TutorialModalWindowPCView (31 fields) DAA0FA049F50922A4B76306F91831AFB/759D34AA6A3A9861B9A17E09386BF984 */
public record class TutorialModalWindowPCView(
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
    PPtr<OwlcatMultiButton> m_CloseButton /* None */,
    PPtr<OwlcatButton> m_ConfirmButton /* None */,
    PPtr<TextMeshProUGUI> m_ConfirmButtonText /* None */,
    float m_TitleDefaultSize /* None */,
    float m_TriggerDefaultSize /* None */,
    float m_MainTextsDefaultSize /* None */,
    float m_ConfirmButtonDefaultSize /* None */,
    PPtr<GameObject> m_EncyclopediaBlock /* None */,
    PPtr<OwlcatButton> m_EncyclopediaButton /* None */,
    PPtr<TextMeshProUGUI> m_EncyclopediaButtonText /* None */,
    PPtr<GameObject> m_PagesBlock /* None */,
    PPtr<PageNavigationPC> m_PageNavigation /* None */,
    PPtr<TextMeshProUGUI> m_PageNavigationText /* None */,
    float m_EncyclopediaButtonDefaultSize /* None */)
{
    public static TutorialModalWindowPCView Read(EndianBinaryReader reader)
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
        PPtr<OwlcatMultiButton> _m_CloseButton = PPtr<OwlcatMultiButton>.Read(reader);
        PPtr<OwlcatButton> _m_ConfirmButton = PPtr<OwlcatButton>.Read(reader);
        PPtr<TextMeshProUGUI> _m_ConfirmButtonText = PPtr<TextMeshProUGUI>.Read(reader);
        float _m_TitleDefaultSize = reader.ReadF32();
        float _m_TriggerDefaultSize = reader.ReadF32();
        float _m_MainTextsDefaultSize = reader.ReadF32();
        float _m_ConfirmButtonDefaultSize = reader.ReadF32();
        PPtr<GameObject> _m_EncyclopediaBlock = PPtr<GameObject>.Read(reader);
        PPtr<OwlcatButton> _m_EncyclopediaButton = PPtr<OwlcatButton>.Read(reader);
        PPtr<TextMeshProUGUI> _m_EncyclopediaButtonText = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<GameObject> _m_PagesBlock = PPtr<GameObject>.Read(reader);
        PPtr<PageNavigationPC> _m_PageNavigation = PPtr<PageNavigationPC>.Read(reader);
        PPtr<TextMeshProUGUI> _m_PageNavigationText = PPtr<TextMeshProUGUI>.Read(reader);
        float _m_EncyclopediaButtonDefaultSize = reader.ReadF32();
        
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
            _m_CloseButton,
            _m_ConfirmButton,
            _m_ConfirmButtonText,
            _m_TitleDefaultSize,
            _m_TriggerDefaultSize,
            _m_MainTextsDefaultSize,
            _m_ConfirmButtonDefaultSize,
            _m_EncyclopediaBlock,
            _m_EncyclopediaButton,
            _m_EncyclopediaButtonText,
            _m_PagesBlock,
            _m_PageNavigation,
            _m_PageNavigationText,
            _m_EncyclopediaButtonDefaultSize);
    }
}


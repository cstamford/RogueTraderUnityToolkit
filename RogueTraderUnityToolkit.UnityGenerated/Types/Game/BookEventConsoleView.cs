namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $BookEventConsoleView (30 fields) B387274726F3EF6B8120B7F1D11DC898/662B95E6EEF9E3405174E3F70FAF7755 */
public record class BookEventConsoleView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<FadeAnimator> m_WindowAnimator /* NeedsAlign */,
    PPtr<FadeAnimator> m_ContentAnimator /* None */,
    PPtr<GameObject> m_CuesPanel /* None */,
    PPtr<BookEventCueView> m_CueView /* None */,
    PPtr<ScrollRectExtended> m_CuesScrollRect /* None */,
    PPtr<GameObject> m_AnswersPanel /* None */,
    PPtr<BookEventAnswerView> m_AnswerView /* None */,
    PPtr<Image> m_Picture /* None */,
    PPtr<FadeAnimator> m_PictureAnimator /* None */,
    PPtr<DialogNotificationsPCView> m_DialogNotifications /* None */,
    PPtr<BookEventChooseCharacterPCView> m_BookEventChooseCharacterView /* None */,
    PPtr<TextMeshProUGUI> m_HistoryLabel /* None */,
    PPtr<OwlcatMultiButton> m_OpenHistoryButton /* None */,
    PPtr<OwlcatMultiButton> m_CloseHistoryButton /* None */,
    PPtr<OwlcatMultiButton> m_SwitchHistoryButton /* None */,
    PPtr<Animator> m_SwitchAnimator /* None */,
    PPtr<GameObject> m_CuesHistoryPanel /* None */,
    PPtr<GameObject> m_CuesHistory /* None */,
    PPtr<GameObject> m_Cues /* None */,
    PPtr<ScrollRectExtended> m_CuesHistoryScrollRect /* None */,
    PPtr<GameObject> m_Fade /* None */,
    PPtr<Image> m_MirrorPortrait /* None */,
    PPtr<ConsoleHintsWidget> m_ConsoleHintsWidget /* None */,
    PPtr<OwlcatMultiButton> m_FirstGlossaryFocus /* None */,
    PPtr<OwlcatMultiButton> m_SecondGlossaryFocus /* None */,
    NavigationParameters m_NavigationParameters /* None */)
{
    public static BookEventConsoleView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_WindowAnimator */
        PPtr<FadeAnimator> _m_WindowAnimator = PPtr<FadeAnimator>.Read(reader);
        PPtr<FadeAnimator> _m_ContentAnimator = PPtr<FadeAnimator>.Read(reader);
        PPtr<GameObject> _m_CuesPanel = PPtr<GameObject>.Read(reader);
        PPtr<BookEventCueView> _m_CueView = PPtr<BookEventCueView>.Read(reader);
        PPtr<ScrollRectExtended> _m_CuesScrollRect = PPtr<ScrollRectExtended>.Read(reader);
        PPtr<GameObject> _m_AnswersPanel = PPtr<GameObject>.Read(reader);
        PPtr<BookEventAnswerView> _m_AnswerView = PPtr<BookEventAnswerView>.Read(reader);
        PPtr<Image> _m_Picture = PPtr<Image>.Read(reader);
        PPtr<FadeAnimator> _m_PictureAnimator = PPtr<FadeAnimator>.Read(reader);
        PPtr<DialogNotificationsPCView> _m_DialogNotifications = PPtr<DialogNotificationsPCView>.Read(reader);
        PPtr<BookEventChooseCharacterPCView> _m_BookEventChooseCharacterView = PPtr<BookEventChooseCharacterPCView>.Read(reader);
        PPtr<TextMeshProUGUI> _m_HistoryLabel = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<OwlcatMultiButton> _m_OpenHistoryButton = PPtr<OwlcatMultiButton>.Read(reader);
        PPtr<OwlcatMultiButton> _m_CloseHistoryButton = PPtr<OwlcatMultiButton>.Read(reader);
        PPtr<OwlcatMultiButton> _m_SwitchHistoryButton = PPtr<OwlcatMultiButton>.Read(reader);
        PPtr<Animator> _m_SwitchAnimator = PPtr<Animator>.Read(reader);
        PPtr<GameObject> _m_CuesHistoryPanel = PPtr<GameObject>.Read(reader);
        PPtr<GameObject> _m_CuesHistory = PPtr<GameObject>.Read(reader);
        PPtr<GameObject> _m_Cues = PPtr<GameObject>.Read(reader);
        PPtr<ScrollRectExtended> _m_CuesHistoryScrollRect = PPtr<ScrollRectExtended>.Read(reader);
        PPtr<GameObject> _m_Fade = PPtr<GameObject>.Read(reader);
        PPtr<Image> _m_MirrorPortrait = PPtr<Image>.Read(reader);
        PPtr<ConsoleHintsWidget> _m_ConsoleHintsWidget = PPtr<ConsoleHintsWidget>.Read(reader);
        PPtr<OwlcatMultiButton> _m_FirstGlossaryFocus = PPtr<OwlcatMultiButton>.Read(reader);
        PPtr<OwlcatMultiButton> _m_SecondGlossaryFocus = PPtr<OwlcatMultiButton>.Read(reader);
        NavigationParameters _m_NavigationParameters = NavigationParameters.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_WindowAnimator,
            _m_ContentAnimator,
            _m_CuesPanel,
            _m_CueView,
            _m_CuesScrollRect,
            _m_AnswersPanel,
            _m_AnswerView,
            _m_Picture,
            _m_PictureAnimator,
            _m_DialogNotifications,
            _m_BookEventChooseCharacterView,
            _m_HistoryLabel,
            _m_OpenHistoryButton,
            _m_CloseHistoryButton,
            _m_SwitchHistoryButton,
            _m_SwitchAnimator,
            _m_CuesHistoryPanel,
            _m_CuesHistory,
            _m_Cues,
            _m_CuesHistoryScrollRect,
            _m_Fade,
            _m_MirrorPortrait,
            _m_ConsoleHintsWidget,
            _m_FirstGlossaryFocus,
            _m_SecondGlossaryFocus,
            _m_NavigationParameters);
    }
}


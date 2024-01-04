namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $SurfaceDialogPCView (33 fields) B249673DF291103C3B48204AFFC9BDF9/1AF5BB8BA7ABC9B7D697F82A7C3F9083 */
public record class SurfaceDialogPCView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<TextMeshProUGUI> m_SpeakerName /* NeedsAlign */,
    PPtr<Image> m_SpeakerPortrait /* None */,
    PPtr<RectTransform> m_SpeakerNoPortrait /* None */,
    PPtr<RectTransform> m_SpeakerNoPortraitEqualizerFx /* None */,
    PPtr<CanvasGroup> m_SpeakerGlow /* None */,
    PPtr<ScrollRectExtended> m_SpeakerScrollRect /* None */,
    PPtr<CanvasGroup> m_SpeakerContentCanvasGroup /* None */,
    float m_SpeakerContentFadeTime /* None */,
    PPtr<DialogCuePCView> m_CueView /* None */,
    PPtr<RectTransform> m_CuesTooltipPlace /* None */,
    PPtr<DialogHistoryEntity> m_HistoryEntity /* None */,
    PPtr<RectTransform> m_HistoryContainer /* None */,
    PPtr<DialogNotificationsPCView> m_DialogNotifications /* None */,
    PPtr<TextMeshProUGUI> m_AnswerName /* None */,
    PPtr<Image> m_AnswererPortrait /* None */,
    PPtr<RectTransform> m_AnswererNoPortrait /* None */,
    PPtr<RectTransform> m_AnswerNoPortraitEqualizerFx /* None */,
    PPtr<CanvasGroup> m_AnswererGlow /* None */,
    PPtr<DialogAnswerPCView> m_AnswerView /* None */,
    PPtr<RectTransform> m_AnswerPanel /* None */,
    PPtr<ScrollRectExtended> m_AnswerScrollRect /* None */,
    PPtr<CanvasGroup> m_AnswerContentCanvasGroup /* None */,
    PPtr<FadeAnimator> m_AnswerFadeAnimator /* None */,
    PPtr<RectTransform> m_AnswersTooltipPlace /* None */,
    int m_HidePosY /* None */,
    int m_ShowPosY /* None */,
    PPtr<DialogColorsConfig> m_DialogConfig /* None */,
    PPtr<DialogVotesBlockView> m_TopDialogVotesBlock /* None */,
    PPtr<DialogVotesBlockView> m_BottomDialogVotesBlock /* None */)
{
    public static SurfaceDialogPCView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_SpeakerName */
        PPtr<TextMeshProUGUI> _m_SpeakerName = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<Image> _m_SpeakerPortrait = PPtr<Image>.Read(reader);
        PPtr<RectTransform> _m_SpeakerNoPortrait = PPtr<RectTransform>.Read(reader);
        PPtr<RectTransform> _m_SpeakerNoPortraitEqualizerFx = PPtr<RectTransform>.Read(reader);
        PPtr<CanvasGroup> _m_SpeakerGlow = PPtr<CanvasGroup>.Read(reader);
        PPtr<ScrollRectExtended> _m_SpeakerScrollRect = PPtr<ScrollRectExtended>.Read(reader);
        PPtr<CanvasGroup> _m_SpeakerContentCanvasGroup = PPtr<CanvasGroup>.Read(reader);
        float _m_SpeakerContentFadeTime = reader.ReadF32();
        PPtr<DialogCuePCView> _m_CueView = PPtr<DialogCuePCView>.Read(reader);
        PPtr<RectTransform> _m_CuesTooltipPlace = PPtr<RectTransform>.Read(reader);
        PPtr<DialogHistoryEntity> _m_HistoryEntity = PPtr<DialogHistoryEntity>.Read(reader);
        PPtr<RectTransform> _m_HistoryContainer = PPtr<RectTransform>.Read(reader);
        PPtr<DialogNotificationsPCView> _m_DialogNotifications = PPtr<DialogNotificationsPCView>.Read(reader);
        PPtr<TextMeshProUGUI> _m_AnswerName = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<Image> _m_AnswererPortrait = PPtr<Image>.Read(reader);
        PPtr<RectTransform> _m_AnswererNoPortrait = PPtr<RectTransform>.Read(reader);
        PPtr<RectTransform> _m_AnswerNoPortraitEqualizerFx = PPtr<RectTransform>.Read(reader);
        PPtr<CanvasGroup> _m_AnswererGlow = PPtr<CanvasGroup>.Read(reader);
        PPtr<DialogAnswerPCView> _m_AnswerView = PPtr<DialogAnswerPCView>.Read(reader);
        PPtr<RectTransform> _m_AnswerPanel = PPtr<RectTransform>.Read(reader);
        PPtr<ScrollRectExtended> _m_AnswerScrollRect = PPtr<ScrollRectExtended>.Read(reader);
        PPtr<CanvasGroup> _m_AnswerContentCanvasGroup = PPtr<CanvasGroup>.Read(reader);
        PPtr<FadeAnimator> _m_AnswerFadeAnimator = PPtr<FadeAnimator>.Read(reader);
        PPtr<RectTransform> _m_AnswersTooltipPlace = PPtr<RectTransform>.Read(reader);
        int _m_HidePosY = reader.ReadS32();
        int _m_ShowPosY = reader.ReadS32();
        PPtr<DialogColorsConfig> _m_DialogConfig = PPtr<DialogColorsConfig>.Read(reader);
        PPtr<DialogVotesBlockView> _m_TopDialogVotesBlock = PPtr<DialogVotesBlockView>.Read(reader);
        PPtr<DialogVotesBlockView> _m_BottomDialogVotesBlock = PPtr<DialogVotesBlockView>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_SpeakerName,
            _m_SpeakerPortrait,
            _m_SpeakerNoPortrait,
            _m_SpeakerNoPortraitEqualizerFx,
            _m_SpeakerGlow,
            _m_SpeakerScrollRect,
            _m_SpeakerContentCanvasGroup,
            _m_SpeakerContentFadeTime,
            _m_CueView,
            _m_CuesTooltipPlace,
            _m_HistoryEntity,
            _m_HistoryContainer,
            _m_DialogNotifications,
            _m_AnswerName,
            _m_AnswererPortrait,
            _m_AnswererNoPortrait,
            _m_AnswerNoPortraitEqualizerFx,
            _m_AnswererGlow,
            _m_AnswerView,
            _m_AnswerPanel,
            _m_AnswerScrollRect,
            _m_AnswerContentCanvasGroup,
            _m_AnswerFadeAnimator,
            _m_AnswersTooltipPlace,
            _m_HidePosY,
            _m_ShowPosY,
            _m_DialogConfig,
            _m_TopDialogVotesBlock,
            _m_BottomDialogVotesBlock);
    }
}


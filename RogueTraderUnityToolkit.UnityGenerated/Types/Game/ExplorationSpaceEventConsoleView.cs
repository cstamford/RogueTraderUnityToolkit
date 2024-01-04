namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $ExplorationSpaceEventConsoleView (18 fields) F15176D696F2CC1EC001187960108733/DEE94DBFFF7F12DE721673F229C10599 */
public record class ExplorationSpaceEventConsoleView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<DialogCuePCView> m_CueView /* NeedsAlign */,
    PPtr<DialogAnswerConsoleView> m_AnswerView /* None */,
    PPtr<RectTransform> m_AnswerPanel /* None */,
    PPtr<DialogSystemAnswerConsoleView> m_SystemAnswerView /* None */,
    PPtr<ScrollRectExtended> m_ScrollRect /* None */,
    PPtr<VerticalLayoutGroup> m_CurrentPartLayoutGroup /* None */,
    PPtr<DialogHistoryEntity> m_HistoryEntity /* None */,
    PPtr<RectTransform> m_HistoryContainer /* None */,
    PPtr<DialogNotificationsPCView> m_DialogNotifications /* None */,
    PPtr<FadeAnimator> m_Animator /* None */,
    PPtr<ConsoleHintsWidget> m_ConsoleHintsWidget /* None */,
    PPtr<OwlcatMultiButton> m_FirstGlossaryFocus /* None */,
    PPtr<OwlcatMultiButton> m_SecondGlossaryFocus /* None */,
    NavigationParameters m_NavigationParameters /* None */)
{
    public static ExplorationSpaceEventConsoleView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_CueView */
        PPtr<DialogCuePCView> _m_CueView = PPtr<DialogCuePCView>.Read(reader);
        PPtr<DialogAnswerConsoleView> _m_AnswerView = PPtr<DialogAnswerConsoleView>.Read(reader);
        PPtr<RectTransform> _m_AnswerPanel = PPtr<RectTransform>.Read(reader);
        PPtr<DialogSystemAnswerConsoleView> _m_SystemAnswerView = PPtr<DialogSystemAnswerConsoleView>.Read(reader);
        PPtr<ScrollRectExtended> _m_ScrollRect = PPtr<ScrollRectExtended>.Read(reader);
        PPtr<VerticalLayoutGroup> _m_CurrentPartLayoutGroup = PPtr<VerticalLayoutGroup>.Read(reader);
        PPtr<DialogHistoryEntity> _m_HistoryEntity = PPtr<DialogHistoryEntity>.Read(reader);
        PPtr<RectTransform> _m_HistoryContainer = PPtr<RectTransform>.Read(reader);
        PPtr<DialogNotificationsPCView> _m_DialogNotifications = PPtr<DialogNotificationsPCView>.Read(reader);
        PPtr<FadeAnimator> _m_Animator = PPtr<FadeAnimator>.Read(reader);
        PPtr<ConsoleHintsWidget> _m_ConsoleHintsWidget = PPtr<ConsoleHintsWidget>.Read(reader);
        PPtr<OwlcatMultiButton> _m_FirstGlossaryFocus = PPtr<OwlcatMultiButton>.Read(reader);
        PPtr<OwlcatMultiButton> _m_SecondGlossaryFocus = PPtr<OwlcatMultiButton>.Read(reader);
        NavigationParameters _m_NavigationParameters = NavigationParameters.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_CueView,
            _m_AnswerView,
            _m_AnswerPanel,
            _m_SystemAnswerView,
            _m_ScrollRect,
            _m_CurrentPartLayoutGroup,
            _m_HistoryEntity,
            _m_HistoryContainer,
            _m_DialogNotifications,
            _m_Animator,
            _m_ConsoleHintsWidget,
            _m_FirstGlossaryFocus,
            _m_SecondGlossaryFocus,
            _m_NavigationParameters);
    }
}


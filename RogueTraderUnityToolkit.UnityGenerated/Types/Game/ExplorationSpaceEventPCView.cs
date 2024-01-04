namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $ExplorationSpaceEventPCView (14 fields) 47BB6F48D8A9BBC83B5EBD30F3E48002/70C389F625CF3F57CAEA76E6361327D8 */
public record class ExplorationSpaceEventPCView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<DialogCuePCView> m_CueView /* NeedsAlign */,
    PPtr<DialogAnswerPCView> m_AnswerView /* None */,
    PPtr<RectTransform> m_AnswerPanel /* None */,
    PPtr<DialogSystemAnswerPCView> m_SystemAnswerView /* None */,
    PPtr<ScrollRectExtended> m_ScrollRect /* None */,
    PPtr<VerticalLayoutGroup> m_CurrentPartLayoutGroup /* None */,
    PPtr<DialogHistoryEntity> m_HistoryEntity /* None */,
    PPtr<RectTransform> m_HistoryContainer /* None */,
    PPtr<DialogNotificationsPCView> m_DialogNotifications /* None */,
    PPtr<FadeAnimator> m_Animator /* None */)
{
    public static ExplorationSpaceEventPCView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_CueView */
        PPtr<DialogCuePCView> _m_CueView = PPtr<DialogCuePCView>.Read(reader);
        PPtr<DialogAnswerPCView> _m_AnswerView = PPtr<DialogAnswerPCView>.Read(reader);
        PPtr<RectTransform> _m_AnswerPanel = PPtr<RectTransform>.Read(reader);
        PPtr<DialogSystemAnswerPCView> _m_SystemAnswerView = PPtr<DialogSystemAnswerPCView>.Read(reader);
        PPtr<ScrollRectExtended> _m_ScrollRect = PPtr<ScrollRectExtended>.Read(reader);
        PPtr<VerticalLayoutGroup> _m_CurrentPartLayoutGroup = PPtr<VerticalLayoutGroup>.Read(reader);
        PPtr<DialogHistoryEntity> _m_HistoryEntity = PPtr<DialogHistoryEntity>.Read(reader);
        PPtr<RectTransform> _m_HistoryContainer = PPtr<RectTransform>.Read(reader);
        PPtr<DialogNotificationsPCView> _m_DialogNotifications = PPtr<DialogNotificationsPCView>.Read(reader);
        PPtr<FadeAnimator> _m_Animator = PPtr<FadeAnimator>.Read(reader);
        
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
            _m_Animator);
    }
}


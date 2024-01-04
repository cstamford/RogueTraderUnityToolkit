namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $DialogPCView (20 fields) C10D2A2DAA1235EE1F065FAD8971219C/EAAD4EEC4BE9400AB2A501722E12721F */
public record class DialogPCView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<TextMeshProUGUI> m_AnswerName /* NeedsAlign */,
    PPtr<Image> m_AnswererPortrait /* None */,
    PPtr<TextMeshProUGUI> m_SpeakerName /* None */,
    PPtr<Image> m_SpeakerPortrait /* None */,
    PPtr<Image> m_SpeakerHolder /* None */,
    PPtr<DialogCuePCView> m_CueView /* None */,
    PPtr<DialogAnswerPCView> m_AnswerView /* None */,
    PPtr<RectTransform> m_AnswerPanel /* None */,
    PPtr<DialogSystemAnswerPCView> m_SystemAnswerPCView /* None */,
    PPtr<ScrollRectExtended> m_ScrollRect /* None */,
    PPtr<VerticalLayoutGroup> m_CurrentPartLayoutGroup /* None */,
    PPtr<DialogHistoryEntity> m_HistoryEntity /* None */,
    PPtr<RectTransform> m_HistoryContainer /* None */,
    PPtr<DialogNotificationsPCView> m_DialogNotifications /* None */,
    int m_HidePosY /* None */,
    int m_ShowPosY /* None */)
{
    public static DialogPCView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_AnswerName */
        PPtr<TextMeshProUGUI> _m_AnswerName = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<Image> _m_AnswererPortrait = PPtr<Image>.Read(reader);
        PPtr<TextMeshProUGUI> _m_SpeakerName = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<Image> _m_SpeakerPortrait = PPtr<Image>.Read(reader);
        PPtr<Image> _m_SpeakerHolder = PPtr<Image>.Read(reader);
        PPtr<DialogCuePCView> _m_CueView = PPtr<DialogCuePCView>.Read(reader);
        PPtr<DialogAnswerPCView> _m_AnswerView = PPtr<DialogAnswerPCView>.Read(reader);
        PPtr<RectTransform> _m_AnswerPanel = PPtr<RectTransform>.Read(reader);
        PPtr<DialogSystemAnswerPCView> _m_SystemAnswerPCView = PPtr<DialogSystemAnswerPCView>.Read(reader);
        PPtr<ScrollRectExtended> _m_ScrollRect = PPtr<ScrollRectExtended>.Read(reader);
        PPtr<VerticalLayoutGroup> _m_CurrentPartLayoutGroup = PPtr<VerticalLayoutGroup>.Read(reader);
        PPtr<DialogHistoryEntity> _m_HistoryEntity = PPtr<DialogHistoryEntity>.Read(reader);
        PPtr<RectTransform> _m_HistoryContainer = PPtr<RectTransform>.Read(reader);
        PPtr<DialogNotificationsPCView> _m_DialogNotifications = PPtr<DialogNotificationsPCView>.Read(reader);
        int _m_HidePosY = reader.ReadS32();
        int _m_ShowPosY = reader.ReadS32();
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_AnswerName,
            _m_AnswererPortrait,
            _m_SpeakerName,
            _m_SpeakerPortrait,
            _m_SpeakerHolder,
            _m_CueView,
            _m_AnswerView,
            _m_AnswerPanel,
            _m_SystemAnswerPCView,
            _m_ScrollRect,
            _m_CurrentPartLayoutGroup,
            _m_HistoryEntity,
            _m_HistoryContainer,
            _m_DialogNotifications,
            _m_HidePosY,
            _m_ShowPosY);
    }
}


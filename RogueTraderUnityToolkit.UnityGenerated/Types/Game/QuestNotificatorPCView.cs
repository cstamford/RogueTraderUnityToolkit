namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $QuestNotificatorPCView (13 fields) 6471E8FC940C0186716E5B2B425BAC0A/1FA70B17972D25FDDF7877FF88BB7B32 */
public record class QuestNotificatorPCView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<TextMeshProUGUI> m_Title /* NeedsAlign */,
    PPtr<QuestNotificationQuestView> m_QuestView /* None */,
    PPtr<QuestNotificationObjectivesView> m_ObjectiveView /* None */,
    PPtr<QuestNotificationAddendumView> m_AddendumView /* None */,
    PPtr<WindowAnimator> m_Animator /* None */,
    PPtr<OwlcatButton> m_JournalButton /* None */,
    PPtr<OwlcatButton> m_FullBodyButton /* None */,
    PPtr<OwlcatMultiButton> m_CloseButton /* None */,
    PPtr<TextMeshProUGUI> m_ToJournalButtonLabel /* None */)
{
    public static QuestNotificatorPCView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_Title */
        PPtr<TextMeshProUGUI> _m_Title = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<QuestNotificationQuestView> _m_QuestView = PPtr<QuestNotificationQuestView>.Read(reader);
        PPtr<QuestNotificationObjectivesView> _m_ObjectiveView = PPtr<QuestNotificationObjectivesView>.Read(reader);
        PPtr<QuestNotificationAddendumView> _m_AddendumView = PPtr<QuestNotificationAddendumView>.Read(reader);
        PPtr<WindowAnimator> _m_Animator = PPtr<WindowAnimator>.Read(reader);
        PPtr<OwlcatButton> _m_JournalButton = PPtr<OwlcatButton>.Read(reader);
        PPtr<OwlcatButton> _m_FullBodyButton = PPtr<OwlcatButton>.Read(reader);
        PPtr<OwlcatMultiButton> _m_CloseButton = PPtr<OwlcatMultiButton>.Read(reader);
        PPtr<TextMeshProUGUI> _m_ToJournalButtonLabel = PPtr<TextMeshProUGUI>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_Title,
            _m_QuestView,
            _m_ObjectiveView,
            _m_AddendumView,
            _m_Animator,
            _m_JournalButton,
            _m_FullBodyButton,
            _m_CloseButton,
            _m_ToJournalButtonLabel);
    }
}


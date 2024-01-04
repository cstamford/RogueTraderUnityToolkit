namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $QuestNotificatorConsoleView (11 fields) 093CB0E7A0EC0D5B2DF59AD42A1BBE99/1F771250DDF787201F944FDC06A231D5 */
public record class QuestNotificatorConsoleView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<TextMeshProUGUI> m_Title /* NeedsAlign */,
    PPtr<QuestNotificationQuestView> m_QuestView /* None */,
    PPtr<QuestNotificationObjectivesView> m_ObjectiveView /* None */,
    PPtr<QuestNotificationAddendumView> m_AddendumView /* None */,
    PPtr<WindowAnimator> m_Animator /* None */,
    PPtr<ConsoleHint> m_CloseHint /* None */,
    PPtr<ConsoleHint> m_JournalHint /* None */)
{
    public static QuestNotificatorConsoleView Read(EndianBinaryReader reader)
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
        PPtr<ConsoleHint> _m_CloseHint = PPtr<ConsoleHint>.Read(reader);
        PPtr<ConsoleHint> _m_JournalHint = PPtr<ConsoleHint>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_Title,
            _m_QuestView,
            _m_ObjectiveView,
            _m_AddendumView,
            _m_Animator,
            _m_CloseHint,
            _m_JournalHint);
    }
}


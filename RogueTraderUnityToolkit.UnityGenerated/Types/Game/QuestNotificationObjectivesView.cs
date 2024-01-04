namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $QuestNotificationObjectivesView (12 fields) 000E14C6C9FA0DA291BF143BF28972D3/603390925D18A8BBE10340DD8EFEAE04 */
public record class QuestNotificationObjectivesView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<TextMeshProUGUI> m_Title /* NeedsAlign */,
    PPtr<TextMeshProUGUI> m_Description /* None */,
    PPtr<GameObject> m_FailMark /* None */,
    PPtr<GameObject> m_UpdateMark /* None */,
    PPtr<GameObject> m_PostponeMark /* None */,
    PPtr<GameObject> m_CompleteMark /* None */,
    PPtr<GameObject> m_NewMark /* None */,
    PPtr<QuestNotificationObjectivesView> m_AdditionalObjective /* None */)
{
    public static QuestNotificationObjectivesView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_Title */
        PPtr<TextMeshProUGUI> _m_Title = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<TextMeshProUGUI> _m_Description = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<GameObject> _m_FailMark = PPtr<GameObject>.Read(reader);
        PPtr<GameObject> _m_UpdateMark = PPtr<GameObject>.Read(reader);
        PPtr<GameObject> _m_PostponeMark = PPtr<GameObject>.Read(reader);
        PPtr<GameObject> _m_CompleteMark = PPtr<GameObject>.Read(reader);
        PPtr<GameObject> _m_NewMark = PPtr<GameObject>.Read(reader);
        PPtr<QuestNotificationObjectivesView> _m_AdditionalObjective = PPtr<QuestNotificationObjectivesView>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_Title,
            _m_Description,
            _m_FailMark,
            _m_UpdateMark,
            _m_PostponeMark,
            _m_CompleteMark,
            _m_NewMark,
            _m_AdditionalObjective);
    }
}


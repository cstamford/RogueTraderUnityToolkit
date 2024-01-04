namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $QuestNotificationQuestView (11 fields) CE55F757CB06A95BB0D882F7B0344741/95F3AEAF1C978113A5426069628E191B */
public record class QuestNotificationQuestView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<TextMeshProUGUI> m_StatusLabel /* NeedsAlign */,
    PPtr<TextMeshProUGUI> m_Description /* None */,
    PPtr<GameObject> m_FailMark /* None */,
    PPtr<GameObject> m_CompleteMark /* None */,
    PPtr<GameObject> m_NewMark /* None */,
    PPtr<GameObject> m_UpdatedMark /* None */,
    PPtr<GameObject> m_PostponedMark /* None */)
{
    public static QuestNotificationQuestView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_StatusLabel */
        PPtr<TextMeshProUGUI> _m_StatusLabel = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<TextMeshProUGUI> _m_Description = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<GameObject> _m_FailMark = PPtr<GameObject>.Read(reader);
        PPtr<GameObject> _m_CompleteMark = PPtr<GameObject>.Read(reader);
        PPtr<GameObject> _m_NewMark = PPtr<GameObject>.Read(reader);
        PPtr<GameObject> _m_UpdatedMark = PPtr<GameObject>.Read(reader);
        PPtr<GameObject> _m_PostponedMark = PPtr<GameObject>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_StatusLabel,
            _m_Description,
            _m_FailMark,
            _m_CompleteMark,
            _m_NewMark,
            _m_UpdatedMark,
            _m_PostponedMark);
    }
}


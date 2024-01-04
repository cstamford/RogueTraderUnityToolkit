namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $JournalQuestObjectiveAddendumConsoleView (16 fields) 504B2F98DF15D5FB89F911E46D099716/64A3A261AE32865F4FEC6D591ACF0C1E */
public record class JournalQuestObjectiveAddendumConsoleView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<TextMeshProUGUI> m_Description /* NeedsAlign */,
    PPtr<TextMeshProUGUI> m_EtudeCounter /* None */,
    PPtr<GameObject> m_FailedMark /* None */,
    PPtr<GameObject> m_CompletedMark /* None */,
    PPtr<GameObject> m_AttentionMark /* None */,
    PPtr<GameObject> m_InProgressMark /* None */,
    PPtr<GameObject> m_UpdatedMark /* None */,
    PPtr<GameObject> m_PostponedMark /* None */,
    ColorRGBA m_InProgressColor /* None */,
    ColorRGBA m_CompletedColor /* None */,
    ColorRGBA m_FailedColor /* None */,
    float m_DefaultConsoleFontSize /* None */)
{
    public static JournalQuestObjectiveAddendumConsoleView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_Description */
        PPtr<TextMeshProUGUI> _m_Description = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<TextMeshProUGUI> _m_EtudeCounter = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<GameObject> _m_FailedMark = PPtr<GameObject>.Read(reader);
        PPtr<GameObject> _m_CompletedMark = PPtr<GameObject>.Read(reader);
        PPtr<GameObject> _m_AttentionMark = PPtr<GameObject>.Read(reader);
        PPtr<GameObject> _m_InProgressMark = PPtr<GameObject>.Read(reader);
        PPtr<GameObject> _m_UpdatedMark = PPtr<GameObject>.Read(reader);
        PPtr<GameObject> _m_PostponedMark = PPtr<GameObject>.Read(reader);
        ColorRGBA _m_InProgressColor = ColorRGBA.Read(reader);
        ColorRGBA _m_CompletedColor = ColorRGBA.Read(reader);
        ColorRGBA _m_FailedColor = ColorRGBA.Read(reader);
        float _m_DefaultConsoleFontSize = reader.ReadF32();
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_Description,
            _m_EtudeCounter,
            _m_FailedMark,
            _m_CompletedMark,
            _m_AttentionMark,
            _m_InProgressMark,
            _m_UpdatedMark,
            _m_PostponedMark,
            _m_InProgressColor,
            _m_CompletedColor,
            _m_FailedColor,
            _m_DefaultConsoleFontSize);
    }
}


namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $JournalQuestObjectiveConsoleView (20 fields) FB48CCC572C00156F7A48A49D12DDE99/5FEBCED37B9A0D7DD8A9F028EF477DDA */
public record class JournalQuestObjectiveConsoleView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<TextMeshProUGUI> m_Title /* NeedsAlign */,
    PPtr<TextMeshProUGUI> m_ObjectiveNummer /* None */,
    PPtr<TextMeshProUGUI> m_Description /* None */,
    PPtr<TextMeshProUGUI> m_EtudeCounter /* None */,
    PPtr<TextMeshProUGUI> m_Destination /* None */,
    PPtr<GameObject> m_AttentionMark /* None */,
    PPtr<GameObject> m_FailedMark /* None */,
    PPtr<GameObject> m_CompletedMark /* None */,
    PPtr<GameObject> m_UpdatedMark /* None */,
    PPtr<GameObject> m_PostponedMark /* None */,
    PPtr<GameObject> m_InProgressMark /* None */,
    PPtr<Image> m_DestinationGeoMark /* None */,
    PPtr<ExpandableCollapseMultiButtonConsole> m_ExpandableCollapseMultiButton /* None */,
    PPtr<WidgetListMVVM> m_WidgetList /* None */,
    PPtr<JournalQuestObjectiveAddendumConsoleView> m_AddendumViewPrefab /* None */,
    float m_DefaultConsoleFontSize /* None */)
{
    public static JournalQuestObjectiveConsoleView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_Title */
        PPtr<TextMeshProUGUI> _m_Title = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<TextMeshProUGUI> _m_ObjectiveNummer = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<TextMeshProUGUI> _m_Description = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<TextMeshProUGUI> _m_EtudeCounter = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<TextMeshProUGUI> _m_Destination = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<GameObject> _m_AttentionMark = PPtr<GameObject>.Read(reader);
        PPtr<GameObject> _m_FailedMark = PPtr<GameObject>.Read(reader);
        PPtr<GameObject> _m_CompletedMark = PPtr<GameObject>.Read(reader);
        PPtr<GameObject> _m_UpdatedMark = PPtr<GameObject>.Read(reader);
        PPtr<GameObject> _m_PostponedMark = PPtr<GameObject>.Read(reader);
        PPtr<GameObject> _m_InProgressMark = PPtr<GameObject>.Read(reader);
        PPtr<Image> _m_DestinationGeoMark = PPtr<Image>.Read(reader);
        PPtr<ExpandableCollapseMultiButtonConsole> _m_ExpandableCollapseMultiButton = PPtr<ExpandableCollapseMultiButtonConsole>.Read(reader);
        PPtr<WidgetListMVVM> _m_WidgetList = PPtr<WidgetListMVVM>.Read(reader);
        PPtr<JournalQuestObjectiveAddendumConsoleView> _m_AddendumViewPrefab = PPtr<JournalQuestObjectiveAddendumConsoleView>.Read(reader);
        float _m_DefaultConsoleFontSize = reader.ReadF32();
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_Title,
            _m_ObjectiveNummer,
            _m_Description,
            _m_EtudeCounter,
            _m_Destination,
            _m_AttentionMark,
            _m_FailedMark,
            _m_CompletedMark,
            _m_UpdatedMark,
            _m_PostponedMark,
            _m_InProgressMark,
            _m_DestinationGeoMark,
            _m_ExpandableCollapseMultiButton,
            _m_WidgetList,
            _m_AddendumViewPrefab,
            _m_DefaultConsoleFontSize);
    }
}


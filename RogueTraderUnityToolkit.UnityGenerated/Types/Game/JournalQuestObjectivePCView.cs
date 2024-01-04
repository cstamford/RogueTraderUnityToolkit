namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $JournalQuestObjectivePCView (21 fields) FAA8248A82FECD540CF30238134E6787/12DBB717AF3F1C289EA140203F62C86A */
public record class JournalQuestObjectivePCView(
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
    PPtr<ExpandableCollapseMultiButtonPC> m_ExpandableCollapseMultiButton /* None */,
    PPtr<WidgetListMVVM> m_WidgetList /* None */,
    PPtr<JournalQuestObjectiveAddendumPCView> m_AddendumViewPrefab /* None */,
    PPtr<Image> m_HintPlace /* None */,
    float m_DefaultFontSize /* None */)
{
    public static JournalQuestObjectivePCView Read(EndianBinaryReader reader)
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
        PPtr<ExpandableCollapseMultiButtonPC> _m_ExpandableCollapseMultiButton = PPtr<ExpandableCollapseMultiButtonPC>.Read(reader);
        PPtr<WidgetListMVVM> _m_WidgetList = PPtr<WidgetListMVVM>.Read(reader);
        PPtr<JournalQuestObjectiveAddendumPCView> _m_AddendumViewPrefab = PPtr<JournalQuestObjectiveAddendumPCView>.Read(reader);
        PPtr<Image> _m_HintPlace = PPtr<Image>.Read(reader);
        float _m_DefaultFontSize = reader.ReadF32();
        
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
            _m_HintPlace,
            _m_DefaultFontSize);
    }
}


namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $CareerPathListItemCommonView (16 fields) 5A8C143AB57E5FB3103BE5FAD0591CEB/452A7D93C3E228F2BA59E4A5525D0B6F */
public record class CareerPathListItemCommonView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<OwlcatMultiButton> m_MainButton /* NeedsAlign */,
    PPtr<TextMeshProUGUI> m_CareerName /* None */,
    PPtr<Image> m_CareerIcon /* None */,
    PPtr<GameObject> m_SelectedMark /* None */,
    PPtr<Image> m_RecommendMark /* None */,
    PPtr<GameObject> m_CurrentRankEntryMark /* None */,
    PPtr<GameObject> m_SelectedIcon /* None */,
    byte m_IsInsideCareerProgression /* None */,
    byte m_PrerequisitesAffectsHighlight /* NeedsAlign */,
    PPtr<GameObject> m_ProgressBar /* NeedsAlign */,
    PPtr<TextMeshProUGUI> m_ProgressText /* None */,
    PPtr<Image> m_ProgressValueBar /* None */)
{
    public static CareerPathListItemCommonView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_MainButton */
        PPtr<OwlcatMultiButton> _m_MainButton = PPtr<OwlcatMultiButton>.Read(reader);
        PPtr<TextMeshProUGUI> _m_CareerName = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<Image> _m_CareerIcon = PPtr<Image>.Read(reader);
        PPtr<GameObject> _m_SelectedMark = PPtr<GameObject>.Read(reader);
        PPtr<Image> _m_RecommendMark = PPtr<Image>.Read(reader);
        PPtr<GameObject> _m_CurrentRankEntryMark = PPtr<GameObject>.Read(reader);
        PPtr<GameObject> _m_SelectedIcon = PPtr<GameObject>.Read(reader);
        byte _m_IsInsideCareerProgression = reader.ReadU8();
        reader.AlignTo(4); /* m_PrerequisitesAffectsHighlight */
        byte _m_PrerequisitesAffectsHighlight = reader.ReadU8();
        reader.AlignTo(4); /* m_ProgressBar */
        PPtr<GameObject> _m_ProgressBar = PPtr<GameObject>.Read(reader);
        PPtr<TextMeshProUGUI> _m_ProgressText = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<Image> _m_ProgressValueBar = PPtr<Image>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_MainButton,
            _m_CareerName,
            _m_CareerIcon,
            _m_SelectedMark,
            _m_RecommendMark,
            _m_CurrentRankEntryMark,
            _m_SelectedIcon,
            _m_IsInsideCareerProgression,
            _m_PrerequisitesAffectsHighlight,
            _m_ProgressBar,
            _m_ProgressText,
            _m_ProgressValueBar);
    }
}


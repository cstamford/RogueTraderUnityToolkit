namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $CharacterInfoPCView (16 fields) 891D74841659856E198750C68D67A676/A8B6308A9D5D9A9FC854894AC74705B3 */
public record class CharacterInfoPCView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<CharInfoPagesMenuPCView> m_CharInfoPagesMenu /* NeedsAlign */,
    PPtr<CharInfoNameAndPortraitPCView> m_NameAndPortraitView /* None */,
    PPtr<CharInfoLevelClassScoresPCView> m_LevelClassScoresView /* None */,
    PPtr<CharInfoSkillsAndWeaponsBaseView> m_SkillsAndWeaponsView /* None */,
    PPtr<CharInfoAlignmentWheelPCView> m_AlignmentWheelView /* None */,
    PPtr<CharInfoAbilitiesBaseView> m_AbilitiesView /* None */,
    PPtr<CharInfoChoicesMadeView> m_ChoicesMadeView /* None */,
    PPtr<CharInfoNameAndPortraitPCView> m_NameFullPortraitPCView /* None */,
    PPtr<CharInfoFactionsReputationPCView> m_FactionsReputationPCView /* None */,
    PPtr<CharInfoStoriesView> m_BiographyStoriesView /* None */,
    PPtr<UnitProgressionCommonView> m_ProgressionView /* None */,
    PPtr<CharInfoSummaryPCView> m_SummaryView /* None */)
{
    public static CharacterInfoPCView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_CharInfoPagesMenu */
        PPtr<CharInfoPagesMenuPCView> _m_CharInfoPagesMenu = PPtr<CharInfoPagesMenuPCView>.Read(reader);
        PPtr<CharInfoNameAndPortraitPCView> _m_NameAndPortraitView = PPtr<CharInfoNameAndPortraitPCView>.Read(reader);
        PPtr<CharInfoLevelClassScoresPCView> _m_LevelClassScoresView = PPtr<CharInfoLevelClassScoresPCView>.Read(reader);
        PPtr<CharInfoSkillsAndWeaponsBaseView> _m_SkillsAndWeaponsView = PPtr<CharInfoSkillsAndWeaponsBaseView>.Read(reader);
        PPtr<CharInfoAlignmentWheelPCView> _m_AlignmentWheelView = PPtr<CharInfoAlignmentWheelPCView>.Read(reader);
        PPtr<CharInfoAbilitiesBaseView> _m_AbilitiesView = PPtr<CharInfoAbilitiesBaseView>.Read(reader);
        PPtr<CharInfoChoicesMadeView> _m_ChoicesMadeView = PPtr<CharInfoChoicesMadeView>.Read(reader);
        PPtr<CharInfoNameAndPortraitPCView> _m_NameFullPortraitPCView = PPtr<CharInfoNameAndPortraitPCView>.Read(reader);
        PPtr<CharInfoFactionsReputationPCView> _m_FactionsReputationPCView = PPtr<CharInfoFactionsReputationPCView>.Read(reader);
        PPtr<CharInfoStoriesView> _m_BiographyStoriesView = PPtr<CharInfoStoriesView>.Read(reader);
        PPtr<UnitProgressionCommonView> _m_ProgressionView = PPtr<UnitProgressionCommonView>.Read(reader);
        PPtr<CharInfoSummaryPCView> _m_SummaryView = PPtr<CharInfoSummaryPCView>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_CharInfoPagesMenu,
            _m_NameAndPortraitView,
            _m_LevelClassScoresView,
            _m_SkillsAndWeaponsView,
            _m_AlignmentWheelView,
            _m_AbilitiesView,
            _m_ChoicesMadeView,
            _m_NameFullPortraitPCView,
            _m_FactionsReputationPCView,
            _m_BiographyStoriesView,
            _m_ProgressionView,
            _m_SummaryView);
    }
}


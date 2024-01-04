namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $CharGenSummaryPhaseDetailedConsoleView (12 fields) 6D92F817A672ECF768FCFBC44F7D1BA9/4D066700313223BB3AADB53FBD0AF60B */
public record class CharGenSummaryPhaseDetailedConsoleView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<FadeAnimator> m_PageAnimator /* NeedsAlign */,
    PPtr<CharGenNameBaseView> m_CharGenNameView /* None */,
    PPtr<CharInfoLevelClassScoresPCView> m_LevelClassScoresView /* None */,
    PPtr<CharInfoSkillsBlockCommonView> m_SkillsBlockView /* None */,
    PPtr<InfoSectionView> m_InfoView /* None */,
    PPtr<CharInfoAbilityScoresBlockBaseView> m_AbilityScores /* None */,
    PPtr<GameObject> m_SecondaryInfoViewContainer /* None */,
    PPtr<InfoSectionView> m_SecondaryInfoView /* None */)
{
    public static CharGenSummaryPhaseDetailedConsoleView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_PageAnimator */
        PPtr<FadeAnimator> _m_PageAnimator = PPtr<FadeAnimator>.Read(reader);
        PPtr<CharGenNameBaseView> _m_CharGenNameView = PPtr<CharGenNameBaseView>.Read(reader);
        PPtr<CharInfoLevelClassScoresPCView> _m_LevelClassScoresView = PPtr<CharInfoLevelClassScoresPCView>.Read(reader);
        PPtr<CharInfoSkillsBlockCommonView> _m_SkillsBlockView = PPtr<CharInfoSkillsBlockCommonView>.Read(reader);
        PPtr<InfoSectionView> _m_InfoView = PPtr<InfoSectionView>.Read(reader);
        PPtr<CharInfoAbilityScoresBlockBaseView> _m_AbilityScores = PPtr<CharInfoAbilityScoresBlockBaseView>.Read(reader);
        PPtr<GameObject> _m_SecondaryInfoViewContainer = PPtr<GameObject>.Read(reader);
        PPtr<InfoSectionView> _m_SecondaryInfoView = PPtr<InfoSectionView>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_PageAnimator,
            _m_CharGenNameView,
            _m_LevelClassScoresView,
            _m_SkillsBlockView,
            _m_InfoView,
            _m_AbilityScores,
            _m_SecondaryInfoViewContainer,
            _m_SecondaryInfoView);
    }
}


namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $CharGenSummaryPhaseDetailedPCView (9 fields) 34384C7B5B5874CEA0B164B1AB1DA50B/5A2B147231002382AFFFCDE07B03382E */
public record class CharGenSummaryPhaseDetailedPCView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<FadeAnimator> m_PageAnimator /* NeedsAlign */,
    PPtr<CharGenNameBaseView> m_CharGenNameView /* None */,
    PPtr<CharInfoLevelClassScoresPCView> m_LevelClassScoresView /* None */,
    PPtr<CharInfoSkillsBlockCommonView> m_SkillsBlockView /* None */,
    PPtr<InfoSectionView> m_InfoView /* None */)
{
    public static CharGenSummaryPhaseDetailedPCView Read(EndianBinaryReader reader)
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
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_PageAnimator,
            _m_CharGenNameView,
            _m_LevelClassScoresView,
            _m_SkillsBlockView,
            _m_InfoView);
    }
}


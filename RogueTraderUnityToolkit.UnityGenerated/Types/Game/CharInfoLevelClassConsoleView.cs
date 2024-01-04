namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $CharInfoLevelClassConsoleView (10 fields) E4FD7433B746514BEB505BCF6933CD0D/2045A7E7EF503ABEB52C36B44A1D6353 */
public record class CharInfoLevelClassConsoleView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<FadeAnimator> m_FadeAnimator /* NeedsAlign */,
    PPtr<CharInfoExperiencePCView> m_Experience /* None */,
    PPtr<CharInfoAbilityScoresBlockBaseView> m_AbilityScores /* None */,
    PPtr<CharInfoClassesListPCView> m_Classes /* None */,
    PPtr<InventoryDollAdditionalStatsPCView> m_AdditionalStatsView /* None */,
    PPtr<TextMeshProUGUI> m_CharacterStatsLabel /* None */)
{
    public static CharInfoLevelClassConsoleView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_FadeAnimator */
        PPtr<FadeAnimator> _m_FadeAnimator = PPtr<FadeAnimator>.Read(reader);
        PPtr<CharInfoExperiencePCView> _m_Experience = PPtr<CharInfoExperiencePCView>.Read(reader);
        PPtr<CharInfoAbilityScoresBlockBaseView> _m_AbilityScores = PPtr<CharInfoAbilityScoresBlockBaseView>.Read(reader);
        PPtr<CharInfoClassesListPCView> _m_Classes = PPtr<CharInfoClassesListPCView>.Read(reader);
        PPtr<InventoryDollAdditionalStatsPCView> _m_AdditionalStatsView = PPtr<InventoryDollAdditionalStatsPCView>.Read(reader);
        PPtr<TextMeshProUGUI> _m_CharacterStatsLabel = PPtr<TextMeshProUGUI>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_FadeAnimator,
            _m_Experience,
            _m_AbilityScores,
            _m_Classes,
            _m_AdditionalStatsView,
            _m_CharacterStatsLabel);
    }
}


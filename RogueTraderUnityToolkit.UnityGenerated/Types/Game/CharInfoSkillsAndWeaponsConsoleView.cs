namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $CharInfoSkillsAndWeaponsConsoleView (10 fields) 8099B5FA646A5FF05D97D70210BD07DC/18DEAACA03222816E1DD625C835F942E */
public record class CharInfoSkillsAndWeaponsConsoleView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<FadeAnimator> m_FadeAnimator /* NeedsAlign */,
    PPtr<CharInfoSkillsBlockCommonView> m_SkillsBlockPCView /* None */,
    PPtr<CharInfoWeaponsBlockPCView> m_WeaponsBlockPCView /* None */,
    PPtr<TextMeshProUGUI> m_WeaponStatsLabel /* None */,
    PPtr<TextMeshProUGUI> m_SkillsStatsLabel /* None */,
    PPtr<CharInfoAbilityScoresBlockConsoleView> m_AbilityScoresBlockConsoleView /* None */)
{
    public static CharInfoSkillsAndWeaponsConsoleView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_FadeAnimator */
        PPtr<FadeAnimator> _m_FadeAnimator = PPtr<FadeAnimator>.Read(reader);
        PPtr<CharInfoSkillsBlockCommonView> _m_SkillsBlockPCView = PPtr<CharInfoSkillsBlockCommonView>.Read(reader);
        PPtr<CharInfoWeaponsBlockPCView> _m_WeaponsBlockPCView = PPtr<CharInfoWeaponsBlockPCView>.Read(reader);
        PPtr<TextMeshProUGUI> _m_WeaponStatsLabel = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<TextMeshProUGUI> _m_SkillsStatsLabel = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<CharInfoAbilityScoresBlockConsoleView> _m_AbilityScoresBlockConsoleView = PPtr<CharInfoAbilityScoresBlockConsoleView>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_FadeAnimator,
            _m_SkillsBlockPCView,
            _m_WeaponsBlockPCView,
            _m_WeaponStatsLabel,
            _m_SkillsStatsLabel,
            _m_AbilityScoresBlockConsoleView);
    }
}


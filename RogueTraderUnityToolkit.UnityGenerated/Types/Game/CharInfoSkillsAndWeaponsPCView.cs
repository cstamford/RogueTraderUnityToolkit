namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $CharInfoSkillsAndWeaponsPCView (12 fields) 498897CE9F52C306E57B9E154CFC2D08/91F55FC632BDFFFC423AC2CAADF99B3C */
public record class CharInfoSkillsAndWeaponsPCView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<FadeAnimator> m_FadeAnimator /* NeedsAlign */,
    PPtr<CharInfoSkillsBlockCommonView> m_SkillsBlockPCView /* None */,
    PPtr<CharInfoWeaponsBlockPCView> m_WeaponsBlockPCView /* None */,
    PPtr<TextMeshProUGUI> m_WeaponStatsLabel /* None */,
    PPtr<TextMeshProUGUI> m_SkillsStatsLabel /* None */,
    PPtr<OwlcatMultiButton> m_SkillsButton /* None */,
    PPtr<OwlcatMultiButton> m_WeaponsButton /* None */,
    PPtr<Transform> m_TabSelector /* None */)
{
    public static CharInfoSkillsAndWeaponsPCView Read(EndianBinaryReader reader)
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
        PPtr<OwlcatMultiButton> _m_SkillsButton = PPtr<OwlcatMultiButton>.Read(reader);
        PPtr<OwlcatMultiButton> _m_WeaponsButton = PPtr<OwlcatMultiButton>.Read(reader);
        PPtr<Transform> _m_TabSelector = PPtr<Transform>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_FadeAnimator,
            _m_SkillsBlockPCView,
            _m_WeaponsBlockPCView,
            _m_WeaponStatsLabel,
            _m_SkillsStatsLabel,
            _m_SkillsButton,
            _m_WeaponsButton,
            _m_TabSelector);
    }
}


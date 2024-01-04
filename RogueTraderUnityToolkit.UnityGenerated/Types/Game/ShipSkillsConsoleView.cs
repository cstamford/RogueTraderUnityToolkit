namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $ShipSkillsConsoleView (10 fields) 437BED960F7145141AE52D1C92A20938/9B3D26DB5847B7F01865D17063B54842 */
public record class ShipSkillsConsoleView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<FadeAnimator> m_FadeAnimator /* NeedsAlign */,
    PPtr<InfoSectionView> m_InfoSection /* None */,
    PPtr<ShipCareerPathSelectionTabsConsoleView> m_ShipCareerPathSelectionTabsPCView /* None */,
    PPtr<CareerPathRoundProgressionCommonView> m_CareerPathRoundProgression /* None */,
    PPtr<ShipRankExpCounterPCView> m_RankExpCounterPCView /* None */,
    PPtr<GameObject> m_LockBackground /* None */)
{
    public static ShipSkillsConsoleView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_FadeAnimator */
        PPtr<FadeAnimator> _m_FadeAnimator = PPtr<FadeAnimator>.Read(reader);
        PPtr<InfoSectionView> _m_InfoSection = PPtr<InfoSectionView>.Read(reader);
        PPtr<ShipCareerPathSelectionTabsConsoleView> _m_ShipCareerPathSelectionTabsPCView = PPtr<ShipCareerPathSelectionTabsConsoleView>.Read(reader);
        PPtr<CareerPathRoundProgressionCommonView> _m_CareerPathRoundProgression = PPtr<CareerPathRoundProgressionCommonView>.Read(reader);
        PPtr<ShipRankExpCounterPCView> _m_RankExpCounterPCView = PPtr<ShipRankExpCounterPCView>.Read(reader);
        PPtr<GameObject> _m_LockBackground = PPtr<GameObject>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_FadeAnimator,
            _m_InfoSection,
            _m_ShipCareerPathSelectionTabsPCView,
            _m_CareerPathRoundProgression,
            _m_RankExpCounterPCView,
            _m_LockBackground);
    }
}


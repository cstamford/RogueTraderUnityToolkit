namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $CharGenAttributesPhaseDetailedConsoleView (11 fields) E52C83B5B2418E3697C23E9B74EA0F9A/98A40D9EAFE721DCCEAC67A97F341A89 */
public record class CharGenAttributesPhaseDetailedConsoleView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<FadeAnimator> m_PageAnimator /* NeedsAlign */,
    PPtr<TextMeshProUGUI> m_AvailablePointsLabel /* None */,
    PPtr<CharGenAttributesPhaseSelectorView> m_CharGenAttributesPhaseSelectorView /* None */,
    PPtr<CharInfoSkillsBlockCommonView> m_CharInfoSkillsBlockView /* None */,
    PPtr<InfoSectionView> m_InfoView /* None */,
    PPtr<GameObject> m_SecondaryInfoViewContainer /* None */,
    PPtr<InfoSectionView> m_SecondaryInfoView /* None */)
{
    public static CharGenAttributesPhaseDetailedConsoleView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_PageAnimator */
        PPtr<FadeAnimator> _m_PageAnimator = PPtr<FadeAnimator>.Read(reader);
        PPtr<TextMeshProUGUI> _m_AvailablePointsLabel = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<CharGenAttributesPhaseSelectorView> _m_CharGenAttributesPhaseSelectorView = PPtr<CharGenAttributesPhaseSelectorView>.Read(reader);
        PPtr<CharInfoSkillsBlockCommonView> _m_CharInfoSkillsBlockView = PPtr<CharInfoSkillsBlockCommonView>.Read(reader);
        PPtr<InfoSectionView> _m_InfoView = PPtr<InfoSectionView>.Read(reader);
        PPtr<GameObject> _m_SecondaryInfoViewContainer = PPtr<GameObject>.Read(reader);
        PPtr<InfoSectionView> _m_SecondaryInfoView = PPtr<InfoSectionView>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_PageAnimator,
            _m_AvailablePointsLabel,
            _m_CharGenAttributesPhaseSelectorView,
            _m_CharInfoSkillsBlockView,
            _m_InfoView,
            _m_SecondaryInfoViewContainer,
            _m_SecondaryInfoView);
    }
}


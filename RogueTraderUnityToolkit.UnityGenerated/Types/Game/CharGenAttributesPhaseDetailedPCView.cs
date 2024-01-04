namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $CharGenAttributesPhaseDetailedPCView (9 fields) C26C8A59D2F9F3CE70229ED378320A25/948D4D996591CAB15ADE42B9F17815F0 */
public record class CharGenAttributesPhaseDetailedPCView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<FadeAnimator> m_PageAnimator /* NeedsAlign */,
    PPtr<TextMeshProUGUI> m_AvailablePointsLabel /* None */,
    PPtr<CharGenAttributesPhaseSelectorView> m_CharGenAttributesPhaseSelectorView /* None */,
    PPtr<CharInfoSkillsBlockCommonView> m_CharInfoSkillsBlockView /* None */,
    PPtr<InfoSectionView> m_InfoView /* None */)
{
    public static CharGenAttributesPhaseDetailedPCView Read(EndianBinaryReader reader)
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
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_PageAnimator,
            _m_AvailablePointsLabel,
            _m_CharGenAttributesPhaseSelectorView,
            _m_CharInfoSkillsBlockView,
            _m_InfoView);
    }
}


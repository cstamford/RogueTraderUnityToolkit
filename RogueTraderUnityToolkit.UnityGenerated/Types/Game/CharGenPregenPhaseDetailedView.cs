namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $CharGenPregenPhaseDetailedView (10 fields) EFF4777A84C0551C4D239D4A0247CB55/C8BABAD057CF5E0F47077B011ACD89A3 */
public record class CharGenPregenPhaseDetailedView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<FadeAnimator> m_PageAnimator /* NeedsAlign */,
    PPtr<InfoSectionView> m_InfoView /* None */,
    PPtr<GameObject> m_SecondaryInfoViewContainer /* None */,
    PPtr<InfoSectionView> m_SecondaryInfoView /* None */,
    PPtr<CharGenPregenSelectorView> m_CharGenPregenSelectorView /* None */,
    PPtr<FadeAnimator> m_CharacterPlaceholder /* None */)
{
    public static CharGenPregenPhaseDetailedView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_PageAnimator */
        PPtr<FadeAnimator> _m_PageAnimator = PPtr<FadeAnimator>.Read(reader);
        PPtr<InfoSectionView> _m_InfoView = PPtr<InfoSectionView>.Read(reader);
        PPtr<GameObject> _m_SecondaryInfoViewContainer = PPtr<GameObject>.Read(reader);
        PPtr<InfoSectionView> _m_SecondaryInfoView = PPtr<InfoSectionView>.Read(reader);
        PPtr<CharGenPregenSelectorView> _m_CharGenPregenSelectorView = PPtr<CharGenPregenSelectorView>.Read(reader);
        PPtr<FadeAnimator> _m_CharacterPlaceholder = PPtr<FadeAnimator>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_PageAnimator,
            _m_InfoView,
            _m_SecondaryInfoViewContainer,
            _m_SecondaryInfoView,
            _m_CharGenPregenSelectorView,
            _m_CharacterPlaceholder);
    }
}


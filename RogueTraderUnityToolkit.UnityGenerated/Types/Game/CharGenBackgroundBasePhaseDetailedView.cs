namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $CharGenBackgroundBasePhaseDetailedView (9 fields) 97E7DD177D9F5DA3725D6FBCAD35C147/E2AA9B59B4AC26CEA77F931303604E7F */
public record class CharGenBackgroundBasePhaseDetailedView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<FadeAnimator> m_PageAnimator /* NeedsAlign */,
    PPtr<InfoSectionView> m_InfoView /* None */,
    PPtr<GameObject> m_SecondaryInfoViewContainer /* None */,
    PPtr<InfoSectionView> m_SecondaryInfoView /* None */,
    PPtr<CharGenBackgroundBasePhaseSelectorView> m_CharGenSelectionsCommonPhaseSelectorView /* None */)
{
    public static CharGenBackgroundBasePhaseDetailedView Read(EndianBinaryReader reader)
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
        PPtr<CharGenBackgroundBasePhaseSelectorView> _m_CharGenSelectionsCommonPhaseSelectorView = PPtr<CharGenBackgroundBasePhaseSelectorView>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_PageAnimator,
            _m_InfoView,
            _m_SecondaryInfoViewContainer,
            _m_SecondaryInfoView,
            _m_CharGenSelectionsCommonPhaseSelectorView);
    }
}


namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $CareerPathProgressionConsoleView (17 fields) D9B26DC368DDAE3F128277D7DADA5B2D/43895518E9898251CC5025E46F7303FC */
public record class CareerPathProgressionConsoleView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<FadeAnimator> m_FadeAnimator /* NeedsAlign */,
    PPtr<CareerPathSelectionTabsCommonView> m_CareerPathSelectionPartCommonView /* None */,
    PPtr<CharInfoAvailableRanksCommonView> m_AvailableRanksCommonView /* None */,
    PPtr<CareerPathRoundProgressionCommonView> m_CareerPathRoundProgressionCommonView /* None */,
    PPtr<InfoSectionView> m_InfoSection /* None */,
    byte m_CanExpand /* None */,
    byte m_AlwaysShowInfo /* NeedsAlign */,
    PPtr<SizeAnimator> m_ProgressionSizeAnimator /* NeedsAlign */,
    PPtr<SizeAnimator> m_DescriptionSizeAnimator /* None */,
    PPtr<OwlcatSelectable> m_ProgressionArea /* None */,
    PPtr<ScrollRectExtended> m_CareerScrollRectExtended /* None */,
    float m_EnsureVisibleSenseZone /* None */,
    PPtr<RectTransform> m_TooltipPlace /* None */)
{
    public static CareerPathProgressionConsoleView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_FadeAnimator */
        PPtr<FadeAnimator> _m_FadeAnimator = PPtr<FadeAnimator>.Read(reader);
        PPtr<CareerPathSelectionTabsCommonView> _m_CareerPathSelectionPartCommonView = PPtr<CareerPathSelectionTabsCommonView>.Read(reader);
        PPtr<CharInfoAvailableRanksCommonView> _m_AvailableRanksCommonView = PPtr<CharInfoAvailableRanksCommonView>.Read(reader);
        PPtr<CareerPathRoundProgressionCommonView> _m_CareerPathRoundProgressionCommonView = PPtr<CareerPathRoundProgressionCommonView>.Read(reader);
        PPtr<InfoSectionView> _m_InfoSection = PPtr<InfoSectionView>.Read(reader);
        byte _m_CanExpand = reader.ReadU8();
        reader.AlignTo(4); /* m_AlwaysShowInfo */
        byte _m_AlwaysShowInfo = reader.ReadU8();
        reader.AlignTo(4); /* m_ProgressionSizeAnimator */
        PPtr<SizeAnimator> _m_ProgressionSizeAnimator = PPtr<SizeAnimator>.Read(reader);
        PPtr<SizeAnimator> _m_DescriptionSizeAnimator = PPtr<SizeAnimator>.Read(reader);
        PPtr<OwlcatSelectable> _m_ProgressionArea = PPtr<OwlcatSelectable>.Read(reader);
        PPtr<ScrollRectExtended> _m_CareerScrollRectExtended = PPtr<ScrollRectExtended>.Read(reader);
        float _m_EnsureVisibleSenseZone = reader.ReadF32();
        PPtr<RectTransform> _m_TooltipPlace = PPtr<RectTransform>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_FadeAnimator,
            _m_CareerPathSelectionPartCommonView,
            _m_AvailableRanksCommonView,
            _m_CareerPathRoundProgressionCommonView,
            _m_InfoSection,
            _m_CanExpand,
            _m_AlwaysShowInfo,
            _m_ProgressionSizeAnimator,
            _m_DescriptionSizeAnimator,
            _m_ProgressionArea,
            _m_CareerScrollRectExtended,
            _m_EnsureVisibleSenseZone,
            _m_TooltipPlace);
    }
}


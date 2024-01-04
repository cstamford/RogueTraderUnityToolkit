namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $SpaceSystemNavigationButtonsPCView (25 fields) DE7D9C1EB1B76BFBDC5195A7F3AAB3FE/B976FB7D3E01D77F468D5BEF744A1FA0 */
public record class SpaceSystemNavigationButtonsPCView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<OwlcatButton> m_CreateWayButton /* NeedsAlign */,
    PPtr<OwlcatButton>[] m_UpgradeButtons /* None */,
    PPtr<TextMeshProUGUI>[] m_UpgradeCostText /* None */,
    PPtr<FadeAnimator> m_CreateAndUpgradeWayLabelFadeAnimator /* None */,
    PPtr<TextMeshProUGUI> m_CreateAndUpgradeWayLabelText /* None */,
    PPtr<Image>[] m_UpgradeWayCostFillingImage /* None */,
    PPtr<TextMeshProUGUI> m_CreateWayCostText /* None */,
    PPtr<Image> m_CreateWayFillingImage /* None */,
    PPtr<FadeAnimator> m_ChangeNavigatorResourceAnimator /* None */,
    PPtr<TextMeshProUGUI> m_PlusNavigatorCostText /* None */,
    PPtr<FadeAnimator> m_NavigationWindowFadeAnimator /* None */,
    PPtr<Image>[] m_ChangeDifficultyColorObjects /* None */,
    ColorRGBA[] m_DifficultyColors /* None */,
    PPtr<Image> m_EagleImage /* NeedsAlign */,
    ColorRGBA[] m_DifficultyEagleColors /* None */,
    ColorRGBA[] m_DifficultyHintPanelTextsColors /* NeedsAlign */,
    PPtr<OwlcatButton> m_TravelButton /* NeedsAlign */,
    PPtr<TextMeshProUGUI> m_TravelButtonLabel /* None */,
    ColorRGBA[] m_TravelButtonDifficultyColorsText /* None */,
    PPtr<FadeAnimator> m_TravelLabelFadeAnimator /* NeedsAlign */,
    PPtr<TextMeshProUGUI> m_TravelLabelText /* None */)
{
    public static SpaceSystemNavigationButtonsPCView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_CreateWayButton */
        PPtr<OwlcatButton> _m_CreateWayButton = PPtr<OwlcatButton>.Read(reader);
        PPtr<OwlcatButton>[] _m_UpgradeButtons = BuiltInArray<PPtr<OwlcatButton>>.Read(reader);
        PPtr<TextMeshProUGUI>[] _m_UpgradeCostText = BuiltInArray<PPtr<TextMeshProUGUI>>.Read(reader);
        PPtr<FadeAnimator> _m_CreateAndUpgradeWayLabelFadeAnimator = PPtr<FadeAnimator>.Read(reader);
        PPtr<TextMeshProUGUI> _m_CreateAndUpgradeWayLabelText = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<Image>[] _m_UpgradeWayCostFillingImage = BuiltInArray<PPtr<Image>>.Read(reader);
        PPtr<TextMeshProUGUI> _m_CreateWayCostText = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<Image> _m_CreateWayFillingImage = PPtr<Image>.Read(reader);
        PPtr<FadeAnimator> _m_ChangeNavigatorResourceAnimator = PPtr<FadeAnimator>.Read(reader);
        PPtr<TextMeshProUGUI> _m_PlusNavigatorCostText = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<FadeAnimator> _m_NavigationWindowFadeAnimator = PPtr<FadeAnimator>.Read(reader);
        PPtr<Image>[] _m_ChangeDifficultyColorObjects = BuiltInArray<PPtr<Image>>.Read(reader);
        ColorRGBA[] _m_DifficultyColors = BuiltInArray<ColorRGBA>.Read(reader);
        reader.AlignTo(4); /* m_EagleImage */
        PPtr<Image> _m_EagleImage = PPtr<Image>.Read(reader);
        ColorRGBA[] _m_DifficultyEagleColors = BuiltInArray<ColorRGBA>.Read(reader);
        reader.AlignTo(4); /* m_DifficultyHintPanelTextsColors */
        ColorRGBA[] _m_DifficultyHintPanelTextsColors = BuiltInArray<ColorRGBA>.Read(reader);
        reader.AlignTo(4); /* m_TravelButton */
        PPtr<OwlcatButton> _m_TravelButton = PPtr<OwlcatButton>.Read(reader);
        PPtr<TextMeshProUGUI> _m_TravelButtonLabel = PPtr<TextMeshProUGUI>.Read(reader);
        ColorRGBA[] _m_TravelButtonDifficultyColorsText = BuiltInArray<ColorRGBA>.Read(reader);
        reader.AlignTo(4); /* m_TravelLabelFadeAnimator */
        PPtr<FadeAnimator> _m_TravelLabelFadeAnimator = PPtr<FadeAnimator>.Read(reader);
        PPtr<TextMeshProUGUI> _m_TravelLabelText = PPtr<TextMeshProUGUI>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_CreateWayButton,
            _m_UpgradeButtons,
            _m_UpgradeCostText,
            _m_CreateAndUpgradeWayLabelFadeAnimator,
            _m_CreateAndUpgradeWayLabelText,
            _m_UpgradeWayCostFillingImage,
            _m_CreateWayCostText,
            _m_CreateWayFillingImage,
            _m_ChangeNavigatorResourceAnimator,
            _m_PlusNavigatorCostText,
            _m_NavigationWindowFadeAnimator,
            _m_ChangeDifficultyColorObjects,
            _m_DifficultyColors,
            _m_EagleImage,
            _m_DifficultyEagleColors,
            _m_DifficultyHintPanelTextsColors,
            _m_TravelButton,
            _m_TravelButtonLabel,
            _m_TravelButtonDifficultyColorsText,
            _m_TravelLabelFadeAnimator,
            _m_TravelLabelText);
    }
}


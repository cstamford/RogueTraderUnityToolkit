namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $SpaceSystemNavigationButtonsConsoleView (27 fields) 14B8141AF107058629AA944A7FCEFE71/9025159EC210E39A724B694FAF5406EF */
public record class SpaceSystemNavigationButtonsConsoleView(
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
    PPtr<ConsoleHint> m_VisitHint /* NeedsAlign */,
    PPtr<ConsoleHint> m_TravelHint /* None */,
    PPtr<ConsoleHint> m_ScanHint /* None */,
    PPtr<ConsoleHint> m_UpgradeWayHint /* None */,
    PPtr<ConsoleHint> m_CreateWayHint /* None */,
    PPtr<ConsoleHint> m_PreviousHint /* None */,
    PPtr<ConsoleHint> m_NextHint /* None */)
{
    public static SpaceSystemNavigationButtonsConsoleView Read(EndianBinaryReader reader)
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
        reader.AlignTo(4); /* m_VisitHint */
        PPtr<ConsoleHint> _m_VisitHint = PPtr<ConsoleHint>.Read(reader);
        PPtr<ConsoleHint> _m_TravelHint = PPtr<ConsoleHint>.Read(reader);
        PPtr<ConsoleHint> _m_ScanHint = PPtr<ConsoleHint>.Read(reader);
        PPtr<ConsoleHint> _m_UpgradeWayHint = PPtr<ConsoleHint>.Read(reader);
        PPtr<ConsoleHint> _m_CreateWayHint = PPtr<ConsoleHint>.Read(reader);
        PPtr<ConsoleHint> _m_PreviousHint = PPtr<ConsoleHint>.Read(reader);
        PPtr<ConsoleHint> _m_NextHint = PPtr<ConsoleHint>.Read(reader);
        
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
            _m_VisitHint,
            _m_TravelHint,
            _m_ScanHint,
            _m_UpgradeWayHint,
            _m_CreateWayHint,
            _m_PreviousHint,
            _m_NextHint);
    }
}


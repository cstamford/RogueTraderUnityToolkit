namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $ExplorationConsoleView (34 fields) 07485DAE04C4FD7699586BBD48D488AE/5304AE0F63B1E8CED8FE91D57D000749 */
public record class ExplorationConsoleView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<ExplorationVisualElementsWrapperBaseView> m_ExplorationVisualElementsWrapperBaseView /* NeedsAlign */,
    PPtr<ExplorationScanResultsWrapperBaseView> m_ExplorationScanResultsWrapperBaseView /* None */,
    PPtr<ExplorationPointOfInterestListWrapperBaseView> m_ExplorationPointOfInterestListWrapperBaseView /* None */,
    PPtr<ExplorationPlanetDollRoomWrapperBaseView> m_ExplorationPlanetDollRoomWrapperBaseView /* None */,
    PPtr<TextMeshProUGUI> m_PlanetNameText /* None */,
    PPtr<TextMeshProUGUI> m_TitheGradeText /* None */,
    PPtr<TextMeshProUGUI> m_TitheGradeValueText /* None */,
    PPtr<FadeAnimator> m_TabletAnimator /* None */,
    PPtr<ResourceMinersView> m_ResourceMinersView /* None */,
    PPtr<Animation> m_ScanAnimation /* None */,
    float m_ScanAnimationDelay /* None */,
    float m_NotificationInterval /* None */,
    PPtr<DollRoomTargetController> m_CharacterController /* None */,
    PPtr<GameObject> m_BackupPlanet /* None */,
    PPtr<CanvasGroup> m_DialogOverlay /* None */,
    NavigationParameters m_PointsNavigationParameters /* None */,
    PPtr<ExplorationResourceListConsoleView> m_ExplorationResourceListConsoleView /* NeedsAlign */,
    PPtr<ExplorationColonyStatsWrapperConsoleView> m_ExplorationColonyStatsWrapperConsoleView /* None */,
    PPtr<ExplorationColonyTraitsWrapperConsoleView> m_ExplorationColonyTraitsWrapperConsoleView /* None */,
    PPtr<ExplorationPointOfInterestListConsoleView> m_ExplorationPointOfInterestListView /* None */,
    PPtr<ExplorationColonyRewardsWrapperConsoleView> m_ExplorationColonyRewardsWrapperConsoleView /* None */,
    PPtr<ExplorationColonyEventsWrapperConsoleView> m_ExplorationColonyEventsWrapperConsoleView /* None */,
    PPtr<ExplorationColonyProjectsWrapperConsoleView> m_ExplorationColonyProjectsWrapperPCView /* None */,
    PPtr<ExplorationColonyProjectsBuiltListWrapperConsoleView> m_ExplorationColonyProjectsBuiltListWrapperConsoleView /* None */,
    PPtr<ExplorationSpaceBarksHolderPCView> m_ExplorationSpaceBarksHolderPCView /* None */,
    PPtr<ExplorationSpaceResourcesWrapperConsoleView> m_ExplorationSpaceResourcesWrapperConsoleView /* None */,
    PPtr<ExplorationScanHintWrapperConsoleView> m_ExplorationScanHintWrapperConsoleView /* None */,
    PPtr<ConsoleHintsWidget> m_ConsoleHintsWidget /* None */,
    PPtr<CombatLogConsoleView> m_CombatLogConsoleView /* None */,
    NavigationBlockHighlight[] m_NavigationBlockHighlights /* None */)
{
    public static ExplorationConsoleView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_ExplorationVisualElementsWrapperBaseView */
        PPtr<ExplorationVisualElementsWrapperBaseView> _m_ExplorationVisualElementsWrapperBaseView = PPtr<ExplorationVisualElementsWrapperBaseView>.Read(reader);
        PPtr<ExplorationScanResultsWrapperBaseView> _m_ExplorationScanResultsWrapperBaseView = PPtr<ExplorationScanResultsWrapperBaseView>.Read(reader);
        PPtr<ExplorationPointOfInterestListWrapperBaseView> _m_ExplorationPointOfInterestListWrapperBaseView = PPtr<ExplorationPointOfInterestListWrapperBaseView>.Read(reader);
        PPtr<ExplorationPlanetDollRoomWrapperBaseView> _m_ExplorationPlanetDollRoomWrapperBaseView = PPtr<ExplorationPlanetDollRoomWrapperBaseView>.Read(reader);
        PPtr<TextMeshProUGUI> _m_PlanetNameText = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<TextMeshProUGUI> _m_TitheGradeText = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<TextMeshProUGUI> _m_TitheGradeValueText = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<FadeAnimator> _m_TabletAnimator = PPtr<FadeAnimator>.Read(reader);
        PPtr<ResourceMinersView> _m_ResourceMinersView = PPtr<ResourceMinersView>.Read(reader);
        PPtr<Animation> _m_ScanAnimation = PPtr<Animation>.Read(reader);
        float _m_ScanAnimationDelay = reader.ReadF32();
        float _m_NotificationInterval = reader.ReadF32();
        PPtr<DollRoomTargetController> _m_CharacterController = PPtr<DollRoomTargetController>.Read(reader);
        PPtr<GameObject> _m_BackupPlanet = PPtr<GameObject>.Read(reader);
        PPtr<CanvasGroup> _m_DialogOverlay = PPtr<CanvasGroup>.Read(reader);
        NavigationParameters _m_PointsNavigationParameters = NavigationParameters.Read(reader);
        reader.AlignTo(4); /* m_ExplorationResourceListConsoleView */
        PPtr<ExplorationResourceListConsoleView> _m_ExplorationResourceListConsoleView = PPtr<ExplorationResourceListConsoleView>.Read(reader);
        PPtr<ExplorationColonyStatsWrapperConsoleView> _m_ExplorationColonyStatsWrapperConsoleView = PPtr<ExplorationColonyStatsWrapperConsoleView>.Read(reader);
        PPtr<ExplorationColonyTraitsWrapperConsoleView> _m_ExplorationColonyTraitsWrapperConsoleView = PPtr<ExplorationColonyTraitsWrapperConsoleView>.Read(reader);
        PPtr<ExplorationPointOfInterestListConsoleView> _m_ExplorationPointOfInterestListView = PPtr<ExplorationPointOfInterestListConsoleView>.Read(reader);
        PPtr<ExplorationColonyRewardsWrapperConsoleView> _m_ExplorationColonyRewardsWrapperConsoleView = PPtr<ExplorationColonyRewardsWrapperConsoleView>.Read(reader);
        PPtr<ExplorationColonyEventsWrapperConsoleView> _m_ExplorationColonyEventsWrapperConsoleView = PPtr<ExplorationColonyEventsWrapperConsoleView>.Read(reader);
        PPtr<ExplorationColonyProjectsWrapperConsoleView> _m_ExplorationColonyProjectsWrapperPCView = PPtr<ExplorationColonyProjectsWrapperConsoleView>.Read(reader);
        PPtr<ExplorationColonyProjectsBuiltListWrapperConsoleView> _m_ExplorationColonyProjectsBuiltListWrapperConsoleView = PPtr<ExplorationColonyProjectsBuiltListWrapperConsoleView>.Read(reader);
        PPtr<ExplorationSpaceBarksHolderPCView> _m_ExplorationSpaceBarksHolderPCView = PPtr<ExplorationSpaceBarksHolderPCView>.Read(reader);
        PPtr<ExplorationSpaceResourcesWrapperConsoleView> _m_ExplorationSpaceResourcesWrapperConsoleView = PPtr<ExplorationSpaceResourcesWrapperConsoleView>.Read(reader);
        PPtr<ExplorationScanHintWrapperConsoleView> _m_ExplorationScanHintWrapperConsoleView = PPtr<ExplorationScanHintWrapperConsoleView>.Read(reader);
        PPtr<ConsoleHintsWidget> _m_ConsoleHintsWidget = PPtr<ConsoleHintsWidget>.Read(reader);
        PPtr<CombatLogConsoleView> _m_CombatLogConsoleView = PPtr<CombatLogConsoleView>.Read(reader);
        NavigationBlockHighlight[] _m_NavigationBlockHighlights = BuiltInArray<NavigationBlockHighlight>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_ExplorationVisualElementsWrapperBaseView,
            _m_ExplorationScanResultsWrapperBaseView,
            _m_ExplorationPointOfInterestListWrapperBaseView,
            _m_ExplorationPlanetDollRoomWrapperBaseView,
            _m_PlanetNameText,
            _m_TitheGradeText,
            _m_TitheGradeValueText,
            _m_TabletAnimator,
            _m_ResourceMinersView,
            _m_ScanAnimation,
            _m_ScanAnimationDelay,
            _m_NotificationInterval,
            _m_CharacterController,
            _m_BackupPlanet,
            _m_DialogOverlay,
            _m_PointsNavigationParameters,
            _m_ExplorationResourceListConsoleView,
            _m_ExplorationColonyStatsWrapperConsoleView,
            _m_ExplorationColonyTraitsWrapperConsoleView,
            _m_ExplorationPointOfInterestListView,
            _m_ExplorationColonyRewardsWrapperConsoleView,
            _m_ExplorationColonyEventsWrapperConsoleView,
            _m_ExplorationColonyProjectsWrapperPCView,
            _m_ExplorationColonyProjectsBuiltListWrapperConsoleView,
            _m_ExplorationSpaceBarksHolderPCView,
            _m_ExplorationSpaceResourcesWrapperConsoleView,
            _m_ExplorationScanHintWrapperConsoleView,
            _m_ConsoleHintsWidget,
            _m_CombatLogConsoleView,
            _m_NavigationBlockHighlights);
    }
}


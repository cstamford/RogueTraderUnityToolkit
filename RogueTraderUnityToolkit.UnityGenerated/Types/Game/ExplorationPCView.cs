namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $ExplorationPCView (34 fields) D9136C23445D95C94B972FF3C739DC82/1435D915EF0B87DE35B6C081815FFD4C */
public record class ExplorationPCView(
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
    PPtr<ExplorationResourceListPCView> m_ExplorationResourceListPCView /* NeedsAlign */,
    PPtr<ExplorationColonyStatsWrapperPCView> m_ExplorationColonyStatsWrapperPCView /* None */,
    PPtr<ExplorationColonyTraitsWrapperPCView> m_ExplorationColonyTraitsWrapperPCView /* None */,
    PPtr<ExplorationColonyEventsWrapperPCView> m_ExplorationColonyEventsWrapperPCView /* None */,
    PPtr<ExplorationPointOfInterestListPCView> m_ExplorationPointOfInterestListView /* None */,
    PPtr<ExplorationColonyRewardsWrapperPCView> m_ExplorationColonyRewardsWrapperPCView /* None */,
    PPtr<GameObject>[] m_ObjectsToHideForDialog /* None */,
    PPtr<OwlcatButton> m_CloseButton /* None */,
    PPtr<ExplorationScanButtonWrapperPCView> m_ExplorationScanButtonWrapperPCView /* None */,
    PPtr<ExplorationColonyProjectsWrapperPCView> m_ExplorationColonyProjectsWrapperPCView /* None */,
    PPtr<ExplorationColonyProjectsButtonWrapperPCView> m_ExplorationColonyProjectsButtonWrapperPCView /* None */,
    PPtr<ExplorationColonyProjectsBuiltListWrapperPCView> m_ExplorationColonyProjectsBuiltListWrapperPCView /* None */,
    PPtr<ExplorationSpaceBarksHolderPCView> m_ExplorationSpaceBarksHolderPCView /* None */,
    PPtr<ExplorationSpaceResourcesWrapperPCView> m_ExplorationSpaceResourcesWrapperPCView /* None */)
{
    public static ExplorationPCView Read(EndianBinaryReader reader)
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
        reader.AlignTo(4); /* m_ExplorationResourceListPCView */
        PPtr<ExplorationResourceListPCView> _m_ExplorationResourceListPCView = PPtr<ExplorationResourceListPCView>.Read(reader);
        PPtr<ExplorationColonyStatsWrapperPCView> _m_ExplorationColonyStatsWrapperPCView = PPtr<ExplorationColonyStatsWrapperPCView>.Read(reader);
        PPtr<ExplorationColonyTraitsWrapperPCView> _m_ExplorationColonyTraitsWrapperPCView = PPtr<ExplorationColonyTraitsWrapperPCView>.Read(reader);
        PPtr<ExplorationColonyEventsWrapperPCView> _m_ExplorationColonyEventsWrapperPCView = PPtr<ExplorationColonyEventsWrapperPCView>.Read(reader);
        PPtr<ExplorationPointOfInterestListPCView> _m_ExplorationPointOfInterestListView = PPtr<ExplorationPointOfInterestListPCView>.Read(reader);
        PPtr<ExplorationColonyRewardsWrapperPCView> _m_ExplorationColonyRewardsWrapperPCView = PPtr<ExplorationColonyRewardsWrapperPCView>.Read(reader);
        PPtr<GameObject>[] _m_ObjectsToHideForDialog = BuiltInArray<PPtr<GameObject>>.Read(reader);
        PPtr<OwlcatButton> _m_CloseButton = PPtr<OwlcatButton>.Read(reader);
        PPtr<ExplorationScanButtonWrapperPCView> _m_ExplorationScanButtonWrapperPCView = PPtr<ExplorationScanButtonWrapperPCView>.Read(reader);
        PPtr<ExplorationColonyProjectsWrapperPCView> _m_ExplorationColonyProjectsWrapperPCView = PPtr<ExplorationColonyProjectsWrapperPCView>.Read(reader);
        PPtr<ExplorationColonyProjectsButtonWrapperPCView> _m_ExplorationColonyProjectsButtonWrapperPCView = PPtr<ExplorationColonyProjectsButtonWrapperPCView>.Read(reader);
        PPtr<ExplorationColonyProjectsBuiltListWrapperPCView> _m_ExplorationColonyProjectsBuiltListWrapperPCView = PPtr<ExplorationColonyProjectsBuiltListWrapperPCView>.Read(reader);
        PPtr<ExplorationSpaceBarksHolderPCView> _m_ExplorationSpaceBarksHolderPCView = PPtr<ExplorationSpaceBarksHolderPCView>.Read(reader);
        PPtr<ExplorationSpaceResourcesWrapperPCView> _m_ExplorationSpaceResourcesWrapperPCView = PPtr<ExplorationSpaceResourcesWrapperPCView>.Read(reader);
        
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
            _m_ExplorationResourceListPCView,
            _m_ExplorationColonyStatsWrapperPCView,
            _m_ExplorationColonyTraitsWrapperPCView,
            _m_ExplorationColonyEventsWrapperPCView,
            _m_ExplorationPointOfInterestListView,
            _m_ExplorationColonyRewardsWrapperPCView,
            _m_ObjectsToHideForDialog,
            _m_CloseButton,
            _m_ExplorationScanButtonWrapperPCView,
            _m_ExplorationColonyProjectsWrapperPCView,
            _m_ExplorationColonyProjectsButtonWrapperPCView,
            _m_ExplorationColonyProjectsBuiltListWrapperPCView,
            _m_ExplorationSpaceBarksHolderPCView,
            _m_ExplorationSpaceResourcesWrapperPCView);
    }
}


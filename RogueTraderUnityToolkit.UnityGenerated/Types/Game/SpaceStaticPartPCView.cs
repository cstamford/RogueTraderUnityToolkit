namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $SpaceStaticPartPCView (44 fields) 07E8304DDBE56F45410D12A1A14EFF68/3799F49E6D79B4A65B3380358CFAE7DD */
public record class SpaceStaticPartPCView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<UIVisibilityView> m_UIVisibilityView /* NeedsAlign */,
    PPtr<CanvasScalerWorkaround> m_CanvasScalerWorkaround /* None */,
    PPtr<ServiceWindowsPCView> m_ServiceWindowsPCView /* None */,
    PPtr<LootContextPCView> m_LootContextPCView /* None */,
    PPtr<DialogContextPCView> m_DialogContextPCView /* None */,
    PPtr<GroupChangerContextPCView> m_GroupChangerContextPCView /* None */,
    UIViewLink_2 m_TransitionPCViewLink /* None */,
    PPtr<InspectPCView> m_InspectPCView /* NeedsAlign */,
    PPtr<IngameMenuNewPCView> m_IngameMenuPCView /* None */,
    PPtr<IngameMenuSettingsButtonPCView> m_IngameMenuSettingsButtonPCView /* None */,
    PPtr<PartyPCView> m_PartyPCView /* None */,
    UIViewLink_2 m_VendorPCViewLink /* None */,
    PPtr<ShipCustomizationPCView> m_ShipCustomizationPCView /* NeedsAlign */,
    PPtr<GameOverPCView> m_GameOverPCView /* None */,
    PPtr<SubtitleView> m_SubtitleView /* None */,
    PPtr<CreditsPCView> m_CreditsPCView /* None */,
    PPtr<SpaceCombatPCView> m_SpaceCombatPCView /* None */,
    PPtr<CombatLogPCView> m_CombatLogPCView /* None */,
    float m_CombatLogSpaceCombatPosition /* None */,
    float m_CombatLogSpacePostion /* None */,
    PPtr<SystemMapPCView> m_SystemMapPCView /* None */,
    PPtr<ZoneExitPCView> m_ZoneExitPCView /* None */,
    PPtr<ShipHealthAndRepairPCView> m_ShipHealthAndRepairPCView /* None */,
    PPtr<SystemMapSpaceResourcesPCView> m_SystemMapSpaceResourcesPCView /* None */,
    PPtr<ExplorationPCView> m_ExplorationPCView /* None */,
    PPtr<AnomalyPCView> m_AnomalyPCView /* None */,
    PPtr<PointMarkersPCView> m_SpacePointMarkersPCView /* None */,
    PPtr<SystemTitleView> m_SystemTitleView /* None */,
    PPtr<ShipPositionRulersView> m_ShipPositionRulersView /* None */,
    PPtr<CircleArcsView> m_SystemMapCircleArcsView /* None */,
    PPtr<SystemScannerView> m_SystemScannerView /* None */,
    PPtr<SystemMapNoisesView> m_SystemMapNoisesView /* None */,
    PPtr<SystemMapShipTrajectoryView> m_SystemMapShipTrajectoryView /* None */,
    PPtr<SectorMapPCView> m_SectorMapPCView /* None */,
    PPtr<ExperienceNotificationPCView> m_ExperienceNotificationPCView /* None */,
    PPtr<EncyclopediaNotificationPCView> m_EncyclopediaNotificationPCView /* None */,
    PPtr<ColonyNotificationPCView> m_ColonyNotificationPCView /* None */,
    PPtr<MiningNotificationPCView> m_MiningNotificationPCView /* None */,
    PPtr<ColonyEventIngameMenuNotificatorPCView> m_ColonyEventIngameMenuNotificatorPCView /* None */,
    PPtr<VendorSelectingWindowPCView> m_VendorSelectingWindowContextPCView /* None */)
{
    public static SpaceStaticPartPCView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_UIVisibilityView */
        PPtr<UIVisibilityView> _m_UIVisibilityView = PPtr<UIVisibilityView>.Read(reader);
        PPtr<CanvasScalerWorkaround> _m_CanvasScalerWorkaround = PPtr<CanvasScalerWorkaround>.Read(reader);
        PPtr<ServiceWindowsPCView> _m_ServiceWindowsPCView = PPtr<ServiceWindowsPCView>.Read(reader);
        PPtr<LootContextPCView> _m_LootContextPCView = PPtr<LootContextPCView>.Read(reader);
        PPtr<DialogContextPCView> _m_DialogContextPCView = PPtr<DialogContextPCView>.Read(reader);
        PPtr<GroupChangerContextPCView> _m_GroupChangerContextPCView = PPtr<GroupChangerContextPCView>.Read(reader);
        UIViewLink_2 _m_TransitionPCViewLink = UIViewLink_2.Read(reader);
        reader.AlignTo(4); /* m_InspectPCView */
        PPtr<InspectPCView> _m_InspectPCView = PPtr<InspectPCView>.Read(reader);
        PPtr<IngameMenuNewPCView> _m_IngameMenuPCView = PPtr<IngameMenuNewPCView>.Read(reader);
        PPtr<IngameMenuSettingsButtonPCView> _m_IngameMenuSettingsButtonPCView = PPtr<IngameMenuSettingsButtonPCView>.Read(reader);
        PPtr<PartyPCView> _m_PartyPCView = PPtr<PartyPCView>.Read(reader);
        UIViewLink_2 _m_VendorPCViewLink = UIViewLink_2.Read(reader);
        reader.AlignTo(4); /* m_ShipCustomizationPCView */
        PPtr<ShipCustomizationPCView> _m_ShipCustomizationPCView = PPtr<ShipCustomizationPCView>.Read(reader);
        PPtr<GameOverPCView> _m_GameOverPCView = PPtr<GameOverPCView>.Read(reader);
        PPtr<SubtitleView> _m_SubtitleView = PPtr<SubtitleView>.Read(reader);
        PPtr<CreditsPCView> _m_CreditsPCView = PPtr<CreditsPCView>.Read(reader);
        PPtr<SpaceCombatPCView> _m_SpaceCombatPCView = PPtr<SpaceCombatPCView>.Read(reader);
        PPtr<CombatLogPCView> _m_CombatLogPCView = PPtr<CombatLogPCView>.Read(reader);
        float _m_CombatLogSpaceCombatPosition = reader.ReadF32();
        float _m_CombatLogSpacePostion = reader.ReadF32();
        PPtr<SystemMapPCView> _m_SystemMapPCView = PPtr<SystemMapPCView>.Read(reader);
        PPtr<ZoneExitPCView> _m_ZoneExitPCView = PPtr<ZoneExitPCView>.Read(reader);
        PPtr<ShipHealthAndRepairPCView> _m_ShipHealthAndRepairPCView = PPtr<ShipHealthAndRepairPCView>.Read(reader);
        PPtr<SystemMapSpaceResourcesPCView> _m_SystemMapSpaceResourcesPCView = PPtr<SystemMapSpaceResourcesPCView>.Read(reader);
        PPtr<ExplorationPCView> _m_ExplorationPCView = PPtr<ExplorationPCView>.Read(reader);
        PPtr<AnomalyPCView> _m_AnomalyPCView = PPtr<AnomalyPCView>.Read(reader);
        PPtr<PointMarkersPCView> _m_SpacePointMarkersPCView = PPtr<PointMarkersPCView>.Read(reader);
        PPtr<SystemTitleView> _m_SystemTitleView = PPtr<SystemTitleView>.Read(reader);
        PPtr<ShipPositionRulersView> _m_ShipPositionRulersView = PPtr<ShipPositionRulersView>.Read(reader);
        PPtr<CircleArcsView> _m_SystemMapCircleArcsView = PPtr<CircleArcsView>.Read(reader);
        PPtr<SystemScannerView> _m_SystemScannerView = PPtr<SystemScannerView>.Read(reader);
        PPtr<SystemMapNoisesView> _m_SystemMapNoisesView = PPtr<SystemMapNoisesView>.Read(reader);
        PPtr<SystemMapShipTrajectoryView> _m_SystemMapShipTrajectoryView = PPtr<SystemMapShipTrajectoryView>.Read(reader);
        PPtr<SectorMapPCView> _m_SectorMapPCView = PPtr<SectorMapPCView>.Read(reader);
        PPtr<ExperienceNotificationPCView> _m_ExperienceNotificationPCView = PPtr<ExperienceNotificationPCView>.Read(reader);
        PPtr<EncyclopediaNotificationPCView> _m_EncyclopediaNotificationPCView = PPtr<EncyclopediaNotificationPCView>.Read(reader);
        PPtr<ColonyNotificationPCView> _m_ColonyNotificationPCView = PPtr<ColonyNotificationPCView>.Read(reader);
        PPtr<MiningNotificationPCView> _m_MiningNotificationPCView = PPtr<MiningNotificationPCView>.Read(reader);
        PPtr<ColonyEventIngameMenuNotificatorPCView> _m_ColonyEventIngameMenuNotificatorPCView = PPtr<ColonyEventIngameMenuNotificatorPCView>.Read(reader);
        PPtr<VendorSelectingWindowPCView> _m_VendorSelectingWindowContextPCView = PPtr<VendorSelectingWindowPCView>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_UIVisibilityView,
            _m_CanvasScalerWorkaround,
            _m_ServiceWindowsPCView,
            _m_LootContextPCView,
            _m_DialogContextPCView,
            _m_GroupChangerContextPCView,
            _m_TransitionPCViewLink,
            _m_InspectPCView,
            _m_IngameMenuPCView,
            _m_IngameMenuSettingsButtonPCView,
            _m_PartyPCView,
            _m_VendorPCViewLink,
            _m_ShipCustomizationPCView,
            _m_GameOverPCView,
            _m_SubtitleView,
            _m_CreditsPCView,
            _m_SpaceCombatPCView,
            _m_CombatLogPCView,
            _m_CombatLogSpaceCombatPosition,
            _m_CombatLogSpacePostion,
            _m_SystemMapPCView,
            _m_ZoneExitPCView,
            _m_ShipHealthAndRepairPCView,
            _m_SystemMapSpaceResourcesPCView,
            _m_ExplorationPCView,
            _m_AnomalyPCView,
            _m_SpacePointMarkersPCView,
            _m_SystemTitleView,
            _m_ShipPositionRulersView,
            _m_SystemMapCircleArcsView,
            _m_SystemScannerView,
            _m_SystemMapNoisesView,
            _m_SystemMapShipTrajectoryView,
            _m_SectorMapPCView,
            _m_ExperienceNotificationPCView,
            _m_EncyclopediaNotificationPCView,
            _m_ColonyNotificationPCView,
            _m_MiningNotificationPCView,
            _m_ColonyEventIngameMenuNotificatorPCView,
            _m_VendorSelectingWindowContextPCView);
    }
}


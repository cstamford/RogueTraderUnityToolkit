namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $SpaceStaticPartConsoleView (44 fields) 447CB64F1E79D8FE35EB072ED279B6A7/8C6B6CB20B4DD9A9FFCEA9FCEB06F6BA */
public record class SpaceStaticPartConsoleView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<UIVisibilityView> m_UIVisibilityView /* NeedsAlign */,
    PPtr<CanvasScalerWorkaround> m_CanvasScalerWorkaround /* None */,
    PPtr<ServiceWindowsConsoleView> m_ServiceWindowsConsoleView /* None */,
    PPtr<LootContextConsoleView> m_LootContextConsoleView /* None */,
    PPtr<GroupChangerContextConsoleView> m_GroupChangerContextConsoleView /* None */,
    UIViewLink_2 m_TransitionConsoleViewLink /* None */,
    PPtr<DialogContextConsoleView> m_DialogContextConsoleView /* NeedsAlign */,
    PPtr<IngameMenuConsoleView> m_IngameMenuConsoleView /* None */,
    PPtr<CombatLogConsoleView> m_CombatLogConsoleView /* None */,
    PPtr<InspectConsoleView> m_InspectConsoleView /* None */,
    PPtr<PartySelectorConsoleView> m_PartySelectorConsoleView /* None */,
    UIViewLink_2 m_VendorConsoleViewLink /* None */,
    PPtr<GameOverConsoleView> m_GameOverConsoleView /* NeedsAlign */,
    PPtr<CreditsConsoleView> m_CreditsConsoleView /* None */,
    PPtr<SpaceCombatConsoleView> m_SpaceCombatConsoleView /* None */,
    PPtr<SystemMapConsoleView> m_SystemMapConsoleView /* None */,
    PPtr<ZoneExitConsoleView> m_ZoneExitConsoleView /* None */,
    PPtr<ShipHealthAndRepairConsoleView> m_ShipHealthAndRepairConsoleView /* None */,
    PPtr<SystemMapSpaceResourcesPCView> m_SystemMapSpaceResourcesPCView /* None */,
    PPtr<ExplorationConsoleView> m_ExplorationConsoleView /* None */,
    PPtr<AnomalyConsoleView> m_AnomalyConsoleView /* None */,
    PPtr<PointMarkersPCView> m_SpacePointMarkersPCView /* None */,
    PPtr<VendorSelectingWindowConsoleView> m_VendorSelectingWindowContextConsoleView /* None */,
    PPtr<SystemTitleView> m_SystemTitleView /* None */,
    PPtr<ShipPositionRulersView> m_ShipPositionRulersView /* None */,
    PPtr<CircleArcsView> m_SystemMapCircleArcsView /* None */,
    PPtr<SystemScannerView> m_SystemScannerView /* None */,
    PPtr<SystemMapNoisesView> m_SystemMapNoisesView /* None */,
    PPtr<SystemMapShipTrajectoryView> m_SystemMapShipTrajectoryView /* None */,
    PPtr<SectorMapConsoleView> m_SectorMapConsoleView /* None */,
    PPtr<ExperienceNotificationPCView> m_ExperienceNotificationPCView /* None */,
    PPtr<EncyclopediaNotificationConsoleView> m_EncyclopediaNotificationConsoleView /* None */,
    PPtr<ColonyNotificationConsoleView> m_ColonyNotificationConsoleView /* None */,
    PPtr<MiningNotificationConsoleView> m_MiningNotificationConsoleView /* None */,
    PPtr<ConsoleHint> m_ShowResourcesHint /* None */,
    PPtr<ConsoleHint> m_CloseResourcesHint /* None */,
    PPtr<ConsoleHint> m_MenuHint /* None */,
    PPtr<ConsoleHint> m_PointerHint /* None */,
    PPtr<ConsoleHint> m_CoopRolesHint /* None */,
    PPtr<Image> m_NetRolesAttentionMark /* None */)
{
    public static SpaceStaticPartConsoleView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_UIVisibilityView */
        PPtr<UIVisibilityView> _m_UIVisibilityView = PPtr<UIVisibilityView>.Read(reader);
        PPtr<CanvasScalerWorkaround> _m_CanvasScalerWorkaround = PPtr<CanvasScalerWorkaround>.Read(reader);
        PPtr<ServiceWindowsConsoleView> _m_ServiceWindowsConsoleView = PPtr<ServiceWindowsConsoleView>.Read(reader);
        PPtr<LootContextConsoleView> _m_LootContextConsoleView = PPtr<LootContextConsoleView>.Read(reader);
        PPtr<GroupChangerContextConsoleView> _m_GroupChangerContextConsoleView = PPtr<GroupChangerContextConsoleView>.Read(reader);
        UIViewLink_2 _m_TransitionConsoleViewLink = UIViewLink_2.Read(reader);
        reader.AlignTo(4); /* m_DialogContextConsoleView */
        PPtr<DialogContextConsoleView> _m_DialogContextConsoleView = PPtr<DialogContextConsoleView>.Read(reader);
        PPtr<IngameMenuConsoleView> _m_IngameMenuConsoleView = PPtr<IngameMenuConsoleView>.Read(reader);
        PPtr<CombatLogConsoleView> _m_CombatLogConsoleView = PPtr<CombatLogConsoleView>.Read(reader);
        PPtr<InspectConsoleView> _m_InspectConsoleView = PPtr<InspectConsoleView>.Read(reader);
        PPtr<PartySelectorConsoleView> _m_PartySelectorConsoleView = PPtr<PartySelectorConsoleView>.Read(reader);
        UIViewLink_2 _m_VendorConsoleViewLink = UIViewLink_2.Read(reader);
        reader.AlignTo(4); /* m_GameOverConsoleView */
        PPtr<GameOverConsoleView> _m_GameOverConsoleView = PPtr<GameOverConsoleView>.Read(reader);
        PPtr<CreditsConsoleView> _m_CreditsConsoleView = PPtr<CreditsConsoleView>.Read(reader);
        PPtr<SpaceCombatConsoleView> _m_SpaceCombatConsoleView = PPtr<SpaceCombatConsoleView>.Read(reader);
        PPtr<SystemMapConsoleView> _m_SystemMapConsoleView = PPtr<SystemMapConsoleView>.Read(reader);
        PPtr<ZoneExitConsoleView> _m_ZoneExitConsoleView = PPtr<ZoneExitConsoleView>.Read(reader);
        PPtr<ShipHealthAndRepairConsoleView> _m_ShipHealthAndRepairConsoleView = PPtr<ShipHealthAndRepairConsoleView>.Read(reader);
        PPtr<SystemMapSpaceResourcesPCView> _m_SystemMapSpaceResourcesPCView = PPtr<SystemMapSpaceResourcesPCView>.Read(reader);
        PPtr<ExplorationConsoleView> _m_ExplorationConsoleView = PPtr<ExplorationConsoleView>.Read(reader);
        PPtr<AnomalyConsoleView> _m_AnomalyConsoleView = PPtr<AnomalyConsoleView>.Read(reader);
        PPtr<PointMarkersPCView> _m_SpacePointMarkersPCView = PPtr<PointMarkersPCView>.Read(reader);
        PPtr<VendorSelectingWindowConsoleView> _m_VendorSelectingWindowContextConsoleView = PPtr<VendorSelectingWindowConsoleView>.Read(reader);
        PPtr<SystemTitleView> _m_SystemTitleView = PPtr<SystemTitleView>.Read(reader);
        PPtr<ShipPositionRulersView> _m_ShipPositionRulersView = PPtr<ShipPositionRulersView>.Read(reader);
        PPtr<CircleArcsView> _m_SystemMapCircleArcsView = PPtr<CircleArcsView>.Read(reader);
        PPtr<SystemScannerView> _m_SystemScannerView = PPtr<SystemScannerView>.Read(reader);
        PPtr<SystemMapNoisesView> _m_SystemMapNoisesView = PPtr<SystemMapNoisesView>.Read(reader);
        PPtr<SystemMapShipTrajectoryView> _m_SystemMapShipTrajectoryView = PPtr<SystemMapShipTrajectoryView>.Read(reader);
        PPtr<SectorMapConsoleView> _m_SectorMapConsoleView = PPtr<SectorMapConsoleView>.Read(reader);
        PPtr<ExperienceNotificationPCView> _m_ExperienceNotificationPCView = PPtr<ExperienceNotificationPCView>.Read(reader);
        PPtr<EncyclopediaNotificationConsoleView> _m_EncyclopediaNotificationConsoleView = PPtr<EncyclopediaNotificationConsoleView>.Read(reader);
        PPtr<ColonyNotificationConsoleView> _m_ColonyNotificationConsoleView = PPtr<ColonyNotificationConsoleView>.Read(reader);
        PPtr<MiningNotificationConsoleView> _m_MiningNotificationConsoleView = PPtr<MiningNotificationConsoleView>.Read(reader);
        PPtr<ConsoleHint> _m_ShowResourcesHint = PPtr<ConsoleHint>.Read(reader);
        PPtr<ConsoleHint> _m_CloseResourcesHint = PPtr<ConsoleHint>.Read(reader);
        PPtr<ConsoleHint> _m_MenuHint = PPtr<ConsoleHint>.Read(reader);
        PPtr<ConsoleHint> _m_PointerHint = PPtr<ConsoleHint>.Read(reader);
        PPtr<ConsoleHint> _m_CoopRolesHint = PPtr<ConsoleHint>.Read(reader);
        PPtr<Image> _m_NetRolesAttentionMark = PPtr<Image>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_UIVisibilityView,
            _m_CanvasScalerWorkaround,
            _m_ServiceWindowsConsoleView,
            _m_LootContextConsoleView,
            _m_GroupChangerContextConsoleView,
            _m_TransitionConsoleViewLink,
            _m_DialogContextConsoleView,
            _m_IngameMenuConsoleView,
            _m_CombatLogConsoleView,
            _m_InspectConsoleView,
            _m_PartySelectorConsoleView,
            _m_VendorConsoleViewLink,
            _m_GameOverConsoleView,
            _m_CreditsConsoleView,
            _m_SpaceCombatConsoleView,
            _m_SystemMapConsoleView,
            _m_ZoneExitConsoleView,
            _m_ShipHealthAndRepairConsoleView,
            _m_SystemMapSpaceResourcesPCView,
            _m_ExplorationConsoleView,
            _m_AnomalyConsoleView,
            _m_SpacePointMarkersPCView,
            _m_VendorSelectingWindowContextConsoleView,
            _m_SystemTitleView,
            _m_ShipPositionRulersView,
            _m_SystemMapCircleArcsView,
            _m_SystemScannerView,
            _m_SystemMapNoisesView,
            _m_SystemMapShipTrajectoryView,
            _m_SectorMapConsoleView,
            _m_ExperienceNotificationPCView,
            _m_EncyclopediaNotificationConsoleView,
            _m_ColonyNotificationConsoleView,
            _m_MiningNotificationConsoleView,
            _m_ShowResourcesHint,
            _m_CloseResourcesHint,
            _m_MenuHint,
            _m_PointerHint,
            _m_CoopRolesHint,
            _m_NetRolesAttentionMark);
    }
}


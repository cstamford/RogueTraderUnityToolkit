namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $UIStrings (69 fields) DC9017D0342FD578B323FAFBA1EB4335/11B97E3EEDAEC83263CE11DB880407BA */
public record class UIStrings(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    UIMeinMenuTexts MainMenu /* NeedsAlign */,
    UITextCharSheet CharacterSheet /* NeedsAlign */,
    UITextInventory InventoryScreen /* NeedsAlign */,
    UITextGlobalMap GlobalMap /* NeedsAlign */,
    UITextSystemMap SystemMap /* NeedsAlign */,
    UITextGlobalMapPassages GlobalMapPassages /* NeedsAlign */,
    UITextBookEvent BookEvent /* NeedsAlign */,
    UITextAlignment Alignment /* NeedsAlign */,
    UITextActionBar ActionBar /* NeedsAlign */,
    UICommonTexts CommonTexts /* NeedsAlign */,
    UIPartySelectorTexts PartyTexts /* NeedsAlign */,
    UINetLobbyTexts NetLobbyTexts /* NeedsAlign */,
    UINetRolesTexts NetRolesTexts /* NeedsAlign */,
    UINetLobbyErrorsTexts NetLobbyErrorsTexts /* NeedsAlign */,
    UIActionText ActionTexts /* NeedsAlign */,
    UITooltips Tooltips /* NeedsAlign */,
    UITooltipElementLabels TooltipsElementLabels /* NeedsAlign */,
    UISkillcheckTooltip SkillcheckTooltips /* NeedsAlign */,
    UITutorial Tutorial /* NeedsAlign */,
    UITextSettingsUI SettingsUI /* NeedsAlign */,
    UICombatTexts CombatTexts /* NeedsAlign */,
    UITurnBasedTexts TurnBasedTexts /* NeedsAlign */,
    UISpaceCombatTexts SpaceCombatTexts /* NeedsAlign */,
    UIExplorationTexts ExplorationTexts /* NeedsAlign */,
    UIColonizationTexts ColonizationTexts /* NeedsAlign */,
    UIColonyProjectsTexts ColonyProjectsTexts /* NeedsAlign */,
    UIColonyProjectsRewards ColonyProjectsRewards /* NeedsAlign */,
    UIColonyProjectsRequirements ColonyProjectsRequirements /* NeedsAlign */,
    UIColonyNotificationTexts ColonyNotificationTexts /* NeedsAlign */,
    UIColonyEventsTexts ColonyEventsTexts /* NeedsAlign */,
    UIColonyTraitsTexts ColonyTraitsTexts /* NeedsAlign */,
    UITermsOfUseTexts TermsOfUseTexts /* NeedsAlign */,
    UIDialog Dialog /* NeedsAlign */,
    UISaveLoadTexts SaveLoadTexts /* NeedsAlign */,
    UIVendor Vendor /* NeedsAlign */,
    UIShipCustomization ShipCustomization /* NeedsAlign */,
    UICharGen CharGen /* NeedsAlign */,
    UINewGame NewGameWin /* NeedsAlign */,
    UIGameOverScreen GameOverScreen /* NeedsAlign */,
    UINotificationTexts NotificationTexts /* NeedsAlign */,
    UIQuestNotificationTexts QuestNotificationTexts /* NeedsAlign */,
    UIKeyboardTexts KeyboardTexts /* NeedsAlign */,
    UILoot LootWindow /* NeedsAlign */,
    UIQuesJournalTexts QuesJournalTexts /* NeedsAlign */,
    UITransitionTexts Transition /* NeedsAlign */,
    GroupChangerTexts GroupChangerTexts /* NeedsAlign */,
    UIContextMenu ContextMenu /* NeedsAlign */,
    EncyclopediaTexts EncyclopediaTexts /* NeedsAlign */,
    UIControllerModeTexts ControllerModeTexts /* NeedsAlign */,
    UIProfitFactorTexts ProfitFactorTexts /* NeedsAlign */,
    UIBugReport UIBugReport /* NeedsAlign */,
    UIFeedbackPopupTexts FeedbackPopupTexts /* NeedsAlign */,
    UIAbilityTexts AbilityTexts /* NeedsAlign */,
    UICargoTexts CargoTexts /* NeedsAlign */,
    UIPropertyNames UIPropertyNames /* NeedsAlign */,
    HUDTexts HUDTexts /* NeedsAlign */,
    UIxBoxTexts XBoxTexts /* NeedsAlign */,
    UICombatLogTexts CombatLog /* NeedsAlign */,
    UIInspect Inspect /* NeedsAlign */,
    UIInteractableSettingsReasons InteractableSettingsReasons /* NeedsAlign */,
    UIOvertips Overtips /* NeedsAlign */,
    UIFormationTexts FormationTexts /* NeedsAlign */,
    UILocalMapTexts LocalMapTexts /* NeedsAlign */,
    UICredits Credits /* NeedsAlign */,
    UIEscapeMenu EscapeMenu /* NeedsAlign */)
{
    public static UIStrings Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* MainMenu */
        UIMeinMenuTexts _MainMenu = UIMeinMenuTexts.Read(reader);
        reader.AlignTo(4); /* CharacterSheet */
        UITextCharSheet _CharacterSheet = UITextCharSheet.Read(reader);
        reader.AlignTo(4); /* InventoryScreen */
        UITextInventory _InventoryScreen = UITextInventory.Read(reader);
        reader.AlignTo(4); /* GlobalMap */
        UITextGlobalMap _GlobalMap = UITextGlobalMap.Read(reader);
        reader.AlignTo(4); /* SystemMap */
        UITextSystemMap _SystemMap = UITextSystemMap.Read(reader);
        reader.AlignTo(4); /* GlobalMapPassages */
        UITextGlobalMapPassages _GlobalMapPassages = UITextGlobalMapPassages.Read(reader);
        reader.AlignTo(4); /* BookEvent */
        UITextBookEvent _BookEvent = UITextBookEvent.Read(reader);
        reader.AlignTo(4); /* Alignment */
        UITextAlignment _Alignment = UITextAlignment.Read(reader);
        reader.AlignTo(4); /* ActionBar */
        UITextActionBar _ActionBar = UITextActionBar.Read(reader);
        reader.AlignTo(4); /* CommonTexts */
        UICommonTexts _CommonTexts = UICommonTexts.Read(reader);
        reader.AlignTo(4); /* PartyTexts */
        UIPartySelectorTexts _PartyTexts = UIPartySelectorTexts.Read(reader);
        reader.AlignTo(4); /* NetLobbyTexts */
        UINetLobbyTexts _NetLobbyTexts = UINetLobbyTexts.Read(reader);
        reader.AlignTo(4); /* NetRolesTexts */
        UINetRolesTexts _NetRolesTexts = UINetRolesTexts.Read(reader);
        reader.AlignTo(4); /* NetLobbyErrorsTexts */
        UINetLobbyErrorsTexts _NetLobbyErrorsTexts = UINetLobbyErrorsTexts.Read(reader);
        reader.AlignTo(4); /* ActionTexts */
        UIActionText _ActionTexts = UIActionText.Read(reader);
        reader.AlignTo(4); /* Tooltips */
        UITooltips _Tooltips = UITooltips.Read(reader);
        reader.AlignTo(4); /* TooltipsElementLabels */
        UITooltipElementLabels _TooltipsElementLabels = UITooltipElementLabels.Read(reader);
        reader.AlignTo(4); /* SkillcheckTooltips */
        UISkillcheckTooltip _SkillcheckTooltips = UISkillcheckTooltip.Read(reader);
        reader.AlignTo(4); /* Tutorial */
        UITutorial _Tutorial = UITutorial.Read(reader);
        reader.AlignTo(4); /* SettingsUI */
        UITextSettingsUI _SettingsUI = UITextSettingsUI.Read(reader);
        reader.AlignTo(4); /* CombatTexts */
        UICombatTexts _CombatTexts = UICombatTexts.Read(reader);
        reader.AlignTo(4); /* TurnBasedTexts */
        UITurnBasedTexts _TurnBasedTexts = UITurnBasedTexts.Read(reader);
        reader.AlignTo(4); /* SpaceCombatTexts */
        UISpaceCombatTexts _SpaceCombatTexts = UISpaceCombatTexts.Read(reader);
        reader.AlignTo(4); /* ExplorationTexts */
        UIExplorationTexts _ExplorationTexts = UIExplorationTexts.Read(reader);
        reader.AlignTo(4); /* ColonizationTexts */
        UIColonizationTexts _ColonizationTexts = UIColonizationTexts.Read(reader);
        reader.AlignTo(4); /* ColonyProjectsTexts */
        UIColonyProjectsTexts _ColonyProjectsTexts = UIColonyProjectsTexts.Read(reader);
        reader.AlignTo(4); /* ColonyProjectsRewards */
        UIColonyProjectsRewards _ColonyProjectsRewards = UIColonyProjectsRewards.Read(reader);
        reader.AlignTo(4); /* ColonyProjectsRequirements */
        UIColonyProjectsRequirements _ColonyProjectsRequirements = UIColonyProjectsRequirements.Read(reader);
        reader.AlignTo(4); /* ColonyNotificationTexts */
        UIColonyNotificationTexts _ColonyNotificationTexts = UIColonyNotificationTexts.Read(reader);
        reader.AlignTo(4); /* ColonyEventsTexts */
        UIColonyEventsTexts _ColonyEventsTexts = UIColonyEventsTexts.Read(reader);
        reader.AlignTo(4); /* ColonyTraitsTexts */
        UIColonyTraitsTexts _ColonyTraitsTexts = UIColonyTraitsTexts.Read(reader);
        reader.AlignTo(4); /* TermsOfUseTexts */
        UITermsOfUseTexts _TermsOfUseTexts = UITermsOfUseTexts.Read(reader);
        reader.AlignTo(4); /* Dialog */
        UIDialog _Dialog = UIDialog.Read(reader);
        reader.AlignTo(4); /* SaveLoadTexts */
        UISaveLoadTexts _SaveLoadTexts = UISaveLoadTexts.Read(reader);
        reader.AlignTo(4); /* Vendor */
        UIVendor _Vendor = UIVendor.Read(reader);
        reader.AlignTo(4); /* ShipCustomization */
        UIShipCustomization _ShipCustomization = UIShipCustomization.Read(reader);
        reader.AlignTo(4); /* CharGen */
        UICharGen _CharGen = UICharGen.Read(reader);
        reader.AlignTo(4); /* NewGameWin */
        UINewGame _NewGameWin = UINewGame.Read(reader);
        reader.AlignTo(4); /* GameOverScreen */
        UIGameOverScreen _GameOverScreen = UIGameOverScreen.Read(reader);
        reader.AlignTo(4); /* NotificationTexts */
        UINotificationTexts _NotificationTexts = UINotificationTexts.Read(reader);
        reader.AlignTo(4); /* QuestNotificationTexts */
        UIQuestNotificationTexts _QuestNotificationTexts = UIQuestNotificationTexts.Read(reader);
        reader.AlignTo(4); /* KeyboardTexts */
        UIKeyboardTexts _KeyboardTexts = UIKeyboardTexts.Read(reader);
        reader.AlignTo(4); /* LootWindow */
        UILoot _LootWindow = UILoot.Read(reader);
        reader.AlignTo(4); /* QuesJournalTexts */
        UIQuesJournalTexts _QuesJournalTexts = UIQuesJournalTexts.Read(reader);
        reader.AlignTo(4); /* Transition */
        UITransitionTexts _Transition = UITransitionTexts.Read(reader);
        reader.AlignTo(4); /* GroupChangerTexts */
        GroupChangerTexts _GroupChangerTexts = GroupChangerTexts.Read(reader);
        reader.AlignTo(4); /* ContextMenu */
        UIContextMenu _ContextMenu = UIContextMenu.Read(reader);
        reader.AlignTo(4); /* EncyclopediaTexts */
        EncyclopediaTexts _EncyclopediaTexts = EncyclopediaTexts.Read(reader);
        reader.AlignTo(4); /* ControllerModeTexts */
        UIControllerModeTexts _ControllerModeTexts = UIControllerModeTexts.Read(reader);
        reader.AlignTo(4); /* ProfitFactorTexts */
        UIProfitFactorTexts _ProfitFactorTexts = UIProfitFactorTexts.Read(reader);
        reader.AlignTo(4); /* UIBugReport */
        UIBugReport _UIBugReport = UIBugReport.Read(reader);
        reader.AlignTo(4); /* FeedbackPopupTexts */
        UIFeedbackPopupTexts _FeedbackPopupTexts = UIFeedbackPopupTexts.Read(reader);
        reader.AlignTo(4); /* AbilityTexts */
        UIAbilityTexts _AbilityTexts = UIAbilityTexts.Read(reader);
        reader.AlignTo(4); /* CargoTexts */
        UICargoTexts _CargoTexts = UICargoTexts.Read(reader);
        reader.AlignTo(4); /* UIPropertyNames */
        UIPropertyNames _UIPropertyNames = UIPropertyNames.Read(reader);
        reader.AlignTo(4); /* HUDTexts */
        HUDTexts _HUDTexts = HUDTexts.Read(reader);
        reader.AlignTo(4); /* XBoxTexts */
        UIxBoxTexts _XBoxTexts = UIxBoxTexts.Read(reader);
        reader.AlignTo(4); /* CombatLog */
        UICombatLogTexts _CombatLog = UICombatLogTexts.Read(reader);
        reader.AlignTo(4); /* Inspect */
        UIInspect _Inspect = UIInspect.Read(reader);
        reader.AlignTo(4); /* InteractableSettingsReasons */
        UIInteractableSettingsReasons _InteractableSettingsReasons = UIInteractableSettingsReasons.Read(reader);
        reader.AlignTo(4); /* Overtips */
        UIOvertips _Overtips = UIOvertips.Read(reader);
        reader.AlignTo(4); /* FormationTexts */
        UIFormationTexts _FormationTexts = UIFormationTexts.Read(reader);
        reader.AlignTo(4); /* LocalMapTexts */
        UILocalMapTexts _LocalMapTexts = UILocalMapTexts.Read(reader);
        reader.AlignTo(4); /* Credits */
        UICredits _Credits = UICredits.Read(reader);
        reader.AlignTo(4); /* EscapeMenu */
        UIEscapeMenu _EscapeMenu = UIEscapeMenu.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _MainMenu,
            _CharacterSheet,
            _InventoryScreen,
            _GlobalMap,
            _SystemMap,
            _GlobalMapPassages,
            _BookEvent,
            _Alignment,
            _ActionBar,
            _CommonTexts,
            _PartyTexts,
            _NetLobbyTexts,
            _NetRolesTexts,
            _NetLobbyErrorsTexts,
            _ActionTexts,
            _Tooltips,
            _TooltipsElementLabels,
            _SkillcheckTooltips,
            _Tutorial,
            _SettingsUI,
            _CombatTexts,
            _TurnBasedTexts,
            _SpaceCombatTexts,
            _ExplorationTexts,
            _ColonizationTexts,
            _ColonyProjectsTexts,
            _ColonyProjectsRewards,
            _ColonyProjectsRequirements,
            _ColonyNotificationTexts,
            _ColonyEventsTexts,
            _ColonyTraitsTexts,
            _TermsOfUseTexts,
            _Dialog,
            _SaveLoadTexts,
            _Vendor,
            _ShipCustomization,
            _CharGen,
            _NewGameWin,
            _GameOverScreen,
            _NotificationTexts,
            _QuestNotificationTexts,
            _KeyboardTexts,
            _LootWindow,
            _QuesJournalTexts,
            _Transition,
            _GroupChangerTexts,
            _ContextMenu,
            _EncyclopediaTexts,
            _ControllerModeTexts,
            _ProfitFactorTexts,
            _UIBugReport,
            _FeedbackPopupTexts,
            _AbilityTexts,
            _CargoTexts,
            _UIPropertyNames,
            _HUDTexts,
            _XBoxTexts,
            _CombatLog,
            _Inspect,
            _InteractableSettingsReasons,
            _Overtips,
            _FormationTexts,
            _LocalMapTexts,
            _Credits,
            _EscapeMenu);
    }
}


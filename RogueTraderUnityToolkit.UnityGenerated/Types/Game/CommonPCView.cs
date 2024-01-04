namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $CommonPCView (27 fields) 59A2D10E689EE8F7A9CA8A7789B26D12/E3DDAC9C4E39B2462EFC0111248E6490 */
public record class CommonPCView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<UIVisibilityView> m_UIVisibilityCommonView /* NeedsAlign */,
    PPtr<UIVisibilityView> m_UIVisibilityBugReportView /* None */,
    PPtr<EscMenuContextPCView> m_EscMenuContextPCView /* None */,
    PPtr<TooltipContextPCView> m_TooltipContextPCView /* None */,
    PPtr<QuestNotificatorPCView> m_QuestNotificatorPCView /* None */,
    PPtr<LoadingScreenPCView> m_LoadingScreenPCView /* None */,
    PPtr<TutorialPCView> m_TutorialPCView /* None */,
    PPtr<MessageBoxPCView> m_MessageBoxPCView /* None */,
    PPtr<CounterWindowPCView> m_CounterWindowPCView /* None */,
    PPtr<ContextMenuPCView> m_ContextMenuPCView /* None */,
    PPtr<SaveLoadPCView> m_SaveLoadPCView /* None */,
    PPtr<SettingsPCView> m_SettingsPCView /* None */,
    PPtr<GamepadConnectedInKeyboardModeWindowView> m_GamepadConnectedInKeyboardModeWindowView /* None */,
    PPtr<PauseNotification> m_PauseNotification /* None */,
    PPtr<WarningsTextView> m_WarningsTextView /* None */,
    PPtr<FadeView> m_FadeView /* None */,
    PPtr<DragNDropManager> m_DragNDropManager /* None */,
    PPtr<MultiplySelection> m_MultiplySelection /* None */,
    PPtr<OwlcatModificationsWindow> m_OwlcatModificationsWindow /* None */,
    PPtr<BugReportPCView> m_BugReportView /* None */,
    PPtr<NetLobbyPCView> m_NetLobbyPCView /* None */,
    PPtr<NetRolesPCView> m_NetRolesPCView /* None */,
    PPtr<TitlesBaseView> m_TitlesView /* None */)
{
    public static CommonPCView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_UIVisibilityCommonView */
        PPtr<UIVisibilityView> _m_UIVisibilityCommonView = PPtr<UIVisibilityView>.Read(reader);
        PPtr<UIVisibilityView> _m_UIVisibilityBugReportView = PPtr<UIVisibilityView>.Read(reader);
        PPtr<EscMenuContextPCView> _m_EscMenuContextPCView = PPtr<EscMenuContextPCView>.Read(reader);
        PPtr<TooltipContextPCView> _m_TooltipContextPCView = PPtr<TooltipContextPCView>.Read(reader);
        PPtr<QuestNotificatorPCView> _m_QuestNotificatorPCView = PPtr<QuestNotificatorPCView>.Read(reader);
        PPtr<LoadingScreenPCView> _m_LoadingScreenPCView = PPtr<LoadingScreenPCView>.Read(reader);
        PPtr<TutorialPCView> _m_TutorialPCView = PPtr<TutorialPCView>.Read(reader);
        PPtr<MessageBoxPCView> _m_MessageBoxPCView = PPtr<MessageBoxPCView>.Read(reader);
        PPtr<CounterWindowPCView> _m_CounterWindowPCView = PPtr<CounterWindowPCView>.Read(reader);
        PPtr<ContextMenuPCView> _m_ContextMenuPCView = PPtr<ContextMenuPCView>.Read(reader);
        PPtr<SaveLoadPCView> _m_SaveLoadPCView = PPtr<SaveLoadPCView>.Read(reader);
        PPtr<SettingsPCView> _m_SettingsPCView = PPtr<SettingsPCView>.Read(reader);
        PPtr<GamepadConnectedInKeyboardModeWindowView> _m_GamepadConnectedInKeyboardModeWindowView = PPtr<GamepadConnectedInKeyboardModeWindowView>.Read(reader);
        PPtr<PauseNotification> _m_PauseNotification = PPtr<PauseNotification>.Read(reader);
        PPtr<WarningsTextView> _m_WarningsTextView = PPtr<WarningsTextView>.Read(reader);
        PPtr<FadeView> _m_FadeView = PPtr<FadeView>.Read(reader);
        PPtr<DragNDropManager> _m_DragNDropManager = PPtr<DragNDropManager>.Read(reader);
        PPtr<MultiplySelection> _m_MultiplySelection = PPtr<MultiplySelection>.Read(reader);
        PPtr<OwlcatModificationsWindow> _m_OwlcatModificationsWindow = PPtr<OwlcatModificationsWindow>.Read(reader);
        PPtr<BugReportPCView> _m_BugReportView = PPtr<BugReportPCView>.Read(reader);
        PPtr<NetLobbyPCView> _m_NetLobbyPCView = PPtr<NetLobbyPCView>.Read(reader);
        PPtr<NetRolesPCView> _m_NetRolesPCView = PPtr<NetRolesPCView>.Read(reader);
        PPtr<TitlesBaseView> _m_TitlesView = PPtr<TitlesBaseView>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_UIVisibilityCommonView,
            _m_UIVisibilityBugReportView,
            _m_EscMenuContextPCView,
            _m_TooltipContextPCView,
            _m_QuestNotificatorPCView,
            _m_LoadingScreenPCView,
            _m_TutorialPCView,
            _m_MessageBoxPCView,
            _m_CounterWindowPCView,
            _m_ContextMenuPCView,
            _m_SaveLoadPCView,
            _m_SettingsPCView,
            _m_GamepadConnectedInKeyboardModeWindowView,
            _m_PauseNotification,
            _m_WarningsTextView,
            _m_FadeView,
            _m_DragNDropManager,
            _m_MultiplySelection,
            _m_OwlcatModificationsWindow,
            _m_BugReportView,
            _m_NetLobbyPCView,
            _m_NetRolesPCView,
            _m_TitlesView);
    }
}


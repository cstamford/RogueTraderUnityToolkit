namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $CommonConsoleView (25 fields) 96250A5ED8966578DE01E45C7AD22793/6BB3640FC116BEBDEFABA6397D4D9CB2 */
public record class CommonConsoleView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<UIVisibilityView> m_UIVisibilityCommonView /* NeedsAlign */,
    PPtr<UIVisibilityView> m_UIVisibilityBugReportView /* None */,
    PPtr<LoadingScreenConsoleView> m_LoadingScreenConsoleView /* None */,
    PPtr<TutorialConsoleView> m_TutorialView /* None */,
    PPtr<CounterWindowConsoleView> m_CounterWindowConsoleView /* None */,
    PPtr<ContextMenuConsoleView> m_ContextMenuConsoleView /* None */,
    PPtr<TooltipContextConsoleView> m_TooltipContextConsoleView /* None */,
    PPtr<QuestNotificatorConsoleView> m_QuestNotificatorConsoleView /* None */,
    PPtr<GamepadDisconnectedInGamepadModeWindowView> m_GamepadDisconnectedInGamepadModeWindowView /* None */,
    PPtr<PauseNotification> m_PauseNotification /* None */,
    PPtr<WarningsTextView> m_WarningsTextView /* None */,
    PPtr<MultiplySelection> m_MultiplySelection /* None */,
    PPtr<EscMenuContextConsoleView> m_EscMenuConsoleView /* None */,
    PPtr<MessageBoxConsoleView> m_MessageBoxConsoleView /* None */,
    PPtr<SaveLoadConsoleView> m_SaveLoadConsoleView /* None */,
    PPtr<SettingsConsoleView> m_SettingsView /* None */,
    PPtr<FadeView> m_FadeView /* None */,
    PPtr<BugReportBaseView> m_BugReportView /* None */,
    PPtr<NetLobbyConsoleView> m_NetLobbyConsoleView /* None */,
    PPtr<NetRolesConsoleView> m_NetRolesConsoleView /* None */,
    PPtr<TitlesBaseView> m_TitlesView /* None */)
{
    public static CommonConsoleView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_UIVisibilityCommonView */
        PPtr<UIVisibilityView> _m_UIVisibilityCommonView = PPtr<UIVisibilityView>.Read(reader);
        PPtr<UIVisibilityView> _m_UIVisibilityBugReportView = PPtr<UIVisibilityView>.Read(reader);
        PPtr<LoadingScreenConsoleView> _m_LoadingScreenConsoleView = PPtr<LoadingScreenConsoleView>.Read(reader);
        PPtr<TutorialConsoleView> _m_TutorialView = PPtr<TutorialConsoleView>.Read(reader);
        PPtr<CounterWindowConsoleView> _m_CounterWindowConsoleView = PPtr<CounterWindowConsoleView>.Read(reader);
        PPtr<ContextMenuConsoleView> _m_ContextMenuConsoleView = PPtr<ContextMenuConsoleView>.Read(reader);
        PPtr<TooltipContextConsoleView> _m_TooltipContextConsoleView = PPtr<TooltipContextConsoleView>.Read(reader);
        PPtr<QuestNotificatorConsoleView> _m_QuestNotificatorConsoleView = PPtr<QuestNotificatorConsoleView>.Read(reader);
        PPtr<GamepadDisconnectedInGamepadModeWindowView> _m_GamepadDisconnectedInGamepadModeWindowView = PPtr<GamepadDisconnectedInGamepadModeWindowView>.Read(reader);
        PPtr<PauseNotification> _m_PauseNotification = PPtr<PauseNotification>.Read(reader);
        PPtr<WarningsTextView> _m_WarningsTextView = PPtr<WarningsTextView>.Read(reader);
        PPtr<MultiplySelection> _m_MultiplySelection = PPtr<MultiplySelection>.Read(reader);
        PPtr<EscMenuContextConsoleView> _m_EscMenuConsoleView = PPtr<EscMenuContextConsoleView>.Read(reader);
        PPtr<MessageBoxConsoleView> _m_MessageBoxConsoleView = PPtr<MessageBoxConsoleView>.Read(reader);
        PPtr<SaveLoadConsoleView> _m_SaveLoadConsoleView = PPtr<SaveLoadConsoleView>.Read(reader);
        PPtr<SettingsConsoleView> _m_SettingsView = PPtr<SettingsConsoleView>.Read(reader);
        PPtr<FadeView> _m_FadeView = PPtr<FadeView>.Read(reader);
        PPtr<BugReportBaseView> _m_BugReportView = PPtr<BugReportBaseView>.Read(reader);
        PPtr<NetLobbyConsoleView> _m_NetLobbyConsoleView = PPtr<NetLobbyConsoleView>.Read(reader);
        PPtr<NetRolesConsoleView> _m_NetRolesConsoleView = PPtr<NetRolesConsoleView>.Read(reader);
        PPtr<TitlesBaseView> _m_TitlesView = PPtr<TitlesBaseView>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_UIVisibilityCommonView,
            _m_UIVisibilityBugReportView,
            _m_LoadingScreenConsoleView,
            _m_TutorialView,
            _m_CounterWindowConsoleView,
            _m_ContextMenuConsoleView,
            _m_TooltipContextConsoleView,
            _m_QuestNotificatorConsoleView,
            _m_GamepadDisconnectedInGamepadModeWindowView,
            _m_PauseNotification,
            _m_WarningsTextView,
            _m_MultiplySelection,
            _m_EscMenuConsoleView,
            _m_MessageBoxConsoleView,
            _m_SaveLoadConsoleView,
            _m_SettingsView,
            _m_FadeView,
            _m_BugReportView,
            _m_NetLobbyConsoleView,
            _m_NetRolesConsoleView,
            _m_TitlesView);
    }
}


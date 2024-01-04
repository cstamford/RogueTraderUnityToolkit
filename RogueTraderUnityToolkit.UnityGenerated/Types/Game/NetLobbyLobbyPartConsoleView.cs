namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $NetLobbyLobbyPartConsoleView (31 fields) 8B06FC27287D24AE9628574B3EA0F633/1DEDC403B9719953B2193DC325A7BC73 */
public record class NetLobbyLobbyPartConsoleView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<TextMeshProUGUI> m_LobbyIdText /* NeedsAlign */,
    PPtr<TextMeshProUGUI> m_LobbyIdHintText /* None */,
    PPtr<CanvasGroup> m_ShowHideIcon /* None */,
    PPtr<ScrambledTMP> m_ScrambledLobbyCode /* None */,
    PPtr<RectTransform> m_LobbyIdTooltipPlace /* None */,
    PPtr<TextMeshProUGUI> m_LobbyNotEnoughPlayersText /* None */,
    PPtr<OwlcatButton> m_ConnectEpicGamesToSteam /* None */,
    PPtr<TextMeshProUGUI> m_EpicGamesUserName /* None */,
    PPtr<TextMeshProUGUI> m_CurrentRegionText /* None */,
    PPtr<TextMeshProUGUI> m_CurrentVersion /* None */,
    PPtr<TextMeshProUGUI> m_CurrentVersionHeader /* None */,
    PPtr<RectTransform> m_RegionTooltipPlace /* None */,
    PPtr<TextMeshProUGUI> m_SaveBlockHeader /* None */,
    PPtr<TextMeshProUGUI> m_LaunchInGameHintText /* None */,
    PPtr<TextMeshProUGUI> m_SaveBlockHintHeader /* None */,
    PPtr<OwlcatButton> m_EmptySaveSlotButton /* None */,
    PPtr<SaveSlotBaseView> m_SaveSlot /* None */,
    PPtr<GameObject> m_TransferSavePart /* None */,
    PPtr<Image> m_TransferSaveProgress /* None */,
    PPtr<TextMeshProUGUI> m_TransferSaveProgressPercent /* None */,
    PPtr<TextMeshProUGUI> m_TransferSaveProgressSize /* None */,
    PPtr<GameObject> m_WaitingForSaveList /* None */,
    PPtr<TextMeshProUGUI> m_EmptyListHint /* None */,
    PPtr<NetLobbyPlayerConsoleView>[] m_PlayerList /* None */,
    PPtr<ConsoleHint> m_ShowHideLobbyCodeHint /* None */,
    PPtr<ConsoleHint> m_CopyLobbyCodeHint /* None */,
    PPtr<OwlcatButton> m_SavePartFocusButton /* None */)
{
    public static NetLobbyLobbyPartConsoleView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_LobbyIdText */
        PPtr<TextMeshProUGUI> _m_LobbyIdText = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<TextMeshProUGUI> _m_LobbyIdHintText = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<CanvasGroup> _m_ShowHideIcon = PPtr<CanvasGroup>.Read(reader);
        PPtr<ScrambledTMP> _m_ScrambledLobbyCode = PPtr<ScrambledTMP>.Read(reader);
        PPtr<RectTransform> _m_LobbyIdTooltipPlace = PPtr<RectTransform>.Read(reader);
        PPtr<TextMeshProUGUI> _m_LobbyNotEnoughPlayersText = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<OwlcatButton> _m_ConnectEpicGamesToSteam = PPtr<OwlcatButton>.Read(reader);
        PPtr<TextMeshProUGUI> _m_EpicGamesUserName = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<TextMeshProUGUI> _m_CurrentRegionText = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<TextMeshProUGUI> _m_CurrentVersion = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<TextMeshProUGUI> _m_CurrentVersionHeader = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<RectTransform> _m_RegionTooltipPlace = PPtr<RectTransform>.Read(reader);
        PPtr<TextMeshProUGUI> _m_SaveBlockHeader = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<TextMeshProUGUI> _m_LaunchInGameHintText = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<TextMeshProUGUI> _m_SaveBlockHintHeader = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<OwlcatButton> _m_EmptySaveSlotButton = PPtr<OwlcatButton>.Read(reader);
        PPtr<SaveSlotBaseView> _m_SaveSlot = PPtr<SaveSlotBaseView>.Read(reader);
        PPtr<GameObject> _m_TransferSavePart = PPtr<GameObject>.Read(reader);
        PPtr<Image> _m_TransferSaveProgress = PPtr<Image>.Read(reader);
        PPtr<TextMeshProUGUI> _m_TransferSaveProgressPercent = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<TextMeshProUGUI> _m_TransferSaveProgressSize = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<GameObject> _m_WaitingForSaveList = PPtr<GameObject>.Read(reader);
        PPtr<TextMeshProUGUI> _m_EmptyListHint = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<NetLobbyPlayerConsoleView>[] _m_PlayerList = BuiltInArray<PPtr<NetLobbyPlayerConsoleView>>.Read(reader);
        PPtr<ConsoleHint> _m_ShowHideLobbyCodeHint = PPtr<ConsoleHint>.Read(reader);
        PPtr<ConsoleHint> _m_CopyLobbyCodeHint = PPtr<ConsoleHint>.Read(reader);
        PPtr<OwlcatButton> _m_SavePartFocusButton = PPtr<OwlcatButton>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_LobbyIdText,
            _m_LobbyIdHintText,
            _m_ShowHideIcon,
            _m_ScrambledLobbyCode,
            _m_LobbyIdTooltipPlace,
            _m_LobbyNotEnoughPlayersText,
            _m_ConnectEpicGamesToSteam,
            _m_EpicGamesUserName,
            _m_CurrentRegionText,
            _m_CurrentVersion,
            _m_CurrentVersionHeader,
            _m_RegionTooltipPlace,
            _m_SaveBlockHeader,
            _m_LaunchInGameHintText,
            _m_SaveBlockHintHeader,
            _m_EmptySaveSlotButton,
            _m_SaveSlot,
            _m_TransferSavePart,
            _m_TransferSaveProgress,
            _m_TransferSaveProgressPercent,
            _m_TransferSaveProgressSize,
            _m_WaitingForSaveList,
            _m_EmptyListHint,
            _m_PlayerList,
            _m_ShowHideLobbyCodeHint,
            _m_CopyLobbyCodeHint,
            _m_SavePartFocusButton);
    }
}


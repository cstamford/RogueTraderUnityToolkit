namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $NetLobbyLobbyPartPCView (39 fields) 4F04EA07A5CFAFE0A6FD3DB88B497066/42F98E2BFA4A160375734BF964C91730 */
public record class NetLobbyLobbyPartPCView(
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
    PPtr<OwlcatButton> m_DisconnectButton /* None */,
    PPtr<TextMeshProUGUI> m_DisconnectButtonText /* None */,
    PPtr<OwlcatButton> m_LaunchButton /* None */,
    PPtr<TextMeshProUGUI> m_LaunchButtonText /* None */,
    PPtr<NetLobbyPlayerPCView>[] m_PlayerList /* None */,
    PPtr<OwlcatButton> m_LobbyIdCopyButton /* None */,
    PPtr<TextMeshProUGUI> m_LobbyIdCopyButtonText /* None */,
    PPtr<OwlcatButton> m_LobbyIdShowHideButton /* None */,
    PPtr<OwlcatButton> m_ResetCurrentSave /* None */,
    PPtr<OwlcatButton> m_SaveListBackButton /* None */,
    PPtr<TextMeshProUGUI> m_SaveListBackButtonText /* None */,
    PPtr<NetLobbyInvitePlayerDifferentPlatformsPCView> m_DifferentPlatformsInvitePCView /* None */)
{
    public static NetLobbyLobbyPartPCView Read(EndianBinaryReader reader)
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
        PPtr<OwlcatButton> _m_DisconnectButton = PPtr<OwlcatButton>.Read(reader);
        PPtr<TextMeshProUGUI> _m_DisconnectButtonText = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<OwlcatButton> _m_LaunchButton = PPtr<OwlcatButton>.Read(reader);
        PPtr<TextMeshProUGUI> _m_LaunchButtonText = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<NetLobbyPlayerPCView>[] _m_PlayerList = BuiltInArray<PPtr<NetLobbyPlayerPCView>>.Read(reader);
        PPtr<OwlcatButton> _m_LobbyIdCopyButton = PPtr<OwlcatButton>.Read(reader);
        PPtr<TextMeshProUGUI> _m_LobbyIdCopyButtonText = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<OwlcatButton> _m_LobbyIdShowHideButton = PPtr<OwlcatButton>.Read(reader);
        PPtr<OwlcatButton> _m_ResetCurrentSave = PPtr<OwlcatButton>.Read(reader);
        PPtr<OwlcatButton> _m_SaveListBackButton = PPtr<OwlcatButton>.Read(reader);
        PPtr<TextMeshProUGUI> _m_SaveListBackButtonText = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<NetLobbyInvitePlayerDifferentPlatformsPCView> _m_DifferentPlatformsInvitePCView = PPtr<NetLobbyInvitePlayerDifferentPlatformsPCView>.Read(reader);
        
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
            _m_DisconnectButton,
            _m_DisconnectButtonText,
            _m_LaunchButton,
            _m_LaunchButtonText,
            _m_PlayerList,
            _m_LobbyIdCopyButton,
            _m_LobbyIdCopyButtonText,
            _m_LobbyIdShowHideButton,
            _m_ResetCurrentSave,
            _m_SaveListBackButton,
            _m_SaveListBackButtonText,
            _m_DifferentPlatformsInvitePCView);
    }
}


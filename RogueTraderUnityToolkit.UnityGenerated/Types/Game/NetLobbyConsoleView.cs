namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $NetLobbyConsoleView (11 fields) D36305FB4905EDBF945FA586E29483BD/C67C24CB9648E1C438DFC345E9614F96 */
public record class NetLobbyConsoleView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<TextMeshProUGUI> m_Header /* NeedsAlign */,
    PPtr<NetLobbySaveSlotCollectionBaseView> m_SlotCollectionView /* None */,
    PPtr<NetLobbyCreateJoinPartConsoleView> m_CreateJoinBlock /* None */,
    PPtr<NetLobbyWaitingPartConsoleView> m_WaitingBlock /* None */,
    PPtr<NetLobbyLobbyPartConsoleView> m_LobbyBlock /* None */,
    PPtr<NetLobbyTutorialPartConsoleView> m_TutorialBlock /* None */,
    PPtr<ConsoleHintsWidget> m_CommonHintsWidget /* None */)
{
    public static NetLobbyConsoleView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_Header */
        PPtr<TextMeshProUGUI> _m_Header = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<NetLobbySaveSlotCollectionBaseView> _m_SlotCollectionView = PPtr<NetLobbySaveSlotCollectionBaseView>.Read(reader);
        PPtr<NetLobbyCreateJoinPartConsoleView> _m_CreateJoinBlock = PPtr<NetLobbyCreateJoinPartConsoleView>.Read(reader);
        PPtr<NetLobbyWaitingPartConsoleView> _m_WaitingBlock = PPtr<NetLobbyWaitingPartConsoleView>.Read(reader);
        PPtr<NetLobbyLobbyPartConsoleView> _m_LobbyBlock = PPtr<NetLobbyLobbyPartConsoleView>.Read(reader);
        PPtr<NetLobbyTutorialPartConsoleView> _m_TutorialBlock = PPtr<NetLobbyTutorialPartConsoleView>.Read(reader);
        PPtr<ConsoleHintsWidget> _m_CommonHintsWidget = PPtr<ConsoleHintsWidget>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_Header,
            _m_SlotCollectionView,
            _m_CreateJoinBlock,
            _m_WaitingBlock,
            _m_LobbyBlock,
            _m_TutorialBlock,
            _m_CommonHintsWidget);
    }
}


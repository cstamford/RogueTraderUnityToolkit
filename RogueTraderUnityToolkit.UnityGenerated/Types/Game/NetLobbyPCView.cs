namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $NetLobbyPCView (12 fields) D470084BF66A935BA0691B462B1571F4/67821FA508F9571B65E2131763E17801 */
public record class NetLobbyPCView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<TextMeshProUGUI> m_Header /* NeedsAlign */,
    PPtr<NetLobbySaveSlotCollectionBaseView> m_SlotCollectionView /* None */,
    PPtr<OwlcatButton> m_CloseButton /* None */,
    PPtr<NetLobbyCreateJoinPartPCView> m_CreateJoinBlock /* None */,
    PPtr<NetLobbyWaitingPartPCView> m_WaitingBlock /* None */,
    PPtr<NetLobbyLobbyPartPCView> m_LobbyBlock /* None */,
    PPtr<NetLobbyTutorialPartPCView> m_TutorialBlock /* None */,
    PPtr<OwlcatButton>[] m_TutorialButtons /* None */)
{
    public static NetLobbyPCView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_Header */
        PPtr<TextMeshProUGUI> _m_Header = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<NetLobbySaveSlotCollectionBaseView> _m_SlotCollectionView = PPtr<NetLobbySaveSlotCollectionBaseView>.Read(reader);
        PPtr<OwlcatButton> _m_CloseButton = PPtr<OwlcatButton>.Read(reader);
        PPtr<NetLobbyCreateJoinPartPCView> _m_CreateJoinBlock = PPtr<NetLobbyCreateJoinPartPCView>.Read(reader);
        PPtr<NetLobbyWaitingPartPCView> _m_WaitingBlock = PPtr<NetLobbyWaitingPartPCView>.Read(reader);
        PPtr<NetLobbyLobbyPartPCView> _m_LobbyBlock = PPtr<NetLobbyLobbyPartPCView>.Read(reader);
        PPtr<NetLobbyTutorialPartPCView> _m_TutorialBlock = PPtr<NetLobbyTutorialPartPCView>.Read(reader);
        PPtr<OwlcatButton>[] _m_TutorialButtons = BuiltInArray<PPtr<OwlcatButton>>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_Header,
            _m_SlotCollectionView,
            _m_CloseButton,
            _m_CreateJoinBlock,
            _m_WaitingBlock,
            _m_LobbyBlock,
            _m_TutorialBlock,
            _m_TutorialButtons);
    }
}


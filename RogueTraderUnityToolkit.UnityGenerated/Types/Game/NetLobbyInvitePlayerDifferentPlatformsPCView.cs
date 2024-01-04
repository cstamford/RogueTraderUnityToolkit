namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $NetLobbyInvitePlayerDifferentPlatformsPCView (11 fields) E00536B766FB5B8D9D35E47BBD30EF49/1A7C28EA1D85E407C7594EF01B458EE3 */
public record class NetLobbyInvitePlayerDifferentPlatformsPCView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<OwlcatButton> m_InviteFromSteamButton /* NeedsAlign */,
    PPtr<TextMeshProUGUI> m_InviteFromSteamLabel /* None */,
    PPtr<OwlcatButton> m_InviteFromEpicGamesButton /* None */,
    PPtr<TextMeshProUGUI> m_InviteFromEpicGamesLabel /* None */,
    PPtr<OwlcatButton> m_CancelInviteButton /* None */,
    PPtr<TextMeshProUGUI> m_CancelInviteLabel /* None */,
    PPtr<OwlcatButton> m_CloseButton /* None */)
{
    public static NetLobbyInvitePlayerDifferentPlatformsPCView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_InviteFromSteamButton */
        PPtr<OwlcatButton> _m_InviteFromSteamButton = PPtr<OwlcatButton>.Read(reader);
        PPtr<TextMeshProUGUI> _m_InviteFromSteamLabel = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<OwlcatButton> _m_InviteFromEpicGamesButton = PPtr<OwlcatButton>.Read(reader);
        PPtr<TextMeshProUGUI> _m_InviteFromEpicGamesLabel = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<OwlcatButton> _m_CancelInviteButton = PPtr<OwlcatButton>.Read(reader);
        PPtr<TextMeshProUGUI> _m_CancelInviteLabel = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<OwlcatButton> _m_CloseButton = PPtr<OwlcatButton>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_InviteFromSteamButton,
            _m_InviteFromSteamLabel,
            _m_InviteFromEpicGamesButton,
            _m_InviteFromEpicGamesLabel,
            _m_CancelInviteButton,
            _m_CancelInviteLabel,
            _m_CloseButton);
    }
}


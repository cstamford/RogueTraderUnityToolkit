namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $NetLobbyCreateJoinPartPCView (19 fields) 897935A426ECE4BA456030C9CD7235DE/D6D8D3BB1EB1CC9F6A486C5C1892F365 */
public record class NetLobbyCreateJoinPartPCView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<CanvasGroup> m_ShowHideLobbyIcon /* NeedsAlign */,
    PPtr<TMP_InputField> m_LobbyCodeInputField /* None */,
    PPtr<TextMeshProUGUI> m_LobbyCodeInputFieldPlaceholder /* None */,
    PPtr<OwlcatDropdown> m_RegionDropdown /* None */,
    PPtr<GameObject> m_RegionWaiting /* None */,
    PPtr<TextMeshProUGUI> m_RegionHeader /* None */,
    PPtr<TextMeshProUGUI> m_VersionText /* None */,
    PPtr<TextMeshProUGUI> m_VersionHeader /* None */,
    PPtr<TextMeshProUGUI> m_NeedSameRegionAndCoopVerDescription /* None */,
    PPtr<OwlcatButton> m_CreateLobbyButton /* None */,
    PPtr<TextMeshProUGUI> m_CreateLobbyButtonText /* None */,
    PPtr<OwlcatButton> m_JoinLobbyButton /* None */,
    PPtr<TextMeshProUGUI> m_JoinLobbyButtonText /* None */,
    PPtr<OwlcatButton> m_ShowHideLobbyCodeButton /* None */,
    PPtr<OwlcatButton> m_LobbyIdPasteButton /* None */)
{
    public static NetLobbyCreateJoinPartPCView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_ShowHideLobbyIcon */
        PPtr<CanvasGroup> _m_ShowHideLobbyIcon = PPtr<CanvasGroup>.Read(reader);
        PPtr<TMP_InputField> _m_LobbyCodeInputField = PPtr<TMP_InputField>.Read(reader);
        PPtr<TextMeshProUGUI> _m_LobbyCodeInputFieldPlaceholder = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<OwlcatDropdown> _m_RegionDropdown = PPtr<OwlcatDropdown>.Read(reader);
        PPtr<GameObject> _m_RegionWaiting = PPtr<GameObject>.Read(reader);
        PPtr<TextMeshProUGUI> _m_RegionHeader = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<TextMeshProUGUI> _m_VersionText = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<TextMeshProUGUI> _m_VersionHeader = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<TextMeshProUGUI> _m_NeedSameRegionAndCoopVerDescription = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<OwlcatButton> _m_CreateLobbyButton = PPtr<OwlcatButton>.Read(reader);
        PPtr<TextMeshProUGUI> _m_CreateLobbyButtonText = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<OwlcatButton> _m_JoinLobbyButton = PPtr<OwlcatButton>.Read(reader);
        PPtr<TextMeshProUGUI> _m_JoinLobbyButtonText = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<OwlcatButton> _m_ShowHideLobbyCodeButton = PPtr<OwlcatButton>.Read(reader);
        PPtr<OwlcatButton> _m_LobbyIdPasteButton = PPtr<OwlcatButton>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_ShowHideLobbyIcon,
            _m_LobbyCodeInputField,
            _m_LobbyCodeInputFieldPlaceholder,
            _m_RegionDropdown,
            _m_RegionWaiting,
            _m_RegionHeader,
            _m_VersionText,
            _m_VersionHeader,
            _m_NeedSameRegionAndCoopVerDescription,
            _m_CreateLobbyButton,
            _m_CreateLobbyButtonText,
            _m_JoinLobbyButton,
            _m_JoinLobbyButtonText,
            _m_ShowHideLobbyCodeButton,
            _m_LobbyIdPasteButton);
    }
}


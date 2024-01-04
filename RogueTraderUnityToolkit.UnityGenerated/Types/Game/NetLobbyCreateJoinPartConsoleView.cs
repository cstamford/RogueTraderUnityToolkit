namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $NetLobbyCreateJoinPartConsoleView (21 fields) 9C2C1F4B2CA22ECD3A5D06D39F88550D/CFEB659712E75522E73B8BAA175B8016 */
public record class NetLobbyCreateJoinPartConsoleView(
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
    PPtr<ConsoleInputField> m_ConsoleInputField /* None */,
    PPtr<ConsoleHint> m_SelectRegionHint /* None */,
    PPtr<ConsoleHint> m_PasteLobbyIdHint /* None */,
    PPtr<ConsoleHint> m_ShowLobbyCodeHint /* None */,
    PPtr<ConsoleHint> m_EnterLobbyIdHint /* None */,
    PPtr<OwlcatMultiButton> m_CreateBlockFocusButton /* None */,
    PPtr<OwlcatMultiButton> m_JoinBlockFocusButton /* None */,
    PPtr<TextMeshProUGUI> m_CreateLobbyLabel /* None */)
{
    public static NetLobbyCreateJoinPartConsoleView Read(EndianBinaryReader reader)
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
        PPtr<ConsoleInputField> _m_ConsoleInputField = PPtr<ConsoleInputField>.Read(reader);
        PPtr<ConsoleHint> _m_SelectRegionHint = PPtr<ConsoleHint>.Read(reader);
        PPtr<ConsoleHint> _m_PasteLobbyIdHint = PPtr<ConsoleHint>.Read(reader);
        PPtr<ConsoleHint> _m_ShowLobbyCodeHint = PPtr<ConsoleHint>.Read(reader);
        PPtr<ConsoleHint> _m_EnterLobbyIdHint = PPtr<ConsoleHint>.Read(reader);
        PPtr<OwlcatMultiButton> _m_CreateBlockFocusButton = PPtr<OwlcatMultiButton>.Read(reader);
        PPtr<OwlcatMultiButton> _m_JoinBlockFocusButton = PPtr<OwlcatMultiButton>.Read(reader);
        PPtr<TextMeshProUGUI> _m_CreateLobbyLabel = PPtr<TextMeshProUGUI>.Read(reader);
        
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
            _m_ConsoleInputField,
            _m_SelectRegionHint,
            _m_PasteLobbyIdHint,
            _m_ShowLobbyCodeHint,
            _m_EnterLobbyIdHint,
            _m_CreateBlockFocusButton,
            _m_JoinBlockFocusButton,
            _m_CreateLobbyLabel);
    }
}


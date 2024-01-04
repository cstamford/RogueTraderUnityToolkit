namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $EscMenuPCView (23 fields) E065A4E52CB10638F226E7F605B06AFA/B229270C352678642F641BA80E92BDC9 */
public record class EscMenuPCView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<OwlcatButton> m_SaveButton /* NeedsAlign */,
    PPtr<OwlcatButton> m_LoadButton /* None */,
    PPtr<OwlcatButton> m_MultiplayerButton /* None */,
    PPtr<OwlcatButton> m_MultiplayerRolesButton /* None */,
    PPtr<OwlcatButton> m_FormationButton /* None */,
    PPtr<OwlcatButton> m_OptionsButton /* None */,
    PPtr<OwlcatButton> m_BugReportButton /* None */,
    PPtr<OwlcatButton> m_MainMenuButton /* None */,
    PPtr<OwlcatButton> m_QuitButton /* None */,
    PPtr<TextMeshProUGUI> m_SaveButtonLabel /* None */,
    PPtr<TextMeshProUGUI> m_LoadButtonLabel /* None */,
    PPtr<TextMeshProUGUI> m_MultiplayerButtonLabel /* None */,
    PPtr<TextMeshProUGUI> m_MultiplayerRolesButtonLabel /* None */,
    PPtr<TextMeshProUGUI> m_FormationButtonLabel /* None */,
    PPtr<TextMeshProUGUI> m_OptionsButtonLabel /* None */,
    PPtr<TextMeshProUGUI> m_BugReportButtonLabel /* None */,
    PPtr<TextMeshProUGUI> m_MainMenuButtonLabel /* None */,
    PPtr<TextMeshProUGUI> m_QuitButtonLabel /* None */,
    PPtr<OwlcatButton> m_CloseButton /* None */)
{
    public static EscMenuPCView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_SaveButton */
        PPtr<OwlcatButton> _m_SaveButton = PPtr<OwlcatButton>.Read(reader);
        PPtr<OwlcatButton> _m_LoadButton = PPtr<OwlcatButton>.Read(reader);
        PPtr<OwlcatButton> _m_MultiplayerButton = PPtr<OwlcatButton>.Read(reader);
        PPtr<OwlcatButton> _m_MultiplayerRolesButton = PPtr<OwlcatButton>.Read(reader);
        PPtr<OwlcatButton> _m_FormationButton = PPtr<OwlcatButton>.Read(reader);
        PPtr<OwlcatButton> _m_OptionsButton = PPtr<OwlcatButton>.Read(reader);
        PPtr<OwlcatButton> _m_BugReportButton = PPtr<OwlcatButton>.Read(reader);
        PPtr<OwlcatButton> _m_MainMenuButton = PPtr<OwlcatButton>.Read(reader);
        PPtr<OwlcatButton> _m_QuitButton = PPtr<OwlcatButton>.Read(reader);
        PPtr<TextMeshProUGUI> _m_SaveButtonLabel = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<TextMeshProUGUI> _m_LoadButtonLabel = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<TextMeshProUGUI> _m_MultiplayerButtonLabel = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<TextMeshProUGUI> _m_MultiplayerRolesButtonLabel = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<TextMeshProUGUI> _m_FormationButtonLabel = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<TextMeshProUGUI> _m_OptionsButtonLabel = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<TextMeshProUGUI> _m_BugReportButtonLabel = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<TextMeshProUGUI> _m_MainMenuButtonLabel = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<TextMeshProUGUI> _m_QuitButtonLabel = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<OwlcatButton> _m_CloseButton = PPtr<OwlcatButton>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_SaveButton,
            _m_LoadButton,
            _m_MultiplayerButton,
            _m_MultiplayerRolesButton,
            _m_FormationButton,
            _m_OptionsButton,
            _m_BugReportButton,
            _m_MainMenuButton,
            _m_QuitButton,
            _m_SaveButtonLabel,
            _m_LoadButtonLabel,
            _m_MultiplayerButtonLabel,
            _m_MultiplayerRolesButtonLabel,
            _m_FormationButtonLabel,
            _m_OptionsButtonLabel,
            _m_BugReportButtonLabel,
            _m_MainMenuButtonLabel,
            _m_QuitButtonLabel,
            _m_CloseButton);
    }
}


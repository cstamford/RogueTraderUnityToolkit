namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $MainMenuSideBarConsoleView (30 fields) F1A6D4952023F3E468B670F29DB6AAB5/1A80C408A73C04751226E0CD34EB22E1 */
public record class MainMenuSideBarConsoleView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<ContextMenuEntityConsoleView> m_ContinueView /* NeedsAlign */,
    PPtr<ContextMenuEntityConsoleView> m_NewGameView /* None */,
    PPtr<ContextMenuEntityConsoleView> m_LoadView /* None */,
    PPtr<ContextMenuEntityConsoleView> m_NetView /* None */,
    PPtr<ContextMenuEntityConsoleView> m_OptionsView /* None */,
    PPtr<ContextMenuEntityConsoleView> m_CreditView /* None */,
    PPtr<ContextMenuEntityConsoleView> m_ExitView /* None */,
    PPtr<OwlcatButton> m_WebsiteButton /* None */,
    PPtr<OwlcatButton> m_LicenceButton /* None */,
    PPtr<OwlcatButton> m_DiscordButton /* None */,
    PPtr<GameObject> m_WelcomeTextContainer /* None */,
    PPtr<MoveAnimator> m_WelcomeTextBlock /* None */,
    float m_DelayBeforeShow /* None */,
    PPtr<TextMeshProUGUI> m_WebsiteLabel /* None */,
    PPtr<TextMeshProUGUI> m_LicenceLabel /* None */,
    PPtr<TextMeshProUGUI> m_DiscordLabel /* None */,
    PPtr<ScrollRectExtended> m_ScrollRect /* None */,
    PPtr<TextMeshProUGUI> m_MotivationText /* None */,
    PPtr<ConsoleHintsWidget> m_HintsWidget /* None */,
    PPtr<ConsoleHint> m_LicenseHint /* None */,
    PPtr<OwlcatMultiButton> m_FirstGlossaryFocus /* None */,
    PPtr<OwlcatMultiButton> m_SecondGlossaryFocus /* None */,
    PPtr<GameObject> m_XBoxGamerGroup /* None */,
    PPtr<TextMeshProUGUI> m_XBoxGamerTagText /* None */,
    PPtr<RawImage> m_XBoxGamerRawImage /* None */,
    NavigationParameters m_Parameters /* None */)
{
    public static MainMenuSideBarConsoleView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_ContinueView */
        PPtr<ContextMenuEntityConsoleView> _m_ContinueView = PPtr<ContextMenuEntityConsoleView>.Read(reader);
        PPtr<ContextMenuEntityConsoleView> _m_NewGameView = PPtr<ContextMenuEntityConsoleView>.Read(reader);
        PPtr<ContextMenuEntityConsoleView> _m_LoadView = PPtr<ContextMenuEntityConsoleView>.Read(reader);
        PPtr<ContextMenuEntityConsoleView> _m_NetView = PPtr<ContextMenuEntityConsoleView>.Read(reader);
        PPtr<ContextMenuEntityConsoleView> _m_OptionsView = PPtr<ContextMenuEntityConsoleView>.Read(reader);
        PPtr<ContextMenuEntityConsoleView> _m_CreditView = PPtr<ContextMenuEntityConsoleView>.Read(reader);
        PPtr<ContextMenuEntityConsoleView> _m_ExitView = PPtr<ContextMenuEntityConsoleView>.Read(reader);
        PPtr<OwlcatButton> _m_WebsiteButton = PPtr<OwlcatButton>.Read(reader);
        PPtr<OwlcatButton> _m_LicenceButton = PPtr<OwlcatButton>.Read(reader);
        PPtr<OwlcatButton> _m_DiscordButton = PPtr<OwlcatButton>.Read(reader);
        PPtr<GameObject> _m_WelcomeTextContainer = PPtr<GameObject>.Read(reader);
        PPtr<MoveAnimator> _m_WelcomeTextBlock = PPtr<MoveAnimator>.Read(reader);
        float _m_DelayBeforeShow = reader.ReadF32();
        PPtr<TextMeshProUGUI> _m_WebsiteLabel = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<TextMeshProUGUI> _m_LicenceLabel = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<TextMeshProUGUI> _m_DiscordLabel = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<ScrollRectExtended> _m_ScrollRect = PPtr<ScrollRectExtended>.Read(reader);
        PPtr<TextMeshProUGUI> _m_MotivationText = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<ConsoleHintsWidget> _m_HintsWidget = PPtr<ConsoleHintsWidget>.Read(reader);
        PPtr<ConsoleHint> _m_LicenseHint = PPtr<ConsoleHint>.Read(reader);
        PPtr<OwlcatMultiButton> _m_FirstGlossaryFocus = PPtr<OwlcatMultiButton>.Read(reader);
        PPtr<OwlcatMultiButton> _m_SecondGlossaryFocus = PPtr<OwlcatMultiButton>.Read(reader);
        PPtr<GameObject> _m_XBoxGamerGroup = PPtr<GameObject>.Read(reader);
        PPtr<TextMeshProUGUI> _m_XBoxGamerTagText = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<RawImage> _m_XBoxGamerRawImage = PPtr<RawImage>.Read(reader);
        NavigationParameters _m_Parameters = NavigationParameters.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_ContinueView,
            _m_NewGameView,
            _m_LoadView,
            _m_NetView,
            _m_OptionsView,
            _m_CreditView,
            _m_ExitView,
            _m_WebsiteButton,
            _m_LicenceButton,
            _m_DiscordButton,
            _m_WelcomeTextContainer,
            _m_WelcomeTextBlock,
            _m_DelayBeforeShow,
            _m_WebsiteLabel,
            _m_LicenceLabel,
            _m_DiscordLabel,
            _m_ScrollRect,
            _m_MotivationText,
            _m_HintsWidget,
            _m_LicenseHint,
            _m_FirstGlossaryFocus,
            _m_SecondGlossaryFocus,
            _m_XBoxGamerGroup,
            _m_XBoxGamerTagText,
            _m_XBoxGamerRawImage,
            _m_Parameters);
    }
}


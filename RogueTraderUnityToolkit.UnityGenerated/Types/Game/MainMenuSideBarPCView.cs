namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $MainMenuSideBarPCView (22 fields) 9A92CD0D95F4C9E198E6CEDFE78BEB95/B362128D9A8B42AADC4BE0646CCCC706 */
public record class MainMenuSideBarPCView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<ContextMenuEntityPCView> m_ContinueView /* NeedsAlign */,
    PPtr<ContextMenuEntityPCView> m_NewGameView /* None */,
    PPtr<ContextMenuEntityPCView> m_LoadView /* None */,
    PPtr<ContextMenuEntityPCView> m_NetView /* None */,
    PPtr<ContextMenuEntityPCView> m_OptionsView /* None */,
    PPtr<ContextMenuEntityPCView> m_CreditView /* None */,
    PPtr<ContextMenuEntityPCView> m_ExitView /* None */,
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
    PPtr<TextMeshProUGUI> m_MotivationText /* None */)
{
    public static MainMenuSideBarPCView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_ContinueView */
        PPtr<ContextMenuEntityPCView> _m_ContinueView = PPtr<ContextMenuEntityPCView>.Read(reader);
        PPtr<ContextMenuEntityPCView> _m_NewGameView = PPtr<ContextMenuEntityPCView>.Read(reader);
        PPtr<ContextMenuEntityPCView> _m_LoadView = PPtr<ContextMenuEntityPCView>.Read(reader);
        PPtr<ContextMenuEntityPCView> _m_NetView = PPtr<ContextMenuEntityPCView>.Read(reader);
        PPtr<ContextMenuEntityPCView> _m_OptionsView = PPtr<ContextMenuEntityPCView>.Read(reader);
        PPtr<ContextMenuEntityPCView> _m_CreditView = PPtr<ContextMenuEntityPCView>.Read(reader);
        PPtr<ContextMenuEntityPCView> _m_ExitView = PPtr<ContextMenuEntityPCView>.Read(reader);
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
            _m_MotivationText);
    }
}


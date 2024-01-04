namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $SettingsConsoleView (24 fields) F1973617C84D9D8D6B026C7B9E21489E/711744F489742435438631EE7837BB86 */
public record class SettingsConsoleView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    SettingsViews m_SettingsViews /* NeedsAlign */,
    PPtr<VirtualListVertical> m_VirtualList /* None */,
    PPtr<InfoSectionView> m_InfoView /* None */,
    PPtr<RectTransform> m_BigGreenScreenView /* None */,
    PPtr<RectTransform> m_LittleGreenScreenView /* None */,
    PPtr<RectTransform> m_PaperGroup /* None */,
    PPtr<RectTransform> m_ScrollBarObject /* None */,
    PPtr<SettingsMenuSelectorConsoleView> m_MenuSelector /* None */,
    PPtr<FlexibleLensSelectorView> m_SelectorView /* None */,
    PPtr<ConsoleHint> m_PrevHint /* None */,
    PPtr<ConsoleHint> m_NextHint /* None */,
    PPtr<ConsoleHintsWidget> m_ConsoleHintsWidget /* None */,
    PPtr<FadeAnimator> m_Animator /* None */,
    PPtr<GameObject> m_ControlsConsoleGroup /* None */,
    PPtr<SettingsControlConsole> m_PSConsoleGroup /* None */,
    PPtr<SettingsControlConsole> m_DualSenseConsoleGroup /* None */,
    PPtr<SettingsControlConsole> m_XBoxConsoleGroup /* None */,
    PPtr<SettingsControlConsole> m_SwitchConsoleGroup /* None */,
    PPtr<SettingsControlConsole> m_SteamConsoleGroup /* None */,
    PPtr<RectTransform> m_SafeZoneFrame /* None */)
{
    public static SettingsConsoleView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_SettingsViews */
        SettingsViews _m_SettingsViews = SettingsViews.Read(reader);
        PPtr<VirtualListVertical> _m_VirtualList = PPtr<VirtualListVertical>.Read(reader);
        PPtr<InfoSectionView> _m_InfoView = PPtr<InfoSectionView>.Read(reader);
        PPtr<RectTransform> _m_BigGreenScreenView = PPtr<RectTransform>.Read(reader);
        PPtr<RectTransform> _m_LittleGreenScreenView = PPtr<RectTransform>.Read(reader);
        PPtr<RectTransform> _m_PaperGroup = PPtr<RectTransform>.Read(reader);
        PPtr<RectTransform> _m_ScrollBarObject = PPtr<RectTransform>.Read(reader);
        PPtr<SettingsMenuSelectorConsoleView> _m_MenuSelector = PPtr<SettingsMenuSelectorConsoleView>.Read(reader);
        PPtr<FlexibleLensSelectorView> _m_SelectorView = PPtr<FlexibleLensSelectorView>.Read(reader);
        PPtr<ConsoleHint> _m_PrevHint = PPtr<ConsoleHint>.Read(reader);
        PPtr<ConsoleHint> _m_NextHint = PPtr<ConsoleHint>.Read(reader);
        PPtr<ConsoleHintsWidget> _m_ConsoleHintsWidget = PPtr<ConsoleHintsWidget>.Read(reader);
        PPtr<FadeAnimator> _m_Animator = PPtr<FadeAnimator>.Read(reader);
        PPtr<GameObject> _m_ControlsConsoleGroup = PPtr<GameObject>.Read(reader);
        PPtr<SettingsControlConsole> _m_PSConsoleGroup = PPtr<SettingsControlConsole>.Read(reader);
        PPtr<SettingsControlConsole> _m_DualSenseConsoleGroup = PPtr<SettingsControlConsole>.Read(reader);
        PPtr<SettingsControlConsole> _m_XBoxConsoleGroup = PPtr<SettingsControlConsole>.Read(reader);
        PPtr<SettingsControlConsole> _m_SwitchConsoleGroup = PPtr<SettingsControlConsole>.Read(reader);
        PPtr<SettingsControlConsole> _m_SteamConsoleGroup = PPtr<SettingsControlConsole>.Read(reader);
        PPtr<RectTransform> _m_SafeZoneFrame = PPtr<RectTransform>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_SettingsViews,
            _m_VirtualList,
            _m_InfoView,
            _m_BigGreenScreenView,
            _m_LittleGreenScreenView,
            _m_PaperGroup,
            _m_ScrollBarObject,
            _m_MenuSelector,
            _m_SelectorView,
            _m_PrevHint,
            _m_NextHint,
            _m_ConsoleHintsWidget,
            _m_Animator,
            _m_ControlsConsoleGroup,
            _m_PSConsoleGroup,
            _m_DualSenseConsoleGroup,
            _m_XBoxConsoleGroup,
            _m_SwitchConsoleGroup,
            _m_SteamConsoleGroup,
            _m_SafeZoneFrame);
    }
}


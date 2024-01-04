namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $SectorMapConsoleView (19 fields) E328F0A803AA3675F34E374D014F6CC3/011C7F23AB9186C287027D7D9CDD145D */
public record class SectorMapConsoleView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<SectorMapBottomHudConsoleView> m_SectorMapBottomHudConsoleView /* NeedsAlign */,
    PPtr<SpaceSystemInformationWindowConsoleView> m_SpaceSystemInformationWindowConsoleView /* None */,
    PPtr<AllSystemsInformationWindowConsoleView> m_AllSystemsInformationWindowConsoleView /* None */,
    PPtr<FadeAnimator> m_AdditionalHintsContainer /* None */,
    float m_HintsDisappearTime /* None */,
    PPtr<ConsoleHint> m_HorizontalDPadInformationWindowsHint /* None */,
    PPtr<ConsoleHint> m_VerticalDPadInformationWindowsHint /* None */,
    PPtr<ConsoleHint> m_CloseWindowInformationWindowsHint /* None */,
    PPtr<ConsoleHint> m_ShowTooltipBigInfoWindowInformationWindowsHint /* None */,
    PPtr<ConsoleHint> m_SwitchCursorHint /* None */,
    PPtr<ConsoleHint> m_SystemInfoHint /* None */,
    PPtr<ConsoleHint> m_ResourcesHint /* None */,
    PPtr<ConsoleHint> m_CloseResourcesHint /* None */,
    NavigationParameters m_Parameters /* None */,
    PPtr<SectorMapOvertipsConsoleView> m_SectorMapOvertipsConsoleView /* NeedsAlign */)
{
    public static SectorMapConsoleView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_SectorMapBottomHudConsoleView */
        PPtr<SectorMapBottomHudConsoleView> _m_SectorMapBottomHudConsoleView = PPtr<SectorMapBottomHudConsoleView>.Read(reader);
        PPtr<SpaceSystemInformationWindowConsoleView> _m_SpaceSystemInformationWindowConsoleView = PPtr<SpaceSystemInformationWindowConsoleView>.Read(reader);
        PPtr<AllSystemsInformationWindowConsoleView> _m_AllSystemsInformationWindowConsoleView = PPtr<AllSystemsInformationWindowConsoleView>.Read(reader);
        PPtr<FadeAnimator> _m_AdditionalHintsContainer = PPtr<FadeAnimator>.Read(reader);
        float _m_HintsDisappearTime = reader.ReadF32();
        PPtr<ConsoleHint> _m_HorizontalDPadInformationWindowsHint = PPtr<ConsoleHint>.Read(reader);
        PPtr<ConsoleHint> _m_VerticalDPadInformationWindowsHint = PPtr<ConsoleHint>.Read(reader);
        PPtr<ConsoleHint> _m_CloseWindowInformationWindowsHint = PPtr<ConsoleHint>.Read(reader);
        PPtr<ConsoleHint> _m_ShowTooltipBigInfoWindowInformationWindowsHint = PPtr<ConsoleHint>.Read(reader);
        PPtr<ConsoleHint> _m_SwitchCursorHint = PPtr<ConsoleHint>.Read(reader);
        PPtr<ConsoleHint> _m_SystemInfoHint = PPtr<ConsoleHint>.Read(reader);
        PPtr<ConsoleHint> _m_ResourcesHint = PPtr<ConsoleHint>.Read(reader);
        PPtr<ConsoleHint> _m_CloseResourcesHint = PPtr<ConsoleHint>.Read(reader);
        NavigationParameters _m_Parameters = NavigationParameters.Read(reader);
        reader.AlignTo(4); /* m_SectorMapOvertipsConsoleView */
        PPtr<SectorMapOvertipsConsoleView> _m_SectorMapOvertipsConsoleView = PPtr<SectorMapOvertipsConsoleView>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_SectorMapBottomHudConsoleView,
            _m_SpaceSystemInformationWindowConsoleView,
            _m_AllSystemsInformationWindowConsoleView,
            _m_AdditionalHintsContainer,
            _m_HintsDisappearTime,
            _m_HorizontalDPadInformationWindowsHint,
            _m_VerticalDPadInformationWindowsHint,
            _m_CloseWindowInformationWindowsHint,
            _m_ShowTooltipBigInfoWindowInformationWindowsHint,
            _m_SwitchCursorHint,
            _m_SystemInfoHint,
            _m_ResourcesHint,
            _m_CloseResourcesHint,
            _m_Parameters,
            _m_SectorMapOvertipsConsoleView);
    }
}


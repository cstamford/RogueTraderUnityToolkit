namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $SystemMapConsoleView (10 fields) 82DF266088FF83D91B7D30A05F6245C5/236EE24AAED6FDA01B06487534D0B8D1 */
public record class SystemMapConsoleView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<SystemMapOvertipsConsoleView> m_SystemMapOvertipsConsoleView /* NeedsAlign */,
    PPtr<StarSystemSpaceBarksHolderConsoleView> m_StarSystemSpaceBarksHolderConsoleView /* None */,
    PPtr<CombatLogConsoleView> m_CombatLogConsoleView /* None */,
    NavigationParameters m_Parameters /* None */,
    PPtr<ConsoleHint> m_InteractHint /* NeedsAlign */,
    PPtr<ConsoleHint> m_ToggleTooltipHint /* None */)
{
    public static SystemMapConsoleView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_SystemMapOvertipsConsoleView */
        PPtr<SystemMapOvertipsConsoleView> _m_SystemMapOvertipsConsoleView = PPtr<SystemMapOvertipsConsoleView>.Read(reader);
        PPtr<StarSystemSpaceBarksHolderConsoleView> _m_StarSystemSpaceBarksHolderConsoleView = PPtr<StarSystemSpaceBarksHolderConsoleView>.Read(reader);
        PPtr<CombatLogConsoleView> _m_CombatLogConsoleView = PPtr<CombatLogConsoleView>.Read(reader);
        NavigationParameters _m_Parameters = NavigationParameters.Read(reader);
        reader.AlignTo(4); /* m_InteractHint */
        PPtr<ConsoleHint> _m_InteractHint = PPtr<ConsoleHint>.Read(reader);
        PPtr<ConsoleHint> _m_ToggleTooltipHint = PPtr<ConsoleHint>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_SystemMapOvertipsConsoleView,
            _m_StarSystemSpaceBarksHolderConsoleView,
            _m_CombatLogConsoleView,
            _m_Parameters,
            _m_InteractHint,
            _m_ToggleTooltipHint);
    }
}


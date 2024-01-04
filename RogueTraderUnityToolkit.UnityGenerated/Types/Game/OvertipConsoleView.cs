namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $OvertipConsoleView (7 fields) C1213690FC1AE655CDA2560F4D3DDD7D/613EDEE86185DFD0C31402511E26ADEA */
public record class OvertipConsoleView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<ConsoleHint> m_Hint /* NeedsAlign */,
    PPtr<TextMeshProUGUI> m_HintLabel /* None */,
    PPtr<PageNavigationConsole> m_PageNavigation /* None */)
{
    public static OvertipConsoleView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_Hint */
        PPtr<ConsoleHint> _m_Hint = PPtr<ConsoleHint>.Read(reader);
        PPtr<TextMeshProUGUI> _m_HintLabel = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<PageNavigationConsole> _m_PageNavigation = PPtr<PageNavigationConsole>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_Hint,
            _m_HintLabel,
            _m_PageNavigation);
    }
}


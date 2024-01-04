namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $ColonyProjectsConsoleView (8 fields) 91EA70520ACE264E4E6F6CB1501B070D/CD4EADC880D1DA34AE73C6603885E1AC */
public record class ColonyProjectsConsoleView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<TextMeshProUGUI> m_HeaderLabel /* NeedsAlign */,
    PPtr<ColonyProjectsNavigationConsoleView> m_Navigation /* None */,
    PPtr<ColonyProjectsPageConsoleView> m_Page /* None */,
    PPtr<ConsoleHintsWidget> m_ConsoleHintsWidget /* None */)
{
    public static ColonyProjectsConsoleView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_HeaderLabel */
        PPtr<TextMeshProUGUI> _m_HeaderLabel = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<ColonyProjectsNavigationConsoleView> _m_Navigation = PPtr<ColonyProjectsNavigationConsoleView>.Read(reader);
        PPtr<ColonyProjectsPageConsoleView> _m_Page = PPtr<ColonyProjectsPageConsoleView>.Read(reader);
        PPtr<ConsoleHintsWidget> _m_ConsoleHintsWidget = PPtr<ConsoleHintsWidget>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_HeaderLabel,
            _m_Navigation,
            _m_Page,
            _m_ConsoleHintsWidget);
    }
}


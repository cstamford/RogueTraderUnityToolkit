namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $ColonyManagementNavigationElementConsoleView (7 fields) 25BAFEA32BF31C9006462B07FD8C6ECF/7C682A05FED5C314441F79E27A7370B6 */
public record class ColonyManagementNavigationElementConsoleView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<TextMeshProUGUI> m_Label /* NeedsAlign */,
    PPtr<OwlcatMultiButton> m_MultiButton /* None */,
    PPtr<ColonyEventNotificatorListPCView> m_ColonyEventNotificatorListPCView /* None */)
{
    public static ColonyManagementNavigationElementConsoleView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_Label */
        PPtr<TextMeshProUGUI> _m_Label = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<OwlcatMultiButton> _m_MultiButton = PPtr<OwlcatMultiButton>.Read(reader);
        PPtr<ColonyEventNotificatorListPCView> _m_ColonyEventNotificatorListPCView = PPtr<ColonyEventNotificatorListPCView>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_Label,
            _m_MultiButton,
            _m_ColonyEventNotificatorListPCView);
    }
}


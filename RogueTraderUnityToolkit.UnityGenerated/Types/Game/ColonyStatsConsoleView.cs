namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $ColonyStatsConsoleView (7 fields) FF5FA1541CD3343DA860D3B0FC63C015/D1CB44BE19D5EB13E772FE224303DF36 */
public record class ColonyStatsConsoleView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<TextMeshProUGUI> m_Title /* NeedsAlign */,
    PPtr<WidgetListMVVM> m_WidgetListStats /* None */,
    PPtr<ColonyStatConsoleView> m_ColonyStatConsoleView /* None */)
{
    public static ColonyStatsConsoleView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_Title */
        PPtr<TextMeshProUGUI> _m_Title = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<WidgetListMVVM> _m_WidgetListStats = PPtr<WidgetListMVVM>.Read(reader);
        PPtr<ColonyStatConsoleView> _m_ColonyStatConsoleView = PPtr<ColonyStatConsoleView>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_Title,
            _m_WidgetListStats,
            _m_ColonyStatConsoleView);
    }
}


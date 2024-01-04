namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $ColonyEventsConsoleView (8 fields) 1EDFC019DBCC652761AE1BF947DA0416/115B94F521CA2CEF48038C940D8CC2E4 */
public record class ColonyEventsConsoleView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<TextMeshProUGUI> m_HeaderLabel /* NeedsAlign */,
    PPtr<WidgetListMVVM> m_WidgetListEvents /* None */,
    PPtr<ScrollRectExtended> m_ScrollRect /* None */,
    PPtr<ColonyEventConsoleView> m_ColonyEventConsoleView /* None */)
{
    public static ColonyEventsConsoleView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_HeaderLabel */
        PPtr<TextMeshProUGUI> _m_HeaderLabel = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<WidgetListMVVM> _m_WidgetListEvents = PPtr<WidgetListMVVM>.Read(reader);
        PPtr<ScrollRectExtended> _m_ScrollRect = PPtr<ScrollRectExtended>.Read(reader);
        PPtr<ColonyEventConsoleView> _m_ColonyEventConsoleView = PPtr<ColonyEventConsoleView>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_HeaderLabel,
            _m_WidgetListEvents,
            _m_ScrollRect,
            _m_ColonyEventConsoleView);
    }
}


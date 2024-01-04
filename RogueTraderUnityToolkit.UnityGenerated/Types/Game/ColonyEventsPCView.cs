namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $ColonyEventsPCView (8 fields) ED0B1859E22D46FFBD08253B5E3019B3/7C727C46B94F1B8CB33EF41FA66F5109 */
public record class ColonyEventsPCView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<TextMeshProUGUI> m_HeaderLabel /* NeedsAlign */,
    PPtr<WidgetListMVVM> m_WidgetListEvents /* None */,
    PPtr<ScrollRectExtended> m_ScrollRect /* None */,
    PPtr<ColonyEventPCView> m_ColonyEventPCView /* None */)
{
    public static ColonyEventsPCView Read(EndianBinaryReader reader)
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
        PPtr<ColonyEventPCView> _m_ColonyEventPCView = PPtr<ColonyEventPCView>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_HeaderLabel,
            _m_WidgetListEvents,
            _m_ScrollRect,
            _m_ColonyEventPCView);
    }
}


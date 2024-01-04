namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $ItemSlotsGroupView (9 fields) C8E3FF125AAC5DEBECED9D59B64A114B/CBA7C78B214B17078E3BA9CCBF1FCA94 */
public record class ItemSlotsGroupView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    byte m_UseVirtualList /* NeedsAlign */,
    PPtr<VirtualListGridVertical> m_VirtualList /* NeedsAlign */,
    byte m_UseWidgetList /* None */,
    PPtr<WidgetListMVVM> m_WidgetList /* NeedsAlign */,
    int m_ColumnCount /* None */)
{
    public static ItemSlotsGroupView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_UseVirtualList */
        byte _m_UseVirtualList = reader.ReadU8();
        reader.AlignTo(4); /* m_VirtualList */
        PPtr<VirtualListGridVertical> _m_VirtualList = PPtr<VirtualListGridVertical>.Read(reader);
        byte _m_UseWidgetList = reader.ReadU8();
        reader.AlignTo(4); /* m_WidgetList */
        PPtr<WidgetListMVVM> _m_WidgetList = PPtr<WidgetListMVVM>.Read(reader);
        int _m_ColumnCount = reader.ReadS32();
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_UseVirtualList,
            _m_VirtualList,
            _m_UseWidgetList,
            _m_WidgetList,
            _m_ColumnCount);
    }
}


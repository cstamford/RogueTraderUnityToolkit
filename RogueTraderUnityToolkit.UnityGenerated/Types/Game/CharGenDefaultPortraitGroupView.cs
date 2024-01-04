namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $CharGenDefaultPortraitGroupView (9 fields) EB798F70F73B337DFE616DC4196F7AF6/886EEF3A223AFBF630D6D63069ACACF7 */
public record class CharGenDefaultPortraitGroupView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<WidgetListMVVM> m_WidgetList /* NeedsAlign */,
    PPtr<CharGenPortraitSelectorItemView> m_Prefab /* None */,
    PPtr<ExpandableElement> m_ExpandableElement /* None */,
    PPtr<TextMeshProUGUI> m_Label /* None */,
    int m_PortraitsInRow /* None */)
{
    public static CharGenDefaultPortraitGroupView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_WidgetList */
        PPtr<WidgetListMVVM> _m_WidgetList = PPtr<WidgetListMVVM>.Read(reader);
        PPtr<CharGenPortraitSelectorItemView> _m_Prefab = PPtr<CharGenPortraitSelectorItemView>.Read(reader);
        PPtr<ExpandableElement> _m_ExpandableElement = PPtr<ExpandableElement>.Read(reader);
        PPtr<TextMeshProUGUI> _m_Label = PPtr<TextMeshProUGUI>.Read(reader);
        int _m_PortraitsInRow = reader.ReadS32();
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_WidgetList,
            _m_Prefab,
            _m_ExpandableElement,
            _m_Label,
            _m_PortraitsInRow);
    }
}


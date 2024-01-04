namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $PostOfficerSelectionGroup (7 fields) 0E27EEEBEF1DDE0F4CFFED13787E8037/E80AB2F25CDE5613E3E341DE7FA2B5D7 */
public record class PostOfficerSelectionGroup(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<WidgetListMVVM> m_WidgetList /* NeedsAlign */,
    PPtr<PostOfficerView> m_OfficerView /* None */,
    PPtr<ScrollRectExtended> m_ScrollRect /* None */)
{
    public static PostOfficerSelectionGroup Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_WidgetList */
        PPtr<WidgetListMVVM> _m_WidgetList = PPtr<WidgetListMVVM>.Read(reader);
        PPtr<PostOfficerView> _m_OfficerView = PPtr<PostOfficerView>.Read(reader);
        PPtr<ScrollRectExtended> _m_ScrollRect = PPtr<ScrollRectExtended>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_WidgetList,
            _m_OfficerView,
            _m_ScrollRect);
    }
}


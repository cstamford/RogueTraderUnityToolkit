namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $CharGenPregenSelectorView (6 fields) 4EE95B47E4CF63D196A3A9F9678812BA/133EEDBC2F6C1D39E4FC6E26FC9FF9A7 */
public record class CharGenPregenSelectorView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<WidgetListMVVM> m_WidgetList /* NeedsAlign */,
    PPtr<CharGenPregenSelectorItemView> m_ItemViewPrefab /* None */)
{
    public static CharGenPregenSelectorView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_WidgetList */
        PPtr<WidgetListMVVM> _m_WidgetList = PPtr<WidgetListMVVM>.Read(reader);
        PPtr<CharGenPregenSelectorItemView> _m_ItemViewPrefab = PPtr<CharGenPregenSelectorItemView>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_WidgetList,
            _m_ItemViewPrefab);
    }
}


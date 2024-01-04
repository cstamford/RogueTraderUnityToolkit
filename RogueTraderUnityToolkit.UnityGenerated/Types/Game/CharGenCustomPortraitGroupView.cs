namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $CharGenCustomPortraitGroupView (8 fields) 2A488F8A54003AE0B7AED6B8DE5DB805/868FCA1A24591A3FDA7A02178F8F66E6 */
public record class CharGenCustomPortraitGroupView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<WidgetListMVVM> m_WidgetList /* NeedsAlign */,
    PPtr<CharGenPortraitSelectorItemView> m_Prefab /* None */,
    PPtr<CharGenCustomPortraitCreatorItemView> m_CreatorItemPrefab /* None */,
    int m_ItemsInRow /* None */)
{
    public static CharGenCustomPortraitGroupView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_WidgetList */
        PPtr<WidgetListMVVM> _m_WidgetList = PPtr<WidgetListMVVM>.Read(reader);
        PPtr<CharGenPortraitSelectorItemView> _m_Prefab = PPtr<CharGenPortraitSelectorItemView>.Read(reader);
        PPtr<CharGenCustomPortraitCreatorItemView> _m_CreatorItemPrefab = PPtr<CharGenCustomPortraitCreatorItemView>.Read(reader);
        int _m_ItemsInRow = reader.ReadS32();
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_WidgetList,
            _m_Prefab,
            _m_CreatorItemPrefab,
            _m_ItemsInRow);
    }
}


namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $CharGenPortraitTabSelectorView (6 fields) F85A3C2FED34450FD54D1C8419672679/37988C5FF9597F079699E595C1C128FD */
public record class CharGenPortraitTabSelectorView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<WidgetListMVVM> m_WidgetListMvvm /* NeedsAlign */,
    PPtr<CharGenPortraitTabView> m_Prefab /* None */)
{
    public static CharGenPortraitTabSelectorView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_WidgetListMvvm */
        PPtr<WidgetListMVVM> _m_WidgetListMvvm = PPtr<WidgetListMVVM>.Read(reader);
        PPtr<CharGenPortraitTabView> _m_Prefab = PPtr<CharGenPortraitTabView>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_WidgetListMvvm,
            _m_Prefab);
    }
}


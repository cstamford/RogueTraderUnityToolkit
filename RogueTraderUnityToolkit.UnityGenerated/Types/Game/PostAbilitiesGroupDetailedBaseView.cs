namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $PostAbilitiesGroupDetailedBaseView (7 fields) F13D24B60BC450EA387FC2349CA87CBD/1DDE567C251067D1693C9CAE2084E604 */
public record class PostAbilitiesGroupDetailedBaseView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<PostAbilityDetailedBaseView> m_PostAbilityDetailedBaseView /* NeedsAlign */,
    PPtr<WidgetListMVVM> m_WidgetList /* None */,
    PPtr<ScrollRectExtended> m_RectExtended /* None */)
{
    public static PostAbilitiesGroupDetailedBaseView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_PostAbilityDetailedBaseView */
        PPtr<PostAbilityDetailedBaseView> _m_PostAbilityDetailedBaseView = PPtr<PostAbilityDetailedBaseView>.Read(reader);
        PPtr<WidgetListMVVM> _m_WidgetList = PPtr<WidgetListMVVM>.Read(reader);
        PPtr<ScrollRectExtended> _m_RectExtended = PPtr<ScrollRectExtended>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_PostAbilityDetailedBaseView,
            _m_WidgetList,
            _m_RectExtended);
    }
}


namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $CharGenBackgroundBasePhaseSelectorView (6 fields) FF8EA956CAB7BD0BB6CAE4DCC550A08C/5F533877A70CBC8641CBF1083AD56F4F */
public record class CharGenBackgroundBasePhaseSelectorView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<WidgetListMVVM> m_WidgetList /* NeedsAlign */,
    PPtr<CharGenBackgroundBasePhaseSelectorItemView_1> m_ItemViewPrefab /* None */)
{
    public static CharGenBackgroundBasePhaseSelectorView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_WidgetList */
        PPtr<WidgetListMVVM> _m_WidgetList = PPtr<WidgetListMVVM>.Read(reader);
        PPtr<CharGenBackgroundBasePhaseSelectorItemView_1> _m_ItemViewPrefab = PPtr<CharGenBackgroundBasePhaseSelectorItemView_1>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_WidgetList,
            _m_ItemViewPrefab);
    }
}


namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $CharGenAttributesPhaseSelectorView (7 fields) 2EA6F6F71C4B6542CE20BB60D0C007E2/BE7621E14E0217D7F59FEA01B23BCCFE */
public record class CharGenAttributesPhaseSelectorView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<WidgetListMVVM> m_WidgetList /* NeedsAlign */,
    PPtr<CharGenAttributesPhaseSelectorItemView> m_ItemViewPrefab /* None */,
    PPtr<TextMeshProUGUI> m_Label /* None */)
{
    public static CharGenAttributesPhaseSelectorView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_WidgetList */
        PPtr<WidgetListMVVM> _m_WidgetList = PPtr<WidgetListMVVM>.Read(reader);
        PPtr<CharGenAttributesPhaseSelectorItemView> _m_ItemViewPrefab = PPtr<CharGenAttributesPhaseSelectorItemView>.Read(reader);
        PPtr<TextMeshProUGUI> _m_Label = PPtr<TextMeshProUGUI>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_WidgetList,
            _m_ItemViewPrefab,
            _m_Label);
    }
}


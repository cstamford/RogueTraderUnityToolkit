namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $CharGenVoiceSelectorGroupView (8 fields) 859CF5782F8CD4A70EEB2C3740C2E553/4345EA92A300A4EFB7D983445C2A1081 */
public record class CharGenVoiceSelectorGroupView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<WidgetListMVVM> m_WidgetList /* NeedsAlign */,
    PPtr<CharGenVoiceItemView> m_ItemPrefab /* None */,
    float m_EnsureVisibleFocusDelta /* None */,
    PPtr<ScrollRectExtended> m_ScrollRectExtended /* None */)
{
    public static CharGenVoiceSelectorGroupView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_WidgetList */
        PPtr<WidgetListMVVM> _m_WidgetList = PPtr<WidgetListMVVM>.Read(reader);
        PPtr<CharGenVoiceItemView> _m_ItemPrefab = PPtr<CharGenVoiceItemView>.Read(reader);
        float _m_EnsureVisibleFocusDelta = reader.ReadF32();
        PPtr<ScrollRectExtended> _m_ScrollRectExtended = PPtr<ScrollRectExtended>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_WidgetList,
            _m_ItemPrefab,
            _m_EnsureVisibleFocusDelta,
            _m_ScrollRectExtended);
    }
}


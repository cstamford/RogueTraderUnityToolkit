namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $VirtualListVertical (11 fields) 88F74F65DE21D827C5976F294CE66B89/63B075B5BC4A17011B803EBBF17854B7 */
public record class VirtualListVertical(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<RectTransform> m_Viewport /* NeedsAlign */,
    PPtr<RectTransform> m_Content /* None */,
    PPtr<Scrollbar> m_Scrollbar /* None */,
    PPtr<Button> m_BeginButton /* None */,
    PPtr<Button> m_EndButton /* None */,
    VirtualListScrollSettings m_ScrollSettings /* None */,
    VirtualListLayoutSettingsVertical m_LayoutSettings /* NeedsAlign */)
{
    public static VirtualListVertical Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_Viewport */
        PPtr<RectTransform> _m_Viewport = PPtr<RectTransform>.Read(reader);
        PPtr<RectTransform> _m_Content = PPtr<RectTransform>.Read(reader);
        PPtr<Scrollbar> _m_Scrollbar = PPtr<Scrollbar>.Read(reader);
        PPtr<Button> _m_BeginButton = PPtr<Button>.Read(reader);
        PPtr<Button> _m_EndButton = PPtr<Button>.Read(reader);
        VirtualListScrollSettings _m_ScrollSettings = VirtualListScrollSettings.Read(reader);
        reader.AlignTo(4); /* m_LayoutSettings */
        VirtualListLayoutSettingsVertical _m_LayoutSettings = VirtualListLayoutSettingsVertical.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_Viewport,
            _m_Content,
            _m_Scrollbar,
            _m_BeginButton,
            _m_EndButton,
            _m_ScrollSettings,
            _m_LayoutSettings);
    }
}

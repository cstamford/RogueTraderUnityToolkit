namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $Paginator (7 fields) C8E92CB45E127B7CABA57F66750BE3B0/2742A7DCE2CC5038AD6DEEAE130CE9F4 */
public record class Paginator(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<RectTransform> m_ViewPort /* NeedsAlign */,
    PPtr<RectTransform> m_Content /* None */,
    PPtr<PageNavigationPC> m_PageNavigation /* None */)
{
    public static Paginator Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_ViewPort */
        PPtr<RectTransform> _m_ViewPort = PPtr<RectTransform>.Read(reader);
        PPtr<RectTransform> _m_Content = PPtr<RectTransform>.Read(reader);
        PPtr<PageNavigationPC> _m_PageNavigation = PPtr<PageNavigationPC>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_ViewPort,
            _m_Content,
            _m_PageNavigation);
    }
}


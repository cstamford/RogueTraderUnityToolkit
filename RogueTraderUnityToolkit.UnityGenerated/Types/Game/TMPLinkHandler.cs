namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $TMPLinkHandler (14 fields) 99726829CB6FA9837014DEE325E6F170/535C9DB3718A5027FD73A3146C06520E */
public record class TMPLinkHandler(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    byte m_Interactable /* NeedsAlign */,
    byte m_ColorTransnition /* NeedsAlign */,
    byte m_OverlayNormalColor /* NeedsAlign */,
    ColorRGBA m_NormalColor /* NeedsAlign */,
    ColorRGBA m_HighlightedColor /* None */,
    byte m_HighlightedUnderline /* None */,
    LinkEventData m_OnClick /* NeedsAlign */,
    LinkEventData m_OnEnter /* NeedsAlign */,
    LinkEventData m_OnHover /* NeedsAlign */,
    LinkEventData m_OnExit /* NeedsAlign */)
{
    public static TMPLinkHandler Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_Interactable */
        byte _m_Interactable = reader.ReadU8();
        reader.AlignTo(4); /* m_ColorTransnition */
        byte _m_ColorTransnition = reader.ReadU8();
        reader.AlignTo(4); /* m_OverlayNormalColor */
        byte _m_OverlayNormalColor = reader.ReadU8();
        reader.AlignTo(4); /* m_NormalColor */
        ColorRGBA _m_NormalColor = ColorRGBA.Read(reader);
        ColorRGBA _m_HighlightedColor = ColorRGBA.Read(reader);
        byte _m_HighlightedUnderline = reader.ReadU8();
        reader.AlignTo(4); /* m_OnClick */
        LinkEventData _m_OnClick = LinkEventData.Read(reader);
        reader.AlignTo(4); /* m_OnEnter */
        LinkEventData _m_OnEnter = LinkEventData.Read(reader);
        reader.AlignTo(4); /* m_OnHover */
        LinkEventData _m_OnHover = LinkEventData.Read(reader);
        reader.AlignTo(4); /* m_OnExit */
        LinkEventData _m_OnExit = LinkEventData.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_Interactable,
            _m_ColorTransnition,
            _m_OverlayNormalColor,
            _m_NormalColor,
            _m_HighlightedColor,
            _m_HighlightedUnderline,
            _m_OnClick,
            _m_OnEnter,
            _m_OnHover,
            _m_OnExit);
    }
}


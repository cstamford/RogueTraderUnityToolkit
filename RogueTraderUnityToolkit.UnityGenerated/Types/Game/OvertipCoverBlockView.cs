namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $OvertipCoverBlockView (11 fields) 41A03C095DCBA65FC2BC0B8659B06058/18A233A774A678F610D8E9802B49D46D */
public record class OvertipCoverBlockView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<CanvasGroup> m_CanvasGroup /* NeedsAlign */,
    PPtr<Image> m_Icon /* None */,
    PPtr<Sprite> m_None /* None */,
    PPtr<Sprite> m_Half /* None */,
    PPtr<Sprite> m_Full /* None */,
    PPtr<Sprite> m_Invisible /* None */,
    BoolReactiveProperty IsVisible /* None */)
{
    public static OvertipCoverBlockView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_CanvasGroup */
        PPtr<CanvasGroup> _m_CanvasGroup = PPtr<CanvasGroup>.Read(reader);
        PPtr<Image> _m_Icon = PPtr<Image>.Read(reader);
        PPtr<Sprite> _m_None = PPtr<Sprite>.Read(reader);
        PPtr<Sprite> _m_Half = PPtr<Sprite>.Read(reader);
        PPtr<Sprite> _m_Full = PPtr<Sprite>.Read(reader);
        PPtr<Sprite> _m_Invisible = PPtr<Sprite>.Read(reader);
        BoolReactiveProperty _IsVisible = BoolReactiveProperty.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_CanvasGroup,
            _m_Icon,
            _m_None,
            _m_Half,
            _m_Full,
            _m_Invisible,
            _IsVisible);
    }
}


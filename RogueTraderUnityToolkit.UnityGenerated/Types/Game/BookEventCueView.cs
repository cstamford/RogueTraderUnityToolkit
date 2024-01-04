namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $BookEventCueView (15 fields) F528C75E3DFBA1504315C2E441C00C1E/A0C7728A61E6A9E8BFDDB4D0FC3405CF */
public record class BookEventCueView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<CanvasGroup> m_CueGroup /* NeedsAlign */,
    PPtr<TextMeshProUGUI> m_Text /* None */,
    BookEventCueStyle m_NormalText /* None */,
    BookEventCueStyle m_HighlightText /* None */,
    BookEventCueStyle m_ShadeText /* None */,
    BookEventCueStyle m_SpecialText /* None */,
    PPtr<TMP_FontAsset> m_FirstLetterFont /* None */,
    PPtr<Material> m_FirstLetterFontMaterial /* None */,
    ColorRGBA m_FirstLetterColor /* None */,
    int m_FirstLetterSize /* None */,
    int m_FirstLetterVOffset /* None */)
{
    public static BookEventCueView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_CueGroup */
        PPtr<CanvasGroup> _m_CueGroup = PPtr<CanvasGroup>.Read(reader);
        PPtr<TextMeshProUGUI> _m_Text = PPtr<TextMeshProUGUI>.Read(reader);
        BookEventCueStyle _m_NormalText = BookEventCueStyle.Read(reader);
        BookEventCueStyle _m_HighlightText = BookEventCueStyle.Read(reader);
        BookEventCueStyle _m_ShadeText = BookEventCueStyle.Read(reader);
        BookEventCueStyle _m_SpecialText = BookEventCueStyle.Read(reader);
        PPtr<TMP_FontAsset> _m_FirstLetterFont = PPtr<TMP_FontAsset>.Read(reader);
        PPtr<Material> _m_FirstLetterFontMaterial = PPtr<Material>.Read(reader);
        ColorRGBA _m_FirstLetterColor = ColorRGBA.Read(reader);
        int _m_FirstLetterSize = reader.ReadS32();
        int _m_FirstLetterVOffset = reader.ReadS32();
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_CueGroup,
            _m_Text,
            _m_NormalText,
            _m_HighlightText,
            _m_ShadeText,
            _m_SpecialText,
            _m_FirstLetterFont,
            _m_FirstLetterFontMaterial,
            _m_FirstLetterColor,
            _m_FirstLetterSize,
            _m_FirstLetterVOffset);
    }
}


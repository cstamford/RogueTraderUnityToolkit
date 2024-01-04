namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $TooltipBrickNestedMessageConsoleView (12 fields) BC47B69DB945D26B9B506CFC271AD679/467061B18A3240AE29443A39F3F347EA */
public record class TooltipBrickNestedMessageConsoleView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<TextMeshProUGUI> m_Text /* NeedsAlign */,
    PPtr<Image> m_Line /* None */,
    PPtr<CanvasGroup> m_PrefixCanvasGroup /* None */,
    PPtr<Image> m_IconImage /* None */,
    PPtr<RectTransform> m_TooltipPlaceRectTransform /* None */,
    PPtr<CanvasGroup> m_HighlightCanvasGroup /* None */,
    float m_DefaultFontSize /* None */,
    PPtr<OwlcatMultiButton> m_FocusMultiButton /* None */)
{
    public static TooltipBrickNestedMessageConsoleView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_Text */
        PPtr<TextMeshProUGUI> _m_Text = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<Image> _m_Line = PPtr<Image>.Read(reader);
        PPtr<CanvasGroup> _m_PrefixCanvasGroup = PPtr<CanvasGroup>.Read(reader);
        PPtr<Image> _m_IconImage = PPtr<Image>.Read(reader);
        PPtr<RectTransform> _m_TooltipPlaceRectTransform = PPtr<RectTransform>.Read(reader);
        PPtr<CanvasGroup> _m_HighlightCanvasGroup = PPtr<CanvasGroup>.Read(reader);
        float _m_DefaultFontSize = reader.ReadF32();
        PPtr<OwlcatMultiButton> _m_FocusMultiButton = PPtr<OwlcatMultiButton>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_Text,
            _m_Line,
            _m_PrefixCanvasGroup,
            _m_IconImage,
            _m_TooltipPlaceRectTransform,
            _m_HighlightCanvasGroup,
            _m_DefaultFontSize,
            _m_FocusMultiButton);
    }
}


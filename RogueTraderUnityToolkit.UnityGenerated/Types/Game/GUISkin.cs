namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $GUISkin (27 fields) 8155619E65D4F04FA1D2860CC3B83554/9D93B54743E29AC79381A9EFDCB250DE */
public record class GUISkin(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<Font> m_Font /* NeedsAlign */,
    GUIStyle m_box /* None */,
    GUIStyle m_button /* NeedsAlign */,
    GUIStyle m_toggle /* NeedsAlign */,
    GUIStyle m_label /* NeedsAlign */,
    GUIStyle m_textField /* NeedsAlign */,
    GUIStyle m_textArea /* NeedsAlign */,
    GUIStyle m_window /* NeedsAlign */,
    GUIStyle m_horizontalSlider /* NeedsAlign */,
    GUIStyle m_horizontalSliderThumb /* NeedsAlign */,
    GUIStyle m_verticalSlider /* NeedsAlign */,
    GUIStyle m_verticalSliderThumb /* NeedsAlign */,
    GUIStyle m_horizontalScrollbar /* NeedsAlign */,
    GUIStyle m_horizontalScrollbarThumb /* NeedsAlign */,
    GUIStyle m_horizontalScrollbarLeftButton /* NeedsAlign */,
    GUIStyle m_horizontalScrollbarRightButton /* NeedsAlign */,
    GUIStyle m_verticalScrollbar /* NeedsAlign */,
    GUIStyle m_verticalScrollbarThumb /* NeedsAlign */,
    GUIStyle m_verticalScrollbarUpButton /* NeedsAlign */,
    GUIStyle m_verticalScrollbarDownButton /* NeedsAlign */,
    GUIStyle m_ScrollView /* NeedsAlign */,
    GUIStyle[] m_CustomStyles /* NeedsAlign */,
    GUISettings m_Settings /* NeedsAlign */)
{
    public static GUISkin Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_Font */
        PPtr<Font> _m_Font = PPtr<Font>.Read(reader);
        GUIStyle _m_box = GUIStyle.Read(reader);
        reader.AlignTo(4); /* m_button */
        GUIStyle _m_button = GUIStyle.Read(reader);
        reader.AlignTo(4); /* m_toggle */
        GUIStyle _m_toggle = GUIStyle.Read(reader);
        reader.AlignTo(4); /* m_label */
        GUIStyle _m_label = GUIStyle.Read(reader);
        reader.AlignTo(4); /* m_textField */
        GUIStyle _m_textField = GUIStyle.Read(reader);
        reader.AlignTo(4); /* m_textArea */
        GUIStyle _m_textArea = GUIStyle.Read(reader);
        reader.AlignTo(4); /* m_window */
        GUIStyle _m_window = GUIStyle.Read(reader);
        reader.AlignTo(4); /* m_horizontalSlider */
        GUIStyle _m_horizontalSlider = GUIStyle.Read(reader);
        reader.AlignTo(4); /* m_horizontalSliderThumb */
        GUIStyle _m_horizontalSliderThumb = GUIStyle.Read(reader);
        reader.AlignTo(4); /* m_verticalSlider */
        GUIStyle _m_verticalSlider = GUIStyle.Read(reader);
        reader.AlignTo(4); /* m_verticalSliderThumb */
        GUIStyle _m_verticalSliderThumb = GUIStyle.Read(reader);
        reader.AlignTo(4); /* m_horizontalScrollbar */
        GUIStyle _m_horizontalScrollbar = GUIStyle.Read(reader);
        reader.AlignTo(4); /* m_horizontalScrollbarThumb */
        GUIStyle _m_horizontalScrollbarThumb = GUIStyle.Read(reader);
        reader.AlignTo(4); /* m_horizontalScrollbarLeftButton */
        GUIStyle _m_horizontalScrollbarLeftButton = GUIStyle.Read(reader);
        reader.AlignTo(4); /* m_horizontalScrollbarRightButton */
        GUIStyle _m_horizontalScrollbarRightButton = GUIStyle.Read(reader);
        reader.AlignTo(4); /* m_verticalScrollbar */
        GUIStyle _m_verticalScrollbar = GUIStyle.Read(reader);
        reader.AlignTo(4); /* m_verticalScrollbarThumb */
        GUIStyle _m_verticalScrollbarThumb = GUIStyle.Read(reader);
        reader.AlignTo(4); /* m_verticalScrollbarUpButton */
        GUIStyle _m_verticalScrollbarUpButton = GUIStyle.Read(reader);
        reader.AlignTo(4); /* m_verticalScrollbarDownButton */
        GUIStyle _m_verticalScrollbarDownButton = GUIStyle.Read(reader);
        reader.AlignTo(4); /* m_ScrollView */
        GUIStyle _m_ScrollView = GUIStyle.Read(reader);
        reader.AlignTo(4); /* m_CustomStyles */
        GUIStyle[] _m_CustomStyles = BuiltInArray<GUIStyle>.Read(reader);
        reader.AlignTo(4); /* m_Settings */
        GUISettings _m_Settings = GUISettings.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_Font,
            _m_box,
            _m_button,
            _m_toggle,
            _m_label,
            _m_textField,
            _m_textArea,
            _m_window,
            _m_horizontalSlider,
            _m_horizontalSliderThumb,
            _m_verticalSlider,
            _m_verticalSliderThumb,
            _m_horizontalScrollbar,
            _m_horizontalScrollbarThumb,
            _m_horizontalScrollbarLeftButton,
            _m_horizontalScrollbarRightButton,
            _m_verticalScrollbar,
            _m_verticalScrollbarThumb,
            _m_verticalScrollbarUpButton,
            _m_verticalScrollbarDownButton,
            _m_ScrollView,
            _m_CustomStyles,
            _m_Settings);
    }
}


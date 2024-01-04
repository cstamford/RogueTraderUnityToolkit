namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $SettingsEntitySliderFontSizePCView (19 fields) 867312D8B31521DF329A0EA9D7B09642/19503150B7D7172CC7E1372DAD26DE1E */
public record class SettingsEntitySliderFontSizePCView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<GameObject> m_SetConnector /* NeedsAlign */,
    PPtr<GameObject> m_SetConnectorIAmSet /* None */,
    PPtr<TextMeshProUGUI> m_Title /* None */,
    PPtr<Image> m_HighlightedImage /* None */,
    ColorRGBA NormalColor /* None */,
    ColorRGBA OddColor /* None */,
    ColorRGBA HighlightedColor /* None */,
    PPtr<Image> m_PointImage /* None */,
    PPtr<Image> m_MarkImage /* None */,
    PPtr<Slider> Slider /* None */,
    PPtr<TextMeshProUGUI> LabelSliderValue /* None */,
    PPtr<TextMeshProUGUI> m_FontSizeExample /* None */,
    float m_OriginalFontSize /* None */,
    PPtr<TMP_FontAsset>[] Fonts /* None */,
    VirtualListLayoutElementSettings m_LayoutSettings /* None */)
{
    public static SettingsEntitySliderFontSizePCView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_SetConnector */
        PPtr<GameObject> _m_SetConnector = PPtr<GameObject>.Read(reader);
        PPtr<GameObject> _m_SetConnectorIAmSet = PPtr<GameObject>.Read(reader);
        PPtr<TextMeshProUGUI> _m_Title = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<Image> _m_HighlightedImage = PPtr<Image>.Read(reader);
        ColorRGBA _NormalColor = ColorRGBA.Read(reader);
        ColorRGBA _OddColor = ColorRGBA.Read(reader);
        ColorRGBA _HighlightedColor = ColorRGBA.Read(reader);
        PPtr<Image> _m_PointImage = PPtr<Image>.Read(reader);
        PPtr<Image> _m_MarkImage = PPtr<Image>.Read(reader);
        PPtr<Slider> _Slider = PPtr<Slider>.Read(reader);
        PPtr<TextMeshProUGUI> _LabelSliderValue = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<TextMeshProUGUI> _m_FontSizeExample = PPtr<TextMeshProUGUI>.Read(reader);
        float _m_OriginalFontSize = reader.ReadF32();
        PPtr<TMP_FontAsset>[] _Fonts = BuiltInArray<PPtr<TMP_FontAsset>>.Read(reader);
        VirtualListLayoutElementSettings _m_LayoutSettings = VirtualListLayoutElementSettings.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_SetConnector,
            _m_SetConnectorIAmSet,
            _m_Title,
            _m_HighlightedImage,
            _NormalColor,
            _OddColor,
            _HighlightedColor,
            _m_PointImage,
            _m_MarkImage,
            _Slider,
            _LabelSliderValue,
            _m_FontSizeExample,
            _m_OriginalFontSize,
            _Fonts,
            _m_LayoutSettings);
    }
}


namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $TooltipBrickShotDeviationWithNameView (13 fields) A2D25C3401391AA972C5AABA1BE27184/53E821661F2E1887F5A01302ED715091 */
public record class TooltipBrickShotDeviationWithNameView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<TextMeshProUGUI> m_NameText /* NeedsAlign */,
    ColorRGBA m_TextOrangeColor /* None */,
    PPtr<Slider> m_DeviationValueSlider /* None */,
    PPtr<RectTransform> m_CentralDeviationAnchorSlider /* None */,
    PPtr<RectTransform> m_SlightDeviationAnchorSlider /* None */,
    PPtr<RectTransform> m_FarDeviationAnchorSlider /* None */,
    PPtr<TextMeshProUGUI> m_DeviationMinValueText /* None */,
    PPtr<TextMeshProUGUI> m_DeviationMaxValueText /* None */,
    PPtr<TextMeshProUGUI> m_DeviationValueText /* None */)
{
    public static TooltipBrickShotDeviationWithNameView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_NameText */
        PPtr<TextMeshProUGUI> _m_NameText = PPtr<TextMeshProUGUI>.Read(reader);
        ColorRGBA _m_TextOrangeColor = ColorRGBA.Read(reader);
        PPtr<Slider> _m_DeviationValueSlider = PPtr<Slider>.Read(reader);
        PPtr<RectTransform> _m_CentralDeviationAnchorSlider = PPtr<RectTransform>.Read(reader);
        PPtr<RectTransform> _m_SlightDeviationAnchorSlider = PPtr<RectTransform>.Read(reader);
        PPtr<RectTransform> _m_FarDeviationAnchorSlider = PPtr<RectTransform>.Read(reader);
        PPtr<TextMeshProUGUI> _m_DeviationMinValueText = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<TextMeshProUGUI> _m_DeviationMaxValueText = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<TextMeshProUGUI> _m_DeviationValueText = PPtr<TextMeshProUGUI>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_NameText,
            _m_TextOrangeColor,
            _m_DeviationValueSlider,
            _m_CentralDeviationAnchorSlider,
            _m_SlightDeviationAnchorSlider,
            _m_FarDeviationAnchorSlider,
            _m_DeviationMinValueText,
            _m_DeviationMaxValueText,
            _m_DeviationValueText);
    }
}


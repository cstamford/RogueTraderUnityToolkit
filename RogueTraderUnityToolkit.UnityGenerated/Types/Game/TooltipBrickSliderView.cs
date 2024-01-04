namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $TooltipBrickSliderView (15 fields) F0D9EAB36F60E184F01B5A9364D6657A/92B393DD99B18608E3963E937042DF99 */
public record class TooltipBrickSliderView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<BrickSliderValueView> m_ValueViewPrefab /* NeedsAlign */,
    PPtr<Transform> m_ValueViewsContainer /* None */,
    PPtr<BrickSliderValueView>[] m_SliderValueViews /* None */,
    PPtr<Slider> m_Slider /* None */,
    PPtr<Image> m_Image /* None */,
    PPtr<TextMeshProUGUI> m_MaxValue /* None */,
    PPtr<TextMeshProUGUI> m_MaxValueText /* None */,
    PPtr<TextMeshProUGUI> m_CurrentValue /* None */,
    PPtr<LayoutElement> m_LayoutElement /* None */,
    float m_DefaultFontSize /* None */,
    float m_DefaultConsoleFontSize /* None */)
{
    public static TooltipBrickSliderView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_ValueViewPrefab */
        PPtr<BrickSliderValueView> _m_ValueViewPrefab = PPtr<BrickSliderValueView>.Read(reader);
        PPtr<Transform> _m_ValueViewsContainer = PPtr<Transform>.Read(reader);
        PPtr<BrickSliderValueView>[] _m_SliderValueViews = BuiltInArray<PPtr<BrickSliderValueView>>.Read(reader);
        PPtr<Slider> _m_Slider = PPtr<Slider>.Read(reader);
        PPtr<Image> _m_Image = PPtr<Image>.Read(reader);
        PPtr<TextMeshProUGUI> _m_MaxValue = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<TextMeshProUGUI> _m_MaxValueText = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<TextMeshProUGUI> _m_CurrentValue = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<LayoutElement> _m_LayoutElement = PPtr<LayoutElement>.Read(reader);
        float _m_DefaultFontSize = reader.ReadF32();
        float _m_DefaultConsoleFontSize = reader.ReadF32();
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_ValueViewPrefab,
            _m_ValueViewsContainer,
            _m_SliderValueViews,
            _m_Slider,
            _m_Image,
            _m_MaxValue,
            _m_MaxValueText,
            _m_CurrentValue,
            _m_LayoutElement,
            _m_DefaultFontSize,
            _m_DefaultConsoleFontSize);
    }
}


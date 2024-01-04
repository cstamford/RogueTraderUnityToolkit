namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $LampSliderPrediction (16 fields) F1B7C19997DC0D850EEA29CD06120808/11CB437761EAA1ED6466DA43805C9F4D */
public record class LampSliderPrediction(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    float m_SliderAnimationTime /* NeedsAlign */,
    float m_SliderAnimationBlinkTime /* None */,
    PPtr<Slider> m_FrontSlider /* None */,
    PPtr<Slider> m_BackSlider /* None */,
    PPtr<CanvasGroup> m_BackSliderCanvasGroup /* None */,
    PPtr<RectTransform> m_DisableLampsContainer /* None */,
    PPtr<Image> m_DisableLampImage /* None */,
    PPtr<RectTransform> m_BackLampsContainer /* None */,
    PPtr<Image> m_BackLampImage /* None */,
    PPtr<RectTransform> m_FrontLampsContainer /* None */,
    PPtr<Image> m_FrontLampImage /* None */,
    PPtr<Image> m_HintPlace /* None */)
{
    public static LampSliderPrediction Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_SliderAnimationTime */
        float _m_SliderAnimationTime = reader.ReadF32();
        float _m_SliderAnimationBlinkTime = reader.ReadF32();
        PPtr<Slider> _m_FrontSlider = PPtr<Slider>.Read(reader);
        PPtr<Slider> _m_BackSlider = PPtr<Slider>.Read(reader);
        PPtr<CanvasGroup> _m_BackSliderCanvasGroup = PPtr<CanvasGroup>.Read(reader);
        PPtr<RectTransform> _m_DisableLampsContainer = PPtr<RectTransform>.Read(reader);
        PPtr<Image> _m_DisableLampImage = PPtr<Image>.Read(reader);
        PPtr<RectTransform> _m_BackLampsContainer = PPtr<RectTransform>.Read(reader);
        PPtr<Image> _m_BackLampImage = PPtr<Image>.Read(reader);
        PPtr<RectTransform> _m_FrontLampsContainer = PPtr<RectTransform>.Read(reader);
        PPtr<Image> _m_FrontLampImage = PPtr<Image>.Read(reader);
        PPtr<Image> _m_HintPlace = PPtr<Image>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_SliderAnimationTime,
            _m_SliderAnimationBlinkTime,
            _m_FrontSlider,
            _m_BackSlider,
            _m_BackSliderCanvasGroup,
            _m_DisableLampsContainer,
            _m_DisableLampImage,
            _m_BackLampsContainer,
            _m_BackLampImage,
            _m_FrontLampsContainer,
            _m_FrontLampImage,
            _m_HintPlace);
    }
}


namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $RollSlider (16 fields) 1CFDB17A591658F33435821FBF9ABB75/5ED290C84C4A659D6013F311B3D9DE6D */
public record class RollSlider(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<Slider> m_SufficientValueSlider /* NeedsAlign */,
    PPtr<Slider> m_CurrentValueSlider /* None */,
    PPtr<TextMeshProUGUI> m_ChanceValueText /* None */,
    PPtr<Image> m_ResultSignImage /* None */,
    PPtr<Image> m_CurrentHandleImage /* None */,
    PPtr<Sprite> m_ResultSignSuccessSprite /* None */,
    PPtr<Sprite> m_ResultSignFailedSprite /* None */,
    PPtr<Sprite> m_HandleSuccessSprite /* None */,
    PPtr<Sprite> m_HandleFailedSprite /* None */,
    ColorRGBA m_OrangeColor /* None */,
    ColorRGBA m_BlueColor /* None */,
    ColorRGBA m_LightColor /* None */)
{
    public static RollSlider Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_SufficientValueSlider */
        PPtr<Slider> _m_SufficientValueSlider = PPtr<Slider>.Read(reader);
        PPtr<Slider> _m_CurrentValueSlider = PPtr<Slider>.Read(reader);
        PPtr<TextMeshProUGUI> _m_ChanceValueText = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<Image> _m_ResultSignImage = PPtr<Image>.Read(reader);
        PPtr<Image> _m_CurrentHandleImage = PPtr<Image>.Read(reader);
        PPtr<Sprite> _m_ResultSignSuccessSprite = PPtr<Sprite>.Read(reader);
        PPtr<Sprite> _m_ResultSignFailedSprite = PPtr<Sprite>.Read(reader);
        PPtr<Sprite> _m_HandleSuccessSprite = PPtr<Sprite>.Read(reader);
        PPtr<Sprite> _m_HandleFailedSprite = PPtr<Sprite>.Read(reader);
        ColorRGBA _m_OrangeColor = ColorRGBA.Read(reader);
        ColorRGBA _m_BlueColor = ColorRGBA.Read(reader);
        ColorRGBA _m_LightColor = ColorRGBA.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_SufficientValueSlider,
            _m_CurrentValueSlider,
            _m_ChanceValueText,
            _m_ResultSignImage,
            _m_CurrentHandleImage,
            _m_ResultSignSuccessSprite,
            _m_ResultSignFailedSprite,
            _m_HandleSuccessSprite,
            _m_HandleFailedSprite,
            _m_OrangeColor,
            _m_BlueColor,
            _m_LightColor);
    }
}


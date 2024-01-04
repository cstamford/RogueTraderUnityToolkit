namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $EncumbranceView (12 fields) B1F7B71013410C90CA3FBE1F834E7E3A/747CBDDA61DC04D70CF303E9936A5ADB */
public record class EncumbranceView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<TextMeshProUGUI> m_Label /* NeedsAlign */,
    PPtr<Slider> m_CurrentLoadSlider /* None */,
    PPtr<TextMeshProUGUI> m_CurrentLoadWeight /* None */,
    ColorRGBA m_LightColor /* None */,
    ColorRGBA m_MiddleColor /* None */,
    ColorRGBA m_HeavyColor /* None */,
    ColorRGBA m_OverloadColor /* None */,
    PPtr<Graphic> m_FillGraphic /* None */)
{
    public static EncumbranceView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_Label */
        PPtr<TextMeshProUGUI> _m_Label = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<Slider> _m_CurrentLoadSlider = PPtr<Slider>.Read(reader);
        PPtr<TextMeshProUGUI> _m_CurrentLoadWeight = PPtr<TextMeshProUGUI>.Read(reader);
        ColorRGBA _m_LightColor = ColorRGBA.Read(reader);
        ColorRGBA _m_MiddleColor = ColorRGBA.Read(reader);
        ColorRGBA _m_HeavyColor = ColorRGBA.Read(reader);
        ColorRGBA _m_OverloadColor = ColorRGBA.Read(reader);
        PPtr<Graphic> _m_FillGraphic = PPtr<Graphic>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_Label,
            _m_CurrentLoadSlider,
            _m_CurrentLoadWeight,
            _m_LightColor,
            _m_MiddleColor,
            _m_HeavyColor,
            _m_OverloadColor,
            _m_FillGraphic);
    }
}


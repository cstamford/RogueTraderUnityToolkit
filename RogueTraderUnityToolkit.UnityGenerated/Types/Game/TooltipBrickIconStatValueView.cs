namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $TooltipBrickIconStatValueView (25 fields) 0E16170569CCDE9B38DF040DD1C97232/8F535630E144C5C43D1E933A2F1DC691 */
public record class TooltipBrickIconStatValueView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<TextMeshProUGUI> m_Label /* NeedsAlign */,
    PPtr<TextMeshProUGUI> m_Value /* None */,
    PPtr<TextMeshProUGUI> m_AddValue /* None */,
    PPtr<Image> m_Icon /* None */,
    PPtr<TextMeshProUGUI> m_IconText /* None */,
    PPtr<Image> m_Background /* None */,
    PPtr<GameObject>[] m_HasValueGroup /* None */,
    float m_DefaultIconSize /* None */,
    ColorRGBA m_NormalColor /* None */,
    ColorRGBA m_PositiveColor /* None */,
    ColorRGBA m_NegativeColor /* None */,
    ColorRGBA m_NormalBackgroundColor /* None */,
    ColorRGBA m_PositiveBackgroundColor /* None */,
    ColorRGBA m_NegativeBackgroundColor /* None */,
    float m_NonNormalWidthExpanse /* None */,
    float m_DefaultFontSizeLabel /* None */,
    float m_DefaultFontSizeValue /* None */,
    float m_DefaultFontSizeAddValue /* None */,
    float m_DefaultConsoleFontSizeLabel /* None */,
    float m_DefaultConsoleFontSizeValue /* None */,
    float m_DefaultConsoleFontSizeAddValue /* None */)
{
    public static TooltipBrickIconStatValueView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_Label */
        PPtr<TextMeshProUGUI> _m_Label = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<TextMeshProUGUI> _m_Value = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<TextMeshProUGUI> _m_AddValue = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<Image> _m_Icon = PPtr<Image>.Read(reader);
        PPtr<TextMeshProUGUI> _m_IconText = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<Image> _m_Background = PPtr<Image>.Read(reader);
        PPtr<GameObject>[] _m_HasValueGroup = BuiltInArray<PPtr<GameObject>>.Read(reader);
        float _m_DefaultIconSize = reader.ReadF32();
        ColorRGBA _m_NormalColor = ColorRGBA.Read(reader);
        ColorRGBA _m_PositiveColor = ColorRGBA.Read(reader);
        ColorRGBA _m_NegativeColor = ColorRGBA.Read(reader);
        ColorRGBA _m_NormalBackgroundColor = ColorRGBA.Read(reader);
        ColorRGBA _m_PositiveBackgroundColor = ColorRGBA.Read(reader);
        ColorRGBA _m_NegativeBackgroundColor = ColorRGBA.Read(reader);
        float _m_NonNormalWidthExpanse = reader.ReadF32();
        float _m_DefaultFontSizeLabel = reader.ReadF32();
        float _m_DefaultFontSizeValue = reader.ReadF32();
        float _m_DefaultFontSizeAddValue = reader.ReadF32();
        float _m_DefaultConsoleFontSizeLabel = reader.ReadF32();
        float _m_DefaultConsoleFontSizeValue = reader.ReadF32();
        float _m_DefaultConsoleFontSizeAddValue = reader.ReadF32();
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_Label,
            _m_Value,
            _m_AddValue,
            _m_Icon,
            _m_IconText,
            _m_Background,
            _m_HasValueGroup,
            _m_DefaultIconSize,
            _m_NormalColor,
            _m_PositiveColor,
            _m_NegativeColor,
            _m_NormalBackgroundColor,
            _m_PositiveBackgroundColor,
            _m_NegativeBackgroundColor,
            _m_NonNormalWidthExpanse,
            _m_DefaultFontSizeLabel,
            _m_DefaultFontSizeValue,
            _m_DefaultFontSizeAddValue,
            _m_DefaultConsoleFontSizeLabel,
            _m_DefaultConsoleFontSizeValue,
            _m_DefaultConsoleFontSizeAddValue);
    }
}


namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $TooltipBrickTextBackgroundView (16 fields) E9295B6C5AE7579D0FFBDFFD73608296/2F353DEC3BCF59A06DF685FD332EBD6C */
public record class TooltipBrickTextBackgroundView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<TextMeshProUGUI> m_Text /* NeedsAlign */,
    PPtr<Image> m_BackgroundImage /* None */,
    PPtr<GameObject> m_RightDecoration /* None */,
    PPtr<GameObject> m_LeftDecoration /* None */,
    PPtr<LayoutGroup> m_LayoutGroup /* None */,
    ColorRGBA m_DefaultColor /* None */,
    ColorRGBA m_BrightColor /* None */,
    float m_DefaultFontSize /* None */,
    float m_DefaultConsoleFontSize /* None */,
    ColorRGBA m_GrayBackgroundColor /* None */,
    ColorRGBA m_GreenBackgroundColor /* None */,
    ColorRGBA m_RedBackgroundColor /* None */)
{
    public static TooltipBrickTextBackgroundView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_Text */
        PPtr<TextMeshProUGUI> _m_Text = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<Image> _m_BackgroundImage = PPtr<Image>.Read(reader);
        PPtr<GameObject> _m_RightDecoration = PPtr<GameObject>.Read(reader);
        PPtr<GameObject> _m_LeftDecoration = PPtr<GameObject>.Read(reader);
        PPtr<LayoutGroup> _m_LayoutGroup = PPtr<LayoutGroup>.Read(reader);
        ColorRGBA _m_DefaultColor = ColorRGBA.Read(reader);
        ColorRGBA _m_BrightColor = ColorRGBA.Read(reader);
        float _m_DefaultFontSize = reader.ReadF32();
        float _m_DefaultConsoleFontSize = reader.ReadF32();
        ColorRGBA _m_GrayBackgroundColor = ColorRGBA.Read(reader);
        ColorRGBA _m_GreenBackgroundColor = ColorRGBA.Read(reader);
        ColorRGBA _m_RedBackgroundColor = ColorRGBA.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_Text,
            _m_BackgroundImage,
            _m_RightDecoration,
            _m_LeftDecoration,
            _m_LayoutGroup,
            _m_DefaultColor,
            _m_BrightColor,
            _m_DefaultFontSize,
            _m_DefaultConsoleFontSize,
            _m_GrayBackgroundColor,
            _m_GreenBackgroundColor,
            _m_RedBackgroundColor);
    }
}


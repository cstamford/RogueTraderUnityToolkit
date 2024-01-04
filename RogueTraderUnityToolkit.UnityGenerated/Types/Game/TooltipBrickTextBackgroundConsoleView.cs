namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $TooltipBrickTextBackgroundConsoleView (21 fields) 4A8944BECF835461B48010B029DFF0A4/BA2AC7B142D2D3AFDB7B8535FAEB3F98 */
public record class TooltipBrickTextBackgroundConsoleView(
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
    ColorRGBA m_RedBackgroundColor /* None */,
    PPtr<RectTransform> m_TextContainer /* None */,
    PPtr<OwlcatMultiButton> m_FrameButtonPrefab /* None */,
    PPtr<OwlcatMultiButton> m_MultiButtonFirstFocus /* None */,
    PPtr<OwlcatMultiButton> m_MultiButtonSecondFocus /* None */,
    NavigationParameters m_NavigationParameters /* None */)
{
    public static TooltipBrickTextBackgroundConsoleView Read(EndianBinaryReader reader)
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
        PPtr<RectTransform> _m_TextContainer = PPtr<RectTransform>.Read(reader);
        PPtr<OwlcatMultiButton> _m_FrameButtonPrefab = PPtr<OwlcatMultiButton>.Read(reader);
        PPtr<OwlcatMultiButton> _m_MultiButtonFirstFocus = PPtr<OwlcatMultiButton>.Read(reader);
        PPtr<OwlcatMultiButton> _m_MultiButtonSecondFocus = PPtr<OwlcatMultiButton>.Read(reader);
        NavigationParameters _m_NavigationParameters = NavigationParameters.Read(reader);
        
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
            _m_RedBackgroundColor,
            _m_TextContainer,
            _m_FrameButtonPrefab,
            _m_MultiButtonFirstFocus,
            _m_MultiButtonSecondFocus,
            _m_NavigationParameters);
    }
}


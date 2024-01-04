namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $TooltipBrickTextConsoleView (17 fields) D62E80D8787D4245188538104B8E3C09/F5C03C997273F91B6F667C270ADBD7A7 */
public record class TooltipBrickTextConsoleView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<TextMeshProUGUI> m_Text /* NeedsAlign */,
    PPtr<GameObject> m_RightDecoration /* None */,
    PPtr<GameObject> m_LeftDecoration /* None */,
    PPtr<LayoutGroup> m_LayoutGroup /* None */,
    ColorRGBA m_DefaultColor /* None */,
    ColorRGBA m_BrightColor /* None */,
    float m_DefaultFontSize /* None */,
    float m_DefaultConsoleFontSize /* None */,
    PPtr<RectTransform> m_TextContainer /* None */,
    PPtr<OwlcatMultiButton> m_FrameButtonPrefab /* None */,
    PPtr<OwlcatMultiButton> m_MultiButtonFirstFocus /* None */,
    PPtr<OwlcatMultiButton> m_MultiButtonSecondFocus /* None */,
    NavigationParameters m_NavigationParameters /* None */)
{
    public static TooltipBrickTextConsoleView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_Text */
        PPtr<TextMeshProUGUI> _m_Text = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<GameObject> _m_RightDecoration = PPtr<GameObject>.Read(reader);
        PPtr<GameObject> _m_LeftDecoration = PPtr<GameObject>.Read(reader);
        PPtr<LayoutGroup> _m_LayoutGroup = PPtr<LayoutGroup>.Read(reader);
        ColorRGBA _m_DefaultColor = ColorRGBA.Read(reader);
        ColorRGBA _m_BrightColor = ColorRGBA.Read(reader);
        float _m_DefaultFontSize = reader.ReadF32();
        float _m_DefaultConsoleFontSize = reader.ReadF32();
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
            _m_RightDecoration,
            _m_LeftDecoration,
            _m_LayoutGroup,
            _m_DefaultColor,
            _m_BrightColor,
            _m_DefaultFontSize,
            _m_DefaultConsoleFontSize,
            _m_TextContainer,
            _m_FrameButtonPrefab,
            _m_MultiButtonFirstFocus,
            _m_MultiButtonSecondFocus,
            _m_NavigationParameters);
    }
}


namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $TooltipBrickIconPatternConsoleView (21 fields) 6C6672E79F128B05F75C5BD2D159D7D0/4A37F50F36EAFD59FAA2442D665D20C4 */
public record class TooltipBrickIconPatternConsoleView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<Image> m_Icon /* NeedsAlign */,
    PPtr<Image> m_Frame /* None */,
    PPtr<GameObject> m_IconBlock /* None */,
    PPtr<AbilityPatternView> m_AbilityPatternView /* None */,
    PPtr<TextMeshProUGUI> m_TitleText /* None */,
    PPtr<TextMeshProUGUI> m_SecondaryText /* None */,
    PPtr<TextMeshProUGUI> m_SecondaryValue /* None */,
    PPtr<TextMeshProUGUI> m_TertiaryText /* None */,
    PPtr<TextMeshProUGUI> m_TertiaryValue /* None */,
    float m_DefaultFontSizeTitle /* None */,
    float m_DefaultFontSize /* None */,
    float m_DefaultConsoleFontSizeTitle /* None */,
    float m_DefaultConsoleFontSize /* None */,
    PPtr<OwlcatMultiButton> m_FrameButton /* None */,
    PPtr<OwlcatMultiButton> m_MultiButtonFirstFocus /* None */,
    PPtr<OwlcatMultiButton> m_MultiButtonSecondFocus /* None */,
    NavigationParameters m_NavigationParameters /* None */)
{
    public static TooltipBrickIconPatternConsoleView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_Icon */
        PPtr<Image> _m_Icon = PPtr<Image>.Read(reader);
        PPtr<Image> _m_Frame = PPtr<Image>.Read(reader);
        PPtr<GameObject> _m_IconBlock = PPtr<GameObject>.Read(reader);
        PPtr<AbilityPatternView> _m_AbilityPatternView = PPtr<AbilityPatternView>.Read(reader);
        PPtr<TextMeshProUGUI> _m_TitleText = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<TextMeshProUGUI> _m_SecondaryText = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<TextMeshProUGUI> _m_SecondaryValue = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<TextMeshProUGUI> _m_TertiaryText = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<TextMeshProUGUI> _m_TertiaryValue = PPtr<TextMeshProUGUI>.Read(reader);
        float _m_DefaultFontSizeTitle = reader.ReadF32();
        float _m_DefaultFontSize = reader.ReadF32();
        float _m_DefaultConsoleFontSizeTitle = reader.ReadF32();
        float _m_DefaultConsoleFontSize = reader.ReadF32();
        PPtr<OwlcatMultiButton> _m_FrameButton = PPtr<OwlcatMultiButton>.Read(reader);
        PPtr<OwlcatMultiButton> _m_MultiButtonFirstFocus = PPtr<OwlcatMultiButton>.Read(reader);
        PPtr<OwlcatMultiButton> _m_MultiButtonSecondFocus = PPtr<OwlcatMultiButton>.Read(reader);
        NavigationParameters _m_NavigationParameters = NavigationParameters.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_Icon,
            _m_Frame,
            _m_IconBlock,
            _m_AbilityPatternView,
            _m_TitleText,
            _m_SecondaryText,
            _m_SecondaryValue,
            _m_TertiaryText,
            _m_TertiaryValue,
            _m_DefaultFontSizeTitle,
            _m_DefaultFontSize,
            _m_DefaultConsoleFontSizeTitle,
            _m_DefaultConsoleFontSize,
            _m_FrameButton,
            _m_MultiButtonFirstFocus,
            _m_MultiButtonSecondFocus,
            _m_NavigationParameters);
    }
}


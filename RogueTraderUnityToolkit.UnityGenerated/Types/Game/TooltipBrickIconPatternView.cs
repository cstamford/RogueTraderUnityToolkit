namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $TooltipBrickIconPatternView (17 fields) 4D0016B7D79A442E9294B923A8C9D4BD/C1A728844A6C7EEB7BD3710E572D1F3F */
public record class TooltipBrickIconPatternView(
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
    float m_DefaultConsoleFontSize /* None */)
{
    public static TooltipBrickIconPatternView Read(EndianBinaryReader reader)
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
            _m_DefaultConsoleFontSize);
    }
}


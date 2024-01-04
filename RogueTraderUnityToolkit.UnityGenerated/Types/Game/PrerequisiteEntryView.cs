namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $PrerequisiteEntryView (16 fields) CAD51C86BEF4EF525EB79EF308101188/EA8336A269541113CA9CBFCD0C36A94D */
public record class PrerequisiteEntryView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<TextMeshProUGUI> m_Text /* NeedsAlign */,
    PPtr<TextMeshProUGUI> m_Value /* None */,
    PPtr<Image> m_Background /* None */,
    PPtr<OwlcatMultiButton> m_Focus /* None */,
    ColorRGBA m_DoneBGColor /* None */,
    ColorRGBA m_RequiredBGColor /* None */,
    ColorRGBA m_DoneTextColor /* None */,
    ColorRGBA m_RequiredTextColor /* None */,
    float m_DefaultFontSizeText /* None */,
    float m_DefaultFontSizeValue /* None */,
    float m_DefaultConsoleFontSizeText /* None */,
    float m_DefaultConsoleFontSizeValue /* None */)
{
    public static PrerequisiteEntryView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_Text */
        PPtr<TextMeshProUGUI> _m_Text = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<TextMeshProUGUI> _m_Value = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<Image> _m_Background = PPtr<Image>.Read(reader);
        PPtr<OwlcatMultiButton> _m_Focus = PPtr<OwlcatMultiButton>.Read(reader);
        ColorRGBA _m_DoneBGColor = ColorRGBA.Read(reader);
        ColorRGBA _m_RequiredBGColor = ColorRGBA.Read(reader);
        ColorRGBA _m_DoneTextColor = ColorRGBA.Read(reader);
        ColorRGBA _m_RequiredTextColor = ColorRGBA.Read(reader);
        float _m_DefaultFontSizeText = reader.ReadF32();
        float _m_DefaultFontSizeValue = reader.ReadF32();
        float _m_DefaultConsoleFontSizeText = reader.ReadF32();
        float _m_DefaultConsoleFontSizeValue = reader.ReadF32();
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_Text,
            _m_Value,
            _m_Background,
            _m_Focus,
            _m_DoneBGColor,
            _m_RequiredBGColor,
            _m_DoneTextColor,
            _m_RequiredTextColor,
            _m_DefaultFontSizeText,
            _m_DefaultFontSizeValue,
            _m_DefaultConsoleFontSizeText,
            _m_DefaultConsoleFontSizeValue);
    }
}


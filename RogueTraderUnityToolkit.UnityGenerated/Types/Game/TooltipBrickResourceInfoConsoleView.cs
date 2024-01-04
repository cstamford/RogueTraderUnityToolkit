namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $TooltipBrickResourceInfoConsoleView (12 fields) 7BE6600EEDDAA3824084FC2E5F807C7E/A5A970DF8655B599BE05CCDB45BDABC7 */
public record class TooltipBrickResourceInfoConsoleView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<TextMeshProUGUI> m_Text /* NeedsAlign */,
    PPtr<Image> m_Image /* None */,
    PPtr<TextMeshProUGUI> m_Count /* None */,
    float m_DefaultFontSizeText /* None */,
    float m_DefaultFontSizeCount /* None */,
    float m_DefaultConsoleFontSizeText /* None */,
    float m_DefaultConsoleFontSizeCount /* None */,
    PPtr<OwlcatMultiButton> m_MultiButton /* None */)
{
    public static TooltipBrickResourceInfoConsoleView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_Text */
        PPtr<TextMeshProUGUI> _m_Text = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<Image> _m_Image = PPtr<Image>.Read(reader);
        PPtr<TextMeshProUGUI> _m_Count = PPtr<TextMeshProUGUI>.Read(reader);
        float _m_DefaultFontSizeText = reader.ReadF32();
        float _m_DefaultFontSizeCount = reader.ReadF32();
        float _m_DefaultConsoleFontSizeText = reader.ReadF32();
        float _m_DefaultConsoleFontSizeCount = reader.ReadF32();
        PPtr<OwlcatMultiButton> _m_MultiButton = PPtr<OwlcatMultiButton>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_Text,
            _m_Image,
            _m_Count,
            _m_DefaultFontSizeText,
            _m_DefaultFontSizeCount,
            _m_DefaultConsoleFontSizeText,
            _m_DefaultConsoleFontSizeCount,
            _m_MultiButton);
    }
}


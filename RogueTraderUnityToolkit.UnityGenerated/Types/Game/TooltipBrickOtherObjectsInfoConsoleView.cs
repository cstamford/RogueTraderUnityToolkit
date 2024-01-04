namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $TooltipBrickOtherObjectsInfoConsoleView (9 fields) F5D6CD79CC7C3CB01A2DED9AD7D102CC/D5560D50D0A06B3545090DA80DAB59C5 */
public record class TooltipBrickOtherObjectsInfoConsoleView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<TextMeshProUGUI> m_Text /* NeedsAlign */,
    PPtr<Image> m_Image /* None */,
    float m_DefaultFontSize /* None */,
    float m_DefaultConsoleFontSize /* None */,
    PPtr<OwlcatMultiButton> m_MultiButton /* None */)
{
    public static TooltipBrickOtherObjectsInfoConsoleView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_Text */
        PPtr<TextMeshProUGUI> _m_Text = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<Image> _m_Image = PPtr<Image>.Read(reader);
        float _m_DefaultFontSize = reader.ReadF32();
        float _m_DefaultConsoleFontSize = reader.ReadF32();
        PPtr<OwlcatMultiButton> _m_MultiButton = PPtr<OwlcatMultiButton>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_Text,
            _m_Image,
            _m_DefaultFontSize,
            _m_DefaultConsoleFontSize,
            _m_MultiButton);
    }
}


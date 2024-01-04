namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $TooltipBrickFactionStatusConsoleView (12 fields) F5922B6A0A99365AC3B73E6CA541880E/C6913CA54623B9963565F54257874221 */
public record class TooltipBrickFactionStatusConsoleView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<Image> m_Icon /* NeedsAlign */,
    PPtr<TextMeshProUGUI> m_Label /* None */,
    PPtr<TextMeshProUGUI> m_Status /* None */,
    float m_DefaultFontSizeLabel /* None */,
    float m_DefaultFontSizeStatus /* None */,
    float m_DefaultConsoleFontSizeLabel /* None */,
    float m_DefaultConsoleFontSizeStatus /* None */,
    PPtr<OwlcatMultiButton> m_MultiButton /* None */)
{
    public static TooltipBrickFactionStatusConsoleView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_Icon */
        PPtr<Image> _m_Icon = PPtr<Image>.Read(reader);
        PPtr<TextMeshProUGUI> _m_Label = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<TextMeshProUGUI> _m_Status = PPtr<TextMeshProUGUI>.Read(reader);
        float _m_DefaultFontSizeLabel = reader.ReadF32();
        float _m_DefaultFontSizeStatus = reader.ReadF32();
        float _m_DefaultConsoleFontSizeLabel = reader.ReadF32();
        float _m_DefaultConsoleFontSizeStatus = reader.ReadF32();
        PPtr<OwlcatMultiButton> _m_MultiButton = PPtr<OwlcatMultiButton>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_Icon,
            _m_Label,
            _m_Status,
            _m_DefaultFontSizeLabel,
            _m_DefaultFontSizeStatus,
            _m_DefaultConsoleFontSizeLabel,
            _m_DefaultConsoleFontSizeStatus,
            _m_MultiButton);
    }
}


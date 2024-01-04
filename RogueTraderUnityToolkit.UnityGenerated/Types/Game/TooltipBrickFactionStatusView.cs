namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $TooltipBrickFactionStatusView (11 fields) 363EEB381FD89734BCFA04BA8957133C/903681F6754707442C35E0E859C2234A */
public record class TooltipBrickFactionStatusView(
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
    float m_DefaultConsoleFontSizeStatus /* None */)
{
    public static TooltipBrickFactionStatusView Read(EndianBinaryReader reader)
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
            _m_DefaultConsoleFontSizeStatus);
    }
}


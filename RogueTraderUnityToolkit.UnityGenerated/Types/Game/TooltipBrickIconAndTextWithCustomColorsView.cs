namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $TooltipBrickIconAndTextWithCustomColorsView (9 fields) C1512FAA8288971FAE84CFBBBD64A96E/8391B1795849AED2F4BA024A61DE85F3 */
public record class TooltipBrickIconAndTextWithCustomColorsView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<TextMeshProUGUI> m_StringValue /* NeedsAlign */,
    PPtr<Image> m_Icon /* None */,
    PPtr<Image> m_Background /* None */,
    float m_DefaultFontSize /* None */,
    float m_DefaultConsoleFontSize /* None */)
{
    public static TooltipBrickIconAndTextWithCustomColorsView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_StringValue */
        PPtr<TextMeshProUGUI> _m_StringValue = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<Image> _m_Icon = PPtr<Image>.Read(reader);
        PPtr<Image> _m_Background = PPtr<Image>.Read(reader);
        float _m_DefaultFontSize = reader.ReadF32();
        float _m_DefaultConsoleFontSize = reader.ReadF32();
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_StringValue,
            _m_Icon,
            _m_Background,
            _m_DefaultFontSize,
            _m_DefaultConsoleFontSize);
    }
}


namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $TooltipBrickTitleWithIconView (8 fields) 58DA7CF78EC3046AD9EED47311086977/B350F5F5430F7A2C344B19594D79ACC0 */
public record class TooltipBrickTitleWithIconView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<TextMeshProUGUI> m_Label /* NeedsAlign */,
    PPtr<Image> m_Icon /* None */,
    float m_DefaultFontSizeLabel /* None */,
    float m_DefaultConsoleFontSizeLabel /* None */)
{
    public static TooltipBrickTitleWithIconView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_Label */
        PPtr<TextMeshProUGUI> _m_Label = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<Image> _m_Icon = PPtr<Image>.Read(reader);
        float _m_DefaultFontSizeLabel = reader.ReadF32();
        float _m_DefaultConsoleFontSizeLabel = reader.ReadF32();
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_Label,
            _m_Icon,
            _m_DefaultFontSizeLabel,
            _m_DefaultConsoleFontSizeLabel);
    }
}


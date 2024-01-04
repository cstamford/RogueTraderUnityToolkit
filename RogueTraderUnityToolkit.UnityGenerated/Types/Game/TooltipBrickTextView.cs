namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $TooltipBrickTextView (12 fields) 5A080A81E953990ABE92B2166B3D3815/67E18245AB842C939B0ABBB451FDE394 */
public record class TooltipBrickTextView(
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
    float m_DefaultConsoleFontSize /* None */)
{
    public static TooltipBrickTextView Read(EndianBinaryReader reader)
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
            _m_DefaultConsoleFontSize);
    }
}


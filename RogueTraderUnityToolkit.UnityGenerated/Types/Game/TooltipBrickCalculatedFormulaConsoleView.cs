namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $TooltipBrickCalculatedFormulaConsoleView (10 fields) C8211915E04ED7F493FA9A8C77F99926/4C6C29A1044E6970A73F063642328EB3 */
public record class TooltipBrickCalculatedFormulaConsoleView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<TextMeshProUGUI> m_TitleText /* NeedsAlign */,
    PPtr<TextMeshProUGUI> m_DescriptionText /* None */,
    PPtr<TextMeshProUGUI> m_ValueText /* None */,
    PPtr<LayoutElement> m_ValueLayoutElement /* None */,
    float m_FlexibleWidth /* None */,
    PPtr<OwlcatMultiButton> m_MultiButton /* None */)
{
    public static TooltipBrickCalculatedFormulaConsoleView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_TitleText */
        PPtr<TextMeshProUGUI> _m_TitleText = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<TextMeshProUGUI> _m_DescriptionText = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<TextMeshProUGUI> _m_ValueText = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<LayoutElement> _m_ValueLayoutElement = PPtr<LayoutElement>.Read(reader);
        float _m_FlexibleWidth = reader.ReadF32();
        PPtr<OwlcatMultiButton> _m_MultiButton = PPtr<OwlcatMultiButton>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_TitleText,
            _m_DescriptionText,
            _m_ValueText,
            _m_ValueLayoutElement,
            _m_FlexibleWidth,
            _m_MultiButton);
    }
}


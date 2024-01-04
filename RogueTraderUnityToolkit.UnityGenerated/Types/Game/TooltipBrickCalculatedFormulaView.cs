namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $TooltipBrickCalculatedFormulaView (9 fields) 78928BB3433FA93E8CF574119CE1F0C7/7305EFC2B8AE46C6B1EC248B50EDE4AA */
public record class TooltipBrickCalculatedFormulaView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<TextMeshProUGUI> m_TitleText /* NeedsAlign */,
    PPtr<TextMeshProUGUI> m_DescriptionText /* None */,
    PPtr<TextMeshProUGUI> m_ValueText /* None */,
    PPtr<LayoutElement> m_ValueLayoutElement /* None */,
    float m_FlexibleWidth /* None */)
{
    public static TooltipBrickCalculatedFormulaView Read(EndianBinaryReader reader)
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
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_TitleText,
            _m_DescriptionText,
            _m_ValueText,
            _m_ValueLayoutElement,
            _m_FlexibleWidth);
    }
}


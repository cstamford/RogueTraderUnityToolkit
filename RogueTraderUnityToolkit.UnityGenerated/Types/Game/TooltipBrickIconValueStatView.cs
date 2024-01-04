namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $TooltipBrickIconValueStatView (15 fields) 94AB82DEA72C39F0597E00E39839CF2A/B5BFDA6FA232BEB9A5423CC4A5A62FB2 */
public record class TooltipBrickIconValueStatView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<TextMeshProUGUI> m_Label /* NeedsAlign */,
    PPtr<TextMeshProUGUI> m_Value /* None */,
    PPtr<Image> m_Icon /* None */,
    ColorRGBA m_LabelColor /* None */,
    ColorRGBA m_LabelSecondaryColor /* None */,
    ColorRGBA m_ValueColor /* None */,
    int m_NormalSize /* None */,
    int m_SmallSize /* None */,
    PPtr<LayoutElement> m_LayoutElement /* None */,
    PPtr<LayoutElement> m_IconContainer /* None */,
    PPtr<HorizontalLayoutGroup> m_LayoutGroup /* None */)
{
    public static TooltipBrickIconValueStatView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_Label */
        PPtr<TextMeshProUGUI> _m_Label = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<TextMeshProUGUI> _m_Value = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<Image> _m_Icon = PPtr<Image>.Read(reader);
        ColorRGBA _m_LabelColor = ColorRGBA.Read(reader);
        ColorRGBA _m_LabelSecondaryColor = ColorRGBA.Read(reader);
        ColorRGBA _m_ValueColor = ColorRGBA.Read(reader);
        int _m_NormalSize = reader.ReadS32();
        int _m_SmallSize = reader.ReadS32();
        PPtr<LayoutElement> _m_LayoutElement = PPtr<LayoutElement>.Read(reader);
        PPtr<LayoutElement> _m_IconContainer = PPtr<LayoutElement>.Read(reader);
        PPtr<HorizontalLayoutGroup> _m_LayoutGroup = PPtr<HorizontalLayoutGroup>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_Label,
            _m_Value,
            _m_Icon,
            _m_LabelColor,
            _m_LabelSecondaryColor,
            _m_ValueColor,
            _m_NormalSize,
            _m_SmallSize,
            _m_LayoutElement,
            _m_IconContainer,
            _m_LayoutGroup);
    }
}


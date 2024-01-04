namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $TooltipBrickTwoColumnsStatView (16 fields) 638F51E87CC26F0F014D302E443460B7/253F41123935602BC8E61CCE429E083C */
public record class TooltipBrickTwoColumnsStatView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<TextMeshProUGUI> m_LabelLeft /* NeedsAlign */,
    PPtr<TextMeshProUGUI> m_LabelRight /* None */,
    PPtr<TextMeshProUGUI> m_ValueLeft /* None */,
    PPtr<TextMeshProUGUI> m_ValueRight /* None */,
    PPtr<Image> m_IconLeft /* None */,
    PPtr<Image> m_IconRight /* None */,
    PPtr<GameObject> m_IconContainerLeft /* None */,
    PPtr<GameObject> m_IconContainerRight /* None */,
    PPtr<OwlcatMultiSelectable> m_ComparisonLeft /* None */,
    PPtr<OwlcatMultiSelectable> m_ComparisonRight /* None */,
    ColorRGBA m_RegularColor /* None */,
    ColorRGBA m_HighlightColor /* None */)
{
    public static TooltipBrickTwoColumnsStatView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_LabelLeft */
        PPtr<TextMeshProUGUI> _m_LabelLeft = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<TextMeshProUGUI> _m_LabelRight = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<TextMeshProUGUI> _m_ValueLeft = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<TextMeshProUGUI> _m_ValueRight = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<Image> _m_IconLeft = PPtr<Image>.Read(reader);
        PPtr<Image> _m_IconRight = PPtr<Image>.Read(reader);
        PPtr<GameObject> _m_IconContainerLeft = PPtr<GameObject>.Read(reader);
        PPtr<GameObject> _m_IconContainerRight = PPtr<GameObject>.Read(reader);
        PPtr<OwlcatMultiSelectable> _m_ComparisonLeft = PPtr<OwlcatMultiSelectable>.Read(reader);
        PPtr<OwlcatMultiSelectable> _m_ComparisonRight = PPtr<OwlcatMultiSelectable>.Read(reader);
        ColorRGBA _m_RegularColor = ColorRGBA.Read(reader);
        ColorRGBA _m_HighlightColor = ColorRGBA.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_LabelLeft,
            _m_LabelRight,
            _m_ValueLeft,
            _m_ValueRight,
            _m_IconLeft,
            _m_IconRight,
            _m_IconContainerLeft,
            _m_IconContainerRight,
            _m_ComparisonLeft,
            _m_ComparisonRight,
            _m_RegularColor,
            _m_HighlightColor);
    }
}


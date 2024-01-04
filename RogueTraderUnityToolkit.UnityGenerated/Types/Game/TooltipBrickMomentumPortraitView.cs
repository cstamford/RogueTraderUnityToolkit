namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $TooltipBrickMomentumPortraitView (11 fields) 8E9BAC3406DF381EF1A5D069834E6326/FA8E28A3091717E0787A0250F2C25AC4 */
public record class TooltipBrickMomentumPortraitView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<Image> m_Icon /* NeedsAlign */,
    PPtr<_2dxFX_GrayScale> m_GrayScale /* None */,
    PPtr<TextMeshProUGUI> m_Text /* None */,
    AsciiString m_EnableText /* None */,
    AsciiString m_DisableText /* NeedsAlign */,
    ColorRGBA m_EnableTextColor /* NeedsAlign */,
    ColorRGBA m_DisableTextColor /* None */)
{
    public static TooltipBrickMomentumPortraitView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_Icon */
        PPtr<Image> _m_Icon = PPtr<Image>.Read(reader);
        PPtr<_2dxFX_GrayScale> _m_GrayScale = PPtr<_2dxFX_GrayScale>.Read(reader);
        PPtr<TextMeshProUGUI> _m_Text = PPtr<TextMeshProUGUI>.Read(reader);
        AsciiString _m_EnableText = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_DisableText */
        AsciiString _m_DisableText = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_EnableTextColor */
        ColorRGBA _m_EnableTextColor = ColorRGBA.Read(reader);
        ColorRGBA _m_DisableTextColor = ColorRGBA.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_Icon,
            _m_GrayScale,
            _m_Text,
            _m_EnableText,
            _m_DisableText,
            _m_EnableTextColor,
            _m_DisableTextColor);
    }
}


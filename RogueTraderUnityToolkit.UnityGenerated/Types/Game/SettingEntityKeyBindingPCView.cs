namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $SettingEntityKeyBindingPCView (17 fields) 2A37D3F7B37563C3F104029AFE069C62/0E05B20BE7B9F4270EB53A5574176EEB */
public record class SettingEntityKeyBindingPCView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<GameObject> m_SetConnector /* NeedsAlign */,
    PPtr<GameObject> m_SetConnectorIAmSet /* None */,
    PPtr<TextMeshProUGUI> m_Title /* None */,
    PPtr<Image> m_HighlightedImage /* None */,
    ColorRGBA NormalColor /* None */,
    ColorRGBA OddColor /* None */,
    ColorRGBA HighlightedColor /* None */,
    PPtr<Image> m_PointImage /* None */,
    PPtr<Image> m_MarkImage /* None */,
    PPtr<OwlcatMultiButton> m_BindingButton1 /* None */,
    PPtr<OwlcatMultiButton> m_BindingButton2 /* None */,
    PPtr<TextMeshProUGUI> m_BindingText1 /* None */,
    PPtr<TextMeshProUGUI> m_BindingText2 /* None */)
{
    public static SettingEntityKeyBindingPCView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_SetConnector */
        PPtr<GameObject> _m_SetConnector = PPtr<GameObject>.Read(reader);
        PPtr<GameObject> _m_SetConnectorIAmSet = PPtr<GameObject>.Read(reader);
        PPtr<TextMeshProUGUI> _m_Title = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<Image> _m_HighlightedImage = PPtr<Image>.Read(reader);
        ColorRGBA _NormalColor = ColorRGBA.Read(reader);
        ColorRGBA _OddColor = ColorRGBA.Read(reader);
        ColorRGBA _HighlightedColor = ColorRGBA.Read(reader);
        PPtr<Image> _m_PointImage = PPtr<Image>.Read(reader);
        PPtr<Image> _m_MarkImage = PPtr<Image>.Read(reader);
        PPtr<OwlcatMultiButton> _m_BindingButton1 = PPtr<OwlcatMultiButton>.Read(reader);
        PPtr<OwlcatMultiButton> _m_BindingButton2 = PPtr<OwlcatMultiButton>.Read(reader);
        PPtr<TextMeshProUGUI> _m_BindingText1 = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<TextMeshProUGUI> _m_BindingText2 = PPtr<TextMeshProUGUI>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_SetConnector,
            _m_SetConnectorIAmSet,
            _m_Title,
            _m_HighlightedImage,
            _NormalColor,
            _OddColor,
            _HighlightedColor,
            _m_PointImage,
            _m_MarkImage,
            _m_BindingButton1,
            _m_BindingButton2,
            _m_BindingText1,
            _m_BindingText2);
    }
}


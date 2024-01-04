namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $SettingsEntityDropdownGameDifficultyConsoleView (17 fields) 255229936D1074A22FA96E1F19EFC11E/3EA6E3E9D3FA51D4DDDEC3133C458B2D */
public record class SettingsEntityDropdownGameDifficultyConsoleView(
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
    VirtualListLayoutElementSettings m_LayoutSettings /* None */,
    VirtualListLayoutElementSettings m_LayoutElementSettings /* NeedsAlign */,
    PPtr<SettingsEntityDropdownGameDifficultyItemConsoleView>[] m_ItemViews /* NeedsAlign */,
    PPtr<OwlcatMultiButton> m_FocusMultiButton /* None */)
{
    public static SettingsEntityDropdownGameDifficultyConsoleView Read(EndianBinaryReader reader)
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
        VirtualListLayoutElementSettings _m_LayoutSettings = VirtualListLayoutElementSettings.Read(reader);
        reader.AlignTo(4); /* m_LayoutElementSettings */
        VirtualListLayoutElementSettings _m_LayoutElementSettings = VirtualListLayoutElementSettings.Read(reader);
        reader.AlignTo(4); /* m_ItemViews */
        PPtr<SettingsEntityDropdownGameDifficultyItemConsoleView>[] _m_ItemViews = BuiltInArray<PPtr<SettingsEntityDropdownGameDifficultyItemConsoleView>>.Read(reader);
        PPtr<OwlcatMultiButton> _m_FocusMultiButton = PPtr<OwlcatMultiButton>.Read(reader);
        
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
            _m_LayoutSettings,
            _m_LayoutElementSettings,
            _m_ItemViews,
            _m_FocusMultiButton);
    }
}


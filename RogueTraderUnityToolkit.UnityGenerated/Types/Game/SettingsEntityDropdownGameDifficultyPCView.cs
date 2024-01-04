namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $SettingsEntityDropdownGameDifficultyPCView (16 fields) CCECAD5060AA6CCA32F0078E1268A383/DCA34E90C5B6A08C45D678014A7E8FA0 */
public record class SettingsEntityDropdownGameDifficultyPCView(
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
    PPtr<SettingsEntityDropdownGameDifficultyItemPCView>[] m_ItemViews /* None */,
    PPtr<OwlcatMultiSelectable> m_Selectable /* None */,
    VirtualListLayoutElementSettings m_LayoutElementSettings /* None */)
{
    public static SettingsEntityDropdownGameDifficultyPCView Read(EndianBinaryReader reader)
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
        PPtr<SettingsEntityDropdownGameDifficultyItemPCView>[] _m_ItemViews = BuiltInArray<PPtr<SettingsEntityDropdownGameDifficultyItemPCView>>.Read(reader);
        PPtr<OwlcatMultiSelectable> _m_Selectable = PPtr<OwlcatMultiSelectable>.Read(reader);
        VirtualListLayoutElementSettings _m_LayoutElementSettings = VirtualListLayoutElementSettings.Read(reader);
        
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
            _m_ItemViews,
            _m_Selectable,
            _m_LayoutElementSettings);
    }
}


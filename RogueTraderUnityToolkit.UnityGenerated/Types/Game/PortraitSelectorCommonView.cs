namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $PortraitSelectorCommonView (19 fields) 5EE60215BEE440EDDA611DBE942EAEC8/39A63BFB8DE5C8DAED78732C6E237ADE */
public record class PortraitSelectorCommonView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<OwlcatMultiSelectable> m_Selectable /* NeedsAlign */,
    PPtr<CharGenPortraitTabSelectorView> m_TabSelector /* None */,
    PPtr<WidgetListMVVM> m_WidgetListDefaultGroups /* None */,
    PPtr<CharGenDefaultPortraitGroupView> m_DefaultGroupPrefab /* None */,
    PPtr<CharGenCustomPortraitGroupView> m_CustomPortraitGroup /* None */,
    PPtr<CharGenCustomPortraitCreatorView> m_CustomPortraitCreatorView /* None */,
    PPtr<ScrollRectExtended> m_ScrollRectExtended /* None */,
    PPtr<GameObject> m_PortraitSelectorContainer /* None */,
    PPtr<GameObject> m_DefaultPortraitsContainer /* None */,
    PPtr<GameObject> m_CustomPortraitsContainer /* None */,
    PPtr<GameObject> m_CustomPortraitsInfoContainer /* None */,
    PPtr<OwlcatButton> m_ChangePortraitButton /* None */,
    PPtr<TextMeshProUGUI> m_ChangePortraitLabel /* None */,
    PPtr<TextMeshProUGUI> m_ChangePortraitDescription /* None */,
    VirtualListLayoutElementSettings m_LayoutSettings /* None */)
{
    public static PortraitSelectorCommonView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_Selectable */
        PPtr<OwlcatMultiSelectable> _m_Selectable = PPtr<OwlcatMultiSelectable>.Read(reader);
        PPtr<CharGenPortraitTabSelectorView> _m_TabSelector = PPtr<CharGenPortraitTabSelectorView>.Read(reader);
        PPtr<WidgetListMVVM> _m_WidgetListDefaultGroups = PPtr<WidgetListMVVM>.Read(reader);
        PPtr<CharGenDefaultPortraitGroupView> _m_DefaultGroupPrefab = PPtr<CharGenDefaultPortraitGroupView>.Read(reader);
        PPtr<CharGenCustomPortraitGroupView> _m_CustomPortraitGroup = PPtr<CharGenCustomPortraitGroupView>.Read(reader);
        PPtr<CharGenCustomPortraitCreatorView> _m_CustomPortraitCreatorView = PPtr<CharGenCustomPortraitCreatorView>.Read(reader);
        PPtr<ScrollRectExtended> _m_ScrollRectExtended = PPtr<ScrollRectExtended>.Read(reader);
        PPtr<GameObject> _m_PortraitSelectorContainer = PPtr<GameObject>.Read(reader);
        PPtr<GameObject> _m_DefaultPortraitsContainer = PPtr<GameObject>.Read(reader);
        PPtr<GameObject> _m_CustomPortraitsContainer = PPtr<GameObject>.Read(reader);
        PPtr<GameObject> _m_CustomPortraitsInfoContainer = PPtr<GameObject>.Read(reader);
        PPtr<OwlcatButton> _m_ChangePortraitButton = PPtr<OwlcatButton>.Read(reader);
        PPtr<TextMeshProUGUI> _m_ChangePortraitLabel = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<TextMeshProUGUI> _m_ChangePortraitDescription = PPtr<TextMeshProUGUI>.Read(reader);
        VirtualListLayoutElementSettings _m_LayoutSettings = VirtualListLayoutElementSettings.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_Selectable,
            _m_TabSelector,
            _m_WidgetListDefaultGroups,
            _m_DefaultGroupPrefab,
            _m_CustomPortraitGroup,
            _m_CustomPortraitCreatorView,
            _m_ScrollRectExtended,
            _m_PortraitSelectorContainer,
            _m_DefaultPortraitsContainer,
            _m_CustomPortraitsContainer,
            _m_CustomPortraitsInfoContainer,
            _m_ChangePortraitButton,
            _m_ChangePortraitLabel,
            _m_ChangePortraitDescription,
            _m_LayoutSettings);
    }
}


namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $ShipSelectorWindowPCView (18 fields) 7ACC433697662EB6C9DE98DC32FF8C37/9FF2D519B94159159032A54ACB11A802 */
public record class ShipSelectorWindowPCView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<FadeAnimator> m_FadeAnimator /* NeedsAlign */,
    PPtr<TextMeshProUGUI> m_Header /* None */,
    PPtr<VirtualListComponent> m_VirtualList /* None */,
    PPtr<ShipComponentItemSlotPCView> m_SlotPrefab /* None */,
    PPtr<InfoSectionView> m_InfoSectionView /* None */,
    PPtr<CanvasSortingComponent> m_SortingComponent /* None */,
    PPtr<OwlcatButton> m_Button /* None */,
    PPtr<OwlcatButton> m_InfoButton /* None */,
    PPtr<TextMeshProUGUI> m_InfoButtonText /* None */,
    PPtr<OwlcatButton> m_ConfirmButton /* None */,
    PPtr<TextMeshProUGUI> m_ConfirmButtonText /* None */,
    PPtr<OwlcatButton> m_UnequipButton /* None */,
    PPtr<TextMeshProUGUI> m_UnequipButtonText /* None */,
    PPtr<GameObject> m_Background /* None */)
{
    public static ShipSelectorWindowPCView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_FadeAnimator */
        PPtr<FadeAnimator> _m_FadeAnimator = PPtr<FadeAnimator>.Read(reader);
        PPtr<TextMeshProUGUI> _m_Header = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<VirtualListComponent> _m_VirtualList = PPtr<VirtualListComponent>.Read(reader);
        PPtr<ShipComponentItemSlotPCView> _m_SlotPrefab = PPtr<ShipComponentItemSlotPCView>.Read(reader);
        PPtr<InfoSectionView> _m_InfoSectionView = PPtr<InfoSectionView>.Read(reader);
        PPtr<CanvasSortingComponent> _m_SortingComponent = PPtr<CanvasSortingComponent>.Read(reader);
        PPtr<OwlcatButton> _m_Button = PPtr<OwlcatButton>.Read(reader);
        PPtr<OwlcatButton> _m_InfoButton = PPtr<OwlcatButton>.Read(reader);
        PPtr<TextMeshProUGUI> _m_InfoButtonText = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<OwlcatButton> _m_ConfirmButton = PPtr<OwlcatButton>.Read(reader);
        PPtr<TextMeshProUGUI> _m_ConfirmButtonText = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<OwlcatButton> _m_UnequipButton = PPtr<OwlcatButton>.Read(reader);
        PPtr<TextMeshProUGUI> _m_UnequipButtonText = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<GameObject> _m_Background = PPtr<GameObject>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_FadeAnimator,
            _m_Header,
            _m_VirtualList,
            _m_SlotPrefab,
            _m_InfoSectionView,
            _m_SortingComponent,
            _m_Button,
            _m_InfoButton,
            _m_InfoButtonText,
            _m_ConfirmButton,
            _m_ConfirmButtonText,
            _m_UnequipButton,
            _m_UnequipButtonText,
            _m_Background);
    }
}


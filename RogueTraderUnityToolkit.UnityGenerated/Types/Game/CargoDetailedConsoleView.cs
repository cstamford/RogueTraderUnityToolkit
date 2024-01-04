namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $CargoDetailedConsoleView (19 fields) 1A4F27DEA6AD0EC25DC36D72A745F4E4/801533CF01D76EA94E939DE87ED47648 */
public record class CargoDetailedConsoleView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<Image> m_TypeIcon /* NeedsAlign */,
    PPtr<Transform> m_Content /* None */,
    PPtr<TextMeshProUGUI> m_TypeLabel /* None */,
    PPtr<Image> m_TooltipPlace /* None */,
    PPtr<ItemSlotsGroupView> m_ItemSlotsGroup /* None */,
    PPtr<InventorySlotView> m_InventorySlotPrefab /* None */,
    PPtr<TextMeshProUGUI> m_TotalFillValue /* None */,
    PPtr<TextMeshProUGUI> m_UnusableFillValue /* None */,
    PPtr<Image> m_UsableFillBar /* None */,
    PPtr<Image> m_UnusableFillBar /* None */,
    PPtr<OwlcatButton> m_BackButton /* None */,
    PPtr<FadeAnimator> m_FadeAnimator /* None */,
    VirtualListLayoutElementSettings m_LayoutSettings /* None */,
    PPtr<CanvasGroup> m_BlinkCanvas /* NeedsAlign */,
    ReactiveProperty_1 Selected /* None */)
{
    public static CargoDetailedConsoleView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_TypeIcon */
        PPtr<Image> _m_TypeIcon = PPtr<Image>.Read(reader);
        PPtr<Transform> _m_Content = PPtr<Transform>.Read(reader);
        PPtr<TextMeshProUGUI> _m_TypeLabel = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<Image> _m_TooltipPlace = PPtr<Image>.Read(reader);
        PPtr<ItemSlotsGroupView> _m_ItemSlotsGroup = PPtr<ItemSlotsGroupView>.Read(reader);
        PPtr<InventorySlotView> _m_InventorySlotPrefab = PPtr<InventorySlotView>.Read(reader);
        PPtr<TextMeshProUGUI> _m_TotalFillValue = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<TextMeshProUGUI> _m_UnusableFillValue = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<Image> _m_UsableFillBar = PPtr<Image>.Read(reader);
        PPtr<Image> _m_UnusableFillBar = PPtr<Image>.Read(reader);
        PPtr<OwlcatButton> _m_BackButton = PPtr<OwlcatButton>.Read(reader);
        PPtr<FadeAnimator> _m_FadeAnimator = PPtr<FadeAnimator>.Read(reader);
        VirtualListLayoutElementSettings _m_LayoutSettings = VirtualListLayoutElementSettings.Read(reader);
        reader.AlignTo(4); /* m_BlinkCanvas */
        PPtr<CanvasGroup> _m_BlinkCanvas = PPtr<CanvasGroup>.Read(reader);
        ReactiveProperty_1 _Selected = default! /* ?ReactiveProperty`1 */;
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_TypeIcon,
            _m_Content,
            _m_TypeLabel,
            _m_TooltipPlace,
            _m_ItemSlotsGroup,
            _m_InventorySlotPrefab,
            _m_TotalFillValue,
            _m_UnusableFillValue,
            _m_UsableFillBar,
            _m_UnusableFillBar,
            _m_BackButton,
            _m_FadeAnimator,
            _m_LayoutSettings,
            _m_BlinkCanvas,
            _Selected);
    }
}


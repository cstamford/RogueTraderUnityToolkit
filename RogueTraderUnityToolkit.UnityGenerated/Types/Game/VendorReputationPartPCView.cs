namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $VendorReputationPartPCView (26 fields) 95ED825A5BD5FEEDEE7003254FD5FD28/5226E0F8B469292F4AFB11105072A9A7 */
public record class VendorReputationPartPCView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<FadeAnimator> m_FadeAnimator /* NeedsAlign */,
    PPtr<InventoryCargoPCView> m_InventoryCargoPCView /* None */,
    PPtr<TextMeshProUGUI> m_DemandCargo /* None */,
    PPtr<TextMeshProUGUI> m_ReputationValues /* None */,
    PPtr<TextMeshProUGUI> m_ReputationHeader /* None */,
    PPtr<TextMeshProUGUI> m_VendorReputationLevelInCircle /* None */,
    PPtr<TextMeshProUGUI> FractionName /* None */,
    PPtr<VendorReputationForItemWindowPCView> m_ReputationForItemWindowPCView /* None */,
    PPtr<Image> m_VendorReputationProgressToNextLevel /* None */,
    PPtr<FlexibleLensSelectorView> m_SelectorView /* None */,
    PPtr<TextMeshProUGUI> m_ExchangeValue /* None */,
    PPtr<OwlcatToggle> m_ShowUnrelevantToggle /* None */,
    PPtr<TextMeshProUGUI> m_ShowUnrelevantLabel /* None */,
    PPtr<OwlcatButton> SellButton /* None */,
    PPtr<TextMeshProUGUI> m_SellButtonText /* None */,
    PPtr<CanvasGroup> m_VendorReputationBlock /* None */,
    PPtr<OwlcatButton> m_SelectAllButton /* None */,
    PPtr<TextMeshProUGUI> m_SelectAllButtonText /* None */,
    PPtr<OwlcatButton> m_UnselectAllButton /* None */,
    PPtr<TextMeshProUGUI> m_UnselectButtonText /* None */,
    PPtr<OwlcatMultiButton> m_CargoButton /* None */,
    PPtr<OwlcatMultiButton> m_ListButton /* None */)
{
    public static VendorReputationPartPCView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_FadeAnimator */
        PPtr<FadeAnimator> _m_FadeAnimator = PPtr<FadeAnimator>.Read(reader);
        PPtr<InventoryCargoPCView> _m_InventoryCargoPCView = PPtr<InventoryCargoPCView>.Read(reader);
        PPtr<TextMeshProUGUI> _m_DemandCargo = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<TextMeshProUGUI> _m_ReputationValues = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<TextMeshProUGUI> _m_ReputationHeader = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<TextMeshProUGUI> _m_VendorReputationLevelInCircle = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<TextMeshProUGUI> _FractionName = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<VendorReputationForItemWindowPCView> _m_ReputationForItemWindowPCView = PPtr<VendorReputationForItemWindowPCView>.Read(reader);
        PPtr<Image> _m_VendorReputationProgressToNextLevel = PPtr<Image>.Read(reader);
        PPtr<FlexibleLensSelectorView> _m_SelectorView = PPtr<FlexibleLensSelectorView>.Read(reader);
        PPtr<TextMeshProUGUI> _m_ExchangeValue = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<OwlcatToggle> _m_ShowUnrelevantToggle = PPtr<OwlcatToggle>.Read(reader);
        PPtr<TextMeshProUGUI> _m_ShowUnrelevantLabel = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<OwlcatButton> _SellButton = PPtr<OwlcatButton>.Read(reader);
        PPtr<TextMeshProUGUI> _m_SellButtonText = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<CanvasGroup> _m_VendorReputationBlock = PPtr<CanvasGroup>.Read(reader);
        PPtr<OwlcatButton> _m_SelectAllButton = PPtr<OwlcatButton>.Read(reader);
        PPtr<TextMeshProUGUI> _m_SelectAllButtonText = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<OwlcatButton> _m_UnselectAllButton = PPtr<OwlcatButton>.Read(reader);
        PPtr<TextMeshProUGUI> _m_UnselectButtonText = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<OwlcatMultiButton> _m_CargoButton = PPtr<OwlcatMultiButton>.Read(reader);
        PPtr<OwlcatMultiButton> _m_ListButton = PPtr<OwlcatMultiButton>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_FadeAnimator,
            _m_InventoryCargoPCView,
            _m_DemandCargo,
            _m_ReputationValues,
            _m_ReputationHeader,
            _m_VendorReputationLevelInCircle,
            _FractionName,
            _m_ReputationForItemWindowPCView,
            _m_VendorReputationProgressToNextLevel,
            _m_SelectorView,
            _m_ExchangeValue,
            _m_ShowUnrelevantToggle,
            _m_ShowUnrelevantLabel,
            _SellButton,
            _m_SellButtonText,
            _m_VendorReputationBlock,
            _m_SelectAllButton,
            _m_SelectAllButtonText,
            _m_UnselectAllButton,
            _m_UnselectButtonText,
            _m_CargoButton,
            _m_ListButton);
    }
}


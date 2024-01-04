namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $VendorReputationPartConsoleView (26 fields) 7EDFDE4BBFA77619666DE37F19D1852E/BDA2DE88D25BC7BDCCD1F395DE5AC9B0 */
public record class VendorReputationPartConsoleView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<FadeAnimator> m_FadeAnimator /* NeedsAlign */,
    PPtr<InventoryCargoConsoleView> m_InventoryCargoPCView /* None */,
    PPtr<TextMeshProUGUI> m_DemandCargo /* None */,
    PPtr<TextMeshProUGUI> m_ReputationValues /* None */,
    PPtr<TextMeshProUGUI> m_ReputationHeader /* None */,
    PPtr<TextMeshProUGUI> m_VendorReputationLevelInCircle /* None */,
    PPtr<TextMeshProUGUI> FractionName /* None */,
    PPtr<VendorReputationForItemWindowConsoleView> m_ReputationForItemWindowPCView /* None */,
    PPtr<Image> m_VendorReputationProgressToNextLevel /* None */,
    PPtr<FlexibleLensSelectorView> m_SelectorView /* None */,
    PPtr<TextMeshProUGUI> m_ExchangeValue /* None */,
    PPtr<OwlcatToggle> m_ShowUnrelevantToggle /* None */,
    PPtr<TextMeshProUGUI> m_ShowUnrelevantLabel /* None */,
    PPtr<OwlcatButton> SellButton /* None */,
    PPtr<TextMeshProUGUI> m_SellButtonText /* None */,
    PPtr<CanvasGroup> m_VendorReputationBlock /* None */,
    PPtr<ConsoleHint> m_SellHint /* None */,
    PPtr<ConsoleHint> m_ShowUnrelevantHint /* None */,
    PPtr<ConsoleHint> m_SelectMenuHint /* None */,
    PPtr<TextMeshProUGUI> m_SelectMenuText /* None */,
    PPtr<Image> m_ContextMenuPlace /* None */,
    PPtr<GameObject> m_ReputationPartTabsBlock /* None */)
{
    public static VendorReputationPartConsoleView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_FadeAnimator */
        PPtr<FadeAnimator> _m_FadeAnimator = PPtr<FadeAnimator>.Read(reader);
        PPtr<InventoryCargoConsoleView> _m_InventoryCargoPCView = PPtr<InventoryCargoConsoleView>.Read(reader);
        PPtr<TextMeshProUGUI> _m_DemandCargo = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<TextMeshProUGUI> _m_ReputationValues = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<TextMeshProUGUI> _m_ReputationHeader = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<TextMeshProUGUI> _m_VendorReputationLevelInCircle = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<TextMeshProUGUI> _FractionName = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<VendorReputationForItemWindowConsoleView> _m_ReputationForItemWindowPCView = PPtr<VendorReputationForItemWindowConsoleView>.Read(reader);
        PPtr<Image> _m_VendorReputationProgressToNextLevel = PPtr<Image>.Read(reader);
        PPtr<FlexibleLensSelectorView> _m_SelectorView = PPtr<FlexibleLensSelectorView>.Read(reader);
        PPtr<TextMeshProUGUI> _m_ExchangeValue = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<OwlcatToggle> _m_ShowUnrelevantToggle = PPtr<OwlcatToggle>.Read(reader);
        PPtr<TextMeshProUGUI> _m_ShowUnrelevantLabel = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<OwlcatButton> _SellButton = PPtr<OwlcatButton>.Read(reader);
        PPtr<TextMeshProUGUI> _m_SellButtonText = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<CanvasGroup> _m_VendorReputationBlock = PPtr<CanvasGroup>.Read(reader);
        PPtr<ConsoleHint> _m_SellHint = PPtr<ConsoleHint>.Read(reader);
        PPtr<ConsoleHint> _m_ShowUnrelevantHint = PPtr<ConsoleHint>.Read(reader);
        PPtr<ConsoleHint> _m_SelectMenuHint = PPtr<ConsoleHint>.Read(reader);
        PPtr<TextMeshProUGUI> _m_SelectMenuText = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<Image> _m_ContextMenuPlace = PPtr<Image>.Read(reader);
        PPtr<GameObject> _m_ReputationPartTabsBlock = PPtr<GameObject>.Read(reader);
        
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
            _m_SellHint,
            _m_ShowUnrelevantHint,
            _m_SelectMenuHint,
            _m_SelectMenuText,
            _m_ContextMenuPlace,
            _m_ReputationPartTabsBlock);
    }
}


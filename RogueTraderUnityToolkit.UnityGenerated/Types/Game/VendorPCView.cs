namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $VendorPCView (23 fields) EB46C3397AC9595E50720C82D19D7DA4/E74B680CBAE0A9DE2C260F41DAD5542F */
public record class VendorPCView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<InventoryStashPCView> m_StashView /* NeedsAlign */,
    PPtr<InventoryCargoPCView> m_CargoView /* None */,
    PPtr<VendorTradePartView_3> m_VendorTradePartView /* None */,
    PPtr<VendorReputationPartView_2> m_VendorReputationPartPCView /* None */,
    PPtr<VendorTabNavigationPCView> m_VendorTabNavigation /* None */,
    PPtr<FlexibleLensSelectorView> m_SelectorView /* None */,
    PPtr<OwlcatButton> m_BuyExchangeButton /* None */,
    PPtr<OwlcatButton> m_SellExchangeButton /* None */,
    PPtr<TextMeshProUGUI> m_BuyExchangeButtonLabel /* None */,
    PPtr<TextMeshProUGUI> m_SellExchangeButtonLabel /* None */,
    PPtr<TextMeshProUGUI> m_BuyExchangeLabel /* None */,
    PPtr<TextMeshProUGUI> m_SellExchangeLabel /* None */,
    PPtr<TextMeshProUGUI> m_UnsupportedItemExchangeText /* None */,
    PPtr<TextMeshProUGUI> m_CargoDetailBackBtnLabel /* None */,
    PPtr<TextMeshProUGUI> m_ReputationButtonText /* None */,
    PPtr<TextMeshProUGUI> m_TradeButtonText /* None */,
    PPtr<GameObject> m_BuyCanvas /* None */,
    PPtr<GameObject> m_SellCanvas /* None */,
    PPtr<OwlcatButton> m_CloseButton /* None */)
{
    public static VendorPCView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_StashView */
        PPtr<InventoryStashPCView> _m_StashView = PPtr<InventoryStashPCView>.Read(reader);
        PPtr<InventoryCargoPCView> _m_CargoView = PPtr<InventoryCargoPCView>.Read(reader);
        PPtr<VendorTradePartView_3> _m_VendorTradePartView = PPtr<VendorTradePartView_3>.Read(reader);
        PPtr<VendorReputationPartView_2> _m_VendorReputationPartPCView = PPtr<VendorReputationPartView_2>.Read(reader);
        PPtr<VendorTabNavigationPCView> _m_VendorTabNavigation = PPtr<VendorTabNavigationPCView>.Read(reader);
        PPtr<FlexibleLensSelectorView> _m_SelectorView = PPtr<FlexibleLensSelectorView>.Read(reader);
        PPtr<OwlcatButton> _m_BuyExchangeButton = PPtr<OwlcatButton>.Read(reader);
        PPtr<OwlcatButton> _m_SellExchangeButton = PPtr<OwlcatButton>.Read(reader);
        PPtr<TextMeshProUGUI> _m_BuyExchangeButtonLabel = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<TextMeshProUGUI> _m_SellExchangeButtonLabel = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<TextMeshProUGUI> _m_BuyExchangeLabel = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<TextMeshProUGUI> _m_SellExchangeLabel = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<TextMeshProUGUI> _m_UnsupportedItemExchangeText = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<TextMeshProUGUI> _m_CargoDetailBackBtnLabel = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<TextMeshProUGUI> _m_ReputationButtonText = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<TextMeshProUGUI> _m_TradeButtonText = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<GameObject> _m_BuyCanvas = PPtr<GameObject>.Read(reader);
        PPtr<GameObject> _m_SellCanvas = PPtr<GameObject>.Read(reader);
        PPtr<OwlcatButton> _m_CloseButton = PPtr<OwlcatButton>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_StashView,
            _m_CargoView,
            _m_VendorTradePartView,
            _m_VendorReputationPartPCView,
            _m_VendorTabNavigation,
            _m_SelectorView,
            _m_BuyExchangeButton,
            _m_SellExchangeButton,
            _m_BuyExchangeButtonLabel,
            _m_SellExchangeButtonLabel,
            _m_BuyExchangeLabel,
            _m_SellExchangeLabel,
            _m_UnsupportedItemExchangeText,
            _m_CargoDetailBackBtnLabel,
            _m_ReputationButtonText,
            _m_TradeButtonText,
            _m_BuyCanvas,
            _m_SellCanvas,
            _m_CloseButton);
    }
}


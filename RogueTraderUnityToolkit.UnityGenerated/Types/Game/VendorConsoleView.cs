namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $VendorConsoleView (25 fields) DE5BEF837D523FB87E4CCC5D8E53A23D/600B4B72E1C656EF4AA1A131B68398A9 */
public record class VendorConsoleView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<InventoryStashConsoleView> m_StashView /* NeedsAlign */,
    PPtr<InventoryCargoConsoleView> m_CargoView /* None */,
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
    PPtr<ConsoleHintsWidget> m_HintsWidget /* None */,
    PPtr<ConsoleHint> m_NextWindowHint /* None */,
    PPtr<ConsoleHint> m_PrevWindowHint /* None */)
{
    public static VendorConsoleView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_StashView */
        PPtr<InventoryStashConsoleView> _m_StashView = PPtr<InventoryStashConsoleView>.Read(reader);
        PPtr<InventoryCargoConsoleView> _m_CargoView = PPtr<InventoryCargoConsoleView>.Read(reader);
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
        PPtr<ConsoleHintsWidget> _m_HintsWidget = PPtr<ConsoleHintsWidget>.Read(reader);
        PPtr<ConsoleHint> _m_NextWindowHint = PPtr<ConsoleHint>.Read(reader);
        PPtr<ConsoleHint> _m_PrevWindowHint = PPtr<ConsoleHint>.Read(reader);
        
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
            _m_HintsWidget,
            _m_NextWindowHint,
            _m_PrevWindowHint);
    }
}


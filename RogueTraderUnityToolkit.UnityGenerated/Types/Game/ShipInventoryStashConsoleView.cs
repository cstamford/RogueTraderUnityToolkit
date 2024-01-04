namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $ShipInventoryStashConsoleView (14 fields) 8FDFB3AD30AF1A37B790D7AB556D2BBC/C1D380B724BC710C0F3D5F80FCA0CEB3 */
public record class ShipInventoryStashConsoleView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<GameObject> m_Background /* NeedsAlign */,
    PPtr<TextMeshProUGUI> m_ScrapCounter /* None */,
    PPtr<TextMeshProUGUI> m_ScrapName /* None */,
    PPtr<OwlcatMultiButton> m_CoinsContainer /* None */,
    PPtr<ItemSlotsGroupView> m_ItemSlotsGroup /* None */,
    PPtr<InsertableLootSlotsGroupView> m_InsertableSlotsGroup /* None */,
    PPtr<ShipItemsFilterPCView> m_ItemsFilter /* None */,
    PPtr<InventorySlotView> m_InventorySlotPrefab /* None */,
    PPtr<InsertableLootSlotView> m_InsertableSlotPrefab /* None */,
    PPtr<CanvasGroup> m_ScrapMark /* None */)
{
    public static ShipInventoryStashConsoleView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_Background */
        PPtr<GameObject> _m_Background = PPtr<GameObject>.Read(reader);
        PPtr<TextMeshProUGUI> _m_ScrapCounter = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<TextMeshProUGUI> _m_ScrapName = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<OwlcatMultiButton> _m_CoinsContainer = PPtr<OwlcatMultiButton>.Read(reader);
        PPtr<ItemSlotsGroupView> _m_ItemSlotsGroup = PPtr<ItemSlotsGroupView>.Read(reader);
        PPtr<InsertableLootSlotsGroupView> _m_InsertableSlotsGroup = PPtr<InsertableLootSlotsGroupView>.Read(reader);
        PPtr<ShipItemsFilterPCView> _m_ItemsFilter = PPtr<ShipItemsFilterPCView>.Read(reader);
        PPtr<InventorySlotView> _m_InventorySlotPrefab = PPtr<InventorySlotView>.Read(reader);
        PPtr<InsertableLootSlotView> _m_InsertableSlotPrefab = PPtr<InsertableLootSlotView>.Read(reader);
        PPtr<CanvasGroup> _m_ScrapMark = PPtr<CanvasGroup>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_Background,
            _m_ScrapCounter,
            _m_ScrapName,
            _m_CoinsContainer,
            _m_ItemSlotsGroup,
            _m_InsertableSlotsGroup,
            _m_ItemsFilter,
            _m_InventorySlotPrefab,
            _m_InsertableSlotPrefab,
            _m_ScrapMark);
    }
}


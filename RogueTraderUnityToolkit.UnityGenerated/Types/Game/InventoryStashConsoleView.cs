namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $InventoryStashConsoleView (11 fields) 8EAE092E7AADC968CCA7EC111F70A15F/3C0169C148534334C6C8AEC278AECD22 */
public record class InventoryStashConsoleView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<GameObject> m_Background /* NeedsAlign */,
    PPtr<TextMeshProUGUI> m_CoinsCounter /* None */,
    PPtr<ItemSlotsGroupView> m_ItemSlotsGroup /* None */,
    PPtr<InsertableLootSlotsGroupView> m_InsertableSlotsGroup /* None */,
    PPtr<ItemsFilterPCView> m_ItemsFilter /* None */,
    PPtr<InventorySlotView> m_InventorySlotPrefab /* None */,
    PPtr<InsertableLootSlotView> m_InsertableSlotPrefab /* None */)
{
    public static InventoryStashConsoleView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_Background */
        PPtr<GameObject> _m_Background = PPtr<GameObject>.Read(reader);
        PPtr<TextMeshProUGUI> _m_CoinsCounter = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<ItemSlotsGroupView> _m_ItemSlotsGroup = PPtr<ItemSlotsGroupView>.Read(reader);
        PPtr<InsertableLootSlotsGroupView> _m_InsertableSlotsGroup = PPtr<InsertableLootSlotsGroupView>.Read(reader);
        PPtr<ItemsFilterPCView> _m_ItemsFilter = PPtr<ItemsFilterPCView>.Read(reader);
        PPtr<InventorySlotView> _m_InventorySlotPrefab = PPtr<InventorySlotView>.Read(reader);
        PPtr<InsertableLootSlotView> _m_InsertableSlotPrefab = PPtr<InsertableLootSlotView>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_Background,
            _m_CoinsCounter,
            _m_ItemSlotsGroup,
            _m_InsertableSlotsGroup,
            _m_ItemsFilter,
            _m_InventorySlotPrefab,
            _m_InsertableSlotPrefab);
    }
}


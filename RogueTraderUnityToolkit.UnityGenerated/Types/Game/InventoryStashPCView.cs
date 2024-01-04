namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $InventoryStashPCView (12 fields) 5DCCE3FC7E731306B182777A102455C2/E1651F73AA5C8498D57540B8149E0A67 */
public record class InventoryStashPCView(
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
    PPtr<InsertableLootSlotView> m_InsertableSlotPrefab /* None */,
    PPtr<InventoryDropZonePCView> m_DropZonePCView /* None */)
{
    public static InventoryStashPCView Read(EndianBinaryReader reader)
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
        PPtr<InventoryDropZonePCView> _m_DropZonePCView = PPtr<InventoryDropZonePCView>.Read(reader);
        
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
            _m_InsertableSlotPrefab,
            _m_DropZonePCView);
    }
}


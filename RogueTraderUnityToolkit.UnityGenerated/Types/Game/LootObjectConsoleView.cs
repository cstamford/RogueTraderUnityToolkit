namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $LootObjectConsoleView (8 fields) 75811F454DFD39DFD1839DF03B1F2CD0/9303AC21ED1131D998B2ABDB81F1951A */
public record class LootObjectConsoleView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<ItemSlotsGroupView> m_SlotsGroup /* NeedsAlign */,
    PPtr<LootSlotView> m_SlotPrefab /* None */,
    PPtr<InventoryDropZonePCView> m_InventoryDropZonePCView /* None */,
    PPtr<CargoDropZonePCView> m_CargoDropZonePCView /* None */)
{
    public static LootObjectConsoleView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_SlotsGroup */
        PPtr<ItemSlotsGroupView> _m_SlotsGroup = PPtr<ItemSlotsGroupView>.Read(reader);
        PPtr<LootSlotView> _m_SlotPrefab = PPtr<LootSlotView>.Read(reader);
        PPtr<InventoryDropZonePCView> _m_InventoryDropZonePCView = PPtr<InventoryDropZonePCView>.Read(reader);
        PPtr<CargoDropZonePCView> _m_CargoDropZonePCView = PPtr<CargoDropZonePCView>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_SlotsGroup,
            _m_SlotPrefab,
            _m_InventoryDropZonePCView,
            _m_CargoDropZonePCView);
    }
}


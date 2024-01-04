namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $InteractionSlotPartConsoleView (8 fields) 2EBB216182A960A04F68BFB5EA658E1E/D0C78DACC840CE6D2861E7471F63D449 */
public record class InteractionSlotPartConsoleView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<TextMeshProUGUI> m_Title /* NeedsAlign */,
    PPtr<TextMeshProUGUI> m_Description /* None */,
    PPtr<LootSlotView> m_SlotView /* None */,
    PPtr<OneSlotLootDropZonePCView> m_OneSlotLootDropZonePCView /* None */)
{
    public static InteractionSlotPartConsoleView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_Title */
        PPtr<TextMeshProUGUI> _m_Title = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<TextMeshProUGUI> _m_Description = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<LootSlotView> _m_SlotView = PPtr<LootSlotView>.Read(reader);
        PPtr<OneSlotLootDropZonePCView> _m_OneSlotLootDropZonePCView = PPtr<OneSlotLootDropZonePCView>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_Title,
            _m_Description,
            _m_SlotView,
            _m_OneSlotLootDropZonePCView);
    }
}


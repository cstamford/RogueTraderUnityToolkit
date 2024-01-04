namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $VendorTransitionWindowConsoleView (12 fields) 90B29B885877D60D70AF93E97F779210/9CE9A89F7DE1FAABA37DCB13C25B1CE7 */
public record class VendorTransitionWindowConsoleView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<TextMeshProUGUI> m_Header /* NeedsAlign */,
    PPtr<ItemSlotsGroupView> m_SlotsGroup /* None */,
    PPtr<LootInventorySlotView> m_SlotPrefab /* None */,
    PPtr<LootInventorySlotView> m_Slot /* None */,
    PPtr<GameObject> m_SliderBlock /* None */,
    PPtr<Slider> m_Slider /* None */,
    PPtr<TextMeshProUGUI> m_SliderText /* None */,
    PPtr<ConsoleHintsWidget> m_HintsWidget /* None */)
{
    public static VendorTransitionWindowConsoleView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_Header */
        PPtr<TextMeshProUGUI> _m_Header = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<ItemSlotsGroupView> _m_SlotsGroup = PPtr<ItemSlotsGroupView>.Read(reader);
        PPtr<LootInventorySlotView> _m_SlotPrefab = PPtr<LootInventorySlotView>.Read(reader);
        PPtr<LootInventorySlotView> _m_Slot = PPtr<LootInventorySlotView>.Read(reader);
        PPtr<GameObject> _m_SliderBlock = PPtr<GameObject>.Read(reader);
        PPtr<Slider> _m_Slider = PPtr<Slider>.Read(reader);
        PPtr<TextMeshProUGUI> _m_SliderText = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<ConsoleHintsWidget> _m_HintsWidget = PPtr<ConsoleHintsWidget>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_Header,
            _m_SlotsGroup,
            _m_SlotPrefab,
            _m_Slot,
            _m_SliderBlock,
            _m_Slider,
            _m_SliderText,
            _m_HintsWidget);
    }
}


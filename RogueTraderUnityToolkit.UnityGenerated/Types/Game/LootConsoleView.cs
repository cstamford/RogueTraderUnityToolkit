namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $LootConsoleView (16 fields) 8CE8E82965E8C05FD1BC17C86906DA8B/B0AC45D2C44CC7C797FA3BDB075FC2FF */
public record class LootConsoleView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<FadeAnimator> m_Animator /* NeedsAlign */,
    PPtr<LootCollectorConsoleView> m_Collector /* None */,
    PPtr<InteractionSlotPartConsoleView> m_InteractionSlot /* None */,
    PPtr<PlayerStashConsoleView> m_PlayerStash /* None */,
    PPtr<InventoryStashConsoleView> m_Inventory /* None */,
    PPtr<InventoryCargoConsoleView> m_Cargo /* None */,
    PPtr<TextMeshProUGUI> m_LeaveZoneButtonText /* None */,
    PPtr<MoveAnimator> m_RightWindow /* None */,
    PPtr<MoveAnimator> m_LeftWindow /* None */,
    PPtr<FlexibleLensSelectorView> m_SelectorView /* None */,
    PPtr<CanvasSortingComponent> m_SortingComponent /* None */,
    PPtr<ConsoleHintsWidget> m_HintsWidget /* None */)
{
    public static LootConsoleView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_Animator */
        PPtr<FadeAnimator> _m_Animator = PPtr<FadeAnimator>.Read(reader);
        PPtr<LootCollectorConsoleView> _m_Collector = PPtr<LootCollectorConsoleView>.Read(reader);
        PPtr<InteractionSlotPartConsoleView> _m_InteractionSlot = PPtr<InteractionSlotPartConsoleView>.Read(reader);
        PPtr<PlayerStashConsoleView> _m_PlayerStash = PPtr<PlayerStashConsoleView>.Read(reader);
        PPtr<InventoryStashConsoleView> _m_Inventory = PPtr<InventoryStashConsoleView>.Read(reader);
        PPtr<InventoryCargoConsoleView> _m_Cargo = PPtr<InventoryCargoConsoleView>.Read(reader);
        PPtr<TextMeshProUGUI> _m_LeaveZoneButtonText = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<MoveAnimator> _m_RightWindow = PPtr<MoveAnimator>.Read(reader);
        PPtr<MoveAnimator> _m_LeftWindow = PPtr<MoveAnimator>.Read(reader);
        PPtr<FlexibleLensSelectorView> _m_SelectorView = PPtr<FlexibleLensSelectorView>.Read(reader);
        PPtr<CanvasSortingComponent> _m_SortingComponent = PPtr<CanvasSortingComponent>.Read(reader);
        PPtr<ConsoleHintsWidget> _m_HintsWidget = PPtr<ConsoleHintsWidget>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_Animator,
            _m_Collector,
            _m_InteractionSlot,
            _m_PlayerStash,
            _m_Inventory,
            _m_Cargo,
            _m_LeaveZoneButtonText,
            _m_RightWindow,
            _m_LeftWindow,
            _m_SelectorView,
            _m_SortingComponent,
            _m_HintsWidget);
    }
}


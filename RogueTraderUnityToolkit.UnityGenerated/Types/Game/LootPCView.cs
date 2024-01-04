namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $LootPCView (20 fields) E6B3CF0380CC12B5AB19A5BA3D587361/2974619E1BF5FDB79EF18EC7D0396246 */
public record class LootPCView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<FadeAnimator> m_Animator /* NeedsAlign */,
    PPtr<LootCollectorPCView> m_Collector /* None */,
    PPtr<InteractionSlotPartPCView> m_InteractionSlot /* None */,
    PPtr<PlayerStashPCView> m_PlayerStash /* None */,
    PPtr<InventoryStashPCView> m_Inventory /* None */,
    PPtr<InventoryCargoPCView> m_Cargo /* None */,
    PPtr<TextMeshProUGUI> m_LeaveZoneButtonText /* None */,
    PPtr<MoveAnimator> m_RightWindow /* None */,
    PPtr<MoveAnimator> m_LeftWindow /* None */,
    PPtr<FlexibleLensSelectorView> m_SelectorView /* None */,
    PPtr<OwlcatButton> m_Close /* None */,
    PPtr<OwlcatButton> m_ExtendedClose /* None */,
    PPtr<OwlcatButton> m_LeaveZoneButton /* None */,
    PPtr<GameObject> m_LeaveZoneButtonBlock /* None */,
    PPtr<OwlcatButton> m_AcceptButton /* None */,
    PPtr<TextMeshProUGUI> m_AcceptButtonText /* None */)
{
    public static LootPCView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_Animator */
        PPtr<FadeAnimator> _m_Animator = PPtr<FadeAnimator>.Read(reader);
        PPtr<LootCollectorPCView> _m_Collector = PPtr<LootCollectorPCView>.Read(reader);
        PPtr<InteractionSlotPartPCView> _m_InteractionSlot = PPtr<InteractionSlotPartPCView>.Read(reader);
        PPtr<PlayerStashPCView> _m_PlayerStash = PPtr<PlayerStashPCView>.Read(reader);
        PPtr<InventoryStashPCView> _m_Inventory = PPtr<InventoryStashPCView>.Read(reader);
        PPtr<InventoryCargoPCView> _m_Cargo = PPtr<InventoryCargoPCView>.Read(reader);
        PPtr<TextMeshProUGUI> _m_LeaveZoneButtonText = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<MoveAnimator> _m_RightWindow = PPtr<MoveAnimator>.Read(reader);
        PPtr<MoveAnimator> _m_LeftWindow = PPtr<MoveAnimator>.Read(reader);
        PPtr<FlexibleLensSelectorView> _m_SelectorView = PPtr<FlexibleLensSelectorView>.Read(reader);
        PPtr<OwlcatButton> _m_Close = PPtr<OwlcatButton>.Read(reader);
        PPtr<OwlcatButton> _m_ExtendedClose = PPtr<OwlcatButton>.Read(reader);
        PPtr<OwlcatButton> _m_LeaveZoneButton = PPtr<OwlcatButton>.Read(reader);
        PPtr<GameObject> _m_LeaveZoneButtonBlock = PPtr<GameObject>.Read(reader);
        PPtr<OwlcatButton> _m_AcceptButton = PPtr<OwlcatButton>.Read(reader);
        PPtr<TextMeshProUGUI> _m_AcceptButtonText = PPtr<TextMeshProUGUI>.Read(reader);
        
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
            _m_Close,
            _m_ExtendedClose,
            _m_LeaveZoneButton,
            _m_LeaveZoneButtonBlock,
            _m_AcceptButton,
            _m_AcceptButtonText);
    }
}


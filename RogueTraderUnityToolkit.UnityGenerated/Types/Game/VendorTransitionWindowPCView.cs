namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $VendorTransitionWindowPCView (15 fields) F025D6A745CE0DB7A73E0546A512F1C9/70775DDAA822891431A59AA54102C9AE */
public record class VendorTransitionWindowPCView(
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
    PPtr<OwlcatButton> m_AcceptButton /* None */,
    PPtr<TextMeshProUGUI> m_AcceptButtonLabel /* None */,
    PPtr<OwlcatButton> m_CancelButton /* None */,
    PPtr<TextMeshProUGUI> m_____ancelButtonLabel /* None */)
{
    public static VendorTransitionWindowPCView Read(EndianBinaryReader reader)
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
        PPtr<OwlcatButton> _m_AcceptButton = PPtr<OwlcatButton>.Read(reader);
        PPtr<TextMeshProUGUI> _m_AcceptButtonLabel = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<OwlcatButton> _m_CancelButton = PPtr<OwlcatButton>.Read(reader);
        PPtr<TextMeshProUGUI> _m_____ancelButtonLabel = PPtr<TextMeshProUGUI>.Read(reader);
        
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
            _m_AcceptButton,
            _m_AcceptButtonLabel,
            _m_CancelButton,
            _m_____ancelButtonLabel);
    }
}


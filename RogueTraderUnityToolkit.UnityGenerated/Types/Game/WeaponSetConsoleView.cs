namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $WeaponSetConsoleView (8 fields) 0C2BE2D3852DEDD492B0CD09E9FC44C3/3C15499A144F2BDC187CB5535E19B33E */
public record class WeaponSetConsoleView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<OwlcatMultiButton> m_Button /* NeedsAlign */,
    PPtr<InventoryEquipSlotView> m_PrimaryHand /* None */,
    PPtr<InventoryEquipSlotView> m_SecondaryHand /* None */,
    PPtr<TextMeshProUGUI>[] m_WeaponSetIndexes /* None */)
{
    public static WeaponSetConsoleView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_Button */
        PPtr<OwlcatMultiButton> _m_Button = PPtr<OwlcatMultiButton>.Read(reader);
        PPtr<InventoryEquipSlotView> _m_PrimaryHand = PPtr<InventoryEquipSlotView>.Read(reader);
        PPtr<InventoryEquipSlotView> _m_SecondaryHand = PPtr<InventoryEquipSlotView>.Read(reader);
        PPtr<TextMeshProUGUI>[] _m_WeaponSetIndexes = BuiltInArray<PPtr<TextMeshProUGUI>>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_Button,
            _m_PrimaryHand,
            _m_SecondaryHand,
            _m_WeaponSetIndexes);
    }
}


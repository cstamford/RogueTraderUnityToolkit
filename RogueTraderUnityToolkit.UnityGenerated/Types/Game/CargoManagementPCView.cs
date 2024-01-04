namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $CargoManagementPCView (7 fields) 37A6FF0A3D343C3F1A69F9C701B5D776/A62E4E28E30707FF60AD5CBDDE3E1BF0 */
public record class CargoManagementPCView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<ShipNameAndPortraitPCView> m_ShipNameAndPortraitPCView /* NeedsAlign */,
    PPtr<InventoryStashPCView> m_StashView /* None */,
    PPtr<InventoryCargoPCView> m_CargoView /* None */)
{
    public static CargoManagementPCView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_ShipNameAndPortraitPCView */
        PPtr<ShipNameAndPortraitPCView> _m_ShipNameAndPortraitPCView = PPtr<ShipNameAndPortraitPCView>.Read(reader);
        PPtr<InventoryStashPCView> _m_StashView = PPtr<InventoryStashPCView>.Read(reader);
        PPtr<InventoryCargoPCView> _m_CargoView = PPtr<InventoryCargoPCView>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_ShipNameAndPortraitPCView,
            _m_StashView,
            _m_CargoView);
    }
}


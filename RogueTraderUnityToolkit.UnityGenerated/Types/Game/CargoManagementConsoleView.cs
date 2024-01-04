namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $CargoManagementConsoleView (9 fields) 91D4F2834E9693E6BE7A8FF45C307BF8/29F00DE36F91FE229F50902826A56AFE */
public record class CargoManagementConsoleView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<ShipNameAndPortraitPCView> m_ShipNameAndPortraitPCView /* NeedsAlign */,
    PPtr<InventoryStashConsoleView> m_StashView /* None */,
    PPtr<InventoryCargoConsoleView> m_CargoView /* None */,
    PPtr<CanvasSortingComponent> m_SortingComponent /* None */,
    PPtr<ConsoleHintsWidget> m_HintsWidget /* None */)
{
    public static CargoManagementConsoleView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_ShipNameAndPortraitPCView */
        PPtr<ShipNameAndPortraitPCView> _m_ShipNameAndPortraitPCView = PPtr<ShipNameAndPortraitPCView>.Read(reader);
        PPtr<InventoryStashConsoleView> _m_StashView = PPtr<InventoryStashConsoleView>.Read(reader);
        PPtr<InventoryCargoConsoleView> _m_CargoView = PPtr<InventoryCargoConsoleView>.Read(reader);
        PPtr<CanvasSortingComponent> _m_SortingComponent = PPtr<CanvasSortingComponent>.Read(reader);
        PPtr<ConsoleHintsWidget> _m_HintsWidget = PPtr<ConsoleHintsWidget>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_ShipNameAndPortraitPCView,
            _m_StashView,
            _m_CargoView,
            _m_SortingComponent,
            _m_HintsWidget);
    }
}


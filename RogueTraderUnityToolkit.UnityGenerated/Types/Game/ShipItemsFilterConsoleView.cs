namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $ShipItemsFilterConsoleView (20 fields) 00B8B3E36B6ABC1DC4CC7EB2F1E5551F/D8E618AA9536D94E4C583E64AAFFCEB1 */
public record class ShipItemsFilterConsoleView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<GameObject> m_Lens /* NeedsAlign */,
    float FilterSwitchAnimationDuration /* None */,
    PPtr<OwlcatToggleGroup> m_FiltersToggleGroup /* None */,
    PPtr<OwlcatToggle> m_None /* None */,
    PPtr<OwlcatToggle> m_Weapon /* None */,
    PPtr<OwlcatToggle> m_Other /* None */,
    PPtr<OwlcatDropdown> m_SorterDropdown /* None */,
    PPtr<GameObject> m_SorterObject /* None */,
    PPtr<VirtualListComponent> m_VirtualList /* None */,
    PPtr<ItemsFilterSearchBaseView> m_SearchView /* None */,
    float m_ShipNoFilterPosition /* None */,
    float m_ShipWeaponPosition /* None */,
    float ShipOtherPosition /* None */,
    PPtr<ConsoleHint> m_PreviousFilterHint /* None */,
    PPtr<ConsoleHint> m_NextFilterHint /* None */,
    PPtr<ConsoleHint> m_SortingHint /* None */)
{
    public static ShipItemsFilterConsoleView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_Lens */
        PPtr<GameObject> _m_Lens = PPtr<GameObject>.Read(reader);
        float _FilterSwitchAnimationDuration = reader.ReadF32();
        PPtr<OwlcatToggleGroup> _m_FiltersToggleGroup = PPtr<OwlcatToggleGroup>.Read(reader);
        PPtr<OwlcatToggle> _m_None = PPtr<OwlcatToggle>.Read(reader);
        PPtr<OwlcatToggle> _m_Weapon = PPtr<OwlcatToggle>.Read(reader);
        PPtr<OwlcatToggle> _m_Other = PPtr<OwlcatToggle>.Read(reader);
        PPtr<OwlcatDropdown> _m_SorterDropdown = PPtr<OwlcatDropdown>.Read(reader);
        PPtr<GameObject> _m_SorterObject = PPtr<GameObject>.Read(reader);
        PPtr<VirtualListComponent> _m_VirtualList = PPtr<VirtualListComponent>.Read(reader);
        PPtr<ItemsFilterSearchBaseView> _m_SearchView = PPtr<ItemsFilterSearchBaseView>.Read(reader);
        float _m_ShipNoFilterPosition = reader.ReadF32();
        float _m_ShipWeaponPosition = reader.ReadF32();
        float _ShipOtherPosition = reader.ReadF32();
        PPtr<ConsoleHint> _m_PreviousFilterHint = PPtr<ConsoleHint>.Read(reader);
        PPtr<ConsoleHint> _m_NextFilterHint = PPtr<ConsoleHint>.Read(reader);
        PPtr<ConsoleHint> _m_SortingHint = PPtr<ConsoleHint>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_Lens,
            _FilterSwitchAnimationDuration,
            _m_FiltersToggleGroup,
            _m_None,
            _m_Weapon,
            _m_Other,
            _m_SorterDropdown,
            _m_SorterObject,
            _m_VirtualList,
            _m_SearchView,
            _m_ShipNoFilterPosition,
            _m_ShipWeaponPosition,
            _ShipOtherPosition,
            _m_PreviousFilterHint,
            _m_NextFilterHint,
            _m_SortingHint);
    }
}


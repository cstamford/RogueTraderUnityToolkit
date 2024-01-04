namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $ShipItemsFilterPCView (17 fields) C099AAFAC5D26AA9DB74D280540C5B2F/B019A608FF599F8C322049799A90A87D */
public record class ShipItemsFilterPCView(
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
    float ShipOtherPosition /* None */)
{
    public static ShipItemsFilterPCView Read(EndianBinaryReader reader)
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
            _ShipOtherPosition);
    }
}


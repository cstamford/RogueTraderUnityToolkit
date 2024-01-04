namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $ItemsFilterConsoleView (25 fields) 72CB52C015BB47C4BACD27441ED9C3D8/432D4824CFDE3FCF81404794DD17583E */
public record class ItemsFilterConsoleView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<OwlcatToggleGroup> m_FiltersToggleGroup /* NeedsAlign */,
    PPtr<OwlcatToggle> m_None /* None */,
    PPtr<OwlcatToggle> m_Weapon /* None */,
    PPtr<OwlcatToggle> m_Armor /* None */,
    PPtr<OwlcatToggle> m_Accessories /* None */,
    PPtr<OwlcatToggle> m_Usable /* None */,
    PPtr<OwlcatToggle> m_Notable /* None */,
    PPtr<OwlcatToggle> m_ShipItems /* None */,
    PPtr<OwlcatToggle> m_Other /* None */,
    PPtr<GameObject> m_Lens /* None */,
    PPtr<OwlcatDropdown> m_SorterDropdown /* None */,
    PPtr<GameObject> m_SorterObject /* None */,
    PPtr<VirtualListComponent> m_VirtualList /* None */,
    PPtr<ItemsFilterSearchBaseView> m_SearchView /* None */,
    int[] m_SortedFiltersList /* None */,
    float m_LensStartPosition /* NeedsAlign */,
    float m_LensOffsetDelta /* None */,
    float FilterSwitchAnimationDuration /* None */,
    PPtr<ConsoleHint> m_PreviousFilterHint /* None */,
    PPtr<ConsoleHint> m_NextFilterHint /* None */,
    PPtr<ConsoleHint> m_SortingHint /* None */)
{
    public static ItemsFilterConsoleView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_FiltersToggleGroup */
        PPtr<OwlcatToggleGroup> _m_FiltersToggleGroup = PPtr<OwlcatToggleGroup>.Read(reader);
        PPtr<OwlcatToggle> _m_None = PPtr<OwlcatToggle>.Read(reader);
        PPtr<OwlcatToggle> _m_Weapon = PPtr<OwlcatToggle>.Read(reader);
        PPtr<OwlcatToggle> _m_Armor = PPtr<OwlcatToggle>.Read(reader);
        PPtr<OwlcatToggle> _m_Accessories = PPtr<OwlcatToggle>.Read(reader);
        PPtr<OwlcatToggle> _m_Usable = PPtr<OwlcatToggle>.Read(reader);
        PPtr<OwlcatToggle> _m_Notable = PPtr<OwlcatToggle>.Read(reader);
        PPtr<OwlcatToggle> _m_ShipItems = PPtr<OwlcatToggle>.Read(reader);
        PPtr<OwlcatToggle> _m_Other = PPtr<OwlcatToggle>.Read(reader);
        PPtr<GameObject> _m_Lens = PPtr<GameObject>.Read(reader);
        PPtr<OwlcatDropdown> _m_SorterDropdown = PPtr<OwlcatDropdown>.Read(reader);
        PPtr<GameObject> _m_SorterObject = PPtr<GameObject>.Read(reader);
        PPtr<VirtualListComponent> _m_VirtualList = PPtr<VirtualListComponent>.Read(reader);
        PPtr<ItemsFilterSearchBaseView> _m_SearchView = PPtr<ItemsFilterSearchBaseView>.Read(reader);
        int[] _m_SortedFiltersList = BuiltInArray<int>.Read(reader);
        reader.AlignTo(4); /* m_LensStartPosition */
        float _m_LensStartPosition = reader.ReadF32();
        float _m_LensOffsetDelta = reader.ReadF32();
        float _FilterSwitchAnimationDuration = reader.ReadF32();
        PPtr<ConsoleHint> _m_PreviousFilterHint = PPtr<ConsoleHint>.Read(reader);
        PPtr<ConsoleHint> _m_NextFilterHint = PPtr<ConsoleHint>.Read(reader);
        PPtr<ConsoleHint> _m_SortingHint = PPtr<ConsoleHint>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_FiltersToggleGroup,
            _m_None,
            _m_Weapon,
            _m_Armor,
            _m_Accessories,
            _m_Usable,
            _m_Notable,
            _m_ShipItems,
            _m_Other,
            _m_Lens,
            _m_SorterDropdown,
            _m_SorterObject,
            _m_VirtualList,
            _m_SearchView,
            _m_SortedFiltersList,
            _m_LensStartPosition,
            _m_LensOffsetDelta,
            _FilterSwitchAnimationDuration,
            _m_PreviousFilterHint,
            _m_NextFilterHint,
            _m_SortingHint);
    }
}


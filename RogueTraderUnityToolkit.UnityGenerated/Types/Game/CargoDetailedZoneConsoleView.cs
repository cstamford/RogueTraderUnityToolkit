namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $CargoDetailedZoneConsoleView (13 fields) 96ED9878749D81F5DA648A6AEEE1FCD7/FBA1047482508BE4EF820D4064FD63F5 */
public record class CargoDetailedZoneConsoleView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<VirtualListVertical> m_VirtualList /* NeedsAlign */,
    PPtr<CargoDetailedBaseView> m_CargoDetailedPrefab /* None */,
    PPtr<FadeAnimator> m_FadeAnimator /* None */,
    PPtr<Transform> m_Panel /* None */,
    PPtr<ItemsFilterSearchBaseView> SearchView /* None */,
    PPtr<OwlcatDropdown> m_SorterDropdown /* None */,
    float m_ScrollToCargoDelay /* None */,
    BoolReactiveProperty HasCargo /* None */,
    PPtr<ConsoleHint> m_SortingHint /* NeedsAlign */)
{
    public static CargoDetailedZoneConsoleView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_VirtualList */
        PPtr<VirtualListVertical> _m_VirtualList = PPtr<VirtualListVertical>.Read(reader);
        PPtr<CargoDetailedBaseView> _m_CargoDetailedPrefab = PPtr<CargoDetailedBaseView>.Read(reader);
        PPtr<FadeAnimator> _m_FadeAnimator = PPtr<FadeAnimator>.Read(reader);
        PPtr<Transform> _m_Panel = PPtr<Transform>.Read(reader);
        PPtr<ItemsFilterSearchBaseView> _SearchView = PPtr<ItemsFilterSearchBaseView>.Read(reader);
        PPtr<OwlcatDropdown> _m_SorterDropdown = PPtr<OwlcatDropdown>.Read(reader);
        float _m_ScrollToCargoDelay = reader.ReadF32();
        BoolReactiveProperty _HasCargo = BoolReactiveProperty.Read(reader);
        reader.AlignTo(4); /* m_SortingHint */
        PPtr<ConsoleHint> _m_SortingHint = PPtr<ConsoleHint>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_VirtualList,
            _m_CargoDetailedPrefab,
            _m_FadeAnimator,
            _m_Panel,
            _SearchView,
            _m_SorterDropdown,
            _m_ScrollToCargoDelay,
            _HasCargo,
            _m_SortingHint);
    }
}


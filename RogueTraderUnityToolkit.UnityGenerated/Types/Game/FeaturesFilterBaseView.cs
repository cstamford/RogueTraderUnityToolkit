namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $FeaturesFilterBaseView (16 fields) 1C0B2B1556B7673A5CBBFD58114904A0/9B26E65C7CEC4269DEFC9F0658648EB7 */
public record class FeaturesFilterBaseView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<OwlcatToggleGroup> m_FiltersToggleGroup /* NeedsAlign */,
    FilterView m_None /* None */,
    FilterView m_RecommendedFilter /* None */,
    FilterView m_ChoosedFilter /* None */,
    FilterView m_OffenseFilter /* None */,
    FilterView m_DefenseFilter /* None */,
    FilterView m_SupportFilter /* None */,
    FilterView m_UniversalFilter /* None */,
    FilterView m_ArchetypeFilter /* None */,
    FilterView m_OriginFilter /* None */,
    FilterView m_WarpFilter /* None */,
    PPtr<TextMeshProUGUI> m_FilterHint /* None */)
{
    public static FeaturesFilterBaseView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_FiltersToggleGroup */
        PPtr<OwlcatToggleGroup> _m_FiltersToggleGroup = PPtr<OwlcatToggleGroup>.Read(reader);
        FilterView _m_None = FilterView.Read(reader);
        FilterView _m_RecommendedFilter = FilterView.Read(reader);
        FilterView _m_ChoosedFilter = FilterView.Read(reader);
        FilterView _m_OffenseFilter = FilterView.Read(reader);
        FilterView _m_DefenseFilter = FilterView.Read(reader);
        FilterView _m_SupportFilter = FilterView.Read(reader);
        FilterView _m_UniversalFilter = FilterView.Read(reader);
        FilterView _m_ArchetypeFilter = FilterView.Read(reader);
        FilterView _m_OriginFilter = FilterView.Read(reader);
        FilterView _m_WarpFilter = FilterView.Read(reader);
        PPtr<TextMeshProUGUI> _m_FilterHint = PPtr<TextMeshProUGUI>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_FiltersToggleGroup,
            _m_None,
            _m_RecommendedFilter,
            _m_ChoosedFilter,
            _m_OffenseFilter,
            _m_DefenseFilter,
            _m_SupportFilter,
            _m_UniversalFilter,
            _m_ArchetypeFilter,
            _m_OriginFilter,
            _m_WarpFilter,
            _m_FilterHint);
    }
}


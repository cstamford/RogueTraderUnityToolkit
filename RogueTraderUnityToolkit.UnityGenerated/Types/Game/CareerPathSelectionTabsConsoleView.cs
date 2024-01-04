namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $CareerPathSelectionTabsConsoleView (8 fields) 376AA6B7190599EBE4FB28672C3ED516/12077B3D92F0FA72DD2E95FBBDB1FDD1 */
public record class CareerPathSelectionTabsConsoleView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<CareerPathDescriptionConsoleView> m_CareerPathDescriptionConsoleView /* NeedsAlign */,
    PPtr<CareerPathSelectionsSummaryConsoleView> m_CareerPathSelectionsSummaryConsoleView /* None */,
    PPtr<RankEntryFeatureDescriptionConsoleView> m_RankEntryFeatureDescriptionConsoleView /* None */,
    PPtr<RankEntryFeatureSelectionConsoleView> m_RankEntryFeatureSelectionConsoleView /* None */)
{
    public static CareerPathSelectionTabsConsoleView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_CareerPathDescriptionConsoleView */
        PPtr<CareerPathDescriptionConsoleView> _m_CareerPathDescriptionConsoleView = PPtr<CareerPathDescriptionConsoleView>.Read(reader);
        PPtr<CareerPathSelectionsSummaryConsoleView> _m_CareerPathSelectionsSummaryConsoleView = PPtr<CareerPathSelectionsSummaryConsoleView>.Read(reader);
        PPtr<RankEntryFeatureDescriptionConsoleView> _m_RankEntryFeatureDescriptionConsoleView = PPtr<RankEntryFeatureDescriptionConsoleView>.Read(reader);
        PPtr<RankEntryFeatureSelectionConsoleView> _m_RankEntryFeatureSelectionConsoleView = PPtr<RankEntryFeatureSelectionConsoleView>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_CareerPathDescriptionConsoleView,
            _m_CareerPathSelectionsSummaryConsoleView,
            _m_RankEntryFeatureDescriptionConsoleView,
            _m_RankEntryFeatureSelectionConsoleView);
    }
}


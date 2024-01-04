namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $ShipCareerPathSelectionTabsConsoleView (7 fields) 4969F0F4948C2B9B832D675D7735BFAB/238F4F47D514AA533C9FBDFBDE5415E6 */
public record class ShipCareerPathSelectionTabsConsoleView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<CareerPathSelectionsSummaryConsoleView> m_CareerPathSelectionsSummaryConsoleView /* NeedsAlign */,
    PPtr<RankEntryFeatureDescriptionConsoleView> m_RankEntryFeatureDescriptionConsoleView /* None */,
    PPtr<RankEntryFeatureSelectionConsoleView> m_RankEntryFeatureSelectionConsoleView /* None */)
{
    public static ShipCareerPathSelectionTabsConsoleView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_CareerPathSelectionsSummaryConsoleView */
        PPtr<CareerPathSelectionsSummaryConsoleView> _m_CareerPathSelectionsSummaryConsoleView = PPtr<CareerPathSelectionsSummaryConsoleView>.Read(reader);
        PPtr<RankEntryFeatureDescriptionConsoleView> _m_RankEntryFeatureDescriptionConsoleView = PPtr<RankEntryFeatureDescriptionConsoleView>.Read(reader);
        PPtr<RankEntryFeatureSelectionConsoleView> _m_RankEntryFeatureSelectionConsoleView = PPtr<RankEntryFeatureSelectionConsoleView>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_CareerPathSelectionsSummaryConsoleView,
            _m_RankEntryFeatureDescriptionConsoleView,
            _m_RankEntryFeatureSelectionConsoleView);
    }
}


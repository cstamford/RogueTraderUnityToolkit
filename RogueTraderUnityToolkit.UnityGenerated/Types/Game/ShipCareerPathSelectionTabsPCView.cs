namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $ShipCareerPathSelectionTabsPCView (7 fields) 66BF5D1047378BC63E6D000F393E19EE/324B71894420912978C41A25BC7FEABF */
public record class ShipCareerPathSelectionTabsPCView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<CareerPathSelectionsSummaryPCView> m_CareerPathSelectionsSummaryPCView /* NeedsAlign */,
    PPtr<RankEntryFeatureDescriptionPCView> m_RankEntryFeatureDescriptionPCView /* None */,
    PPtr<RankEntryFeatureSelectionPCView> m_RankEntryFeatureSelectionPCView /* None */)
{
    public static ShipCareerPathSelectionTabsPCView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_CareerPathSelectionsSummaryPCView */
        PPtr<CareerPathSelectionsSummaryPCView> _m_CareerPathSelectionsSummaryPCView = PPtr<CareerPathSelectionsSummaryPCView>.Read(reader);
        PPtr<RankEntryFeatureDescriptionPCView> _m_RankEntryFeatureDescriptionPCView = PPtr<RankEntryFeatureDescriptionPCView>.Read(reader);
        PPtr<RankEntryFeatureSelectionPCView> _m_RankEntryFeatureSelectionPCView = PPtr<RankEntryFeatureSelectionPCView>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_CareerPathSelectionsSummaryPCView,
            _m_RankEntryFeatureDescriptionPCView,
            _m_RankEntryFeatureSelectionPCView);
    }
}


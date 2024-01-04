namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $CareerPathSelectionTabsPCView (8 fields) 11B84F2D1918E9F4A4D471D6CE8525D7/83418BF78BC0454CC9298F4FC53162CC */
public record class CareerPathSelectionTabsPCView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<CareerPathDescriptionPCView> m_CareerPathDescriptionPCView /* NeedsAlign */,
    PPtr<CareerPathSelectionsSummaryPCView> m_CareerPathSelectionsSummaryPCView /* None */,
    PPtr<RankEntryFeatureDescriptionPCView> m_RankEntryFeatureDescriptionPCView /* None */,
    PPtr<RankEntryFeatureSelectionPCView> m_RankEntryFeatureSelectionPCView /* None */)
{
    public static CareerPathSelectionTabsPCView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_CareerPathDescriptionPCView */
        PPtr<CareerPathDescriptionPCView> _m_CareerPathDescriptionPCView = PPtr<CareerPathDescriptionPCView>.Read(reader);
        PPtr<CareerPathSelectionsSummaryPCView> _m_CareerPathSelectionsSummaryPCView = PPtr<CareerPathSelectionsSummaryPCView>.Read(reader);
        PPtr<RankEntryFeatureDescriptionPCView> _m_RankEntryFeatureDescriptionPCView = PPtr<RankEntryFeatureDescriptionPCView>.Read(reader);
        PPtr<RankEntryFeatureSelectionPCView> _m_RankEntryFeatureSelectionPCView = PPtr<RankEntryFeatureSelectionPCView>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_CareerPathDescriptionPCView,
            _m_CareerPathSelectionsSummaryPCView,
            _m_RankEntryFeatureDescriptionPCView,
            _m_RankEntryFeatureSelectionPCView);
    }
}


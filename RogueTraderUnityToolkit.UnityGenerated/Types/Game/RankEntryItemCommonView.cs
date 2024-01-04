namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $RankEntryItemCommonView (12 fields) CAEBBDADD1EE72AA2897F46768547479/381D1E90455A921CAAD55866574BBD8D */
public record class RankEntryItemCommonView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<GameObject> m_FirstRankDecoration /* NeedsAlign */,
    PPtr<RankEntryFeatureItemCommonView> m_FeatureItemCommonView /* None */,
    PPtr<RankEntrySelectionItemCommonView> m_SelectionItemCommonView /* None */,
    PPtr<OwlcatMultiSelectable> m_EmptyDummy /* None */,
    PPtr<RectTransform> m_Container /* None */,
    byte m_IsVoidshipEntry /* None */,
    PPtr<RectTransform> m_ForShipContainer /* NeedsAlign */,
    byte m_IsListEntry /* None */)
{
    public static RankEntryItemCommonView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_FirstRankDecoration */
        PPtr<GameObject> _m_FirstRankDecoration = PPtr<GameObject>.Read(reader);
        PPtr<RankEntryFeatureItemCommonView> _m_FeatureItemCommonView = PPtr<RankEntryFeatureItemCommonView>.Read(reader);
        PPtr<RankEntrySelectionItemCommonView> _m_SelectionItemCommonView = PPtr<RankEntrySelectionItemCommonView>.Read(reader);
        PPtr<OwlcatMultiSelectable> _m_EmptyDummy = PPtr<OwlcatMultiSelectable>.Read(reader);
        PPtr<RectTransform> _m_Container = PPtr<RectTransform>.Read(reader);
        byte _m_IsVoidshipEntry = reader.ReadU8();
        reader.AlignTo(4); /* m_ForShipContainer */
        PPtr<RectTransform> _m_ForShipContainer = PPtr<RectTransform>.Read(reader);
        byte _m_IsListEntry = reader.ReadU8();
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_FirstRankDecoration,
            _m_FeatureItemCommonView,
            _m_SelectionItemCommonView,
            _m_EmptyDummy,
            _m_Container,
            _m_IsVoidshipEntry,
            _m_ForShipContainer,
            _m_IsListEntry);
    }
}


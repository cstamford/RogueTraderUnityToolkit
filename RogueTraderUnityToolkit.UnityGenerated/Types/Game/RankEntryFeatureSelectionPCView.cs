namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $RankEntryFeatureSelectionPCView (17 fields) 6EFD4DA98F85E434F3F983112FB0CF59/198DE2F5A5B8A2954E20B09D73DAD28C */
public record class RankEntryFeatureSelectionPCView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<GameObject> m_HeaderBlock /* NeedsAlign */,
    PPtr<TextMeshProUGUI> m_HeaderLabel /* None */,
    byte m_ButtonsSetFromParent /* None */,
    PPtr<CareerButtonsBlock> m_ButtonsBlock /* NeedsAlign */,
    PPtr<CharInfoFeaturePCView> m_UltimateFeaturePCView /* None */,
    PPtr<FeaturesFilterBaseView> m_FeaturesFilter /* None */,
    PPtr<TextMeshProUGUI> m_NoFeaturesText /* None */,
    PPtr<VirtualListVertical> m_VirtualList /* None */,
    PPtr<ExpandableTitleView> m_ExpandableTitleView /* None */,
    PPtr<RankEntryStatItemCommonView> m_RankEntryStatItemCommonView /* None */,
    PPtr<RankEntryFeatureItemCommonView> m_RankEntryFeatureItemCommonView /* None */,
    PPtr<RankEntryUltimateFeatureUpgradeItemCommonView> m_RankEntryUltimateFeatureUpgradeItemCommonView /* None */,
    PPtr<RankEntryDescriptionView> m_RankEntryDescriptionView /* None */)
{
    public static RankEntryFeatureSelectionPCView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_HeaderBlock */
        PPtr<GameObject> _m_HeaderBlock = PPtr<GameObject>.Read(reader);
        PPtr<TextMeshProUGUI> _m_HeaderLabel = PPtr<TextMeshProUGUI>.Read(reader);
        byte _m_ButtonsSetFromParent = reader.ReadU8();
        reader.AlignTo(4); /* m_ButtonsBlock */
        PPtr<CareerButtonsBlock> _m_ButtonsBlock = PPtr<CareerButtonsBlock>.Read(reader);
        PPtr<CharInfoFeaturePCView> _m_UltimateFeaturePCView = PPtr<CharInfoFeaturePCView>.Read(reader);
        PPtr<FeaturesFilterBaseView> _m_FeaturesFilter = PPtr<FeaturesFilterBaseView>.Read(reader);
        PPtr<TextMeshProUGUI> _m_NoFeaturesText = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<VirtualListVertical> _m_VirtualList = PPtr<VirtualListVertical>.Read(reader);
        PPtr<ExpandableTitleView> _m_ExpandableTitleView = PPtr<ExpandableTitleView>.Read(reader);
        PPtr<RankEntryStatItemCommonView> _m_RankEntryStatItemCommonView = PPtr<RankEntryStatItemCommonView>.Read(reader);
        PPtr<RankEntryFeatureItemCommonView> _m_RankEntryFeatureItemCommonView = PPtr<RankEntryFeatureItemCommonView>.Read(reader);
        PPtr<RankEntryUltimateFeatureUpgradeItemCommonView> _m_RankEntryUltimateFeatureUpgradeItemCommonView = PPtr<RankEntryUltimateFeatureUpgradeItemCommonView>.Read(reader);
        PPtr<RankEntryDescriptionView> _m_RankEntryDescriptionView = PPtr<RankEntryDescriptionView>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_HeaderBlock,
            _m_HeaderLabel,
            _m_ButtonsSetFromParent,
            _m_ButtonsBlock,
            _m_UltimateFeaturePCView,
            _m_FeaturesFilter,
            _m_NoFeaturesText,
            _m_VirtualList,
            _m_ExpandableTitleView,
            _m_RankEntryStatItemCommonView,
            _m_RankEntryFeatureItemCommonView,
            _m_RankEntryUltimateFeatureUpgradeItemCommonView,
            _m_RankEntryDescriptionView);
    }
}


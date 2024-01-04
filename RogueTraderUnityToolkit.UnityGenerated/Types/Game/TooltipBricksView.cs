namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $TooltipBricksView (74 fields) ABA041920CB64A2F830C16FC2170326B/FB78548B931705BD6AC51FEE0FD30B60 */
public record class TooltipBricksView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<TooltipBrickTextView> BrickTextView /* NeedsAlign */,
    PPtr<TooltipBrickSeparatorView> BrickSeparatorView /* None */,
    PPtr<TooltipBrickSpaceView> BrickSpaceView /* None */,
    PPtr<TooltipBrickTitleView> BrickTitleView /* None */,
    PPtr<TooltipBrickPictureView> BrickPictureView /* None */,
    PPtr<TooltipBrickIconAndNameView> BrickIconAndNameView /* None */,
    PPtr<TooltipBrickFactionStatusView> FactionStatusView /* None */,
    PPtr<TooltipBrickDoubleTextView> BrickDoubleTextView /* None */,
    PPtr<TooltipBrickTripleTextView> BrickTripleTextView /* None */,
    PPtr<TooltipBrickIconValueStatView> BrickIconValueStatView /* None */,
    PPtr<TooltipBrickIconStatValueView> BrickIconStatValueView /* None */,
    PPtr<TooltipBrickTwoColumnsStatView> BrickTwoColumnsStatView /* None */,
    PPtr<TooltipBrickValueStatFormulaView> BrickValueStatFormulaView /* None */,
    PPtr<TooltipBrickTimerView> BrickTimerView /* None */,
    PPtr<TooltipBrickEntityHeaderView> BrickEntityHeaderView /* None */,
    PPtr<TooltipBrickFeatureView> BrickFeatureView /* None */,
    PPtr<TooltipBrickFeatureHeaderView> BrickFeatureHeaderView /* None */,
    PPtr<TooltipBrickBuffView> BrickBuffView /* None */,
    PPtr<TooltipBrickItemFooterView> BrickItemFooterView /* None */,
    PPtr<TooltipBrickAbilityScoresView> BrickAbilityScoresView /* None */,
    PPtr<TooltipBrickEncumbranceView> BrickEncumbranceView /* None */,
    PPtr<TooltipBrickPortraitAndNameView> BrickPortraitAndNameView /* None */,
    PPtr<TooltipBrickItemIconAndNameView> BrickItemIconAndNameView /* None */,
    PPtr<TooltipBrickResourceIconAndNameView> BrickResourceIconAndNameView /* None */,
    PPtr<TooltipBrickColonyProjectProgressView> BrickColonyProjectProgressView /* None */,
    PPtr<TooltipBrickPFIconAndNameView> BrickPFIconAndNameView /* None */,
    PPtr<TooltipBrickButtonView> BrickButtonView /* None */,
    PPtr<TooltipBrickHistoryManagementView> BrickHistoryManagementView /* None */,
    PPtr<TooltipBrickNonStackView> BrickNonStackView /* None */,
    PPtr<TooltipBrickPrerequisiteView> BrickPrerequisiteView /* None */,
    PPtr<TooltipBrickRateView> BrickRateView /* None */,
    PPtr<TooltipBrickFeatureShortDescriptionView> BrickFeatureShortDescriptionView /* None */,
    PPtr<TooltipBrickAbilityScoresBlockView> BrickAbilityScoresBlockView /* None */,
    PPtr<TooltipBrickSkillsView> BrickSkillsView /* None */,
    PPtr<TooltipBrickAbilityTargetView> BrickAbilityTargetView /* None */,
    PPtr<TooltipBrickHintView> BrickHintView /* None */,
    PPtr<TooltipBrickPlanetInfoView> PlanetInfoView /* None */,
    PPtr<TooltipBrickOtherObjectsInfoView> OtherObjectsInfoView /* None */,
    PPtr<TooltipBrickResourceInfoView> ResourceInfoView /* None */,
    PPtr<TooltipBrickUnifiedStatusView> UnifiedStatusView /* None */,
    PPtr<TooltipBrickProfitFactorView> ProfitFactorView /* None */,
    PPtr<TooltipBrickIconPatternView> IconPatternView /* None */,
    PPtr<TooltipBricksGroupView> BricksGroupView /* None */,
    PPtr<TooltipBrickCargoCapacityView> CargoCapacityView /* None */,
    PPtr<TooltipBrickGlobalMapPositionView> GlobalMapPositionView /* None */,
    PPtr<TooltipBrickMomentumPortraitView> MomentumPortraitView /* None */,
    PPtr<TooltipBricksMomentumPortraitsView> MomentumPortraitsView /* None */,
    PPtr<TooltipBrickPortraitFeaturesView> PortraitFeaturesView /* None */,
    PPtr<TooltipBrickSliderView> SliderView /* None */,
    PPtr<TooltipBrickWeaponSetView> WeaponSetView /* None */,
    PPtr<TooltipBrickArmorStatsView> ArmorStatsView /* None */,
    PPtr<TooltipBrickEventsView> EventsView /* None */,
    PPtr<TooltipBrickIconAndTextWithCustomColorsView> IconAndTextWithCustomColorsView /* None */,
    PPtr<TooltipBrickWidgetView> BrickWidgetView /* None */,
    PPtr<TooltipBrickCalculatedFormulaView> CalculatedFormulaView /* None */,
    PPtr<TooltipBrickTitleWithIconView> BrickTitleWithIconView /* None */,
    PPtr<TooltipBrickRankEntrySelectionView> BrickRankEntrySelectionView /* None */,
    PPtr<TooltipBrickTextBackgroundView> BrickTextBackgroundView /* None */,
    PPtr<TooltipBrickChanceView> BrickChanceView /* None */,
    PPtr<TooltipBrickShotDeviationView> BrickShotDeviationView /* None */,
    PPtr<TooltipBrickShotDeviationWithNameView> BrickShotDeviationWithNameView /* None */,
    PPtr<TooltipBrickIconTextView> BrickIconTextView /* None */,
    PPtr<TooltipBrickIconTextValueView> BrickIconTextValueView /* None */,
    PPtr<TooltipBrickTextValueView> BrickTextValueView /* None */,
    PPtr<TooltipBrickTextSignatureValueView> BrickTextSignatureValueView /* None */,
    PPtr<TooltipBrickDamageRangeView> BrickDamageRangeView /* None */,
    PPtr<TooltipBrickMinimalAdmissibleDamageView> BrickMinimalAdmissibleDamageView /* None */,
    PPtr<TooltipBrickTriggeredAutoView> BrickTriggeredAutoView /* None */,
    PPtr<TooltipBrickDamageNullifierView> BrickDamageNullifierView /* None */,
    PPtr<TooltipBrickNestedMessageView> BrickNestedMessageView /* None */)
{
    public static TooltipBricksView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* BrickTextView */
        PPtr<TooltipBrickTextView> _BrickTextView = PPtr<TooltipBrickTextView>.Read(reader);
        PPtr<TooltipBrickSeparatorView> _BrickSeparatorView = PPtr<TooltipBrickSeparatorView>.Read(reader);
        PPtr<TooltipBrickSpaceView> _BrickSpaceView = PPtr<TooltipBrickSpaceView>.Read(reader);
        PPtr<TooltipBrickTitleView> _BrickTitleView = PPtr<TooltipBrickTitleView>.Read(reader);
        PPtr<TooltipBrickPictureView> _BrickPictureView = PPtr<TooltipBrickPictureView>.Read(reader);
        PPtr<TooltipBrickIconAndNameView> _BrickIconAndNameView = PPtr<TooltipBrickIconAndNameView>.Read(reader);
        PPtr<TooltipBrickFactionStatusView> _FactionStatusView = PPtr<TooltipBrickFactionStatusView>.Read(reader);
        PPtr<TooltipBrickDoubleTextView> _BrickDoubleTextView = PPtr<TooltipBrickDoubleTextView>.Read(reader);
        PPtr<TooltipBrickTripleTextView> _BrickTripleTextView = PPtr<TooltipBrickTripleTextView>.Read(reader);
        PPtr<TooltipBrickIconValueStatView> _BrickIconValueStatView = PPtr<TooltipBrickIconValueStatView>.Read(reader);
        PPtr<TooltipBrickIconStatValueView> _BrickIconStatValueView = PPtr<TooltipBrickIconStatValueView>.Read(reader);
        PPtr<TooltipBrickTwoColumnsStatView> _BrickTwoColumnsStatView = PPtr<TooltipBrickTwoColumnsStatView>.Read(reader);
        PPtr<TooltipBrickValueStatFormulaView> _BrickValueStatFormulaView = PPtr<TooltipBrickValueStatFormulaView>.Read(reader);
        PPtr<TooltipBrickTimerView> _BrickTimerView = PPtr<TooltipBrickTimerView>.Read(reader);
        PPtr<TooltipBrickEntityHeaderView> _BrickEntityHeaderView = PPtr<TooltipBrickEntityHeaderView>.Read(reader);
        PPtr<TooltipBrickFeatureView> _BrickFeatureView = PPtr<TooltipBrickFeatureView>.Read(reader);
        PPtr<TooltipBrickFeatureHeaderView> _BrickFeatureHeaderView = PPtr<TooltipBrickFeatureHeaderView>.Read(reader);
        PPtr<TooltipBrickBuffView> _BrickBuffView = PPtr<TooltipBrickBuffView>.Read(reader);
        PPtr<TooltipBrickItemFooterView> _BrickItemFooterView = PPtr<TooltipBrickItemFooterView>.Read(reader);
        PPtr<TooltipBrickAbilityScoresView> _BrickAbilityScoresView = PPtr<TooltipBrickAbilityScoresView>.Read(reader);
        PPtr<TooltipBrickEncumbranceView> _BrickEncumbranceView = PPtr<TooltipBrickEncumbranceView>.Read(reader);
        PPtr<TooltipBrickPortraitAndNameView> _BrickPortraitAndNameView = PPtr<TooltipBrickPortraitAndNameView>.Read(reader);
        PPtr<TooltipBrickItemIconAndNameView> _BrickItemIconAndNameView = PPtr<TooltipBrickItemIconAndNameView>.Read(reader);
        PPtr<TooltipBrickResourceIconAndNameView> _BrickResourceIconAndNameView = PPtr<TooltipBrickResourceIconAndNameView>.Read(reader);
        PPtr<TooltipBrickColonyProjectProgressView> _BrickColonyProjectProgressView = PPtr<TooltipBrickColonyProjectProgressView>.Read(reader);
        PPtr<TooltipBrickPFIconAndNameView> _BrickPFIconAndNameView = PPtr<TooltipBrickPFIconAndNameView>.Read(reader);
        PPtr<TooltipBrickButtonView> _BrickButtonView = PPtr<TooltipBrickButtonView>.Read(reader);
        PPtr<TooltipBrickHistoryManagementView> _BrickHistoryManagementView = PPtr<TooltipBrickHistoryManagementView>.Read(reader);
        PPtr<TooltipBrickNonStackView> _BrickNonStackView = PPtr<TooltipBrickNonStackView>.Read(reader);
        PPtr<TooltipBrickPrerequisiteView> _BrickPrerequisiteView = PPtr<TooltipBrickPrerequisiteView>.Read(reader);
        PPtr<TooltipBrickRateView> _BrickRateView = PPtr<TooltipBrickRateView>.Read(reader);
        PPtr<TooltipBrickFeatureShortDescriptionView> _BrickFeatureShortDescriptionView = PPtr<TooltipBrickFeatureShortDescriptionView>.Read(reader);
        PPtr<TooltipBrickAbilityScoresBlockView> _BrickAbilityScoresBlockView = PPtr<TooltipBrickAbilityScoresBlockView>.Read(reader);
        PPtr<TooltipBrickSkillsView> _BrickSkillsView = PPtr<TooltipBrickSkillsView>.Read(reader);
        PPtr<TooltipBrickAbilityTargetView> _BrickAbilityTargetView = PPtr<TooltipBrickAbilityTargetView>.Read(reader);
        PPtr<TooltipBrickHintView> _BrickHintView = PPtr<TooltipBrickHintView>.Read(reader);
        PPtr<TooltipBrickPlanetInfoView> _PlanetInfoView = PPtr<TooltipBrickPlanetInfoView>.Read(reader);
        PPtr<TooltipBrickOtherObjectsInfoView> _OtherObjectsInfoView = PPtr<TooltipBrickOtherObjectsInfoView>.Read(reader);
        PPtr<TooltipBrickResourceInfoView> _ResourceInfoView = PPtr<TooltipBrickResourceInfoView>.Read(reader);
        PPtr<TooltipBrickUnifiedStatusView> _UnifiedStatusView = PPtr<TooltipBrickUnifiedStatusView>.Read(reader);
        PPtr<TooltipBrickProfitFactorView> _ProfitFactorView = PPtr<TooltipBrickProfitFactorView>.Read(reader);
        PPtr<TooltipBrickIconPatternView> _IconPatternView = PPtr<TooltipBrickIconPatternView>.Read(reader);
        PPtr<TooltipBricksGroupView> _BricksGroupView = PPtr<TooltipBricksGroupView>.Read(reader);
        PPtr<TooltipBrickCargoCapacityView> _CargoCapacityView = PPtr<TooltipBrickCargoCapacityView>.Read(reader);
        PPtr<TooltipBrickGlobalMapPositionView> _GlobalMapPositionView = PPtr<TooltipBrickGlobalMapPositionView>.Read(reader);
        PPtr<TooltipBrickMomentumPortraitView> _MomentumPortraitView = PPtr<TooltipBrickMomentumPortraitView>.Read(reader);
        PPtr<TooltipBricksMomentumPortraitsView> _MomentumPortraitsView = PPtr<TooltipBricksMomentumPortraitsView>.Read(reader);
        PPtr<TooltipBrickPortraitFeaturesView> _PortraitFeaturesView = PPtr<TooltipBrickPortraitFeaturesView>.Read(reader);
        PPtr<TooltipBrickSliderView> _SliderView = PPtr<TooltipBrickSliderView>.Read(reader);
        PPtr<TooltipBrickWeaponSetView> _WeaponSetView = PPtr<TooltipBrickWeaponSetView>.Read(reader);
        PPtr<TooltipBrickArmorStatsView> _ArmorStatsView = PPtr<TooltipBrickArmorStatsView>.Read(reader);
        PPtr<TooltipBrickEventsView> _EventsView = PPtr<TooltipBrickEventsView>.Read(reader);
        PPtr<TooltipBrickIconAndTextWithCustomColorsView> _IconAndTextWithCustomColorsView = PPtr<TooltipBrickIconAndTextWithCustomColorsView>.Read(reader);
        PPtr<TooltipBrickWidgetView> _BrickWidgetView = PPtr<TooltipBrickWidgetView>.Read(reader);
        PPtr<TooltipBrickCalculatedFormulaView> _CalculatedFormulaView = PPtr<TooltipBrickCalculatedFormulaView>.Read(reader);
        PPtr<TooltipBrickTitleWithIconView> _BrickTitleWithIconView = PPtr<TooltipBrickTitleWithIconView>.Read(reader);
        PPtr<TooltipBrickRankEntrySelectionView> _BrickRankEntrySelectionView = PPtr<TooltipBrickRankEntrySelectionView>.Read(reader);
        PPtr<TooltipBrickTextBackgroundView> _BrickTextBackgroundView = PPtr<TooltipBrickTextBackgroundView>.Read(reader);
        PPtr<TooltipBrickChanceView> _BrickChanceView = PPtr<TooltipBrickChanceView>.Read(reader);
        PPtr<TooltipBrickShotDeviationView> _BrickShotDeviationView = PPtr<TooltipBrickShotDeviationView>.Read(reader);
        PPtr<TooltipBrickShotDeviationWithNameView> _BrickShotDeviationWithNameView = PPtr<TooltipBrickShotDeviationWithNameView>.Read(reader);
        PPtr<TooltipBrickIconTextView> _BrickIconTextView = PPtr<TooltipBrickIconTextView>.Read(reader);
        PPtr<TooltipBrickIconTextValueView> _BrickIconTextValueView = PPtr<TooltipBrickIconTextValueView>.Read(reader);
        PPtr<TooltipBrickTextValueView> _BrickTextValueView = PPtr<TooltipBrickTextValueView>.Read(reader);
        PPtr<TooltipBrickTextSignatureValueView> _BrickTextSignatureValueView = PPtr<TooltipBrickTextSignatureValueView>.Read(reader);
        PPtr<TooltipBrickDamageRangeView> _BrickDamageRangeView = PPtr<TooltipBrickDamageRangeView>.Read(reader);
        PPtr<TooltipBrickMinimalAdmissibleDamageView> _BrickMinimalAdmissibleDamageView = PPtr<TooltipBrickMinimalAdmissibleDamageView>.Read(reader);
        PPtr<TooltipBrickTriggeredAutoView> _BrickTriggeredAutoView = PPtr<TooltipBrickTriggeredAutoView>.Read(reader);
        PPtr<TooltipBrickDamageNullifierView> _BrickDamageNullifierView = PPtr<TooltipBrickDamageNullifierView>.Read(reader);
        PPtr<TooltipBrickNestedMessageView> _BrickNestedMessageView = PPtr<TooltipBrickNestedMessageView>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _BrickTextView,
            _BrickSeparatorView,
            _BrickSpaceView,
            _BrickTitleView,
            _BrickPictureView,
            _BrickIconAndNameView,
            _FactionStatusView,
            _BrickDoubleTextView,
            _BrickTripleTextView,
            _BrickIconValueStatView,
            _BrickIconStatValueView,
            _BrickTwoColumnsStatView,
            _BrickValueStatFormulaView,
            _BrickTimerView,
            _BrickEntityHeaderView,
            _BrickFeatureView,
            _BrickFeatureHeaderView,
            _BrickBuffView,
            _BrickItemFooterView,
            _BrickAbilityScoresView,
            _BrickEncumbranceView,
            _BrickPortraitAndNameView,
            _BrickItemIconAndNameView,
            _BrickResourceIconAndNameView,
            _BrickColonyProjectProgressView,
            _BrickPFIconAndNameView,
            _BrickButtonView,
            _BrickHistoryManagementView,
            _BrickNonStackView,
            _BrickPrerequisiteView,
            _BrickRateView,
            _BrickFeatureShortDescriptionView,
            _BrickAbilityScoresBlockView,
            _BrickSkillsView,
            _BrickAbilityTargetView,
            _BrickHintView,
            _PlanetInfoView,
            _OtherObjectsInfoView,
            _ResourceInfoView,
            _UnifiedStatusView,
            _ProfitFactorView,
            _IconPatternView,
            _BricksGroupView,
            _CargoCapacityView,
            _GlobalMapPositionView,
            _MomentumPortraitView,
            _MomentumPortraitsView,
            _PortraitFeaturesView,
            _SliderView,
            _WeaponSetView,
            _ArmorStatsView,
            _EventsView,
            _IconAndTextWithCustomColorsView,
            _BrickWidgetView,
            _CalculatedFormulaView,
            _BrickTitleWithIconView,
            _BrickRankEntrySelectionView,
            _BrickTextBackgroundView,
            _BrickChanceView,
            _BrickShotDeviationView,
            _BrickShotDeviationWithNameView,
            _BrickIconTextView,
            _BrickIconTextValueView,
            _BrickTextValueView,
            _BrickTextSignatureValueView,
            _BrickDamageRangeView,
            _BrickMinimalAdmissibleDamageView,
            _BrickTriggeredAutoView,
            _BrickDamageNullifierView,
            _BrickNestedMessageView);
    }
}


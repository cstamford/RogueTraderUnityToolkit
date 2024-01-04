namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $ExitBattlePopupConsoleView (30 fields) 5F078EB53D2C24FCCFE0A963DEA709CD/6A8F2A6B857768930821A6C2FD7F5C5F */
public record class ExitBattlePopupConsoleView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<TextMeshProUGUI> m_ExitBattleTitleLabel /* NeedsAlign */,
    PPtr<FadeAnimator> m_Animator /* None */,
    PPtr<Image> m_ExperiencePanel /* None */,
    PPtr<TextMeshProUGUI> m_ExpLabel /* None */,
    PPtr<TextMeshProUGUI> m_CurrentLevel /* None */,
    PPtr<TextMeshProUGUI> m_GainedExpAmount /* None */,
    PPtr<TextMeshProUGUI> m_CurrentExpAmount /* None */,
    PPtr<TextMeshProUGUI> m_NextLevelExpAmount /* None */,
    PPtr<Slider> m_ExpMaxSlider /* None */,
    PPtr<DelayedSlider> m_ExpCurrentSlider /* None */,
    PPtr<Slider> m_FakeExpMaxSlider /* None */,
    PPtr<DelayedSlider> m_FakeExpCurrentSlider /* None */,
    PPtr<Image> m_UpgradeAvailableIcon /* None */,
    PPtr<TextMeshProUGUI> m_LootRewardsLabel /* None */,
    PPtr<GameObject> m_LootBlock /* None */,
    PPtr<GameObject> m_ItemsSubBlock /* None */,
    PPtr<ItemSlotsGroupView> m_ItemsSlotsGroup /* None */,
    PPtr<GridLayoutGroup> m_ItemsGridLayoutGroup /* None */,
    PPtr<GameObject> m_CargoSubBlock /* None */,
    PPtr<GameObject> m_CargoSeparator /* None */,
    PPtr<WidgetListMVVM> m_WidgetListCargoes /* None */,
    PPtr<GridLayoutGroup> m_CargoGridLayoutGroup /* None */,
    PPtr<CargoRewardSlotView> m_CargoRewardSlotPrefab /* None */,
    PPtr<ScrapRewardSlotView> m_ScrapRewardSlotView /* None */,
    PPtr<LootSlotConsoleView> m_SlotPrefab /* None */,
    PPtr<ConsoleHintsWidget> m_HintsWidget /* None */)
{
    public static ExitBattlePopupConsoleView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_ExitBattleTitleLabel */
        PPtr<TextMeshProUGUI> _m_ExitBattleTitleLabel = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<FadeAnimator> _m_Animator = PPtr<FadeAnimator>.Read(reader);
        PPtr<Image> _m_ExperiencePanel = PPtr<Image>.Read(reader);
        PPtr<TextMeshProUGUI> _m_ExpLabel = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<TextMeshProUGUI> _m_CurrentLevel = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<TextMeshProUGUI> _m_GainedExpAmount = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<TextMeshProUGUI> _m_CurrentExpAmount = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<TextMeshProUGUI> _m_NextLevelExpAmount = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<Slider> _m_ExpMaxSlider = PPtr<Slider>.Read(reader);
        PPtr<DelayedSlider> _m_ExpCurrentSlider = PPtr<DelayedSlider>.Read(reader);
        PPtr<Slider> _m_FakeExpMaxSlider = PPtr<Slider>.Read(reader);
        PPtr<DelayedSlider> _m_FakeExpCurrentSlider = PPtr<DelayedSlider>.Read(reader);
        PPtr<Image> _m_UpgradeAvailableIcon = PPtr<Image>.Read(reader);
        PPtr<TextMeshProUGUI> _m_LootRewardsLabel = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<GameObject> _m_LootBlock = PPtr<GameObject>.Read(reader);
        PPtr<GameObject> _m_ItemsSubBlock = PPtr<GameObject>.Read(reader);
        PPtr<ItemSlotsGroupView> _m_ItemsSlotsGroup = PPtr<ItemSlotsGroupView>.Read(reader);
        PPtr<GridLayoutGroup> _m_ItemsGridLayoutGroup = PPtr<GridLayoutGroup>.Read(reader);
        PPtr<GameObject> _m_CargoSubBlock = PPtr<GameObject>.Read(reader);
        PPtr<GameObject> _m_CargoSeparator = PPtr<GameObject>.Read(reader);
        PPtr<WidgetListMVVM> _m_WidgetListCargoes = PPtr<WidgetListMVVM>.Read(reader);
        PPtr<GridLayoutGroup> _m_CargoGridLayoutGroup = PPtr<GridLayoutGroup>.Read(reader);
        PPtr<CargoRewardSlotView> _m_CargoRewardSlotPrefab = PPtr<CargoRewardSlotView>.Read(reader);
        PPtr<ScrapRewardSlotView> _m_ScrapRewardSlotView = PPtr<ScrapRewardSlotView>.Read(reader);
        PPtr<LootSlotConsoleView> _m_SlotPrefab = PPtr<LootSlotConsoleView>.Read(reader);
        PPtr<ConsoleHintsWidget> _m_HintsWidget = PPtr<ConsoleHintsWidget>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_ExitBattleTitleLabel,
            _m_Animator,
            _m_ExperiencePanel,
            _m_ExpLabel,
            _m_CurrentLevel,
            _m_GainedExpAmount,
            _m_CurrentExpAmount,
            _m_NextLevelExpAmount,
            _m_ExpMaxSlider,
            _m_ExpCurrentSlider,
            _m_FakeExpMaxSlider,
            _m_FakeExpCurrentSlider,
            _m_UpgradeAvailableIcon,
            _m_LootRewardsLabel,
            _m_LootBlock,
            _m_ItemsSubBlock,
            _m_ItemsSlotsGroup,
            _m_ItemsGridLayoutGroup,
            _m_CargoSubBlock,
            _m_CargoSeparator,
            _m_WidgetListCargoes,
            _m_CargoGridLayoutGroup,
            _m_CargoRewardSlotPrefab,
            _m_ScrapRewardSlotView,
            _m_SlotPrefab,
            _m_HintsWidget);
    }
}


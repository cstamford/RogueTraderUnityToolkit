namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $ColonyRewardsPCView (35 fields) 42C304E450617B17831693067418EB61/3BA37CD169A24C07E9534C975B54550A */
public record class ColonyRewardsPCView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<TextMeshProUGUI> m_HeaderLabel /* NeedsAlign */,
    PPtr<GameObject> m_ColonyRewardBlock /* None */,
    PPtr<GameObject> m_FinishedProjectBlock /* None */,
    PPtr<TextMeshProUGUI> m_ProjectIsFinishedLabel /* None */,
    PPtr<TextMeshProUGUI> m_FinishedProjectNameLabel /* None */,
    PPtr<Image> m_FinishedProjectIcon /* None */,
    PPtr<GameObject> m_StatsBlock /* None */,
    PPtr<TextMeshProUGUI> m_ColonyNameLabel /* None */,
    PPtr<TextMeshProUGUI> m_EfficiencyStatValue /* None */,
    PPtr<TextMeshProUGUI> m_ContentmentStatValue /* None */,
    PPtr<TextMeshProUGUI> m_SecurityStatValue /* None */,
    PPtr<GameObject> m_StatsAllColoniesBlock /* None */,
    PPtr<TextMeshProUGUI> m_AllColoniesLabel /* None */,
    PPtr<TextMeshProUGUI> m_EfficiencyStatAllColoniesValue /* None */,
    PPtr<TextMeshProUGUI> m_ContentmentStatAllColoniesValue /* None */,
    PPtr<TextMeshProUGUI> m_SecurityStatAllColoniesValue /* None */,
    PPtr<TextMeshProUGUI> m_LootRewardsLabel /* None */,
    PPtr<GameObject> m_LootBlock /* None */,
    PPtr<GameObject> m_ItemsSubBlock /* None */,
    PPtr<ItemSlotsGroupView> m_SlotsGroup /* None */,
    PPtr<GameObject> m_CargoSubBlock /* None */,
    PPtr<GameObject> m_CargoSeparator /* None */,
    PPtr<WidgetListMVVM> m_WidgetListCargoes /* None */,
    PPtr<CargoRewardSlotView> m_CargoRewardSlotPrefab /* None */,
    PPtr<GameObject> m_OtherRewardsSubBlock /* None */,
    PPtr<GameObject> m_OtherRewardsSeparator /* None */,
    PPtr<WidgetListMVVM> m_WidgetListOtherRewards /* None */,
    PPtr<ColonyRewardsOtherRewardView> m_OtherRewardPrefab /* None */,
    PPtr<OwlcatButton> m_CompleteButton /* None */,
    PPtr<TextMeshProUGUI> m_CompleteButtonLabel /* None */,
    PPtr<LootSlotPCView> m_SlotPrefab /* None */)
{
    public static ColonyRewardsPCView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_HeaderLabel */
        PPtr<TextMeshProUGUI> _m_HeaderLabel = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<GameObject> _m_ColonyRewardBlock = PPtr<GameObject>.Read(reader);
        PPtr<GameObject> _m_FinishedProjectBlock = PPtr<GameObject>.Read(reader);
        PPtr<TextMeshProUGUI> _m_ProjectIsFinishedLabel = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<TextMeshProUGUI> _m_FinishedProjectNameLabel = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<Image> _m_FinishedProjectIcon = PPtr<Image>.Read(reader);
        PPtr<GameObject> _m_StatsBlock = PPtr<GameObject>.Read(reader);
        PPtr<TextMeshProUGUI> _m_ColonyNameLabel = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<TextMeshProUGUI> _m_EfficiencyStatValue = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<TextMeshProUGUI> _m_ContentmentStatValue = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<TextMeshProUGUI> _m_SecurityStatValue = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<GameObject> _m_StatsAllColoniesBlock = PPtr<GameObject>.Read(reader);
        PPtr<TextMeshProUGUI> _m_AllColoniesLabel = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<TextMeshProUGUI> _m_EfficiencyStatAllColoniesValue = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<TextMeshProUGUI> _m_ContentmentStatAllColoniesValue = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<TextMeshProUGUI> _m_SecurityStatAllColoniesValue = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<TextMeshProUGUI> _m_LootRewardsLabel = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<GameObject> _m_LootBlock = PPtr<GameObject>.Read(reader);
        PPtr<GameObject> _m_ItemsSubBlock = PPtr<GameObject>.Read(reader);
        PPtr<ItemSlotsGroupView> _m_SlotsGroup = PPtr<ItemSlotsGroupView>.Read(reader);
        PPtr<GameObject> _m_CargoSubBlock = PPtr<GameObject>.Read(reader);
        PPtr<GameObject> _m_CargoSeparator = PPtr<GameObject>.Read(reader);
        PPtr<WidgetListMVVM> _m_WidgetListCargoes = PPtr<WidgetListMVVM>.Read(reader);
        PPtr<CargoRewardSlotView> _m_CargoRewardSlotPrefab = PPtr<CargoRewardSlotView>.Read(reader);
        PPtr<GameObject> _m_OtherRewardsSubBlock = PPtr<GameObject>.Read(reader);
        PPtr<GameObject> _m_OtherRewardsSeparator = PPtr<GameObject>.Read(reader);
        PPtr<WidgetListMVVM> _m_WidgetListOtherRewards = PPtr<WidgetListMVVM>.Read(reader);
        PPtr<ColonyRewardsOtherRewardView> _m_OtherRewardPrefab = PPtr<ColonyRewardsOtherRewardView>.Read(reader);
        PPtr<OwlcatButton> _m_CompleteButton = PPtr<OwlcatButton>.Read(reader);
        PPtr<TextMeshProUGUI> _m_CompleteButtonLabel = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<LootSlotPCView> _m_SlotPrefab = PPtr<LootSlotPCView>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_HeaderLabel,
            _m_ColonyRewardBlock,
            _m_FinishedProjectBlock,
            _m_ProjectIsFinishedLabel,
            _m_FinishedProjectNameLabel,
            _m_FinishedProjectIcon,
            _m_StatsBlock,
            _m_ColonyNameLabel,
            _m_EfficiencyStatValue,
            _m_ContentmentStatValue,
            _m_SecurityStatValue,
            _m_StatsAllColoniesBlock,
            _m_AllColoniesLabel,
            _m_EfficiencyStatAllColoniesValue,
            _m_ContentmentStatAllColoniesValue,
            _m_SecurityStatAllColoniesValue,
            _m_LootRewardsLabel,
            _m_LootBlock,
            _m_ItemsSubBlock,
            _m_SlotsGroup,
            _m_CargoSubBlock,
            _m_CargoSeparator,
            _m_WidgetListCargoes,
            _m_CargoRewardSlotPrefab,
            _m_OtherRewardsSubBlock,
            _m_OtherRewardsSeparator,
            _m_WidgetListOtherRewards,
            _m_OtherRewardPrefab,
            _m_CompleteButton,
            _m_CompleteButtonLabel,
            _m_SlotPrefab);
    }
}


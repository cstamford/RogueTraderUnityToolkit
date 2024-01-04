namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $VendorTradePartPCView (31 fields) 38B1BDEB0138696FF3FF12A0AFBD110A/C1669332BC4BEB9F3883F5B829728436 */
public record class VendorTradePartPCView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<FadeAnimator> m_FadeAnimator /* NeedsAlign */,
    PPtr<TextMeshProUGUI> m_VendorName /* None */,
    PPtr<Image> m_VendorPortrait /* None */,
    PPtr<GameObject> m_VendorNoPortraitEffect /* None */,
    PPtr<TextMeshProUGUI> m_VendorNoPortraitNoDataText /* None */,
    PPtr<VendorRandomPhrases> m_VendorPhrasesList /* None */,
    PPtr<ScrambledTMP> m_VendorPhrase /* None */,
    PPtr<Image> m_VendorReputationProgressToNextLevel /* None */,
    PPtr<ItemsFilterPCView> m_VendorItemsFilter /* None */,
    PPtr<VendorLevelItemsPCView> m_VendorSlotPrefab /* None */,
    PPtr<WidgetListMVVM> m_WidgetList /* None */,
    PPtr<TextMeshProUGUI> m_ReputationValues /* None */,
    PPtr<TextMeshProUGUI> m_ReputationHeader /* None */,
    PPtr<VendorTransitionWindowPCView> m_TransitionWindowPCView /* None */,
    PPtr<TextMeshProUGUI> m_VendorReputationLevel /* None */,
    PPtr<TextMeshProUGUI> FractionName /* None */,
    PPtr<ScrollRectExtended> m_ScrollRect /* None */,
    PPtr<Image> m_PlayerPortrait /* None */,
    PPtr<TextMeshProUGUI> m_PlayerName /* None */,
    PPtr<TextMeshProUGUI> m_ProfitFactorText /* None */,
    PPtr<TextMeshProUGUI> m_ProfitFactorValue /* None */,
    PPtr<OwlcatMultiButton> m_ProfitFactorBackground /* None */,
    PPtr<GameObject> m_NoItemsToSell /* None */,
    PPtr<TextMeshProUGUI> m_NoItemsToSellText /* None */,
    PPtr<CanvasGroup> m_VendorPhrasesBlock /* None */,
    PPtr<CanvasGroup> m_VendorReputationBlock /* None */,
    PPtr<CanvasGroup> m_VendorBotProfitFactorBlock /* None */)
{
    public static VendorTradePartPCView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_FadeAnimator */
        PPtr<FadeAnimator> _m_FadeAnimator = PPtr<FadeAnimator>.Read(reader);
        PPtr<TextMeshProUGUI> _m_VendorName = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<Image> _m_VendorPortrait = PPtr<Image>.Read(reader);
        PPtr<GameObject> _m_VendorNoPortraitEffect = PPtr<GameObject>.Read(reader);
        PPtr<TextMeshProUGUI> _m_VendorNoPortraitNoDataText = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<VendorRandomPhrases> _m_VendorPhrasesList = PPtr<VendorRandomPhrases>.Read(reader);
        PPtr<ScrambledTMP> _m_VendorPhrase = PPtr<ScrambledTMP>.Read(reader);
        PPtr<Image> _m_VendorReputationProgressToNextLevel = PPtr<Image>.Read(reader);
        PPtr<ItemsFilterPCView> _m_VendorItemsFilter = PPtr<ItemsFilterPCView>.Read(reader);
        PPtr<VendorLevelItemsPCView> _m_VendorSlotPrefab = PPtr<VendorLevelItemsPCView>.Read(reader);
        PPtr<WidgetListMVVM> _m_WidgetList = PPtr<WidgetListMVVM>.Read(reader);
        PPtr<TextMeshProUGUI> _m_ReputationValues = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<TextMeshProUGUI> _m_ReputationHeader = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<VendorTransitionWindowPCView> _m_TransitionWindowPCView = PPtr<VendorTransitionWindowPCView>.Read(reader);
        PPtr<TextMeshProUGUI> _m_VendorReputationLevel = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<TextMeshProUGUI> _FractionName = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<ScrollRectExtended> _m_ScrollRect = PPtr<ScrollRectExtended>.Read(reader);
        PPtr<Image> _m_PlayerPortrait = PPtr<Image>.Read(reader);
        PPtr<TextMeshProUGUI> _m_PlayerName = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<TextMeshProUGUI> _m_ProfitFactorText = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<TextMeshProUGUI> _m_ProfitFactorValue = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<OwlcatMultiButton> _m_ProfitFactorBackground = PPtr<OwlcatMultiButton>.Read(reader);
        PPtr<GameObject> _m_NoItemsToSell = PPtr<GameObject>.Read(reader);
        PPtr<TextMeshProUGUI> _m_NoItemsToSellText = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<CanvasGroup> _m_VendorPhrasesBlock = PPtr<CanvasGroup>.Read(reader);
        PPtr<CanvasGroup> _m_VendorReputationBlock = PPtr<CanvasGroup>.Read(reader);
        PPtr<CanvasGroup> _m_VendorBotProfitFactorBlock = PPtr<CanvasGroup>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_FadeAnimator,
            _m_VendorName,
            _m_VendorPortrait,
            _m_VendorNoPortraitEffect,
            _m_VendorNoPortraitNoDataText,
            _m_VendorPhrasesList,
            _m_VendorPhrase,
            _m_VendorReputationProgressToNextLevel,
            _m_VendorItemsFilter,
            _m_VendorSlotPrefab,
            _m_WidgetList,
            _m_ReputationValues,
            _m_ReputationHeader,
            _m_TransitionWindowPCView,
            _m_VendorReputationLevel,
            _FractionName,
            _m_ScrollRect,
            _m_PlayerPortrait,
            _m_PlayerName,
            _m_ProfitFactorText,
            _m_ProfitFactorValue,
            _m_ProfitFactorBackground,
            _m_NoItemsToSell,
            _m_NoItemsToSellText,
            _m_VendorPhrasesBlock,
            _m_VendorReputationBlock,
            _m_VendorBotProfitFactorBlock);
    }
}


namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $JournalOrderPCView (47 fields) 85CE494E69553D6FBA4885DE0C040CE6/875A13B5B454880360DEDD40BF03EA1E */
public record class JournalOrderPCView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<FadeAnimator> m_FadeAnimator /* NeedsAlign */,
    PPtr<RectTransform> m_HeaderRectTransform /* None */,
    PPtr<RectTransform> m_ContentRectTransform /* None */,
    PPtr<WidgetListMVVM> m_WidgetList /* None */,
    PPtr<JournalQuestObjectivePCView> m_QuestObjectiveViewPrefab /* None */,
    PPtr<TextMeshProUGUI> m_StatusLabel /* None */,
    PPtr<GameObject> m_NewMark /* None */,
    PPtr<GameObject> m_DefaultMark /* None */,
    PPtr<GameObject> m_AlarmMark /* None */,
    PPtr<GameObject> m_FailedMark /* None */,
    PPtr<GameObject> m_CompletedMark /* None */,
    PPtr<GameObject> m_UpdatedMark /* None */,
    PPtr<GameObject> m_PostponedMark /* None */,
    ColorRGBA m_NewColor /* None */,
    ColorRGBA m_DefaultColor /* None */,
    ColorRGBA m_AlarmColor /* None */,
    ColorRGBA m_FailedColor /* None */,
    ColorRGBA m_CompletedColor /* None */,
    ColorRGBA m_UpdatedColor /* None */,
    ColorRGBA m_PostponedColor /* None */,
    PPtr<Image> m_HintPlace /* None */,
    PPtr<ScrambledTMP> m_TitleLabel /* None */,
    PPtr<TextMeshProUGUI> m_PlaceLabel /* None */,
    PPtr<GameObject> m_CompletionItem /* None */,
    PPtr<TextMeshProUGUI> m_CompletionLabel /* None */,
    PPtr<TextMeshProUGUI> m_ServiceMessageLabel /* None */,
    PPtr<TextMeshProUGUI> m_DescriptionLabel /* None */,
    PPtr<ScrollRectExtended> m_ScrollRect /* None */,
    PPtr<GameObject> m_NomosTag /* None */,
    PPtr<GameObject> m_CompletionGroup /* None */,
    PPtr<OwlcatButton> m_CompleteOrderButton /* None */,
    PPtr<TextMeshProUGUI> m_CompleteOrderLabel /* None */,
    PPtr<TextMeshProUGUI> m_RequirementsTitle /* None */,
    PPtr<WidgetListMVVM> m_RequirementsWidgetList /* None */,
    PPtr<ColonyProjectsRequirementElementPCView> m_RequirementsViewPrefab /* None */,
    PPtr<TextMeshProUGUI> m_RewardsTitle /* None */,
    PPtr<WidgetListMVVM> m_RewardsWidgetList /* None */,
    PPtr<ColonyProjectsRewardElementPCView> m_RewardsViewPrefab /* None */,
    PPtr<WidgetListMVVM> m_WidgetListResources /* None */,
    PPtr<TextMeshProUGUI> m_YourResourcesText /* None */,
    PPtr<JournalOrderResourcesPCView> m_JournalOrderResourcesPCViewPrefab /* None */,
    PPtr<JournalOrderProfitFactorPCView> m_JournalOrderProfitFactorPCViewPrefab /* None */,
    float m_DefaultFontSize /* None */)
{
    public static JournalOrderPCView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_FadeAnimator */
        PPtr<FadeAnimator> _m_FadeAnimator = PPtr<FadeAnimator>.Read(reader);
        PPtr<RectTransform> _m_HeaderRectTransform = PPtr<RectTransform>.Read(reader);
        PPtr<RectTransform> _m_ContentRectTransform = PPtr<RectTransform>.Read(reader);
        PPtr<WidgetListMVVM> _m_WidgetList = PPtr<WidgetListMVVM>.Read(reader);
        PPtr<JournalQuestObjectivePCView> _m_QuestObjectiveViewPrefab = PPtr<JournalQuestObjectivePCView>.Read(reader);
        PPtr<TextMeshProUGUI> _m_StatusLabel = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<GameObject> _m_NewMark = PPtr<GameObject>.Read(reader);
        PPtr<GameObject> _m_DefaultMark = PPtr<GameObject>.Read(reader);
        PPtr<GameObject> _m_AlarmMark = PPtr<GameObject>.Read(reader);
        PPtr<GameObject> _m_FailedMark = PPtr<GameObject>.Read(reader);
        PPtr<GameObject> _m_CompletedMark = PPtr<GameObject>.Read(reader);
        PPtr<GameObject> _m_UpdatedMark = PPtr<GameObject>.Read(reader);
        PPtr<GameObject> _m_PostponedMark = PPtr<GameObject>.Read(reader);
        ColorRGBA _m_NewColor = ColorRGBA.Read(reader);
        ColorRGBA _m_DefaultColor = ColorRGBA.Read(reader);
        ColorRGBA _m_AlarmColor = ColorRGBA.Read(reader);
        ColorRGBA _m_FailedColor = ColorRGBA.Read(reader);
        ColorRGBA _m_CompletedColor = ColorRGBA.Read(reader);
        ColorRGBA _m_UpdatedColor = ColorRGBA.Read(reader);
        ColorRGBA _m_PostponedColor = ColorRGBA.Read(reader);
        PPtr<Image> _m_HintPlace = PPtr<Image>.Read(reader);
        PPtr<ScrambledTMP> _m_TitleLabel = PPtr<ScrambledTMP>.Read(reader);
        PPtr<TextMeshProUGUI> _m_PlaceLabel = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<GameObject> _m_CompletionItem = PPtr<GameObject>.Read(reader);
        PPtr<TextMeshProUGUI> _m_CompletionLabel = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<TextMeshProUGUI> _m_ServiceMessageLabel = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<TextMeshProUGUI> _m_DescriptionLabel = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<ScrollRectExtended> _m_ScrollRect = PPtr<ScrollRectExtended>.Read(reader);
        PPtr<GameObject> _m_NomosTag = PPtr<GameObject>.Read(reader);
        PPtr<GameObject> _m_CompletionGroup = PPtr<GameObject>.Read(reader);
        PPtr<OwlcatButton> _m_CompleteOrderButton = PPtr<OwlcatButton>.Read(reader);
        PPtr<TextMeshProUGUI> _m_CompleteOrderLabel = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<TextMeshProUGUI> _m_RequirementsTitle = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<WidgetListMVVM> _m_RequirementsWidgetList = PPtr<WidgetListMVVM>.Read(reader);
        PPtr<ColonyProjectsRequirementElementPCView> _m_RequirementsViewPrefab = PPtr<ColonyProjectsRequirementElementPCView>.Read(reader);
        PPtr<TextMeshProUGUI> _m_RewardsTitle = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<WidgetListMVVM> _m_RewardsWidgetList = PPtr<WidgetListMVVM>.Read(reader);
        PPtr<ColonyProjectsRewardElementPCView> _m_RewardsViewPrefab = PPtr<ColonyProjectsRewardElementPCView>.Read(reader);
        PPtr<WidgetListMVVM> _m_WidgetListResources = PPtr<WidgetListMVVM>.Read(reader);
        PPtr<TextMeshProUGUI> _m_YourResourcesText = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<JournalOrderResourcesPCView> _m_JournalOrderResourcesPCViewPrefab = PPtr<JournalOrderResourcesPCView>.Read(reader);
        PPtr<JournalOrderProfitFactorPCView> _m_JournalOrderProfitFactorPCViewPrefab = PPtr<JournalOrderProfitFactorPCView>.Read(reader);
        float _m_DefaultFontSize = reader.ReadF32();
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_FadeAnimator,
            _m_HeaderRectTransform,
            _m_ContentRectTransform,
            _m_WidgetList,
            _m_QuestObjectiveViewPrefab,
            _m_StatusLabel,
            _m_NewMark,
            _m_DefaultMark,
            _m_AlarmMark,
            _m_FailedMark,
            _m_CompletedMark,
            _m_UpdatedMark,
            _m_PostponedMark,
            _m_NewColor,
            _m_DefaultColor,
            _m_AlarmColor,
            _m_FailedColor,
            _m_CompletedColor,
            _m_UpdatedColor,
            _m_PostponedColor,
            _m_HintPlace,
            _m_TitleLabel,
            _m_PlaceLabel,
            _m_CompletionItem,
            _m_CompletionLabel,
            _m_ServiceMessageLabel,
            _m_DescriptionLabel,
            _m_ScrollRect,
            _m_NomosTag,
            _m_CompletionGroup,
            _m_CompleteOrderButton,
            _m_CompleteOrderLabel,
            _m_RequirementsTitle,
            _m_RequirementsWidgetList,
            _m_RequirementsViewPrefab,
            _m_RewardsTitle,
            _m_RewardsWidgetList,
            _m_RewardsViewPrefab,
            _m_WidgetListResources,
            _m_YourResourcesText,
            _m_JournalOrderResourcesPCViewPrefab,
            _m_JournalOrderProfitFactorPCViewPrefab,
            _m_DefaultFontSize);
    }
}


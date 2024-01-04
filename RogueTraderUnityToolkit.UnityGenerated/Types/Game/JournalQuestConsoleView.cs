namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $JournalQuestConsoleView (36 fields) B115091E210214E99AFFA839181C427B/E180C7E646A384FD377D142D2049C70E */
public record class JournalQuestConsoleView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<FadeAnimator> m_FadeAnimator /* NeedsAlign */,
    PPtr<RectTransform> m_HeaderRectTransform /* None */,
    PPtr<RectTransform> m_ContentRectTransform /* None */,
    PPtr<WidgetListMVVM> m_WidgetList /* None */,
    PPtr<JournalQuestObjectiveConsoleView> m_QuestObjectiveViewPrefab /* None */,
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
    PPtr<ScrollRectExtended> m_ScrollRect /* None */,
    PPtr<ScrambledTMP> m_TitleLabel /* None */,
    PPtr<TextMeshProUGUI> m_PlaceLabel /* None */,
    PPtr<GameObject> m_CompletionItem /* None */,
    PPtr<TextMeshProUGUI> m_CompletionLabel /* None */,
    PPtr<TextMeshProUGUI> m_ServiceMessageLabel /* None */,
    PPtr<TextMeshProUGUI> m_DescriptionLabel /* None */,
    PPtr<GameObject> m_NomosTag /* None */,
    float m_DefaultConsoleFontSize /* None */,
    PPtr<RectTransform> m_LocationGroup /* None */,
    PPtr<RectTransform> m_EagleGroup /* None */,
    PPtr<RectTransform> m_EagleImage /* None */)
{
    public static JournalQuestConsoleView Read(EndianBinaryReader reader)
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
        PPtr<JournalQuestObjectiveConsoleView> _m_QuestObjectiveViewPrefab = PPtr<JournalQuestObjectiveConsoleView>.Read(reader);
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
        PPtr<ScrollRectExtended> _m_ScrollRect = PPtr<ScrollRectExtended>.Read(reader);
        PPtr<ScrambledTMP> _m_TitleLabel = PPtr<ScrambledTMP>.Read(reader);
        PPtr<TextMeshProUGUI> _m_PlaceLabel = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<GameObject> _m_CompletionItem = PPtr<GameObject>.Read(reader);
        PPtr<TextMeshProUGUI> _m_CompletionLabel = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<TextMeshProUGUI> _m_ServiceMessageLabel = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<TextMeshProUGUI> _m_DescriptionLabel = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<GameObject> _m_NomosTag = PPtr<GameObject>.Read(reader);
        float _m_DefaultConsoleFontSize = reader.ReadF32();
        PPtr<RectTransform> _m_LocationGroup = PPtr<RectTransform>.Read(reader);
        PPtr<RectTransform> _m_EagleGroup = PPtr<RectTransform>.Read(reader);
        PPtr<RectTransform> _m_EagleImage = PPtr<RectTransform>.Read(reader);
        
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
            _m_ScrollRect,
            _m_TitleLabel,
            _m_PlaceLabel,
            _m_CompletionItem,
            _m_CompletionLabel,
            _m_ServiceMessageLabel,
            _m_DescriptionLabel,
            _m_NomosTag,
            _m_DefaultConsoleFontSize,
            _m_LocationGroup,
            _m_EagleGroup,
            _m_EagleImage);
    }
}


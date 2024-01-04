namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $JournalNavigationPCView (24 fields) D59C2B2CA195BA4CE7157E9B77E80E25/7AA78FEE5AF596203FA82DFDCF9F1947 */
public record class JournalNavigationPCView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<OwlcatMultiButton> m_QuestsButton /* NeedsAlign */,
    PPtr<OwlcatMultiButton> m_RumorsButton /* None */,
    PPtr<OwlcatMultiButton> m_OrdersButton /* None */,
    PPtr<ScrollRectExtended> m_ScrollRect /* None */,
    PPtr<WidgetListMVVM> m_WidgetList /* None */,
    PPtr<GameObject> m_CurrentQuest /* None */,
    PPtr<GameObject> m_RumoursTitleGO /* None */,
    PPtr<GameObject> m_RumoursAboutUsButtonGO /* None */,
    PPtr<TextMeshProUGUI> m_RumoursTitleText /* None */,
    PPtr<TextMeshProUGUI> m_RumoursAboutUsTitleText /* None */,
    PPtr<RectTransform> m_ReadyToCompleteOrderImage /* None */,
    PPtr<RectTransform> m_CannotAccessContractsImage /* None */,
    PPtr<RectTransform> m_EmptyListObject /* None */,
    PPtr<TextMeshProUGUI> m_EmptyListLabel /* None */,
    PPtr<JournalNavigationGroupPCView> m_NavigationGroupViewPrefab /* None */,
    PPtr<JournalNavigationGroupElementPCView> m_NavigationRumorViewPrefab /* None */,
    PPtr<JournalNavigationGroupElementPCView> m_NavigationOrderViewPrefab /* None */,
    PPtr<OwlcatToggle> m_ShowCompleteToggle /* None */,
    PPtr<TextMeshProUGUI> m_ShowCompleteLabel /* None */,
    PPtr<RectTransform> m_PaperTransform /* None */)
{
    public static JournalNavigationPCView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_QuestsButton */
        PPtr<OwlcatMultiButton> _m_QuestsButton = PPtr<OwlcatMultiButton>.Read(reader);
        PPtr<OwlcatMultiButton> _m_RumorsButton = PPtr<OwlcatMultiButton>.Read(reader);
        PPtr<OwlcatMultiButton> _m_OrdersButton = PPtr<OwlcatMultiButton>.Read(reader);
        PPtr<ScrollRectExtended> _m_ScrollRect = PPtr<ScrollRectExtended>.Read(reader);
        PPtr<WidgetListMVVM> _m_WidgetList = PPtr<WidgetListMVVM>.Read(reader);
        PPtr<GameObject> _m_CurrentQuest = PPtr<GameObject>.Read(reader);
        PPtr<GameObject> _m_RumoursTitleGO = PPtr<GameObject>.Read(reader);
        PPtr<GameObject> _m_RumoursAboutUsButtonGO = PPtr<GameObject>.Read(reader);
        PPtr<TextMeshProUGUI> _m_RumoursTitleText = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<TextMeshProUGUI> _m_RumoursAboutUsTitleText = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<RectTransform> _m_ReadyToCompleteOrderImage = PPtr<RectTransform>.Read(reader);
        PPtr<RectTransform> _m_CannotAccessContractsImage = PPtr<RectTransform>.Read(reader);
        PPtr<RectTransform> _m_EmptyListObject = PPtr<RectTransform>.Read(reader);
        PPtr<TextMeshProUGUI> _m_EmptyListLabel = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<JournalNavigationGroupPCView> _m_NavigationGroupViewPrefab = PPtr<JournalNavigationGroupPCView>.Read(reader);
        PPtr<JournalNavigationGroupElementPCView> _m_NavigationRumorViewPrefab = PPtr<JournalNavigationGroupElementPCView>.Read(reader);
        PPtr<JournalNavigationGroupElementPCView> _m_NavigationOrderViewPrefab = PPtr<JournalNavigationGroupElementPCView>.Read(reader);
        PPtr<OwlcatToggle> _m_ShowCompleteToggle = PPtr<OwlcatToggle>.Read(reader);
        PPtr<TextMeshProUGUI> _m_ShowCompleteLabel = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<RectTransform> _m_PaperTransform = PPtr<RectTransform>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_QuestsButton,
            _m_RumorsButton,
            _m_OrdersButton,
            _m_ScrollRect,
            _m_WidgetList,
            _m_CurrentQuest,
            _m_RumoursTitleGO,
            _m_RumoursAboutUsButtonGO,
            _m_RumoursTitleText,
            _m_RumoursAboutUsTitleText,
            _m_ReadyToCompleteOrderImage,
            _m_CannotAccessContractsImage,
            _m_EmptyListObject,
            _m_EmptyListLabel,
            _m_NavigationGroupViewPrefab,
            _m_NavigationRumorViewPrefab,
            _m_NavigationOrderViewPrefab,
            _m_ShowCompleteToggle,
            _m_ShowCompleteLabel,
            _m_PaperTransform);
    }
}


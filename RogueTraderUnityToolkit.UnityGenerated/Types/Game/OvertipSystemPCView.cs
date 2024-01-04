namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $OvertipSystemPCView (20 fields) 259030B59A3D4905E123A83E785E49FA/E78C2E8F57D756540CEA3A6A92E3F57F */
public record class OvertipSystemPCView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<TextMeshProUGUI> m_PlusNavigatorResourceObject /* NeedsAlign */,
    PPtr<FadeAnimator> m_PlusNavigatorResourceAimator /* None */,
    PPtr<OvertipSystemResourceBlockView> m_ResourceBlockView /* None */,
    PPtr<Image> m_ColonizedIcon /* None */,
    PPtr<Image> m_QuestIcon /* None */,
    PPtr<TextMeshProUGUI> m_SystemName /* None */,
    PPtr<FadeAnimator> m_CircleBackgroundAnimator /* None */,
    PPtr<FadeAnimator> m_CircleBackgroundMiniAnimator /* None */,
    PPtr<OwlcatButton> m_InfoButton /* None */,
    PPtr<OwlcatButton> m_TravelButton /* None */,
    PPtr<OwlcatButton> m_VisitButton /* None */,
    PPtr<TextMeshProUGUI> m_VisitButtonLabel /* None */,
    PPtr<OwlcatButton> m_CoopPingForAnotherPlayersButton /* None */,
    PPtr<SpaceSystemNavigationButtonsPCView> m_SpaceSystemNavigationButtonsPCView /* None */,
    PPtr<RectTransform> m_TooltipPlace /* None */,
    Vector2f[] m_PriorityPivots /* None */)
{
    public static OvertipSystemPCView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_PlusNavigatorResourceObject */
        PPtr<TextMeshProUGUI> _m_PlusNavigatorResourceObject = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<FadeAnimator> _m_PlusNavigatorResourceAimator = PPtr<FadeAnimator>.Read(reader);
        PPtr<OvertipSystemResourceBlockView> _m_ResourceBlockView = PPtr<OvertipSystemResourceBlockView>.Read(reader);
        PPtr<Image> _m_ColonizedIcon = PPtr<Image>.Read(reader);
        PPtr<Image> _m_QuestIcon = PPtr<Image>.Read(reader);
        PPtr<TextMeshProUGUI> _m_SystemName = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<FadeAnimator> _m_CircleBackgroundAnimator = PPtr<FadeAnimator>.Read(reader);
        PPtr<FadeAnimator> _m_CircleBackgroundMiniAnimator = PPtr<FadeAnimator>.Read(reader);
        PPtr<OwlcatButton> _m_InfoButton = PPtr<OwlcatButton>.Read(reader);
        PPtr<OwlcatButton> _m_TravelButton = PPtr<OwlcatButton>.Read(reader);
        PPtr<OwlcatButton> _m_VisitButton = PPtr<OwlcatButton>.Read(reader);
        PPtr<TextMeshProUGUI> _m_VisitButtonLabel = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<OwlcatButton> _m_CoopPingForAnotherPlayersButton = PPtr<OwlcatButton>.Read(reader);
        PPtr<SpaceSystemNavigationButtonsPCView> _m_SpaceSystemNavigationButtonsPCView = PPtr<SpaceSystemNavigationButtonsPCView>.Read(reader);
        PPtr<RectTransform> _m_TooltipPlace = PPtr<RectTransform>.Read(reader);
        Vector2f[] _m_PriorityPivots = BuiltInArray<Vector2f>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_PlusNavigatorResourceObject,
            _m_PlusNavigatorResourceAimator,
            _m_ResourceBlockView,
            _m_ColonizedIcon,
            _m_QuestIcon,
            _m_SystemName,
            _m_CircleBackgroundAnimator,
            _m_CircleBackgroundMiniAnimator,
            _m_InfoButton,
            _m_TravelButton,
            _m_VisitButton,
            _m_VisitButtonLabel,
            _m_CoopPingForAnotherPlayersButton,
            _m_SpaceSystemNavigationButtonsPCView,
            _m_TooltipPlace,
            _m_PriorityPivots);
    }
}


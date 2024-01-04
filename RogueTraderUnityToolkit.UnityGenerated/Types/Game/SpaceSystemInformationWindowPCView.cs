namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $SpaceSystemInformationWindowPCView (24 fields) 915E7A5D8ABAA50F37796DCB8727447B/6239746887BED3B998FDF880B322EB73 */
public record class SpaceSystemInformationWindowPCView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<TextMeshProUGUI> m_SystemName /* NeedsAlign */,
    PPtr<Image> m_SystemImage /* None */,
    PPtr<Sprite> m_UnvisitedSystemSprite /* None */,
    PPtr<Sprite> m_VisitedSystemSprite /* None */,
    PPtr<TextMeshProUGUI> m_NoDataText /* None */,
    PPtr<TextMeshProUGUI> m_ColonizeText /* None */,
    PPtr<TextMeshProUGUI> m_QuestName /* None */,
    PPtr<TextMeshProUGUI> m_VisitedStatus /* None */,
    PPtr<TextMeshProUGUI> m_SpaceCombatInfoText /* None */,
    float m_ShowPosX /* None */,
    float m_HidePosX /* None */,
    PPtr<TextMeshProUGUI> m_PlanetsLabel /* None */,
    PPtr<WidgetListMVVM> m_WidgetList /* None */,
    PPtr<PlanetInfoSpaceSystemInformationWindowView> PlanetInfoSpaceSystemInformationWindowViewPrefab /* None */,
    PPtr<RectTransform> m_TooltipPlace /* None */,
    PPtr<TextMeshProUGUI> m_OtherObjectsLabel /* None */,
    PPtr<WidgetListMVVM> m_WidgetListOtherObjects /* None */,
    PPtr<OtherObjectsInfoSpaceSystemInformationWindowView> OtherObjectsInfoSpaceSystemInformationWindowViewPrefab /* None */,
    PPtr<ScrollRectExtended> m_ScrollRectExtended /* None */,
    PPtr<OwlcatButton> m_CloseButton /* None */)
{
    public static SpaceSystemInformationWindowPCView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_SystemName */
        PPtr<TextMeshProUGUI> _m_SystemName = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<Image> _m_SystemImage = PPtr<Image>.Read(reader);
        PPtr<Sprite> _m_UnvisitedSystemSprite = PPtr<Sprite>.Read(reader);
        PPtr<Sprite> _m_VisitedSystemSprite = PPtr<Sprite>.Read(reader);
        PPtr<TextMeshProUGUI> _m_NoDataText = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<TextMeshProUGUI> _m_ColonizeText = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<TextMeshProUGUI> _m_QuestName = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<TextMeshProUGUI> _m_VisitedStatus = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<TextMeshProUGUI> _m_SpaceCombatInfoText = PPtr<TextMeshProUGUI>.Read(reader);
        float _m_ShowPosX = reader.ReadF32();
        float _m_HidePosX = reader.ReadF32();
        PPtr<TextMeshProUGUI> _m_PlanetsLabel = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<WidgetListMVVM> _m_WidgetList = PPtr<WidgetListMVVM>.Read(reader);
        PPtr<PlanetInfoSpaceSystemInformationWindowView> _PlanetInfoSpaceSystemInformationWindowViewPrefab = PPtr<PlanetInfoSpaceSystemInformationWindowView>.Read(reader);
        PPtr<RectTransform> _m_TooltipPlace = PPtr<RectTransform>.Read(reader);
        PPtr<TextMeshProUGUI> _m_OtherObjectsLabel = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<WidgetListMVVM> _m_WidgetListOtherObjects = PPtr<WidgetListMVVM>.Read(reader);
        PPtr<OtherObjectsInfoSpaceSystemInformationWindowView> _OtherObjectsInfoSpaceSystemInformationWindowViewPrefab = PPtr<OtherObjectsInfoSpaceSystemInformationWindowView>.Read(reader);
        PPtr<ScrollRectExtended> _m_ScrollRectExtended = PPtr<ScrollRectExtended>.Read(reader);
        PPtr<OwlcatButton> _m_CloseButton = PPtr<OwlcatButton>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_SystemName,
            _m_SystemImage,
            _m_UnvisitedSystemSprite,
            _m_VisitedSystemSprite,
            _m_NoDataText,
            _m_ColonizeText,
            _m_QuestName,
            _m_VisitedStatus,
            _m_SpaceCombatInfoText,
            _m_ShowPosX,
            _m_HidePosX,
            _m_PlanetsLabel,
            _m_WidgetList,
            _PlanetInfoSpaceSystemInformationWindowViewPrefab,
            _m_TooltipPlace,
            _m_OtherObjectsLabel,
            _m_WidgetListOtherObjects,
            _OtherObjectsInfoSpaceSystemInformationWindowViewPrefab,
            _m_ScrollRectExtended,
            _m_CloseButton);
    }
}


namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $OvertipPlanetConsoleView (26 fields) 65E454601CAD9886CB905D6675424E5F/E35CA18A44328F3DE045926CE3B521F5 */
public record class OvertipPlanetConsoleView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<OwlcatButton> m_PlanetButton /* NeedsAlign */,
    PPtr<TextMeshProUGUI> m_PlanetNameLabel /* None */,
    PPtr<Image> m_UnknownPlanetNameImage /* None */,
    PPtr<RectTransform> m_StateIconCanvas /* None */,
    PPtr<Image> m_ColonizeStateIcon /* None */,
    PPtr<Image> m_QuestStateIcon /* None */,
    PPtr<Image> m_ResourceStateIcon /* None */,
    PPtr<Image> m_PoiStateIcon /* None */,
    PPtr<Image> m_RumourStateIcon /* None */,
    PPtr<Image> m_NotExploredStateIcon /* None */,
    PPtr<RectTransform> m_CanvasRectTransform /* None */,
    PPtr<Image> m_TooltipTaker /* None */,
    PPtr<OwlcatSelectable> m_ResourceIconSelectable /* None */,
    PPtr<FadeAnimator> m_ResourceCustomHint /* None */,
    PPtr<WidgetListMVVM> m_WidgetList /* None */,
    PPtr<SystemMapPlanetResourcesPCView> m_SystemMapPlanetResourcesPCViewPrefab /* None */,
    PPtr<FadeAnimator> m_TargetPingEntity /* None */,
    PPtr<Image> m_NoiseAroundImage /* None */,
    PPtr<Sprite>[] m_RandomNoises /* None */,
    PPtr<Image> m_BottomImage /* None */,
    PPtr<Sprite>[] m_RandomBottomSprites /* None */,
    PPtr<TextMeshProUGUI> m_TopInformation /* None */)
{
    public static OvertipPlanetConsoleView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_PlanetButton */
        PPtr<OwlcatButton> _m_PlanetButton = PPtr<OwlcatButton>.Read(reader);
        PPtr<TextMeshProUGUI> _m_PlanetNameLabel = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<Image> _m_UnknownPlanetNameImage = PPtr<Image>.Read(reader);
        PPtr<RectTransform> _m_StateIconCanvas = PPtr<RectTransform>.Read(reader);
        PPtr<Image> _m_ColonizeStateIcon = PPtr<Image>.Read(reader);
        PPtr<Image> _m_QuestStateIcon = PPtr<Image>.Read(reader);
        PPtr<Image> _m_ResourceStateIcon = PPtr<Image>.Read(reader);
        PPtr<Image> _m_PoiStateIcon = PPtr<Image>.Read(reader);
        PPtr<Image> _m_RumourStateIcon = PPtr<Image>.Read(reader);
        PPtr<Image> _m_NotExploredStateIcon = PPtr<Image>.Read(reader);
        PPtr<RectTransform> _m_CanvasRectTransform = PPtr<RectTransform>.Read(reader);
        PPtr<Image> _m_TooltipTaker = PPtr<Image>.Read(reader);
        PPtr<OwlcatSelectable> _m_ResourceIconSelectable = PPtr<OwlcatSelectable>.Read(reader);
        PPtr<FadeAnimator> _m_ResourceCustomHint = PPtr<FadeAnimator>.Read(reader);
        PPtr<WidgetListMVVM> _m_WidgetList = PPtr<WidgetListMVVM>.Read(reader);
        PPtr<SystemMapPlanetResourcesPCView> _m_SystemMapPlanetResourcesPCViewPrefab = PPtr<SystemMapPlanetResourcesPCView>.Read(reader);
        PPtr<FadeAnimator> _m_TargetPingEntity = PPtr<FadeAnimator>.Read(reader);
        PPtr<Image> _m_NoiseAroundImage = PPtr<Image>.Read(reader);
        PPtr<Sprite>[] _m_RandomNoises = BuiltInArray<PPtr<Sprite>>.Read(reader);
        PPtr<Image> _m_BottomImage = PPtr<Image>.Read(reader);
        PPtr<Sprite>[] _m_RandomBottomSprites = BuiltInArray<PPtr<Sprite>>.Read(reader);
        PPtr<TextMeshProUGUI> _m_TopInformation = PPtr<TextMeshProUGUI>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_PlanetButton,
            _m_PlanetNameLabel,
            _m_UnknownPlanetNameImage,
            _m_StateIconCanvas,
            _m_ColonizeStateIcon,
            _m_QuestStateIcon,
            _m_ResourceStateIcon,
            _m_PoiStateIcon,
            _m_RumourStateIcon,
            _m_NotExploredStateIcon,
            _m_CanvasRectTransform,
            _m_TooltipTaker,
            _m_ResourceIconSelectable,
            _m_ResourceCustomHint,
            _m_WidgetList,
            _m_SystemMapPlanetResourcesPCViewPrefab,
            _m_TargetPingEntity,
            _m_NoiseAroundImage,
            _m_RandomNoises,
            _m_BottomImage,
            _m_RandomBottomSprites,
            _m_TopInformation);
    }
}


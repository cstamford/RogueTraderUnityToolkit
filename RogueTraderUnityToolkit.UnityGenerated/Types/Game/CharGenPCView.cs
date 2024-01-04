namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $CharGenPCView (24 fields) A7B285C79E06DB86DE226DD21600F7EC/7359DC5B1723F4F9241FA48FBEB33A13 */
public record class CharGenPCView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<CanvasGroup> m_CanvasGroup /* NeedsAlign */,
    PPtr<CharGenRoadmapMenuView> RoadmapMenuView /* None */,
    CharGenPhaseDetailedViewsFactory DetailedViewsFactory /* None */,
    PPtr<CharGenPortraitView> m_PortraitView /* None */,
    PPtr<CharGenPortraitView> m_PortraitFullView /* None */,
    PPtr<PantographView> m_PantographView /* None */,
    PPtr<RectTransform> m_PantographPosition /* None */,
    PPtr<DollRoomTargetController> m_CharacterController /* None */,
    PPtr<FadeAnimator> m_CharacterDollTexture /* None */,
    PPtr<DollRoomTargetController> m_ShipController /* None */,
    PPtr<FadeAnimator> m_ShipDollTexture /* None */,
    PPtr<RectTransform> m_DollTransform /* None */,
    DollPosition m_DollPositions /* None */,
    PPtr<OwlcatButton> m_VisualSettingsViewButton /* None */,
    PPtr<CharacterVisualSettingsPCView> m_VisualSettingsPCView /* None */,
    PPtr<OwlcatButton> m_CloseButton /* None */,
    PPtr<OwlcatButton> m_NextButton /* None */,
    PPtr<TextMeshProUGUI> m_NextButtonLabel /* None */,
    PPtr<OwlcatButton> m_BackButton /* None */,
    PPtr<TextMeshProUGUI> m_BackButtonLabel /* None */)
{
    public static CharGenPCView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_CanvasGroup */
        PPtr<CanvasGroup> _m_CanvasGroup = PPtr<CanvasGroup>.Read(reader);
        PPtr<CharGenRoadmapMenuView> _RoadmapMenuView = PPtr<CharGenRoadmapMenuView>.Read(reader);
        CharGenPhaseDetailedViewsFactory _DetailedViewsFactory = CharGenPhaseDetailedViewsFactory.Read(reader);
        PPtr<CharGenPortraitView> _m_PortraitView = PPtr<CharGenPortraitView>.Read(reader);
        PPtr<CharGenPortraitView> _m_PortraitFullView = PPtr<CharGenPortraitView>.Read(reader);
        PPtr<PantographView> _m_PantographView = PPtr<PantographView>.Read(reader);
        PPtr<RectTransform> _m_PantographPosition = PPtr<RectTransform>.Read(reader);
        PPtr<DollRoomTargetController> _m_CharacterController = PPtr<DollRoomTargetController>.Read(reader);
        PPtr<FadeAnimator> _m_CharacterDollTexture = PPtr<FadeAnimator>.Read(reader);
        PPtr<DollRoomTargetController> _m_ShipController = PPtr<DollRoomTargetController>.Read(reader);
        PPtr<FadeAnimator> _m_ShipDollTexture = PPtr<FadeAnimator>.Read(reader);
        PPtr<RectTransform> _m_DollTransform = PPtr<RectTransform>.Read(reader);
        DollPosition _m_DollPositions = DollPosition.Read(reader);
        PPtr<OwlcatButton> _m_VisualSettingsViewButton = PPtr<OwlcatButton>.Read(reader);
        PPtr<CharacterVisualSettingsPCView> _m_VisualSettingsPCView = PPtr<CharacterVisualSettingsPCView>.Read(reader);
        PPtr<OwlcatButton> _m_CloseButton = PPtr<OwlcatButton>.Read(reader);
        PPtr<OwlcatButton> _m_NextButton = PPtr<OwlcatButton>.Read(reader);
        PPtr<TextMeshProUGUI> _m_NextButtonLabel = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<OwlcatButton> _m_BackButton = PPtr<OwlcatButton>.Read(reader);
        PPtr<TextMeshProUGUI> _m_BackButtonLabel = PPtr<TextMeshProUGUI>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_CanvasGroup,
            _RoadmapMenuView,
            _DetailedViewsFactory,
            _m_PortraitView,
            _m_PortraitFullView,
            _m_PantographView,
            _m_PantographPosition,
            _m_CharacterController,
            _m_CharacterDollTexture,
            _m_ShipController,
            _m_ShipDollTexture,
            _m_DollTransform,
            _m_DollPositions,
            _m_VisualSettingsViewButton,
            _m_VisualSettingsPCView,
            _m_CloseButton,
            _m_NextButton,
            _m_NextButtonLabel,
            _m_BackButton,
            _m_BackButtonLabel);
    }
}


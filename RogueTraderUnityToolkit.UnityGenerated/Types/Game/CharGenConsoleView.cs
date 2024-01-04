namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $CharGenConsoleView (28 fields) A520870895475016E4F708421F941A7E/580DCEA0B7E28B146EC5F763AB968C82 */
public record class CharGenConsoleView(
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
    DollPosition[] m_DollPositions /* None */,
    float m_RotateFactor /* None */,
    float m_ZoomFactor /* None */,
    float m_ZoomThresholdValue /* None */,
    PPtr<ConsoleHint> m_ConfirmHint /* None */,
    PPtr<ConsoleHint> m_NextPhaseHint /* None */,
    PPtr<ConsoleHint> m_DeclineHint /* None */,
    PPtr<ConsoleHint> m_PreviousPhaseHint /* None */,
    PPtr<ConsoleHint> m_VisualSettingsHint /* None */,
    PPtr<CharacterVisualSettingsConsoleView> m_VisualSettingsConsoleView /* None */,
    PPtr<ConsoleHint> m_FullPortraitHint /* None */,
    PPtr<ConsoleHintsWidget> m_HintsWidget /* None */)
{
    public static CharGenConsoleView Read(EndianBinaryReader reader)
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
        DollPosition[] _m_DollPositions = BuiltInArray<DollPosition>.Read(reader);
        float _m_RotateFactor = reader.ReadF32();
        float _m_ZoomFactor = reader.ReadF32();
        float _m_ZoomThresholdValue = reader.ReadF32();
        PPtr<ConsoleHint> _m_ConfirmHint = PPtr<ConsoleHint>.Read(reader);
        PPtr<ConsoleHint> _m_NextPhaseHint = PPtr<ConsoleHint>.Read(reader);
        PPtr<ConsoleHint> _m_DeclineHint = PPtr<ConsoleHint>.Read(reader);
        PPtr<ConsoleHint> _m_PreviousPhaseHint = PPtr<ConsoleHint>.Read(reader);
        PPtr<ConsoleHint> _m_VisualSettingsHint = PPtr<ConsoleHint>.Read(reader);
        PPtr<CharacterVisualSettingsConsoleView> _m_VisualSettingsConsoleView = PPtr<CharacterVisualSettingsConsoleView>.Read(reader);
        PPtr<ConsoleHint> _m_FullPortraitHint = PPtr<ConsoleHint>.Read(reader);
        PPtr<ConsoleHintsWidget> _m_HintsWidget = PPtr<ConsoleHintsWidget>.Read(reader);
        
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
            _m_RotateFactor,
            _m_ZoomFactor,
            _m_ZoomThresholdValue,
            _m_ConfirmHint,
            _m_NextPhaseHint,
            _m_DeclineHint,
            _m_PreviousPhaseHint,
            _m_VisualSettingsHint,
            _m_VisualSettingsConsoleView,
            _m_FullPortraitHint,
            _m_HintsWidget);
    }
}


namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $LocalMapConsoleView (34 fields) 1F0E67CE1E600FCFAC9DFA1AFDEEA1B6/B5CC6569E55C3BC6883578EA2011E063 */
public record class LocalMapConsoleView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<ScrambledTMP> m_Title /* NeedsAlign */,
    PPtr<RawImage> m_Image /* None */,
    PPtr<RectTransform> m_FrameBlock /* None */,
    PPtr<RectTransform> m_Frame /* None */,
    PPtr<RectTransform> m_LittleSkullCamera /* None */,
    Vector2f MaxSize /* None */,
    LocalMapMarkerSet[] m_MarkerSets /* None */,
    PPtr<TextMeshProUGUI> m_TitleLabelMap /* None */,
    PPtr<OwlcatButton> m_MapHistoryButton /* None */,
    PPtr<LocalMapLegendBlockView> m_LegendBlockView /* None */,
    PPtr<RectTransform> m_MapHistoryLittleSquare /* None */,
    float m_ZoomStep /* None */,
    float m_ZoomMaxSize /* None */,
    float m_ZoomMinSize /* None */,
    float m_MoveMapSpeed /* None */,
    float m_MoveMapFrame /* None */,
    PPtr<RectTransform> m_MapBlock /* None */,
    PPtr<RectTransform>[] m_MarkersNeedToShowAlways /* None */,
    PPtr<FadeAnimator> m_TargetPingEntity /* None */,
    Vector2f m_CorrectTargetPositionPoint /* None */,
    float m_CorrectBiggerX /* None */,
    float m_CorrectBiggerMinusX /* None */,
    float m_CorrectBiggerY /* None */,
    float m_CorrectBiggerMinusY /* None */,
    float m_StickCameraMoveFactor /* None */,
    float m_StickCursorFactor /* None */,
    float m_StickMapDragFactor /* None */,
    PPtr<ConsoleHintsWidget> m_ConsoleHintsWidget /* None */,
    PPtr<ConsoleHint> m_OpenLegendHint /* None */,
    PPtr<ConsoleHint> m_HideLegendHint /* None */)
{
    public static LocalMapConsoleView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_Title */
        PPtr<ScrambledTMP> _m_Title = PPtr<ScrambledTMP>.Read(reader);
        PPtr<RawImage> _m_Image = PPtr<RawImage>.Read(reader);
        PPtr<RectTransform> _m_FrameBlock = PPtr<RectTransform>.Read(reader);
        PPtr<RectTransform> _m_Frame = PPtr<RectTransform>.Read(reader);
        PPtr<RectTransform> _m_LittleSkullCamera = PPtr<RectTransform>.Read(reader);
        Vector2f _MaxSize = Vector2f.Read(reader);
        LocalMapMarkerSet[] _m_MarkerSets = BuiltInArray<LocalMapMarkerSet>.Read(reader);
        PPtr<TextMeshProUGUI> _m_TitleLabelMap = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<OwlcatButton> _m_MapHistoryButton = PPtr<OwlcatButton>.Read(reader);
        PPtr<LocalMapLegendBlockView> _m_LegendBlockView = PPtr<LocalMapLegendBlockView>.Read(reader);
        PPtr<RectTransform> _m_MapHistoryLittleSquare = PPtr<RectTransform>.Read(reader);
        float _m_ZoomStep = reader.ReadF32();
        float _m_ZoomMaxSize = reader.ReadF32();
        float _m_ZoomMinSize = reader.ReadF32();
        float _m_MoveMapSpeed = reader.ReadF32();
        float _m_MoveMapFrame = reader.ReadF32();
        PPtr<RectTransform> _m_MapBlock = PPtr<RectTransform>.Read(reader);
        PPtr<RectTransform>[] _m_MarkersNeedToShowAlways = BuiltInArray<PPtr<RectTransform>>.Read(reader);
        PPtr<FadeAnimator> _m_TargetPingEntity = PPtr<FadeAnimator>.Read(reader);
        Vector2f _m_CorrectTargetPositionPoint = Vector2f.Read(reader);
        float _m_CorrectBiggerX = reader.ReadF32();
        float _m_CorrectBiggerMinusX = reader.ReadF32();
        float _m_CorrectBiggerY = reader.ReadF32();
        float _m_CorrectBiggerMinusY = reader.ReadF32();
        float _m_StickCameraMoveFactor = reader.ReadF32();
        float _m_StickCursorFactor = reader.ReadF32();
        float _m_StickMapDragFactor = reader.ReadF32();
        PPtr<ConsoleHintsWidget> _m_ConsoleHintsWidget = PPtr<ConsoleHintsWidget>.Read(reader);
        PPtr<ConsoleHint> _m_OpenLegendHint = PPtr<ConsoleHint>.Read(reader);
        PPtr<ConsoleHint> _m_HideLegendHint = PPtr<ConsoleHint>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_Title,
            _m_Image,
            _m_FrameBlock,
            _m_Frame,
            _m_LittleSkullCamera,
            _MaxSize,
            _m_MarkerSets,
            _m_TitleLabelMap,
            _m_MapHistoryButton,
            _m_LegendBlockView,
            _m_MapHistoryLittleSquare,
            _m_ZoomStep,
            _m_ZoomMaxSize,
            _m_ZoomMinSize,
            _m_MoveMapSpeed,
            _m_MoveMapFrame,
            _m_MapBlock,
            _m_MarkersNeedToShowAlways,
            _m_TargetPingEntity,
            _m_CorrectTargetPositionPoint,
            _m_CorrectBiggerX,
            _m_CorrectBiggerMinusX,
            _m_CorrectBiggerY,
            _m_CorrectBiggerMinusY,
            _m_StickCameraMoveFactor,
            _m_StickCursorFactor,
            _m_StickMapDragFactor,
            _m_ConsoleHintsWidget,
            _m_OpenLegendHint,
            _m_HideLegendHint);
    }
}


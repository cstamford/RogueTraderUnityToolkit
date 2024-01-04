namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $SurfaceDynamicPartConsoleView (12 fields) 95C38E9EA9EBC17B53DF0F5F70BB27DD/8F0CEE908A7D93D4B69CE20333E67F72 */
public record class SurfaceDynamicPartConsoleView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<UIVisibilityView> m_UIVisibilityDynamicView /* NeedsAlign */,
    PPtr<CanvasGroup> m_DynamicCanvasGroup /* None */,
    PPtr<UIVisibilityView> m_UIVisibilityPointerView /* None */,
    PPtr<VariativeInteractionConsoleView> m_VariativeInteractionView /* None */,
    PPtr<SurfaceOvertipsConsoleView> m_SurfaceOvertipsView /* None */,
    PPtr<PointMarkersPCView> m_PointMarkersPCView /* None */,
    PPtr<ConsoleCursor> m_ConsoleCursor /* None */,
    PPtr<CanvasScalerWorkaround> m_DynamicCanvasScalerWorkaround /* None */)
{
    public static SurfaceDynamicPartConsoleView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_UIVisibilityDynamicView */
        PPtr<UIVisibilityView> _m_UIVisibilityDynamicView = PPtr<UIVisibilityView>.Read(reader);
        PPtr<CanvasGroup> _m_DynamicCanvasGroup = PPtr<CanvasGroup>.Read(reader);
        PPtr<UIVisibilityView> _m_UIVisibilityPointerView = PPtr<UIVisibilityView>.Read(reader);
        PPtr<VariativeInteractionConsoleView> _m_VariativeInteractionView = PPtr<VariativeInteractionConsoleView>.Read(reader);
        PPtr<SurfaceOvertipsConsoleView> _m_SurfaceOvertipsView = PPtr<SurfaceOvertipsConsoleView>.Read(reader);
        PPtr<PointMarkersPCView> _m_PointMarkersPCView = PPtr<PointMarkersPCView>.Read(reader);
        PPtr<ConsoleCursor> _m_ConsoleCursor = PPtr<ConsoleCursor>.Read(reader);
        PPtr<CanvasScalerWorkaround> _m_DynamicCanvasScalerWorkaround = PPtr<CanvasScalerWorkaround>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_UIVisibilityDynamicView,
            _m_DynamicCanvasGroup,
            _m_UIVisibilityPointerView,
            _m_VariativeInteractionView,
            _m_SurfaceOvertipsView,
            _m_PointMarkersPCView,
            _m_ConsoleCursor,
            _m_DynamicCanvasScalerWorkaround);
    }
}


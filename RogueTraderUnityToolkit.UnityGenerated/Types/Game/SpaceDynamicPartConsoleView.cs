namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $SpaceDynamicPartConsoleView (11 fields) CAD7AA586D415D8A32D4B1CD765FCFB3/6957E89686BD349D53D6B092946386FB */
public record class SpaceDynamicPartConsoleView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<UIVisibilityView> m_UIVisibilityDynamicView /* NeedsAlign */,
    PPtr<CanvasGroup> m_DynamicCanvasGroup /* None */,
    PPtr<UIVisibilityView> m_UIVisibilityPointerView /* None */,
    PPtr<SpaceOvertipsConsoleView> m_SpaceOvertipsConsoleView /* None */,
    PPtr<PointMarkersPCView> m_SpaceCombatPointMarkersPCView /* None */,
    PPtr<ConsoleCursor> m_ConsoleCursor /* None */,
    PPtr<CanvasScalerWorkaround> m_DynamicCanvasScalerWorkaround /* None */)
{
    public static SpaceDynamicPartConsoleView Read(EndianBinaryReader reader)
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
        PPtr<SpaceOvertipsConsoleView> _m_SpaceOvertipsConsoleView = PPtr<SpaceOvertipsConsoleView>.Read(reader);
        PPtr<PointMarkersPCView> _m_SpaceCombatPointMarkersPCView = PPtr<PointMarkersPCView>.Read(reader);
        PPtr<ConsoleCursor> _m_ConsoleCursor = PPtr<ConsoleCursor>.Read(reader);
        PPtr<CanvasScalerWorkaround> _m_DynamicCanvasScalerWorkaround = PPtr<CanvasScalerWorkaround>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_UIVisibilityDynamicView,
            _m_DynamicCanvasGroup,
            _m_UIVisibilityPointerView,
            _m_SpaceOvertipsConsoleView,
            _m_SpaceCombatPointMarkersPCView,
            _m_ConsoleCursor,
            _m_DynamicCanvasScalerWorkaround);
    }
}


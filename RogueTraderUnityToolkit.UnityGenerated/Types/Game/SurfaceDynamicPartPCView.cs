namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $SurfaceDynamicPartPCView (11 fields) DD148178F834D0E907C4EA835E1BF63B/AD96A809976D71A8AECBC2E3A7E7487E */
public record class SurfaceDynamicPartPCView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<UIVisibilityView> m_UIVisibilityDynamicView /* NeedsAlign */,
    PPtr<UIVisibilityView> m_UIVisibilityPointerView /* None */,
    PPtr<SurfaceOvertipsPCView> m_SurfaceOvertipsView /* None */,
    PPtr<VariativeInteractionPCView> m_VariativeInteractionView /* None */,
    PPtr<PointMarkersPCView> m_PointMarkersPCView /* None */,
    PPtr<PCCursor> m_Cursor /* None */,
    PPtr<CanvasScalerWorkaround> m_DynamicCanvasScalerWorkaround /* None */)
{
    public static SurfaceDynamicPartPCView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_UIVisibilityDynamicView */
        PPtr<UIVisibilityView> _m_UIVisibilityDynamicView = PPtr<UIVisibilityView>.Read(reader);
        PPtr<UIVisibilityView> _m_UIVisibilityPointerView = PPtr<UIVisibilityView>.Read(reader);
        PPtr<SurfaceOvertipsPCView> _m_SurfaceOvertipsView = PPtr<SurfaceOvertipsPCView>.Read(reader);
        PPtr<VariativeInteractionPCView> _m_VariativeInteractionView = PPtr<VariativeInteractionPCView>.Read(reader);
        PPtr<PointMarkersPCView> _m_PointMarkersPCView = PPtr<PointMarkersPCView>.Read(reader);
        PPtr<PCCursor> _m_Cursor = PPtr<PCCursor>.Read(reader);
        PPtr<CanvasScalerWorkaround> _m_DynamicCanvasScalerWorkaround = PPtr<CanvasScalerWorkaround>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_UIVisibilityDynamicView,
            _m_UIVisibilityPointerView,
            _m_SurfaceOvertipsView,
            _m_VariativeInteractionView,
            _m_PointMarkersPCView,
            _m_Cursor,
            _m_DynamicCanvasScalerWorkaround);
    }
}


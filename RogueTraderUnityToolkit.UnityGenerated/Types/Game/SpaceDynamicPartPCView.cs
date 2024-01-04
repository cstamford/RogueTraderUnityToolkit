namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $SpaceDynamicPartPCView (10 fields) 3E3A60C844FBC08796973C5681FE4687/503B0C0267306648943606ABC24ACB69 */
public record class SpaceDynamicPartPCView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<UIVisibilityView> m_UIVisibilityDynamicView /* NeedsAlign */,
    PPtr<UIVisibilityView> m_UIVisibilityPointerView /* None */,
    PPtr<SpaceOvertipsPCView> m_SpaceOvertipsView /* None */,
    PPtr<PointMarkersPCView> m_SpaceCombatPointMarkersPCView /* None */,
    PPtr<PCCursor> m_Cursor /* None */,
    PPtr<CanvasScalerWorkaround> m_DynamicCanvasScalerWorkaround /* None */)
{
    public static SpaceDynamicPartPCView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_UIVisibilityDynamicView */
        PPtr<UIVisibilityView> _m_UIVisibilityDynamicView = PPtr<UIVisibilityView>.Read(reader);
        PPtr<UIVisibilityView> _m_UIVisibilityPointerView = PPtr<UIVisibilityView>.Read(reader);
        PPtr<SpaceOvertipsPCView> _m_SpaceOvertipsView = PPtr<SpaceOvertipsPCView>.Read(reader);
        PPtr<PointMarkersPCView> _m_SpaceCombatPointMarkersPCView = PPtr<PointMarkersPCView>.Read(reader);
        PPtr<PCCursor> _m_Cursor = PPtr<PCCursor>.Read(reader);
        PPtr<CanvasScalerWorkaround> _m_DynamicCanvasScalerWorkaround = PPtr<CanvasScalerWorkaround>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_UIVisibilityDynamicView,
            _m_UIVisibilityPointerView,
            _m_SpaceOvertipsView,
            _m_SpaceCombatPointMarkersPCView,
            _m_Cursor,
            _m_DynamicCanvasScalerWorkaround);
    }
}


namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $ObjectSelectionGizmos (12 fields) C81E2B6100783ECE935938E9404CB3D3/1FAACB1D696F9F50696FE2FB65B38E2E */
public record class ObjectSelectionGizmos(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    byte _areGizmosActive /* NeedsAlign */,
    int _activeGizmoType /* NeedsAlign */,
    int _gizmoTransformSpace /* None */,
    int _gizmoTransformPivotPoint /* None */,
    PPtr<ObjectMoveGizmo> _objectMoveGizmo /* None */,
    PPtr<ObjectRotationGizmo> _objectRotationGizmo /* None */,
    PPtr<ObjectScaleGizmo> _objectScaleGizmo /* None */,
    PPtr<ObjectSelectionExtrudeGizmo> _objectDuplicateGizmo /* None */)
{
    public static ObjectSelectionGizmos Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* _areGizmosActive */
        byte __areGizmosActive = reader.ReadU8();
        reader.AlignTo(4); /* _activeGizmoType */
        int __activeGizmoType = reader.ReadS32();
        int __gizmoTransformSpace = reader.ReadS32();
        int __gizmoTransformPivotPoint = reader.ReadS32();
        PPtr<ObjectMoveGizmo> __objectMoveGizmo = PPtr<ObjectMoveGizmo>.Read(reader);
        PPtr<ObjectRotationGizmo> __objectRotationGizmo = PPtr<ObjectRotationGizmo>.Read(reader);
        PPtr<ObjectScaleGizmo> __objectScaleGizmo = PPtr<ObjectScaleGizmo>.Read(reader);
        PPtr<ObjectSelectionExtrudeGizmo> __objectDuplicateGizmo = PPtr<ObjectSelectionExtrudeGizmo>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            __areGizmosActive,
            __activeGizmoType,
            __gizmoTransformSpace,
            __gizmoTransformPivotPoint,
            __objectMoveGizmo,
            __objectRotationGizmo,
            __objectScaleGizmo,
            __objectDuplicateGizmo);
    }
}


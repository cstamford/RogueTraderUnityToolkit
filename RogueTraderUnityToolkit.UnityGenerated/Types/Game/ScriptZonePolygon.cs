namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $ScriptZonePolygon (11 fields) F4EBD01BDD39EE0CA887E0BCA91740DC/6E534AA926955105AE39A603FA41B94A */
public record class ScriptZonePolygon(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    Vector3f[] m_Points /* NeedsAlign */,
    ColorRGBA m_GizmoColor /* NeedsAlign */,
    byte m_Closed /* None */,
    float PointYShift /* NeedsAlign */,
    PolygonMeshEditorSettings _editorSettings /* None */,
    PPtr<MeshFilter> DecalMeshObject /* None */,
    PPtr<LineRenderer> OutlineLineRenderer /* None */)
{
    public static ScriptZonePolygon Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_Points */
        Vector3f[] _m_Points = BuiltInArray<Vector3f>.Read(reader);
        reader.AlignTo(4); /* m_GizmoColor */
        ColorRGBA _m_GizmoColor = ColorRGBA.Read(reader);
        byte _m_Closed = reader.ReadU8();
        reader.AlignTo(4); /* PointYShift */
        float _PointYShift = reader.ReadF32();
        PolygonMeshEditorSettings __editorSettings = PolygonMeshEditorSettings.Read(reader);
        PPtr<MeshFilter> _DecalMeshObject = PPtr<MeshFilter>.Read(reader);
        PPtr<LineRenderer> _OutlineLineRenderer = PPtr<LineRenderer>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_Points,
            _m_GizmoColor,
            _m_Closed,
            _PointYShift,
            __editorSettings,
            _DecalMeshObject,
            _OutlineLineRenderer);
    }
}


namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $ObjectPlacement (14 fields) FE3169579388AF3D93E78830DE665214/323FEF760857B9803C1A327A79799E91 */
public record class ObjectPlacement(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<InteractableMirror> _mirror /* NeedsAlign */,
    ProjectedBoxFacePivotPoints _projectedGuidePivotPoints /* None */,
    PPtr<ObjectPivotPointsRenderSettings> _guidePivotPointsRenderSettings /* NeedsAlign */,
    PPtr<ObjectVertexSnapSessionRenderSettings> _objectVertexSnapSessionRenderSettings /* None */,
    PPtr<ObjectPlacementSettings> _settings /* None */,
    PersistentObjectPlacementGuideData _persistentObjectPlacementGuideData /* None */,
    PointAndClickObjectPlacement _pointAndClickObjectPlacement /* None */,
    PathObjectPlacement _pathObjectPlacement /* None */,
    BlockObjectPlacement _blockObjectPlacement /* None */,
    PPtr<DecorPaintObjectPlacement> _decorPaintObjectPlacement /* None */)
{
    public static ObjectPlacement Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* _mirror */
        PPtr<InteractableMirror> __mirror = PPtr<InteractableMirror>.Read(reader);
        ProjectedBoxFacePivotPoints __projectedGuidePivotPoints = ProjectedBoxFacePivotPoints.Read(reader);
        reader.AlignTo(4); /* _guidePivotPointsRenderSettings */
        PPtr<ObjectPivotPointsRenderSettings> __guidePivotPointsRenderSettings = PPtr<ObjectPivotPointsRenderSettings>.Read(reader);
        PPtr<ObjectVertexSnapSessionRenderSettings> __objectVertexSnapSessionRenderSettings = PPtr<ObjectVertexSnapSessionRenderSettings>.Read(reader);
        PPtr<ObjectPlacementSettings> __settings = PPtr<ObjectPlacementSettings>.Read(reader);
        PersistentObjectPlacementGuideData __persistentObjectPlacementGuideData = PersistentObjectPlacementGuideData.Read(reader);
        PointAndClickObjectPlacement __pointAndClickObjectPlacement = default! /* ?PointAndClickObjectPlacement */;
        PathObjectPlacement __pathObjectPlacement = PathObjectPlacement.Read(reader);
        BlockObjectPlacement __blockObjectPlacement = BlockObjectPlacement.Read(reader);
        PPtr<DecorPaintObjectPlacement> __decorPaintObjectPlacement = PPtr<DecorPaintObjectPlacement>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            __mirror,
            __projectedGuidePivotPoints,
            __guidePivotPointsRenderSettings,
            __objectVertexSnapSessionRenderSettings,
            __settings,
            __persistentObjectPlacementGuideData,
            __pointAndClickObjectPlacement,
            __pathObjectPlacement,
            __blockObjectPlacement,
            __decorPaintObjectPlacement);
    }
}


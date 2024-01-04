namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $ObjectSelection (18 fields) F1D91CFE585FF19446B61356A7ADF555/EC9C726C2579C62D77E2A5DF94301597 */
public record class ObjectSelection(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    SerializableGameObjectHashSet _selectedObjects /* NeedsAlign */,
    PPtr<InteractableMirror> _mirror /* None */,
    PPtr<ObjectSelectionSettings> _settings /* None */,
    PPtr<ObjectSelectionPrefabCreationSettings> _prefabCreationSettings /* None */,
    PPtr<ObjectOnSurfaceProjectSettings> _objectOnSurfaceProjectSettings /* None */,
    PPtr<ObjectSelectionRenderSettings> _renderSettings /* None */,
    PPtr<ObjectGrabSettings> _selectionGrabSettings /* None */,
    PPtr<ObjectSelectionExtrudeGizmo> _duplicateGizmo /* None */,
    ObjectSelectionShape _selectionShape /* None */,
    PPtr<ObjectSelectionGizmos> _objectSelectionGizmos /* None */,
    PPtr<GameObject> _firstSelectedGameObject /* None */,
    PPtr<GameObject> _lastSelectedGameObject /* None */,
    PPtr<ObjectVertexSnapSessionRenderSettings> _objectVertexSnapSessionRenderSettings /* None */,
    byte _wasInitialized /* None */)
{
    public static ObjectSelection Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* _selectedObjects */
        SerializableGameObjectHashSet __selectedObjects = SerializableGameObjectHashSet.Read(reader);
        PPtr<InteractableMirror> __mirror = PPtr<InteractableMirror>.Read(reader);
        PPtr<ObjectSelectionSettings> __settings = PPtr<ObjectSelectionSettings>.Read(reader);
        PPtr<ObjectSelectionPrefabCreationSettings> __prefabCreationSettings = PPtr<ObjectSelectionPrefabCreationSettings>.Read(reader);
        PPtr<ObjectOnSurfaceProjectSettings> __objectOnSurfaceProjectSettings = PPtr<ObjectOnSurfaceProjectSettings>.Read(reader);
        PPtr<ObjectSelectionRenderSettings> __renderSettings = PPtr<ObjectSelectionRenderSettings>.Read(reader);
        PPtr<ObjectGrabSettings> __selectionGrabSettings = PPtr<ObjectGrabSettings>.Read(reader);
        PPtr<ObjectSelectionExtrudeGizmo> __duplicateGizmo = PPtr<ObjectSelectionExtrudeGizmo>.Read(reader);
        ObjectSelectionShape __selectionShape = ObjectSelectionShape.Read(reader);
        PPtr<ObjectSelectionGizmos> __objectSelectionGizmos = PPtr<ObjectSelectionGizmos>.Read(reader);
        PPtr<GameObject> __firstSelectedGameObject = PPtr<GameObject>.Read(reader);
        PPtr<GameObject> __lastSelectedGameObject = PPtr<GameObject>.Read(reader);
        PPtr<ObjectVertexSnapSessionRenderSettings> __objectVertexSnapSessionRenderSettings = PPtr<ObjectVertexSnapSessionRenderSettings>.Read(reader);
        byte __wasInitialized = reader.ReadU8();
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            __selectedObjects,
            __mirror,
            __settings,
            __prefabCreationSettings,
            __objectOnSurfaceProjectSettings,
            __renderSettings,
            __selectionGrabSettings,
            __duplicateGizmo,
            __selectionShape,
            __objectSelectionGizmos,
            __firstSelectedGameObject,
            __lastSelectedGameObject,
            __objectVertexSnapSessionRenderSettings,
            __wasInitialized);
    }
}


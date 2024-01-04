namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $Octave3DWorldBuilder (27 fields) 67EA4F97E7BD2F3D6D3977F1EAE5C4F9/2F50D8F1A4F5760312784C9C47E33508 */
public record class Octave3DWorldBuilder(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<Transform> _transform /* NeedsAlign */,
    byte _showGUIHints /* None */,
    Octave3DScene _octave3DScene /* NeedsAlign */,
    PrefabPreviewGenerator _prefabPreviewGenerator /* None */,
    PPtr<EditorWindowPool> _editorWindowPool /* None */,
    PPtr<PrefabCategoryDatabase> _prefabCategoryDatabase /* None */,
    PPtr<ObjectLayerDatabase> _objectLayerDatabase /* None */,
    PPtr<PrefabTagDatabase> _prefabTagDatabase /* None */,
    PPtr<ObjectPlacementPathHeightPatternDatabase> _objectPlacementPathHeightPatternDatabase /* None */,
    PPtr<ObjectPlacementPathTileConnectionConfigurationDatabase> _objectPlacementPathTileConnectionConfigurationDatabase /* None */,
    PPtr<DecorPaintObjectPlacementBrushDatabase> _decorPaintObjectPlacementBrushDatabase /* None */,
    PPtr<ObjectGroupDatabase> _placementObjectGroupDatabase /* None */,
    PPtr<ObjectPlacement> _objectPlacement /* None */,
    PPtr<ObjectSnapping> _objectSnapping /* None */,
    PPtr<ObjectEraser> _objectEraser /* None */,
    PPtr<ObjectSelection> _objectSelection /* None */,
    PrefabsToCategoryDropEventHandler _prefabsToCategoryDropEventHandler /* None */,
    PrefabsToPathTileConectionDropEventHandler _prefabsToPathTileConnectionDropEventHandler /* None */,
    PrefabsToDecorPaintBrushEventHandler _prefabsToDecorPaintBrushEventHandler /* None */,
    PPtr<Inspector> _inspector /* None */,
    PPtr<MeshCombineSettings> _meshCombineSettings /* None */,
    ShaderPool _shaderPool /* None */,
    MaterialPool _materialPool /* None */)
{
    public static Octave3DWorldBuilder Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* _transform */
        PPtr<Transform> __transform = PPtr<Transform>.Read(reader);
        byte __showGUIHints = reader.ReadU8();
        reader.AlignTo(4); /* _octave3DScene */
        Octave3DScene __octave3DScene = Octave3DScene.Read(reader);
        PrefabPreviewGenerator __prefabPreviewGenerator = PrefabPreviewGenerator.Read(reader);
        PPtr<EditorWindowPool> __editorWindowPool = PPtr<EditorWindowPool>.Read(reader);
        PPtr<PrefabCategoryDatabase> __prefabCategoryDatabase = PPtr<PrefabCategoryDatabase>.Read(reader);
        PPtr<ObjectLayerDatabase> __objectLayerDatabase = PPtr<ObjectLayerDatabase>.Read(reader);
        PPtr<PrefabTagDatabase> __prefabTagDatabase = PPtr<PrefabTagDatabase>.Read(reader);
        PPtr<ObjectPlacementPathHeightPatternDatabase> __objectPlacementPathHeightPatternDatabase = PPtr<ObjectPlacementPathHeightPatternDatabase>.Read(reader);
        PPtr<ObjectPlacementPathTileConnectionConfigurationDatabase> __objectPlacementPathTileConnectionConfigurationDatabase = PPtr<ObjectPlacementPathTileConnectionConfigurationDatabase>.Read(reader);
        PPtr<DecorPaintObjectPlacementBrushDatabase> __decorPaintObjectPlacementBrushDatabase = PPtr<DecorPaintObjectPlacementBrushDatabase>.Read(reader);
        PPtr<ObjectGroupDatabase> __placementObjectGroupDatabase = PPtr<ObjectGroupDatabase>.Read(reader);
        PPtr<ObjectPlacement> __objectPlacement = PPtr<ObjectPlacement>.Read(reader);
        PPtr<ObjectSnapping> __objectSnapping = PPtr<ObjectSnapping>.Read(reader);
        PPtr<ObjectEraser> __objectEraser = PPtr<ObjectEraser>.Read(reader);
        PPtr<ObjectSelection> __objectSelection = PPtr<ObjectSelection>.Read(reader);
        PrefabsToCategoryDropEventHandler __prefabsToCategoryDropEventHandler = PrefabsToCategoryDropEventHandler.Read(reader);
        PrefabsToPathTileConectionDropEventHandler __prefabsToPathTileConnectionDropEventHandler = PrefabsToPathTileConectionDropEventHandler.Read(reader);
        PrefabsToDecorPaintBrushEventHandler __prefabsToDecorPaintBrushEventHandler = default! /* ?PrefabsToDecorPaintBrushEventHandler */;
        PPtr<Inspector> __inspector = PPtr<Inspector>.Read(reader);
        PPtr<MeshCombineSettings> __meshCombineSettings = PPtr<MeshCombineSettings>.Read(reader);
        ShaderPool __shaderPool = ShaderPool.Read(reader);
        MaterialPool __materialPool = MaterialPool.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            __transform,
            __showGUIHints,
            __octave3DScene,
            __prefabPreviewGenerator,
            __editorWindowPool,
            __prefabCategoryDatabase,
            __objectLayerDatabase,
            __prefabTagDatabase,
            __objectPlacementPathHeightPatternDatabase,
            __objectPlacementPathTileConnectionConfigurationDatabase,
            __decorPaintObjectPlacementBrushDatabase,
            __placementObjectGroupDatabase,
            __objectPlacement,
            __objectSnapping,
            __objectEraser,
            __objectSelection,
            __prefabsToCategoryDropEventHandler,
            __prefabsToPathTileConnectionDropEventHandler,
            __prefabsToDecorPaintBrushEventHandler,
            __inspector,
            __meshCombineSettings,
            __shaderPool,
            __materialPool);
    }
}


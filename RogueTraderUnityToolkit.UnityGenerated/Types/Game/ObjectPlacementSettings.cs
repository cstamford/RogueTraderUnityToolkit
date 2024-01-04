namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $ObjectPlacementSettings (19 fields) 5F04B8C1F80E7E1E6C050A465D4DA8EF/2E5629CE4E45EF37B9403B3CF357907A */
public record class ObjectPlacementSettings(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    byte _hideWireframeWhenPlacingObjects /* NeedsAlign */,
    byte _inheritRotationOnPrefabScroll /* NeedsAlign */,
    byte _spawnInPrefabLayer /* NeedsAlign */,
    int _customSpawnLayer /* NeedsAlign */,
    byte _attachPlacedObjectsToObjectGroup /* None */,
    byte _useActivePrefabCategoryGroup /* NeedsAlign */,
    int _objectPlacementMode /* NeedsAlign */,
    byte _makePlacedObjectsChildrenOfHoveredObject /* None */,
    PPtr<ObjectIntersectionSettings> _objectIntersectionSettings /* NeedsAlign */,
    PPtr<ObjectPlacementGuideSettings> _objectPlacementGuideSettings /* None */,
    PPtr<DecorPaintObjectPlacementSettings> _decorPaintObjectPlacementSettings /* None */,
    PPtr<PointAndClickObjectPlacementSettings> _pointAndClickPlacementSettings /* None */,
    PPtr<PathObjectPlacementSettings> _pathPlacementSettings /* None */,
    PPtr<BlockObjectPlacementSettings> _blockObjectPlacementSettings /* None */,
    ObjectPlacementSettingsView _view /* None */)
{
    public static ObjectPlacementSettings Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* _hideWireframeWhenPlacingObjects */
        byte __hideWireframeWhenPlacingObjects = reader.ReadU8();
        reader.AlignTo(4); /* _inheritRotationOnPrefabScroll */
        byte __inheritRotationOnPrefabScroll = reader.ReadU8();
        reader.AlignTo(4); /* _spawnInPrefabLayer */
        byte __spawnInPrefabLayer = reader.ReadU8();
        reader.AlignTo(4); /* _customSpawnLayer */
        int __customSpawnLayer = reader.ReadS32();
        byte __attachPlacedObjectsToObjectGroup = reader.ReadU8();
        reader.AlignTo(4); /* _useActivePrefabCategoryGroup */
        byte __useActivePrefabCategoryGroup = reader.ReadU8();
        reader.AlignTo(4); /* _objectPlacementMode */
        int __objectPlacementMode = reader.ReadS32();
        byte __makePlacedObjectsChildrenOfHoveredObject = reader.ReadU8();
        reader.AlignTo(4); /* _objectIntersectionSettings */
        PPtr<ObjectIntersectionSettings> __objectIntersectionSettings = PPtr<ObjectIntersectionSettings>.Read(reader);
        PPtr<ObjectPlacementGuideSettings> __objectPlacementGuideSettings = PPtr<ObjectPlacementGuideSettings>.Read(reader);
        PPtr<DecorPaintObjectPlacementSettings> __decorPaintObjectPlacementSettings = PPtr<DecorPaintObjectPlacementSettings>.Read(reader);
        PPtr<PointAndClickObjectPlacementSettings> __pointAndClickPlacementSettings = PPtr<PointAndClickObjectPlacementSettings>.Read(reader);
        PPtr<PathObjectPlacementSettings> __pathPlacementSettings = PPtr<PathObjectPlacementSettings>.Read(reader);
        PPtr<BlockObjectPlacementSettings> __blockObjectPlacementSettings = PPtr<BlockObjectPlacementSettings>.Read(reader);
        ObjectPlacementSettingsView __view = ObjectPlacementSettingsView.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            __hideWireframeWhenPlacingObjects,
            __inheritRotationOnPrefabScroll,
            __spawnInPrefabLayer,
            __customSpawnLayer,
            __attachPlacedObjectsToObjectGroup,
            __useActivePrefabCategoryGroup,
            __objectPlacementMode,
            __makePlacedObjectsChildrenOfHoveredObject,
            __objectIntersectionSettings,
            __objectPlacementGuideSettings,
            __decorPaintObjectPlacementSettings,
            __pointAndClickPlacementSettings,
            __pathPlacementSettings,
            __blockObjectPlacementSettings,
            __view);
    }
}


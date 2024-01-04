namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $ObjectPlacementBlockManualConstructionSettings (15 fields) 63B1E0D6EF682B0C326A1E11304345C0/3D300954E27DDBA41B6C780BC7A2711A */
public record class ObjectPlacementBlockManualConstructionSettings(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    byte _constrainSize /* NeedsAlign */,
    int _maxSize /* NeedsAlign */,
    float _offsetAlongGrowDirection /* None */,
    byte _excludeCorners /* None */,
    byte _randomizePrefabs /* NeedsAlign */,
    float _objectMissChance /* NeedsAlign */,
    PPtr<ObjectPlacementBlockPaddingSettings> _paddingSettings /* None */,
    PPtr<ObjectRotationRandomizationSettings> _objectRotationRandomizationSettings /* None */,
    PPtr<ObjectPlacementBlockHeightAdjustmentSettings> _heightAdjustmentSettings /* None */,
    PPtr<ObjectPlacementBlockSubdivisionSettings> _subdivisionSettings /* None */,
    ObjectPlacementBlockManualConstructionSettingsView _view /* None */)
{
    public static ObjectPlacementBlockManualConstructionSettings Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* _constrainSize */
        byte __constrainSize = reader.ReadU8();
        reader.AlignTo(4); /* _maxSize */
        int __maxSize = reader.ReadS32();
        float __offsetAlongGrowDirection = reader.ReadF32();
        byte __excludeCorners = reader.ReadU8();
        reader.AlignTo(4); /* _randomizePrefabs */
        byte __randomizePrefabs = reader.ReadU8();
        reader.AlignTo(4); /* _objectMissChance */
        float __objectMissChance = reader.ReadF32();
        PPtr<ObjectPlacementBlockPaddingSettings> __paddingSettings = PPtr<ObjectPlacementBlockPaddingSettings>.Read(reader);
        PPtr<ObjectRotationRandomizationSettings> __objectRotationRandomizationSettings = PPtr<ObjectRotationRandomizationSettings>.Read(reader);
        PPtr<ObjectPlacementBlockHeightAdjustmentSettings> __heightAdjustmentSettings = PPtr<ObjectPlacementBlockHeightAdjustmentSettings>.Read(reader);
        PPtr<ObjectPlacementBlockSubdivisionSettings> __subdivisionSettings = PPtr<ObjectPlacementBlockSubdivisionSettings>.Read(reader);
        ObjectPlacementBlockManualConstructionSettingsView __view = ObjectPlacementBlockManualConstructionSettingsView.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            __constrainSize,
            __maxSize,
            __offsetAlongGrowDirection,
            __excludeCorners,
            __randomizePrefabs,
            __objectMissChance,
            __paddingSettings,
            __objectRotationRandomizationSettings,
            __heightAdjustmentSettings,
            __subdivisionSettings,
            __view);
    }
}


namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $SingleDecorPaintModeObjectPlacementSettings (12 fields) A5AF0C74127263237C42DA4F153F5D52/A8B38E38FD7E2E0BBC0108D4B7B02515 */
public record class SingleDecorPaintModeObjectPlacementSettings(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    byte _alignToStroke /* NeedsAlign */,
    byte _embedInSurfaceWhenNoAlign /* NeedsAlign */,
    byte _randomizePrefabsInActiveCategory /* NeedsAlign */,
    byte _useOriginalPivot /* NeedsAlign */,
    PPtr<AxisAlignmentSettings> _placementGuideSurfaceAlignmentSettings /* NeedsAlign */,
    PPtr<ObjectRotationRandomizationSettings> _placementGuideRotationRandomizationSettings /* None */,
    PPtr<ObjectScaleRandomizationSettings> _placementGuideScaleRandomizationSettings /* None */,
    SingleDecorPaintModeObjectPlacementSettingsView _view /* None */)
{
    public static SingleDecorPaintModeObjectPlacementSettings Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* _alignToStroke */
        byte __alignToStroke = reader.ReadU8();
        reader.AlignTo(4); /* _embedInSurfaceWhenNoAlign */
        byte __embedInSurfaceWhenNoAlign = reader.ReadU8();
        reader.AlignTo(4); /* _randomizePrefabsInActiveCategory */
        byte __randomizePrefabsInActiveCategory = reader.ReadU8();
        reader.AlignTo(4); /* _useOriginalPivot */
        byte __useOriginalPivot = reader.ReadU8();
        reader.AlignTo(4); /* _placementGuideSurfaceAlignmentSettings */
        PPtr<AxisAlignmentSettings> __placementGuideSurfaceAlignmentSettings = PPtr<AxisAlignmentSettings>.Read(reader);
        PPtr<ObjectRotationRandomizationSettings> __placementGuideRotationRandomizationSettings = PPtr<ObjectRotationRandomizationSettings>.Read(reader);
        PPtr<ObjectScaleRandomizationSettings> __placementGuideScaleRandomizationSettings = PPtr<ObjectScaleRandomizationSettings>.Read(reader);
        SingleDecorPaintModeObjectPlacementSettingsView __view = SingleDecorPaintModeObjectPlacementSettingsView.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            __alignToStroke,
            __embedInSurfaceWhenNoAlign,
            __randomizePrefabsInActiveCategory,
            __useOriginalPivot,
            __placementGuideSurfaceAlignmentSettings,
            __placementGuideRotationRandomizationSettings,
            __placementGuideScaleRandomizationSettings,
            __view);
    }
}


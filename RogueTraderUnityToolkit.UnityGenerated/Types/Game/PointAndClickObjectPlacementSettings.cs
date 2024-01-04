namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $PointAndClickObjectPlacementSettings (9 fields) 7AAAD3AF6D56FB0DB979C22C5B9DE0C5/446D9421EA1F579320396E7772A77E2B */
public record class PointAndClickObjectPlacementSettings(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    byte _randomizePrefabsInActiveCategory /* NeedsAlign */,
    PPtr<AxisAlignmentSettings> _placementGuideSurfaceAlignmentSettings /* NeedsAlign */,
    PPtr<ObjectRotationRandomizationSettings> _placementGuideRotationRandomizationSettings /* None */,
    PPtr<ObjectScaleRandomizationSettings> _placementGuideScaleRandomizationSettings /* None */,
    PointAndClickObjectPlacementSettingsView _view /* None */)
{
    public static PointAndClickObjectPlacementSettings Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* _randomizePrefabsInActiveCategory */
        byte __randomizePrefabsInActiveCategory = reader.ReadU8();
        reader.AlignTo(4); /* _placementGuideSurfaceAlignmentSettings */
        PPtr<AxisAlignmentSettings> __placementGuideSurfaceAlignmentSettings = PPtr<AxisAlignmentSettings>.Read(reader);
        PPtr<ObjectRotationRandomizationSettings> __placementGuideRotationRandomizationSettings = PPtr<ObjectRotationRandomizationSettings>.Read(reader);
        PPtr<ObjectScaleRandomizationSettings> __placementGuideScaleRandomizationSettings = PPtr<ObjectScaleRandomizationSettings>.Read(reader);
        PointAndClickObjectPlacementSettingsView __view = PointAndClickObjectPlacementSettingsView.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            __randomizePrefabsInActiveCategory,
            __placementGuideSurfaceAlignmentSettings,
            __placementGuideRotationRandomizationSettings,
            __placementGuideScaleRandomizationSettings,
            __view);
    }
}


namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $PathObjectPlacementSettings (6 fields) A1904C66F9DFC32439C000B45CB99713/AD940ED220F7DDE7CA27AEA236999B0F */
public record class PathObjectPlacementSettings(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<AxisAlignmentSettings> _placementGuideSurfaceAlignmentSettings /* NeedsAlign */,
    PathObjectPlacementSettingsView _view /* None */)
{
    public static PathObjectPlacementSettings Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* _placementGuideSurfaceAlignmentSettings */
        PPtr<AxisAlignmentSettings> __placementGuideSurfaceAlignmentSettings = PPtr<AxisAlignmentSettings>.Read(reader);
        PathObjectPlacementSettingsView __view = PathObjectPlacementSettingsView.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            __placementGuideSurfaceAlignmentSettings,
            __view);
    }
}


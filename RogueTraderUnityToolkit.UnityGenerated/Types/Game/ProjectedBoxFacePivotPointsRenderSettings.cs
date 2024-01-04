namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $ProjectedBoxFacePivotPointsRenderSettings (12 fields) 63113B45DE3B4C69EE5ED387E5CF74FA/38F6D69868347C9B650CCAC6F5D1E535 */
public record class ProjectedBoxFacePivotPointsRenderSettings(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<SingleObjectPivotPointRenderSettings> _activePivotPointRenderSettings /* NeedsAlign */,
    PPtr<SingleObjectPivotPointRenderSettings> _inactivePivotPointRenderSettings /* None */,
    byte _renderProjectionLines /* None */,
    ColorRGBA _projectionLineColor /* NeedsAlign */,
    byte _renderPivotPointConnectionLines /* None */,
    ColorRGBA _pivotPointConnectionLineColor /* NeedsAlign */,
    byte _wasInitialized /* None */,
    ProjectedBoxFacePivotPointsRenderSettingsView _view /* NeedsAlign */)
{
    public static ProjectedBoxFacePivotPointsRenderSettings Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* _activePivotPointRenderSettings */
        PPtr<SingleObjectPivotPointRenderSettings> __activePivotPointRenderSettings = PPtr<SingleObjectPivotPointRenderSettings>.Read(reader);
        PPtr<SingleObjectPivotPointRenderSettings> __inactivePivotPointRenderSettings = PPtr<SingleObjectPivotPointRenderSettings>.Read(reader);
        byte __renderProjectionLines = reader.ReadU8();
        reader.AlignTo(4); /* _projectionLineColor */
        ColorRGBA __projectionLineColor = ColorRGBA.Read(reader);
        byte __renderPivotPointConnectionLines = reader.ReadU8();
        reader.AlignTo(4); /* _pivotPointConnectionLineColor */
        ColorRGBA __pivotPointConnectionLineColor = ColorRGBA.Read(reader);
        byte __wasInitialized = reader.ReadU8();
        reader.AlignTo(4); /* _view */
        ProjectedBoxFacePivotPointsRenderSettingsView __view = ProjectedBoxFacePivotPointsRenderSettingsView.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            __activePivotPointRenderSettings,
            __inactivePivotPointRenderSettings,
            __renderProjectionLines,
            __projectionLineColor,
            __renderPivotPointConnectionLines,
            __pivotPointConnectionLineColor,
            __wasInitialized,
            __view);
    }
}


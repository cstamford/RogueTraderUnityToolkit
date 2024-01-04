namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $ObjectRotationRandomizationSettings (10 fields) FE1C678C5A5692EF2BD54F82E344D4D9/1F4FB75542F19F9E63FCD1AA41C55E91 */
public record class ObjectRotationRandomizationSettings(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    byte _randomizeRotation /* NeedsAlign */,
    PPtr<CustomAxisRotationRandomizationSettings> _customAxisRandomizationSettings /* NeedsAlign */,
    PPtr<AxisRotationRandomizationSettings> _xAxisRandomizationSettings /* None */,
    PPtr<AxisRotationRandomizationSettings> _yAxisRandomizationSettings /* None */,
    PPtr<AxisRotationRandomizationSettings> _zAxisRandomizationSettings /* None */,
    ObjectRotationRandomizationSettingsView _view /* None */)
{
    public static ObjectRotationRandomizationSettings Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* _randomizeRotation */
        byte __randomizeRotation = reader.ReadU8();
        reader.AlignTo(4); /* _customAxisRandomizationSettings */
        PPtr<CustomAxisRotationRandomizationSettings> __customAxisRandomizationSettings = PPtr<CustomAxisRotationRandomizationSettings>.Read(reader);
        PPtr<AxisRotationRandomizationSettings> __xAxisRandomizationSettings = PPtr<AxisRotationRandomizationSettings>.Read(reader);
        PPtr<AxisRotationRandomizationSettings> __yAxisRandomizationSettings = PPtr<AxisRotationRandomizationSettings>.Read(reader);
        PPtr<AxisRotationRandomizationSettings> __zAxisRandomizationSettings = PPtr<AxisRotationRandomizationSettings>.Read(reader);
        ObjectRotationRandomizationSettingsView __view = ObjectRotationRandomizationSettingsView.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            __randomizeRotation,
            __customAxisRandomizationSettings,
            __xAxisRandomizationSettings,
            __yAxisRandomizationSettings,
            __zAxisRandomizationSettings,
            __view);
    }
}


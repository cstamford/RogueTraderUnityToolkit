namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $ObjectMouseRotationSettings (11 fields) 1C19369ED99975A2DA51074683CA6245/CC99883867D664DCBB5E9685104B4AE3 */
public record class ObjectMouseRotationSettings(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<AxisMouseRotationSettings> _xAxisRotationSettings /* NeedsAlign */,
    PPtr<AxisMouseRotationSettings> _yAxisRotationSettings /* None */,
    PPtr<AxisMouseRotationSettings> _zAxisRotationSettings /* None */,
    PPtr<CustomAxisMouseRotationSettings> _customAxisRotationSettings /* None */,
    float _snapStepInDegrees /* None */,
    byte _useSnapping /* None */,
    ObjectMouseRotationSettingsView _view /* NeedsAlign */)
{
    public static ObjectMouseRotationSettings Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* _xAxisRotationSettings */
        PPtr<AxisMouseRotationSettings> __xAxisRotationSettings = PPtr<AxisMouseRotationSettings>.Read(reader);
        PPtr<AxisMouseRotationSettings> __yAxisRotationSettings = PPtr<AxisMouseRotationSettings>.Read(reader);
        PPtr<AxisMouseRotationSettings> __zAxisRotationSettings = PPtr<AxisMouseRotationSettings>.Read(reader);
        PPtr<CustomAxisMouseRotationSettings> __customAxisRotationSettings = PPtr<CustomAxisMouseRotationSettings>.Read(reader);
        float __snapStepInDegrees = reader.ReadF32();
        byte __useSnapping = reader.ReadU8();
        reader.AlignTo(4); /* _view */
        ObjectMouseRotationSettingsView __view = ObjectMouseRotationSettingsView.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            __xAxisRotationSettings,
            __yAxisRotationSettings,
            __zAxisRotationSettings,
            __customAxisRotationSettings,
            __snapStepInDegrees,
            __useSnapping,
            __view);
    }
}


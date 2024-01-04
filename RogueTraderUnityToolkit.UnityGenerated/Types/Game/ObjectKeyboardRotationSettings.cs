namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $ObjectKeyboardRotationSettings (9 fields) 6C65875020C552DA8A50C46D16689C74/8ACCF7AD1EF02A4C7CC08A3BF4820C88 */
public record class ObjectKeyboardRotationSettings(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<AxisKeyboardRotationSettings> _xAxisRotationSettings /* NeedsAlign */,
    PPtr<AxisKeyboardRotationSettings> _yAxisRotationSettings /* None */,
    PPtr<AxisKeyboardRotationSettings> _zAxisRotationSettings /* None */,
    PPtr<CustomAxisKeyboardRotationSettings> _customAxisRotationSettings /* None */,
    ObjectKeyboardRotationSettingsView _view /* None */)
{
    public static ObjectKeyboardRotationSettings Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* _xAxisRotationSettings */
        PPtr<AxisKeyboardRotationSettings> __xAxisRotationSettings = PPtr<AxisKeyboardRotationSettings>.Read(reader);
        PPtr<AxisKeyboardRotationSettings> __yAxisRotationSettings = PPtr<AxisKeyboardRotationSettings>.Read(reader);
        PPtr<AxisKeyboardRotationSettings> __zAxisRotationSettings = PPtr<AxisKeyboardRotationSettings>.Read(reader);
        PPtr<CustomAxisKeyboardRotationSettings> __customAxisRotationSettings = PPtr<CustomAxisKeyboardRotationSettings>.Read(reader);
        ObjectKeyboardRotationSettingsView __view = ObjectKeyboardRotationSettingsView.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            __xAxisRotationSettings,
            __yAxisRotationSettings,
            __zAxisRotationSettings,
            __customAxisRotationSettings,
            __view);
    }
}


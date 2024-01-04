namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $ControllerDataFiles (7 fields) BB50C9208D45AE957979A4738262C6E0/678E5B819F19A391C28A213FA5496B61 */
public record class ControllerDataFiles(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<HardwareJoystickMap> defaultHardwareJoystickMap /* NeedsAlign */,
    PPtr<HardwareJoystickMap>[] hardwareJoystickMaps /* None */,
    PPtr<HardwareJoystickTemplateMap>[] joystickTemplates /* None */)
{
    public static ControllerDataFiles Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* defaultHardwareJoystickMap */
        PPtr<HardwareJoystickMap> _defaultHardwareJoystickMap = PPtr<HardwareJoystickMap>.Read(reader);
        PPtr<HardwareJoystickMap>[] _hardwareJoystickMaps = BuiltInArray<PPtr<HardwareJoystickMap>>.Read(reader);
        PPtr<HardwareJoystickTemplateMap>[] _joystickTemplates = BuiltInArray<PPtr<HardwareJoystickTemplateMap>>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _defaultHardwareJoystickMap,
            _hardwareJoystickMaps,
            _joystickTemplates);
    }
}


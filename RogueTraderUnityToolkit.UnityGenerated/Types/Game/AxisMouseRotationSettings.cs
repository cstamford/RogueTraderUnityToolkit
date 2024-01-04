namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $AxisMouseRotationSettings (7 fields) 160E85EFCF570A37B3A728E81ADB33C8/B8C57CF69BDE276F54B58D8405BD660C */
public record class AxisMouseRotationSettings(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    int _rotationAxis /* NeedsAlign */,
    float _mouseSensitivity /* None */,
    AxisMouseRotationSettingsView _view /* None */)
{
    public static AxisMouseRotationSettings Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* _rotationAxis */
        int __rotationAxis = reader.ReadS32();
        float __mouseSensitivity = reader.ReadF32();
        AxisMouseRotationSettingsView __view = AxisMouseRotationSettingsView.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            __rotationAxis,
            __mouseSensitivity,
            __view);
    }
}


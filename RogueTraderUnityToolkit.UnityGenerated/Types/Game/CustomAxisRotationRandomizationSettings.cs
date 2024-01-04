namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $CustomAxisRotationRandomizationSettings (7 fields) 5677E4D3A019F17C7A948223D2E90D45/25A57374477016B9178E5A96AF16BD4B */
public record class CustomAxisRotationRandomizationSettings(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    byte _randomize /* NeedsAlign */,
    PPtr<AxisRotationRandomizationModeSettings> _randomizationModeSettings /* NeedsAlign */,
    CustomAxisRotationRandomizationSettingsView _view /* None */)
{
    public static CustomAxisRotationRandomizationSettings Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* _randomize */
        byte __randomize = reader.ReadU8();
        reader.AlignTo(4); /* _randomizationModeSettings */
        PPtr<AxisRotationRandomizationModeSettings> __randomizationModeSettings = PPtr<AxisRotationRandomizationModeSettings>.Read(reader);
        CustomAxisRotationRandomizationSettingsView __view = CustomAxisRotationRandomizationSettingsView.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            __randomize,
            __randomizationModeSettings,
            __view);
    }
}


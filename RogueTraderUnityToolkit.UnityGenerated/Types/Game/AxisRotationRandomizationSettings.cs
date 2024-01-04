namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $AxisRotationRandomizationSettings (8 fields) ED7715C0AE38C8CC6A689770B0230339/73C2637C00041497DE02190F8FF278E3 */
public record class AxisRotationRandomizationSettings(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    byte _randomize /* NeedsAlign */,
    int _axis /* NeedsAlign */,
    PPtr<AxisRotationRandomizationModeSettings> _randomizationModeSettings /* None */,
    AxisRotationRandomizationSettingsView _view /* None */)
{
    public static AxisRotationRandomizationSettings Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* _randomize */
        byte __randomize = reader.ReadU8();
        reader.AlignTo(4); /* _axis */
        int __axis = reader.ReadS32();
        PPtr<AxisRotationRandomizationModeSettings> __randomizationModeSettings = PPtr<AxisRotationRandomizationModeSettings>.Read(reader);
        AxisRotationRandomizationSettingsView __view = AxisRotationRandomizationSettingsView.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            __randomize,
            __axis,
            __randomizationModeSettings,
            __view);
    }
}


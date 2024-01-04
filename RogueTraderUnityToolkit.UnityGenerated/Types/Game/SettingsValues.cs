namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $SettingsValues (7 fields) 796D867812C67B8945E2AE2E59B99729/F2DD39FCBB58FD52AD5AD4B093C0FE35 */
public record class SettingsValues(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    SettingsDefaultValues SettingsDefaultValues /* NeedsAlign */,
    PPtr<DifficultyPresetsList> DifficultiesPresets /* NeedsAlign */,
    PPtr<GraphicsPresetsList> GraphicsPresetsList /* None */)
{
    public static SettingsValues Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* SettingsDefaultValues */
        SettingsDefaultValues _SettingsDefaultValues = SettingsDefaultValues.Read(reader);
        reader.AlignTo(4); /* DifficultiesPresets */
        PPtr<DifficultyPresetsList> _DifficultiesPresets = PPtr<DifficultyPresetsList>.Read(reader);
        PPtr<GraphicsPresetsList> _GraphicsPresetsList = PPtr<GraphicsPresetsList>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _SettingsDefaultValues,
            _DifficultiesPresets,
            _GraphicsPresetsList);
    }
}


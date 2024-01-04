namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $Arbiter (5 fields) BC9EB7AC35C1009F88DC38A1FA3B5EEB/C94CADE23013CC21E56C3B112FF067AB */
public record class Arbiter(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    BlueprintAreaPresetReference StartGamePreset /* NeedsAlign */)
{
    public static Arbiter Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* StartGamePreset */
        BlueprintAreaPresetReference _StartGamePreset = BlueprintAreaPresetReference.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _StartGamePreset);
    }
}


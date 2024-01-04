namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $ScrambledTMP (6 fields) FD900CFC9533F8F0BA3D245C47D1A242/496F29C3A282CBEF3BE2E20FEBE165FE */
public record class ScrambledTMP(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    float m_Duration /* NeedsAlign */,
    int m_FramesPerChar /* None */)
{
    public static ScrambledTMP Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_Duration */
        float _m_Duration = reader.ReadF32();
        int _m_FramesPerChar = reader.ReadS32();
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_Duration,
            _m_FramesPerChar);
    }
}


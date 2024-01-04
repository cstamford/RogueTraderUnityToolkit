namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $Wind (12 fields) 333DD0CF87B748AC2D235449F458932B/17C5B4906CA2A7F4F4AEC4907FD1B528 */
public record class Wind(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    float2 Direction /* NeedsAlign */,
    float Intensity /* None */,
    float StrengthNoiseWeight /* None */,
    float StrengthNoiseContrast /* None */,
    NoiseOctave StrenghtOctave0 /* None */,
    NoiseOctave StrengthOctave1 /* None */,
    NoiseOctave ShiftOctave0 /* None */,
    NoiseOctave ShiftOctave1 /* None */)
{
    public static Wind Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* Direction */
        float2 _Direction = float2.Read(reader);
        float _Intensity = reader.ReadF32();
        float _StrengthNoiseWeight = reader.ReadF32();
        float _StrengthNoiseContrast = reader.ReadF32();
        NoiseOctave _StrenghtOctave0 = NoiseOctave.Read(reader);
        NoiseOctave _StrengthOctave1 = NoiseOctave.Read(reader);
        NoiseOctave _ShiftOctave0 = NoiseOctave.Read(reader);
        NoiseOctave _ShiftOctave1 = NoiseOctave.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _Direction,
            _Intensity,
            _StrengthNoiseWeight,
            _StrengthNoiseContrast,
            _StrenghtOctave0,
            _StrengthOctave1,
            _ShiftOctave0,
            _ShiftOctave1);
    }
}


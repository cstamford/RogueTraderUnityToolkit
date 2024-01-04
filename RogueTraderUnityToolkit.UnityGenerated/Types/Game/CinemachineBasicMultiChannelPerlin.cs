namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $CinemachineBasicMultiChannelPerlin (9 fields) F210B6FB35EBD36A47AD53391C4019E9/D0AA83E706060F0448BBE10022F87FDC */
public record class CinemachineBasicMultiChannelPerlin(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<NoiseSettings> m_NoiseProfile /* NeedsAlign */,
    Vector3f m_PivotOffset /* None */,
    float m_AmplitudeGain /* None */,
    float m_FrequencyGain /* None */,
    Vector3f mNoiseOffsets /* None */)
{
    public static CinemachineBasicMultiChannelPerlin Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_NoiseProfile */
        PPtr<NoiseSettings> _m_NoiseProfile = PPtr<NoiseSettings>.Read(reader);
        Vector3f _m_PivotOffset = Vector3f.Read(reader);
        float _m_AmplitudeGain = reader.ReadF32();
        float _m_FrequencyGain = reader.ReadF32();
        Vector3f _mNoiseOffsets = Vector3f.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_NoiseProfile,
            _m_PivotOffset,
            _m_AmplitudeGain,
            _m_FrequencyGain,
            _mNoiseOffsets);
    }
}


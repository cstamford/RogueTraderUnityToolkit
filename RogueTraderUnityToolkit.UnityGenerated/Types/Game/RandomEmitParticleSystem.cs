namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $RandomEmitParticleSystem (11 fields) 2A593CB3724B4C1CF9847A4995F9912C/E5745118B0CC440FDFAACAB269C29582 */
public record class RandomEmitParticleSystem(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<ParticleSystem>[] ControlledParticleSystems /* NeedsAlign */,
    float RandomX /* None */,
    float RandomY /* None */,
    float RandomZ /* None */,
    float Delay /* None */,
    float RandomDelay /* None */,
    int MaxEmit /* None */)
{
    public static RandomEmitParticleSystem Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* ControlledParticleSystems */
        PPtr<ParticleSystem>[] _ControlledParticleSystems = BuiltInArray<PPtr<ParticleSystem>>.Read(reader);
        float _RandomX = reader.ReadF32();
        float _RandomY = reader.ReadF32();
        float _RandomZ = reader.ReadF32();
        float _Delay = reader.ReadF32();
        float _RandomDelay = reader.ReadF32();
        int _MaxEmit = reader.ReadS32();
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _ControlledParticleSystems,
            _RandomX,
            _RandomY,
            _RandomZ,
            _Delay,
            _RandomDelay,
            _MaxEmit);
    }
}


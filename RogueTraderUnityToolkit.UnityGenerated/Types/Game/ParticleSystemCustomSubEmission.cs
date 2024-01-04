namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $ParticleSystemCustomSubEmission (5 fields) 2A088913E900F51BE6434204FCDFE9EC/037B3463360FA0167E50F629950A87F4 */
public record class ParticleSystemCustomSubEmission(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<GameObject> m_SubEmitterParticleSystemsPrefab /* NeedsAlign */)
{
    public static ParticleSystemCustomSubEmission Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_SubEmitterParticleSystemsPrefab */
        PPtr<GameObject> _m_SubEmitterParticleSystemsPrefab = PPtr<GameObject>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_SubEmitterParticleSystemsPrefab);
    }
}


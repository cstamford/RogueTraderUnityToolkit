namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $CharacterFxBonesMap (10 fields) EDF7BBA4C89978300CF2660593E9C53C/12B413F2531348AA53FF684D0AF1AEBA */
public record class CharacterFxBonesMap(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    float ParticleSizeScale /* NeedsAlign */,
    float SizeScale /* None */,
    float LifetimeScale /* None */,
    float RateOverTimeScale /* None */,
    float BurstScale /* None */,
    FxBone Bones /* None */)
{
    public static CharacterFxBonesMap Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* ParticleSizeScale */
        float _ParticleSizeScale = reader.ReadF32();
        float _SizeScale = reader.ReadF32();
        float _LifetimeScale = reader.ReadF32();
        float _RateOverTimeScale = reader.ReadF32();
        float _BurstScale = reader.ReadF32();
        FxBone _Bones = FxBone.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _ParticleSizeScale,
            _SizeScale,
            _LifetimeScale,
            _RateOverTimeScale,
            _BurstScale,
            _Bones);
    }
}


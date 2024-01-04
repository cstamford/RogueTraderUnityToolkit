namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $ParticlesSnapMap (15 fields) 3526A5806E07FAF849AF4C9E1B04E329/E307B883582DB9F2EDB9FF71F7C6EC66 */
public record class ParticlesSnapMap(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    byte m_UseLocatorGroups /* NeedsAlign */,
    float m_ParticleSizeScale /* NeedsAlign */,
    float m_SizeScale /* None */,
    float m_LifetimeScale /* None */,
    float m_RateOverTimeScale /* None */,
    float m_BurstScale /* None */,
    float ParticleSize /* None */,
    PPtr<GameObject>[] FxLocatorsObjects /* None */,
    PPtr<FxLocator>[] FxLocators /* None */,
    FxBone[] m_Bones /* None */,
    PPtr<CharacterFxBonesMap> CharacterFxBonesMap /* NeedsAlign */)
{
    public static ParticlesSnapMap Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_UseLocatorGroups */
        byte _m_UseLocatorGroups = reader.ReadU8();
        reader.AlignTo(4); /* m_ParticleSizeScale */
        float _m_ParticleSizeScale = reader.ReadF32();
        float _m_SizeScale = reader.ReadF32();
        float _m_LifetimeScale = reader.ReadF32();
        float _m_RateOverTimeScale = reader.ReadF32();
        float _m_BurstScale = reader.ReadF32();
        float _ParticleSize = reader.ReadF32();
        PPtr<GameObject>[] _FxLocatorsObjects = BuiltInArray<PPtr<GameObject>>.Read(reader);
        PPtr<FxLocator>[] _FxLocators = BuiltInArray<PPtr<FxLocator>>.Read(reader);
        FxBone[] _m_Bones = BuiltInArray<FxBone>.Read(reader);
        reader.AlignTo(4); /* CharacterFxBonesMap */
        PPtr<CharacterFxBonesMap> _CharacterFxBonesMap = PPtr<CharacterFxBonesMap>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_UseLocatorGroups,
            _m_ParticleSizeScale,
            _m_SizeScale,
            _m_LifetimeScale,
            _m_RateOverTimeScale,
            _m_BurstScale,
            _ParticleSize,
            _FxLocatorsObjects,
            _FxLocators,
            _m_Bones,
            _CharacterFxBonesMap);
    }
}


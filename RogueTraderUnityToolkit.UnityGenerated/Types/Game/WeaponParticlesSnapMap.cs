namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $WeaponParticlesSnapMap (19 fields) B9A6A1638596CA2D8A50A37EC9ADBE2C/C1D487A5BA97E310E87D6BFEAD36A01C */
public record class WeaponParticlesSnapMap(
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
    FxBone m_Bones /* None */,
    int Slot /* NeedsAlign */,
    PPtr<GameObject> DefaultTrailPrefab /* None */,
    Gradient ColorGradient /* None */,
    int Alignment /* NeedsAlign */,
    TrailBonesPair[] m_TrailBones /* None */)
{
    public static WeaponParticlesSnapMap Read(EndianBinaryReader reader)
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
        FxBone _m_Bones = FxBone.Read(reader);
        reader.AlignTo(4); /* Slot */
        int _Slot = reader.ReadS32();
        PPtr<GameObject> _DefaultTrailPrefab = PPtr<GameObject>.Read(reader);
        Gradient _ColorGradient = Gradient.Read(reader);
        reader.AlignTo(4); /* Alignment */
        int _Alignment = reader.ReadS32();
        TrailBonesPair[] _m_TrailBones = BuiltInArray<TrailBonesPair>.Read(reader);
        
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
            _Slot,
            _DefaultTrailPrefab,
            _ColorGradient,
            _Alignment,
            _m_TrailBones);
    }
}


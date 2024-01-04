namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $ParticlesSnapController (21 fields) 403AC22CC048C943E513672EDA4850C9/B876E3649D310620FD890D237FF5C83E */
public record class ParticlesSnapController(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<SnapControllerBase> m_RotatableCopy /* NeedsAlign */,
    byte m_IsRotatableCopy /* None */,
    int SnapType /* NeedsAlign */,
    PPtr<SnapMapBase> Map /* None */,
    byte SupressMapOverride /* None */,
    AnimationCurve CameraOffsetScale /* NeedsAlign */,
    byte ApplySizeScale /* NeedsAlign */,
    byte ApplyLifetimeScale /* NeedsAlign */,
    byte ApplyRateOverTimeScale /* NeedsAlign */,
    byte ApplyBurstScale /* NeedsAlign */,
    byte PersistWhenDisabled /* NeedsAlign */,
    OffsetAnimationSettings Offset /* NeedsAlign */,
    AsciiString[] BonesNames /* NeedsAlign */,
    Reference m_LocatorGroups /* NeedsAlign */,
    byte IgnoreSpecialBones /* NeedsAlign */,
    byte m_useRandomBones /* NeedsAlign */,
    float m_randomBonesPercent /* NeedsAlign */)
{
    public static ParticlesSnapController Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_RotatableCopy */
        PPtr<SnapControllerBase> _m_RotatableCopy = PPtr<SnapControllerBase>.Read(reader);
        byte _m_IsRotatableCopy = reader.ReadU8();
        reader.AlignTo(4); /* SnapType */
        int _SnapType = reader.ReadS32();
        PPtr<SnapMapBase> _Map = PPtr<SnapMapBase>.Read(reader);
        byte _SupressMapOverride = reader.ReadU8();
        reader.AlignTo(4); /* CameraOffsetScale */
        AnimationCurve _CameraOffsetScale = AnimationCurve.Read(reader);
        reader.AlignTo(4); /* ApplySizeScale */
        byte _ApplySizeScale = reader.ReadU8();
        reader.AlignTo(4); /* ApplyLifetimeScale */
        byte _ApplyLifetimeScale = reader.ReadU8();
        reader.AlignTo(4); /* ApplyRateOverTimeScale */
        byte _ApplyRateOverTimeScale = reader.ReadU8();
        reader.AlignTo(4); /* ApplyBurstScale */
        byte _ApplyBurstScale = reader.ReadU8();
        reader.AlignTo(4); /* PersistWhenDisabled */
        byte _PersistWhenDisabled = reader.ReadU8();
        reader.AlignTo(4); /* Offset */
        OffsetAnimationSettings _Offset = OffsetAnimationSettings.Read(reader);
        reader.AlignTo(4); /* BonesNames */
        AsciiString[] _BonesNames = BuiltInArray<AsciiString>.Read(reader);
        reader.AlignTo(4); /* m_LocatorGroups */
        Reference _m_LocatorGroups = Reference.Read(reader);
        reader.AlignTo(4); /* IgnoreSpecialBones */
        byte _IgnoreSpecialBones = reader.ReadU8();
        reader.AlignTo(4); /* m_useRandomBones */
        byte _m_useRandomBones = reader.ReadU8();
        reader.AlignTo(4); /* m_randomBonesPercent */
        float _m_randomBonesPercent = reader.ReadF32();
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_RotatableCopy,
            _m_IsRotatableCopy,
            _SnapType,
            _Map,
            _SupressMapOverride,
            _CameraOffsetScale,
            _ApplySizeScale,
            _ApplyLifetimeScale,
            _ApplyRateOverTimeScale,
            _ApplyBurstScale,
            _PersistWhenDisabled,
            _Offset,
            _BonesNames,
            _m_LocatorGroups,
            _IgnoreSpecialBones,
            _m_useRandomBones,
            _m_randomBonesPercent);
    }
}


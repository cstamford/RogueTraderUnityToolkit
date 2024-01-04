namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $UnitAnimationActionVariantIdle (15 fields) 096F187DCF4FB9CA4D46BA0782022FB3/7028E128D74E27A7C72F8B05D4C5C8F2 */
public record class UnitAnimationActionVariantIdle(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    float TransitionIn /* NeedsAlign */,
    float TransitionOut /* None */,
    int ExecutionMode /* None */,
    byte UseEmptyAvatarMask /* None */,
    PPtr<AvatarMask>[] AvatarMasks /* NeedsAlign */,
    byte m_ForDollRoom /* None */,
    PPtr<AnimationClipWrapper>[] m_ClipWrappers /* NeedsAlign */,
    TimedProbabilityCurve RetriggerProbability /* None */,
    byte PlayOnNPC /* None */,
    ClassOverrideData[] ClassOverrides /* NeedsAlign */,
    RaceOverrideData[] RaceOverrides /* NeedsAlign */)
{
    public static UnitAnimationActionVariantIdle Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* TransitionIn */
        float _TransitionIn = reader.ReadF32();
        float _TransitionOut = reader.ReadF32();
        int _ExecutionMode = reader.ReadS32();
        byte _UseEmptyAvatarMask = reader.ReadU8();
        reader.AlignTo(4); /* AvatarMasks */
        PPtr<AvatarMask>[] _AvatarMasks = BuiltInArray<PPtr<AvatarMask>>.Read(reader);
        byte _m_ForDollRoom = reader.ReadU8();
        reader.AlignTo(4); /* m_ClipWrappers */
        PPtr<AnimationClipWrapper>[] _m_ClipWrappers = BuiltInArray<PPtr<AnimationClipWrapper>>.Read(reader);
        TimedProbabilityCurve _RetriggerProbability = TimedProbabilityCurve.Read(reader);
        byte _PlayOnNPC = reader.ReadU8();
        reader.AlignTo(4); /* ClassOverrides */
        ClassOverrideData[] _ClassOverrides = BuiltInArray<ClassOverrideData>.Read(reader);
        reader.AlignTo(4); /* RaceOverrides */
        RaceOverrideData[] _RaceOverrides = BuiltInArray<RaceOverrideData>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _TransitionIn,
            _TransitionOut,
            _ExecutionMode,
            _UseEmptyAvatarMask,
            _AvatarMasks,
            _m_ForDollRoom,
            _m_ClipWrappers,
            _RetriggerProbability,
            _PlayOnNPC,
            _ClassOverrides,
            _RaceOverrides);
    }
}


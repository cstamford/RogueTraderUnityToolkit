namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $UnitAnimationActionMicroIdle (13 fields) 1E505926BBA34934FEBDBDCF3077D3C1/838CC65F9F94EE91EE92A181A590161B */
public record class UnitAnimationActionMicroIdle(
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
    TimedProbabilityCurve TriggerProbability /* NeedsAlign */,
    ClipList[] Variants /* None */,
    MaskedClipList[] OffHandAnimations /* None */)
{
    public static UnitAnimationActionMicroIdle Read(EndianBinaryReader reader)
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
        reader.AlignTo(4); /* TriggerProbability */
        TimedProbabilityCurve _TriggerProbability = TimedProbabilityCurve.Read(reader);
        ClipList[] _Variants = BuiltInArray<ClipList>.Read(reader);
        MaskedClipList[] _OffHandAnimations = BuiltInArray<MaskedClipList>.Read(reader);
        
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
            _TriggerProbability,
            _Variants,
            _OffHandAnimations);
    }
}


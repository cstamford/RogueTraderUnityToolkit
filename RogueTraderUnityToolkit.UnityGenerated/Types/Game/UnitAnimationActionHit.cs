namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $UnitAnimationActionHit (13 fields) 75336CED77C25813EF2D6F3052EA52D5/5A5B24D7270B1B0F0215F1930C2C7F74 */
public record class UnitAnimationActionHit(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    float TransitionIn /* NeedsAlign */,
    float TransitionOut /* None */,
    int ExecutionMode /* None */,
    byte UseEmptyAvatarMask /* None */,
    PPtr<AvatarMask>[] AvatarMasks /* NeedsAlign */,
    PPtr<AnimationClipWrapper> ClipWrapper /* None */,
    PPtr<AnimationClipWrapper>[] RandomClips /* None */,
    PPtr<AnimationClipWrapper>[] HitInFullCover /* None */,
    PPtr<AnimationClipWrapper>[] HitInHalfCover /* None */)
{
    public static UnitAnimationActionHit Read(EndianBinaryReader reader)
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
        PPtr<AnimationClipWrapper> _ClipWrapper = PPtr<AnimationClipWrapper>.Read(reader);
        PPtr<AnimationClipWrapper>[] _RandomClips = BuiltInArray<PPtr<AnimationClipWrapper>>.Read(reader);
        PPtr<AnimationClipWrapper>[] _HitInFullCover = BuiltInArray<PPtr<AnimationClipWrapper>>.Read(reader);
        PPtr<AnimationClipWrapper>[] _HitInHalfCover = BuiltInArray<PPtr<AnimationClipWrapper>>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _TransitionIn,
            _TransitionOut,
            _ExecutionMode,
            _UseEmptyAvatarMask,
            _AvatarMasks,
            _ClipWrapper,
            _RandomClips,
            _HitInFullCover,
            _HitInHalfCover);
    }
}


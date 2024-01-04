namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $UnitAnimationActionProne (17 fields) 2FD175706AFC2872DA4AD4F242016392/8F710E176C7B62199661568597981377 */
public record class UnitAnimationActionProne(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    float TransitionIn /* NeedsAlign */,
    float TransitionOut /* None */,
    int ExecutionMode /* None */,
    byte UseEmptyAvatarMask /* None */,
    PPtr<AvatarMask>[] AvatarMasks /* NeedsAlign */,
    PPtr<AnimationClipWrapper> m_Falling /* None */,
    PPtr<AnimationClipWrapper> m_DyingWhileProne /* None */,
    float m_TransitionToLyingTime /* None */,
    PPtr<AnimationClipWrapper> m_Dead /* None */,
    PPtr<AnimationClipWrapper> m_Unconscious /* None */,
    byte AllowFallingBelowGround /* None */,
    PPtr<AnimationClipWrapper> m_StandUpInIdle /* NeedsAlign */,
    WeaponStyleStandUp[] StandUpByWeaponStileInCombat /* None */)
{
    public static UnitAnimationActionProne Read(EndianBinaryReader reader)
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
        PPtr<AnimationClipWrapper> _m_Falling = PPtr<AnimationClipWrapper>.Read(reader);
        PPtr<AnimationClipWrapper> _m_DyingWhileProne = PPtr<AnimationClipWrapper>.Read(reader);
        float _m_TransitionToLyingTime = reader.ReadF32();
        PPtr<AnimationClipWrapper> _m_Dead = PPtr<AnimationClipWrapper>.Read(reader);
        PPtr<AnimationClipWrapper> _m_Unconscious = PPtr<AnimationClipWrapper>.Read(reader);
        byte _AllowFallingBelowGround = reader.ReadU8();
        reader.AlignTo(4); /* m_StandUpInIdle */
        PPtr<AnimationClipWrapper> _m_StandUpInIdle = PPtr<AnimationClipWrapper>.Read(reader);
        WeaponStyleStandUp[] _StandUpByWeaponStileInCombat = BuiltInArray<WeaponStyleStandUp>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _TransitionIn,
            _TransitionOut,
            _ExecutionMode,
            _UseEmptyAvatarMask,
            _AvatarMasks,
            _m_Falling,
            _m_DyingWhileProne,
            _m_TransitionToLyingTime,
            _m_Dead,
            _m_Unconscious,
            _AllowFallingBelowGround,
            _m_StandUpInIdle,
            _StandUpByWeaponStileInCombat);
    }
}


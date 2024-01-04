namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $WarhammerUnitAnimationActionLocoMotionHuman (15 fields) AA4362AC12D8FA7A8BF5EEAAECD51BF8/F581A9D27192491A227751E1485558B6 */
public record class WarhammerUnitAnimationActionLocoMotionHuman(
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
    PPtr<AnimationClipWrapper> NonCombatIdle /* NeedsAlign */,
    MovementStyleLayer NonCombatWalk /* None */,
    WeaponStyleIdleLayer[] CombatIdle /* NeedsAlign */,
    WeaponStyleLayer[] CombatWalk /* NeedsAlign */,
    PPtr<AvatarMask> OffHandMask /* NeedsAlign */)
{
    public static WarhammerUnitAnimationActionLocoMotionHuman Read(EndianBinaryReader reader)
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
        reader.AlignTo(4); /* NonCombatIdle */
        PPtr<AnimationClipWrapper> _NonCombatIdle = PPtr<AnimationClipWrapper>.Read(reader);
        MovementStyleLayer _NonCombatWalk = MovementStyleLayer.Read(reader);
        reader.AlignTo(4); /* CombatIdle */
        WeaponStyleIdleLayer[] _CombatIdle = BuiltInArray<WeaponStyleIdleLayer>.Read(reader);
        reader.AlignTo(4); /* CombatWalk */
        WeaponStyleLayer[] _CombatWalk = BuiltInArray<WeaponStyleLayer>.Read(reader);
        reader.AlignTo(4); /* OffHandMask */
        PPtr<AvatarMask> _OffHandMask = PPtr<AvatarMask>.Read(reader);
        
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
            _NonCombatIdle,
            _NonCombatWalk,
            _CombatIdle,
            _CombatWalk,
            _OffHandMask);
    }
}


namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $WarhammerUnitAnimationActionLocoMotion (14 fields) C0BB6F0AB74CE684AE8DCE3955076384/BE5A37C850EBE8A6731ACB1303637073 */
public record class WarhammerUnitAnimationActionLocoMotion(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    float TransitionIn /* NeedsAlign */,
    float TransitionOut /* None */,
    int ExecutionMode /* None */,
    byte UseEmptyAvatarMask /* None */,
    PPtr<AvatarMask>[] AvatarMasks /* NeedsAlign */,
    PPtr<AnimationClipWrapper> NonCombatIdle /* None */,
    WalkingStyleLayer NonCombatWalk /* None */,
    WeaponStyleIdleLayer CombatIdle /* NeedsAlign */,
    WeaponStyleWalkingLayer[] CombatWalk /* NeedsAlign */,
    PPtr<AvatarMask> OffHandMask /* NeedsAlign */)
{
    public static WarhammerUnitAnimationActionLocoMotion Read(EndianBinaryReader reader)
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
        PPtr<AnimationClipWrapper> _NonCombatIdle = PPtr<AnimationClipWrapper>.Read(reader);
        WalkingStyleLayer _NonCombatWalk = WalkingStyleLayer.Read(reader);
        reader.AlignTo(4); /* CombatIdle */
        WeaponStyleIdleLayer _CombatIdle = WeaponStyleIdleLayer.Read(reader);
        reader.AlignTo(4); /* CombatWalk */
        WeaponStyleWalkingLayer[] _CombatWalk = BuiltInArray<WeaponStyleWalkingLayer>.Read(reader);
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
            _NonCombatIdle,
            _NonCombatWalk,
            _CombatIdle,
            _CombatWalk,
            _OffHandMask);
    }
}


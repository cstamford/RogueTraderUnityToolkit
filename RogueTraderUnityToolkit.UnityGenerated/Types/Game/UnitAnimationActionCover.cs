namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $UnitAnimationActionCover (22 fields) 945664B8E635F5ABAAE35C0AF657EC1F/4A4EBD290D2BDCB9D515D76527588683 */
public record class UnitAnimationActionCover(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    float TransitionIn /* NeedsAlign */,
    float TransitionOut /* None */,
    int ExecutionMode /* None */,
    byte UseEmptyAvatarMask /* None */,
    PPtr<AvatarMask>[] AvatarMasks /* NeedsAlign */,
    PPtr<AnimationClipWrapper> HalfCoverEntering /* None */,
    PPtr<AnimationClipWrapper> HalfCoverIdle /* None */,
    PPtr<AnimationClipWrapper> HalfCoverExiting /* None */,
    PPtr<AnimationClipWrapper> FullCoverEntering /* None */,
    PPtr<AnimationClipWrapper> FullCoverIdle /* None */,
    PPtr<AnimationClipWrapper> FullCoverExiting /* None */,
    PPtr<AnimationClipWrapper> LeftStepFullCoverEntering /* None */,
    PPtr<AnimationClipWrapper> LeftStepFullCoverExiting /* None */,
    PPtr<AnimationClipWrapper> RightStepFullCoverEntering /* None */,
    PPtr<AnimationClipWrapper> RightStepFullCoverExiting /* None */,
    PPtr<AnimationClipWrapper> FullCoverInside /* None */,
    PPtr<AnimationClipWrapper> FullCoverOutside /* None */,
    WeaponStyleSettings m_WeaponStyleOverrides /* None */)
{
    public static UnitAnimationActionCover Read(EndianBinaryReader reader)
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
        PPtr<AnimationClipWrapper> _HalfCoverEntering = PPtr<AnimationClipWrapper>.Read(reader);
        PPtr<AnimationClipWrapper> _HalfCoverIdle = PPtr<AnimationClipWrapper>.Read(reader);
        PPtr<AnimationClipWrapper> _HalfCoverExiting = PPtr<AnimationClipWrapper>.Read(reader);
        PPtr<AnimationClipWrapper> _FullCoverEntering = PPtr<AnimationClipWrapper>.Read(reader);
        PPtr<AnimationClipWrapper> _FullCoverIdle = PPtr<AnimationClipWrapper>.Read(reader);
        PPtr<AnimationClipWrapper> _FullCoverExiting = PPtr<AnimationClipWrapper>.Read(reader);
        PPtr<AnimationClipWrapper> _LeftStepFullCoverEntering = PPtr<AnimationClipWrapper>.Read(reader);
        PPtr<AnimationClipWrapper> _LeftStepFullCoverExiting = PPtr<AnimationClipWrapper>.Read(reader);
        PPtr<AnimationClipWrapper> _RightStepFullCoverEntering = PPtr<AnimationClipWrapper>.Read(reader);
        PPtr<AnimationClipWrapper> _RightStepFullCoverExiting = PPtr<AnimationClipWrapper>.Read(reader);
        PPtr<AnimationClipWrapper> _FullCoverInside = PPtr<AnimationClipWrapper>.Read(reader);
        PPtr<AnimationClipWrapper> _FullCoverOutside = PPtr<AnimationClipWrapper>.Read(reader);
        WeaponStyleSettings _m_WeaponStyleOverrides = WeaponStyleSettings.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _TransitionIn,
            _TransitionOut,
            _ExecutionMode,
            _UseEmptyAvatarMask,
            _AvatarMasks,
            _HalfCoverEntering,
            _HalfCoverIdle,
            _HalfCoverExiting,
            _FullCoverEntering,
            _FullCoverIdle,
            _FullCoverExiting,
            _LeftStepFullCoverEntering,
            _LeftStepFullCoverExiting,
            _RightStepFullCoverEntering,
            _RightStepFullCoverExiting,
            _FullCoverInside,
            _FullCoverOutside,
            _m_WeaponStyleOverrides);
    }
}


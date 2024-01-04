namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $UnitAnimationActionDialog (11 fields) 94013A5D5471A19F13C1486088EAF68F/A24FD19C4D22AF976F51A7C718656AAF */
public record class UnitAnimationActionDialog(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    float TransitionIn /* NeedsAlign */,
    float TransitionOut /* None */,
    int ExecutionMode /* None */,
    byte UseEmptyAvatarMask /* None */,
    PPtr<AvatarMask>[] AvatarMasks /* NeedsAlign */,
    PPtr<AnimationClipWrapper>[] m_ClipWrappers /* None */,
    byte m_Dummy /* None */)
{
    public static UnitAnimationActionDialog Read(EndianBinaryReader reader)
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
        PPtr<AnimationClipWrapper>[] _m_ClipWrappers = BuiltInArray<PPtr<AnimationClipWrapper>>.Read(reader);
        byte _m_Dummy = reader.ReadU8();
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _TransitionIn,
            _TransitionOut,
            _ExecutionMode,
            _UseEmptyAvatarMask,
            _AvatarMasks,
            _m_ClipWrappers,
            _m_Dummy);
    }
}


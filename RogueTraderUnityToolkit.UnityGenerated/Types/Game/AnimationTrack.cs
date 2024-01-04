namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $AnimationTrack (32 fields) 58DA43C30ADDFD28EB699E89D57F440F/7C676BE0D90B4DDDDF823E6EC612FCBF */
public record class AnimationTrack(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    int m_Version /* NeedsAlign */,
    PPtr<AnimationClip> m_AnimClip /* None */,
    byte m_Locked /* None */,
    byte m_Muted /* NeedsAlign */,
    AsciiString m_CustomPlayableFullTypename /* NeedsAlign */,
    PPtr<AnimationClip> m_Curves /* NeedsAlign */,
    PPtr<PlayableAsset> m_Parent /* None */,
    PPtr<ScriptableObject>[] m_Children /* None */,
    TimelineClip[] m_Clips /* None */,
    MarkerList m_Markers /* NeedsAlign */,
    int m_InfiniteClipPreExtrapolation /* None */,
    int m_InfiniteClipPostExtrapolation /* None */,
    Vector3f m_InfiniteClipOffsetPosition /* None */,
    Vector3f m_InfiniteClipOffsetEulerAngles /* None */,
    double m_InfiniteClipTimeOffset /* None */,
    byte m_InfiniteClipRemoveOffset /* None */,
    byte m_InfiniteClipApplyFootIK /* NeedsAlign */,
    int mInfiniteClipLoop /* NeedsAlign */,
    int m_MatchTargetFields /* None */,
    Vector3f m_Position /* None */,
    Vector3f m_EulerAngles /* None */,
    PPtr<AvatarMask> m_AvatarMask /* None */,
    byte m_ApplyAvatarMask /* None */,
    int m_TrackOffset /* NeedsAlign */,
    PPtr<AnimationClip> m_InfiniteClip /* None */,
    Quaternionf m_OpenClipOffsetRotation /* None */,
    Quaternionf m_Rotation /* None */,
    byte m_ApplyOffsets /* None */)
{
    public static AnimationTrack Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_Version */
        int _m_Version = reader.ReadS32();
        PPtr<AnimationClip> _m_AnimClip = PPtr<AnimationClip>.Read(reader);
        byte _m_Locked = reader.ReadU8();
        reader.AlignTo(4); /* m_Muted */
        byte _m_Muted = reader.ReadU8();
        reader.AlignTo(4); /* m_CustomPlayableFullTypename */
        AsciiString _m_CustomPlayableFullTypename = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_Curves */
        PPtr<AnimationClip> _m_Curves = PPtr<AnimationClip>.Read(reader);
        PPtr<PlayableAsset> _m_Parent = PPtr<PlayableAsset>.Read(reader);
        PPtr<ScriptableObject>[] _m_Children = BuiltInArray<PPtr<ScriptableObject>>.Read(reader);
        TimelineClip[] _m_Clips = BuiltInArray<TimelineClip>.Read(reader);
        reader.AlignTo(4); /* m_Markers */
        MarkerList _m_Markers = MarkerList.Read(reader);
        int _m_InfiniteClipPreExtrapolation = reader.ReadS32();
        int _m_InfiniteClipPostExtrapolation = reader.ReadS32();
        Vector3f _m_InfiniteClipOffsetPosition = Vector3f.Read(reader);
        Vector3f _m_InfiniteClipOffsetEulerAngles = Vector3f.Read(reader);
        double _m_InfiniteClipTimeOffset = reader.ReadF64();
        byte _m_InfiniteClipRemoveOffset = reader.ReadU8();
        reader.AlignTo(4); /* m_InfiniteClipApplyFootIK */
        byte _m_InfiniteClipApplyFootIK = reader.ReadU8();
        reader.AlignTo(4); /* mInfiniteClipLoop */
        int _mInfiniteClipLoop = reader.ReadS32();
        int _m_MatchTargetFields = reader.ReadS32();
        Vector3f _m_Position = Vector3f.Read(reader);
        Vector3f _m_EulerAngles = Vector3f.Read(reader);
        PPtr<AvatarMask> _m_AvatarMask = PPtr<AvatarMask>.Read(reader);
        byte _m_ApplyAvatarMask = reader.ReadU8();
        reader.AlignTo(4); /* m_TrackOffset */
        int _m_TrackOffset = reader.ReadS32();
        PPtr<AnimationClip> _m_InfiniteClip = PPtr<AnimationClip>.Read(reader);
        Quaternionf _m_OpenClipOffsetRotation = Quaternionf.Read(reader);
        Quaternionf _m_Rotation = Quaternionf.Read(reader);
        byte _m_ApplyOffsets = reader.ReadU8();
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_Version,
            _m_AnimClip,
            _m_Locked,
            _m_Muted,
            _m_CustomPlayableFullTypename,
            _m_Curves,
            _m_Parent,
            _m_Children,
            _m_Clips,
            _m_Markers,
            _m_InfiniteClipPreExtrapolation,
            _m_InfiniteClipPostExtrapolation,
            _m_InfiniteClipOffsetPosition,
            _m_InfiniteClipOffsetEulerAngles,
            _m_InfiniteClipTimeOffset,
            _m_InfiniteClipRemoveOffset,
            _m_InfiniteClipApplyFootIK,
            _mInfiniteClipLoop,
            _m_MatchTargetFields,
            _m_Position,
            _m_EulerAngles,
            _m_AvatarMask,
            _m_ApplyAvatarMask,
            _m_TrackOffset,
            _m_InfiniteClip,
            _m_OpenClipOffsetRotation,
            _m_Rotation,
            _m_ApplyOffsets);
    }
}


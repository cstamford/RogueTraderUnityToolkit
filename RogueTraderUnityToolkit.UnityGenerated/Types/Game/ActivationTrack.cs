namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $ActivationTrack (15 fields) 84ED86023C6E6A939A04BA4D1C7B1AE2/B06929CEA827AD70B6A9988A4D44FF32 */
public record class ActivationTrack(
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
    TimelineClip m_Clips /* None */,
    MarkerList m_Markers /* NeedsAlign */,
    int m_PostPlaybackState /* None */)
{
    public static ActivationTrack Read(EndianBinaryReader reader)
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
        TimelineClip _m_Clips = TimelineClip.Read(reader);
        reader.AlignTo(4); /* m_Markers */
        MarkerList _m_Markers = MarkerList.Read(reader);
        int _m_PostPlaybackState = reader.ReadS32();
        
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
            _m_PostPlaybackState);
    }
}


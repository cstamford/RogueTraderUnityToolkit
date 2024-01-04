namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $CinemachineTrack (14 fields) A00E14BE5B25111A76091C65B155AC61/447FE15414025712CEBCFA9EFE54E568 */
public record class CinemachineTrack(
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
    MarkerList m_Markers /* NeedsAlign */)
{
    public static CinemachineTrack Read(EndianBinaryReader reader)
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
            _m_Markers);
    }
}


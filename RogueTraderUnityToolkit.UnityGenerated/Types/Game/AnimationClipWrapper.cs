namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $AnimationClipWrapper (6 fields) 3061E5BE3942A45A42316E027C11C40C/58FAB902981B6A6A0C11985051AEC966 */
public record class AnimationClipWrapper(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<AnimationClip> m_AnimationClip /* NeedsAlign */,
    PPtr<AnimationClipEventTrack>[] m_EventTracks /* None */)
{
    public static AnimationClipWrapper Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_AnimationClip */
        PPtr<AnimationClip> _m_AnimationClip = PPtr<AnimationClip>.Read(reader);
        PPtr<AnimationClipEventTrack>[] _m_EventTracks = BuiltInArray<PPtr<AnimationClipEventTrack>>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_AnimationClip,
            _m_EventTracks);
    }
}


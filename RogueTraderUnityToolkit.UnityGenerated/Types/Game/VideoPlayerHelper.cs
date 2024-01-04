namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $VideoPlayerHelper (8 fields) B1008BCA94E5F8095E25779277654134/509C1747194BDBD7B25B750B9607C9FD */
public record class VideoPlayerHelper(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<VideoClip> m_VideoClip /* NeedsAlign */,
    byte m_PlayOnAwake /* None */,
    byte m_IsLooping /* NeedsAlign */,
    int m_AspectRatio /* NeedsAlign */)
{
    public static VideoPlayerHelper Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_VideoClip */
        PPtr<VideoClip> _m_VideoClip = PPtr<VideoClip>.Read(reader);
        byte _m_PlayOnAwake = reader.ReadU8();
        reader.AlignTo(4); /* m_IsLooping */
        byte _m_IsLooping = reader.ReadU8();
        reader.AlignTo(4); /* m_AspectRatio */
        int _m_AspectRatio = reader.ReadS32();
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_VideoClip,
            _m_PlayOnAwake,
            _m_IsLooping,
            _m_AspectRatio);
    }
}


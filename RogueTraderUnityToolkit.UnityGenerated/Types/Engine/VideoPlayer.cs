namespace RogueTraderUnityToolkit.UnityGenerated.Types.Engine;

using Core;
using Unity;

/* $VideoPlayer (28 fields) 8309167C511C189EE68C72C3136BD187 */
public record class VideoPlayer(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<VideoClip> m_VideoClip /* NeedsAlign */,
    float m_TargetCameraAlpha /* None */,
    int m_TargetCamera3DLayout /* None */,
    PPtr<Camera> m_TargetCamera /* None */,
    PPtr<RenderTexture> m_TargetTexture /* None */,
    int m_TimeReference /* None */,
    PPtr<Renderer> m_TargetMaterialRenderer /* None */,
    AsciiString m_TargetMaterialProperty /* None */,
    int m_RenderMode /* NeedsAlign */,
    int m_AspectRatio /* None */,
    int m_DataSource /* None */,
    int m_TimeUpdateMode /* None */,
    float m_PlaybackSpeed /* None */,
    int m_AudioOutputMode /* None */,
    PPtr<AudioSource>[] m_TargetAudioSources /* None */,
    float[] m_DirectAudioVolumes /* NeedsAlign */,
    AsciiString m_Url /* NeedsAlign */,
    bool[] m_EnabledAudioTracks /* NeedsAlign */,
    bool[] m_DirectAudioMutes /* NeedsAlign */,
    ushort m_ControlledAudioTrackCount /* NeedsAlign */,
    bool m_PlayOnAwake /* None */,
    bool m_SkipOnDrop /* None */,
    bool m_Looping /* None */,
    bool m_WaitForFirstFrame /* None */,
    bool m_FrameReadyEventEnabled /* None */,
    PPtr<Shader>[] m_VideoShaders /* NeedsAlign */) : IUnityObject
{
    public static Hash128 Hash => new(2198410876, 1360795806, 3867964099, 325833095);
    public static VideoPlayer Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_VideoClip */
        PPtr<VideoClip> _m_VideoClip = PPtr<VideoClip>.Read(reader);
        float _m_TargetCameraAlpha = reader.ReadF32();
        int _m_TargetCamera3DLayout = reader.ReadS32();
        PPtr<Camera> _m_TargetCamera = PPtr<Camera>.Read(reader);
        PPtr<RenderTexture> _m_TargetTexture = PPtr<RenderTexture>.Read(reader);
        int _m_TimeReference = reader.ReadS32();
        PPtr<Renderer> _m_TargetMaterialRenderer = PPtr<Renderer>.Read(reader);
        AsciiString _m_TargetMaterialProperty = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_RenderMode */
        int _m_RenderMode = reader.ReadS32();
        int _m_AspectRatio = reader.ReadS32();
        int _m_DataSource = reader.ReadS32();
        int _m_TimeUpdateMode = reader.ReadS32();
        float _m_PlaybackSpeed = reader.ReadF32();
        int _m_AudioOutputMode = reader.ReadS32();
        PPtr<AudioSource>[] _m_TargetAudioSources = BuiltInArray<PPtr<AudioSource>>.Read(reader);
        reader.AlignTo(4); /* m_DirectAudioVolumes */
        float[] _m_DirectAudioVolumes = BuiltInArray<float>.Read(reader);
        reader.AlignTo(4); /* m_Url */
        AsciiString _m_Url = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_EnabledAudioTracks */
        bool[] _m_EnabledAudioTracks = BuiltInArray<bool>.Read(reader);
        reader.AlignTo(4); /* m_DirectAudioMutes */
        bool[] _m_DirectAudioMutes = BuiltInArray<bool>.Read(reader);
        reader.AlignTo(4); /* m_ControlledAudioTrackCount */
        ushort _m_ControlledAudioTrackCount = reader.ReadU16();
        bool _m_PlayOnAwake = reader.ReadBool();
        bool _m_SkipOnDrop = reader.ReadBool();
        bool _m_Looping = reader.ReadBool();
        bool _m_WaitForFirstFrame = reader.ReadBool();
        bool _m_FrameReadyEventEnabled = reader.ReadBool();
        reader.AlignTo(4); /* m_VideoShaders */
        PPtr<Shader>[] _m_VideoShaders = BuiltInArray<PPtr<Shader>>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_VideoClip,
            _m_TargetCameraAlpha,
            _m_TargetCamera3DLayout,
            _m_TargetCamera,
            _m_TargetTexture,
            _m_TimeReference,
            _m_TargetMaterialRenderer,
            _m_TargetMaterialProperty,
            _m_RenderMode,
            _m_AspectRatio,
            _m_DataSource,
            _m_TimeUpdateMode,
            _m_PlaybackSpeed,
            _m_AudioOutputMode,
            _m_TargetAudioSources,
            _m_DirectAudioVolumes,
            _m_Url,
            _m_EnabledAudioTracks,
            _m_DirectAudioMutes,
            _m_ControlledAudioTrackCount,
            _m_PlayOnAwake,
            _m_SkipOnDrop,
            _m_Looping,
            _m_WaitForFirstFrame,
            _m_FrameReadyEventEnabled,
            _m_VideoShaders);
    }
}


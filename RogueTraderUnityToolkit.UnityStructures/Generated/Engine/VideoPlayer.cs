namespace RogueTraderUnityToolkit.UnityStructures.Generated.Engine;

using Core;
using Unity.BuiltInTypes;

/* $VideoPlayer (28 fields) (IsEngineType) */
public record class VideoPlayer(
    PPtr<GameObject> m_GameObject,
    byte m_Enabled,
    PPtr<VideoClip> m_VideoClip,
    float m_TargetCameraAlpha,
    int m_TargetCamera3DLayout,
    PPtr<Camera> m_TargetCamera,
    PPtr<RenderTexture> m_TargetTexture,
    int m_TimeReference,
    PPtr<Renderer> m_TargetMaterialRenderer,
    AsciiString m_TargetMaterialProperty,
    int m_RenderMode,
    int m_AspectRatio,
    int m_DataSource,
    int m_TimeUpdateMode,
    float m_PlaybackSpeed,
    int m_AudioOutputMode,
    PPtr<AudioSource>[] m_TargetAudioSources,
    float[] m_DirectAudioVolumes,
    AsciiString m_Url,
    bool[] m_EnabledAudioTracks,
    bool[] m_DirectAudioMutes,
    ushort m_ControlledAudioTrackCount,
    bool m_PlayOnAwake,
    bool m_SkipOnDrop,
    bool m_Looping,
    bool m_WaitForFirstFrame,
    bool m_FrameReadyEventEnabled,
    PPtr<Shader>[] m_VideoShaders)
{
    public static VideoPlayer Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> m_GameObject = PPtr<GameObject>.Read(reader);
        byte m_Enabled = reader.ReadU8();
        PPtr<VideoClip> m_VideoClip = PPtr<VideoClip>.Read(reader);
        float m_TargetCameraAlpha = reader.ReadF32();
        int m_TargetCamera3DLayout = reader.ReadS32();
        PPtr<Camera> m_TargetCamera = PPtr<Camera>.Read(reader);
        PPtr<RenderTexture> m_TargetTexture = PPtr<RenderTexture>.Read(reader);
        int m_TimeReference = reader.ReadS32();
        PPtr<Renderer> m_TargetMaterialRenderer = PPtr<Renderer>.Read(reader);
        AsciiString m_TargetMaterialProperty = String.Read(reader);
        int m_RenderMode = reader.ReadS32();
        int m_AspectRatio = reader.ReadS32();
        int m_DataSource = reader.ReadS32();
        int m_TimeUpdateMode = reader.ReadS32();
        float m_PlaybackSpeed = reader.ReadF32();
        int m_AudioOutputMode = reader.ReadS32();
        PPtr<AudioSource>[] m_TargetAudioSources = Array<PPtr<AudioSource>>.Read(reader);
        float[] m_DirectAudioVolumes = Array<float>.Read(reader);
        AsciiString m_Url = String.Read(reader);
        bool[] m_EnabledAudioTracks = Array<bool>.Read(reader);
        bool[] m_DirectAudioMutes = Array<bool>.Read(reader);
        ushort m_ControlledAudioTrackCount = reader.ReadU16();
        bool m_PlayOnAwake = reader.ReadBool();
        bool m_SkipOnDrop = reader.ReadBool();
        bool m_Looping = reader.ReadBool();
        bool m_WaitForFirstFrame = reader.ReadBool();
        bool m_FrameReadyEventEnabled = reader.ReadBool();
        PPtr<Shader>[] m_VideoShaders = Array<PPtr<Shader>>.Read(reader);
        
        return new(m_GameObject,
            m_Enabled,
            m_VideoClip,
            m_TargetCameraAlpha,
            m_TargetCamera3DLayout,
            m_TargetCamera,
            m_TargetTexture,
            m_TimeReference,
            m_TargetMaterialRenderer,
            m_TargetMaterialProperty,
            m_RenderMode,
            m_AspectRatio,
            m_DataSource,
            m_TimeUpdateMode,
            m_PlaybackSpeed,
            m_AudioOutputMode,
            m_TargetAudioSources,
            m_DirectAudioVolumes,
            m_Url,
            m_EnabledAudioTracks,
            m_DirectAudioMutes,
            m_ControlledAudioTrackCount,
            m_PlayOnAwake,
            m_SkipOnDrop,
            m_Looping,
            m_WaitForFirstFrame,
            m_FrameReadyEventEnabled,
            m_VideoShaders);
    }
}


namespace RogueTraderUnityToolkit.UnityGenerated.Types.Engine;

using Core;
using System.Text;
using Unity;

/* $VideoPlayer (28 fields) 8309167C511C189EE68C72C3136BD187 */
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
    PPtr<Shader>[] m_VideoShaders) : IUnityEngineStructure
{
    public static Hash128 Hash => new(2198410876, 1360795806, 3867964099, 325833095);

    public static VideoPlayer Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Enabled */
        PPtr<VideoClip> _m_VideoClip = PPtr<VideoClip>.Read(reader);
        float _m_TargetCameraAlpha = reader.ReadF32();
        int _m_TargetCamera3DLayout = reader.ReadS32();
        PPtr<Camera> _m_TargetCamera = PPtr<Camera>.Read(reader);
        PPtr<RenderTexture> _m_TargetTexture = PPtr<RenderTexture>.Read(reader);
        int _m_TimeReference = reader.ReadS32();
        PPtr<Renderer> _m_TargetMaterialRenderer = PPtr<Renderer>.Read(reader);
        AsciiString _m_TargetMaterialProperty = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_TargetMaterialProperty */
        int _m_RenderMode = reader.ReadS32();
        int _m_AspectRatio = reader.ReadS32();
        int _m_DataSource = reader.ReadS32();
        int _m_TimeUpdateMode = reader.ReadS32();
        float _m_PlaybackSpeed = reader.ReadF32();
        int _m_AudioOutputMode = reader.ReadS32();
        PPtr<AudioSource>[] _m_TargetAudioSources = BuiltInArray<PPtr<AudioSource>>.Read(reader);
        reader.AlignTo(4); /* m_TargetAudioSources */
        float[] _m_DirectAudioVolumes = BuiltInArray<float>.Read(reader);
        reader.AlignTo(4); /* m_DirectAudioVolumes */
        AsciiString _m_Url = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_Url */
        bool[] _m_EnabledAudioTracks = BuiltInArray<bool>.Read(reader);
        reader.AlignTo(4); /* m_EnabledAudioTracks */
        bool[] _m_DirectAudioMutes = BuiltInArray<bool>.Read(reader);
        reader.AlignTo(4); /* m_DirectAudioMutes */
        ushort _m_ControlledAudioTrackCount = reader.ReadU16();
        bool _m_PlayOnAwake = reader.ReadBool();
        bool _m_SkipOnDrop = reader.ReadBool();
        bool _m_Looping = reader.ReadBool();
        bool _m_WaitForFirstFrame = reader.ReadBool();
        bool _m_FrameReadyEventEnabled = reader.ReadBool();
        reader.AlignTo(4); /* m_FrameReadyEventEnabled */
        PPtr<Shader>[] _m_VideoShaders = BuiltInArray<PPtr<Shader>>.Read(reader);
        reader.AlignTo(4); /* m_VideoShaders */
        
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

    public override string ToString() => $"VideoPlayer\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_GameObject: ");
        sb.AppendLine(m_GameObject.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Enabled: ");
        sb.AppendLine(m_Enabled.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_VideoClip: ");
        sb.AppendLine(m_VideoClip.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_TargetCameraAlpha: ");
        sb.AppendLine(m_TargetCameraAlpha.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_TargetCamera3DLayout: ");
        sb.AppendLine(m_TargetCamera3DLayout.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_TargetCamera: ");
        sb.AppendLine(m_TargetCamera.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_TargetTexture: ");
        sb.AppendLine(m_TargetTexture.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_TimeReference: ");
        sb.AppendLine(m_TimeReference.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_TargetMaterialRenderer: ");
        sb.AppendLine(m_TargetMaterialRenderer.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_TargetMaterialProperty: ");
        sb.AppendLine(m_TargetMaterialProperty.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_RenderMode: ");
        sb.AppendLine(m_RenderMode.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_AspectRatio: ");
        sb.AppendLine(m_AspectRatio.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_DataSource: ");
        sb.AppendLine(m_DataSource.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_TimeUpdateMode: ");
        sb.AppendLine(m_TimeUpdateMode.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_PlaybackSpeed: ");
        sb.AppendLine(m_PlaybackSpeed.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_AudioOutputMode: ");
        sb.AppendLine(m_AudioOutputMode.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_TargetAudioSources: ");
        sb.AppendLine(m_TargetAudioSources.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_DirectAudioVolumes: ");
        sb.AppendLine(m_DirectAudioVolumes.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Url: ");
        sb.AppendLine(m_Url.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_EnabledAudioTracks: ");
        sb.AppendLine(m_EnabledAudioTracks.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_DirectAudioMutes: ");
        sb.AppendLine(m_DirectAudioMutes.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_ControlledAudioTrackCount: ");
        sb.AppendLine(m_ControlledAudioTrackCount.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_PlayOnAwake: ");
        sb.AppendLine(m_PlayOnAwake.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_SkipOnDrop: ");
        sb.AppendLine(m_SkipOnDrop.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Looping: ");
        sb.AppendLine(m_Looping.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_WaitForFirstFrame: ");
        sb.AppendLine(m_WaitForFirstFrame.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_FrameReadyEventEnabled: ");
        sb.AppendLine(m_FrameReadyEventEnabled.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_VideoShaders: ");
        sb.AppendLine(m_VideoShaders.ToString());

        return sb.ToString();
    }
}


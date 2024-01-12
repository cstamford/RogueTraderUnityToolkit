namespace RogueTraderUnityToolkit.UnityGenerated.Types.Engine;

using Core;
using System.Text;
using Unity;

/* $VideoPlayer (28 fields) VideoPlayer 8309167C511C189EE68C72C3136BD187 */
public record class VideoPlayer (
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
    public static UnityObjectType ObjectType => UnityObjectType.VideoPlayer;
    public static Hash128 Hash => new("8309167C511C189EE68C72C3136BD187");
    public static VideoPlayer Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> m_GameObject_ = PPtr<GameObject>.Read(reader);
        byte m_Enabled_ = reader.ReadU8();
        reader.AlignTo(4); /* m_Enabled */
        PPtr<VideoClip> m_VideoClip_ = PPtr<VideoClip>.Read(reader);
        float m_TargetCameraAlpha_ = reader.ReadF32();
        int m_TargetCamera3DLayout_ = reader.ReadS32();
        PPtr<Camera> m_TargetCamera_ = PPtr<Camera>.Read(reader);
        PPtr<RenderTexture> m_TargetTexture_ = PPtr<RenderTexture>.Read(reader);
        int m_TimeReference_ = reader.ReadS32();
        PPtr<Renderer> m_TargetMaterialRenderer_ = PPtr<Renderer>.Read(reader);
        AsciiString m_TargetMaterialProperty_ = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_TargetMaterialProperty */
        int m_RenderMode_ = reader.ReadS32();
        int m_AspectRatio_ = reader.ReadS32();
        int m_DataSource_ = reader.ReadS32();
        int m_TimeUpdateMode_ = reader.ReadS32();
        float m_PlaybackSpeed_ = reader.ReadF32();
        int m_AudioOutputMode_ = reader.ReadS32();
        PPtr<AudioSource>[] m_TargetAudioSources_ = BuiltInArray<PPtr<AudioSource>>.Read(reader);
        reader.AlignTo(4); /* m_TargetAudioSources */
        float[] m_DirectAudioVolumes_ = BuiltInArray<float>.Read(reader);
        reader.AlignTo(4); /* m_DirectAudioVolumes */
        AsciiString m_Url_ = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_Url */
        bool[] m_EnabledAudioTracks_ = BuiltInArray<bool>.Read(reader);
        reader.AlignTo(4); /* m_EnabledAudioTracks */
        bool[] m_DirectAudioMutes_ = BuiltInArray<bool>.Read(reader);
        reader.AlignTo(4); /* m_DirectAudioMutes */
        ushort m_ControlledAudioTrackCount_ = reader.ReadU16();
        bool m_PlayOnAwake_ = reader.ReadBool();
        bool m_SkipOnDrop_ = reader.ReadBool();
        bool m_Looping_ = reader.ReadBool();
        bool m_WaitForFirstFrame_ = reader.ReadBool();
        bool m_FrameReadyEventEnabled_ = reader.ReadBool();
        reader.AlignTo(4); /* m_FrameReadyEventEnabled */
        PPtr<Shader>[] m_VideoShaders_ = BuiltInArray<PPtr<Shader>>.Read(reader);
        reader.AlignTo(4); /* m_VideoShaders */
        
        return new(m_GameObject_,
            m_Enabled_,
            m_VideoClip_,
            m_TargetCameraAlpha_,
            m_TargetCamera3DLayout_,
            m_TargetCamera_,
            m_TargetTexture_,
            m_TimeReference_,
            m_TargetMaterialRenderer_,
            m_TargetMaterialProperty_,
            m_RenderMode_,
            m_AspectRatio_,
            m_DataSource_,
            m_TimeUpdateMode_,
            m_PlaybackSpeed_,
            m_AudioOutputMode_,
            m_TargetAudioSources_,
            m_DirectAudioVolumes_,
            m_Url_,
            m_EnabledAudioTracks_,
            m_DirectAudioMutes_,
            m_ControlledAudioTrackCount_,
            m_PlayOnAwake_,
            m_SkipOnDrop_,
            m_Looping_,
            m_WaitForFirstFrame_,
            m_FrameReadyEventEnabled_,
            m_VideoShaders_);
    }

    public override string ToString() => $"VideoPlayer\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();
        string indent_ = ' '.Repeat(indent);

        ToString_Field0(sb, indent, indent_);
        ToString_Field1(sb, indent, indent_);
        ToString_Field2(sb, indent, indent_);
        ToString_Field3(sb, indent, indent_);
        ToString_Field4(sb, indent, indent_);
        ToString_Field5(sb, indent, indent_);
        ToString_Field6(sb, indent, indent_);
        ToString_Field7(sb, indent, indent_);
        ToString_Field8(sb, indent, indent_);
        ToString_Field9(sb, indent, indent_);
        ToString_Field10(sb, indent, indent_);
        ToString_Field11(sb, indent, indent_);
        ToString_Field12(sb, indent, indent_);
        ToString_Field13(sb, indent, indent_);
        ToString_Field14(sb, indent, indent_);
        ToString_Field15(sb, indent, indent_);
        ToString_Field16(sb, indent, indent_);
        ToString_Field17(sb, indent, indent_);
        ToString_Field18(sb, indent, indent_);
        ToString_Field19(sb, indent, indent_);
        ToString_Field20(sb, indent, indent_);
        ToString_Field21(sb, indent, indent_);
        ToString_Field22(sb, indent, indent_);
        ToString_Field23(sb, indent, indent_);
        ToString_Field24(sb, indent, indent_);
        ToString_Field25(sb, indent, indent_);
        ToString_Field26(sb, indent, indent_);
        ToString_Field27(sb, indent, indent_);

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_GameObject: {m_GameObject}");
    }

    public void ToString_Field1(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_Enabled: {m_Enabled}");
    }

    public void ToString_Field2(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_VideoClip: {m_VideoClip}");
    }

    public void ToString_Field3(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_TargetCameraAlpha: {m_TargetCameraAlpha}");
    }

    public void ToString_Field4(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_TargetCamera3DLayout: {m_TargetCamera3DLayout}");
    }

    public void ToString_Field5(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_TargetCamera: {m_TargetCamera}");
    }

    public void ToString_Field6(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_TargetTexture: {m_TargetTexture}");
    }

    public void ToString_Field7(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_TimeReference: {m_TimeReference}");
    }

    public void ToString_Field8(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_TargetMaterialRenderer: {m_TargetMaterialRenderer}");
    }

    public void ToString_Field9(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_TargetMaterialProperty: \"{m_TargetMaterialProperty}\"");
    }

    public void ToString_Field10(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_RenderMode: {m_RenderMode}");
    }

    public void ToString_Field11(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_AspectRatio: {m_AspectRatio}");
    }

    public void ToString_Field12(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_DataSource: {m_DataSource}");
    }

    public void ToString_Field13(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_TimeUpdateMode: {m_TimeUpdateMode}");
    }

    public void ToString_Field14(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_PlaybackSpeed: {m_PlaybackSpeed}");
    }

    public void ToString_Field15(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_AudioOutputMode: {m_AudioOutputMode}");
    }

    public void ToString_Field16(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_TargetAudioSources[{m_TargetAudioSources.Length}] = {{");
        if (m_TargetAudioSources.Length > 0) sb.AppendLine();
        int _4i = 0;
        foreach (PPtr<AudioSource> _4 in m_TargetAudioSources)
        {
            sb.AppendLine($"{indent_ + ' '.Repeat(4)}[{_4i}] = {_4}");
            ++_4i;
        }
        if (m_TargetAudioSources.Length > 0) sb.Append(indent_);
        sb.AppendLine("}");
    }

    public void ToString_Field17(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_DirectAudioVolumes[{m_DirectAudioVolumes.Length}] = {{");
        if (m_DirectAudioVolumes.Length > 0) sb.AppendLine();
        int _4i = 0;
        foreach (float _4 in m_DirectAudioVolumes)
        {
            sb.AppendLine($"{indent_ + ' '.Repeat(4)}[{_4i}] = {_4}");
            ++_4i;
        }
        if (m_DirectAudioVolumes.Length > 0) sb.Append(indent_);
        sb.AppendLine("}");
    }

    public void ToString_Field18(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_Url: \"{m_Url}\"");
    }

    public void ToString_Field19(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_EnabledAudioTracks[{m_EnabledAudioTracks.Length}] = {{");
        if (m_EnabledAudioTracks.Length > 0) sb.AppendLine();
        int _4i = 0;
        foreach (bool _4 in m_EnabledAudioTracks)
        {
            sb.AppendLine($"{indent_ + ' '.Repeat(4)}[{_4i}] = {_4}");
            ++_4i;
        }
        if (m_EnabledAudioTracks.Length > 0) sb.Append(indent_);
        sb.AppendLine("}");
    }

    public void ToString_Field20(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_DirectAudioMutes[{m_DirectAudioMutes.Length}] = {{");
        if (m_DirectAudioMutes.Length > 0) sb.AppendLine();
        int _4i = 0;
        foreach (bool _4 in m_DirectAudioMutes)
        {
            sb.AppendLine($"{indent_ + ' '.Repeat(4)}[{_4i}] = {_4}");
            ++_4i;
        }
        if (m_DirectAudioMutes.Length > 0) sb.Append(indent_);
        sb.AppendLine("}");
    }

    public void ToString_Field21(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_ControlledAudioTrackCount: {m_ControlledAudioTrackCount}");
    }

    public void ToString_Field22(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_PlayOnAwake: {m_PlayOnAwake}");
    }

    public void ToString_Field23(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_SkipOnDrop: {m_SkipOnDrop}");
    }

    public void ToString_Field24(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_Looping: {m_Looping}");
    }

    public void ToString_Field25(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_WaitForFirstFrame: {m_WaitForFirstFrame}");
    }

    public void ToString_Field26(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_FrameReadyEventEnabled: {m_FrameReadyEventEnabled}");
    }

    public void ToString_Field27(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_VideoShaders[{m_VideoShaders.Length}] = {{");
        if (m_VideoShaders.Length > 0) sb.AppendLine();
        int _4i = 0;
        foreach (PPtr<Shader> _4 in m_VideoShaders)
        {
            sb.AppendLine($"{indent_ + ' '.Repeat(4)}[{_4i}] = {_4}");
            ++_4i;
        }
        if (m_VideoShaders.Length > 0) sb.Append(indent_);
        sb.AppendLine("}");
    }
}


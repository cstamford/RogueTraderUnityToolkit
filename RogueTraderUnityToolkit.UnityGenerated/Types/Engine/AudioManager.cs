namespace RogueTraderUnityToolkit.UnityGenerated.Types.Engine;

using Core;
using System.Text;
using Unity;

/* $AudioManager (13 fields) AudioManager 9D77426282A6018654F7E310EE504546 */
public record class AudioManager (
    float m_Volume,
    float Rolloff_Scale,
    float Doppler_Factor,
    int Default_Speaker_Mode,
    int m_SampleRate,
    int m_DSPBufferSize,
    int m_VirtualVoiceCount,
    int m_RealVoiceCount,
    AsciiString m_SpatializerPlugin,
    AsciiString m_AmbisonicDecoderPlugin,
    bool m_DisableAudio,
    bool m_VirtualizeEffects,
    int m_RequestedDSPBufferSize) : IUnityEngineStructure
{
    public static UnityObjectType ObjectType => UnityObjectType.AudioManager;
    public static Hash128 Hash => new("9D77426282A6018654F7E310EE504546");
    public static AudioManager Read(EndianBinaryReader reader)
    {
        float m_Volume_ = reader.ReadF32();
        float Rolloff_Scale_ = reader.ReadF32();
        float Doppler_Factor_ = reader.ReadF32();
        int Default_Speaker_Mode_ = reader.ReadS32();
        int m_SampleRate_ = reader.ReadS32();
        int m_DSPBufferSize_ = reader.ReadS32();
        int m_VirtualVoiceCount_ = reader.ReadS32();
        int m_RealVoiceCount_ = reader.ReadS32();
        reader.AlignTo(4); /* m_RealVoiceCount */
        AsciiString m_SpatializerPlugin_ = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_SpatializerPlugin */
        AsciiString m_AmbisonicDecoderPlugin_ = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_AmbisonicDecoderPlugin */
        bool m_DisableAudio_ = reader.ReadBool();
        bool m_VirtualizeEffects_ = reader.ReadBool();
        reader.AlignTo(4); /* m_VirtualizeEffects */
        int m_RequestedDSPBufferSize_ = reader.ReadS32();
        
        return new(m_Volume_,
            Rolloff_Scale_,
            Doppler_Factor_,
            Default_Speaker_Mode_,
            m_SampleRate_,
            m_DSPBufferSize_,
            m_VirtualVoiceCount_,
            m_RealVoiceCount_,
            m_SpatializerPlugin_,
            m_AmbisonicDecoderPlugin_,
            m_DisableAudio_,
            m_VirtualizeEffects_,
            m_RequestedDSPBufferSize_);
    }

    public override string ToString() => $"AudioManager\n{ToString(4)}";

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

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_Volume: {m_Volume}");
    }

    public void ToString_Field1(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}Rolloff_Scale: {Rolloff_Scale}");
    }

    public void ToString_Field2(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}Doppler_Factor: {Doppler_Factor}");
    }

    public void ToString_Field3(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}Default_Speaker_Mode: {Default_Speaker_Mode}");
    }

    public void ToString_Field4(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_SampleRate: {m_SampleRate}");
    }

    public void ToString_Field5(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_DSPBufferSize: {m_DSPBufferSize}");
    }

    public void ToString_Field6(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_VirtualVoiceCount: {m_VirtualVoiceCount}");
    }

    public void ToString_Field7(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_RealVoiceCount: {m_RealVoiceCount}");
    }

    public void ToString_Field8(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_SpatializerPlugin: \"{m_SpatializerPlugin}\"");
    }

    public void ToString_Field9(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_AmbisonicDecoderPlugin: \"{m_AmbisonicDecoderPlugin}\"");
    }

    public void ToString_Field10(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_DisableAudio: {m_DisableAudio}");
    }

    public void ToString_Field11(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_VirtualizeEffects: {m_VirtualizeEffects}");
    }

    public void ToString_Field12(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_RequestedDSPBufferSize: {m_RequestedDSPBufferSize}");
    }
}


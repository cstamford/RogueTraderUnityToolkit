namespace RogueTraderUnityToolkit.UnityGenerated.Types.Engine;

using Core;
using System.Text;
using Unity;

/* $VFXManager (13 fields) VFXManager 12DE9473D4C50E07A8FBDEC8AEEBAA00 */
public record class VFXManager (
    PPtr<ComputeShader> m_IndirectShader,
    PPtr<ComputeShader> m_CopyBufferShader,
    PPtr<ComputeShader> m_SortShader,
    PPtr<ComputeShader> m_StripUpdateShader,
    PPtr<Shader> m_EmptyShader,
    AsciiString m_RenderPipeSettingsPath,
    float m_FixedTimeStep,
    float m_MaxDeltaTime,
    float m_MaxScrubTime,
    uint m_CompiledVersion,
    uint m_RuntimeVersion,
    PPtr<MonoBehaviour> m_RuntimeResources,
    uint m_BatchEmptyLifetime) : IUnityEngineStructure
{
    public static UnityObjectType ObjectType => UnityObjectType.VFXManager;
    public static Hash128 Hash => new("12DE9473D4C50E07A8FBDEC8AEEBAA00");
    public static VFXManager Read(EndianBinaryReader reader)
    {
        PPtr<ComputeShader> m_IndirectShader_ = PPtr<ComputeShader>.Read(reader);
        PPtr<ComputeShader> m_CopyBufferShader_ = PPtr<ComputeShader>.Read(reader);
        PPtr<ComputeShader> m_SortShader_ = PPtr<ComputeShader>.Read(reader);
        PPtr<ComputeShader> m_StripUpdateShader_ = PPtr<ComputeShader>.Read(reader);
        PPtr<Shader> m_EmptyShader_ = PPtr<Shader>.Read(reader);
        AsciiString m_RenderPipeSettingsPath_ = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_RenderPipeSettingsPath */
        float m_FixedTimeStep_ = reader.ReadF32();
        float m_MaxDeltaTime_ = reader.ReadF32();
        float m_MaxScrubTime_ = reader.ReadF32();
        uint m_CompiledVersion_ = reader.ReadU32();
        uint m_RuntimeVersion_ = reader.ReadU32();
        PPtr<MonoBehaviour> m_RuntimeResources_ = PPtr<MonoBehaviour>.Read(reader);
        uint m_BatchEmptyLifetime_ = reader.ReadU32();
        
        return new(m_IndirectShader_,
            m_CopyBufferShader_,
            m_SortShader_,
            m_StripUpdateShader_,
            m_EmptyShader_,
            m_RenderPipeSettingsPath_,
            m_FixedTimeStep_,
            m_MaxDeltaTime_,
            m_MaxScrubTime_,
            m_CompiledVersion_,
            m_RuntimeVersion_,
            m_RuntimeResources_,
            m_BatchEmptyLifetime_);
    }

    public override string ToString() => $"VFXManager\n{ToString(4)}";

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
        sb.AppendLine($"{indent_}m_IndirectShader: {m_IndirectShader}");
    }

    public void ToString_Field1(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_CopyBufferShader: {m_CopyBufferShader}");
    }

    public void ToString_Field2(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_SortShader: {m_SortShader}");
    }

    public void ToString_Field3(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_StripUpdateShader: {m_StripUpdateShader}");
    }

    public void ToString_Field4(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_EmptyShader: {m_EmptyShader}");
    }

    public void ToString_Field5(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_RenderPipeSettingsPath: \"{m_RenderPipeSettingsPath}\"");
    }

    public void ToString_Field6(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_FixedTimeStep: {m_FixedTimeStep}");
    }

    public void ToString_Field7(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_MaxDeltaTime: {m_MaxDeltaTime}");
    }

    public void ToString_Field8(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_MaxScrubTime: {m_MaxScrubTime}");
    }

    public void ToString_Field9(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_CompiledVersion: {m_CompiledVersion}");
    }

    public void ToString_Field10(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_RuntimeVersion: {m_RuntimeVersion}");
    }

    public void ToString_Field11(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_RuntimeResources: {m_RuntimeResources}");
    }

    public void ToString_Field12(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_BatchEmptyLifetime: {m_BatchEmptyLifetime}");
    }
}


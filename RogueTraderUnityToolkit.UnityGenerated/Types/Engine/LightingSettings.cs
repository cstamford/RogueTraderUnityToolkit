namespace RogueTraderUnityToolkit.UnityGenerated.Types.Engine;

using Core;
using System.Text;
using Unity;

/* $LightingSettings (9 fields) LightingSettings 7C075EB768E56392C216AAFEF21A9FC1 */
public record class LightingSettings (
    AsciiString m_Name,
    int m_GIWorkflowMode,
    bool m_EnableBakedLightmaps,
    bool m_EnableRealtimeLightmaps,
    bool m_RealtimeEnvironmentLighting,
    float m_BounceScale,
    float m_AlbedoBoost,
    float m_IndirectOutputScale,
    bool m_UsingShadowmask) : IUnityEngineStructure
{
    public static UnityObjectType ObjectType => UnityObjectType.LightingSettings;
    public static Hash128 Hash => new("7C075EB768E56392C216AAFEF21A9FC1");
    public static LightingSettings Read(EndianBinaryReader reader)
    {
        AsciiString m_Name_ = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_Name */
        int m_GIWorkflowMode_ = reader.ReadS32();
        bool m_EnableBakedLightmaps_ = reader.ReadBool();
        bool m_EnableRealtimeLightmaps_ = reader.ReadBool();
        bool m_RealtimeEnvironmentLighting_ = reader.ReadBool();
        reader.AlignTo(4); /* m_RealtimeEnvironmentLighting */
        float m_BounceScale_ = reader.ReadF32();
        float m_AlbedoBoost_ = reader.ReadF32();
        float m_IndirectOutputScale_ = reader.ReadF32();
        bool m_UsingShadowmask_ = reader.ReadBool();
        reader.AlignTo(4); /* m_UsingShadowmask */
        
        return new(m_Name_,
            m_GIWorkflowMode_,
            m_EnableBakedLightmaps_,
            m_EnableRealtimeLightmaps_,
            m_RealtimeEnvironmentLighting_,
            m_BounceScale_,
            m_AlbedoBoost_,
            m_IndirectOutputScale_,
            m_UsingShadowmask_);
    }

    public override string ToString() => $"LightingSettings\n{ToString(4)}";

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

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_Name: \"{m_Name}\"");
    }

    public void ToString_Field1(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_GIWorkflowMode: {m_GIWorkflowMode}");
    }

    public void ToString_Field2(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_EnableBakedLightmaps: {m_EnableBakedLightmaps}");
    }

    public void ToString_Field3(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_EnableRealtimeLightmaps: {m_EnableRealtimeLightmaps}");
    }

    public void ToString_Field4(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_RealtimeEnvironmentLighting: {m_RealtimeEnvironmentLighting}");
    }

    public void ToString_Field5(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_BounceScale: {m_BounceScale}");
    }

    public void ToString_Field6(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_AlbedoBoost: {m_AlbedoBoost}");
    }

    public void ToString_Field7(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_IndirectOutputScale: {m_IndirectOutputScale}");
    }

    public void ToString_Field8(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_UsingShadowmask: {m_UsingShadowmask}");
    }
}


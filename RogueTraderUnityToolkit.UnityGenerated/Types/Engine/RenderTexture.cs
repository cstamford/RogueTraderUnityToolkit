namespace RogueTraderUnityToolkit.UnityGenerated.Types.Engine;

using Core;
using System.Text;
using Unity;

/* $RenderTexture (21 fields) RenderTexture D71859AE7F2968864B8EB997C2CF728B */
public record class RenderTexture (
    AsciiString m_Name,
    int m_ForcedFallbackFormat,
    bool m_DownscaleFallback,
    bool m_IsAlphaChannelOptional,
    int m_Width,
    int m_Height,
    int m_AntiAliasing,
    int m_MipCount,
    int m_DepthStencilFormat,
    int m_ColorFormat,
    bool m_MipMap,
    bool m_GenerateMips,
    bool m_SRGB,
    bool m_UseDynamicScale,
    bool m_BindMS,
    bool m_EnableCompatibleFormat,
    bool m_EnableRandomWrite,
    GLTextureSettings m_TextureSettings,
    int m_Dimension,
    int m_VolumeDepth,
    int m_ShadowSamplingMode) : IUnityEngineStructure
{
    public static UnityObjectType ObjectType => UnityObjectType.RenderTexture;
    public static Hash128 Hash => new("D71859AE7F2968864B8EB997C2CF728B");
    public static RenderTexture Read(EndianBinaryReader reader)
    {
        AsciiString m_Name_ = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_Name */
        int m_ForcedFallbackFormat_ = reader.ReadS32();
        bool m_DownscaleFallback_ = reader.ReadBool();
        bool m_IsAlphaChannelOptional_ = reader.ReadBool();
        reader.AlignTo(4); /* m_IsAlphaChannelOptional */
        int m_Width_ = reader.ReadS32();
        int m_Height_ = reader.ReadS32();
        int m_AntiAliasing_ = reader.ReadS32();
        int m_MipCount_ = reader.ReadS32();
        int m_DepthStencilFormat_ = reader.ReadS32();
        int m_ColorFormat_ = reader.ReadS32();
        bool m_MipMap_ = reader.ReadBool();
        bool m_GenerateMips_ = reader.ReadBool();
        bool m_SRGB_ = reader.ReadBool();
        bool m_UseDynamicScale_ = reader.ReadBool();
        bool m_BindMS_ = reader.ReadBool();
        bool m_EnableCompatibleFormat_ = reader.ReadBool();
        bool m_EnableRandomWrite_ = reader.ReadBool();
        reader.AlignTo(4); /* m_EnableRandomWrite */
        GLTextureSettings m_TextureSettings_ = GLTextureSettings.Read(reader);
        int m_Dimension_ = reader.ReadS32();
        int m_VolumeDepth_ = reader.ReadS32();
        int m_ShadowSamplingMode_ = reader.ReadS32();
        
        return new(m_Name_,
            m_ForcedFallbackFormat_,
            m_DownscaleFallback_,
            m_IsAlphaChannelOptional_,
            m_Width_,
            m_Height_,
            m_AntiAliasing_,
            m_MipCount_,
            m_DepthStencilFormat_,
            m_ColorFormat_,
            m_MipMap_,
            m_GenerateMips_,
            m_SRGB_,
            m_UseDynamicScale_,
            m_BindMS_,
            m_EnableCompatibleFormat_,
            m_EnableRandomWrite_,
            m_TextureSettings_,
            m_Dimension_,
            m_VolumeDepth_,
            m_ShadowSamplingMode_);
    }

    public override string ToString() => $"RenderTexture\n{ToString(4)}";

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

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_Name: \"{m_Name}\"");
    }

    public void ToString_Field1(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_ForcedFallbackFormat: {m_ForcedFallbackFormat}");
    }

    public void ToString_Field2(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_DownscaleFallback: {m_DownscaleFallback}");
    }

    public void ToString_Field3(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_IsAlphaChannelOptional: {m_IsAlphaChannelOptional}");
    }

    public void ToString_Field4(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_Width: {m_Width}");
    }

    public void ToString_Field5(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_Height: {m_Height}");
    }

    public void ToString_Field6(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_AntiAliasing: {m_AntiAliasing}");
    }

    public void ToString_Field7(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_MipCount: {m_MipCount}");
    }

    public void ToString_Field8(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_DepthStencilFormat: {m_DepthStencilFormat}");
    }

    public void ToString_Field9(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_ColorFormat: {m_ColorFormat}");
    }

    public void ToString_Field10(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_MipMap: {m_MipMap}");
    }

    public void ToString_Field11(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_GenerateMips: {m_GenerateMips}");
    }

    public void ToString_Field12(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_SRGB: {m_SRGB}");
    }

    public void ToString_Field13(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_UseDynamicScale: {m_UseDynamicScale}");
    }

    public void ToString_Field14(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_BindMS: {m_BindMS}");
    }

    public void ToString_Field15(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_EnableCompatibleFormat: {m_EnableCompatibleFormat}");
    }

    public void ToString_Field16(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_EnableRandomWrite: {m_EnableRandomWrite}");
    }

    public void ToString_Field17(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_TextureSettings: {{ \n{m_TextureSettings.ToString(indent+4)}{indent_}}}\n");
    }

    public void ToString_Field18(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_Dimension: {m_Dimension}");
    }

    public void ToString_Field19(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_VolumeDepth: {m_VolumeDepth}");
    }

    public void ToString_Field20(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_ShadowSamplingMode: {m_ShadowSamplingMode}");
    }
}


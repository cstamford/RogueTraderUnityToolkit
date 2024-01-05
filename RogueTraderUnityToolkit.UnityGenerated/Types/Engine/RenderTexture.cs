namespace RogueTraderUnityToolkit.UnityGenerated.Types.Engine;

using Core;
using System.Text;
using Unity;

/* $RenderTexture (21 fields) D71859AE7F2968864B8EB997C2CF728B */
public record class RenderTexture(
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
    public static Hash128 Hash => new(3608697262, 2133420166, 1267644823, 3268375179);

    public static RenderTexture Read(EndianBinaryReader reader)
    {
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_Name */
        int _m_ForcedFallbackFormat = reader.ReadS32();
        bool _m_DownscaleFallback = reader.ReadBool();
        bool _m_IsAlphaChannelOptional = reader.ReadBool();
        reader.AlignTo(4); /* m_IsAlphaChannelOptional */
        int _m_Width = reader.ReadS32();
        int _m_Height = reader.ReadS32();
        int _m_AntiAliasing = reader.ReadS32();
        int _m_MipCount = reader.ReadS32();
        int _m_DepthStencilFormat = reader.ReadS32();
        int _m_ColorFormat = reader.ReadS32();
        bool _m_MipMap = reader.ReadBool();
        bool _m_GenerateMips = reader.ReadBool();
        bool _m_SRGB = reader.ReadBool();
        bool _m_UseDynamicScale = reader.ReadBool();
        bool _m_BindMS = reader.ReadBool();
        bool _m_EnableCompatibleFormat = reader.ReadBool();
        bool _m_EnableRandomWrite = reader.ReadBool();
        reader.AlignTo(4); /* m_EnableRandomWrite */
        GLTextureSettings _m_TextureSettings = GLTextureSettings.Read(reader);
        int _m_Dimension = reader.ReadS32();
        int _m_VolumeDepth = reader.ReadS32();
        int _m_ShadowSamplingMode = reader.ReadS32();
        
        return new(_m_Name,
            _m_ForcedFallbackFormat,
            _m_DownscaleFallback,
            _m_IsAlphaChannelOptional,
            _m_Width,
            _m_Height,
            _m_AntiAliasing,
            _m_MipCount,
            _m_DepthStencilFormat,
            _m_ColorFormat,
            _m_MipMap,
            _m_GenerateMips,
            _m_SRGB,
            _m_UseDynamicScale,
            _m_BindMS,
            _m_EnableCompatibleFormat,
            _m_EnableRandomWrite,
            _m_TextureSettings,
            _m_Dimension,
            _m_VolumeDepth,
            _m_ShadowSamplingMode);
    }

    public override string ToString() => $"RenderTexture\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Name: ");
        sb.AppendLine(m_Name.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_ForcedFallbackFormat: ");
        sb.AppendLine(m_ForcedFallbackFormat.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_DownscaleFallback: ");
        sb.AppendLine(m_DownscaleFallback.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_IsAlphaChannelOptional: ");
        sb.AppendLine(m_IsAlphaChannelOptional.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Width: ");
        sb.AppendLine(m_Width.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Height: ");
        sb.AppendLine(m_Height.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_AntiAliasing: ");
        sb.AppendLine(m_AntiAliasing.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_MipCount: ");
        sb.AppendLine(m_MipCount.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_DepthStencilFormat: ");
        sb.AppendLine(m_DepthStencilFormat.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_ColorFormat: ");
        sb.AppendLine(m_ColorFormat.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_MipMap: ");
        sb.AppendLine(m_MipMap.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_GenerateMips: ");
        sb.AppendLine(m_GenerateMips.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_SRGB: ");
        sb.AppendLine(m_SRGB.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_UseDynamicScale: ");
        sb.AppendLine(m_UseDynamicScale.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_BindMS: ");
        sb.AppendLine(m_BindMS.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_EnableCompatibleFormat: ");
        sb.AppendLine(m_EnableCompatibleFormat.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_EnableRandomWrite: ");
        sb.AppendLine(m_EnableRandomWrite.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_TextureSettings: ");
        sb.AppendLine();
        sb.Append(m_TextureSettings.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Dimension: ");
        sb.AppendLine(m_Dimension.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_VolumeDepth: ");
        sb.AppendLine(m_VolumeDepth.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_ShadowSamplingMode: ");
        sb.AppendLine(m_ShadowSamplingMode.ToString());

        return sb.ToString();
    }
}


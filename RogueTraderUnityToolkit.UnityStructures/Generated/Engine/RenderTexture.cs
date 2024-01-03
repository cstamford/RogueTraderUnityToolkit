namespace RogueTraderUnityToolkit.UnityStructures.Generated.Engine;

using Core;
using Unity.BuiltInTypes;

/* $RenderTexture (21 fields) (IsEngineType) */
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
    int m_ShadowSamplingMode)
{
    public static RenderTexture Read(EndianBinaryReader reader)
    {
        AsciiString m_Name = String.Read(reader);
        int m_ForcedFallbackFormat = reader.ReadS32();
        bool m_DownscaleFallback = reader.ReadBool();
        bool m_IsAlphaChannelOptional = reader.ReadBool();
        int m_Width = reader.ReadS32();
        int m_Height = reader.ReadS32();
        int m_AntiAliasing = reader.ReadS32();
        int m_MipCount = reader.ReadS32();
        int m_DepthStencilFormat = reader.ReadS32();
        int m_ColorFormat = reader.ReadS32();
        bool m_MipMap = reader.ReadBool();
        bool m_GenerateMips = reader.ReadBool();
        bool m_SRGB = reader.ReadBool();
        bool m_UseDynamicScale = reader.ReadBool();
        bool m_BindMS = reader.ReadBool();
        bool m_EnableCompatibleFormat = reader.ReadBool();
        bool m_EnableRandomWrite = reader.ReadBool();
        GLTextureSettings m_TextureSettings = GLTextureSettings.Read(reader);
        int m_Dimension = reader.ReadS32();
        int m_VolumeDepth = reader.ReadS32();
        int m_ShadowSamplingMode = reader.ReadS32();
        
        return new(m_Name,
            m_ForcedFallbackFormat,
            m_DownscaleFallback,
            m_IsAlphaChannelOptional,
            m_Width,
            m_Height,
            m_AntiAliasing,
            m_MipCount,
            m_DepthStencilFormat,
            m_ColorFormat,
            m_MipMap,
            m_GenerateMips,
            m_SRGB,
            m_UseDynamicScale,
            m_BindMS,
            m_EnableCompatibleFormat,
            m_EnableRandomWrite,
            m_TextureSettings,
            m_Dimension,
            m_VolumeDepth,
            m_ShadowSamplingMode);
    }
}


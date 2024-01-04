namespace RogueTraderUnityToolkit.UnityGenerated.Types.Engine;

using Core;
using Unity;

/* $RenderTexture (21 fields) D71859AE7F2968864B8EB997C2CF728B */
public record class RenderTexture(
    AsciiString m_Name /* None */,
    int m_ForcedFallbackFormat /* NeedsAlign */,
    bool m_DownscaleFallback /* None */,
    bool m_IsAlphaChannelOptional /* None */,
    int m_Width /* NeedsAlign */,
    int m_Height /* None */,
    int m_AntiAliasing /* None */,
    int m_MipCount /* None */,
    int m_DepthStencilFormat /* None */,
    int m_ColorFormat /* None */,
    bool m_MipMap /* None */,
    bool m_GenerateMips /* None */,
    bool m_SRGB /* None */,
    bool m_UseDynamicScale /* None */,
    bool m_BindMS /* None */,
    bool m_EnableCompatibleFormat /* None */,
    bool m_EnableRandomWrite /* None */,
    GLTextureSettings m_TextureSettings /* NeedsAlign */,
    int m_Dimension /* None */,
    int m_VolumeDepth /* None */,
    int m_ShadowSamplingMode /* None */) : IUnityObject
{
    public static Hash128 Hash => new(3608697262, 2133420166, 1267644823, 3268375179);
    public static RenderTexture Read(EndianBinaryReader reader)
    {
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_ForcedFallbackFormat */
        int _m_ForcedFallbackFormat = reader.ReadS32();
        bool _m_DownscaleFallback = reader.ReadBool();
        bool _m_IsAlphaChannelOptional = reader.ReadBool();
        reader.AlignTo(4); /* m_Width */
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
        reader.AlignTo(4); /* m_TextureSettings */
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
}


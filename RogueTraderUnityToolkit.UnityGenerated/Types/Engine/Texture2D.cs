namespace RogueTraderUnityToolkit.UnityGenerated.Types.Engine;

using Core;
using Unity;

/* $Texture2D (24 fields) E35AF631BF71F643C1152F4668971EB4 */
public record class Texture2D(
    AsciiString m_Name /* None */,
    int m_ForcedFallbackFormat /* NeedsAlign */,
    bool m_DownscaleFallback /* None */,
    bool m_IsAlphaChannelOptional /* None */,
    int m_Width /* NeedsAlign */,
    int m_Height /* None */,
    uint m_CompleteImageSize /* None */,
    int m_MipsStripped /* None */,
    int m_TextureFormat /* None */,
    int m_MipCount /* None */,
    bool m_IsReadable /* None */,
    bool m_IsPreProcessed /* None */,
    bool m_IgnoreMipmapLimit /* None */,
    AsciiString m_MipmapLimitGroupName /* NeedsAlign */,
    bool m_StreamingMipmaps /* NeedsAlign */,
    int m_StreamingMipmapsPriority /* NeedsAlign */,
    int m_ImageCount /* NeedsAlign */,
    int m_TextureDimension /* None */,
    GLTextureSettings m_TextureSettings /* None */,
    int m_LightmapFormat /* None */,
    int m_ColorSpace /* None */,
    byte[] m_PlatformBlob /* None */,
    TypelessData image_data /* NeedsAlign */,
    StreamingInfo m_StreamData /* NeedsAlign */) : IUnityObject
{
    public static Hash128 Hash => new(3814389297, 3211916867, 3239391046, 1754734260);
    public static Texture2D Read(EndianBinaryReader reader)
    {
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_ForcedFallbackFormat */
        int _m_ForcedFallbackFormat = reader.ReadS32();
        bool _m_DownscaleFallback = reader.ReadBool();
        bool _m_IsAlphaChannelOptional = reader.ReadBool();
        reader.AlignTo(4); /* m_Width */
        int _m_Width = reader.ReadS32();
        int _m_Height = reader.ReadS32();
        uint _m_CompleteImageSize = reader.ReadU32();
        int _m_MipsStripped = reader.ReadS32();
        int _m_TextureFormat = reader.ReadS32();
        int _m_MipCount = reader.ReadS32();
        bool _m_IsReadable = reader.ReadBool();
        bool _m_IsPreProcessed = reader.ReadBool();
        bool _m_IgnoreMipmapLimit = reader.ReadBool();
        reader.AlignTo(4); /* m_MipmapLimitGroupName */
        AsciiString _m_MipmapLimitGroupName = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_StreamingMipmaps */
        bool _m_StreamingMipmaps = reader.ReadBool();
        reader.AlignTo(4); /* m_StreamingMipmapsPriority */
        int _m_StreamingMipmapsPriority = reader.ReadS32();
        reader.AlignTo(4); /* m_ImageCount */
        int _m_ImageCount = reader.ReadS32();
        int _m_TextureDimension = reader.ReadS32();
        GLTextureSettings _m_TextureSettings = GLTextureSettings.Read(reader);
        int _m_LightmapFormat = reader.ReadS32();
        int _m_ColorSpace = reader.ReadS32();
        byte[] _m_PlatformBlob = BuiltInArray<byte>.Read(reader);
        reader.AlignTo(4); /* image_data */
        TypelessData _image_data = TypelessData.Read(reader);
        reader.AlignTo(4); /* m_StreamData */
        StreamingInfo _m_StreamData = StreamingInfo.Read(reader);
        
        return new(_m_Name,
            _m_ForcedFallbackFormat,
            _m_DownscaleFallback,
            _m_IsAlphaChannelOptional,
            _m_Width,
            _m_Height,
            _m_CompleteImageSize,
            _m_MipsStripped,
            _m_TextureFormat,
            _m_MipCount,
            _m_IsReadable,
            _m_IsPreProcessed,
            _m_IgnoreMipmapLimit,
            _m_MipmapLimitGroupName,
            _m_StreamingMipmaps,
            _m_StreamingMipmapsPriority,
            _m_ImageCount,
            _m_TextureDimension,
            _m_TextureSettings,
            _m_LightmapFormat,
            _m_ColorSpace,
            _m_PlatformBlob,
            _image_data,
            _m_StreamData);
    }
}


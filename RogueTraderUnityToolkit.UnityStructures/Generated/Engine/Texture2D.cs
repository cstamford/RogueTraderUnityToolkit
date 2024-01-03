namespace RogueTraderUnityToolkit.UnityStructures.Generated.Engine;

using Core;
using Unity.BuiltInTypes;

/* $Texture2D (24 fields) (IsEngineType) */
public record class Texture2D(
    AsciiString m_Name,
    int m_ForcedFallbackFormat,
    bool m_DownscaleFallback,
    bool m_IsAlphaChannelOptional,
    int m_Width,
    int m_Height,
    uint m_CompleteImageSize,
    int m_MipsStripped,
    int m_TextureFormat,
    int m_MipCount,
    bool m_IsReadable,
    bool m_IsPreProcessed,
    bool m_IgnoreMipmapLimit,
    AsciiString m_MipmapLimitGroupName,
    bool m_StreamingMipmaps,
    int m_StreamingMipmapsPriority,
    int m_ImageCount,
    int m_TextureDimension,
    GLTextureSettings m_TextureSettings,
    int m_LightmapFormat,
    int m_ColorSpace,
    byte[] m_PlatformBlob,
    TypelessData image_data,
    StreamingInfo m_StreamData)
{
    public static Texture2D Read(EndianBinaryReader reader)
    {
        AsciiString m_Name = String.Read(reader);
        int m_ForcedFallbackFormat = reader.ReadS32();
        bool m_DownscaleFallback = reader.ReadBool();
        bool m_IsAlphaChannelOptional = reader.ReadBool();
        int m_Width = reader.ReadS32();
        int m_Height = reader.ReadS32();
        uint m_CompleteImageSize = reader.ReadU32();
        int m_MipsStripped = reader.ReadS32();
        int m_TextureFormat = reader.ReadS32();
        int m_MipCount = reader.ReadS32();
        bool m_IsReadable = reader.ReadBool();
        bool m_IsPreProcessed = reader.ReadBool();
        bool m_IgnoreMipmapLimit = reader.ReadBool();
        AsciiString m_MipmapLimitGroupName = String.Read(reader);
        bool m_StreamingMipmaps = reader.ReadBool();
        int m_StreamingMipmapsPriority = reader.ReadS32();
        int m_ImageCount = reader.ReadS32();
        int m_TextureDimension = reader.ReadS32();
        GLTextureSettings m_TextureSettings = GLTextureSettings.Read(reader);
        int m_LightmapFormat = reader.ReadS32();
        int m_ColorSpace = reader.ReadS32();
        byte[] m_PlatformBlob = Array<byte>.Read(reader);
        TypelessData image_data = TypelessData.Read(reader);
        StreamingInfo m_StreamData = StreamingInfo.Read(reader);
        
        return new(m_Name,
            m_ForcedFallbackFormat,
            m_DownscaleFallback,
            m_IsAlphaChannelOptional,
            m_Width,
            m_Height,
            m_CompleteImageSize,
            m_MipsStripped,
            m_TextureFormat,
            m_MipCount,
            m_IsReadable,
            m_IsPreProcessed,
            m_IgnoreMipmapLimit,
            m_MipmapLimitGroupName,
            m_StreamingMipmaps,
            m_StreamingMipmapsPriority,
            m_ImageCount,
            m_TextureDimension,
            m_TextureSettings,
            m_LightmapFormat,
            m_ColorSpace,
            m_PlatformBlob,
            image_data,
            m_StreamData);
    }
}


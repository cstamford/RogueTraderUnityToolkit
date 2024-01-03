namespace RogueTraderUnityToolkit.Unity.Generated.Engine;

using Core;

/* $Texture2DArray (16 fields) (IsEngineType) */
public record class Texture2DArray(
    AsciiString m_Name,
    int m_ForcedFallbackFormat,
    bool m_DownscaleFallback,
    bool m_IsAlphaChannelOptional,
    int m_ColorSpace,
    int m_Format,
    int m_Width,
    int m_Height,
    int m_Depth,
    int m_MipCount,
    uint m_DataSize,
    GLTextureSettings m_TextureSettings,
    int m_UsageMode,
    bool m_IsReadable,
    TypelessData image_data,
    StreamingInfo m_StreamData)
{
    public static Texture2DArray Read(EndianBinaryReader reader)
    {
        AsciiString m_Name = String.Read(reader);
        int m_ForcedFallbackFormat = reader.ReadS32();
        bool m_DownscaleFallback = reader.ReadBool();
        bool m_IsAlphaChannelOptional = reader.ReadBool();
        int m_ColorSpace = reader.ReadS32();
        int m_Format = reader.ReadS32();
        int m_Width = reader.ReadS32();
        int m_Height = reader.ReadS32();
        int m_Depth = reader.ReadS32();
        int m_MipCount = reader.ReadS32();
        uint m_DataSize = reader.ReadU32();
        GLTextureSettings m_TextureSettings = GLTextureSettings.Read(reader);
        int m_UsageMode = reader.ReadS32();
        bool m_IsReadable = reader.ReadBool();
        TypelessData image_data = TypelessData.Read(reader);
        StreamingInfo m_StreamData = StreamingInfo.Read(reader);
        
        return new(m_Name,
            m_ForcedFallbackFormat,
            m_DownscaleFallback,
            m_IsAlphaChannelOptional,
            m_ColorSpace,
            m_Format,
            m_Width,
            m_Height,
            m_Depth,
            m_MipCount,
            m_DataSize,
            m_TextureSettings,
            m_UsageMode,
            m_IsReadable,
            image_data,
            m_StreamData);
    }
}


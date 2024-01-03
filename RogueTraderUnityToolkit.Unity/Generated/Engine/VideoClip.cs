namespace RogueTraderUnityToolkit.Unity.Generated.Engine;

using Core;

/* $VideoClip (18 fields) (IsEngineType) */
public record class VideoClip(
    AsciiString m_Name,
    AsciiString m_OriginalPath,
    uint m_ProxyWidth,
    uint m_ProxyHeight,
    uint Width,
    uint Height,
    uint m_PixelAspecRatioNum,
    uint m_PixelAspecRatioDen,
    double m_FrameRate,
    ulong m_FrameCount,
    int m_Format,
    ushort[] m_AudioChannelCount,
    uint[] m_AudioSampleRate,
    AsciiString[] m_AudioLanguage,
    PPtr<Shader>[] m_VideoShaders,
    StreamedResource m_ExternalResources,
    bool m_HasSplitAlpha,
    bool m_sRGB)
{
    public static VideoClip Read(EndianBinaryReader reader)
    {
        AsciiString m_Name = String.Read(reader);
        AsciiString m_OriginalPath = String.Read(reader);
        uint m_ProxyWidth = reader.ReadU32();
        uint m_ProxyHeight = reader.ReadU32();
        uint Width = reader.ReadU32();
        uint Height = reader.ReadU32();
        uint m_PixelAspecRatioNum = reader.ReadU32();
        uint m_PixelAspecRatioDen = reader.ReadU32();
        double m_FrameRate = reader.ReadF64();
        ulong m_FrameCount = reader.ReadU64();
        int m_Format = reader.ReadS32();
        ushort[] m_AudioChannelCount = Array<ushort>.Read(reader);
        uint[] m_AudioSampleRate = Array<uint>.Read(reader);
        AsciiString[] m_AudioLanguage = Array<AsciiString>.Read(reader);
        PPtr<Shader>[] m_VideoShaders = Array<PPtr<Shader>>.Read(reader);
        StreamedResource m_ExternalResources = StreamedResource.Read(reader);
        bool m_HasSplitAlpha = reader.ReadBool();
        bool m_sRGB = reader.ReadBool();
        
        return new(m_Name,
            m_OriginalPath,
            m_ProxyWidth,
            m_ProxyHeight,
            Width,
            Height,
            m_PixelAspecRatioNum,
            m_PixelAspecRatioDen,
            m_FrameRate,
            m_FrameCount,
            m_Format,
            m_AudioChannelCount,
            m_AudioSampleRate,
            m_AudioLanguage,
            m_VideoShaders,
            m_ExternalResources,
            m_HasSplitAlpha,
            m_sRGB);
    }
}


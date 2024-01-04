namespace RogueTraderUnityToolkit.UnityGenerated.Types.Engine;

using Core;
using Unity;

/* $VideoClip (18 fields) 00453E091E7DA6A011B04ED82DFA2065 */
public record class VideoClip(
    AsciiString m_Name /* None */,
    AsciiString m_OriginalPath /* NeedsAlign */,
    uint m_ProxyWidth /* NeedsAlign */,
    uint m_ProxyHeight /* None */,
    uint Width /* None */,
    uint Height /* None */,
    uint m_PixelAspecRatioNum /* None */,
    uint m_PixelAspecRatioDen /* None */,
    double m_FrameRate /* None */,
    ulong m_FrameCount /* None */,
    int m_Format /* None */,
    ushort[] m_AudioChannelCount /* None */,
    uint[] m_AudioSampleRate /* NeedsAlign */,
    AsciiString[] m_AudioLanguage /* NeedsAlign */,
    PPtr<Shader>[] m_VideoShaders /* NeedsAlign */,
    StreamedResource m_ExternalResources /* NeedsAlign */,
    bool m_HasSplitAlpha /* NeedsAlign */,
    bool m_sRGB /* None */) : IUnityObject
{
    public static Hash128 Hash => new(4537865, 511551136, 296767192, 771367013);
    public static VideoClip Read(EndianBinaryReader reader)
    {
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_OriginalPath */
        AsciiString _m_OriginalPath = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_ProxyWidth */
        uint _m_ProxyWidth = reader.ReadU32();
        uint _m_ProxyHeight = reader.ReadU32();
        uint _Width = reader.ReadU32();
        uint _Height = reader.ReadU32();
        uint _m_PixelAspecRatioNum = reader.ReadU32();
        uint _m_PixelAspecRatioDen = reader.ReadU32();
        double _m_FrameRate = reader.ReadF64();
        ulong _m_FrameCount = reader.ReadU64();
        int _m_Format = reader.ReadS32();
        ushort[] _m_AudioChannelCount = BuiltInArray<ushort>.Read(reader);
        reader.AlignTo(4); /* m_AudioSampleRate */
        uint[] _m_AudioSampleRate = BuiltInArray<uint>.Read(reader);
        reader.AlignTo(4); /* m_AudioLanguage */
        AsciiString[] _m_AudioLanguage = BuiltInArray<AsciiString>.Read(reader);
        reader.AlignTo(4); /* m_VideoShaders */
        PPtr<Shader>[] _m_VideoShaders = BuiltInArray<PPtr<Shader>>.Read(reader);
        reader.AlignTo(4); /* m_ExternalResources */
        StreamedResource _m_ExternalResources = StreamedResource.Read(reader);
        reader.AlignTo(4); /* m_HasSplitAlpha */
        bool _m_HasSplitAlpha = reader.ReadBool();
        bool _m_sRGB = reader.ReadBool();
        
        return new(_m_Name,
            _m_OriginalPath,
            _m_ProxyWidth,
            _m_ProxyHeight,
            _Width,
            _Height,
            _m_PixelAspecRatioNum,
            _m_PixelAspecRatioDen,
            _m_FrameRate,
            _m_FrameCount,
            _m_Format,
            _m_AudioChannelCount,
            _m_AudioSampleRate,
            _m_AudioLanguage,
            _m_VideoShaders,
            _m_ExternalResources,
            _m_HasSplitAlpha,
            _m_sRGB);
    }
}


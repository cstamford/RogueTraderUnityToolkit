namespace RogueTraderUnityToolkit.UnityGenerated.Types.Engine;

using Core;
using Unity;

/* $Texture2DArray (16 fields) 6FA4CC5A38C6F0D525B2B4F9443F044B */
public record class Texture2DArray(
    AsciiString m_Name /* None */,
    int m_ForcedFallbackFormat /* NeedsAlign */,
    bool m_DownscaleFallback /* None */,
    bool m_IsAlphaChannelOptional /* None */,
    int m_ColorSpace /* NeedsAlign */,
    int m_Format /* None */,
    int m_Width /* None */,
    int m_Height /* None */,
    int m_Depth /* None */,
    int m_MipCount /* None */,
    uint m_DataSize /* None */,
    GLTextureSettings m_TextureSettings /* None */,
    int m_UsageMode /* None */,
    bool m_IsReadable /* None */,
    TypelessData image_data /* NeedsAlign */,
    StreamingInfo m_StreamData /* NeedsAlign */) : IUnityObject
{
    public static Hash128 Hash => new(1873071194, 952561877, 632468729, 1144980555);
    public static Texture2DArray Read(EndianBinaryReader reader)
    {
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_ForcedFallbackFormat */
        int _m_ForcedFallbackFormat = reader.ReadS32();
        bool _m_DownscaleFallback = reader.ReadBool();
        bool _m_IsAlphaChannelOptional = reader.ReadBool();
        reader.AlignTo(4); /* m_ColorSpace */
        int _m_ColorSpace = reader.ReadS32();
        int _m_Format = reader.ReadS32();
        int _m_Width = reader.ReadS32();
        int _m_Height = reader.ReadS32();
        int _m_Depth = reader.ReadS32();
        int _m_MipCount = reader.ReadS32();
        uint _m_DataSize = reader.ReadU32();
        GLTextureSettings _m_TextureSettings = GLTextureSettings.Read(reader);
        int _m_UsageMode = reader.ReadS32();
        bool _m_IsReadable = reader.ReadBool();
        reader.AlignTo(4); /* image_data */
        TypelessData _image_data = TypelessData.Read(reader);
        reader.AlignTo(4); /* m_StreamData */
        StreamingInfo _m_StreamData = StreamingInfo.Read(reader);
        
        return new(_m_Name,
            _m_ForcedFallbackFormat,
            _m_DownscaleFallback,
            _m_IsAlphaChannelOptional,
            _m_ColorSpace,
            _m_Format,
            _m_Width,
            _m_Height,
            _m_Depth,
            _m_MipCount,
            _m_DataSize,
            _m_TextureSettings,
            _m_UsageMode,
            _m_IsReadable,
            _image_data,
            _m_StreamData);
    }
}


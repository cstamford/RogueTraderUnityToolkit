namespace RogueTraderUnityToolkit.UnityGenerated.Types.Engine;

using Core;
using System.Text;
using Unity;

/* $Cubemap (25 fields) C94D01E4E06BE3215C6D03A7F135CD6A */
public record class Cubemap(
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
    byte[] image_data,
    StreamingInfo m_StreamData,
    PPtr<Texture2D>[] m_SourceTextures) : IUnityEngineStructure
{
    public static Hash128 Hash => new(3377267172, 3765166881, 1550648231, 4046835050);

    public static Cubemap Read(EndianBinaryReader reader)
    {
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_Name */
        int _m_ForcedFallbackFormat = reader.ReadS32();
        bool _m_DownscaleFallback = reader.ReadBool();
        bool _m_IsAlphaChannelOptional = reader.ReadBool();
        reader.AlignTo(4); /* m_IsAlphaChannelOptional */
        int _m_Width = reader.ReadS32();
        int _m_Height = reader.ReadS32();
        uint _m_CompleteImageSize = reader.ReadU32();
        int _m_MipsStripped = reader.ReadS32();
        int _m_TextureFormat = reader.ReadS32();
        int _m_MipCount = reader.ReadS32();
        bool _m_IsReadable = reader.ReadBool();
        bool _m_IsPreProcessed = reader.ReadBool();
        bool _m_IgnoreMipmapLimit = reader.ReadBool();
        reader.AlignTo(4); /* m_IgnoreMipmapLimit */
        AsciiString _m_MipmapLimitGroupName = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_MipmapLimitGroupName */
        bool _m_StreamingMipmaps = reader.ReadBool();
        reader.AlignTo(4); /* m_StreamingMipmaps */
        int _m_StreamingMipmapsPriority = reader.ReadS32();
        reader.AlignTo(4); /* m_StreamingMipmapsPriority */
        int _m_ImageCount = reader.ReadS32();
        int _m_TextureDimension = reader.ReadS32();
        GLTextureSettings _m_TextureSettings = GLTextureSettings.Read(reader);
        int _m_LightmapFormat = reader.ReadS32();
        int _m_ColorSpace = reader.ReadS32();
        byte[] _m_PlatformBlob = BuiltInArray<byte>.Read(reader);
        reader.AlignTo(4); /* m_PlatformBlob */
        byte[] _image_data = BuiltInArray<byte>.Read(reader);
        reader.AlignTo(4); /* image_data */
        StreamingInfo _m_StreamData = StreamingInfo.Read(reader);
        reader.AlignTo(4); /* m_StreamData */
        PPtr<Texture2D>[] _m_SourceTextures = BuiltInArray<PPtr<Texture2D>>.Read(reader);
        reader.AlignTo(4); /* m_SourceTextures */
        
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
            _m_StreamData,
            _m_SourceTextures);
    }

    public override string ToString() => $"Cubemap\n{ToString(4)}";

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
        sb.Append("m_CompleteImageSize: ");
        sb.AppendLine(m_CompleteImageSize.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_MipsStripped: ");
        sb.AppendLine(m_MipsStripped.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_TextureFormat: ");
        sb.AppendLine(m_TextureFormat.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_MipCount: ");
        sb.AppendLine(m_MipCount.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_IsReadable: ");
        sb.AppendLine(m_IsReadable.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_IsPreProcessed: ");
        sb.AppendLine(m_IsPreProcessed.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_IgnoreMipmapLimit: ");
        sb.AppendLine(m_IgnoreMipmapLimit.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_MipmapLimitGroupName: ");
        sb.AppendLine(m_MipmapLimitGroupName.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_StreamingMipmaps: ");
        sb.AppendLine(m_StreamingMipmaps.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_StreamingMipmapsPriority: ");
        sb.AppendLine(m_StreamingMipmapsPriority.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_ImageCount: ");
        sb.AppendLine(m_ImageCount.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_TextureDimension: ");
        sb.AppendLine(m_TextureDimension.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_TextureSettings: ");
        sb.AppendLine();
        sb.Append(m_TextureSettings.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_LightmapFormat: ");
        sb.AppendLine(m_LightmapFormat.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_ColorSpace: ");
        sb.AppendLine(m_ColorSpace.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_PlatformBlob: ");
        sb.AppendLine(m_PlatformBlob.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("image_data: ");
        sb.AppendLine(image_data.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_StreamData: ");
        sb.AppendLine();
        sb.Append(m_StreamData.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_SourceTextures: ");
        sb.AppendLine(m_SourceTextures.ToString());

        return sb.ToString();
    }
}


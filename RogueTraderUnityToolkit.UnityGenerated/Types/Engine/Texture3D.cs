namespace RogueTraderUnityToolkit.UnityGenerated.Types.Engine;

using Core;
using System.Text;
using Unity;

/* $Texture3D (16 fields) C6A18BE51630B4D4D0D74EB2610AC619 */
public record class Texture3D(
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
    byte[] image_data,
    StreamingInfo m_StreamData) : IUnityEngineStructure
{
    public static Hash128 Hash => new(3332475877, 372290772, 3503771314, 1628096025);

    public static Texture3D Read(EndianBinaryReader reader)
    {
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_Name */
        int _m_ForcedFallbackFormat = reader.ReadS32();
        bool _m_DownscaleFallback = reader.ReadBool();
        bool _m_IsAlphaChannelOptional = reader.ReadBool();
        reader.AlignTo(4); /* m_IsAlphaChannelOptional */
        int _m_ColorSpace = reader.ReadS32();
        int _m_Format = reader.ReadS32();
        int _m_Width = reader.ReadS32();
        int _m_Height = reader.ReadS32();
        int _m_Depth = reader.ReadS32();
        int _m_MipCount = reader.ReadS32();
        reader.AlignTo(4); /* m_MipCount */
        uint _m_DataSize = reader.ReadU32();
        GLTextureSettings _m_TextureSettings = GLTextureSettings.Read(reader);
        int _m_UsageMode = reader.ReadS32();
        bool _m_IsReadable = reader.ReadBool();
        reader.AlignTo(4); /* m_IsReadable */
        byte[] _image_data = BuiltInArray<byte>.Read(reader);
        reader.AlignTo(4); /* image_data */
        StreamingInfo _m_StreamData = StreamingInfo.Read(reader);
        reader.AlignTo(4); /* m_StreamData */
        
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

    public override string ToString() => $"Texture3D\n{ToString(4)}";

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
        sb.Append("m_ColorSpace: ");
        sb.AppendLine(m_ColorSpace.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Format: ");
        sb.AppendLine(m_Format.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Width: ");
        sb.AppendLine(m_Width.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Height: ");
        sb.AppendLine(m_Height.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Depth: ");
        sb.AppendLine(m_Depth.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_MipCount: ");
        sb.AppendLine(m_MipCount.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_DataSize: ");
        sb.AppendLine(m_DataSize.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_TextureSettings: ");
        sb.AppendLine();
        sb.Append(m_TextureSettings.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_UsageMode: ");
        sb.AppendLine(m_UsageMode.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_IsReadable: ");
        sb.AppendLine(m_IsReadable.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("image_data: ");
        sb.AppendLine(image_data.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_StreamData: ");
        sb.AppendLine();
        sb.Append(m_StreamData.ToString(indent+4));

        return sb.ToString();
    }
}


namespace RogueTraderUnityToolkit.UnityGenerated.Types.Engine;

using Core;
using System.Text;
using Unity;

/* $VideoClip (18 fields) 00453E091E7DA6A011B04ED82DFA2065 */
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
    bool m_sRGB) : IUnityEngineStructure
{
    public static Hash128 Hash => new(4537865, 511551136, 296767192, 771367013);

    public static VideoClip Read(EndianBinaryReader reader)
    {
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_Name */
        AsciiString _m_OriginalPath = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_OriginalPath */
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
        reader.AlignTo(4); /* m_AudioChannelCount */
        uint[] _m_AudioSampleRate = BuiltInArray<uint>.Read(reader);
        reader.AlignTo(4); /* m_AudioSampleRate */
        AsciiString[] _m_AudioLanguage = BuiltInArray<AsciiString>.Read(reader);
        reader.AlignTo(4); /* m_AudioLanguage */
        PPtr<Shader>[] _m_VideoShaders = BuiltInArray<PPtr<Shader>>.Read(reader);
        reader.AlignTo(4); /* m_VideoShaders */
        StreamedResource _m_ExternalResources = StreamedResource.Read(reader);
        reader.AlignTo(4); /* m_ExternalResources */
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

    public override string ToString() => $"VideoClip\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Name: ");
        sb.AppendLine(m_Name.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_OriginalPath: ");
        sb.AppendLine(m_OriginalPath.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_ProxyWidth: ");
        sb.AppendLine(m_ProxyWidth.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_ProxyHeight: ");
        sb.AppendLine(m_ProxyHeight.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("Width: ");
        sb.AppendLine(Width.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("Height: ");
        sb.AppendLine(Height.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_PixelAspecRatioNum: ");
        sb.AppendLine(m_PixelAspecRatioNum.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_PixelAspecRatioDen: ");
        sb.AppendLine(m_PixelAspecRatioDen.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_FrameRate: ");
        sb.AppendLine(m_FrameRate.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_FrameCount: ");
        sb.AppendLine(m_FrameCount.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Format: ");
        sb.AppendLine(m_Format.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_AudioChannelCount: ");
        sb.AppendLine(m_AudioChannelCount.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_AudioSampleRate: ");
        sb.AppendLine(m_AudioSampleRate.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_AudioLanguage: ");
        sb.AppendLine(m_AudioLanguage.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_VideoShaders: ");
        sb.AppendLine(m_VideoShaders.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_ExternalResources: ");
        sb.AppendLine();
        sb.Append(m_ExternalResources.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_HasSplitAlpha: ");
        sb.AppendLine(m_HasSplitAlpha.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_sRGB: ");
        sb.AppendLine(m_sRGB.ToString());

        return sb.ToString();
    }
}


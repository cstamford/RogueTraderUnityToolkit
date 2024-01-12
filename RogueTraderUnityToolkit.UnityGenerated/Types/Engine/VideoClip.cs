namespace RogueTraderUnityToolkit.UnityGenerated.Types.Engine;

using Core;
using System.Text;
using Unity;

/* $VideoClip (18 fields) VideoClip 00453E091E7DA6A011B04ED82DFA2065 */
public record class VideoClip (
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
    public static UnityObjectType ObjectType => UnityObjectType.VideoClip;
    public static Hash128 Hash => new("00453E091E7DA6A011B04ED82DFA2065");
    public static VideoClip Read(EndianBinaryReader reader)
    {
        AsciiString m_Name_ = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_Name */
        AsciiString m_OriginalPath_ = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_OriginalPath */
        uint m_ProxyWidth_ = reader.ReadU32();
        uint m_ProxyHeight_ = reader.ReadU32();
        uint Width_ = reader.ReadU32();
        uint Height_ = reader.ReadU32();
        uint m_PixelAspecRatioNum_ = reader.ReadU32();
        uint m_PixelAspecRatioDen_ = reader.ReadU32();
        double m_FrameRate_ = reader.ReadF64();
        ulong m_FrameCount_ = reader.ReadU64();
        int m_Format_ = reader.ReadS32();
        ushort[] m_AudioChannelCount_ = BuiltInArray<ushort>.Read(reader);
        reader.AlignTo(4); /* m_AudioChannelCount */
        uint[] m_AudioSampleRate_ = BuiltInArray<uint>.Read(reader);
        reader.AlignTo(4); /* m_AudioSampleRate */
        AsciiString[] m_AudioLanguage_ = BuiltInArray<AsciiString>.Read(reader);
        reader.AlignTo(4); /* m_AudioLanguage */
        PPtr<Shader>[] m_VideoShaders_ = BuiltInArray<PPtr<Shader>>.Read(reader);
        reader.AlignTo(4); /* m_VideoShaders */
        StreamedResource m_ExternalResources_ = StreamedResource.Read(reader);
        reader.AlignTo(4); /* m_ExternalResources */
        bool m_HasSplitAlpha_ = reader.ReadBool();
        bool m_sRGB_ = reader.ReadBool();
        
        return new(m_Name_,
            m_OriginalPath_,
            m_ProxyWidth_,
            m_ProxyHeight_,
            Width_,
            Height_,
            m_PixelAspecRatioNum_,
            m_PixelAspecRatioDen_,
            m_FrameRate_,
            m_FrameCount_,
            m_Format_,
            m_AudioChannelCount_,
            m_AudioSampleRate_,
            m_AudioLanguage_,
            m_VideoShaders_,
            m_ExternalResources_,
            m_HasSplitAlpha_,
            m_sRGB_);
    }

    public override string ToString() => $"VideoClip\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();
        string indent_ = ' '.Repeat(indent);

        ToString_Field0(sb, indent, indent_);
        ToString_Field1(sb, indent, indent_);
        ToString_Field2(sb, indent, indent_);
        ToString_Field3(sb, indent, indent_);
        ToString_Field4(sb, indent, indent_);
        ToString_Field5(sb, indent, indent_);
        ToString_Field6(sb, indent, indent_);
        ToString_Field7(sb, indent, indent_);
        ToString_Field8(sb, indent, indent_);
        ToString_Field9(sb, indent, indent_);
        ToString_Field10(sb, indent, indent_);
        ToString_Field11(sb, indent, indent_);
        ToString_Field12(sb, indent, indent_);
        ToString_Field13(sb, indent, indent_);
        ToString_Field14(sb, indent, indent_);
        ToString_Field15(sb, indent, indent_);
        ToString_Field16(sb, indent, indent_);
        ToString_Field17(sb, indent, indent_);

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_Name: \"{m_Name}\"");
    }

    public void ToString_Field1(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_OriginalPath: \"{m_OriginalPath}\"");
    }

    public void ToString_Field2(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_ProxyWidth: {m_ProxyWidth}");
    }

    public void ToString_Field3(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_ProxyHeight: {m_ProxyHeight}");
    }

    public void ToString_Field4(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}Width: {Width}");
    }

    public void ToString_Field5(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}Height: {Height}");
    }

    public void ToString_Field6(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_PixelAspecRatioNum: {m_PixelAspecRatioNum}");
    }

    public void ToString_Field7(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_PixelAspecRatioDen: {m_PixelAspecRatioDen}");
    }

    public void ToString_Field8(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_FrameRate: {m_FrameRate}");
    }

    public void ToString_Field9(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_FrameCount: {m_FrameCount}");
    }

    public void ToString_Field10(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_Format: {m_Format}");
    }

    public void ToString_Field11(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_AudioChannelCount[{m_AudioChannelCount.Length}] = {{");
        if (m_AudioChannelCount.Length > 0) sb.AppendLine();
        int _4i = 0;
        foreach (ushort _4 in m_AudioChannelCount)
        {
            sb.AppendLine($"{indent_ + ' '.Repeat(4)}[{_4i}] = {_4}");
            ++_4i;
        }
        if (m_AudioChannelCount.Length > 0) sb.Append(indent_);
        sb.AppendLine("}");
    }

    public void ToString_Field12(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_AudioSampleRate[{m_AudioSampleRate.Length}] = {{");
        if (m_AudioSampleRate.Length > 0) sb.AppendLine();
        int _4i = 0;
        foreach (uint _4 in m_AudioSampleRate)
        {
            sb.AppendLine($"{indent_ + ' '.Repeat(4)}[{_4i}] = {_4}");
            ++_4i;
        }
        if (m_AudioSampleRate.Length > 0) sb.Append(indent_);
        sb.AppendLine("}");
    }

    public void ToString_Field13(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_AudioLanguage[{m_AudioLanguage.Length}] = {{");
        if (m_AudioLanguage.Length > 0) sb.AppendLine();
        int _4i = 0;
        foreach (AsciiString _4 in m_AudioLanguage)
        {
            sb.AppendLine($"{indent_ + ' '.Repeat(4)}[{_4i}] = \"{_4}\"");
            ++_4i;
        }
        if (m_AudioLanguage.Length > 0) sb.Append(indent_);
        sb.AppendLine("}");
    }

    public void ToString_Field14(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_VideoShaders[{m_VideoShaders.Length}] = {{");
        if (m_VideoShaders.Length > 0) sb.AppendLine();
        int _4i = 0;
        foreach (PPtr<Shader> _4 in m_VideoShaders)
        {
            sb.AppendLine($"{indent_ + ' '.Repeat(4)}[{_4i}] = {_4}");
            ++_4i;
        }
        if (m_VideoShaders.Length > 0) sb.Append(indent_);
        sb.AppendLine("}");
    }

    public void ToString_Field15(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_ExternalResources: {{ \n{m_ExternalResources.ToString(indent+4)}{indent_}}}\n");
    }

    public void ToString_Field16(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_HasSplitAlpha: {m_HasSplitAlpha}");
    }

    public void ToString_Field17(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_sRGB: {m_sRGB}");
    }
}


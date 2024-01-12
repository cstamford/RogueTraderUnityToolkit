namespace RogueTraderUnityToolkit.UnityGenerated.Types.Engine;

using Core;
using System.Text;
using Unity;

/* $Texture3D (16 fields) Texture3D C6A18BE51630B4D4D0D74EB2610AC619 */
public record class Texture3D (
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
    public static UnityObjectType ObjectType => UnityObjectType.Texture3D;
    public static Hash128 Hash => new("C6A18BE51630B4D4D0D74EB2610AC619");
    public static Texture3D Read(EndianBinaryReader reader)
    {
        AsciiString m_Name_ = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_Name */
        int m_ForcedFallbackFormat_ = reader.ReadS32();
        bool m_DownscaleFallback_ = reader.ReadBool();
        bool m_IsAlphaChannelOptional_ = reader.ReadBool();
        reader.AlignTo(4); /* m_IsAlphaChannelOptional */
        int m_ColorSpace_ = reader.ReadS32();
        int m_Format_ = reader.ReadS32();
        int m_Width_ = reader.ReadS32();
        int m_Height_ = reader.ReadS32();
        int m_Depth_ = reader.ReadS32();
        int m_MipCount_ = reader.ReadS32();
        reader.AlignTo(4); /* m_MipCount */
        uint m_DataSize_ = reader.ReadU32();
        GLTextureSettings m_TextureSettings_ = GLTextureSettings.Read(reader);
        int m_UsageMode_ = reader.ReadS32();
        bool m_IsReadable_ = reader.ReadBool();
        reader.AlignTo(4); /* m_IsReadable */
        byte[] image_data_ = BuiltInArray<byte>.Read(reader);
        reader.AlignTo(4); /* image_data */
        StreamingInfo m_StreamData_ = StreamingInfo.Read(reader);
        reader.AlignTo(4); /* m_StreamData */
        
        return new(m_Name_,
            m_ForcedFallbackFormat_,
            m_DownscaleFallback_,
            m_IsAlphaChannelOptional_,
            m_ColorSpace_,
            m_Format_,
            m_Width_,
            m_Height_,
            m_Depth_,
            m_MipCount_,
            m_DataSize_,
            m_TextureSettings_,
            m_UsageMode_,
            m_IsReadable_,
            image_data_,
            m_StreamData_);
    }

    public override string ToString() => $"Texture3D\n{ToString(4)}";

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

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_Name: \"{m_Name}\"");
    }

    public void ToString_Field1(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_ForcedFallbackFormat: {m_ForcedFallbackFormat}");
    }

    public void ToString_Field2(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_DownscaleFallback: {m_DownscaleFallback}");
    }

    public void ToString_Field3(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_IsAlphaChannelOptional: {m_IsAlphaChannelOptional}");
    }

    public void ToString_Field4(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_ColorSpace: {m_ColorSpace}");
    }

    public void ToString_Field5(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_Format: {m_Format}");
    }

    public void ToString_Field6(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_Width: {m_Width}");
    }

    public void ToString_Field7(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_Height: {m_Height}");
    }

    public void ToString_Field8(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_Depth: {m_Depth}");
    }

    public void ToString_Field9(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_MipCount: {m_MipCount}");
    }

    public void ToString_Field10(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_DataSize: {m_DataSize}");
    }

    public void ToString_Field11(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_TextureSettings: {{ \n{m_TextureSettings.ToString(indent+4)}{indent_}}}\n");
    }

    public void ToString_Field12(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_UsageMode: {m_UsageMode}");
    }

    public void ToString_Field13(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_IsReadable: {m_IsReadable}");
    }

    public void ToString_Field14(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}image_data[{image_data.Length}] = {{");
        if (image_data.Length > 0) sb.AppendLine();
        int _4i = 0;
        foreach (byte _4 in image_data)
        {
            sb.AppendLine($"{indent_ + ' '.Repeat(4)}[{_4i}] = {_4}");
            ++_4i;
        }
        if (image_data.Length > 0) sb.Append(indent_);
        sb.AppendLine("}");
    }

    public void ToString_Field15(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_StreamData: {{ \n{m_StreamData.ToString(indent+4)}{indent_}}}\n");
    }
}


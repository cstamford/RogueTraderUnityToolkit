namespace RogueTraderUnityToolkit.UnityGenerated.Types.Engine;

using Core;
using System.Text;
using Unity;

/* $Texture2D (24 fields) Texture2D E35AF631BF71F643C1152F4668971EB4 */
public record class Texture2D (
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
    StreamingInfo m_StreamData) : IUnityEngineStructure
{
    public static UnityObjectType ObjectType => UnityObjectType.Texture2D;
    public static Hash128 Hash => new("E35AF631BF71F643C1152F4668971EB4");
    public static Texture2D Read(EndianBinaryReader reader)
    {
        AsciiString m_Name_ = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_Name */
        int m_ForcedFallbackFormat_ = reader.ReadS32();
        bool m_DownscaleFallback_ = reader.ReadBool();
        bool m_IsAlphaChannelOptional_ = reader.ReadBool();
        reader.AlignTo(4); /* m_IsAlphaChannelOptional */
        int m_Width_ = reader.ReadS32();
        int m_Height_ = reader.ReadS32();
        uint m_CompleteImageSize_ = reader.ReadU32();
        int m_MipsStripped_ = reader.ReadS32();
        int m_TextureFormat_ = reader.ReadS32();
        int m_MipCount_ = reader.ReadS32();
        bool m_IsReadable_ = reader.ReadBool();
        bool m_IsPreProcessed_ = reader.ReadBool();
        bool m_IgnoreMipmapLimit_ = reader.ReadBool();
        reader.AlignTo(4); /* m_IgnoreMipmapLimit */
        AsciiString m_MipmapLimitGroupName_ = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_MipmapLimitGroupName */
        bool m_StreamingMipmaps_ = reader.ReadBool();
        reader.AlignTo(4); /* m_StreamingMipmaps */
        int m_StreamingMipmapsPriority_ = reader.ReadS32();
        reader.AlignTo(4); /* m_StreamingMipmapsPriority */
        int m_ImageCount_ = reader.ReadS32();
        int m_TextureDimension_ = reader.ReadS32();
        GLTextureSettings m_TextureSettings_ = GLTextureSettings.Read(reader);
        int m_LightmapFormat_ = reader.ReadS32();
        int m_ColorSpace_ = reader.ReadS32();
        byte[] m_PlatformBlob_ = BuiltInArray<byte>.Read(reader);
        reader.AlignTo(4); /* m_PlatformBlob */
        byte[] image_data_ = BuiltInArray<byte>.Read(reader);
        reader.AlignTo(4); /* image_data */
        StreamingInfo m_StreamData_ = StreamingInfo.Read(reader);
        reader.AlignTo(4); /* m_StreamData */
        
        return new(m_Name_,
            m_ForcedFallbackFormat_,
            m_DownscaleFallback_,
            m_IsAlphaChannelOptional_,
            m_Width_,
            m_Height_,
            m_CompleteImageSize_,
            m_MipsStripped_,
            m_TextureFormat_,
            m_MipCount_,
            m_IsReadable_,
            m_IsPreProcessed_,
            m_IgnoreMipmapLimit_,
            m_MipmapLimitGroupName_,
            m_StreamingMipmaps_,
            m_StreamingMipmapsPriority_,
            m_ImageCount_,
            m_TextureDimension_,
            m_TextureSettings_,
            m_LightmapFormat_,
            m_ColorSpace_,
            m_PlatformBlob_,
            image_data_,
            m_StreamData_);
    }

    public override string ToString() => $"Texture2D\n{ToString(4)}";

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
        ToString_Field18(sb, indent, indent_);
        ToString_Field19(sb, indent, indent_);
        ToString_Field20(sb, indent, indent_);
        ToString_Field21(sb, indent, indent_);
        ToString_Field22(sb, indent, indent_);
        ToString_Field23(sb, indent, indent_);

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
        sb.AppendLine($"{indent_}m_Width: {m_Width}");
    }

    public void ToString_Field5(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_Height: {m_Height}");
    }

    public void ToString_Field6(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_CompleteImageSize: {m_CompleteImageSize}");
    }

    public void ToString_Field7(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_MipsStripped: {m_MipsStripped}");
    }

    public void ToString_Field8(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_TextureFormat: {m_TextureFormat}");
    }

    public void ToString_Field9(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_MipCount: {m_MipCount}");
    }

    public void ToString_Field10(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_IsReadable: {m_IsReadable}");
    }

    public void ToString_Field11(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_IsPreProcessed: {m_IsPreProcessed}");
    }

    public void ToString_Field12(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_IgnoreMipmapLimit: {m_IgnoreMipmapLimit}");
    }

    public void ToString_Field13(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_MipmapLimitGroupName: \"{m_MipmapLimitGroupName}\"");
    }

    public void ToString_Field14(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_StreamingMipmaps: {m_StreamingMipmaps}");
    }

    public void ToString_Field15(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_StreamingMipmapsPriority: {m_StreamingMipmapsPriority}");
    }

    public void ToString_Field16(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_ImageCount: {m_ImageCount}");
    }

    public void ToString_Field17(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_TextureDimension: {m_TextureDimension}");
    }

    public void ToString_Field18(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_TextureSettings: {{ \n{m_TextureSettings.ToString(indent+4)}{indent_}}}\n");
    }

    public void ToString_Field19(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_LightmapFormat: {m_LightmapFormat}");
    }

    public void ToString_Field20(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_ColorSpace: {m_ColorSpace}");
    }

    public void ToString_Field21(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_PlatformBlob[{m_PlatformBlob.Length}] = {{");
        if (m_PlatformBlob.Length > 0) sb.AppendLine();
        int _4i = 0;
        foreach (byte _4 in m_PlatformBlob)
        {
            sb.AppendLine($"{indent_ + ' '.Repeat(4)}[{_4i}] = {_4}");
            ++_4i;
        }
        if (m_PlatformBlob.Length > 0) sb.Append(indent_);
        sb.AppendLine("}");
    }

    public void ToString_Field22(StringBuilder sb, int indent, string indent_)
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

    public void ToString_Field23(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_StreamData: {{ \n{m_StreamData.ToString(indent+4)}{indent_}}}\n");
    }
}


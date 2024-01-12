namespace RogueTraderUnityToolkit.UnityGenerated.Types.Engine;

using Core;
using System.Text;
using Unity;

/* $QualitySettings (4 fields) QualitySettings B9C38D273E2ADE0D7B47E754AA071146 */
public record class QualitySettings (
    int m_CurrentQuality,
    QualitySetting[] m_QualitySettings,
    AsciiString[] m_TextureMipmapLimitGroupNames,
    int m_StrippedMaximumLODLevel) : IUnityEngineStructure
{
    public static UnityObjectType ObjectType => UnityObjectType.QualitySettings;
    public static Hash128 Hash => new("B9C38D273E2ADE0D7B47E754AA071146");
    public static QualitySettings Read(EndianBinaryReader reader)
    {
        int m_CurrentQuality_ = reader.ReadS32();
        QualitySetting[] m_QualitySettings_ = BuiltInArray<QualitySetting>.Read(reader);
        reader.AlignTo(4); /* m_QualitySettings */
        AsciiString[] m_TextureMipmapLimitGroupNames_ = BuiltInArray<AsciiString>.Read(reader);
        reader.AlignTo(4); /* m_TextureMipmapLimitGroupNames */
        int m_StrippedMaximumLODLevel_ = reader.ReadS32();
        
        return new(m_CurrentQuality_,
            m_QualitySettings_,
            m_TextureMipmapLimitGroupNames_,
            m_StrippedMaximumLODLevel_);
    }

    public override string ToString() => $"QualitySettings\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();
        string indent_ = ' '.Repeat(indent);

        ToString_Field0(sb, indent, indent_);
        ToString_Field1(sb, indent, indent_);
        ToString_Field2(sb, indent, indent_);
        ToString_Field3(sb, indent, indent_);

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_CurrentQuality: {m_CurrentQuality}");
    }

    public void ToString_Field1(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_QualitySettings[{m_QualitySettings.Length}] = {{");
        if (m_QualitySettings.Length > 0) sb.AppendLine();
        int _4i = 0;
        foreach (QualitySetting _4 in m_QualitySettings)
        {
            sb.Append($"{indent_ + ' '.Repeat(4)}[{_4i}] = {{ \n{_4.ToString(indent+8)}{indent_ + ' '.Repeat(4)}}}\n");
            ++_4i;
        }
        if (m_QualitySettings.Length > 0) sb.Append(indent_);
        sb.AppendLine("}");
    }

    public void ToString_Field2(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_TextureMipmapLimitGroupNames[{m_TextureMipmapLimitGroupNames.Length}] = {{");
        if (m_TextureMipmapLimitGroupNames.Length > 0) sb.AppendLine();
        int _4i = 0;
        foreach (AsciiString _4 in m_TextureMipmapLimitGroupNames)
        {
            sb.AppendLine($"{indent_ + ' '.Repeat(4)}[{_4i}] = \"{_4}\"");
            ++_4i;
        }
        if (m_TextureMipmapLimitGroupNames.Length > 0) sb.Append(indent_);
        sb.AppendLine("}");
    }

    public void ToString_Field3(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_StrippedMaximumLODLevel: {m_StrippedMaximumLODLevel}");
    }
}


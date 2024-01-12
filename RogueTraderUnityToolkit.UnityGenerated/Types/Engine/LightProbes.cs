namespace RogueTraderUnityToolkit.UnityGenerated.Types.Engine;

using Core;
using System.Text;
using Unity;

/* $LightProbes (4 fields) LightProbes 631D2B2DED682AEBF5F7BB947B1DC20F */
public record class LightProbes (
    AsciiString m_Name,
    LightProbeData m_Data,
    SphericalHarmonicsL2[] m_BakedCoefficients,
    LightProbeOcclusion[] m_BakedLightOcclusion) : IUnityEngineStructure
{
    public static UnityObjectType ObjectType => UnityObjectType.LightProbes;
    public static Hash128 Hash => new("631D2B2DED682AEBF5F7BB947B1DC20F");
    public static LightProbes Read(EndianBinaryReader reader)
    {
        AsciiString m_Name_ = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_Name */
        LightProbeData m_Data_ = LightProbeData.Read(reader);
        reader.AlignTo(4); /* m_Data */
        SphericalHarmonicsL2[] m_BakedCoefficients_ = BuiltInArray<SphericalHarmonicsL2>.Read(reader);
        reader.AlignTo(4); /* m_BakedCoefficients */
        LightProbeOcclusion[] m_BakedLightOcclusion_ = BuiltInArray<LightProbeOcclusion>.Read(reader);
        reader.AlignTo(4); /* m_BakedLightOcclusion */
        
        return new(m_Name_,
            m_Data_,
            m_BakedCoefficients_,
            m_BakedLightOcclusion_);
    }

    public override string ToString() => $"LightProbes\n{ToString(4)}";

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
        sb.AppendLine($"{indent_}m_Name: \"{m_Name}\"");
    }

    public void ToString_Field1(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_Data: {{ \n{m_Data.ToString(indent+4)}{indent_}}}\n");
    }

    public void ToString_Field2(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_BakedCoefficients[{m_BakedCoefficients.Length}] = {{");
        if (m_BakedCoefficients.Length > 0) sb.AppendLine();
        int _4i = 0;
        foreach (SphericalHarmonicsL2 _4 in m_BakedCoefficients)
        {
            sb.Append($"{indent_ + ' '.Repeat(4)}[{_4i}] = {{ \n{_4.ToString(indent+8)}{indent_ + ' '.Repeat(4)}}}\n");
            ++_4i;
        }
        if (m_BakedCoefficients.Length > 0) sb.Append(indent_);
        sb.AppendLine("}");
    }

    public void ToString_Field3(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_BakedLightOcclusion[{m_BakedLightOcclusion.Length}] = {{");
        if (m_BakedLightOcclusion.Length > 0) sb.AppendLine();
        int _4i = 0;
        foreach (LightProbeOcclusion _4 in m_BakedLightOcclusion)
        {
            sb.Append($"{indent_ + ' '.Repeat(4)}[{_4i}] = {{ \n{_4.ToString(indent+8)}{indent_ + ' '.Repeat(4)}}}\n");
            ++_4i;
        }
        if (m_BakedLightOcclusion.Length > 0) sb.Append(indent_);
        sb.AppendLine("}");
    }
}


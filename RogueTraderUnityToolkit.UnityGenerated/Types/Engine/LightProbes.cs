namespace RogueTraderUnityToolkit.UnityGenerated.Types.Engine;

using Core;
using System.Text;
using Unity;

/* $LightProbes (4 fields) 631D2B2DED682AEBF5F7BB947B1DC20F */
public record class LightProbes(
    AsciiString m_Name,
    LightProbeData m_Data,
    SphericalHarmonicsL2[] m_BakedCoefficients,
    LightProbeOcclusion[] m_BakedLightOcclusion) : IUnityEngineStructure
{
    public static Hash128 Hash => new(1662855981, 3983026923, 4126653332, 2065547791);

    public static LightProbes Read(EndianBinaryReader reader)
    {
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_Name */
        LightProbeData _m_Data = LightProbeData.Read(reader);
        reader.AlignTo(4); /* m_Data */
        SphericalHarmonicsL2[] _m_BakedCoefficients = BuiltInArray<SphericalHarmonicsL2>.Read(reader);
        reader.AlignTo(4); /* m_BakedCoefficients */
        LightProbeOcclusion[] _m_BakedLightOcclusion = BuiltInArray<LightProbeOcclusion>.Read(reader);
        reader.AlignTo(4); /* m_BakedLightOcclusion */
        
        return new(_m_Name,
            _m_Data,
            _m_BakedCoefficients,
            _m_BakedLightOcclusion);
    }

    public override string ToString() => $"LightProbes\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Name: ");
        sb.AppendLine(m_Name.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Data: ");
        sb.AppendLine();
        sb.Append(m_Data.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_BakedCoefficients: ");
        sb.AppendLine(m_BakedCoefficients.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_BakedLightOcclusion: ");
        sb.AppendLine(m_BakedLightOcclusion.ToString());

        return sb.ToString();
    }
}


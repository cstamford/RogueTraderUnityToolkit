namespace RogueTraderUnityToolkit.UnityGenerated.Types.Engine;

using Core;
using Unity;

/* $LightProbes (4 fields) 631D2B2DED682AEBF5F7BB947B1DC20F */
public record class LightProbes(
    AsciiString m_Name /* None */,
    LightProbeData m_Data /* NeedsAlign */,
    SphericalHarmonicsL2[] m_BakedCoefficients /* NeedsAlign */,
    LightProbeOcclusion[] m_BakedLightOcclusion /* NeedsAlign */) : IUnityObject
{
    public static Hash128 Hash => new(1662855981, 3983026923, 4126653332, 2065547791);
    public static LightProbes Read(EndianBinaryReader reader)
    {
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_Data */
        LightProbeData _m_Data = LightProbeData.Read(reader);
        reader.AlignTo(4); /* m_BakedCoefficients */
        SphericalHarmonicsL2[] _m_BakedCoefficients = BuiltInArray<SphericalHarmonicsL2>.Read(reader);
        reader.AlignTo(4); /* m_BakedLightOcclusion */
        LightProbeOcclusion[] _m_BakedLightOcclusion = BuiltInArray<LightProbeOcclusion>.Read(reader);
        
        return new(_m_Name,
            _m_Data,
            _m_BakedCoefficients,
            _m_BakedLightOcclusion);
    }
}


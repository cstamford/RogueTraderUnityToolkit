namespace RogueTraderUnityToolkit.UnityStructures.Generated.Engine;

using Core;
using Unity.BuiltInTypes;

/* $LightProbes (4 fields) (IsEngineType) */
public record class LightProbes(
    AsciiString m_Name,
    LightProbeData m_Data,
    SphericalHarmonicsL2[] m_BakedCoefficients,
    LightProbeOcclusion[] m_BakedLightOcclusion)
{
    public static LightProbes Read(EndianBinaryReader reader)
    {
        AsciiString m_Name = String.Read(reader);
        LightProbeData m_Data = LightProbeData.Read(reader);
        SphericalHarmonicsL2[] m_BakedCoefficients = Array<SphericalHarmonicsL2>.Read(reader);
        LightProbeOcclusion[] m_BakedLightOcclusion = Array<LightProbeOcclusion>.Read(reader);
        
        return new(m_Name,
            m_Data,
            m_BakedCoefficients,
            m_BakedLightOcclusion);
    }
}


namespace RogueTraderUnityToolkit.Unity.Generated.Engine;

using Core;

/* $ComputeShader (2 fields) (IsEngineType) */
public record class ComputeShader(
    AsciiString m_Name,
    ComputeShaderPlatformVariant[] variants)
{
    public static ComputeShader Read(EndianBinaryReader reader)
    {
        AsciiString m_Name = String.Read(reader);
        ComputeShaderPlatformVariant[] variants = Array<ComputeShaderPlatformVariant>.Read(reader);
        
        return new(m_Name,
            variants);
    }
}


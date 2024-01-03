namespace RogueTraderUnityToolkit.UnityStructures.Generated.Engine;

using Core;
using Unity.BuiltInTypes;

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


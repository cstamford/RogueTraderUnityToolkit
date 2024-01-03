namespace RogueTraderUnityToolkit.UnityStructures.Generated.Engine;

using Core;
using Unity.BuiltInTypes;

/* $Shader (11 fields) (IsEngineType) */
public record class Shader(
    AsciiString m_Name,
    SerializedShader m_ParsedForm,
    uint[] platforms,
    uint[][] offsets,
    uint[][] compressedLengths,
    uint[][] decompressedLengths,
    byte[] compressedBlob,
    uint[] stageCounts,
    PPtr<Shader>[] m_Dependencies,
    Dictionary<AsciiString, PPtr<Texture>> m_NonModifiableTextures,
    bool m_ShaderIsBaked)
{
    public static Shader Read(EndianBinaryReader reader)
    {
        AsciiString m_Name = String.Read(reader);
        SerializedShader m_ParsedForm = SerializedShader.Read(reader);
        uint[] platforms = Array<uint>.Read(reader);
        uint[][] offsets = Array<uint[]>.Read(reader);
        uint[][] compressedLengths = Array<uint[]>.Read(reader);
        uint[][] decompressedLengths = Array<uint[]>.Read(reader);
        byte[] compressedBlob = Array<byte>.Read(reader);
        uint[] stageCounts = Array<uint>.Read(reader);
        PPtr<Shader>[] m_Dependencies = Array<PPtr<Shader>>.Read(reader);
        Dictionary<AsciiString, PPtr<Texture>> m_NonModifiableTextures = Map<AsciiString, PPtr<Texture>>.Read(reader);
        bool m_ShaderIsBaked = reader.ReadBool();
        
        return new(m_Name,
            m_ParsedForm,
            platforms,
            offsets,
            compressedLengths,
            decompressedLengths,
            compressedBlob,
            stageCounts,
            m_Dependencies,
            m_NonModifiableTextures,
            m_ShaderIsBaked);
    }
}


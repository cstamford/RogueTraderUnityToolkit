namespace RogueTraderUnityToolkit.UnityGenerated.Types.Engine;

using Core;
using Unity;

/* $Shader (11 fields) 5F4A42EAB68DE4C195DF442105109E6F */
public record class Shader(
    AsciiString m_Name /* None */,
    SerializedShader m_ParsedForm /* NeedsAlign */,
    uint[] platforms /* NeedsAlign */,
    uint[][] offsets /* NeedsAlign */,
    uint[][] compressedLengths /* NeedsAlign */,
    uint[][] decompressedLengths /* NeedsAlign */,
    byte[] compressedBlob /* NeedsAlign */,
    uint[] stageCounts /* NeedsAlign */,
    PPtr<Shader>[] m_Dependencies /* NeedsAlign */,
    Dictionary<AsciiString, PPtr<Texture>> m_NonModifiableTextures /* NeedsAlign */,
    bool m_ShaderIsBaked /* NeedsAlign */) : IUnityObject
{
    public static Hash128 Hash => new(1598702314, 3062752449, 2514437153, 84975215);
    public static Shader Read(EndianBinaryReader reader)
    {
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_ParsedForm */
        SerializedShader _m_ParsedForm = SerializedShader.Read(reader);
        reader.AlignTo(4); /* platforms */
        uint[] _platforms = BuiltInArray<uint>.Read(reader);
        reader.AlignTo(4); /* offsets */
        uint[][] _offsets = BuiltInArray<uint[]>.Read(reader);
        reader.AlignTo(4); /* compressedLengths */
        uint[][] _compressedLengths = BuiltInArray<uint[]>.Read(reader);
        reader.AlignTo(4); /* decompressedLengths */
        uint[][] _decompressedLengths = BuiltInArray<uint[]>.Read(reader);
        reader.AlignTo(4); /* compressedBlob */
        byte[] _compressedBlob = BuiltInArray<byte>.Read(reader);
        reader.AlignTo(4); /* stageCounts */
        uint[] _stageCounts = BuiltInArray<uint>.Read(reader);
        reader.AlignTo(4); /* m_Dependencies */
        PPtr<Shader>[] _m_Dependencies = BuiltInArray<PPtr<Shader>>.Read(reader);
        reader.AlignTo(4); /* m_NonModifiableTextures */
        Dictionary<AsciiString, PPtr<Texture>> _m_NonModifiableTextures = BuiltInMap<AsciiString, PPtr<Texture>>.Read(reader);
        reader.AlignTo(4); /* m_ShaderIsBaked */
        bool _m_ShaderIsBaked = reader.ReadBool();
        
        return new(_m_Name,
            _m_ParsedForm,
            _platforms,
            _offsets,
            _compressedLengths,
            _decompressedLengths,
            _compressedBlob,
            _stageCounts,
            _m_Dependencies,
            _m_NonModifiableTextures,
            _m_ShaderIsBaked);
    }
}


namespace RogueTraderUnityToolkit.UnityGenerated.Types.Engine;

using Core;
using System.Text;
using Unity;

/* $Shader (11 fields) 5F4A42EAB68DE4C195DF442105109E6F */
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
    bool m_ShaderIsBaked) : IUnityEngineStructure
{
    public static Hash128 Hash => new(1598702314, 3062752449, 2514437153, 84975215);

    public static Shader Read(EndianBinaryReader reader)
    {
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_Name */
        SerializedShader _m_ParsedForm = SerializedShader.Read(reader);
        reader.AlignTo(4); /* m_ParsedForm */
        uint[] _platforms = BuiltInArray<uint>.Read(reader);
        reader.AlignTo(4); /* platforms */
        uint[][] _offsets = BuiltInArray<uint[]>.Read(reader);
        reader.AlignTo(4); /* offsets */
        uint[][] _compressedLengths = BuiltInArray<uint[]>.Read(reader);
        reader.AlignTo(4); /* compressedLengths */
        uint[][] _decompressedLengths = BuiltInArray<uint[]>.Read(reader);
        reader.AlignTo(4); /* decompressedLengths */
        byte[] _compressedBlob = BuiltInArray<byte>.Read(reader);
        reader.AlignTo(4); /* compressedBlob */
        uint[] _stageCounts = BuiltInArray<uint>.Read(reader);
        reader.AlignTo(4); /* stageCounts */
        PPtr<Shader>[] _m_Dependencies = BuiltInArray<PPtr<Shader>>.Read(reader);
        reader.AlignTo(4); /* m_Dependencies */
        Dictionary<AsciiString, PPtr<Texture>> _m_NonModifiableTextures = BuiltInMap<AsciiString, PPtr<Texture>>.Read(reader);
        reader.AlignTo(4); /* m_NonModifiableTextures */
        bool _m_ShaderIsBaked = reader.ReadBool();
        reader.AlignTo(4); /* m_ShaderIsBaked */
        
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

    public override string ToString() => $"Shader\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Name: ");
        sb.AppendLine(m_Name.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_ParsedForm: ");
        sb.AppendLine();
        sb.Append(m_ParsedForm.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("platforms: ");
        sb.AppendLine(platforms.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("offsets: ");
        sb.AppendLine(offsets.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("compressedLengths: ");
        sb.AppendLine(compressedLengths.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("decompressedLengths: ");
        sb.AppendLine(decompressedLengths.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("compressedBlob: ");
        sb.AppendLine(compressedBlob.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("stageCounts: ");
        sb.AppendLine(stageCounts.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Dependencies: ");
        sb.AppendLine(m_Dependencies.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_NonModifiableTextures: ");
        sb.AppendLine(m_NonModifiableTextures.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_ShaderIsBaked: ");
        sb.AppendLine(m_ShaderIsBaked.ToString());

        return sb.ToString();
    }
}


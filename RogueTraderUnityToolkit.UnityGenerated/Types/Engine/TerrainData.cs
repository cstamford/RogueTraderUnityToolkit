namespace RogueTraderUnityToolkit.UnityGenerated.Types.Engine;

using Core;
using System.Text;
using Unity;

/* $TerrainData (5 fields) DCF37C325F52F0390A319657B02B92E6 */
public record class TerrainData(
    AsciiString m_Name,
    SplatDatabase m_SplatDatabase,
    DetailDatabase m_DetailDatabase,
    Heightmap m_Heightmap,
    PPtr<Shader>[] m_PreloadShaders) : IUnityEngineStructure
{
    public static Hash128 Hash => new(3706944562, 1599270969, 171021911, 2955645670);

    public static TerrainData Read(EndianBinaryReader reader)
    {
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_Name */
        SplatDatabase _m_SplatDatabase = SplatDatabase.Read(reader);
        reader.AlignTo(4); /* m_SplatDatabase */
        DetailDatabase _m_DetailDatabase = DetailDatabase.Read(reader);
        reader.AlignTo(4); /* m_DetailDatabase */
        Heightmap _m_Heightmap = Heightmap.Read(reader);
        reader.AlignTo(4); /* m_Heightmap */
        PPtr<Shader>[] _m_PreloadShaders = BuiltInArray<PPtr<Shader>>.Read(reader);
        reader.AlignTo(4); /* m_PreloadShaders */
        
        return new(_m_Name,
            _m_SplatDatabase,
            _m_DetailDatabase,
            _m_Heightmap,
            _m_PreloadShaders);
    }

    public override string ToString() => $"TerrainData\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Name: ");
        sb.AppendLine(m_Name.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_SplatDatabase: ");
        sb.AppendLine();
        sb.Append(m_SplatDatabase.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_DetailDatabase: ");
        sb.AppendLine();
        sb.Append(m_DetailDatabase.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Heightmap: ");
        sb.AppendLine();
        sb.Append(m_Heightmap.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_PreloadShaders: ");
        sb.AppendLine(m_PreloadShaders.ToString());

        return sb.ToString();
    }
}


namespace RogueTraderUnityToolkit.UnityGenerated.Types.Engine;

using Core;
using System.Text;
using Unity;

/* $TerrainData (5 fields) TerrainData DCF37C325F52F0390A319657B02B92E6 */
public record class TerrainData (
    AsciiString m_Name,
    SplatDatabase m_SplatDatabase,
    DetailDatabase m_DetailDatabase,
    Heightmap m_Heightmap,
    PPtr<Shader>[] m_PreloadShaders) : IUnityEngineStructure
{
    public static UnityObjectType ObjectType => UnityObjectType.TerrainData;
    public static Hash128 Hash => new("DCF37C325F52F0390A319657B02B92E6");
    public static TerrainData Read(EndianBinaryReader reader)
    {
        AsciiString m_Name_ = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_Name */
        SplatDatabase m_SplatDatabase_ = SplatDatabase.Read(reader);
        reader.AlignTo(4); /* m_SplatDatabase */
        DetailDatabase m_DetailDatabase_ = DetailDatabase.Read(reader);
        reader.AlignTo(4); /* m_DetailDatabase */
        Heightmap m_Heightmap_ = Heightmap.Read(reader);
        reader.AlignTo(4); /* m_Heightmap */
        PPtr<Shader>[] m_PreloadShaders_ = BuiltInArray<PPtr<Shader>>.Read(reader);
        reader.AlignTo(4); /* m_PreloadShaders */
        
        return new(m_Name_,
            m_SplatDatabase_,
            m_DetailDatabase_,
            m_Heightmap_,
            m_PreloadShaders_);
    }

    public override string ToString() => $"TerrainData\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();
        string indent_ = ' '.Repeat(indent);

        ToString_Field0(sb, indent, indent_);
        ToString_Field1(sb, indent, indent_);
        ToString_Field2(sb, indent, indent_);
        ToString_Field3(sb, indent, indent_);
        ToString_Field4(sb, indent, indent_);

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_Name: \"{m_Name}\"");
    }

    public void ToString_Field1(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_SplatDatabase: {{ \n{m_SplatDatabase.ToString(indent+4)}{indent_}}}\n");
    }

    public void ToString_Field2(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_DetailDatabase: {{ \n{m_DetailDatabase.ToString(indent+4)}{indent_}}}\n");
    }

    public void ToString_Field3(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_Heightmap: {{ \n{m_Heightmap.ToString(indent+4)}{indent_}}}\n");
    }

    public void ToString_Field4(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_PreloadShaders[{m_PreloadShaders.Length}] = {{");
        if (m_PreloadShaders.Length > 0) sb.AppendLine();
        int _4i = 0;
        foreach (PPtr<Shader> _4 in m_PreloadShaders)
        {
            sb.AppendLine($"{indent_ + ' '.Repeat(4)}[{_4i}] = {_4}");
            ++_4i;
        }
        if (m_PreloadShaders.Length > 0) sb.Append(indent_);
        sb.AppendLine("}");
    }
}


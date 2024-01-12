namespace RogueTraderUnityToolkit.UnityGenerated.Types.Engine;

using Core;
using System.Text;
using Unity;

/* $ShaderNameRegistry (2 fields) ShaderNameRegistry D2317756261AD8084667018EC046CDDB */
public record class ShaderNameRegistry (
    NameToObjectMap m_Shaders,
    bool m_PreloadShaders) : IUnityEngineStructure
{
    public static UnityObjectType ObjectType => UnityObjectType.ShaderNameRegistry;
    public static Hash128 Hash => new("D2317756261AD8084667018EC046CDDB");
    public static ShaderNameRegistry Read(EndianBinaryReader reader)
    {
        NameToObjectMap m_Shaders_ = NameToObjectMap.Read(reader);
        reader.AlignTo(4); /* m_Shaders */
        bool m_PreloadShaders_ = reader.ReadBool();
        
        return new(m_Shaders_,
            m_PreloadShaders_);
    }

    public override string ToString() => $"ShaderNameRegistry\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();
        string indent_ = ' '.Repeat(indent);

        ToString_Field0(sb, indent, indent_);
        ToString_Field1(sb, indent, indent_);

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_Shaders: {{ \n{m_Shaders.ToString(indent+4)}{indent_}}}\n");
    }

    public void ToString_Field1(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_PreloadShaders: {m_PreloadShaders}");
    }
}


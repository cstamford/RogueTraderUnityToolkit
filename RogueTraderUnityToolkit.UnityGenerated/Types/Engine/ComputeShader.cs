namespace RogueTraderUnityToolkit.UnityGenerated.Types.Engine;

using Core;
using System.Text;
using Unity;

/* $ComputeShader (2 fields) ComputeShader AB63DFBF5A4DE80CE55E762CE70FD960 */
public record class ComputeShader (
    AsciiString m_Name,
    ComputeShaderPlatformVariant[] variants) : IUnityEngineStructure
{
    public static UnityObjectType ObjectType => UnityObjectType.ComputeShader;
    public static Hash128 Hash => new("AB63DFBF5A4DE80CE55E762CE70FD960");
    public static ComputeShader Read(EndianBinaryReader reader)
    {
        AsciiString m_Name_ = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_Name */
        ComputeShaderPlatformVariant[] variants_ = BuiltInArray<ComputeShaderPlatformVariant>.Read(reader);
        reader.AlignTo(4); /* variants */
        
        return new(m_Name_,
            variants_);
    }

    public override string ToString() => $"ComputeShader\n{ToString(4)}";

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
        sb.AppendLine($"{indent_}m_Name: \"{m_Name}\"");
    }

    public void ToString_Field1(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}variants[{variants.Length}] = {{");
        if (variants.Length > 0) sb.AppendLine();
        int _4i = 0;
        foreach (ComputeShaderPlatformVariant _4 in variants)
        {
            sb.Append($"{indent_ + ' '.Repeat(4)}[{_4i}] = {{ \n{_4.ToString(indent+8)}{indent_ + ' '.Repeat(4)}}}\n");
            ++_4i;
        }
        if (variants.Length > 0) sb.Append(indent_);
        sb.AppendLine("}");
    }
}


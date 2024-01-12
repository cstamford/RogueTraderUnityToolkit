namespace RogueTraderUnityToolkit.UnityGenerated.Types.Engine;

using Core;
using System.Text;
using Unity;

/* $TagManager (3 fields) TagManager D197953D3F842B5B278066ECEA0DDD84 */
public record class TagManager (
    AsciiString[] tags,
    AsciiString[] layers,
    SortingLayerEntry[] m_SortingLayers) : IUnityEngineStructure
{
    public static UnityObjectType ObjectType => UnityObjectType.TagManager;
    public static Hash128 Hash => new("D197953D3F842B5B278066ECEA0DDD84");
    public static TagManager Read(EndianBinaryReader reader)
    {
        AsciiString[] tags_ = BuiltInArray<AsciiString>.Read(reader);
        reader.AlignTo(4); /* tags */
        AsciiString[] layers_ = BuiltInArray<AsciiString>.Read(reader);
        reader.AlignTo(4); /* layers */
        SortingLayerEntry[] m_SortingLayers_ = BuiltInArray<SortingLayerEntry>.Read(reader);
        reader.AlignTo(4); /* m_SortingLayers */
        
        return new(tags_,
            layers_,
            m_SortingLayers_);
    }

    public override string ToString() => $"TagManager\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();
        string indent_ = ' '.Repeat(indent);

        ToString_Field0(sb, indent, indent_);
        ToString_Field1(sb, indent, indent_);
        ToString_Field2(sb, indent, indent_);

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}tags[{tags.Length}] = {{");
        if (tags.Length > 0) sb.AppendLine();
        int _4i = 0;
        foreach (AsciiString _4 in tags)
        {
            sb.AppendLine($"{indent_ + ' '.Repeat(4)}[{_4i}] = \"{_4}\"");
            ++_4i;
        }
        if (tags.Length > 0) sb.Append(indent_);
        sb.AppendLine("}");
    }

    public void ToString_Field1(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}layers[{layers.Length}] = {{");
        if (layers.Length > 0) sb.AppendLine();
        int _4i = 0;
        foreach (AsciiString _4 in layers)
        {
            sb.AppendLine($"{indent_ + ' '.Repeat(4)}[{_4i}] = \"{_4}\"");
            ++_4i;
        }
        if (layers.Length > 0) sb.Append(indent_);
        sb.AppendLine("}");
    }

    public void ToString_Field2(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_SortingLayers[{m_SortingLayers.Length}] = {{");
        if (m_SortingLayers.Length > 0) sb.AppendLine();
        int _4i = 0;
        foreach (SortingLayerEntry _4 in m_SortingLayers)
        {
            sb.Append($"{indent_ + ' '.Repeat(4)}[{_4i}] = {{ \n{_4.ToString(indent+8)}{indent_ + ' '.Repeat(4)}}}\n");
            ++_4i;
        }
        if (m_SortingLayers.Length > 0) sb.Append(indent_);
        sb.AppendLine("}");
    }
}


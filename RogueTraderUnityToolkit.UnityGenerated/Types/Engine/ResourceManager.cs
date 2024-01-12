namespace RogueTraderUnityToolkit.UnityGenerated.Types.Engine;

using Core;
using System.Text;
using Unity;

/* $ResourceManager (2 fields) ResourceManager 0E889D0DC7337F079BC9C26F0AA529D6 */
public record class ResourceManager (
    Dictionary<AsciiString, PPtr<Object>> m_Container,
    ResourceManager_Dependency[] m_DependentAssets) : IUnityEngineStructure
{
    public static UnityObjectType ObjectType => UnityObjectType.ResourceManager;
    public static Hash128 Hash => new("0E889D0DC7337F079BC9C26F0AA529D6");
    public static ResourceManager Read(EndianBinaryReader reader)
    {
        Dictionary<AsciiString, PPtr<Object>> m_Container_ = BuiltInMap<AsciiString, PPtr<Object>>.Read(reader);
        reader.AlignTo(4); /* m_Container */
        ResourceManager_Dependency[] m_DependentAssets_ = BuiltInArray<ResourceManager_Dependency>.Read(reader);
        reader.AlignTo(4); /* m_DependentAssets */
        
        return new(m_Container_,
            m_DependentAssets_);
    }

    public override string ToString() => $"ResourceManager\n{ToString(4)}";

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
        sb.Append($"{indent_}m_Container[{m_Container.Count}] = {{");
        if (m_Container.Count > 0) sb.AppendLine();
        int _4i = 0;
        foreach (KeyValuePair<AsciiString, PPtr<Object>> _4 in m_Container)
        {
            sb.AppendLine($"{indent_ + ' '.Repeat(4)}[\"{_4.Key}\"] = {_4.Value}");
            ++_4i;
        }
        if (m_Container.Count > 0) sb.Append(indent_);
        sb.AppendLine("}");
    }

    public void ToString_Field1(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_DependentAssets[{m_DependentAssets.Length}] = {{");
        if (m_DependentAssets.Length > 0) sb.AppendLine();
        int _4i = 0;
        foreach (ResourceManager_Dependency _4 in m_DependentAssets)
        {
            sb.Append($"{indent_ + ' '.Repeat(4)}[{_4i}] = {{ \n{_4.ToString(indent+8)}{indent_ + ' '.Repeat(4)}}}\n");
            ++_4i;
        }
        if (m_DependentAssets.Length > 0) sb.Append(indent_);
        sb.AppendLine("}");
    }
}


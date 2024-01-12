namespace RogueTraderUnityToolkit.UnityGenerated.Types.Engine;

using Core;
using System.Text;
using Unity;

/* $GameObject (5 fields) GameObject B84EE386B04276EEC998FB89B0D91DD8 */
public record class GameObject (
    ComponentPair[] m_Component,
    uint m_Layer,
    AsciiString m_Name,
    ushort m_Tag,
    bool m_IsActive) : IUnityEngineStructure
{
    public static UnityObjectType ObjectType => UnityObjectType.GameObject;
    public static Hash128 Hash => new("B84EE386B04276EEC998FB89B0D91DD8");
    public static GameObject Read(EndianBinaryReader reader)
    {
        ComponentPair[] m_Component_ = BuiltInArray<ComponentPair>.Read(reader);
        reader.AlignTo(4); /* m_Component */
        uint m_Layer_ = reader.ReadU32();
        AsciiString m_Name_ = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_Name */
        ushort m_Tag_ = reader.ReadU16();
        bool m_IsActive_ = reader.ReadBool();
        
        return new(m_Component_,
            m_Layer_,
            m_Name_,
            m_Tag_,
            m_IsActive_);
    }

    public override string ToString() => $"GameObject\n{ToString(4)}";

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
        sb.Append($"{indent_}m_Component[{m_Component.Length}] = {{");
        if (m_Component.Length > 0) sb.AppendLine();
        int _4i = 0;
        foreach (ComponentPair _4 in m_Component)
        {
            sb.Append($"{indent_ + ' '.Repeat(4)}[{_4i}] = {{ \n{_4.ToString(indent+8)}{indent_ + ' '.Repeat(4)}}}\n");
            ++_4i;
        }
        if (m_Component.Length > 0) sb.Append(indent_);
        sb.AppendLine("}");
    }

    public void ToString_Field1(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_Layer: {m_Layer}");
    }

    public void ToString_Field2(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_Name: \"{m_Name}\"");
    }

    public void ToString_Field3(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_Tag: {m_Tag}");
    }

    public void ToString_Field4(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_IsActive: {m_IsActive}");
    }
}


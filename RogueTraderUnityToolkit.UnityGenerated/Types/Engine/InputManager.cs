namespace RogueTraderUnityToolkit.UnityGenerated.Types.Engine;

using Core;
using System.Text;
using Unity;

/* $InputManager (2 fields) InputManager 5C032E59D903C25FDBBAEEBB188794C7 */
public record class InputManager (
    InputAxis[] m_Axes,
    bool m_UsePhysicalKeys) : IUnityEngineStructure
{
    public static UnityObjectType ObjectType => UnityObjectType.InputManager;
    public static Hash128 Hash => new("5C032E59D903C25FDBBAEEBB188794C7");
    public static InputManager Read(EndianBinaryReader reader)
    {
        InputAxis[] m_Axes_ = BuiltInArray<InputAxis>.Read(reader);
        reader.AlignTo(4); /* m_Axes */
        bool m_UsePhysicalKeys_ = reader.ReadBool();
        reader.AlignTo(4); /* m_UsePhysicalKeys */
        
        return new(m_Axes_,
            m_UsePhysicalKeys_);
    }

    public override string ToString() => $"InputManager\n{ToString(4)}";

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
        sb.Append($"{indent_}m_Axes[{m_Axes.Length}] = {{");
        if (m_Axes.Length > 0) sb.AppendLine();
        int _4i = 0;
        foreach (InputAxis _4 in m_Axes)
        {
            sb.Append($"{indent_ + ' '.Repeat(4)}[{_4i}] = {{ \n{_4.ToString(indent+8)}{indent_ + ' '.Repeat(4)}}}\n");
            ++_4i;
        }
        if (m_Axes.Length > 0) sb.Append(indent_);
        sb.AppendLine("}");
    }

    public void ToString_Field1(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_UsePhysicalKeys: {m_UsePhysicalKeys}");
    }
}


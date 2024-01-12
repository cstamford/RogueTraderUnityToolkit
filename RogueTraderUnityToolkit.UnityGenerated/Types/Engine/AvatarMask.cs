namespace RogueTraderUnityToolkit.UnityGenerated.Types.Engine;

using Core;
using System.Text;
using Unity;

/* $AvatarMask (3 fields) AvatarMask 9215D1126AA8279C97CEA97F18DAEFDA */
public record class AvatarMask (
    AsciiString m_Name,
    uint[] m_Mask,
    TransformMaskElement[] m_Elements) : IUnityEngineStructure
{
    public static UnityObjectType ObjectType => UnityObjectType.AvatarMask;
    public static Hash128 Hash => new("9215D1126AA8279C97CEA97F18DAEFDA");
    public static AvatarMask Read(EndianBinaryReader reader)
    {
        AsciiString m_Name_ = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_Name */
        uint[] m_Mask_ = BuiltInArray<uint>.Read(reader);
        reader.AlignTo(4); /* m_Mask */
        TransformMaskElement[] m_Elements_ = BuiltInArray<TransformMaskElement>.Read(reader);
        reader.AlignTo(4); /* m_Elements */
        
        return new(m_Name_,
            m_Mask_,
            m_Elements_);
    }

    public override string ToString() => $"AvatarMask\n{ToString(4)}";

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
        sb.AppendLine($"{indent_}m_Name: \"{m_Name}\"");
    }

    public void ToString_Field1(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_Mask[{m_Mask.Length}] = {{");
        if (m_Mask.Length > 0) sb.AppendLine();
        int _4i = 0;
        foreach (uint _4 in m_Mask)
        {
            sb.AppendLine($"{indent_ + ' '.Repeat(4)}[{_4i}] = {_4}");
            ++_4i;
        }
        if (m_Mask.Length > 0) sb.Append(indent_);
        sb.AppendLine("}");
    }

    public void ToString_Field2(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_Elements[{m_Elements.Length}] = {{");
        if (m_Elements.Length > 0) sb.AppendLine();
        int _4i = 0;
        foreach (TransformMaskElement _4 in m_Elements)
        {
            sb.Append($"{indent_ + ' '.Repeat(4)}[{_4i}] = {{ \n{_4.ToString(indent+8)}{indent_ + ' '.Repeat(4)}}}\n");
            ++_4i;
        }
        if (m_Elements.Length > 0) sb.Append(indent_);
        sb.AppendLine("}");
    }
}


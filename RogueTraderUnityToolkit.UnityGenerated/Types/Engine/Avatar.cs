namespace RogueTraderUnityToolkit.UnityGenerated.Types.Engine;

using Core;
using System.Text;
using Unity;

/* $Avatar (5 fields) Avatar 7C11FC061465D9A6CA18CC0CA1C10C84 */
public record class Avatar (
    AsciiString m_Name,
    uint m_AvatarSize,
    AvatarConstant m_Avatar,
    Dictionary<uint, AsciiString> m_TOS,
    HumanDescription m_HumanDescription) : IUnityEngineStructure
{
    public static UnityObjectType ObjectType => UnityObjectType.Avatar;
    public static Hash128 Hash => new("7C11FC061465D9A6CA18CC0CA1C10C84");
    public static Avatar Read(EndianBinaryReader reader)
    {
        AsciiString m_Name_ = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_Name */
        uint m_AvatarSize_ = reader.ReadU32();
        AvatarConstant m_Avatar_ = AvatarConstant.Read(reader);
        reader.AlignTo(4); /* m_Avatar */
        Dictionary<uint, AsciiString> m_TOS_ = BuiltInMap<uint, AsciiString>.Read(reader);
        reader.AlignTo(4); /* m_TOS */
        HumanDescription m_HumanDescription_ = HumanDescription.Read(reader);
        reader.AlignTo(4); /* m_HumanDescription */
        
        return new(m_Name_,
            m_AvatarSize_,
            m_Avatar_,
            m_TOS_,
            m_HumanDescription_);
    }

    public override string ToString() => $"Avatar\n{ToString(4)}";

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
        sb.AppendLine($"{indent_}m_AvatarSize: {m_AvatarSize}");
    }

    public void ToString_Field2(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_Avatar: {{ \n{m_Avatar.ToString(indent+4)}{indent_}}}\n");
    }

    public void ToString_Field3(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_TOS[{m_TOS.Count}] = {{");
        if (m_TOS.Count > 0) sb.AppendLine();
        int _4i = 0;
        foreach (KeyValuePair<uint, AsciiString> _4 in m_TOS)
        {
            sb.AppendLine($"{indent_ + ' '.Repeat(4)}[{_4.Key}] = \"{_4.Value}\"");
            ++_4i;
        }
        if (m_TOS.Count > 0) sb.Append(indent_);
        sb.AppendLine("}");
    }

    public void ToString_Field4(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_HumanDescription: {{ \n{m_HumanDescription.ToString(indent+4)}{indent_}}}\n");
    }
}


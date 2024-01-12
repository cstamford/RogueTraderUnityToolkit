namespace RogueTraderUnityToolkit.UnityGenerated.Types.Engine;

using Core;
using System.Text;
using Unity;

/* $TextAsset (2 fields) TextAsset E1A46B48EA6ABD5D64A0C18AC8895830 */
public record class TextAsset (
    AsciiString m_Name,
    AsciiString m_Script) : IUnityEngineStructure
{
    public static UnityObjectType ObjectType => UnityObjectType.TextAsset;
    public static Hash128 Hash => new("E1A46B48EA6ABD5D64A0C18AC8895830");
    public static TextAsset Read(EndianBinaryReader reader)
    {
        AsciiString m_Name_ = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_Name */
        AsciiString m_Script_ = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_Script */
        
        return new(m_Name_,
            m_Script_);
    }

    public override string ToString() => $"TextAsset\n{ToString(4)}";

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
        sb.AppendLine($"{indent_}m_Script: \"{m_Script}\"");
    }
}


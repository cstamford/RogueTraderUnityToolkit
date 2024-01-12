namespace RogueTraderUnityToolkit.UnityGenerated.Types.Engine;

using Core;
using System.Text;
using Unity;

/* $PreloadData (4 fields) PreloadData B5957185FBF85C93CB980B7CAC7E71A9 */
public record class PreloadData (
    AsciiString m_Name,
    PPtr<Object>[] m_Assets,
    AsciiString[] m_Dependencies,
    bool m_ExplicitDataLayout) : IUnityEngineStructure
{
    public static UnityObjectType ObjectType => UnityObjectType.PreloadData;
    public static Hash128 Hash => new("B5957185FBF85C93CB980B7CAC7E71A9");
    public static PreloadData Read(EndianBinaryReader reader)
    {
        AsciiString m_Name_ = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_Name */
        PPtr<Object>[] m_Assets_ = BuiltInArray<PPtr<Object>>.Read(reader);
        reader.AlignTo(4); /* m_Assets */
        AsciiString[] m_Dependencies_ = BuiltInArray<AsciiString>.Read(reader);
        reader.AlignTo(4); /* m_Dependencies */
        bool m_ExplicitDataLayout_ = reader.ReadBool();
        
        return new(m_Name_,
            m_Assets_,
            m_Dependencies_,
            m_ExplicitDataLayout_);
    }

    public override string ToString() => $"PreloadData\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();
        string indent_ = ' '.Repeat(indent);

        ToString_Field0(sb, indent, indent_);
        ToString_Field1(sb, indent, indent_);
        ToString_Field2(sb, indent, indent_);
        ToString_Field3(sb, indent, indent_);

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_Name: \"{m_Name}\"");
    }

    public void ToString_Field1(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_Assets[{m_Assets.Length}] = {{");
        if (m_Assets.Length > 0) sb.AppendLine();
        int _4i = 0;
        foreach (PPtr<Object> _4 in m_Assets)
        {
            sb.AppendLine($"{indent_ + ' '.Repeat(4)}[{_4i}] = {_4}");
            ++_4i;
        }
        if (m_Assets.Length > 0) sb.Append(indent_);
        sb.AppendLine("}");
    }

    public void ToString_Field2(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_Dependencies[{m_Dependencies.Length}] = {{");
        if (m_Dependencies.Length > 0) sb.AppendLine();
        int _4i = 0;
        foreach (AsciiString _4 in m_Dependencies)
        {
            sb.AppendLine($"{indent_ + ' '.Repeat(4)}[{_4i}] = \"{_4}\"");
            ++_4i;
        }
        if (m_Dependencies.Length > 0) sb.Append(indent_);
        sb.AppendLine("}");
    }

    public void ToString_Field3(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_ExplicitDataLayout: {m_ExplicitDataLayout}");
    }
}


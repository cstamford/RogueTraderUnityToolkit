namespace RogueTraderUnityToolkit.UnityGenerated.Types.Engine;

using Core;
using System.Text;
using Unity;

/* $VisualEffectAsset (3 fields) VisualEffectAsset 9E4574B6881DEB162C7B7E88AD5B3242 */
public record class VisualEffectAsset (
    AsciiString m_Name,
    VisualEffectInfo m_Infos,
    VFXSystemDesc[] m_Systems) : IUnityEngineStructure
{
    public static UnityObjectType ObjectType => UnityObjectType.VisualEffectAsset;
    public static Hash128 Hash => new("9E4574B6881DEB162C7B7E88AD5B3242");
    public static VisualEffectAsset Read(EndianBinaryReader reader)
    {
        AsciiString m_Name_ = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_Name */
        VisualEffectInfo m_Infos_ = VisualEffectInfo.Read(reader);
        reader.AlignTo(4); /* m_Infos */
        VFXSystemDesc[] m_Systems_ = BuiltInArray<VFXSystemDesc>.Read(reader);
        reader.AlignTo(4); /* m_Systems */
        
        return new(m_Name_,
            m_Infos_,
            m_Systems_);
    }

    public override string ToString() => $"VisualEffectAsset\n{ToString(4)}";

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
        sb.Append($"{indent_}m_Infos: {{ \n{m_Infos.ToString(indent+4)}{indent_}}}\n");
    }

    public void ToString_Field2(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_Systems[{m_Systems.Length}] = {{");
        if (m_Systems.Length > 0) sb.AppendLine();
        int _4i = 0;
        foreach (VFXSystemDesc _4 in m_Systems)
        {
            sb.Append($"{indent_ + ' '.Repeat(4)}[{_4i}] = {{ \n{_4.ToString(indent+8)}{indent_ + ' '.Repeat(4)}}}\n");
            ++_4i;
        }
        if (m_Systems.Length > 0) sb.Append(indent_);
        sb.AppendLine("}");
    }
}


namespace RogueTraderUnityToolkit.UnityGenerated.Types.Engine;

using Core;
using System.Text;
using Unity;

/* $MonoBehaviour (4 fields) MonoBehaviour 010870D965DB3BACF528A442C657F3E8 */
public record class MonoBehaviour (
    PPtr<GameObject> m_GameObject,
    byte m_Enabled,
    PPtr<MonoScript> m_Script,
    AsciiString m_Name) : IUnityEngineStructure
{
    public static UnityObjectType ObjectType => UnityObjectType.MonoBehaviour;
    public static Hash128 Hash => new("010870D965DB3BACF528A442C657F3E8");
    public static MonoBehaviour Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> m_GameObject_ = PPtr<GameObject>.Read(reader);
        byte m_Enabled_ = reader.ReadU8();
        reader.AlignTo(4); /* m_Enabled */
        PPtr<MonoScript> m_Script_ = PPtr<MonoScript>.Read(reader);
        AsciiString m_Name_ = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_Name */
        
        return new(m_GameObject_,
            m_Enabled_,
            m_Script_,
            m_Name_);
    }

    public override string ToString() => $"MonoBehaviour\n{ToString(4)}";

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
        sb.AppendLine($"{indent_}m_GameObject: {m_GameObject}");
    }

    public void ToString_Field1(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_Enabled: {m_Enabled}");
    }

    public void ToString_Field2(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_Script: {m_Script}");
    }

    public void ToString_Field3(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_Name: \"{m_Name}\"");
    }
}


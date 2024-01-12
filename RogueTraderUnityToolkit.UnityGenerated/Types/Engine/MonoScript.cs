namespace RogueTraderUnityToolkit.UnityGenerated.Types.Engine;

using Core;
using System.Text;
using Unity;

/* $MonoScript (6 fields) MonoScript CA1AF11EF54057482C227089E9D728E9 */
public record class MonoScript (
    AsciiString m_Name,
    int m_ExecutionOrder,
    Hash128 m_PropertiesHash,
    AsciiString m_ClassName,
    AsciiString m_Namespace,
    AsciiString m_AssemblyName) : IUnityEngineStructure
{
    public static UnityObjectType ObjectType => UnityObjectType.MonoScript;
    public static Hash128 Hash => new("CA1AF11EF54057482C227089E9D728E9");
    public static MonoScript Read(EndianBinaryReader reader)
    {
        AsciiString m_Name_ = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_Name */
        int m_ExecutionOrder_ = reader.ReadS32();
        Hash128 m_PropertiesHash_ = Hash128.Read(reader);
        AsciiString m_ClassName_ = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_ClassName */
        AsciiString m_Namespace_ = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_Namespace */
        AsciiString m_AssemblyName_ = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_AssemblyName */
        
        return new(m_Name_,
            m_ExecutionOrder_,
            m_PropertiesHash_,
            m_ClassName_,
            m_Namespace_,
            m_AssemblyName_);
    }

    public override string ToString() => $"MonoScript\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();
        string indent_ = ' '.Repeat(indent);

        ToString_Field0(sb, indent, indent_);
        ToString_Field1(sb, indent, indent_);
        ToString_Field2(sb, indent, indent_);
        ToString_Field3(sb, indent, indent_);
        ToString_Field4(sb, indent, indent_);
        ToString_Field5(sb, indent, indent_);

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_Name: \"{m_Name}\"");
    }

    public void ToString_Field1(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_ExecutionOrder: {m_ExecutionOrder}");
    }

    public void ToString_Field2(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_PropertiesHash: {m_PropertiesHash}");
    }

    public void ToString_Field3(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_ClassName: \"{m_ClassName}\"");
    }

    public void ToString_Field4(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_Namespace: \"{m_Namespace}\"");
    }

    public void ToString_Field5(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_AssemblyName: \"{m_AssemblyName}\"");
    }
}


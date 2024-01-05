namespace RogueTraderUnityToolkit.UnityGenerated.Types.Engine;

using Core;
using System.Text;
using Unity;

/* $MonoScript (6 fields) CA1AF11EF54057482C227089E9D728E9 */
public record class MonoScript(
    AsciiString m_Name,
    int m_ExecutionOrder,
    Hash128 m_PropertiesHash,
    AsciiString m_ClassName,
    AsciiString m_Namespace,
    AsciiString m_AssemblyName) : IUnityEngineStructure
{
    public static Hash128 Hash => new(3390763294, 4114634568, 740454537, 3923192041);

    public static MonoScript Read(EndianBinaryReader reader)
    {
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_Name */
        int _m_ExecutionOrder = reader.ReadS32();
        Hash128 _m_PropertiesHash = Hash128.Read(reader);
        AsciiString _m_ClassName = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_ClassName */
        AsciiString _m_Namespace = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_Namespace */
        AsciiString _m_AssemblyName = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_AssemblyName */
        
        return new(_m_Name,
            _m_ExecutionOrder,
            _m_PropertiesHash,
            _m_ClassName,
            _m_Namespace,
            _m_AssemblyName);
    }

    public override string ToString() => $"MonoScript\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Name: ");
        sb.AppendLine(m_Name.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_ExecutionOrder: ");
        sb.AppendLine(m_ExecutionOrder.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_PropertiesHash: ");
        sb.AppendLine(m_PropertiesHash.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_ClassName: ");
        sb.AppendLine(m_ClassName.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Namespace: ");
        sb.AppendLine(m_Namespace.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_AssemblyName: ");
        sb.AppendLine(m_AssemblyName.ToString());

        return sb.ToString();
    }
}


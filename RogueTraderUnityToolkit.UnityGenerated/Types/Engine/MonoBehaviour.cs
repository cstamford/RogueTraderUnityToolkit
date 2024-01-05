namespace RogueTraderUnityToolkit.UnityGenerated.Types.Engine;

using Core;
using System.Text;
using Unity;

/* $MonoBehaviour (4 fields) 00000000000000000000000000000000 */
public record class MonoBehaviour(
    PPtr<GameObject> m_GameObject,
    byte m_Enabled,
    PPtr<MonoScript> m_Script,
    AsciiString m_Name) : IUnityEngineStructure
{
    public static Hash128 Hash => new(0, 0, 0, 0);

    public static MonoBehaviour Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Enabled */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_Name */
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name);
    }

    public override string ToString() => $"MonoBehaviour\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_GameObject: ");
        sb.AppendLine(m_GameObject.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Enabled: ");
        sb.AppendLine(m_Enabled.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Script: ");
        sb.AppendLine(m_Script.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Name: ");
        sb.AppendLine(m_Name.ToString());

        return sb.ToString();
    }
}


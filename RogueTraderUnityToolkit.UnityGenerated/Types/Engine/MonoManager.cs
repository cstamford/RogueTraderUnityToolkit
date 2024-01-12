namespace RogueTraderUnityToolkit.UnityGenerated.Types.Engine;

using Core;
using System.Text;
using Unity;

/* $MonoManager (3 fields) MonoManager 36707914DD4807B86B739B75E1174D9B */
public record class MonoManager (
    Dictionary<Hash128, Hash128> m_ScriptHashes,
    Dictionary<int, Hash128> m_RuntimeClassHashes,
    PPtr<MonoScript>[] m_Scripts) : IUnityEngineStructure
{
    public static UnityObjectType ObjectType => UnityObjectType.MonoManager;
    public static Hash128 Hash => new("36707914DD4807B86B739B75E1174D9B");
    public static MonoManager Read(EndianBinaryReader reader)
    {
        Dictionary<Hash128, Hash128> m_ScriptHashes_ = BuiltInMap<Hash128, Hash128>.Read(reader);
        Dictionary<int, Hash128> m_RuntimeClassHashes_ = BuiltInMap<int, Hash128>.Read(reader);
        PPtr<MonoScript>[] m_Scripts_ = BuiltInArray<PPtr<MonoScript>>.Read(reader);
        
        return new(m_ScriptHashes_,
            m_RuntimeClassHashes_,
            m_Scripts_);
    }

    public override string ToString() => $"MonoManager\n{ToString(4)}";

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
        sb.Append($"{indent_}m_ScriptHashes[{m_ScriptHashes.Count}] = {{");
        if (m_ScriptHashes.Count > 0) sb.AppendLine();
        int _4i = 0;
        foreach (KeyValuePair<Hash128, Hash128> _4 in m_ScriptHashes)
        {
            sb.AppendLine($"{indent_ + ' '.Repeat(4)}[{_4.Key}] = {_4.Value}");
            ++_4i;
        }
        if (m_ScriptHashes.Count > 0) sb.Append(indent_);
        sb.AppendLine("}");
    }

    public void ToString_Field1(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_RuntimeClassHashes[{m_RuntimeClassHashes.Count}] = {{");
        if (m_RuntimeClassHashes.Count > 0) sb.AppendLine();
        int _4i = 0;
        foreach (KeyValuePair<int, Hash128> _4 in m_RuntimeClassHashes)
        {
            sb.AppendLine($"{indent_ + ' '.Repeat(4)}[{_4.Key}] = {_4.Value}");
            ++_4i;
        }
        if (m_RuntimeClassHashes.Count > 0) sb.Append(indent_);
        sb.AppendLine("}");
    }

    public void ToString_Field2(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_Scripts[{m_Scripts.Length}] = {{");
        if (m_Scripts.Length > 0) sb.AppendLine();
        int _4i = 0;
        foreach (PPtr<MonoScript> _4 in m_Scripts)
        {
            sb.AppendLine($"{indent_ + ' '.Repeat(4)}[{_4i}] = {_4}");
            ++_4i;
        }
        if (m_Scripts.Length > 0) sb.Append(indent_);
        sb.AppendLine("}");
    }
}


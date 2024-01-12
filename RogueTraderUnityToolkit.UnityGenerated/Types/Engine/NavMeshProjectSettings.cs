namespace RogueTraderUnityToolkit.UnityGenerated.Types.Engine;

using Core;
using System.Text;
using Unity;

/* $NavMeshProjectSettings (4 fields) NavMeshProjectSettings F4C2943F0E5F89DAEF4DE9B5F5F3573E */
public record class NavMeshProjectSettings (
    NavMeshAreaData[] areas,
    int m_LastAgentTypeID,
    NavMeshBuildSettings[] m_Settings,
    AsciiString[] m_SettingNames) : IUnityEngineStructure
{
    public static UnityObjectType ObjectType => UnityObjectType.NavMeshProjectSettings;
    public static Hash128 Hash => new("F4C2943F0E5F89DAEF4DE9B5F5F3573E");
    public static NavMeshProjectSettings Read(EndianBinaryReader reader)
    {
        NavMeshAreaData[] areas_ = BuiltInArray<NavMeshAreaData>.Read(reader);
        reader.AlignTo(4); /* areas */
        int m_LastAgentTypeID_ = reader.ReadS32();
        NavMeshBuildSettings[] m_Settings_ = BuiltInArray<NavMeshBuildSettings>.Read(reader);
        reader.AlignTo(4); /* m_Settings */
        AsciiString[] m_SettingNames_ = BuiltInArray<AsciiString>.Read(reader);
        reader.AlignTo(4); /* m_SettingNames */
        
        return new(areas_,
            m_LastAgentTypeID_,
            m_Settings_,
            m_SettingNames_);
    }

    public override string ToString() => $"NavMeshProjectSettings\n{ToString(4)}";

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
        sb.Append($"{indent_}areas[{areas.Length}] = {{");
        if (areas.Length > 0) sb.AppendLine();
        int _4i = 0;
        foreach (NavMeshAreaData _4 in areas)
        {
            sb.Append($"{indent_ + ' '.Repeat(4)}[{_4i}] = {{ \n{_4.ToString(indent+8)}{indent_ + ' '.Repeat(4)}}}\n");
            ++_4i;
        }
        if (areas.Length > 0) sb.Append(indent_);
        sb.AppendLine("}");
    }

    public void ToString_Field1(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_LastAgentTypeID: {m_LastAgentTypeID}");
    }

    public void ToString_Field2(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_Settings[{m_Settings.Length}] = {{");
        if (m_Settings.Length > 0) sb.AppendLine();
        int _4i = 0;
        foreach (NavMeshBuildSettings _4 in m_Settings)
        {
            sb.Append($"{indent_ + ' '.Repeat(4)}[{_4i}] = {{ \n{_4.ToString(indent+8)}{indent_ + ' '.Repeat(4)}}}\n");
            ++_4i;
        }
        if (m_Settings.Length > 0) sb.Append(indent_);
        sb.AppendLine("}");
    }

    public void ToString_Field3(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_SettingNames[{m_SettingNames.Length}] = {{");
        if (m_SettingNames.Length > 0) sb.AppendLine();
        int _4i = 0;
        foreach (AsciiString _4 in m_SettingNames)
        {
            sb.AppendLine($"{indent_ + ' '.Repeat(4)}[{_4i}] = \"{_4}\"");
            ++_4i;
        }
        if (m_SettingNames.Length > 0) sb.Append(indent_);
        sb.AppendLine("}");
    }
}


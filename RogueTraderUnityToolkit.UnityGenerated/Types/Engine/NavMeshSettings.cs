namespace RogueTraderUnityToolkit.UnityGenerated.Types.Engine;

using Core;
using System.Text;
using Unity;

/* $NavMeshSettings (1 fields) NavMeshSettings 270C6F30D58ADC39A4A1B44F80381A4D */
public record class NavMeshSettings (
    PPtr<NavMeshData> m_NavMeshData) : IUnityEngineStructure
{
    public static UnityObjectType ObjectType => UnityObjectType.NavMeshSettings;
    public static Hash128 Hash => new("270C6F30D58ADC39A4A1B44F80381A4D");
    public static NavMeshSettings Read(EndianBinaryReader reader)
    {
        PPtr<NavMeshData> m_NavMeshData_ = PPtr<NavMeshData>.Read(reader);
        
        return new(m_NavMeshData_);
    }

    public override string ToString() => $"NavMeshSettings\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();
        string indent_ = ' '.Repeat(indent);

        ToString_Field0(sb, indent, indent_);

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_NavMeshData: {m_NavMeshData}");
    }
}


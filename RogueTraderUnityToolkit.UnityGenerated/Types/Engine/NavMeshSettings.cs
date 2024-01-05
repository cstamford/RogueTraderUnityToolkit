namespace RogueTraderUnityToolkit.UnityGenerated.Types.Engine;

using Core;
using System.Text;
using Unity;

/* $NavMeshSettings (1 fields) 270C6F30D58ADC39A4A1B44F80381A4D */
public record class NavMeshSettings(
    PPtr<NavMeshData> m_NavMeshData) : IUnityEngineStructure
{
    public static Hash128 Hash => new(655126320, 3582647353, 2762060879, 2151160397);

    public static NavMeshSettings Read(EndianBinaryReader reader)
    {
        PPtr<NavMeshData> _m_NavMeshData = PPtr<NavMeshData>.Read(reader);
        
        return new(_m_NavMeshData);
    }

    public override string ToString() => $"NavMeshSettings\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_NavMeshData: ");
        sb.AppendLine(m_NavMeshData.ToString());

        return sb.ToString();
    }
}


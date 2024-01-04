namespace RogueTraderUnityToolkit.UnityGenerated.Types.Engine;

using Core;
using Unity;

/* $NavMeshSettings (1 fields) 270C6F30D58ADC39A4A1B44F80381A4D */
public record class NavMeshSettings(
    PPtr<NavMeshData> m_NavMeshData /* None */) : IUnityObject
{
    public static Hash128 Hash => new(655126320, 3582647353, 2762060879, 2151160397);
    public static NavMeshSettings Read(EndianBinaryReader reader)
    {
        PPtr<NavMeshData> _m_NavMeshData = PPtr<NavMeshData>.Read(reader);
        
        return new(_m_NavMeshData);
    }
}


namespace RogueTraderUnityToolkit.UnityStructures.Generated.Engine;

using Core;
using Unity.BuiltInTypes;

/* $NavMeshSettings (1 fields) (IsEngineType) */
public record class NavMeshSettings(
    PPtr<NavMeshData> m_NavMeshData)
{
    public static NavMeshSettings Read(EndianBinaryReader reader)
    {
        PPtr<NavMeshData> m_NavMeshData = PPtr<NavMeshData>.Read(reader);
        
        return new(m_NavMeshData);
    }
}


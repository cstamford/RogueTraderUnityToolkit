namespace RogueTraderUnityToolkit.Unity.Generated.Engine;

using Core;

/* $MeshFilter (2 fields) (IsEngineType) */
public record class MeshFilter(
    PPtr<GameObject> m_GameObject,
    PPtr<Mesh> m_Mesh)
{
    public static MeshFilter Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> m_GameObject = PPtr<GameObject>.Read(reader);
        PPtr<Mesh> m_Mesh = PPtr<Mesh>.Read(reader);
        
        return new(m_GameObject,
            m_Mesh);
    }
}


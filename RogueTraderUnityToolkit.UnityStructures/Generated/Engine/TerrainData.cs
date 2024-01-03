namespace RogueTraderUnityToolkit.UnityStructures.Generated.Engine;

using Core;
using Unity.BuiltInTypes;

/* $TerrainData (5 fields) (IsEngineType) */
public record class TerrainData(
    AsciiString m_Name,
    SplatDatabase m_SplatDatabase,
    DetailDatabase m_DetailDatabase,
    Heightmap m_Heightmap,
    PPtr<Shader>[] m_PreloadShaders)
{
    public static TerrainData Read(EndianBinaryReader reader)
    {
        AsciiString m_Name = String.Read(reader);
        SplatDatabase m_SplatDatabase = SplatDatabase.Read(reader);
        DetailDatabase m_DetailDatabase = DetailDatabase.Read(reader);
        Heightmap m_Heightmap = Heightmap.Read(reader);
        PPtr<Shader>[] m_PreloadShaders = Array<PPtr<Shader>>.Read(reader);
        
        return new(m_Name,
            m_SplatDatabase,
            m_DetailDatabase,
            m_Heightmap,
            m_PreloadShaders);
    }
}


namespace RogueTraderUnityToolkit.UnityGenerated.Types.Engine;

using Core;
using Unity;

/* $TerrainData (5 fields) DCF37C325F52F0390A319657B02B92E6 */
public record class TerrainData(
    AsciiString m_Name /* None */,
    SplatDatabase m_SplatDatabase /* NeedsAlign */,
    DetailDatabase m_DetailDatabase /* NeedsAlign */,
    Heightmap m_Heightmap /* NeedsAlign */,
    PPtr<Shader>[] m_PreloadShaders /* NeedsAlign */) : IUnityObject
{
    public static Hash128 Hash => new(3706944562, 1599270969, 171021911, 2955645670);
    public static TerrainData Read(EndianBinaryReader reader)
    {
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_SplatDatabase */
        SplatDatabase _m_SplatDatabase = SplatDatabase.Read(reader);
        reader.AlignTo(4); /* m_DetailDatabase */
        DetailDatabase _m_DetailDatabase = DetailDatabase.Read(reader);
        reader.AlignTo(4); /* m_Heightmap */
        Heightmap _m_Heightmap = Heightmap.Read(reader);
        reader.AlignTo(4); /* m_PreloadShaders */
        PPtr<Shader>[] _m_PreloadShaders = BuiltInArray<PPtr<Shader>>.Read(reader);
        
        return new(_m_Name,
            _m_SplatDatabase,
            _m_DetailDatabase,
            _m_Heightmap,
            _m_PreloadShaders);
    }
}


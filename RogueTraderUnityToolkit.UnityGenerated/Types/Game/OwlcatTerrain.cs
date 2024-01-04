namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $OwlcatTerrain (13 fields) 8AB61B272E6247865700399E188E0EC1/EF50C143B8225B5832CFF63CC00392AE */
public record class OwlcatTerrain(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    int TerrainSize /* NeedsAlign */,
    Vector4f[] m_LayerDataMasksScale /* None */,
    Vector4f[] m_LayerDataUvMatrix /* NeedsAlign */,
    Vector4f[] m_LayerDataParams /* NeedsAlign */,
    PPtr<Texture2DArray> m_Diffuse /* NeedsAlign */,
    PPtr<Texture2DArray> m_Normal /* None */,
    PPtr<Texture2DArray> m_Masks /* None */,
    int TexturesResolution /* None */,
    PPtr<Texture2DArray> m_SplatArray /* None */)
{
    public static OwlcatTerrain Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* TerrainSize */
        int _TerrainSize = reader.ReadS32();
        Vector4f[] _m_LayerDataMasksScale = BuiltInArray<Vector4f>.Read(reader);
        reader.AlignTo(4); /* m_LayerDataUvMatrix */
        Vector4f[] _m_LayerDataUvMatrix = BuiltInArray<Vector4f>.Read(reader);
        reader.AlignTo(4); /* m_LayerDataParams */
        Vector4f[] _m_LayerDataParams = BuiltInArray<Vector4f>.Read(reader);
        reader.AlignTo(4); /* m_Diffuse */
        PPtr<Texture2DArray> _m_Diffuse = PPtr<Texture2DArray>.Read(reader);
        PPtr<Texture2DArray> _m_Normal = PPtr<Texture2DArray>.Read(reader);
        PPtr<Texture2DArray> _m_Masks = PPtr<Texture2DArray>.Read(reader);
        int _TexturesResolution = reader.ReadS32();
        PPtr<Texture2DArray> _m_SplatArray = PPtr<Texture2DArray>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _TerrainSize,
            _m_LayerDataMasksScale,
            _m_LayerDataUvMatrix,
            _m_LayerDataParams,
            _m_Diffuse,
            _m_Normal,
            _m_Masks,
            _TexturesResolution,
            _m_SplatArray);
    }
}


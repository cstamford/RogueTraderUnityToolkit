namespace RogueTraderUnityToolkit.UnityGenerated.Types.Engine;

using Core;
using Unity;

/* $TerrainLayer (14 fields) 2E69023849422B50F8B0E62D2E83D2A1 */
public record class TerrainLayer(
    AsciiString m_Name /* None */,
    PPtr<Texture2D> m_DiffuseTexture /* NeedsAlign */,
    PPtr<Texture2D> m_NormalMapTexture /* None */,
    PPtr<Texture2D> m_MaskMapTexture /* None */,
    Vector2f m_TileSize /* None */,
    Vector2f m_TileOffset /* None */,
    ColorRGBA m_Specular /* None */,
    float m_Metallic /* None */,
    float m_Smoothness /* None */,
    float m_NormalScale /* None */,
    Vector4f m_DiffuseRemapMin /* None */,
    Vector4f m_DiffuseRemapMax /* None */,
    Vector4f m_MaskMapRemapMin /* None */,
    Vector4f m_MaskMapRemapMax /* None */) : IUnityObject
{
    public static Hash128 Hash => new(778633784, 1229073232, 4172342829, 780391073);
    public static TerrainLayer Read(EndianBinaryReader reader)
    {
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_DiffuseTexture */
        PPtr<Texture2D> _m_DiffuseTexture = PPtr<Texture2D>.Read(reader);
        PPtr<Texture2D> _m_NormalMapTexture = PPtr<Texture2D>.Read(reader);
        PPtr<Texture2D> _m_MaskMapTexture = PPtr<Texture2D>.Read(reader);
        Vector2f _m_TileSize = Vector2f.Read(reader);
        Vector2f _m_TileOffset = Vector2f.Read(reader);
        ColorRGBA _m_Specular = ColorRGBA.Read(reader);
        float _m_Metallic = reader.ReadF32();
        float _m_Smoothness = reader.ReadF32();
        float _m_NormalScale = reader.ReadF32();
        Vector4f _m_DiffuseRemapMin = Vector4f.Read(reader);
        Vector4f _m_DiffuseRemapMax = Vector4f.Read(reader);
        Vector4f _m_MaskMapRemapMin = Vector4f.Read(reader);
        Vector4f _m_MaskMapRemapMax = Vector4f.Read(reader);
        
        return new(_m_Name,
            _m_DiffuseTexture,
            _m_NormalMapTexture,
            _m_MaskMapTexture,
            _m_TileSize,
            _m_TileOffset,
            _m_Specular,
            _m_Metallic,
            _m_Smoothness,
            _m_NormalScale,
            _m_DiffuseRemapMin,
            _m_DiffuseRemapMax,
            _m_MaskMapRemapMin,
            _m_MaskMapRemapMax);
    }
}


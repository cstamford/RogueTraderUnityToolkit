namespace RogueTraderUnityToolkit.UnityStructures.Generated.Engine;

using Core;
using Unity.BuiltInTypes;

/* $TerrainLayer (14 fields) (IsEngineType) */
public record class TerrainLayer(
    AsciiString m_Name,
    PPtr<Texture2D> m_DiffuseTexture,
    PPtr<Texture2D> m_NormalMapTexture,
    PPtr<Texture2D> m_MaskMapTexture,
    Vector2f m_TileSize,
    Vector2f m_TileOffset,
    ColorRGBA m_Specular,
    float m_Metallic,
    float m_Smoothness,
    float m_NormalScale,
    Vector4f m_DiffuseRemapMin,
    Vector4f m_DiffuseRemapMax,
    Vector4f m_MaskMapRemapMin,
    Vector4f m_MaskMapRemapMax)
{
    public static TerrainLayer Read(EndianBinaryReader reader)
    {
        AsciiString m_Name = String.Read(reader);
        PPtr<Texture2D> m_DiffuseTexture = PPtr<Texture2D>.Read(reader);
        PPtr<Texture2D> m_NormalMapTexture = PPtr<Texture2D>.Read(reader);
        PPtr<Texture2D> m_MaskMapTexture = PPtr<Texture2D>.Read(reader);
        Vector2f m_TileSize = Vector2f.Read(reader);
        Vector2f m_TileOffset = Vector2f.Read(reader);
        ColorRGBA m_Specular = ColorRGBA.Read(reader);
        float m_Metallic = reader.ReadF32();
        float m_Smoothness = reader.ReadF32();
        float m_NormalScale = reader.ReadF32();
        Vector4f m_DiffuseRemapMin = Vector4f.Read(reader);
        Vector4f m_DiffuseRemapMax = Vector4f.Read(reader);
        Vector4f m_MaskMapRemapMin = Vector4f.Read(reader);
        Vector4f m_MaskMapRemapMax = Vector4f.Read(reader);
        
        return new(m_Name,
            m_DiffuseTexture,
            m_NormalMapTexture,
            m_MaskMapTexture,
            m_TileSize,
            m_TileOffset,
            m_Specular,
            m_Metallic,
            m_Smoothness,
            m_NormalScale,
            m_DiffuseRemapMin,
            m_DiffuseRemapMax,
            m_MaskMapRemapMin,
            m_MaskMapRemapMax);
    }
}


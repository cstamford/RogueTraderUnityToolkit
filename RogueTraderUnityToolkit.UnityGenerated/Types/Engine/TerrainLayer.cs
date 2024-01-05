namespace RogueTraderUnityToolkit.UnityGenerated.Types.Engine;

using Core;
using System.Text;
using Unity;

/* $TerrainLayer (14 fields) 2E69023849422B50F8B0E62D2E83D2A1 */
public record class TerrainLayer(
    AsciiString m_Name,
    PPtr<Texture2D> m_DiffuseTexture,
    PPtr<Texture2D> m_NormalMapTexture,
    PPtr<Texture2D> m_MaskMapTexture,
    Vector2f m_TileSize,
    Vector2f m_TileOffset,
    ColorRGBA_0 m_Specular,
    float m_Metallic,
    float m_Smoothness,
    float m_NormalScale,
    Vector4f m_DiffuseRemapMin,
    Vector4f m_DiffuseRemapMax,
    Vector4f m_MaskMapRemapMin,
    Vector4f m_MaskMapRemapMax) : IUnityEngineStructure
{
    public static Hash128 Hash => new(778633784, 1229073232, 4172342829, 780391073);

    public static TerrainLayer Read(EndianBinaryReader reader)
    {
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_Name */
        PPtr<Texture2D> _m_DiffuseTexture = PPtr<Texture2D>.Read(reader);
        PPtr<Texture2D> _m_NormalMapTexture = PPtr<Texture2D>.Read(reader);
        PPtr<Texture2D> _m_MaskMapTexture = PPtr<Texture2D>.Read(reader);
        Vector2f _m_TileSize = Vector2f.Read(reader);
        Vector2f _m_TileOffset = Vector2f.Read(reader);
        ColorRGBA_0 _m_Specular = ColorRGBA_0.Read(reader);
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

    public override string ToString() => $"TerrainLayer\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Name: ");
        sb.AppendLine(m_Name.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_DiffuseTexture: ");
        sb.AppendLine(m_DiffuseTexture.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_NormalMapTexture: ");
        sb.AppendLine(m_NormalMapTexture.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_MaskMapTexture: ");
        sb.AppendLine(m_MaskMapTexture.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_TileSize: ");
        sb.AppendLine();
        sb.Append(m_TileSize.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_TileOffset: ");
        sb.AppendLine();
        sb.Append(m_TileOffset.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Specular: ");
        sb.AppendLine();
        sb.Append(m_Specular.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Metallic: ");
        sb.AppendLine(m_Metallic.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Smoothness: ");
        sb.AppendLine(m_Smoothness.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_NormalScale: ");
        sb.AppendLine(m_NormalScale.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_DiffuseRemapMin: ");
        sb.AppendLine();
        sb.Append(m_DiffuseRemapMin.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_DiffuseRemapMax: ");
        sb.AppendLine();
        sb.Append(m_DiffuseRemapMax.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_MaskMapRemapMin: ");
        sb.AppendLine();
        sb.Append(m_MaskMapRemapMin.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_MaskMapRemapMax: ");
        sb.AppendLine();
        sb.Append(m_MaskMapRemapMax.ToString(indent+4));

        return sb.ToString();
    }
}


namespace RogueTraderUnityToolkit.UnityGenerated.Types.Engine;

using Core;
using System.Text;
using Unity;

/* $TerrainLayer (14 fields) TerrainLayer 2E69023849422B50F8B0E62D2E83D2A1 */
public record class TerrainLayer (
    AsciiString m_Name,
    PPtr<Texture2D> m_DiffuseTexture,
    PPtr<Texture2D> m_NormalMapTexture,
    PPtr<Texture2D> m_MaskMapTexture,
    Vector2f m_TileSize,
    Vector2f m_TileOffset,
    ColorRGBA_1 m_Specular,
    float m_Metallic,
    float m_Smoothness,
    float m_NormalScale,
    Vector4f m_DiffuseRemapMin,
    Vector4f m_DiffuseRemapMax,
    Vector4f m_MaskMapRemapMin,
    Vector4f m_MaskMapRemapMax) : IUnityEngineStructure
{
    public static UnityObjectType ObjectType => UnityObjectType.TerrainLayer;
    public static Hash128 Hash => new("2E69023849422B50F8B0E62D2E83D2A1");
    public static TerrainLayer Read(EndianBinaryReader reader)
    {
        AsciiString m_Name_ = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_Name */
        PPtr<Texture2D> m_DiffuseTexture_ = PPtr<Texture2D>.Read(reader);
        PPtr<Texture2D> m_NormalMapTexture_ = PPtr<Texture2D>.Read(reader);
        PPtr<Texture2D> m_MaskMapTexture_ = PPtr<Texture2D>.Read(reader);
        Vector2f m_TileSize_ = Vector2f.Read(reader);
        Vector2f m_TileOffset_ = Vector2f.Read(reader);
        ColorRGBA_1 m_Specular_ = ColorRGBA_1.Read(reader);
        float m_Metallic_ = reader.ReadF32();
        float m_Smoothness_ = reader.ReadF32();
        float m_NormalScale_ = reader.ReadF32();
        Vector4f m_DiffuseRemapMin_ = Vector4f.Read(reader);
        Vector4f m_DiffuseRemapMax_ = Vector4f.Read(reader);
        Vector4f m_MaskMapRemapMin_ = Vector4f.Read(reader);
        Vector4f m_MaskMapRemapMax_ = Vector4f.Read(reader);
        
        return new(m_Name_,
            m_DiffuseTexture_,
            m_NormalMapTexture_,
            m_MaskMapTexture_,
            m_TileSize_,
            m_TileOffset_,
            m_Specular_,
            m_Metallic_,
            m_Smoothness_,
            m_NormalScale_,
            m_DiffuseRemapMin_,
            m_DiffuseRemapMax_,
            m_MaskMapRemapMin_,
            m_MaskMapRemapMax_);
    }

    public override string ToString() => $"TerrainLayer\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();
        string indent_ = ' '.Repeat(indent);

        ToString_Field0(sb, indent, indent_);
        ToString_Field1(sb, indent, indent_);
        ToString_Field2(sb, indent, indent_);
        ToString_Field3(sb, indent, indent_);
        ToString_Field4(sb, indent, indent_);
        ToString_Field5(sb, indent, indent_);
        ToString_Field6(sb, indent, indent_);
        ToString_Field7(sb, indent, indent_);
        ToString_Field8(sb, indent, indent_);
        ToString_Field9(sb, indent, indent_);
        ToString_Field10(sb, indent, indent_);
        ToString_Field11(sb, indent, indent_);
        ToString_Field12(sb, indent, indent_);
        ToString_Field13(sb, indent, indent_);

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_Name: \"{m_Name}\"");
    }

    public void ToString_Field1(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_DiffuseTexture: {m_DiffuseTexture}");
    }

    public void ToString_Field2(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_NormalMapTexture: {m_NormalMapTexture}");
    }

    public void ToString_Field3(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_MaskMapTexture: {m_MaskMapTexture}");
    }

    public void ToString_Field4(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_TileSize: {{ x: {m_TileSize.x}, y: {m_TileSize.y} }}\n");
    }

    public void ToString_Field5(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_TileOffset: {{ x: {m_TileOffset.x}, y: {m_TileOffset.y} }}\n");
    }

    public void ToString_Field6(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_Specular: {{ r: {m_Specular.r}, g: {m_Specular.g}, b: {m_Specular.b}, a: {m_Specular.a} }}\n");
    }

    public void ToString_Field7(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_Metallic: {m_Metallic}");
    }

    public void ToString_Field8(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_Smoothness: {m_Smoothness}");
    }

    public void ToString_Field9(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_NormalScale: {m_NormalScale}");
    }

    public void ToString_Field10(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_DiffuseRemapMin: {{ x: {m_DiffuseRemapMin.x}, y: {m_DiffuseRemapMin.y}, z: {m_DiffuseRemapMin.z}, w: {m_DiffuseRemapMin.w} }}\n");
    }

    public void ToString_Field11(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_DiffuseRemapMax: {{ x: {m_DiffuseRemapMax.x}, y: {m_DiffuseRemapMax.y}, z: {m_DiffuseRemapMax.z}, w: {m_DiffuseRemapMax.w} }}\n");
    }

    public void ToString_Field12(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_MaskMapRemapMin: {{ x: {m_MaskMapRemapMin.x}, y: {m_MaskMapRemapMin.y}, z: {m_MaskMapRemapMin.z}, w: {m_MaskMapRemapMin.w} }}\n");
    }

    public void ToString_Field13(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_MaskMapRemapMax: {{ x: {m_MaskMapRemapMax.x}, y: {m_MaskMapRemapMax.y}, z: {m_MaskMapRemapMax.z}, w: {m_MaskMapRemapMax.w} }}\n");
    }
}


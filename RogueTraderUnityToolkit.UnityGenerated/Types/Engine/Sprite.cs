namespace RogueTraderUnityToolkit.UnityGenerated.Types.Engine;

using Core;
using System.Text;
using Unity;

/* $Sprite (14 fields) Sprite DAA9127037D56E771320E274D2BB5D56 */
public record class Sprite (
    AsciiString m_Name,
    Rectf m_Rect,
    Vector2f m_Offset,
    Vector4f m_Border,
    float m_PixelsToUnits,
    Vector2f m_Pivot,
    uint m_Extrude,
    bool m_IsPolygon,
    pair_1 m_RenderDataKey,
    AsciiString[] m_AtlasTags,
    PPtr<SpriteAtlas> m_SpriteAtlas,
    SpriteRenderData m_RD,
    Vector2f[][] m_PhysicsShape,
    SpriteBone[] m_Bones) : IUnityEngineStructure
{
    public static UnityObjectType ObjectType => UnityObjectType.Sprite;
    public static Hash128 Hash => new("DAA9127037D56E771320E274D2BB5D56");
    public static Sprite Read(EndianBinaryReader reader)
    {
        AsciiString m_Name_ = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_Name */
        Rectf m_Rect_ = Rectf.Read(reader);
        Vector2f m_Offset_ = Vector2f.Read(reader);
        Vector4f m_Border_ = Vector4f.Read(reader);
        float m_PixelsToUnits_ = reader.ReadF32();
        Vector2f m_Pivot_ = Vector2f.Read(reader);
        uint m_Extrude_ = reader.ReadU32();
        bool m_IsPolygon_ = reader.ReadBool();
        reader.AlignTo(4); /* m_IsPolygon */
        pair_1 m_RenderDataKey_ = pair_1.Read(reader);
        AsciiString[] m_AtlasTags_ = BuiltInArray<AsciiString>.Read(reader);
        reader.AlignTo(4); /* m_AtlasTags */
        PPtr<SpriteAtlas> m_SpriteAtlas_ = PPtr<SpriteAtlas>.Read(reader);
        reader.AlignTo(4); /* m_SpriteAtlas */
        SpriteRenderData m_RD_ = SpriteRenderData.Read(reader);
        reader.AlignTo(4); /* m_RD */
        Vector2f[][] m_PhysicsShape_ = BuiltInArray<Vector2f[]>.Read(reader);
        reader.AlignTo(4); /* m_PhysicsShape */
        SpriteBone[] m_Bones_ = BuiltInArray<SpriteBone>.Read(reader);
        reader.AlignTo(4); /* m_Bones */
        
        return new(m_Name_,
            m_Rect_,
            m_Offset_,
            m_Border_,
            m_PixelsToUnits_,
            m_Pivot_,
            m_Extrude_,
            m_IsPolygon_,
            m_RenderDataKey_,
            m_AtlasTags_,
            m_SpriteAtlas_,
            m_RD_,
            m_PhysicsShape_,
            m_Bones_);
    }

    public override string ToString() => $"Sprite\n{ToString(4)}";

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
        sb.Append($"{indent_}m_Rect: {{ x: {m_Rect.x}, y: {m_Rect.y}, width: {m_Rect.width}, height: {m_Rect.height} }}\n");
    }

    public void ToString_Field2(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_Offset: {{ x: {m_Offset.x}, y: {m_Offset.y} }}\n");
    }

    public void ToString_Field3(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_Border: {{ x: {m_Border.x}, y: {m_Border.y}, z: {m_Border.z}, w: {m_Border.w} }}\n");
    }

    public void ToString_Field4(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_PixelsToUnits: {m_PixelsToUnits}");
    }

    public void ToString_Field5(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_Pivot: {{ x: {m_Pivot.x}, y: {m_Pivot.y} }}\n");
    }

    public void ToString_Field6(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_Extrude: {m_Extrude}");
    }

    public void ToString_Field7(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_IsPolygon: {m_IsPolygon}");
    }

    public void ToString_Field8(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_RenderDataKey: {{ \n{m_RenderDataKey.ToString(indent+4)}{indent_}}}\n");
    }

    public void ToString_Field9(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_AtlasTags[{m_AtlasTags.Length}] = {{");
        if (m_AtlasTags.Length > 0) sb.AppendLine();
        int _4i = 0;
        foreach (AsciiString _4 in m_AtlasTags)
        {
            sb.AppendLine($"{indent_ + ' '.Repeat(4)}[{_4i}] = \"{_4}\"");
            ++_4i;
        }
        if (m_AtlasTags.Length > 0) sb.Append(indent_);
        sb.AppendLine("}");
    }

    public void ToString_Field10(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_SpriteAtlas: {m_SpriteAtlas}");
    }

    public void ToString_Field11(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_RD: {{ \n{m_RD.ToString(indent+4)}{indent_}}}\n");
    }

    public void ToString_Field12(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_PhysicsShape[{m_PhysicsShape.Length}] = {{");
        if (m_PhysicsShape.Length > 0) sb.AppendLine();
        int _4i = 0;
        foreach (Vector2f[] _4 in m_PhysicsShape)
        {
            sb.Append($"{indent_ + ' '.Repeat(4)}[{_4i}] = [{_4.Length}] = {{");
            if (_4.Length > 0) sb.AppendLine();
            int _8i = 0;
            foreach (Vector2f _8 in _4)
            {
                sb.Append($"{indent_ + ' '.Repeat(8)}[{_8i}] = {{ x: {_8.x}, y: {_8.y} }}\n");
                ++_8i;
            }
            if (_4.Length > 0) sb.Append(indent_ + ' '.Repeat(4));
            sb.AppendLine("}");
            ++_4i;
        }
        if (m_PhysicsShape.Length > 0) sb.Append(indent_);
        sb.AppendLine("}");
    }

    public void ToString_Field13(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_Bones[{m_Bones.Length}] = {{");
        if (m_Bones.Length > 0) sb.AppendLine();
        int _4i = 0;
        foreach (SpriteBone _4 in m_Bones)
        {
            sb.Append($"{indent_ + ' '.Repeat(4)}[{_4i}] = {{ \n{_4.ToString(indent+8)}{indent_ + ' '.Repeat(4)}}}\n");
            ++_4i;
        }
        if (m_Bones.Length > 0) sb.Append(indent_);
        sb.AppendLine("}");
    }
}


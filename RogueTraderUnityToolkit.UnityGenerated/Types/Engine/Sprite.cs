namespace RogueTraderUnityToolkit.UnityGenerated.Types.Engine;

using Core;
using System.Text;
using Unity;

/* $Sprite (14 fields) DAA9127037D56E771320E274D2BB5D56 */
public record class Sprite(
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
    public static Hash128 Hash => new(3668513392, 936734327, 320922228, 3535494486);

    public static Sprite Read(EndianBinaryReader reader)
    {
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_Name */
        Rectf _m_Rect = Rectf.Read(reader);
        Vector2f _m_Offset = Vector2f.Read(reader);
        Vector4f _m_Border = Vector4f.Read(reader);
        float _m_PixelsToUnits = reader.ReadF32();
        Vector2f _m_Pivot = Vector2f.Read(reader);
        uint _m_Extrude = reader.ReadU32();
        bool _m_IsPolygon = reader.ReadBool();
        reader.AlignTo(4); /* m_IsPolygon */
        pair_1 _m_RenderDataKey = pair_1.Read(reader);
        AsciiString[] _m_AtlasTags = BuiltInArray<AsciiString>.Read(reader);
        reader.AlignTo(4); /* m_AtlasTags */
        PPtr<SpriteAtlas> _m_SpriteAtlas = PPtr<SpriteAtlas>.Read(reader);
        reader.AlignTo(4); /* m_SpriteAtlas */
        SpriteRenderData _m_RD = SpriteRenderData.Read(reader);
        reader.AlignTo(4); /* m_RD */
        Vector2f[][] _m_PhysicsShape = BuiltInArray<Vector2f[]>.Read(reader);
        reader.AlignTo(4); /* m_PhysicsShape */
        SpriteBone[] _m_Bones = BuiltInArray<SpriteBone>.Read(reader);
        reader.AlignTo(4); /* m_Bones */
        
        return new(_m_Name,
            _m_Rect,
            _m_Offset,
            _m_Border,
            _m_PixelsToUnits,
            _m_Pivot,
            _m_Extrude,
            _m_IsPolygon,
            _m_RenderDataKey,
            _m_AtlasTags,
            _m_SpriteAtlas,
            _m_RD,
            _m_PhysicsShape,
            _m_Bones);
    }

    public override string ToString() => $"Sprite\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Name: ");
        sb.AppendLine(m_Name.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Rect: ");
        sb.AppendLine();
        sb.Append(m_Rect.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Offset: ");
        sb.AppendLine();
        sb.Append(m_Offset.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Border: ");
        sb.AppendLine();
        sb.Append(m_Border.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_PixelsToUnits: ");
        sb.AppendLine(m_PixelsToUnits.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Pivot: ");
        sb.AppendLine();
        sb.Append(m_Pivot.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Extrude: ");
        sb.AppendLine(m_Extrude.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_IsPolygon: ");
        sb.AppendLine(m_IsPolygon.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_RenderDataKey: ");
        sb.AppendLine();
        sb.Append(m_RenderDataKey.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_AtlasTags: ");
        sb.AppendLine(m_AtlasTags.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_SpriteAtlas: ");
        sb.AppendLine(m_SpriteAtlas.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_RD: ");
        sb.AppendLine();
        sb.Append(m_RD.ToString(indent+4));

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_PhysicsShape: ");
        sb.AppendLine(m_PhysicsShape.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Bones: ");
        sb.AppendLine(m_Bones.ToString());

        return sb.ToString();
    }
}


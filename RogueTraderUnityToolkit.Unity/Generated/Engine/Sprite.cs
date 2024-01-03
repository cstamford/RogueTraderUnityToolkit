namespace RogueTraderUnityToolkit.Unity.Generated.Engine;

using Core;

/* $Sprite (14 fields) (IsEngineType) */
public record class Sprite(
    AsciiString m_Name,
    Rectf m_Rect,
    Vector2f m_Offset,
    Vector4f m_Border,
    float m_PixelsToUnits,
    Vector2f m_Pivot,
    uint m_Extrude,
    bool m_IsPolygon,
    pair m_RenderDataKey,
    AsciiString[] m_AtlasTags,
    PPtr<SpriteAtlas> m_SpriteAtlas,
    SpriteRenderData m_RD,
    Vector2f[][] m_PhysicsShape,
    SpriteBone[] m_Bones)
{
    public static Sprite Read(EndianBinaryReader reader)
    {
        AsciiString m_Name = String.Read(reader);
        Rectf m_Rect = Rectf.Read(reader);
        Vector2f m_Offset = Vector2f.Read(reader);
        Vector4f m_Border = Vector4f.Read(reader);
        float m_PixelsToUnits = reader.ReadF32();
        Vector2f m_Pivot = Vector2f.Read(reader);
        uint m_Extrude = reader.ReadU32();
        bool m_IsPolygon = reader.ReadBool();
        pair m_RenderDataKey = pair.Read(reader);
        AsciiString[] m_AtlasTags = Array<AsciiString>.Read(reader);
        PPtr<SpriteAtlas> m_SpriteAtlas = PPtr<SpriteAtlas>.Read(reader);
        SpriteRenderData m_RD = SpriteRenderData.Read(reader);
        Vector2f[][] m_PhysicsShape = Array<Vector2f[]>.Read(reader);
        SpriteBone[] m_Bones = Array<SpriteBone>.Read(reader);
        
        return new(m_Name,
            m_Rect,
            m_Offset,
            m_Border,
            m_PixelsToUnits,
            m_Pivot,
            m_Extrude,
            m_IsPolygon,
            m_RenderDataKey,
            m_AtlasTags,
            m_SpriteAtlas,
            m_RD,
            m_PhysicsShape,
            m_Bones);
    }
}


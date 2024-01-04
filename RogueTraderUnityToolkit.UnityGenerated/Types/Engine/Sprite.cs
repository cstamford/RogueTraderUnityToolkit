namespace RogueTraderUnityToolkit.UnityGenerated.Types.Engine;

using Core;
using Unity;

/* $Sprite (14 fields) DAA9127037D56E771320E274D2BB5D56 */
public record class Sprite(
    AsciiString m_Name /* None */,
    Rectf m_Rect /* NeedsAlign */,
    Vector2f m_Offset /* None */,
    Vector4f m_Border /* None */,
    float m_PixelsToUnits /* None */,
    Vector2f m_Pivot /* None */,
    uint m_Extrude /* None */,
    bool m_IsPolygon /* None */,
    pair m_RenderDataKey /* NeedsAlign */,
    AsciiString[] m_AtlasTags /* None */,
    PPtr<SpriteAtlas> m_SpriteAtlas /* NeedsAlign */,
    SpriteRenderData m_RD /* NeedsAlign */,
    Vector2f[][] m_PhysicsShape /* NeedsAlign */,
    SpriteBone[] m_Bones /* NeedsAlign */) : IUnityObject
{
    public static Hash128 Hash => new(3668513392, 936734327, 320922228, 3535494486);
    public static Sprite Read(EndianBinaryReader reader)
    {
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_Rect */
        Rectf _m_Rect = Rectf.Read(reader);
        Vector2f _m_Offset = Vector2f.Read(reader);
        Vector4f _m_Border = Vector4f.Read(reader);
        float _m_PixelsToUnits = reader.ReadF32();
        Vector2f _m_Pivot = Vector2f.Read(reader);
        uint _m_Extrude = reader.ReadU32();
        bool _m_IsPolygon = reader.ReadBool();
        reader.AlignTo(4); /* m_RenderDataKey */
        pair _m_RenderDataKey = pair.Read(reader);
        AsciiString[] _m_AtlasTags = BuiltInArray<AsciiString>.Read(reader);
        reader.AlignTo(4); /* m_SpriteAtlas */
        PPtr<SpriteAtlas> _m_SpriteAtlas = PPtr<SpriteAtlas>.Read(reader);
        reader.AlignTo(4); /* m_RD */
        SpriteRenderData _m_RD = SpriteRenderData.Read(reader);
        reader.AlignTo(4); /* m_PhysicsShape */
        Vector2f[][] _m_PhysicsShape = BuiltInArray<Vector2f[]>.Read(reader);
        reader.AlignTo(4); /* m_Bones */
        SpriteBone[] _m_Bones = BuiltInArray<SpriteBone>.Read(reader);
        
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
}


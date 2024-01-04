namespace RogueTraderUnityToolkit.UnityGenerated.Types.Engine;

using Core;
using Unity;

/* $SpriteAtlas (6 fields) 579CE7CAA3B38BC5A7A3C131EFCFF98F */
public record class SpriteAtlas(
    AsciiString m_Name /* None */,
    PPtr<Sprite>[] m_PackedSprites /* NeedsAlign */,
    AsciiString[] m_PackedSpriteNamesToIndex /* NeedsAlign */,
    Dictionary<pair, SpriteAtlasData> m_RenderDataMap /* NeedsAlign */,
    AsciiString m_Tag /* NeedsAlign */,
    bool m_IsVariant /* NeedsAlign */) : IUnityObject
{
    public static Hash128 Hash => new(1469900746, 2746452933, 2812526897, 4023384463);
    public static SpriteAtlas Read(EndianBinaryReader reader)
    {
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_PackedSprites */
        PPtr<Sprite>[] _m_PackedSprites = BuiltInArray<PPtr<Sprite>>.Read(reader);
        reader.AlignTo(4); /* m_PackedSpriteNamesToIndex */
        AsciiString[] _m_PackedSpriteNamesToIndex = BuiltInArray<AsciiString>.Read(reader);
        reader.AlignTo(4); /* m_RenderDataMap */
        Dictionary<pair, SpriteAtlasData> _m_RenderDataMap = BuiltInMap<pair, SpriteAtlasData>.Read(reader);
        reader.AlignTo(4); /* m_Tag */
        AsciiString _m_Tag = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_IsVariant */
        bool _m_IsVariant = reader.ReadBool();
        
        return new(_m_Name,
            _m_PackedSprites,
            _m_PackedSpriteNamesToIndex,
            _m_RenderDataMap,
            _m_Tag,
            _m_IsVariant);
    }
}


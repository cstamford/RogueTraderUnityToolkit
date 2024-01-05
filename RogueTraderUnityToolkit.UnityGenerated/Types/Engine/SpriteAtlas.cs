namespace RogueTraderUnityToolkit.UnityGenerated.Types.Engine;

using Core;
using System.Text;
using Unity;

/* $SpriteAtlas (6 fields) 579CE7CAA3B38BC5A7A3C131EFCFF98F */
public record class SpriteAtlas(
    AsciiString m_Name,
    PPtr<Sprite>[] m_PackedSprites,
    AsciiString[] m_PackedSpriteNamesToIndex,
    Dictionary<pair_1, SpriteAtlasData> m_RenderDataMap,
    AsciiString m_Tag,
    bool m_IsVariant) : IUnityEngineStructure
{
    public static Hash128 Hash => new(1469900746, 2746452933, 2812526897, 4023384463);

    public static SpriteAtlas Read(EndianBinaryReader reader)
    {
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_Name */
        PPtr<Sprite>[] _m_PackedSprites = BuiltInArray<PPtr<Sprite>>.Read(reader);
        reader.AlignTo(4); /* m_PackedSprites */
        AsciiString[] _m_PackedSpriteNamesToIndex = BuiltInArray<AsciiString>.Read(reader);
        reader.AlignTo(4); /* m_PackedSpriteNamesToIndex */
        Dictionary<pair_1, SpriteAtlasData> _m_RenderDataMap = BuiltInMap<pair_1, SpriteAtlasData>.Read(reader);
        reader.AlignTo(4); /* m_RenderDataMap */
        AsciiString _m_Tag = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_Tag */
        bool _m_IsVariant = reader.ReadBool();
        reader.AlignTo(4); /* m_IsVariant */
        
        return new(_m_Name,
            _m_PackedSprites,
            _m_PackedSpriteNamesToIndex,
            _m_RenderDataMap,
            _m_Tag,
            _m_IsVariant);
    }

    public override string ToString() => $"SpriteAtlas\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Name: ");
        sb.AppendLine(m_Name.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_PackedSprites: ");
        sb.AppendLine(m_PackedSprites.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_PackedSpriteNamesToIndex: ");
        sb.AppendLine(m_PackedSpriteNamesToIndex.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_RenderDataMap: ");
        sb.AppendLine(m_RenderDataMap.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_Tag: ");
        sb.AppendLine(m_Tag.ToString());

        for (int i = 0; i < indent; ++i) sb.Append(' ');
        sb.Append("m_IsVariant: ");
        sb.AppendLine(m_IsVariant.ToString());

        return sb.ToString();
    }
}


namespace RogueTraderUnityToolkit.UnityStructures.Generated.Engine;

using Core;
using Unity.BuiltInTypes;

/* $SpriteAtlas (6 fields) (IsEngineType) */
public record class SpriteAtlas(
    AsciiString m_Name,
    PPtr<Sprite>[] m_PackedSprites,
    AsciiString[] m_PackedSpriteNamesToIndex,
    Dictionary<pair, SpriteAtlasData> m_RenderDataMap,
    AsciiString m_Tag,
    bool m_IsVariant)
{
    public static SpriteAtlas Read(EndianBinaryReader reader)
    {
        AsciiString m_Name = String.Read(reader);
        PPtr<Sprite>[] m_PackedSprites = Array<PPtr<Sprite>>.Read(reader);
        AsciiString[] m_PackedSpriteNamesToIndex = Array<AsciiString>.Read(reader);
        Dictionary<pair, SpriteAtlasData> m_RenderDataMap = Map<pair, SpriteAtlasData>.Read(reader);
        AsciiString m_Tag = String.Read(reader);
        bool m_IsVariant = reader.ReadBool();
        
        return new(m_Name,
            m_PackedSprites,
            m_PackedSpriteNamesToIndex,
            m_RenderDataMap,
            m_Tag,
            m_IsVariant);
    }
}


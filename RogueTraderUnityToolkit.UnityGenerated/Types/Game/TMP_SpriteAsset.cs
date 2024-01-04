namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $TMP_SpriteAsset (14 fields) 1669C5FCD99B8D2AC9E834DF1242E8DE/48A727B60815961785697C35770F7087 */
public record class TMP_SpriteAsset(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    int hashCode /* NeedsAlign */,
    PPtr<Material> material /* None */,
    int materialHashCode /* None */,
    AsciiString m_Version /* None */,
    FaceInfo m_FaceInfo /* NeedsAlign */,
    PPtr<Texture> spriteSheet /* NeedsAlign */,
    TMP_SpriteCharacter[] m_SpriteCharacterTable /* None */,
    TMP_SpriteGlyph[] m_SpriteGlyphTable /* NeedsAlign */,
    TMP_Sprite[] spriteInfoList /* None */,
    PPtr<TMP_SpriteAsset>[] fallbackSpriteAssets /* NeedsAlign */)
{
    public static TMP_SpriteAsset Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* hashCode */
        int _hashCode = reader.ReadS32();
        PPtr<Material> _material = PPtr<Material>.Read(reader);
        int _materialHashCode = reader.ReadS32();
        AsciiString _m_Version = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_FaceInfo */
        FaceInfo _m_FaceInfo = FaceInfo.Read(reader);
        reader.AlignTo(4); /* spriteSheet */
        PPtr<Texture> _spriteSheet = PPtr<Texture>.Read(reader);
        TMP_SpriteCharacter[] _m_SpriteCharacterTable = BuiltInArray<TMP_SpriteCharacter>.Read(reader);
        reader.AlignTo(4); /* m_SpriteGlyphTable */
        TMP_SpriteGlyph[] _m_SpriteGlyphTable = BuiltInArray<TMP_SpriteGlyph>.Read(reader);
        TMP_Sprite[] _spriteInfoList = BuiltInArray<TMP_Sprite>.Read(reader);
        reader.AlignTo(4); /* fallbackSpriteAssets */
        PPtr<TMP_SpriteAsset>[] _fallbackSpriteAssets = BuiltInArray<PPtr<TMP_SpriteAsset>>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _hashCode,
            _material,
            _materialHashCode,
            _m_Version,
            _m_FaceInfo,
            _spriteSheet,
            _m_SpriteCharacterTable,
            _m_SpriteGlyphTable,
            _spriteInfoList,
            _fallbackSpriteAssets);
    }
}


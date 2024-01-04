namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $TMP_FontAsset (40 fields) F2834A1BDEA4F1A292DC2CF12CE7CC23/968FA1952D1D20F4CAD9DE26ADD22321 */
public record class TMP_FontAsset(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    int hashCode /* NeedsAlign */,
    PPtr<Material> material /* None */,
    int materialHashCode /* None */,
    AsciiString m_Version /* None */,
    AsciiString m_SourceFontFileGUID /* NeedsAlign */,
    PPtr<Font> m_SourceFontFile /* NeedsAlign */,
    int m_AtlasPopulationMode /* None */,
    FaceInfo m_FaceInfo /* None */,
    Glyph[] m_GlyphTable /* NeedsAlign */,
    TMP_Character[] m_CharacterTable /* None */,
    PPtr<Texture2D>[] m_AtlasTextures /* NeedsAlign */,
    int m_AtlasTextureIndex /* None */,
    byte m_IsMultiAtlasTexturesEnabled /* None */,
    byte m_ClearDynamicDataOnBuild /* NeedsAlign */,
    GlyphRect m_UsedGlyphRects /* NeedsAlign */,
    GlyphRect m_FreeGlyphRects /* None */,
    FaceInfo_Legacy m_fontInfo /* None */,
    PPtr<Texture2D> atlas /* NeedsAlign */,
    int m_AtlasWidth /* None */,
    int m_AtlasHeight /* None */,
    int m_AtlasPadding /* None */,
    int m_AtlasRenderMode /* None */,
    TMP_Glyph[] m_glyphInfoList /* None */,
    KerningTable m_KerningTable /* None */,
    TMP_FontFeatureTable m_FontFeatureTable /* NeedsAlign */,
    PPtr<TMP_FontAsset>[] fallbackFontAssets /* None */,
    PPtr<TMP_FontAsset>[] m_FallbackFontAssetTable /* None */,
    FontAssetCreationSettings m_CreationSettings /* None */,
    TMP_FontWeightPair[] m_FontWeightTable /* NeedsAlign */,
    TMP_FontWeightPair fontWeights /* None */,
    float normalStyle /* None */,
    float normalSpacingOffset /* None */,
    float boldStyle /* None */,
    float boldSpacing /* None */,
    byte italicStyle /* None */,
    byte tabSize /* NeedsAlign */)
{
    public static TMP_FontAsset Read(EndianBinaryReader reader)
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
        reader.AlignTo(4); /* m_SourceFontFileGUID */
        AsciiString _m_SourceFontFileGUID = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_SourceFontFile */
        PPtr<Font> _m_SourceFontFile = PPtr<Font>.Read(reader);
        int _m_AtlasPopulationMode = reader.ReadS32();
        FaceInfo _m_FaceInfo = FaceInfo.Read(reader);
        reader.AlignTo(4); /* m_GlyphTable */
        Glyph[] _m_GlyphTable = BuiltInArray<Glyph>.Read(reader);
        TMP_Character[] _m_CharacterTable = BuiltInArray<TMP_Character>.Read(reader);
        reader.AlignTo(4); /* m_AtlasTextures */
        PPtr<Texture2D>[] _m_AtlasTextures = BuiltInArray<PPtr<Texture2D>>.Read(reader);
        int _m_AtlasTextureIndex = reader.ReadS32();
        byte _m_IsMultiAtlasTexturesEnabled = reader.ReadU8();
        reader.AlignTo(4); /* m_ClearDynamicDataOnBuild */
        byte _m_ClearDynamicDataOnBuild = reader.ReadU8();
        reader.AlignTo(4); /* m_UsedGlyphRects */
        GlyphRect _m_UsedGlyphRects = GlyphRect.Read(reader);
        GlyphRect _m_FreeGlyphRects = GlyphRect.Read(reader);
        FaceInfo_Legacy _m_fontInfo = FaceInfo_Legacy.Read(reader);
        reader.AlignTo(4); /* atlas */
        PPtr<Texture2D> _atlas = PPtr<Texture2D>.Read(reader);
        int _m_AtlasWidth = reader.ReadS32();
        int _m_AtlasHeight = reader.ReadS32();
        int _m_AtlasPadding = reader.ReadS32();
        int _m_AtlasRenderMode = reader.ReadS32();
        TMP_Glyph[] _m_glyphInfoList = BuiltInArray<TMP_Glyph>.Read(reader);
        KerningTable _m_KerningTable = KerningTable.Read(reader);
        reader.AlignTo(4); /* m_FontFeatureTable */
        TMP_FontFeatureTable _m_FontFeatureTable = TMP_FontFeatureTable.Read(reader);
        PPtr<TMP_FontAsset>[] _fallbackFontAssets = BuiltInArray<PPtr<TMP_FontAsset>>.Read(reader);
        PPtr<TMP_FontAsset>[] _m_FallbackFontAssetTable = BuiltInArray<PPtr<TMP_FontAsset>>.Read(reader);
        FontAssetCreationSettings _m_CreationSettings = FontAssetCreationSettings.Read(reader);
        reader.AlignTo(4); /* m_FontWeightTable */
        TMP_FontWeightPair[] _m_FontWeightTable = BuiltInArray<TMP_FontWeightPair>.Read(reader);
        TMP_FontWeightPair _fontWeights = TMP_FontWeightPair.Read(reader);
        float _normalStyle = reader.ReadF32();
        float _normalSpacingOffset = reader.ReadF32();
        float _boldStyle = reader.ReadF32();
        float _boldSpacing = reader.ReadF32();
        byte _italicStyle = reader.ReadU8();
        reader.AlignTo(4); /* tabSize */
        byte _tabSize = reader.ReadU8();
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _hashCode,
            _material,
            _materialHashCode,
            _m_Version,
            _m_SourceFontFileGUID,
            _m_SourceFontFile,
            _m_AtlasPopulationMode,
            _m_FaceInfo,
            _m_GlyphTable,
            _m_CharacterTable,
            _m_AtlasTextures,
            _m_AtlasTextureIndex,
            _m_IsMultiAtlasTexturesEnabled,
            _m_ClearDynamicDataOnBuild,
            _m_UsedGlyphRects,
            _m_FreeGlyphRects,
            _m_fontInfo,
            _atlas,
            _m_AtlasWidth,
            _m_AtlasHeight,
            _m_AtlasPadding,
            _m_AtlasRenderMode,
            _m_glyphInfoList,
            _m_KerningTable,
            _m_FontFeatureTable,
            _fallbackFontAssets,
            _m_FallbackFontAssetTable,
            _m_CreationSettings,
            _m_FontWeightTable,
            _fontWeights,
            _normalStyle,
            _normalSpacingOffset,
            _boldStyle,
            _boldSpacing,
            _italicStyle,
            _tabSize);
    }
}


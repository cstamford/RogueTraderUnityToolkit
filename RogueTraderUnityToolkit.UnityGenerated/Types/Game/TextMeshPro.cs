namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $TextMeshPro (74 fields) D68472745BC4F692ED5549AE4CD05E65/8C07B8AD8EF81521B920F7B1C04DD3DD */
public record class TextMeshPro(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<Material> m_Material /* NeedsAlign */,
    ColorRGBA m_Color /* None */,
    byte m_RaycastTarget /* None */,
    Vector4f m_RaycastPadding /* NeedsAlign */,
    byte m_Maskable /* None */,
    CullStateChangedEvent m_OnCullStateChanged /* NeedsAlign */,
    AsciiString m_text /* NeedsAlign */,
    byte m_isRightToLeft /* NeedsAlign */,
    PPtr<TMP_FontAsset> m_fontAsset /* NeedsAlign */,
    PPtr<Material> m_sharedMaterial /* None */,
    PPtr<Material>[] m_fontSharedMaterials /* None */,
    PPtr<Material> m_fontMaterial /* None */,
    PPtr<Material>[] m_fontMaterials /* None */,
    ColorRGBA m_fontColor32 /* None */,
    ColorRGBA m_fontColor /* None */,
    byte m_enableVertexGradient /* None */,
    int m_colorMode /* NeedsAlign */,
    VertexGradient m_fontColorGradient /* None */,
    PPtr<TMP_ColorGradient> m_fontColorGradientPreset /* None */,
    PPtr<TMP_SpriteAsset> m_spriteAsset /* None */,
    byte m_tintAllSprites /* None */,
    PPtr<TMP_StyleSheet> m_StyleSheet /* NeedsAlign */,
    int m_TextStyleHashCode /* None */,
    byte m_overrideHtmlColors /* None */,
    ColorRGBA m_faceColor /* NeedsAlign */,
    float m_fontSize /* None */,
    float m_fontSizeBase /* None */,
    int m_fontWeight /* None */,
    byte m_enableAutoSizing /* None */,
    float m_fontSizeMin /* NeedsAlign */,
    float m_fontSizeMax /* None */,
    int m_fontStyle /* None */,
    int m_HorizontalAlignment /* None */,
    int m_VerticalAlignment /* None */,
    int m_textAlignment /* None */,
    float m_characterSpacing /* None */,
    float m_wordSpacing /* None */,
    float m_lineSpacing /* None */,
    float m_lineSpacingMax /* None */,
    float m_paragraphSpacing /* None */,
    float m_charWidthMaxAdj /* None */,
    byte m_enableWordWrapping /* None */,
    float m_wordWrappingRatios /* NeedsAlign */,
    int m_overflowMode /* None */,
    PPtr<TMP_Text> m_linkedTextComponent /* None */,
    PPtr<TMP_Text> parentLinkedComponent /* None */,
    byte m_enableKerning /* None */,
    byte m_enableExtraPadding /* NeedsAlign */,
    byte checkPaddingRequired /* NeedsAlign */,
    byte m_isRichText /* NeedsAlign */,
    byte m_parseCtrlCharacters /* NeedsAlign */,
    byte m_isOrthographic /* NeedsAlign */,
    byte m_isCullingEnabled /* NeedsAlign */,
    int m_horizontalMapping /* NeedsAlign */,
    int m_verticalMapping /* None */,
    float m_uvLineOffset /* None */,
    int m_geometrySortingOrder /* None */,
    byte m_IsTextObjectScaleStatic /* None */,
    byte m_VertexBufferAutoSizeReduction /* NeedsAlign */,
    byte m_useMaxVisibleDescender /* NeedsAlign */,
    int m_pageToDisplay /* NeedsAlign */,
    Vector4f m_margin /* None */,
    byte m_isUsingLegacyAnimationComponent /* None */,
    byte m_isVolumetricText /* NeedsAlign */,
    int _SortingLayer /* NeedsAlign */,
    int _SortingLayerID /* None */,
    int _SortingOrder /* None */,
    byte m_hasFontAssetChanged /* None */,
    PPtr<Renderer> m_renderer /* NeedsAlign */,
    int m_maskType /* None */)
{
    public static TextMeshPro Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_Material */
        PPtr<Material> _m_Material = PPtr<Material>.Read(reader);
        ColorRGBA _m_Color = ColorRGBA.Read(reader);
        byte _m_RaycastTarget = reader.ReadU8();
        reader.AlignTo(4); /* m_RaycastPadding */
        Vector4f _m_RaycastPadding = Vector4f.Read(reader);
        byte _m_Maskable = reader.ReadU8();
        reader.AlignTo(4); /* m_OnCullStateChanged */
        CullStateChangedEvent _m_OnCullStateChanged = CullStateChangedEvent.Read(reader);
        reader.AlignTo(4); /* m_text */
        AsciiString _m_text = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_isRightToLeft */
        byte _m_isRightToLeft = reader.ReadU8();
        reader.AlignTo(4); /* m_fontAsset */
        PPtr<TMP_FontAsset> _m_fontAsset = PPtr<TMP_FontAsset>.Read(reader);
        PPtr<Material> _m_sharedMaterial = PPtr<Material>.Read(reader);
        PPtr<Material>[] _m_fontSharedMaterials = BuiltInArray<PPtr<Material>>.Read(reader);
        PPtr<Material> _m_fontMaterial = PPtr<Material>.Read(reader);
        PPtr<Material>[] _m_fontMaterials = BuiltInArray<PPtr<Material>>.Read(reader);
        ColorRGBA _m_fontColor32 = ColorRGBA.Read(reader);
        ColorRGBA _m_fontColor = ColorRGBA.Read(reader);
        byte _m_enableVertexGradient = reader.ReadU8();
        reader.AlignTo(4); /* m_colorMode */
        int _m_colorMode = reader.ReadS32();
        VertexGradient _m_fontColorGradient = VertexGradient.Read(reader);
        PPtr<TMP_ColorGradient> _m_fontColorGradientPreset = PPtr<TMP_ColorGradient>.Read(reader);
        PPtr<TMP_SpriteAsset> _m_spriteAsset = PPtr<TMP_SpriteAsset>.Read(reader);
        byte _m_tintAllSprites = reader.ReadU8();
        reader.AlignTo(4); /* m_StyleSheet */
        PPtr<TMP_StyleSheet> _m_StyleSheet = PPtr<TMP_StyleSheet>.Read(reader);
        int _m_TextStyleHashCode = reader.ReadS32();
        byte _m_overrideHtmlColors = reader.ReadU8();
        reader.AlignTo(4); /* m_faceColor */
        ColorRGBA _m_faceColor = ColorRGBA.Read(reader);
        float _m_fontSize = reader.ReadF32();
        float _m_fontSizeBase = reader.ReadF32();
        int _m_fontWeight = reader.ReadS32();
        byte _m_enableAutoSizing = reader.ReadU8();
        reader.AlignTo(4); /* m_fontSizeMin */
        float _m_fontSizeMin = reader.ReadF32();
        float _m_fontSizeMax = reader.ReadF32();
        int _m_fontStyle = reader.ReadS32();
        int _m_HorizontalAlignment = reader.ReadS32();
        int _m_VerticalAlignment = reader.ReadS32();
        int _m_textAlignment = reader.ReadS32();
        float _m_characterSpacing = reader.ReadF32();
        float _m_wordSpacing = reader.ReadF32();
        float _m_lineSpacing = reader.ReadF32();
        float _m_lineSpacingMax = reader.ReadF32();
        float _m_paragraphSpacing = reader.ReadF32();
        float _m_charWidthMaxAdj = reader.ReadF32();
        byte _m_enableWordWrapping = reader.ReadU8();
        reader.AlignTo(4); /* m_wordWrappingRatios */
        float _m_wordWrappingRatios = reader.ReadF32();
        int _m_overflowMode = reader.ReadS32();
        PPtr<TMP_Text> _m_linkedTextComponent = PPtr<TMP_Text>.Read(reader);
        PPtr<TMP_Text> _parentLinkedComponent = PPtr<TMP_Text>.Read(reader);
        byte _m_enableKerning = reader.ReadU8();
        reader.AlignTo(4); /* m_enableExtraPadding */
        byte _m_enableExtraPadding = reader.ReadU8();
        reader.AlignTo(4); /* checkPaddingRequired */
        byte _checkPaddingRequired = reader.ReadU8();
        reader.AlignTo(4); /* m_isRichText */
        byte _m_isRichText = reader.ReadU8();
        reader.AlignTo(4); /* m_parseCtrlCharacters */
        byte _m_parseCtrlCharacters = reader.ReadU8();
        reader.AlignTo(4); /* m_isOrthographic */
        byte _m_isOrthographic = reader.ReadU8();
        reader.AlignTo(4); /* m_isCullingEnabled */
        byte _m_isCullingEnabled = reader.ReadU8();
        reader.AlignTo(4); /* m_horizontalMapping */
        int _m_horizontalMapping = reader.ReadS32();
        int _m_verticalMapping = reader.ReadS32();
        float _m_uvLineOffset = reader.ReadF32();
        int _m_geometrySortingOrder = reader.ReadS32();
        byte _m_IsTextObjectScaleStatic = reader.ReadU8();
        reader.AlignTo(4); /* m_VertexBufferAutoSizeReduction */
        byte _m_VertexBufferAutoSizeReduction = reader.ReadU8();
        reader.AlignTo(4); /* m_useMaxVisibleDescender */
        byte _m_useMaxVisibleDescender = reader.ReadU8();
        reader.AlignTo(4); /* m_pageToDisplay */
        int _m_pageToDisplay = reader.ReadS32();
        Vector4f _m_margin = Vector4f.Read(reader);
        byte _m_isUsingLegacyAnimationComponent = reader.ReadU8();
        reader.AlignTo(4); /* m_isVolumetricText */
        byte _m_isVolumetricText = reader.ReadU8();
        reader.AlignTo(4); /* _SortingLayer */
        int __SortingLayer = reader.ReadS32();
        int __SortingLayerID = reader.ReadS32();
        int __SortingOrder = reader.ReadS32();
        byte _m_hasFontAssetChanged = reader.ReadU8();
        reader.AlignTo(4); /* m_renderer */
        PPtr<Renderer> _m_renderer = PPtr<Renderer>.Read(reader);
        int _m_maskType = reader.ReadS32();
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_Material,
            _m_Color,
            _m_RaycastTarget,
            _m_RaycastPadding,
            _m_Maskable,
            _m_OnCullStateChanged,
            _m_text,
            _m_isRightToLeft,
            _m_fontAsset,
            _m_sharedMaterial,
            _m_fontSharedMaterials,
            _m_fontMaterial,
            _m_fontMaterials,
            _m_fontColor32,
            _m_fontColor,
            _m_enableVertexGradient,
            _m_colorMode,
            _m_fontColorGradient,
            _m_fontColorGradientPreset,
            _m_spriteAsset,
            _m_tintAllSprites,
            _m_StyleSheet,
            _m_TextStyleHashCode,
            _m_overrideHtmlColors,
            _m_faceColor,
            _m_fontSize,
            _m_fontSizeBase,
            _m_fontWeight,
            _m_enableAutoSizing,
            _m_fontSizeMin,
            _m_fontSizeMax,
            _m_fontStyle,
            _m_HorizontalAlignment,
            _m_VerticalAlignment,
            _m_textAlignment,
            _m_characterSpacing,
            _m_wordSpacing,
            _m_lineSpacing,
            _m_lineSpacingMax,
            _m_paragraphSpacing,
            _m_charWidthMaxAdj,
            _m_enableWordWrapping,
            _m_wordWrappingRatios,
            _m_overflowMode,
            _m_linkedTextComponent,
            _parentLinkedComponent,
            _m_enableKerning,
            _m_enableExtraPadding,
            _checkPaddingRequired,
            _m_isRichText,
            _m_parseCtrlCharacters,
            _m_isOrthographic,
            _m_isCullingEnabled,
            _m_horizontalMapping,
            _m_verticalMapping,
            _m_uvLineOffset,
            _m_geometrySortingOrder,
            _m_IsTextObjectScaleStatic,
            _m_VertexBufferAutoSizeReduction,
            _m_useMaxVisibleDescender,
            _m_pageToDisplay,
            _m_margin,
            _m_isUsingLegacyAnimationComponent,
            _m_isVolumetricText,
            __SortingLayer,
            __SortingLayerID,
            __SortingOrder,
            _m_hasFontAssetChanged,
            _m_renderer,
            _m_maskType);
    }
}


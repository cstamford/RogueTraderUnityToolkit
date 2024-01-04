namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $TMP_SubMeshUI (18 fields) 04A19862114EE91261AC85ADA1DDC948/BF1815696A40CB91FE1A488E1006A3D4 */
public record class TMP_SubMeshUI(
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
    PPtr<TMP_FontAsset> m_fontAsset /* NeedsAlign */,
    PPtr<TMP_SpriteAsset> m_spriteAsset /* None */,
    PPtr<Material> m_material /* None */,
    PPtr<Material> m_sharedMaterial /* None */,
    byte m_isDefaultMaterial /* None */,
    float m_padding /* NeedsAlign */,
    PPtr<TextMeshProUGUI> m_TextComponent /* None */,
    int m_materialReferenceIndex /* None */)
{
    public static TMP_SubMeshUI Read(EndianBinaryReader reader)
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
        reader.AlignTo(4); /* m_fontAsset */
        PPtr<TMP_FontAsset> _m_fontAsset = PPtr<TMP_FontAsset>.Read(reader);
        PPtr<TMP_SpriteAsset> _m_spriteAsset = PPtr<TMP_SpriteAsset>.Read(reader);
        PPtr<Material> _m_material = PPtr<Material>.Read(reader);
        PPtr<Material> _m_sharedMaterial = PPtr<Material>.Read(reader);
        byte _m_isDefaultMaterial = reader.ReadU8();
        reader.AlignTo(4); /* m_padding */
        float _m_padding = reader.ReadF32();
        PPtr<TextMeshProUGUI> _m_TextComponent = PPtr<TextMeshProUGUI>.Read(reader);
        int _m_materialReferenceIndex = reader.ReadS32();
        
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
            _m_fontAsset,
            _m_spriteAsset,
            _m_material,
            _m_sharedMaterial,
            _m_isDefaultMaterial,
            _m_padding,
            _m_TextComponent,
            _m_materialReferenceIndex);
    }
}


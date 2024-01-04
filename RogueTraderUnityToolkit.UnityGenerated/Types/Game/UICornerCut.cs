namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $UICornerCut (21 fields) 27FC64321EB20EA05D7B000BB403EFC8/30ACEB8ED4007F68BAD460CB067FEEFF */
public record class UICornerCut(
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
    PPtr<Sprite> m_Sprite /* NeedsAlign */,
    Vector2f cornerSize /* None */,
    byte cutUL /* None */,
    byte cutUR /* NeedsAlign */,
    byte cutLL /* NeedsAlign */,
    byte cutLR /* NeedsAlign */,
    byte makeColumns /* NeedsAlign */,
    byte useColorUp /* NeedsAlign */,
    ColorRGBA colorUp /* NeedsAlign */,
    byte useColorDown /* None */,
    ColorRGBA colorDown /* NeedsAlign */)
{
    public static UICornerCut Read(EndianBinaryReader reader)
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
        reader.AlignTo(4); /* m_Sprite */
        PPtr<Sprite> _m_Sprite = PPtr<Sprite>.Read(reader);
        Vector2f _cornerSize = Vector2f.Read(reader);
        byte _cutUL = reader.ReadU8();
        reader.AlignTo(4); /* cutUR */
        byte _cutUR = reader.ReadU8();
        reader.AlignTo(4); /* cutLL */
        byte _cutLL = reader.ReadU8();
        reader.AlignTo(4); /* cutLR */
        byte _cutLR = reader.ReadU8();
        reader.AlignTo(4); /* makeColumns */
        byte _makeColumns = reader.ReadU8();
        reader.AlignTo(4); /* useColorUp */
        byte _useColorUp = reader.ReadU8();
        reader.AlignTo(4); /* colorUp */
        ColorRGBA _colorUp = ColorRGBA.Read(reader);
        byte _useColorDown = reader.ReadU8();
        reader.AlignTo(4); /* colorDown */
        ColorRGBA _colorDown = ColorRGBA.Read(reader);
        
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
            _m_Sprite,
            _cornerSize,
            _cutUL,
            _cutUR,
            _cutLL,
            _cutLR,
            _makeColumns,
            _useColorUp,
            _colorUp,
            _useColorDown,
            _colorDown);
    }
}


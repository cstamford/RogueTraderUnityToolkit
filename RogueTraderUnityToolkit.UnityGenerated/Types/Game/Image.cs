namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $Image (20 fields) D2CBC816D6F9324AE0155662738009E9/3B0B757605D85C8871442D545CF439B7 */
public record class Image(
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
    int m_Type /* None */,
    byte m_PreserveAspect /* None */,
    byte m_FillCenter /* NeedsAlign */,
    int m_FillMethod /* NeedsAlign */,
    float m_FillAmount /* None */,
    byte m_FillClockwise /* None */,
    int m_FillOrigin /* NeedsAlign */,
    byte m_UseSpriteMesh /* None */,
    float m_PixelsPerUnitMultiplier /* NeedsAlign */)
{
    public static Image Read(EndianBinaryReader reader)
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
        int _m_Type = reader.ReadS32();
        byte _m_PreserveAspect = reader.ReadU8();
        reader.AlignTo(4); /* m_FillCenter */
        byte _m_FillCenter = reader.ReadU8();
        reader.AlignTo(4); /* m_FillMethod */
        int _m_FillMethod = reader.ReadS32();
        float _m_FillAmount = reader.ReadF32();
        byte _m_FillClockwise = reader.ReadU8();
        reader.AlignTo(4); /* m_FillOrigin */
        int _m_FillOrigin = reader.ReadS32();
        byte _m_UseSpriteMesh = reader.ReadU8();
        reader.AlignTo(4); /* m_PixelsPerUnitMultiplier */
        float _m_PixelsPerUnitMultiplier = reader.ReadF32();
        
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
            _m_Type,
            _m_PreserveAspect,
            _m_FillCenter,
            _m_FillMethod,
            _m_FillAmount,
            _m_FillClockwise,
            _m_FillOrigin,
            _m_UseSpriteMesh,
            _m_PixelsPerUnitMultiplier);
    }
}


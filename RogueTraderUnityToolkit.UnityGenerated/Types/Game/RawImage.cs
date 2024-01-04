namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $RawImage (12 fields) 40DD676F8CC1DF6D908A3F9B66625C72/A7B8FAF3C14EDA5022FE310F12396660 */
public record class RawImage(
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
    PPtr<Texture> m_Texture /* NeedsAlign */,
    Rectf m_UVRect /* None */)
{
    public static RawImage Read(EndianBinaryReader reader)
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
        reader.AlignTo(4); /* m_Texture */
        PPtr<Texture> _m_Texture = PPtr<Texture>.Read(reader);
        Rectf _m_UVRect = Rectf.Read(reader);
        
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
            _m_Texture,
            _m_UVRect);
    }
}


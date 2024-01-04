namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $ScreenSpaceCloudShadows (14 fields) 6BCB41F82636E9E6434F300E2F286422/38A1EAAD483F68D215DE096530E427C6 */
public record class ScreenSpaceCloudShadows(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    byte active /* NeedsAlign */,
    ClampedFloatParameter Intensity /* NeedsAlign */,
    TextureParameter Texture0 /* NeedsAlign */,
    Vector2Parameter Texture0Tiling /* NeedsAlign */,
    Vector2Parameter Texture0ScrollSpeed /* NeedsAlign */,
    ColorParameter Texture0Color /* NeedsAlign */,
    TextureParameter Texture1 /* NeedsAlign */,
    Vector2Parameter Texture1Tiling /* NeedsAlign */,
    Vector2Parameter Texture1ScrollSpeed /* NeedsAlign */,
    ColorParameter Texture1Color /* NeedsAlign */)
{
    public static ScreenSpaceCloudShadows Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* active */
        byte _active = reader.ReadU8();
        reader.AlignTo(4); /* Intensity */
        ClampedFloatParameter _Intensity = ClampedFloatParameter.Read(reader);
        reader.AlignTo(4); /* Texture0 */
        TextureParameter _Texture0 = TextureParameter.Read(reader);
        reader.AlignTo(4); /* Texture0Tiling */
        Vector2Parameter _Texture0Tiling = Vector2Parameter.Read(reader);
        reader.AlignTo(4); /* Texture0ScrollSpeed */
        Vector2Parameter _Texture0ScrollSpeed = Vector2Parameter.Read(reader);
        reader.AlignTo(4); /* Texture0Color */
        ColorParameter _Texture0Color = ColorParameter.Read(reader);
        reader.AlignTo(4); /* Texture1 */
        TextureParameter _Texture1 = TextureParameter.Read(reader);
        reader.AlignTo(4); /* Texture1Tiling */
        Vector2Parameter _Texture1Tiling = Vector2Parameter.Read(reader);
        reader.AlignTo(4); /* Texture1ScrollSpeed */
        Vector2Parameter _Texture1ScrollSpeed = Vector2Parameter.Read(reader);
        reader.AlignTo(4); /* Texture1Color */
        ColorParameter _Texture1Color = ColorParameter.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _active,
            _Intensity,
            _Texture0,
            _Texture0Tiling,
            _Texture0ScrollSpeed,
            _Texture0Color,
            _Texture1,
            _Texture1Tiling,
            _Texture1ScrollSpeed,
            _Texture1Color);
    }
}


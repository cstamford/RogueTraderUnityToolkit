namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $FilmGrain (9 fields) 51DA0EADECB4438D376258AAB2A48AC0/27AA29775CFD15F33C9EC0E6437641C6 */
public record class FilmGrain(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    byte active /* NeedsAlign */,
    FilmGrainLookupParameter type /* NeedsAlign */,
    ClampedFloatParameter intensity /* NeedsAlign */,
    ClampedFloatParameter response /* NeedsAlign */,
    NoInterpTextureParameter texture /* NeedsAlign */)
{
    public static FilmGrain Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* active */
        byte _active = reader.ReadU8();
        reader.AlignTo(4); /* type */
        FilmGrainLookupParameter _type = FilmGrainLookupParameter.Read(reader);
        reader.AlignTo(4); /* intensity */
        ClampedFloatParameter _intensity = ClampedFloatParameter.Read(reader);
        reader.AlignTo(4); /* response */
        ClampedFloatParameter _response = ClampedFloatParameter.Read(reader);
        reader.AlignTo(4); /* texture */
        NoInterpTextureParameter _texture = NoInterpTextureParameter.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _active,
            _type,
            _intensity,
            _response,
            _texture);
    }
}


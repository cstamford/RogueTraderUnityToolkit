namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $Vignette (10 fields) 449869E43FB61AAF4ACAD66ECBDD86D1/1E3CC3D0C006F3E67D543D20065740ED */
public record class Vignette(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    byte active /* NeedsAlign */,
    ColorParameter color /* NeedsAlign */,
    Vector2Parameter center /* NeedsAlign */,
    ClampedFloatParameter intensity /* NeedsAlign */,
    ClampedFloatParameter smoothness /* NeedsAlign */,
    BoolParameter rounded /* NeedsAlign */)
{
    public static Vignette Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* active */
        byte _active = reader.ReadU8();
        reader.AlignTo(4); /* color */
        ColorParameter _color = ColorParameter.Read(reader);
        reader.AlignTo(4); /* center */
        Vector2Parameter _center = Vector2Parameter.Read(reader);
        reader.AlignTo(4); /* intensity */
        ClampedFloatParameter _intensity = ClampedFloatParameter.Read(reader);
        reader.AlignTo(4); /* smoothness */
        ClampedFloatParameter _smoothness = ClampedFloatParameter.Read(reader);
        reader.AlignTo(4); /* rounded */
        BoolParameter _rounded = BoolParameter.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _active,
            _color,
            _center,
            _intensity,
            _smoothness,
            _rounded);
    }
}


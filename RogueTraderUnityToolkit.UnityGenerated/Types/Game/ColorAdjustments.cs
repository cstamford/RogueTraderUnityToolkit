namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $ColorAdjustments (10 fields) E8A516E3236E2EA5F7A7470424A34C74/CD2F1F36F11B97A1C8688DF25F42A9F0 */
public record class ColorAdjustments(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    byte active /* NeedsAlign */,
    FloatParameter postExposure /* NeedsAlign */,
    ClampedFloatParameter contrast /* NeedsAlign */,
    ColorParameter colorFilter /* NeedsAlign */,
    ClampedFloatParameter hueShift /* NeedsAlign */,
    ClampedFloatParameter saturation /* NeedsAlign */)
{
    public static ColorAdjustments Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* active */
        byte _active = reader.ReadU8();
        reader.AlignTo(4); /* postExposure */
        FloatParameter _postExposure = FloatParameter.Read(reader);
        reader.AlignTo(4); /* contrast */
        ClampedFloatParameter _contrast = ClampedFloatParameter.Read(reader);
        reader.AlignTo(4); /* colorFilter */
        ColorParameter _colorFilter = ColorParameter.Read(reader);
        reader.AlignTo(4); /* hueShift */
        ClampedFloatParameter _hueShift = ClampedFloatParameter.Read(reader);
        reader.AlignTo(4); /* saturation */
        ClampedFloatParameter _saturation = ClampedFloatParameter.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _active,
            _postExposure,
            _contrast,
            _colorFilter,
            _hueShift,
            _saturation);
    }
}


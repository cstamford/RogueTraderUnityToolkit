namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $BloomEnhanced (14 fields) 7346E8ACCCD0A9A2C261F020A0DA9CB5/E613B083CC409F7CC0AFE2D590D27D01 */
public record class BloomEnhanced(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    byte active /* NeedsAlign */,
    MinFloatParameter intensity /* NeedsAlign */,
    MinFloatParameter threshold /* NeedsAlign */,
    ClampedFloatParameter softKnee /* NeedsAlign */,
    ClampedFloatParameter radius /* NeedsAlign */,
    BoolParameter antiFlicker /* NeedsAlign */,
    ColorParameter tint /* NeedsAlign */,
    MinFloatParameter clamp /* NeedsAlign */,
    TextureParameter dirtTexture /* NeedsAlign */,
    MinFloatParameter dirtIntensity /* NeedsAlign */)
{
    public static BloomEnhanced Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* active */
        byte _active = reader.ReadU8();
        reader.AlignTo(4); /* intensity */
        MinFloatParameter _intensity = MinFloatParameter.Read(reader);
        reader.AlignTo(4); /* threshold */
        MinFloatParameter _threshold = MinFloatParameter.Read(reader);
        reader.AlignTo(4); /* softKnee */
        ClampedFloatParameter _softKnee = ClampedFloatParameter.Read(reader);
        reader.AlignTo(4); /* radius */
        ClampedFloatParameter _radius = ClampedFloatParameter.Read(reader);
        reader.AlignTo(4); /* antiFlicker */
        BoolParameter _antiFlicker = BoolParameter.Read(reader);
        reader.AlignTo(4); /* tint */
        ColorParameter _tint = ColorParameter.Read(reader);
        reader.AlignTo(4); /* clamp */
        MinFloatParameter _clamp = MinFloatParameter.Read(reader);
        reader.AlignTo(4); /* dirtTexture */
        TextureParameter _dirtTexture = TextureParameter.Read(reader);
        reader.AlignTo(4); /* dirtIntensity */
        MinFloatParameter _dirtIntensity = MinFloatParameter.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _active,
            _intensity,
            _threshold,
            _softKnee,
            _radius,
            _antiFlicker,
            _tint,
            _clamp,
            _dirtTexture,
            _dirtIntensity);
    }
}


namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $Tonemapping (12 fields) 3CC0CFC2797034DC7A40496D8ABCE075/8DDDD823E35CD3A207FD2BD1698E5EF4 */
public record class Tonemapping(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    byte active /* NeedsAlign */,
    TonemappingModeParameter mode /* NeedsAlign */,
    ClampedFloatParameter neutralBlackIn /* NeedsAlign */,
    ClampedFloatParameter neutralWhiteIn /* NeedsAlign */,
    ClampedFloatParameter neutralBlackOut /* NeedsAlign */,
    ClampedFloatParameter neutralWhiteOut /* NeedsAlign */,
    ClampedFloatParameter neutralWhiteLevel /* NeedsAlign */,
    ClampedFloatParameter neutralWhiteClip /* NeedsAlign */)
{
    public static Tonemapping Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* active */
        byte _active = reader.ReadU8();
        reader.AlignTo(4); /* mode */
        TonemappingModeParameter _mode = TonemappingModeParameter.Read(reader);
        reader.AlignTo(4); /* neutralBlackIn */
        ClampedFloatParameter _neutralBlackIn = ClampedFloatParameter.Read(reader);
        reader.AlignTo(4); /* neutralWhiteIn */
        ClampedFloatParameter _neutralWhiteIn = ClampedFloatParameter.Read(reader);
        reader.AlignTo(4); /* neutralBlackOut */
        ClampedFloatParameter _neutralBlackOut = ClampedFloatParameter.Read(reader);
        reader.AlignTo(4); /* neutralWhiteOut */
        ClampedFloatParameter _neutralWhiteOut = ClampedFloatParameter.Read(reader);
        reader.AlignTo(4); /* neutralWhiteLevel */
        ClampedFloatParameter _neutralWhiteLevel = ClampedFloatParameter.Read(reader);
        reader.AlignTo(4); /* neutralWhiteClip */
        ClampedFloatParameter _neutralWhiteClip = ClampedFloatParameter.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _active,
            _mode,
            _neutralBlackIn,
            _neutralWhiteIn,
            _neutralBlackOut,
            _neutralWhiteOut,
            _neutralWhiteLevel,
            _neutralWhiteClip);
    }
}


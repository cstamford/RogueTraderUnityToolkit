namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $Daltonization (11 fields) EF2CA3988CC9E5AEAAC3F26B8B9558B3/D63B65286FD1F9A48C94147D85C07A7C */
public record class Daltonization(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    byte active /* NeedsAlign */,
    ClampedFloatParameter Intensity /* NeedsAlign */,
    ClampedFloatParameter ProtanopiaFactor /* NeedsAlign */,
    ClampedFloatParameter DeuteranopiaFactor /* NeedsAlign */,
    ClampedFloatParameter TritanopiaFactor /* NeedsAlign */,
    ClampedFloatParameter BrightnessFactor /* NeedsAlign */,
    ClampedFloatParameter ContrastFactor /* NeedsAlign */)
{
    public static Daltonization Read(EndianBinaryReader reader)
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
        reader.AlignTo(4); /* ProtanopiaFactor */
        ClampedFloatParameter _ProtanopiaFactor = ClampedFloatParameter.Read(reader);
        reader.AlignTo(4); /* DeuteranopiaFactor */
        ClampedFloatParameter _DeuteranopiaFactor = ClampedFloatParameter.Read(reader);
        reader.AlignTo(4); /* TritanopiaFactor */
        ClampedFloatParameter _TritanopiaFactor = ClampedFloatParameter.Read(reader);
        reader.AlignTo(4); /* BrightnessFactor */
        ClampedFloatParameter _BrightnessFactor = ClampedFloatParameter.Read(reader);
        reader.AlignTo(4); /* ContrastFactor */
        ClampedFloatParameter _ContrastFactor = ClampedFloatParameter.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _active,
            _Intensity,
            _ProtanopiaFactor,
            _DeuteranopiaFactor,
            _TritanopiaFactor,
            _BrightnessFactor,
            _ContrastFactor);
    }
}


namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $Fog (10 fields) A1C5D884012F420704CA88D6090B13FE/959C14A945E45363D8D64096AA67AF49 */
public record class Fog(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    byte active /* NeedsAlign */,
    BoolParameter Enabled /* NeedsAlign */,
    ColorParameter Color /* NeedsAlign */,
    MinFloatParameter StartDistance /* NeedsAlign */,
    MinFloatParameter EndDistance /* NeedsAlign */,
    ClampedFloatParameter Density /* NeedsAlign */)
{
    public static Fog Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* active */
        byte _active = reader.ReadU8();
        reader.AlignTo(4); /* Enabled */
        BoolParameter _Enabled = BoolParameter.Read(reader);
        reader.AlignTo(4); /* Color */
        ColorParameter _Color = ColorParameter.Read(reader);
        reader.AlignTo(4); /* StartDistance */
        MinFloatParameter _StartDistance = MinFloatParameter.Read(reader);
        reader.AlignTo(4); /* EndDistance */
        MinFloatParameter _EndDistance = MinFloatParameter.Read(reader);
        reader.AlignTo(4); /* Density */
        ClampedFloatParameter _Density = ClampedFloatParameter.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _active,
            _Enabled,
            _Color,
            _StartDistance,
            _EndDistance,
            _Density);
    }
}


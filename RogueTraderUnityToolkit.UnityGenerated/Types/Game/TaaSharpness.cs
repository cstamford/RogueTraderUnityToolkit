namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $TaaSharpness (7 fields) 9A35E6DF2D520A95BFEFA01FB1E0839A/A0333E3C06E88EBE50C578C0D4A4EA3C */
public record class TaaSharpness(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    byte active /* NeedsAlign */,
    ClampedFloatParameter Intensity /* NeedsAlign */,
    ClampedFloatParameter Sharpness /* NeedsAlign */)
{
    public static TaaSharpness Read(EndianBinaryReader reader)
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
        reader.AlignTo(4); /* Sharpness */
        ClampedFloatParameter _Sharpness = ClampedFloatParameter.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _active,
            _Intensity,
            _Sharpness);
    }
}


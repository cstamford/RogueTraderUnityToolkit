namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $MaskedColorTransform (8 fields) 67F1E8E8A958797A19DE7F9C646D680F/D0348A19873AD71FE50ABAB20FD74B25 */
public record class MaskedColorTransform(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    byte active /* NeedsAlign */,
    StencilRefParameter StencilRef /* NeedsAlign */,
    ClampedFloatParameter Brightness /* NeedsAlign */,
    ClampedFloatParameter Contrast /* NeedsAlign */)
{
    public static MaskedColorTransform Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* active */
        byte _active = reader.ReadU8();
        reader.AlignTo(4); /* StencilRef */
        StencilRefParameter _StencilRef = StencilRefParameter.Read(reader);
        reader.AlignTo(4); /* Brightness */
        ClampedFloatParameter _Brightness = ClampedFloatParameter.Read(reader);
        reader.AlignTo(4); /* Contrast */
        ClampedFloatParameter _Contrast = ClampedFloatParameter.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _active,
            _StencilRef,
            _Brightness,
            _Contrast);
    }
}


namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $OccludedObjectHighlighting (6 fields) D2CDEE7D8187D2827B6296441437CC7E/8F83EBC6437E54F99228F60E6B4643D9 */
public record class OccludedObjectHighlighting(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    byte active /* NeedsAlign */,
    ClampedFloatParameter Intensity /* NeedsAlign */)
{
    public static OccludedObjectHighlighting Read(EndianBinaryReader reader)
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
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _active,
            _Intensity);
    }
}


namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $ShadowsMidtonesHighlights (12 fields) 503CD6D586D1C226B39F65EB144CA88A/7E3A5FD30F79CFEC6102AD98334A9C7A */
public record class ShadowsMidtonesHighlights(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    byte active /* NeedsAlign */,
    Vector4Parameter shadows /* NeedsAlign */,
    Vector4Parameter midtones /* NeedsAlign */,
    Vector4Parameter highlights /* NeedsAlign */,
    MinFloatParameter shadowsStart /* NeedsAlign */,
    MinFloatParameter shadowsEnd /* NeedsAlign */,
    MinFloatParameter highlightsStart /* NeedsAlign */,
    MinFloatParameter highlightsEnd /* NeedsAlign */)
{
    public static ShadowsMidtonesHighlights Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* active */
        byte _active = reader.ReadU8();
        reader.AlignTo(4); /* shadows */
        Vector4Parameter _shadows = Vector4Parameter.Read(reader);
        reader.AlignTo(4); /* midtones */
        Vector4Parameter _midtones = Vector4Parameter.Read(reader);
        reader.AlignTo(4); /* highlights */
        Vector4Parameter _highlights = Vector4Parameter.Read(reader);
        reader.AlignTo(4); /* shadowsStart */
        MinFloatParameter _shadowsStart = MinFloatParameter.Read(reader);
        reader.AlignTo(4); /* shadowsEnd */
        MinFloatParameter _shadowsEnd = MinFloatParameter.Read(reader);
        reader.AlignTo(4); /* highlightsStart */
        MinFloatParameter _highlightsStart = MinFloatParameter.Read(reader);
        reader.AlignTo(4); /* highlightsEnd */
        MinFloatParameter _highlightsEnd = MinFloatParameter.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _active,
            _shadows,
            _midtones,
            _highlights,
            _shadowsStart,
            _shadowsEnd,
            _highlightsStart,
            _highlightsEnd);
    }
}


namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $ColorCurves (13 fields) 1F58208AE1F444DC6ADE32A0104824E8/146AA48DECA7E6217237F384B6AE8ADD */
public record class ColorCurves(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    byte active /* NeedsAlign */,
    TextureCurveParameter master /* NeedsAlign */,
    TextureCurveParameter red /* NeedsAlign */,
    TextureCurveParameter green /* NeedsAlign */,
    TextureCurveParameter blue /* NeedsAlign */,
    TextureCurveParameter hueVsHue /* NeedsAlign */,
    TextureCurveParameter hueVsSat /* NeedsAlign */,
    TextureCurveParameter satVsSat /* NeedsAlign */,
    TextureCurveParameter lumVsSat /* NeedsAlign */)
{
    public static ColorCurves Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* active */
        byte _active = reader.ReadU8();
        reader.AlignTo(4); /* master */
        TextureCurveParameter _master = TextureCurveParameter.Read(reader);
        reader.AlignTo(4); /* red */
        TextureCurveParameter _red = TextureCurveParameter.Read(reader);
        reader.AlignTo(4); /* green */
        TextureCurveParameter _green = TextureCurveParameter.Read(reader);
        reader.AlignTo(4); /* blue */
        TextureCurveParameter _blue = TextureCurveParameter.Read(reader);
        reader.AlignTo(4); /* hueVsHue */
        TextureCurveParameter _hueVsHue = TextureCurveParameter.Read(reader);
        reader.AlignTo(4); /* hueVsSat */
        TextureCurveParameter _hueVsSat = TextureCurveParameter.Read(reader);
        reader.AlignTo(4); /* satVsSat */
        TextureCurveParameter _satVsSat = TextureCurveParameter.Read(reader);
        reader.AlignTo(4); /* lumVsSat */
        TextureCurveParameter _lumVsSat = TextureCurveParameter.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _active,
            _master,
            _red,
            _green,
            _blue,
            _hueVsHue,
            _hueVsSat,
            _satVsSat,
            _lumVsSat);
    }
}


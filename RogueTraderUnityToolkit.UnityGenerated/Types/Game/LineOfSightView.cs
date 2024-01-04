namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $LineOfSightView (9 fields) F65B956756AF6B95B2942CB805CF3FA9/740DB699AE0CAB0616C99A97F230376B */
public record class LineOfSightView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    int m_Density /* NeedsAlign */,
    int m_MinPoint /* None */,
    float m_FadeTime /* None */,
    PPtr<LineRenderer> m_LineRenderer /* None */,
    LineOfSightColor m_ColorsTable /* None */)
{
    public static LineOfSightView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_Density */
        int _m_Density = reader.ReadS32();
        int _m_MinPoint = reader.ReadS32();
        float _m_FadeTime = reader.ReadF32();
        PPtr<LineRenderer> _m_LineRenderer = PPtr<LineRenderer>.Read(reader);
        LineOfSightColor _m_ColorsTable = LineOfSightColor.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_Density,
            _m_MinPoint,
            _m_FadeTime,
            _m_LineRenderer,
            _m_ColorsTable);
    }
}


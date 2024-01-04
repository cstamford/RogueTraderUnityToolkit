namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $CalendarRoot (11 fields) B39198F18C0BA2697DBA226BFC59EA65/3B13A4E47B11A4C5E8F3951D79D713B7 */
public record class CalendarRoot(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    AsciiString StartDate /* NeedsAlign */,
    AsciiString StartTime /* NeedsAlign */,
    int YearsShift /* NeedsAlign */,
    TextHolder[] Months /* None */,
    TextHolder DaysOfWeek /* NeedsAlign */,
    FormatEntry[] Formats /* NeedsAlign */,
    TimePeriodStrings TimePeriodStrings /* NeedsAlign */)
{
    public static CalendarRoot Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* StartDate */
        AsciiString _StartDate = BuiltInString.Read(reader);
        reader.AlignTo(4); /* StartTime */
        AsciiString _StartTime = BuiltInString.Read(reader);
        reader.AlignTo(4); /* YearsShift */
        int _YearsShift = reader.ReadS32();
        TextHolder[] _Months = BuiltInArray<TextHolder>.Read(reader);
        reader.AlignTo(4); /* DaysOfWeek */
        TextHolder _DaysOfWeek = TextHolder.Read(reader);
        reader.AlignTo(4); /* Formats */
        FormatEntry[] _Formats = BuiltInArray<FormatEntry>.Read(reader);
        reader.AlignTo(4); /* TimePeriodStrings */
        TimePeriodStrings _TimePeriodStrings = TimePeriodStrings.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _StartDate,
            _StartTime,
            _YearsShift,
            _Months,
            _DaysOfWeek,
            _Formats,
            _TimePeriodStrings);
    }
}


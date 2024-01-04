namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $TimeRewindPCView (7 fields) 57AC03ED92EC061ABFB1CEA227DEE469/41B08D133C1B488BF3784AA2EF28DDB5 */
public record class TimeRewindPCView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<GameObject> m_TimeRewindBlock /* NeedsAlign */,
    PPtr<TextMeshProUGUI> m_CurrentTimeSegment /* None */,
    PPtr<TextMeshProUGUI> m_CurrentFullTime /* None */)
{
    public static TimeRewindPCView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_TimeRewindBlock */
        PPtr<GameObject> _m_TimeRewindBlock = PPtr<GameObject>.Read(reader);
        PPtr<TextMeshProUGUI> _m_CurrentTimeSegment = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<TextMeshProUGUI> _m_CurrentFullTime = PPtr<TextMeshProUGUI>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_TimeRewindBlock,
            _m_CurrentTimeSegment,
            _m_CurrentFullTime);
    }
}


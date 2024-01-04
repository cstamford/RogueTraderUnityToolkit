namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $AkTimelineEventPlayable (13 fields) BDCBF8E15D84093E261C2F4F93BECD84/28B86B039A61F328A7E817D93093C2EA */
public record class AkTimelineEventPlayable(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    Event akEvent /* NeedsAlign */,
    int blendInCurve /* NeedsAlign */,
    int blendOutCurve /* None */,
    float eventDurationMax /* None */,
    float eventDurationMin /* None */,
    byte retriggerEvent /* None */,
    byte UseWwiseEventDuration /* NeedsAlign */,
    byte PrintDebugInformation /* NeedsAlign */,
    byte StopEventAtClipEnd /* NeedsAlign */)
{
    public static AkTimelineEventPlayable Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* akEvent */
        Event _akEvent = Event.Read(reader);
        reader.AlignTo(4); /* blendInCurve */
        int _blendInCurve = reader.ReadS32();
        int _blendOutCurve = reader.ReadS32();
        float _eventDurationMax = reader.ReadF32();
        float _eventDurationMin = reader.ReadF32();
        byte _retriggerEvent = reader.ReadU8();
        reader.AlignTo(4); /* UseWwiseEventDuration */
        byte _UseWwiseEventDuration = reader.ReadU8();
        reader.AlignTo(4); /* PrintDebugInformation */
        byte _PrintDebugInformation = reader.ReadU8();
        reader.AlignTo(4); /* StopEventAtClipEnd */
        byte _StopEventAtClipEnd = reader.ReadU8();
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _akEvent,
            _blendInCurve,
            _blendOutCurve,
            _eventDurationMax,
            _eventDurationMin,
            _retriggerEvent,
            _UseWwiseEventDuration,
            _PrintDebugInformation,
            _StopEventAtClipEnd);
    }
}


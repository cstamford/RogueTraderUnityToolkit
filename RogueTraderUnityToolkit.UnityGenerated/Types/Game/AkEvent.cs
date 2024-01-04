namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $AkEvent (18 fields) 6862D1A91ADACD93641463DF1D7A822E/3A8AE6B82A304D97EA71AD3BA5A24638 */
public record class AkEvent(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    int[] triggerList /* NeedsAlign */,
    byte useOtherObject /* NeedsAlign */,
    int actionOnEventType /* NeedsAlign */,
    int curveInterpolation /* None */,
    byte enableActionOnEvent /* None */,
    Event data /* NeedsAlign */,
    byte useCallbacks /* NeedsAlign */,
    CallbackData[] Callbacks /* NeedsAlign */,
    uint playingId /* NeedsAlign */,
    PPtr<GameObject> soundEmitterObject /* None */,
    float transitionDuration /* None */,
    int eventIdInternal /* None */,
    byte[] valueGuidInternal /* None */,
    PPtr<AkEventCallbackData> m_callbackDataInternal /* NeedsAlign */)
{
    public static AkEvent Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* triggerList */
        int[] _triggerList = BuiltInArray<int>.Read(reader);
        reader.AlignTo(4); /* useOtherObject */
        byte _useOtherObject = reader.ReadU8();
        reader.AlignTo(4); /* actionOnEventType */
        int _actionOnEventType = reader.ReadS32();
        int _curveInterpolation = reader.ReadS32();
        byte _enableActionOnEvent = reader.ReadU8();
        reader.AlignTo(4); /* data */
        Event _data = Event.Read(reader);
        reader.AlignTo(4); /* useCallbacks */
        byte _useCallbacks = reader.ReadU8();
        reader.AlignTo(4); /* Callbacks */
        CallbackData[] _Callbacks = BuiltInArray<CallbackData>.Read(reader);
        reader.AlignTo(4); /* playingId */
        uint _playingId = reader.ReadU32();
        PPtr<GameObject> _soundEmitterObject = PPtr<GameObject>.Read(reader);
        float _transitionDuration = reader.ReadF32();
        int _eventIdInternal = reader.ReadS32();
        byte[] _valueGuidInternal = BuiltInArray<byte>.Read(reader);
        reader.AlignTo(4); /* m_callbackDataInternal */
        PPtr<AkEventCallbackData> _m_callbackDataInternal = PPtr<AkEventCallbackData>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _triggerList,
            _useOtherObject,
            _actionOnEventType,
            _curveInterpolation,
            _enableActionOnEvent,
            _data,
            _useCallbacks,
            _Callbacks,
            _playingId,
            _soundEmitterObject,
            _transitionDuration,
            _eventIdInternal,
            _valueGuidInternal,
            _m_callbackDataInternal);
    }
}


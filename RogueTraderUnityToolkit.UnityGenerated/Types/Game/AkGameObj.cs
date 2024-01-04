namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $AkGameObj (10 fields) 37724FFB5750C993512E7AEB18DDC5BE/D5B7C0CE9922D028CA09D066971B1DC4 */
public record class AkGameObj(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    AkGameObjListenerList m_listeners /* NeedsAlign */,
    byte isEnvironmentAware /* NeedsAlign */,
    byte isStaticObject /* NeedsAlign */,
    AkGameObjPositionOffsetData m_positionOffsetData /* NeedsAlign */,
    PPtr<AkGameObjPosOffsetData> m_posOffsetData /* NeedsAlign */,
    int listenerMask /* None */)
{
    public static AkGameObj Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_listeners */
        AkGameObjListenerList _m_listeners = AkGameObjListenerList.Read(reader);
        reader.AlignTo(4); /* isEnvironmentAware */
        byte _isEnvironmentAware = reader.ReadU8();
        reader.AlignTo(4); /* isStaticObject */
        byte _isStaticObject = reader.ReadU8();
        reader.AlignTo(4); /* m_positionOffsetData */
        AkGameObjPositionOffsetData _m_positionOffsetData = AkGameObjPositionOffsetData.Read(reader);
        reader.AlignTo(4); /* m_posOffsetData */
        PPtr<AkGameObjPosOffsetData> _m_posOffsetData = PPtr<AkGameObjPosOffsetData>.Read(reader);
        int _listenerMask = reader.ReadS32();
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_listeners,
            _isEnvironmentAware,
            _isStaticObject,
            _m_positionOffsetData,
            _m_posOffsetData,
            _listenerMask);
    }
}


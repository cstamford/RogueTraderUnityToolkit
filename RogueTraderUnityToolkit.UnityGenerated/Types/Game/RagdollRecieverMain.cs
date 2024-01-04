namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $RagdollRecieverMain (8 fields) E2093C0DB7F80CC40972BF8DFB955A66/21987DA287C3840CD384220E83EE371B */
public record class RagdollRecieverMain(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    float TimerWait /* NeedsAlign */,
    float Impulse01 /* None */,
    float Impulse02 /* None */,
    PPtr<UnitEntityView> _UnitEntityView /* None */)
{
    public static RagdollRecieverMain Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* TimerWait */
        float _TimerWait = reader.ReadF32();
        float _Impulse01 = reader.ReadF32();
        float _Impulse02 = reader.ReadF32();
        PPtr<UnitEntityView> __UnitEntityView = PPtr<UnitEntityView>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _TimerWait,
            _Impulse01,
            _Impulse02,
            __UnitEntityView);
    }
}


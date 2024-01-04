namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $AudioTriggerableSwitch (8 fields) 6165127EF28D7BA87F32430BDC310329/2CF463A4FF8CEB250A9BDCB92AFA2AAA */
public record class AudioTriggerableSwitch(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    byte m_LogTriggers /* NeedsAlign */,
    int m_Triggers /* NeedsAlign */,
    byte m_TriggerOnce /* None */,
    AkSwitchReference m_Switch /* NeedsAlign */)
{
    public static AudioTriggerableSwitch Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_LogTriggers */
        byte _m_LogTriggers = reader.ReadU8();
        reader.AlignTo(4); /* m_Triggers */
        int _m_Triggers = reader.ReadS32();
        byte _m_TriggerOnce = reader.ReadU8();
        reader.AlignTo(4); /* m_Switch */
        AkSwitchReference _m_Switch = AkSwitchReference.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_LogTriggers,
            _m_Triggers,
            _m_TriggerOnce,
            _m_Switch);
    }
}


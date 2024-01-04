namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $AudioTriggerableState (8 fields) 70452DCBAFD49893682B552B77A51930/BC8E8D3BC081F9DC00C20AAAB853B768 */
public record class AudioTriggerableState(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    byte m_LogTriggers /* NeedsAlign */,
    int m_Triggers /* NeedsAlign */,
    byte m_TriggerOnce /* None */,
    AkStateReference m_State /* NeedsAlign */)
{
    public static AudioTriggerableState Read(EndianBinaryReader reader)
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
        reader.AlignTo(4); /* m_State */
        AkStateReference _m_State = AkStateReference.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_LogTriggers,
            _m_Triggers,
            _m_TriggerOnce,
            _m_State);
    }
}


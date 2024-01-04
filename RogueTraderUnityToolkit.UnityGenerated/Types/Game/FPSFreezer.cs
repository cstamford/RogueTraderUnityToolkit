namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $FPSFreezer (6 fields) 986B2A6AE0B3F28BAA02B8E2F57BF765/0A21D5319A709ED388BFC94904ABDFC7 */
public record class FPSFreezer(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    int MinSleepMs /* NeedsAlign */,
    int MaxSleepMs /* None */)
{
    public static FPSFreezer Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* MinSleepMs */
        int _MinSleepMs = reader.ReadS32();
        int _MaxSleepMs = reader.ReadS32();
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _MinSleepMs,
            _MaxSleepMs);
    }
}


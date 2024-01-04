namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $FPSCounter (7 fields) 9781AE5AEEBDC11B27C3AF1B9881A082/DCAFEEFDFB624C9EBFE4B79B6EDD950A */
public record class FPSCounter(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    int updatesPerSecond /* NeedsAlign */,
    int systemMemoryWarnOffsetMb /* None */,
    byte Clear /* None */)
{
    public static FPSCounter Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* updatesPerSecond */
        int _updatesPerSecond = reader.ReadS32();
        int _systemMemoryWarnOffsetMb = reader.ReadS32();
        byte _Clear = reader.ReadU8();
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _updatesPerSecond,
            _systemMemoryWarnOffsetMb,
            _Clear);
    }
}


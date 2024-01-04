namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $SoundEventsEmitter (6 fields) 933F857413A1E8997E7C4385A0A3AECB/427F9DCA6CD835B54A1D37E72E8DE8CE */
public record class SoundEventsEmitter(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    AsciiString SoundBank /* NeedsAlign */,
    SoundFXSettings[] EventsOnEnable /* NeedsAlign */)
{
    public static SoundEventsEmitter Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* SoundBank */
        AsciiString _SoundBank = BuiltInString.Read(reader);
        reader.AlignTo(4); /* EventsOnEnable */
        SoundFXSettings[] _EventsOnEnable = BuiltInArray<SoundFXSettings>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _SoundBank,
            _EventsOnEnable);
    }
}


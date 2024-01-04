namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $Rabbit (10 fields) E4D75D697C6593C96B546FE598AC6A3D/DF1E8B0439226AF201B64B44CBE7D482 */
public record class Rabbit(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    float RoamRadius /* NeedsAlign */,
    byte Fearless /* None */,
    float MinIdleTime /* NeedsAlign */,
    float MaxIdleTime /* None */,
    float RoamChance /* None */,
    float IdleCrossfade /* None */)
{
    public static Rabbit Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* RoamRadius */
        float _RoamRadius = reader.ReadF32();
        byte _Fearless = reader.ReadU8();
        reader.AlignTo(4); /* MinIdleTime */
        float _MinIdleTime = reader.ReadF32();
        float _MaxIdleTime = reader.ReadF32();
        float _RoamChance = reader.ReadF32();
        float _IdleCrossfade = reader.ReadF32();
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _RoamRadius,
            _Fearless,
            _MinIdleTime,
            _MaxIdleTime,
            _RoamChance,
            _IdleCrossfade);
    }
}


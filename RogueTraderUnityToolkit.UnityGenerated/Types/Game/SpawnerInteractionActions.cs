namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $SpawnerInteractionActions (10 fields) 53A2424F7F721AF229EFA78D6BA19B07/9CAF44010C2C63A9CC0E144C9330184C */
public record class SpawnerInteractionActions(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    int OverrideDistance /* NeedsAlign */,
    ConditionsReference Conditions /* None */,
    byte TriggerOnApproach /* NeedsAlign */,
    byte TriggerOnParty /* NeedsAlign */,
    float Cooldown /* NeedsAlign */,
    ActionsReference Actions /* None */)
{
    public static SpawnerInteractionActions Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* OverrideDistance */
        int _OverrideDistance = reader.ReadS32();
        ConditionsReference _Conditions = ConditionsReference.Read(reader);
        reader.AlignTo(4); /* TriggerOnApproach */
        byte _TriggerOnApproach = reader.ReadU8();
        reader.AlignTo(4); /* TriggerOnParty */
        byte _TriggerOnParty = reader.ReadU8();
        reader.AlignTo(4); /* Cooldown */
        float _Cooldown = reader.ReadF32();
        ActionsReference _Actions = ActionsReference.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _OverrideDistance,
            _Conditions,
            _TriggerOnApproach,
            _TriggerOnParty,
            _Cooldown,
            _Actions);
    }
}


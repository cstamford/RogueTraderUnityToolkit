namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $SpawnerInteractionBark (11 fields) EAD40E3060AA04C960AB0C021DCF6208/9DB1AE6ED0DB3CF9652F14568FDE1464 */
public record class SpawnerInteractionBark(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    int OverrideDistance /* NeedsAlign */,
    ConditionsReference Conditions /* None */,
    byte TriggerOnApproach /* NeedsAlign */,
    byte TriggerOnParty /* NeedsAlign */,
    float Cooldown /* NeedsAlign */,
    PPtr<SharedStringAsset> Bark /* None */,
    byte ShowOnUser /* None */)
{
    public static SpawnerInteractionBark Read(EndianBinaryReader reader)
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
        PPtr<SharedStringAsset> _Bark = PPtr<SharedStringAsset>.Read(reader);
        byte _ShowOnUser = reader.ReadU8();
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _OverrideDistance,
            _Conditions,
            _TriggerOnApproach,
            _TriggerOnParty,
            _Cooldown,
            _Bark,
            _ShowOnUser);
    }
}


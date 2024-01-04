namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $SpawnerInteractionDialog (10 fields) F8FCA1EE9047E0DD7D9BC8C9C897C43F/4C977EC759B21EE599821689D4CBFEAF */
public record class SpawnerInteractionDialog(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    int OverrideDistance /* NeedsAlign */,
    ConditionsReference Conditions /* None */,
    byte TriggerOnApproach /* NeedsAlign */,
    byte TriggerOnParty /* NeedsAlign */,
    float Cooldown /* NeedsAlign */,
    BlueprintDialogReference m_Dialog /* None */)
{
    public static SpawnerInteractionDialog Read(EndianBinaryReader reader)
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
        BlueprintDialogReference _m_Dialog = BlueprintDialogReference.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _OverrideDistance,
            _Conditions,
            _TriggerOnApproach,
            _TriggerOnParty,
            _Cooldown,
            _m_Dialog);
    }
}


namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $CompanionSpawner (22 fields) 8ABB4FD5FCF92E4390D5307963279F85/2FFEBB8B007A4414FE34FC5E2DE60E67 */
public record class CompanionSpawner(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    byte m_IsInGame /* NeedsAlign */,
    AsciiString UniqueId /* NeedsAlign */,
    BlueprintUnitReference m_Blueprint /* NeedsAlign */,
    byte m_SpawnOnSceneInit /* NeedsAlign */,
    byte m_RespawnIfDead /* NeedsAlign */,
    ConditionsReference m_spawnConditions /* NeedsAlign */,
    byte m_UsePet /* NeedsAlign */,
    byte m_IsPlayerPet /* NeedsAlign */,
    int m_PetType /* NeedsAlign */,
    byte m_SpawnWhenNone /* None */,
    byte m_SpawnWhenRemote /* NeedsAlign */,
    byte m_SpawnWhenInCapital /* NeedsAlign */,
    byte m_SpawnWhenEx /* NeedsAlign */,
    byte m_HideIfDead /* NeedsAlign */,
    ConditionsReference ControlCondition /* NeedsAlign */,
    ConditionsReference ShowCondition /* NeedsAlign */,
    BlueprintFactionReference m_OverrideFaction /* NeedsAlign */,
    byte m_Dummy /* NeedsAlign */)
{
    public static CompanionSpawner Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_IsInGame */
        byte _m_IsInGame = reader.ReadU8();
        reader.AlignTo(4); /* UniqueId */
        AsciiString _UniqueId = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_Blueprint */
        BlueprintUnitReference _m_Blueprint = BlueprintUnitReference.Read(reader);
        reader.AlignTo(4); /* m_SpawnOnSceneInit */
        byte _m_SpawnOnSceneInit = reader.ReadU8();
        reader.AlignTo(4); /* m_RespawnIfDead */
        byte _m_RespawnIfDead = reader.ReadU8();
        reader.AlignTo(4); /* m_spawnConditions */
        ConditionsReference _m_spawnConditions = ConditionsReference.Read(reader);
        reader.AlignTo(4); /* m_UsePet */
        byte _m_UsePet = reader.ReadU8();
        reader.AlignTo(4); /* m_IsPlayerPet */
        byte _m_IsPlayerPet = reader.ReadU8();
        reader.AlignTo(4); /* m_PetType */
        int _m_PetType = reader.ReadS32();
        byte _m_SpawnWhenNone = reader.ReadU8();
        reader.AlignTo(4); /* m_SpawnWhenRemote */
        byte _m_SpawnWhenRemote = reader.ReadU8();
        reader.AlignTo(4); /* m_SpawnWhenInCapital */
        byte _m_SpawnWhenInCapital = reader.ReadU8();
        reader.AlignTo(4); /* m_SpawnWhenEx */
        byte _m_SpawnWhenEx = reader.ReadU8();
        reader.AlignTo(4); /* m_HideIfDead */
        byte _m_HideIfDead = reader.ReadU8();
        reader.AlignTo(4); /* ControlCondition */
        ConditionsReference _ControlCondition = ConditionsReference.Read(reader);
        reader.AlignTo(4); /* ShowCondition */
        ConditionsReference _ShowCondition = ConditionsReference.Read(reader);
        reader.AlignTo(4); /* m_OverrideFaction */
        BlueprintFactionReference _m_OverrideFaction = BlueprintFactionReference.Read(reader);
        reader.AlignTo(4); /* m_Dummy */
        byte _m_Dummy = reader.ReadU8();
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_IsInGame,
            _UniqueId,
            _m_Blueprint,
            _m_SpawnOnSceneInit,
            _m_RespawnIfDead,
            _m_spawnConditions,
            _m_UsePet,
            _m_IsPlayerPet,
            _m_PetType,
            _m_SpawnWhenNone,
            _m_SpawnWhenRemote,
            _m_SpawnWhenInCapital,
            _m_SpawnWhenEx,
            _m_HideIfDead,
            _ControlCondition,
            _ShowCondition,
            _m_OverrideFaction,
            _m_Dummy);
    }
}


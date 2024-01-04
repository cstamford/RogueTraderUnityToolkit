namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $UnitSpawner (15 fields) A6600B486810B28A75639CB4F97091F9/12381C68293EA36E3C703FC28AD6D6AA */
public record class UnitSpawner(
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
    byte IgnoreInEncoutnerStatistic /* NeedsAlign */,
    byte m_OverrideMusicCombatState /* NeedsAlign */,
    int m_MusicCombatState /* NeedsAlign */,
    byte m_BossMusicEnable /* None */,
    AkStateReference m_MusicBossFightType /* NeedsAlign */)
{
    public static UnitSpawner Read(EndianBinaryReader reader)
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
        reader.AlignTo(4); /* IgnoreInEncoutnerStatistic */
        byte _IgnoreInEncoutnerStatistic = reader.ReadU8();
        reader.AlignTo(4); /* m_OverrideMusicCombatState */
        byte _m_OverrideMusicCombatState = reader.ReadU8();
        reader.AlignTo(4); /* m_MusicCombatState */
        int _m_MusicCombatState = reader.ReadS32();
        byte _m_BossMusicEnable = reader.ReadU8();
        reader.AlignTo(4); /* m_MusicBossFightType */
        AkStateReference _m_MusicBossFightType = AkStateReference.Read(reader);
        
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
            _IgnoreInEncoutnerStatistic,
            _m_OverrideMusicCombatState,
            _m_MusicCombatState,
            _m_BossMusicEnable,
            _m_MusicBossFightType);
    }
}


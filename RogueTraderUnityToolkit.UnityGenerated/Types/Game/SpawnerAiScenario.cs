namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $SpawnerAiScenario (16 fields) 4671052E6E39AF3AB88D113E9120E802/26B647E466859CF6EF01B457D86C41A7 */
public record class SpawnerAiScenario(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    ConditionsReference ScenarioActivationConditions /* NeedsAlign */,
    int Scenario /* NeedsAlign */,
    byte HoldUnitPosition /* None */,
    PPtr<Transform> HoldPosition /* NeedsAlign */,
    managedReference HoldPositionNearUnit /* None */,
    int Range /* None */,
    byte DeactivateWhenPositionReached /* None */,
    int IdleRoundsThreshold /* NeedsAlign */,
    managedRefArrayItem[] m_PriorityTargets /* None */,
    byte SimultaneousTargets /* None */,
    byte AttackPriorityTargetsOnly /* NeedsAlign */,
    RefRegistry references /* NeedsAlign */)
{
    public static SpawnerAiScenario Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* ScenarioActivationConditions */
        ConditionsReference _ScenarioActivationConditions = ConditionsReference.Read(reader);
        reader.AlignTo(4); /* Scenario */
        int _Scenario = reader.ReadS32();
        byte _HoldUnitPosition = reader.ReadU8();
        reader.AlignTo(4); /* HoldPosition */
        PPtr<Transform> _HoldPosition = PPtr<Transform>.Read(reader);
        managedReference _HoldPositionNearUnit = managedReference.Read(reader);
        int _Range = reader.ReadS32();
        byte _DeactivateWhenPositionReached = reader.ReadU8();
        reader.AlignTo(4); /* IdleRoundsThreshold */
        int _IdleRoundsThreshold = reader.ReadS32();
        managedRefArrayItem[] _m_PriorityTargets = BuiltInArray<managedRefArrayItem>.Read(reader);
        byte _SimultaneousTargets = reader.ReadU8();
        reader.AlignTo(4); /* AttackPriorityTargetsOnly */
        byte _AttackPriorityTargetsOnly = reader.ReadU8();
        reader.AlignTo(4); /* references */
        RefRegistry _references = default! /* RefRegistry_2 */;
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _ScenarioActivationConditions,
            _Scenario,
            _HoldUnitPosition,
            _HoldPosition,
            _HoldPositionNearUnit,
            _Range,
            _DeactivateWhenPositionReached,
            _IdleRoundsThreshold,
            _m_PriorityTargets,
            _SimultaneousTargets,
            _AttackPriorityTargetsOnly,
            _references);
    }
}


namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $UnitMovementAgentShip (19 fields) D8B825BF49689518EA1DB8A28861FCF5/42030013D68BF5CEED97CBB947DF216A */
public record class UnitMovementAgentShip(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    byte m_UseAcceleration /* NeedsAlign */,
    float m_Acceleration /* NeedsAlign */,
    float m_MinSpeed /* None */,
    float m_AngularSpeed /* None */,
    float m_CombatAngularSpeed /* None */,
    float m_SlowDownCoefficient /* None */,
    byte m_AvoidanceDisabled /* None */,
    byte IsPositionChanged /* NeedsAlign */,
    float AccelerationDistance /* NeedsAlign */,
    int AccelerationDistanceInCells /* None */,
    float SlowdownDistance /* None */,
    int SlowdownDistanceInCells /* None */,
    float MinAccelerationModifier /* None */,
    int AccelerationPhaseCurve /* None */,
    int SlowdownPhaseCurve /* None */)
{
    public static UnitMovementAgentShip Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_UseAcceleration */
        byte _m_UseAcceleration = reader.ReadU8();
        reader.AlignTo(4); /* m_Acceleration */
        float _m_Acceleration = reader.ReadF32();
        float _m_MinSpeed = reader.ReadF32();
        float _m_AngularSpeed = reader.ReadF32();
        float _m_CombatAngularSpeed = reader.ReadF32();
        float _m_SlowDownCoefficient = reader.ReadF32();
        byte _m_AvoidanceDisabled = reader.ReadU8();
        reader.AlignTo(4); /* IsPositionChanged */
        byte _IsPositionChanged = reader.ReadU8();
        reader.AlignTo(4); /* AccelerationDistance */
        float _AccelerationDistance = reader.ReadF32();
        int _AccelerationDistanceInCells = reader.ReadS32();
        float _SlowdownDistance = reader.ReadF32();
        int _SlowdownDistanceInCells = reader.ReadS32();
        float _MinAccelerationModifier = reader.ReadF32();
        int _AccelerationPhaseCurve = reader.ReadS32();
        int _SlowdownPhaseCurve = reader.ReadS32();
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_UseAcceleration,
            _m_Acceleration,
            _m_MinSpeed,
            _m_AngularSpeed,
            _m_CombatAngularSpeed,
            _m_SlowDownCoefficient,
            _m_AvoidanceDisabled,
            _IsPositionChanged,
            _AccelerationDistance,
            _AccelerationDistanceInCells,
            _SlowdownDistance,
            _SlowdownDistanceInCells,
            _MinAccelerationModifier,
            _AccelerationPhaseCurve,
            _SlowdownPhaseCurve);
    }
}


namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $UnitMovementAgent (11 fields) 17D6D31249BD3536A3FF805073A8570D/03E041F04A3E768D0BEBFA882F14AAEB */
public record class UnitMovementAgent(
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
    byte m_AvoidanceDisabled /* None */)
{
    public static UnitMovementAgent Read(EndianBinaryReader reader)
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
            _m_AvoidanceDisabled);
    }
}


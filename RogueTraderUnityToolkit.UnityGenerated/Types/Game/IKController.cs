namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $IKController (12 fields) 569E8C42CC89DF354AF7B9334A76787F/70F6438BD2A8E7C8FD22E4E1EE43EA32 */
public record class IKController(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<LimbIK> LeftArmLimbIk /* NeedsAlign */,
    PPtr<LimbIK> RightArmLimbIk /* None */,
    PPtr<GrounderBipedIK> GrounderIK /* None */,
    PPtr<Character> CharacterSystem /* None */,
    PPtr<UnitEntityView> CharacterUnitEntity /* None */,
    byte IsDollRoom /* None */,
    Vector3f ShieldTargetPosition /* NeedsAlign */,
    Vector3f ShieldTargetRotation /* None */)
{
    public static IKController Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* LeftArmLimbIk */
        PPtr<LimbIK> _LeftArmLimbIk = PPtr<LimbIK>.Read(reader);
        PPtr<LimbIK> _RightArmLimbIk = PPtr<LimbIK>.Read(reader);
        PPtr<GrounderBipedIK> _GrounderIK = PPtr<GrounderBipedIK>.Read(reader);
        PPtr<Character> _CharacterSystem = PPtr<Character>.Read(reader);
        PPtr<UnitEntityView> _CharacterUnitEntity = PPtr<UnitEntityView>.Read(reader);
        byte _IsDollRoom = reader.ReadU8();
        reader.AlignTo(4); /* ShieldTargetPosition */
        Vector3f _ShieldTargetPosition = Vector3f.Read(reader);
        Vector3f _ShieldTargetRotation = Vector3f.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _LeftArmLimbIk,
            _RightArmLimbIk,
            _GrounderIK,
            _CharacterSystem,
            _CharacterUnitEntity,
            _IsDollRoom,
            _ShieldTargetPosition,
            _ShieldTargetRotation);
    }
}


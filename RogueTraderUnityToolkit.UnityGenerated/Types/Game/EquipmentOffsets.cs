namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $EquipmentOffsets (13 fields) 2A379262391C53FE3735BA073EE751B1/BDE65E83289BCEF0C30FF28F8643C191 */
public record class EquipmentOffsets(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    Offsets m_MainHand /* NeedsAlign */,
    Offsets m_OffHand /* None */,
    Offsets m_SlotOffsets /* None */,
    byte BackpackOffsets /* None */,
    PPtr<Transform> JointsParent /* NeedsAlign */,
    PPtr<Transform> IkTargetLeftHand /* None */,
    PPtr<Transform> IkTargetRightHand /* None */,
    RaceOffset[] raceOffset /* None */,
    RaceScale[] raceScaleList /* None */)
{
    public static EquipmentOffsets Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_MainHand */
        Offsets _m_MainHand = Offsets.Read(reader);
        Offsets _m_OffHand = Offsets.Read(reader);
        Offsets _m_SlotOffsets = Offsets.Read(reader);
        byte _BackpackOffsets = reader.ReadU8();
        reader.AlignTo(4); /* JointsParent */
        PPtr<Transform> _JointsParent = PPtr<Transform>.Read(reader);
        PPtr<Transform> _IkTargetLeftHand = PPtr<Transform>.Read(reader);
        PPtr<Transform> _IkTargetRightHand = PPtr<Transform>.Read(reader);
        RaceOffset[] _raceOffset = BuiltInArray<RaceOffset>.Read(reader);
        RaceScale[] _raceScaleList = BuiltInArray<RaceScale>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_MainHand,
            _m_OffHand,
            _m_SlotOffsets,
            _BackpackOffsets,
            _JointsParent,
            _IkTargetLeftHand,
            _IkTargetRightHand,
            _raceOffset,
            _raceScaleList);
    }
}


namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $NpcUnitMark (11 fields) FA0ECF0815783825208AA420A3F487BD/F3C28062551BB5845BB916D2D94BB73F */
public record class NpcUnitMark(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    DecalColorSet m_ColorSet /* NeedsAlign */,
    PPtr<GameObject> m_NormalDecal /* None */,
    UnitMarkDecal m_DialogCurrentSpeakerDecal /* None */,
    UnitMarkDecal m_CombatDecal /* None */,
    UnitMarkDecal m_CombatSelectedDecal /* None */,
    UnitMarkDecal m_CombatIsInAoeDecal /* None */,
    UnitMarkDecal m_PingTarget /* None */)
{
    public static NpcUnitMark Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_ColorSet */
        DecalColorSet _m_ColorSet = DecalColorSet.Read(reader);
        PPtr<GameObject> _m_NormalDecal = PPtr<GameObject>.Read(reader);
        UnitMarkDecal _m_DialogCurrentSpeakerDecal = UnitMarkDecal.Read(reader);
        UnitMarkDecal _m_CombatDecal = UnitMarkDecal.Read(reader);
        UnitMarkDecal _m_CombatSelectedDecal = UnitMarkDecal.Read(reader);
        UnitMarkDecal _m_CombatIsInAoeDecal = UnitMarkDecal.Read(reader);
        UnitMarkDecal _m_PingTarget = UnitMarkDecal.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_ColorSet,
            _m_NormalDecal,
            _m_DialogCurrentSpeakerDecal,
            _m_CombatDecal,
            _m_CombatSelectedDecal,
            _m_CombatIsInAoeDecal,
            _m_PingTarget);
    }
}


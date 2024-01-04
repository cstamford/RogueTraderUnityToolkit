namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $EnemyUnitMark (11 fields) C4081F5D2DF24F4FC886EAF0DA3EECC1/A4E194BA663CB8D99A0A32256B473BE7 */
public record class EnemyUnitMark(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    DecalColorSet m_ColorSet /* NeedsAlign */,
    PPtr<GameObject> m_NormalDecal /* None */,
    UnitMarkDecal m_ExplorationSelectedDecal /* None */,
    UnitMarkDecal m_CombatDecal /* None */,
    UnitMarkDecal m_CombatSelectedDecal /* None */,
    UnitMarkDecal m_CombatIsInAoeDecal /* None */,
    UnitMarkDecal m_PingTarget /* None */)
{
    public static EnemyUnitMark Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_ColorSet */
        DecalColorSet _m_ColorSet = DecalColorSet.Read(reader);
        PPtr<GameObject> _m_NormalDecal = PPtr<GameObject>.Read(reader);
        UnitMarkDecal _m_ExplorationSelectedDecal = UnitMarkDecal.Read(reader);
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
            _m_ExplorationSelectedDecal,
            _m_CombatDecal,
            _m_CombatSelectedDecal,
            _m_CombatIsInAoeDecal,
            _m_PingTarget);
    }
}


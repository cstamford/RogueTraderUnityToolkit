namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $CharacterUnitMark (17 fields) B9D19D203E5F0558F79A11D4FDE350E6/FCA0B47C92705380CB6469FF98DC49FC */
public record class CharacterUnitMark(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    DecalColorSet m_ColorSet /* NeedsAlign */,
    PPtr<GameObject> m_NormalDecal /* None */,
    UnitMarkDecal m_ExplorationSelectedDecal /* None */,
    UnitMarkDecal m_ExplorationOtherPlayerDecal /* None */,
    UnitMarkDecal m_ExplorationDialogCurrentSpeakerDecal /* None */,
    UnitMarkDecal m_CombatDecal /* None */,
    UnitMarkDecal m_CombatSelectedDecal /* None */,
    UnitMarkDecal m_CombatCurrentTurnDecal /* None */,
    UnitMarkDecal m_CombatOtherPlayerDecal /* None */,
    UnitMarkDecal m_CombatSelectedOtherPlayerDecal /* None */,
    UnitMarkDecal m_CombatCurrentTurnOtherPlayerDecal /* None */,
    UnitMarkDecal m_GamepadSelectedDecal /* None */,
    UnitMarkDecal m_PingTarget /* None */)
{
    public static CharacterUnitMark Read(EndianBinaryReader reader)
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
        UnitMarkDecal _m_ExplorationOtherPlayerDecal = UnitMarkDecal.Read(reader);
        UnitMarkDecal _m_ExplorationDialogCurrentSpeakerDecal = UnitMarkDecal.Read(reader);
        UnitMarkDecal _m_CombatDecal = UnitMarkDecal.Read(reader);
        UnitMarkDecal _m_CombatSelectedDecal = UnitMarkDecal.Read(reader);
        UnitMarkDecal _m_CombatCurrentTurnDecal = UnitMarkDecal.Read(reader);
        UnitMarkDecal _m_CombatOtherPlayerDecal = UnitMarkDecal.Read(reader);
        UnitMarkDecal _m_CombatSelectedOtherPlayerDecal = UnitMarkDecal.Read(reader);
        UnitMarkDecal _m_CombatCurrentTurnOtherPlayerDecal = UnitMarkDecal.Read(reader);
        UnitMarkDecal _m_GamepadSelectedDecal = UnitMarkDecal.Read(reader);
        UnitMarkDecal _m_PingTarget = UnitMarkDecal.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_ColorSet,
            _m_NormalDecal,
            _m_ExplorationSelectedDecal,
            _m_ExplorationOtherPlayerDecal,
            _m_ExplorationDialogCurrentSpeakerDecal,
            _m_CombatDecal,
            _m_CombatSelectedDecal,
            _m_CombatCurrentTurnDecal,
            _m_CombatOtherPlayerDecal,
            _m_CombatSelectedOtherPlayerDecal,
            _m_CombatCurrentTurnOtherPlayerDecal,
            _m_GamepadSelectedDecal,
            _m_PingTarget);
    }
}


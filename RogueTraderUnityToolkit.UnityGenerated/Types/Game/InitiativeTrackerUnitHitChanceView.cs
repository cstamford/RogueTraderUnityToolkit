namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $InitiativeTrackerUnitHitChanceView (21 fields) 6A0C8285BB77D9124832AA60923D2A9C/D9D3DF250349C690891433E1CEFAA5A4 */
public record class InitiativeTrackerUnitHitChanceView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    byte m_HasAttackParams /* NeedsAlign */,
    PPtr<GameObject> m_AttacksContainer /* NeedsAlign */,
    byte m_HasDefenceParams /* None */,
    PPtr<GameObject> m_DefenceContainer /* NeedsAlign */,
    PPtr<GameObject> m_SumChanceBlock /* None */,
    PPtr<TextMeshProUGUI> m_SumChanceLabel /* None */,
    PPtr<GameObject> m_BurstBlock /* None */,
    PPtr<TextMeshProUGUI> m_BurstIndexLabel /* None */,
    PPtr<GameObject> m_HitBlock /* None */,
    PPtr<TextMeshProUGUI> m_HitLabel /* None */,
    PPtr<GameObject> m_PushBlock /* None */,
    PPtr<GameObject> m_DodgeBlock /* None */,
    PPtr<TextMeshProUGUI> m_DodgeLabel /* None */,
    PPtr<GameObject> m_ParryBlock /* None */,
    PPtr<TextMeshProUGUI> m_ParryLabel /* None */,
    PPtr<GameObject> m_CoverBlock /* None */,
    PPtr<TextMeshProUGUI> m_CoverLabel /* None */)
{
    public static InitiativeTrackerUnitHitChanceView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_HasAttackParams */
        byte _m_HasAttackParams = reader.ReadU8();
        reader.AlignTo(4); /* m_AttacksContainer */
        PPtr<GameObject> _m_AttacksContainer = PPtr<GameObject>.Read(reader);
        byte _m_HasDefenceParams = reader.ReadU8();
        reader.AlignTo(4); /* m_DefenceContainer */
        PPtr<GameObject> _m_DefenceContainer = PPtr<GameObject>.Read(reader);
        PPtr<GameObject> _m_SumChanceBlock = PPtr<GameObject>.Read(reader);
        PPtr<TextMeshProUGUI> _m_SumChanceLabel = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<GameObject> _m_BurstBlock = PPtr<GameObject>.Read(reader);
        PPtr<TextMeshProUGUI> _m_BurstIndexLabel = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<GameObject> _m_HitBlock = PPtr<GameObject>.Read(reader);
        PPtr<TextMeshProUGUI> _m_HitLabel = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<GameObject> _m_PushBlock = PPtr<GameObject>.Read(reader);
        PPtr<GameObject> _m_DodgeBlock = PPtr<GameObject>.Read(reader);
        PPtr<TextMeshProUGUI> _m_DodgeLabel = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<GameObject> _m_ParryBlock = PPtr<GameObject>.Read(reader);
        PPtr<TextMeshProUGUI> _m_ParryLabel = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<GameObject> _m_CoverBlock = PPtr<GameObject>.Read(reader);
        PPtr<TextMeshProUGUI> _m_CoverLabel = PPtr<TextMeshProUGUI>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_HasAttackParams,
            _m_AttacksContainer,
            _m_HasDefenceParams,
            _m_DefenceContainer,
            _m_SumChanceBlock,
            _m_SumChanceLabel,
            _m_BurstBlock,
            _m_BurstIndexLabel,
            _m_HitBlock,
            _m_HitLabel,
            _m_PushBlock,
            _m_DodgeBlock,
            _m_DodgeLabel,
            _m_ParryBlock,
            _m_ParryLabel,
            _m_CoverBlock,
            _m_CoverLabel);
    }
}


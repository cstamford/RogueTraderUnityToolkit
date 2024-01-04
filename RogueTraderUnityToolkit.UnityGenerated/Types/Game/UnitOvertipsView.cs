namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $UnitOvertipsView (11 fields) 0C59877C1ACFF48C51F959D9F3A14052/4BE1DE07616A0DBB6F68EDE2264DEB6A */
public record class UnitOvertipsView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<RectTransform> m_PartyContainer /* NeedsAlign */,
    PPtr<RectTransform> m_EnemyContainer /* None */,
    PPtr<RectTransform> m_NpcContainer /* None */,
    byte m_IsSpace /* None */,
    PPtr<OvertipUnitView> m_OvertipUnitView /* NeedsAlign */,
    PPtr<OvertipSpaceShipUnitView> m_OvertipSpaceShipUnitPCView /* None */,
    PPtr<OvertipTorpedoUnitView> m_OvertipTorpedoUnitView /* None */)
{
    public static UnitOvertipsView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_PartyContainer */
        PPtr<RectTransform> _m_PartyContainer = PPtr<RectTransform>.Read(reader);
        PPtr<RectTransform> _m_EnemyContainer = PPtr<RectTransform>.Read(reader);
        PPtr<RectTransform> _m_NpcContainer = PPtr<RectTransform>.Read(reader);
        byte _m_IsSpace = reader.ReadU8();
        reader.AlignTo(4); /* m_OvertipUnitView */
        PPtr<OvertipUnitView> _m_OvertipUnitView = PPtr<OvertipUnitView>.Read(reader);
        PPtr<OvertipSpaceShipUnitView> _m_OvertipSpaceShipUnitPCView = PPtr<OvertipSpaceShipUnitView>.Read(reader);
        PPtr<OvertipTorpedoUnitView> _m_OvertipTorpedoUnitView = PPtr<OvertipTorpedoUnitView>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_PartyContainer,
            _m_EnemyContainer,
            _m_NpcContainer,
            _m_IsSpace,
            _m_OvertipUnitView,
            _m_OvertipSpaceShipUnitPCView,
            _m_OvertipTorpedoUnitView);
    }
}


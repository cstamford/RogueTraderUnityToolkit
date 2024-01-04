namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $SpaceCombatPCView (10 fields) 4F5E2A9FB1F93D39183A7D774A62623B/907A788BAED9A722A246D88F25E0F844 */
public record class SpaceCombatPCView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<ShipWeaponsPanelPCView> m_ShipWeaponsPanelPCView /* NeedsAlign */,
    PPtr<ShipPostsPanelPCView> m_ShipPostsPanelPCView /* None */,
    PPtr<SpaceCombatServicePanelPCView> m_SpaceCombatServicePanelPCView /* None */,
    PPtr<ExitBattlePopupPCView> m_ExitBattlePopupPCView /* None */,
    PPtr<CircleArcsView> m_SpaceCombatCircleArcsView /* None */,
    PPtr<StarSystemSpaceBarksHolderPCView> m_SpaceCombatBarksHolderPCView /* None */)
{
    public static SpaceCombatPCView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_ShipWeaponsPanelPCView */
        PPtr<ShipWeaponsPanelPCView> _m_ShipWeaponsPanelPCView = PPtr<ShipWeaponsPanelPCView>.Read(reader);
        PPtr<ShipPostsPanelPCView> _m_ShipPostsPanelPCView = PPtr<ShipPostsPanelPCView>.Read(reader);
        PPtr<SpaceCombatServicePanelPCView> _m_SpaceCombatServicePanelPCView = PPtr<SpaceCombatServicePanelPCView>.Read(reader);
        PPtr<ExitBattlePopupPCView> _m_ExitBattlePopupPCView = PPtr<ExitBattlePopupPCView>.Read(reader);
        PPtr<CircleArcsView> _m_SpaceCombatCircleArcsView = PPtr<CircleArcsView>.Read(reader);
        PPtr<StarSystemSpaceBarksHolderPCView> _m_SpaceCombatBarksHolderPCView = PPtr<StarSystemSpaceBarksHolderPCView>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_ShipWeaponsPanelPCView,
            _m_ShipPostsPanelPCView,
            _m_SpaceCombatServicePanelPCView,
            _m_ExitBattlePopupPCView,
            _m_SpaceCombatCircleArcsView,
            _m_SpaceCombatBarksHolderPCView);
    }
}


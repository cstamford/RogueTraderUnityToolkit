namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $SpaceCombatConsoleView (10 fields) 686223777E216CD12EE025C2F3EDCE0B/D8E0025A3485F8692CF0D20E90CA85DA */
public record class SpaceCombatConsoleView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<ShipWeaponsPanelConsoleView> m_ShipWeaponsPanelConsoleView /* NeedsAlign */,
    PPtr<ShipPostsPanelConsoleView> m_ShipPostsPanelConsoleView /* None */,
    PPtr<SpaceCombatServicePanelConsoleView> m_SpaceCombatServicePanelConsoleView /* None */,
    PPtr<ExitBattlePopupConsoleView> m_ExitBattlePopupConsoleView /* None */,
    PPtr<CircleArcsView> m_SpaceCombatCircleArcsView /* None */,
    PPtr<StarSystemSpaceBarksHolderConsoleView> m_SpaceCombatBarksHolderConsoleView /* None */)
{
    public static SpaceCombatConsoleView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_ShipWeaponsPanelConsoleView */
        PPtr<ShipWeaponsPanelConsoleView> _m_ShipWeaponsPanelConsoleView = PPtr<ShipWeaponsPanelConsoleView>.Read(reader);
        PPtr<ShipPostsPanelConsoleView> _m_ShipPostsPanelConsoleView = PPtr<ShipPostsPanelConsoleView>.Read(reader);
        PPtr<SpaceCombatServicePanelConsoleView> _m_SpaceCombatServicePanelConsoleView = PPtr<SpaceCombatServicePanelConsoleView>.Read(reader);
        PPtr<ExitBattlePopupConsoleView> _m_ExitBattlePopupConsoleView = PPtr<ExitBattlePopupConsoleView>.Read(reader);
        PPtr<CircleArcsView> _m_SpaceCombatCircleArcsView = PPtr<CircleArcsView>.Read(reader);
        PPtr<StarSystemSpaceBarksHolderConsoleView> _m_SpaceCombatBarksHolderConsoleView = PPtr<StarSystemSpaceBarksHolderConsoleView>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_ShipWeaponsPanelConsoleView,
            _m_ShipPostsPanelConsoleView,
            _m_SpaceCombatServicePanelConsoleView,
            _m_ExitBattlePopupConsoleView,
            _m_SpaceCombatCircleArcsView,
            _m_SpaceCombatBarksHolderConsoleView);
    }
}


namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $ShipWeaponsPanelPCView (10 fields) 6EA6A7FC8C3A9D79BA109DA78A645EB3/211432F86ACD9E2B248999A58A67EE0C */
public record class ShipWeaponsPanelPCView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<WeaponAbilitiesGroupPCView> m_PortGroup /* NeedsAlign */,
    PPtr<WeaponAbilitiesGroupPCView> m_ProwGroup /* None */,
    PPtr<WeaponAbilitiesGroupPCView> m_DorsalGroup /* None */,
    PPtr<WeaponAbilitiesGroupPCView> m_StarboardGroup /* None */,
    PPtr<AbilitiesGroupPCView> m_AbilitiesGroup /* None */,
    PPtr<AbilitiesGroupPCView> m_SecondAbilitiesGroup /* None */)
{
    public static ShipWeaponsPanelPCView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_PortGroup */
        PPtr<WeaponAbilitiesGroupPCView> _m_PortGroup = PPtr<WeaponAbilitiesGroupPCView>.Read(reader);
        PPtr<WeaponAbilitiesGroupPCView> _m_ProwGroup = PPtr<WeaponAbilitiesGroupPCView>.Read(reader);
        PPtr<WeaponAbilitiesGroupPCView> _m_DorsalGroup = PPtr<WeaponAbilitiesGroupPCView>.Read(reader);
        PPtr<WeaponAbilitiesGroupPCView> _m_StarboardGroup = PPtr<WeaponAbilitiesGroupPCView>.Read(reader);
        PPtr<AbilitiesGroupPCView> _m_AbilitiesGroup = PPtr<AbilitiesGroupPCView>.Read(reader);
        PPtr<AbilitiesGroupPCView> _m_SecondAbilitiesGroup = PPtr<AbilitiesGroupPCView>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_PortGroup,
            _m_ProwGroup,
            _m_DorsalGroup,
            _m_StarboardGroup,
            _m_AbilitiesGroup,
            _m_SecondAbilitiesGroup);
    }
}


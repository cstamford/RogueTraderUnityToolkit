namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $ShipWeaponsPanelConsoleView (14 fields) E155134BA0C8C0FCF9D4456F15947382/1D694B672F198145727AB63BA6311D66 */
public record class ShipWeaponsPanelConsoleView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<ConsoleHintsWidget> m_HintsWidget /* NeedsAlign */,
    PPtr<ConsoleHint> m_InspectHint /* None */,
    PPtr<MonoBehaviour>[] m_AnimatorObjects /* None */,
    PPtr<RectTransform> m_TooltipPlace /* None */,
    PPtr<WeaponAbilitiesGroupConsoleView> m_PortGroup /* None */,
    PPtr<WeaponAbilitiesGroupConsoleView> m_ProwGroup /* None */,
    PPtr<WeaponAbilitiesGroupConsoleView> m_DorsalGroup /* None */,
    PPtr<WeaponAbilitiesGroupConsoleView> m_StarboardGroup /* None */,
    PPtr<AbilitiesGroupConsoleView> m_AbilitiesGroup /* None */,
    PPtr<AbilitiesGroupConsoleView> m_SecondAbilitiesGroup /* None */)
{
    public static ShipWeaponsPanelConsoleView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_HintsWidget */
        PPtr<ConsoleHintsWidget> _m_HintsWidget = PPtr<ConsoleHintsWidget>.Read(reader);
        PPtr<ConsoleHint> _m_InspectHint = PPtr<ConsoleHint>.Read(reader);
        PPtr<MonoBehaviour>[] _m_AnimatorObjects = BuiltInArray<PPtr<MonoBehaviour>>.Read(reader);
        PPtr<RectTransform> _m_TooltipPlace = PPtr<RectTransform>.Read(reader);
        PPtr<WeaponAbilitiesGroupConsoleView> _m_PortGroup = PPtr<WeaponAbilitiesGroupConsoleView>.Read(reader);
        PPtr<WeaponAbilitiesGroupConsoleView> _m_ProwGroup = PPtr<WeaponAbilitiesGroupConsoleView>.Read(reader);
        PPtr<WeaponAbilitiesGroupConsoleView> _m_DorsalGroup = PPtr<WeaponAbilitiesGroupConsoleView>.Read(reader);
        PPtr<WeaponAbilitiesGroupConsoleView> _m_StarboardGroup = PPtr<WeaponAbilitiesGroupConsoleView>.Read(reader);
        PPtr<AbilitiesGroupConsoleView> _m_AbilitiesGroup = PPtr<AbilitiesGroupConsoleView>.Read(reader);
        PPtr<AbilitiesGroupConsoleView> _m_SecondAbilitiesGroup = PPtr<AbilitiesGroupConsoleView>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_HintsWidget,
            _m_InspectHint,
            _m_AnimatorObjects,
            _m_TooltipPlace,
            _m_PortGroup,
            _m_ProwGroup,
            _m_DorsalGroup,
            _m_StarboardGroup,
            _m_AbilitiesGroup,
            _m_SecondAbilitiesGroup);
    }
}


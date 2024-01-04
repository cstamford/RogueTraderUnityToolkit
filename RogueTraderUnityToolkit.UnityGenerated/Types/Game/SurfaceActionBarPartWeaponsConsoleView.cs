namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $SurfaceActionBarPartWeaponsConsoleView (8 fields) 94500F5932C11042959A868A86F8383F/400BCDAE0FA29C99D9FBBF2974F389B9 */
public record class SurfaceActionBarPartWeaponsConsoleView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<SurfaceActionBarWeaponSetConsoleView> m_CurrentWeaponSet /* NeedsAlign */,
    PPtr<ConsoleHint> m_ChangeSetSurfaceHint /* None */,
    PPtr<ConsoleHint> m_ChangeSetCombatHint /* None */,
    PPtr<ConsoleHint> m_ChangeSetQuickAccessHint /* None */)
{
    public static SurfaceActionBarPartWeaponsConsoleView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_CurrentWeaponSet */
        PPtr<SurfaceActionBarWeaponSetConsoleView> _m_CurrentWeaponSet = PPtr<SurfaceActionBarWeaponSetConsoleView>.Read(reader);
        PPtr<ConsoleHint> _m_ChangeSetSurfaceHint = PPtr<ConsoleHint>.Read(reader);
        PPtr<ConsoleHint> _m_ChangeSetCombatHint = PPtr<ConsoleHint>.Read(reader);
        PPtr<ConsoleHint> _m_ChangeSetQuickAccessHint = PPtr<ConsoleHint>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_CurrentWeaponSet,
            _m_ChangeSetSurfaceHint,
            _m_ChangeSetCombatHint,
            _m_ChangeSetQuickAccessHint);
    }
}


namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $SurfaceActionBarWeaponSetConsoleView (7 fields) 94CF78FDBB98808A2B3FAB17836AF233/26B9BCAAF86FD1450F8B026D6C29E0EA */
public record class SurfaceActionBarWeaponSetConsoleView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<SurfaceActionBarSlotWeaponConsoleView> m_MainHandWeapon /* NeedsAlign */,
    PPtr<SurfaceActionBarSlotWeaponConsoleView> m_OffHandWeapon /* None */,
    PPtr<TextMeshProUGUI>[] m_WeaponSetIndexes /* None */)
{
    public static SurfaceActionBarWeaponSetConsoleView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_MainHandWeapon */
        PPtr<SurfaceActionBarSlotWeaponConsoleView> _m_MainHandWeapon = PPtr<SurfaceActionBarSlotWeaponConsoleView>.Read(reader);
        PPtr<SurfaceActionBarSlotWeaponConsoleView> _m_OffHandWeapon = PPtr<SurfaceActionBarSlotWeaponConsoleView>.Read(reader);
        PPtr<TextMeshProUGUI>[] _m_WeaponSetIndexes = BuiltInArray<PPtr<TextMeshProUGUI>>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_MainHandWeapon,
            _m_OffHandWeapon,
            _m_WeaponSetIndexes);
    }
}


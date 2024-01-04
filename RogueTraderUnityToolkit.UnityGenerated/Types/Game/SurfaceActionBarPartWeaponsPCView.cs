namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $SurfaceActionBarPartWeaponsPCView (11 fields) C0126E6626C6097F18157932D62BEAF7/FF53F5BD3F3D3F3E4ED6D4A2F58B761A */
public record class SurfaceActionBarPartWeaponsPCView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<SurfaceActionBarWeaponSetPCView> m_CurrentSet /* NeedsAlign */,
    PPtr<SurfaceActionBarWeaponSetPCView> m_WeaponSetPrefab /* None */,
    PPtr<RectTransform> m_WeaponSetsContainer /* None */,
    PPtr<MoveAnimator> m_WeaponSetsMoveAnimator /* None */,
    PPtr<OwlcatMultiButton> m_ConvertButton /* None */,
    PPtr<TextMeshProUGUI> m_HotkeyText /* None */,
    PPtr<GameObject> m_HotkeyContainer /* None */)
{
    public static SurfaceActionBarPartWeaponsPCView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_CurrentSet */
        PPtr<SurfaceActionBarWeaponSetPCView> _m_CurrentSet = PPtr<SurfaceActionBarWeaponSetPCView>.Read(reader);
        PPtr<SurfaceActionBarWeaponSetPCView> _m_WeaponSetPrefab = PPtr<SurfaceActionBarWeaponSetPCView>.Read(reader);
        PPtr<RectTransform> _m_WeaponSetsContainer = PPtr<RectTransform>.Read(reader);
        PPtr<MoveAnimator> _m_WeaponSetsMoveAnimator = PPtr<MoveAnimator>.Read(reader);
        PPtr<OwlcatMultiButton> _m_ConvertButton = PPtr<OwlcatMultiButton>.Read(reader);
        PPtr<TextMeshProUGUI> _m_HotkeyText = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<GameObject> _m_HotkeyContainer = PPtr<GameObject>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_CurrentSet,
            _m_WeaponSetPrefab,
            _m_WeaponSetsContainer,
            _m_WeaponSetsMoveAnimator,
            _m_ConvertButton,
            _m_HotkeyText,
            _m_HotkeyContainer);
    }
}


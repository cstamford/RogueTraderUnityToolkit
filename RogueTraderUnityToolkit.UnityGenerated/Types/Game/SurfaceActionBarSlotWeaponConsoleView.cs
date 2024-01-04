namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $SurfaceActionBarSlotWeaponConsoleView (10 fields) 5AE1A988EDB9B5AFC125B950EDE8AE15/02E9B5FCA58CAA6D31C54CEB60B1DE42 */
public record class SurfaceActionBarSlotWeaponConsoleView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<Image> m_WeaponIcon /* NeedsAlign */,
    ColorRGBA m_FakeColor /* None */,
    ColorRGBA m_NormalColor /* None */,
    PPtr<Sprite> m_UnarmedIcon /* None */,
    PPtr<Image> m_FakeBackground /* None */,
    PPtr<TextMeshProUGUI> m_AmmoCountText /* None */)
{
    public static SurfaceActionBarSlotWeaponConsoleView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_WeaponIcon */
        PPtr<Image> _m_WeaponIcon = PPtr<Image>.Read(reader);
        ColorRGBA _m_FakeColor = ColorRGBA.Read(reader);
        ColorRGBA _m_NormalColor = ColorRGBA.Read(reader);
        PPtr<Sprite> _m_UnarmedIcon = PPtr<Sprite>.Read(reader);
        PPtr<Image> _m_FakeBackground = PPtr<Image>.Read(reader);
        PPtr<TextMeshProUGUI> _m_AmmoCountText = PPtr<TextMeshProUGUI>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_WeaponIcon,
            _m_FakeColor,
            _m_NormalColor,
            _m_UnarmedIcon,
            _m_FakeBackground,
            _m_AmmoCountText);
    }
}


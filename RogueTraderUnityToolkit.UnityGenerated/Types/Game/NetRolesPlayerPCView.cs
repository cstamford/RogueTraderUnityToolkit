namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $NetRolesPlayerPCView (8 fields) CF1A03E3BCFDBED4E0C244750D361709/6E03B54CC5E5E1D50623CBB4DED564D1 */
public record class NetRolesPlayerPCView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<Image> m_PlayerAvatar /* NeedsAlign */,
    PPtr<GameObject> m_MeLayer /* None */,
    PPtr<TextMeshProUGUI> m_PlayerName /* None */,
    PPtr<NetRolesPlayerCharacterPCView>[] m_Characters /* None */)
{
    public static NetRolesPlayerPCView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_PlayerAvatar */
        PPtr<Image> _m_PlayerAvatar = PPtr<Image>.Read(reader);
        PPtr<GameObject> _m_MeLayer = PPtr<GameObject>.Read(reader);
        PPtr<TextMeshProUGUI> _m_PlayerName = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<NetRolesPlayerCharacterPCView>[] _m_Characters = BuiltInArray<PPtr<NetRolesPlayerCharacterPCView>>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_PlayerAvatar,
            _m_MeLayer,
            _m_PlayerName,
            _m_Characters);
    }
}


namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $NetRolesPlayerConsoleView (8 fields) 1ADCB6C19222B1061827BCEB57B954C6/267DC6F158DCD84563ED9B4011D71D81 */
public record class NetRolesPlayerConsoleView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<Image> m_PlayerAvatar /* NeedsAlign */,
    PPtr<GameObject> m_MeLayer /* None */,
    PPtr<TextMeshProUGUI> m_PlayerName /* None */,
    PPtr<NetRolesPlayerCharacterConsoleView>[] m_Characters /* None */)
{
    public static NetRolesPlayerConsoleView Read(EndianBinaryReader reader)
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
        PPtr<NetRolesPlayerCharacterConsoleView>[] _m_Characters = BuiltInArray<PPtr<NetRolesPlayerCharacterConsoleView>>.Read(reader);
        
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


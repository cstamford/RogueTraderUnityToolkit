namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $NetRolesConsoleView (6 fields) 171D3DC38710404EF8C123642D3C9042/0CC3206106213FF2B0E0D02606E8E9F8 */
public record class NetRolesConsoleView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<NetRolesPlayerConsoleView>[] m_Players /* NeedsAlign */,
    PPtr<ConsoleHintsWidget> m_CommonHintsWidget /* None */)
{
    public static NetRolesConsoleView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_Players */
        PPtr<NetRolesPlayerConsoleView>[] _m_Players = BuiltInArray<PPtr<NetRolesPlayerConsoleView>>.Read(reader);
        PPtr<ConsoleHintsWidget> _m_CommonHintsWidget = PPtr<ConsoleHintsWidget>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_Players,
            _m_CommonHintsWidget);
    }
}


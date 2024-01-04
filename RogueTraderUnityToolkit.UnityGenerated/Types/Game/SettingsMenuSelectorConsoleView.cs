namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $SettingsMenuSelectorConsoleView (5 fields) FE0807995747B005DF98F01911055FF3/1A0BD9B14FFC895635AF00020AA64FA8 */
public record class SettingsMenuSelectorConsoleView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<SettingsMenuEntityConsoleView>[] m_MenuEntities /* NeedsAlign */)
{
    public static SettingsMenuSelectorConsoleView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_MenuEntities */
        PPtr<SettingsMenuEntityConsoleView>[] _m_MenuEntities = BuiltInArray<PPtr<SettingsMenuEntityConsoleView>>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_MenuEntities);
    }
}


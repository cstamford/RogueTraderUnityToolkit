namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $FirstLaunchLanguagePageConsoleView (5 fields) 109E217136AD63DC703865F0117DD50A/EF8389D7E0F62090423EE01B5EE3AE75 */
public record class FirstLaunchLanguagePageConsoleView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<FirstLaunchEntityLanguageConsoleView> m_FirstLaunchEntityLanguageConsoleView /* NeedsAlign */)
{
    public static FirstLaunchLanguagePageConsoleView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_FirstLaunchEntityLanguageConsoleView */
        PPtr<FirstLaunchEntityLanguageConsoleView> _m_FirstLaunchEntityLanguageConsoleView = PPtr<FirstLaunchEntityLanguageConsoleView>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_FirstLaunchEntityLanguageConsoleView);
    }
}


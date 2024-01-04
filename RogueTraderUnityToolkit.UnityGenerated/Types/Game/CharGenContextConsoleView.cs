namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $CharGenContextConsoleView (5 fields) A4F2412EAB65A0C80EA07131990AC98D/C6725EAF0B0E1C5D861AF80AD47E5094 */
public record class CharGenContextConsoleView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<CharGenConsoleView> m_CharGenConsoleView /* NeedsAlign */)
{
    public static CharGenContextConsoleView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_CharGenConsoleView */
        PPtr<CharGenConsoleView> _m_CharGenConsoleView = PPtr<CharGenConsoleView>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_CharGenConsoleView);
    }
}


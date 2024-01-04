namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $EscMenuContextConsoleView (5 fields) C40666F5633087D3DE11EF4940B9BF5E/5DC3EB3E4C4D643187ABE41F4228043B */
public record class EscMenuContextConsoleView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<EscMenuConsoleView> m_EscMenuConsoleView /* NeedsAlign */)
{
    public static EscMenuContextConsoleView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_EscMenuConsoleView */
        PPtr<EscMenuConsoleView> _m_EscMenuConsoleView = PPtr<EscMenuConsoleView>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_EscMenuConsoleView);
    }
}


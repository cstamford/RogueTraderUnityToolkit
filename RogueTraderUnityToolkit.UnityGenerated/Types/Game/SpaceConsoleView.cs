namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $SpaceConsoleView (6 fields) D447DA9C4BD75D049F0BE486D5987026/F50CEB5C5E97ADE97174DF51E4E19C0C */
public record class SpaceConsoleView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<SpaceStaticPartConsoleView> m_StaticPartConsoleView /* NeedsAlign */,
    PPtr<SpaceDynamicPartConsoleView> m_DynamicPartConsoleView /* None */)
{
    public static SpaceConsoleView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_StaticPartConsoleView */
        PPtr<SpaceStaticPartConsoleView> _m_StaticPartConsoleView = PPtr<SpaceStaticPartConsoleView>.Read(reader);
        PPtr<SpaceDynamicPartConsoleView> _m_DynamicPartConsoleView = PPtr<SpaceDynamicPartConsoleView>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_StaticPartConsoleView,
            _m_DynamicPartConsoleView);
    }
}


namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $StatCheckLootMainPageConsoleView (6 fields) A44935F50B36F96A75F4D73E60A563BD/80EB98EC0F01F671BDFE06BDBE776FD0 */
public record class StatCheckLootMainPageConsoleView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<StatCheckLootUnitCardConsoleView>[] m_UnitCardSlots /* NeedsAlign */,
    PPtr<ConsoleHintsWidget> m_ConsoleHintsWidget /* None */)
{
    public static StatCheckLootMainPageConsoleView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_UnitCardSlots */
        PPtr<StatCheckLootUnitCardConsoleView>[] _m_UnitCardSlots = BuiltInArray<PPtr<StatCheckLootUnitCardConsoleView>>.Read(reader);
        PPtr<ConsoleHintsWidget> _m_ConsoleHintsWidget = PPtr<ConsoleHintsWidget>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_UnitCardSlots,
            _m_ConsoleHintsWidget);
    }
}


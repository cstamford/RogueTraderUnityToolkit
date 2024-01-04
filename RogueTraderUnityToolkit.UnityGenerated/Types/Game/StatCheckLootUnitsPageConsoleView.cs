namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $StatCheckLootUnitsPageConsoleView (9 fields) 0564F379DFA9DD23FAC1302F28364EF2/58F5CDDFBDB19BA048DE44CBCEC749E1 */
public record class StatCheckLootUnitsPageConsoleView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<TextMeshProUGUI> m_SwitchUnitSubHeaderLabel /* NeedsAlign */,
    PPtr<StatCheckLootUnitCardConsoleView> m_SelectedUnitCardSlot /* None */,
    PPtr<StatCheckLootSmallUnitCardConsoleView>[] m_SmallUnitSlots /* None */,
    PPtr<OwlcatToggleGroup> m_ToggleGroup /* None */,
    PPtr<ConsoleHintsWidget> m_ConsoleHintsWidget /* None */)
{
    public static StatCheckLootUnitsPageConsoleView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_SwitchUnitSubHeaderLabel */
        PPtr<TextMeshProUGUI> _m_SwitchUnitSubHeaderLabel = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<StatCheckLootUnitCardConsoleView> _m_SelectedUnitCardSlot = PPtr<StatCheckLootUnitCardConsoleView>.Read(reader);
        PPtr<StatCheckLootSmallUnitCardConsoleView>[] _m_SmallUnitSlots = BuiltInArray<PPtr<StatCheckLootSmallUnitCardConsoleView>>.Read(reader);
        PPtr<OwlcatToggleGroup> _m_ToggleGroup = PPtr<OwlcatToggleGroup>.Read(reader);
        PPtr<ConsoleHintsWidget> _m_ConsoleHintsWidget = PPtr<ConsoleHintsWidget>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_SwitchUnitSubHeaderLabel,
            _m_SelectedUnitCardSlot,
            _m_SmallUnitSlots,
            _m_ToggleGroup,
            _m_ConsoleHintsWidget);
    }
}


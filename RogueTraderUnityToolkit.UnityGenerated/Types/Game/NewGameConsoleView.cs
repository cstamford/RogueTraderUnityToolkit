namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $NewGameConsoleView (12 fields) 4BA5CC0953C01EAA2140F591C04B6796/FD9026A1B796036A6AA99BEA80BFB627 */
public record class NewGameConsoleView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<NewGameMenuSelectorBaseView> m_Selector /* NeedsAlign */,
    PPtr<NewGamePhaseStoryConsoleView> m_NewGamePhaseStoryConsoleView /* None */,
    PPtr<NewGamePhaseDifficultyConsoleView> m_NewGamePhaseDifficultyConsoleView /* None */,
    PPtr<ConsoleHintsWidget> m_CommonHintsWidget /* None */,
    PPtr<ConsoleHint> m_ConfirmHint /* None */,
    PPtr<ConsoleHint> m_DeclineHint /* None */,
    PPtr<ConsoleHint> m_PrevHint /* None */,
    PPtr<ConsoleHint> m_NextHint /* None */)
{
    public static NewGameConsoleView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_Selector */
        PPtr<NewGameMenuSelectorBaseView> _m_Selector = PPtr<NewGameMenuSelectorBaseView>.Read(reader);
        PPtr<NewGamePhaseStoryConsoleView> _m_NewGamePhaseStoryConsoleView = PPtr<NewGamePhaseStoryConsoleView>.Read(reader);
        PPtr<NewGamePhaseDifficultyConsoleView> _m_NewGamePhaseDifficultyConsoleView = PPtr<NewGamePhaseDifficultyConsoleView>.Read(reader);
        PPtr<ConsoleHintsWidget> _m_CommonHintsWidget = PPtr<ConsoleHintsWidget>.Read(reader);
        PPtr<ConsoleHint> _m_ConfirmHint = PPtr<ConsoleHint>.Read(reader);
        PPtr<ConsoleHint> _m_DeclineHint = PPtr<ConsoleHint>.Read(reader);
        PPtr<ConsoleHint> _m_PrevHint = PPtr<ConsoleHint>.Read(reader);
        PPtr<ConsoleHint> _m_NextHint = PPtr<ConsoleHint>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_Selector,
            _m_NewGamePhaseStoryConsoleView,
            _m_NewGamePhaseDifficultyConsoleView,
            _m_CommonHintsWidget,
            _m_ConfirmHint,
            _m_DeclineHint,
            _m_PrevHint,
            _m_NextHint);
    }
}


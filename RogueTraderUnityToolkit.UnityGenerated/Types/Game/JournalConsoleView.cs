namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $JournalConsoleView (15 fields) 575E95DB105EB8ABC9329ABB21C24A55/3858CBBD46E87234B94C3EE254276A09 */
public record class JournalConsoleView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<PantographView> m_PantographView /* NeedsAlign */,
    PPtr<JournalResourcesBaseView> m_SystemMapSpaceResourcesPCView /* None */,
    PPtr<JournalNavigationConsoleView> m_NavigationView /* None */,
    PPtr<JournalQuestConsoleView> m_QuestView /* None */,
    PPtr<JournalRumourConsoleView> m_RumourView /* None */,
    PPtr<JournalOrderConsoleView> m_OrderView /* None */,
    PPtr<ConsoleHintsWidget> m_ConsoleHintsWidget /* None */,
    PPtr<FlexibleLensSelectorView> m_SelectorView /* None */,
    PPtr<ConsoleHint> m_PrevHint /* None */,
    PPtr<ConsoleHint> m_NextHint /* None */,
    PPtr<CanvasSortingComponent> m_CanvasSortingComponent /* None */)
{
    public static JournalConsoleView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_PantographView */
        PPtr<PantographView> _m_PantographView = PPtr<PantographView>.Read(reader);
        PPtr<JournalResourcesBaseView> _m_SystemMapSpaceResourcesPCView = PPtr<JournalResourcesBaseView>.Read(reader);
        PPtr<JournalNavigationConsoleView> _m_NavigationView = PPtr<JournalNavigationConsoleView>.Read(reader);
        PPtr<JournalQuestConsoleView> _m_QuestView = PPtr<JournalQuestConsoleView>.Read(reader);
        PPtr<JournalRumourConsoleView> _m_RumourView = PPtr<JournalRumourConsoleView>.Read(reader);
        PPtr<JournalOrderConsoleView> _m_OrderView = PPtr<JournalOrderConsoleView>.Read(reader);
        PPtr<ConsoleHintsWidget> _m_ConsoleHintsWidget = PPtr<ConsoleHintsWidget>.Read(reader);
        PPtr<FlexibleLensSelectorView> _m_SelectorView = PPtr<FlexibleLensSelectorView>.Read(reader);
        PPtr<ConsoleHint> _m_PrevHint = PPtr<ConsoleHint>.Read(reader);
        PPtr<ConsoleHint> _m_NextHint = PPtr<ConsoleHint>.Read(reader);
        PPtr<CanvasSortingComponent> _m_CanvasSortingComponent = PPtr<CanvasSortingComponent>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_PantographView,
            _m_SystemMapSpaceResourcesPCView,
            _m_NavigationView,
            _m_QuestView,
            _m_RumourView,
            _m_OrderView,
            _m_ConsoleHintsWidget,
            _m_SelectorView,
            _m_PrevHint,
            _m_NextHint,
            _m_CanvasSortingComponent);
    }
}


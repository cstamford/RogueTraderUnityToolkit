namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $JournalPCView (11 fields) A983A6C2993861908B556D60B0FCE698/86A2447AF5B619A29072A5BA17918914 */
public record class JournalPCView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<PantographView> m_PantographView /* NeedsAlign */,
    PPtr<JournalResourcesBaseView> m_SystemMapSpaceResourcesPCView /* None */,
    PPtr<JournalNavigationPCView> m_NavigationView /* None */,
    PPtr<JournalQuestPCView> m_QuestView /* None */,
    PPtr<JournalRumourPCView> m_RumourView /* None */,
    PPtr<JournalOrderPCView> m_OrderView /* None */,
    PPtr<FlexibleLensSelectorView> m_SelectorView /* None */)
{
    public static JournalPCView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_PantographView */
        PPtr<PantographView> _m_PantographView = PPtr<PantographView>.Read(reader);
        PPtr<JournalResourcesBaseView> _m_SystemMapSpaceResourcesPCView = PPtr<JournalResourcesBaseView>.Read(reader);
        PPtr<JournalNavigationPCView> _m_NavigationView = PPtr<JournalNavigationPCView>.Read(reader);
        PPtr<JournalQuestPCView> _m_QuestView = PPtr<JournalQuestPCView>.Read(reader);
        PPtr<JournalRumourPCView> _m_RumourView = PPtr<JournalRumourPCView>.Read(reader);
        PPtr<JournalOrderPCView> _m_OrderView = PPtr<JournalOrderPCView>.Read(reader);
        PPtr<FlexibleLensSelectorView> _m_SelectorView = PPtr<FlexibleLensSelectorView>.Read(reader);
        
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
            _m_SelectorView);
    }
}


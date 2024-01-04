namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $ColonyManagementPageConsoleView (13 fields) E0DBE805F70A7411A8EFEBAEA0F5F194/492942625E9CCCD2F135C15B92997B9C */
public record class ColonyManagementPageConsoleView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<CanvasGroup> m_ColonyGroup /* NeedsAlign */,
    PPtr<CanvasGroup> m_ProjectsGroup /* None */,
    PPtr<ExplorationSpaceResourcesConsoleView> m_ExplorationSpaceResourcesConsoleView /* None */,
    PPtr<ColonyStatsConsoleView> m_ColonyStatsConsoleView /* None */,
    PPtr<ColonyTraitsConsoleView> m_ColonyTraitsConsoleView /* None */,
    PPtr<ColonyEventsConsoleView> m_ColonyEventsConsoleView /* None */,
    PPtr<ColonyRewardsConsoleView> m_ColonyRewardsConsoleView /* None */,
    PPtr<ColonyProjectsConsoleView> m_ColonyProjectsConsoleView /* None */,
    PPtr<ColonyProjectsBuiltListConsoleView> m_ColonyProjectsBuiltListConsoleView /* None */)
{
    public static ColonyManagementPageConsoleView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_ColonyGroup */
        PPtr<CanvasGroup> _m_ColonyGroup = PPtr<CanvasGroup>.Read(reader);
        PPtr<CanvasGroup> _m_ProjectsGroup = PPtr<CanvasGroup>.Read(reader);
        PPtr<ExplorationSpaceResourcesConsoleView> _m_ExplorationSpaceResourcesConsoleView = PPtr<ExplorationSpaceResourcesConsoleView>.Read(reader);
        PPtr<ColonyStatsConsoleView> _m_ColonyStatsConsoleView = PPtr<ColonyStatsConsoleView>.Read(reader);
        PPtr<ColonyTraitsConsoleView> _m_ColonyTraitsConsoleView = PPtr<ColonyTraitsConsoleView>.Read(reader);
        PPtr<ColonyEventsConsoleView> _m_ColonyEventsConsoleView = PPtr<ColonyEventsConsoleView>.Read(reader);
        PPtr<ColonyRewardsConsoleView> _m_ColonyRewardsConsoleView = PPtr<ColonyRewardsConsoleView>.Read(reader);
        PPtr<ColonyProjectsConsoleView> _m_ColonyProjectsConsoleView = PPtr<ColonyProjectsConsoleView>.Read(reader);
        PPtr<ColonyProjectsBuiltListConsoleView> _m_ColonyProjectsBuiltListConsoleView = PPtr<ColonyProjectsBuiltListConsoleView>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_ColonyGroup,
            _m_ProjectsGroup,
            _m_ExplorationSpaceResourcesConsoleView,
            _m_ColonyStatsConsoleView,
            _m_ColonyTraitsConsoleView,
            _m_ColonyEventsConsoleView,
            _m_ColonyRewardsConsoleView,
            _m_ColonyProjectsConsoleView,
            _m_ColonyProjectsBuiltListConsoleView);
    }
}


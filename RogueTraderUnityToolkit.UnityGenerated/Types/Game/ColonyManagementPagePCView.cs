namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $ColonyManagementPagePCView (14 fields) 94C4E9D1D66E5937EE76774ECE79EA94/D7791361993E20CE9F2A6F195B342AFF */
public record class ColonyManagementPagePCView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<CanvasGroup> m_ColonyGroup /* NeedsAlign */,
    PPtr<CanvasGroup> m_ProjectsGroup /* None */,
    PPtr<ExplorationSpaceResourcesPCView> m_ExplorationSpaceResourcesPCView /* None */,
    PPtr<ColonyStatsPCView> m_ColonyStatsView /* None */,
    PPtr<ColonyTraitsPCView> m_ColonyTraitsPCView /* None */,
    PPtr<ColonyEventsPCView> m_ColonyEventsPCView /* None */,
    PPtr<ColonyRewardsPCView> m_ColonyRewardsPCView /* None */,
    PPtr<ColonyProjectsPCView> m_ColonyProjectsView /* None */,
    PPtr<ColonyProjectsButtonPCView> m_ColonyProjectsButtonView /* None */,
    PPtr<ColonyProjectsBuiltListPCView> m_ColonyProjectsBuiltListView /* None */)
{
    public static ColonyManagementPagePCView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_ColonyGroup */
        PPtr<CanvasGroup> _m_ColonyGroup = PPtr<CanvasGroup>.Read(reader);
        PPtr<CanvasGroup> _m_ProjectsGroup = PPtr<CanvasGroup>.Read(reader);
        PPtr<ExplorationSpaceResourcesPCView> _m_ExplorationSpaceResourcesPCView = PPtr<ExplorationSpaceResourcesPCView>.Read(reader);
        PPtr<ColonyStatsPCView> _m_ColonyStatsView = PPtr<ColonyStatsPCView>.Read(reader);
        PPtr<ColonyTraitsPCView> _m_ColonyTraitsPCView = PPtr<ColonyTraitsPCView>.Read(reader);
        PPtr<ColonyEventsPCView> _m_ColonyEventsPCView = PPtr<ColonyEventsPCView>.Read(reader);
        PPtr<ColonyRewardsPCView> _m_ColonyRewardsPCView = PPtr<ColonyRewardsPCView>.Read(reader);
        PPtr<ColonyProjectsPCView> _m_ColonyProjectsView = PPtr<ColonyProjectsPCView>.Read(reader);
        PPtr<ColonyProjectsButtonPCView> _m_ColonyProjectsButtonView = PPtr<ColonyProjectsButtonPCView>.Read(reader);
        PPtr<ColonyProjectsBuiltListPCView> _m_ColonyProjectsBuiltListView = PPtr<ColonyProjectsBuiltListPCView>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_ColonyGroup,
            _m_ProjectsGroup,
            _m_ExplorationSpaceResourcesPCView,
            _m_ColonyStatsView,
            _m_ColonyTraitsPCView,
            _m_ColonyEventsPCView,
            _m_ColonyRewardsPCView,
            _m_ColonyProjectsView,
            _m_ColonyProjectsButtonView,
            _m_ColonyProjectsBuiltListView);
    }
}


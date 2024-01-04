namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $ColonyProjectsPageConsoleView (15 fields) C1E403824AA17CC4FDE8A186512BBF08/1004B96466AEBD20808E4FF9620BFF31 */
public record class ColonyProjectsPageConsoleView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<Image> m_Icon /* NeedsAlign */,
    PPtr<TextMeshProUGUI> m_Title /* None */,
    PPtr<TextMeshProUGUI> m_Description /* None */,
    PPtr<TextMeshProUGUI> m_RewardsTitle /* None */,
    PPtr<WidgetListMVVM> m_RewardsWidgetList /* None */,
    PPtr<ScrollRectExtended> m_RewardsScrollRect /* None */,
    PPtr<TextMeshProUGUI> m_RequirementsTitle /* None */,
    PPtr<WidgetListMVVM> m_RequirementsWidgetList /* None */,
    PPtr<ScrollRectExtended> m_RequirementsScrollRect /* None */,
    PPtr<ColonyProjectsRewardElementConsoleView> m_RewardsViewPrefab /* None */,
    PPtr<ColonyProjectsRequirementElementConsoleView> m_RequirementsViewPrefab /* None */)
{
    public static ColonyProjectsPageConsoleView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_Icon */
        PPtr<Image> _m_Icon = PPtr<Image>.Read(reader);
        PPtr<TextMeshProUGUI> _m_Title = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<TextMeshProUGUI> _m_Description = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<TextMeshProUGUI> _m_RewardsTitle = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<WidgetListMVVM> _m_RewardsWidgetList = PPtr<WidgetListMVVM>.Read(reader);
        PPtr<ScrollRectExtended> _m_RewardsScrollRect = PPtr<ScrollRectExtended>.Read(reader);
        PPtr<TextMeshProUGUI> _m_RequirementsTitle = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<WidgetListMVVM> _m_RequirementsWidgetList = PPtr<WidgetListMVVM>.Read(reader);
        PPtr<ScrollRectExtended> _m_RequirementsScrollRect = PPtr<ScrollRectExtended>.Read(reader);
        PPtr<ColonyProjectsRewardElementConsoleView> _m_RewardsViewPrefab = PPtr<ColonyProjectsRewardElementConsoleView>.Read(reader);
        PPtr<ColonyProjectsRequirementElementConsoleView> _m_RequirementsViewPrefab = PPtr<ColonyProjectsRequirementElementConsoleView>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_Icon,
            _m_Title,
            _m_Description,
            _m_RewardsTitle,
            _m_RewardsWidgetList,
            _m_RewardsScrollRect,
            _m_RequirementsTitle,
            _m_RequirementsWidgetList,
            _m_RequirementsScrollRect,
            _m_RewardsViewPrefab,
            _m_RequirementsViewPrefab);
    }
}


namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $ColonyProjectsPagePCView (15 fields) A67FF8936F78720F4B7AC67337191244/235F1114AD5B5B0A36DA226AC626BADD */
public record class ColonyProjectsPagePCView(
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
    PPtr<ColonyProjectsRewardElementPCView> m_RewardsViewPrefab /* None */,
    PPtr<ColonyProjectsRequirementElementPCView> m_RequirementsViewPrefab /* None */)
{
    public static ColonyProjectsPagePCView Read(EndianBinaryReader reader)
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
        PPtr<ColonyProjectsRewardElementPCView> _m_RewardsViewPrefab = PPtr<ColonyProjectsRewardElementPCView>.Read(reader);
        PPtr<ColonyProjectsRequirementElementPCView> _m_RequirementsViewPrefab = PPtr<ColonyProjectsRequirementElementPCView>.Read(reader);
        
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


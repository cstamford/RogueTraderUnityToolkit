namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $JournalNavigationGroupPCView (9 fields) F6D4FC5EEE2D533C643A5EBA1B358043/6651F6FA16896EF83D5F8C689BCFB3FC */
public record class JournalNavigationGroupPCView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<TextMeshProUGUI> m_Label /* NeedsAlign */,
    PPtr<OwlcatMultiButton> m_MultiButton /* None */,
    PPtr<WidgetListMVVM> m_WidgetList /* None */,
    PPtr<ExpandableCollapseMultiButtonPC> m_ExpandableCollapseMultiButton /* None */,
    PPtr<JournalNavigationGroupElementPCView> NavigationGroupElementViewPrefab /* None */)
{
    public static JournalNavigationGroupPCView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_Label */
        PPtr<TextMeshProUGUI> _m_Label = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<OwlcatMultiButton> _m_MultiButton = PPtr<OwlcatMultiButton>.Read(reader);
        PPtr<WidgetListMVVM> _m_WidgetList = PPtr<WidgetListMVVM>.Read(reader);
        PPtr<ExpandableCollapseMultiButtonPC> _m_ExpandableCollapseMultiButton = PPtr<ExpandableCollapseMultiButtonPC>.Read(reader);
        PPtr<JournalNavigationGroupElementPCView> _NavigationGroupElementViewPrefab = PPtr<JournalNavigationGroupElementPCView>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_Label,
            _m_MultiButton,
            _m_WidgetList,
            _m_ExpandableCollapseMultiButton,
            _NavigationGroupElementViewPrefab);
    }
}


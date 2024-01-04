namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $JournalNavigationGroupConsoleView (9 fields) ED2151242836000A495296473532CE2B/2587D0E74BFDD6A17F83F37CDBFB78E4 */
public record class JournalNavigationGroupConsoleView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<TextMeshProUGUI> m_Label /* NeedsAlign */,
    PPtr<OwlcatMultiButton> m_MultiButton /* None */,
    PPtr<WidgetListMVVM> m_WidgetList /* None */,
    PPtr<ExpandableCollapseMultiButtonConsole> m_ExpandableCollapseMultiButton /* None */,
    PPtr<JournalNavigationGroupElementConsoleView> NavigationGroupElementViewPrefab /* None */)
{
    public static JournalNavigationGroupConsoleView Read(EndianBinaryReader reader)
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
        PPtr<ExpandableCollapseMultiButtonConsole> _m_ExpandableCollapseMultiButton = PPtr<ExpandableCollapseMultiButtonConsole>.Read(reader);
        PPtr<JournalNavigationGroupElementConsoleView> _NavigationGroupElementViewPrefab = PPtr<JournalNavigationGroupElementConsoleView>.Read(reader);
        
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


namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $ColonyManagementConsoleView (19 fields) F7C0D5703DA74C762EB66B89B9ED8BA4/4C16C6E7C95844D0817A3911B5729C87 */
public record class ColonyManagementConsoleView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<GameObject> m_Content /* NeedsAlign */,
    PPtr<GameObject> m_NoDataContent /* None */,
    PPtr<TextMeshProUGUI> m_NoColoniesLabel /* None */,
    PPtr<FlexibleLensSelectorView> m_SelectorView /* None */,
    PPtr<GameObject>[] m_ObjectsToHideForDialog /* None */,
    PPtr<CanvasGroup> m_DialogOverlay /* None */,
    PPtr<DollRoomTargetController> m_CharacterController /* None */,
    PPtr<GameObject> m_BackupPlanet /* None */,
    NavigationParameters m_PointsNavigationParameters /* None */,
    PPtr<ColonyManagementNavigationConsoleView> m_Navigation /* NeedsAlign */,
    PPtr<ColonyManagementPageConsoleView> m_Page /* None */,
    PPtr<ConsoleHintsWidget> m_ConsoleHintsWidget /* None */,
    PPtr<ConsoleHint> m_PrevHint /* None */,
    PPtr<ConsoleHint> m_NextHint /* None */,
    NavigationBlockHighlight m_NavigationBlockHighlights /* None */)
{
    public static ColonyManagementConsoleView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_Content */
        PPtr<GameObject> _m_Content = PPtr<GameObject>.Read(reader);
        PPtr<GameObject> _m_NoDataContent = PPtr<GameObject>.Read(reader);
        PPtr<TextMeshProUGUI> _m_NoColoniesLabel = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<FlexibleLensSelectorView> _m_SelectorView = PPtr<FlexibleLensSelectorView>.Read(reader);
        PPtr<GameObject>[] _m_ObjectsToHideForDialog = BuiltInArray<PPtr<GameObject>>.Read(reader);
        PPtr<CanvasGroup> _m_DialogOverlay = PPtr<CanvasGroup>.Read(reader);
        PPtr<DollRoomTargetController> _m_CharacterController = PPtr<DollRoomTargetController>.Read(reader);
        PPtr<GameObject> _m_BackupPlanet = PPtr<GameObject>.Read(reader);
        NavigationParameters _m_PointsNavigationParameters = NavigationParameters.Read(reader);
        reader.AlignTo(4); /* m_Navigation */
        PPtr<ColonyManagementNavigationConsoleView> _m_Navigation = PPtr<ColonyManagementNavigationConsoleView>.Read(reader);
        PPtr<ColonyManagementPageConsoleView> _m_Page = PPtr<ColonyManagementPageConsoleView>.Read(reader);
        PPtr<ConsoleHintsWidget> _m_ConsoleHintsWidget = PPtr<ConsoleHintsWidget>.Read(reader);
        PPtr<ConsoleHint> _m_PrevHint = PPtr<ConsoleHint>.Read(reader);
        PPtr<ConsoleHint> _m_NextHint = PPtr<ConsoleHint>.Read(reader);
        NavigationBlockHighlight _m_NavigationBlockHighlights = NavigationBlockHighlight.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_Content,
            _m_NoDataContent,
            _m_NoColoniesLabel,
            _m_SelectorView,
            _m_ObjectsToHideForDialog,
            _m_DialogOverlay,
            _m_CharacterController,
            _m_BackupPlanet,
            _m_PointsNavigationParameters,
            _m_Navigation,
            _m_Page,
            _m_ConsoleHintsWidget,
            _m_PrevHint,
            _m_NextHint,
            _m_NavigationBlockHighlights);
    }
}


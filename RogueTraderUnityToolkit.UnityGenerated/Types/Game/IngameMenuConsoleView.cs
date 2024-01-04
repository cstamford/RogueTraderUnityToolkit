namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $IngameMenuConsoleView (19 fields) 282A8057A50382DE5CA577B87A35DEF2/255484E718B0FD9392E24923B25C922E */
public record class IngameMenuConsoleView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<IngameMenuItemConsoleView> m_Inventory /* NeedsAlign */,
    PPtr<IngameMenuItemConsoleView> m_Character /* None */,
    PPtr<IngameMenuItemConsoleView> m_Journal /* None */,
    PPtr<IngameMenuItemConsoleView> m_Map /* None */,
    PPtr<IngameMenuItemConsoleView> m_Encyclopedia /* None */,
    PPtr<IngameMenuItemConsoleView> m_ShipCustomization /* None */,
    PPtr<IngameMenuItemConsoleView> m_ColonyManagement /* None */,
    PPtr<IngameMenuItemConsoleView> m_LevelUp /* None */,
    PPtr<IngameMenuItemConsoleView> m_VoidshipLevelUp /* None */,
    PPtr<IngameMenuItemConsoleView> m_CargoManagement /* None */,
    PPtr<RectTransform> m_Content /* None */,
    PPtr<FadeAnimator> m_FadeAnimator /* None */,
    NavigationParameters m_Parameters /* None */,
    PPtr<ConsoleHintsWidget> m_ConsoleHintsWidget /* NeedsAlign */,
    PPtr<OwlcatMultiButton> m_FirstSelectionButton /* None */)
{
    public static IngameMenuConsoleView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_Inventory */
        PPtr<IngameMenuItemConsoleView> _m_Inventory = PPtr<IngameMenuItemConsoleView>.Read(reader);
        PPtr<IngameMenuItemConsoleView> _m_Character = PPtr<IngameMenuItemConsoleView>.Read(reader);
        PPtr<IngameMenuItemConsoleView> _m_Journal = PPtr<IngameMenuItemConsoleView>.Read(reader);
        PPtr<IngameMenuItemConsoleView> _m_Map = PPtr<IngameMenuItemConsoleView>.Read(reader);
        PPtr<IngameMenuItemConsoleView> _m_Encyclopedia = PPtr<IngameMenuItemConsoleView>.Read(reader);
        PPtr<IngameMenuItemConsoleView> _m_ShipCustomization = PPtr<IngameMenuItemConsoleView>.Read(reader);
        PPtr<IngameMenuItemConsoleView> _m_ColonyManagement = PPtr<IngameMenuItemConsoleView>.Read(reader);
        PPtr<IngameMenuItemConsoleView> _m_LevelUp = PPtr<IngameMenuItemConsoleView>.Read(reader);
        PPtr<IngameMenuItemConsoleView> _m_VoidshipLevelUp = PPtr<IngameMenuItemConsoleView>.Read(reader);
        PPtr<IngameMenuItemConsoleView> _m_CargoManagement = PPtr<IngameMenuItemConsoleView>.Read(reader);
        PPtr<RectTransform> _m_Content = PPtr<RectTransform>.Read(reader);
        PPtr<FadeAnimator> _m_FadeAnimator = PPtr<FadeAnimator>.Read(reader);
        NavigationParameters _m_Parameters = NavigationParameters.Read(reader);
        reader.AlignTo(4); /* m_ConsoleHintsWidget */
        PPtr<ConsoleHintsWidget> _m_ConsoleHintsWidget = PPtr<ConsoleHintsWidget>.Read(reader);
        PPtr<OwlcatMultiButton> _m_FirstSelectionButton = PPtr<OwlcatMultiButton>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_Inventory,
            _m_Character,
            _m_Journal,
            _m_Map,
            _m_Encyclopedia,
            _m_ShipCustomization,
            _m_ColonyManagement,
            _m_LevelUp,
            _m_VoidshipLevelUp,
            _m_CargoManagement,
            _m_Content,
            _m_FadeAnimator,
            _m_Parameters,
            _m_ConsoleHintsWidget,
            _m_FirstSelectionButton);
    }
}


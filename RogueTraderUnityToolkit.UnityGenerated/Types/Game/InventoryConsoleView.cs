namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $InventoryConsoleView (19 fields) F6541EC17A41AE9B091B829563B945FB/27CD381A9E26208BB5845858755EE7D7 */
public record class InventoryConsoleView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<RectTransform> m_LeftCanvas /* NeedsAlign */,
    PPtr<RectTransform> m_RightCanvas /* None */,
    float m_MoveAnimationTime /* None */,
    PPtr<CharInfoNameAndPortraitPCView> m_NameAndPortraitPCView /* None */,
    PPtr<CharInfoLevelClassScoresPCView> m_LevelClassScoresView /* None */,
    PPtr<CharInfoSkillsAndWeaponsBaseView> m_SkillsAndWeaponsView /* None */,
    PPtr<InventoryDollConsoleView> m_DollView /* None */,
    PPtr<InventoryStashConsoleView> m_StashView /* None */,
    PPtr<ConsoleHintsWidget> m_ConsoleHintsWidget /* None */,
    PPtr<RectTransform> m_TooltipPlaceLeft /* None */,
    PPtr<RectTransform> m_TooltipPlaceRight /* None */,
    float m_FocusedRotation /* None */,
    float m_FocusedOffsetX /* None */,
    float m_FocusTweenTime /* None */,
    PPtr<CanvasSortingComponent> m_CanvasSortingComponent /* None */)
{
    public static InventoryConsoleView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_LeftCanvas */
        PPtr<RectTransform> _m_LeftCanvas = PPtr<RectTransform>.Read(reader);
        PPtr<RectTransform> _m_RightCanvas = PPtr<RectTransform>.Read(reader);
        float _m_MoveAnimationTime = reader.ReadF32();
        PPtr<CharInfoNameAndPortraitPCView> _m_NameAndPortraitPCView = PPtr<CharInfoNameAndPortraitPCView>.Read(reader);
        PPtr<CharInfoLevelClassScoresPCView> _m_LevelClassScoresView = PPtr<CharInfoLevelClassScoresPCView>.Read(reader);
        PPtr<CharInfoSkillsAndWeaponsBaseView> _m_SkillsAndWeaponsView = PPtr<CharInfoSkillsAndWeaponsBaseView>.Read(reader);
        PPtr<InventoryDollConsoleView> _m_DollView = PPtr<InventoryDollConsoleView>.Read(reader);
        PPtr<InventoryStashConsoleView> _m_StashView = PPtr<InventoryStashConsoleView>.Read(reader);
        PPtr<ConsoleHintsWidget> _m_ConsoleHintsWidget = PPtr<ConsoleHintsWidget>.Read(reader);
        PPtr<RectTransform> _m_TooltipPlaceLeft = PPtr<RectTransform>.Read(reader);
        PPtr<RectTransform> _m_TooltipPlaceRight = PPtr<RectTransform>.Read(reader);
        float _m_FocusedRotation = reader.ReadF32();
        float _m_FocusedOffsetX = reader.ReadF32();
        float _m_FocusTweenTime = reader.ReadF32();
        PPtr<CanvasSortingComponent> _m_CanvasSortingComponent = PPtr<CanvasSortingComponent>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_LeftCanvas,
            _m_RightCanvas,
            _m_MoveAnimationTime,
            _m_NameAndPortraitPCView,
            _m_LevelClassScoresView,
            _m_SkillsAndWeaponsView,
            _m_DollView,
            _m_StashView,
            _m_ConsoleHintsWidget,
            _m_TooltipPlaceLeft,
            _m_TooltipPlaceRight,
            _m_FocusedRotation,
            _m_FocusedOffsetX,
            _m_FocusTweenTime,
            _m_CanvasSortingComponent);
    }
}


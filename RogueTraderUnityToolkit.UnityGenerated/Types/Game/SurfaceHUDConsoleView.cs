namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $SurfaceHUDConsoleView (30 fields) DA0DC20667704B6D1A5619352560441E/25CECA7C1C1B2EA52B9E9193725EE40E */
public record class SurfaceHUDConsoleView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<IngameMenuConsoleView> m_IngameMenuConsoleView /* NeedsAlign */,
    PPtr<PartyConsoleView> m_PartyConsoleView /* None */,
    PPtr<PartySelectorConsoleView> m_PartySelectorConsoleView /* None */,
    PPtr<SurfaceCombatCurrentUnitView> m_SurfaceCombatCurrentUnitView /* None */,
    PPtr<SurfaceActionBarConsoleView> m_ActionBarConsoleView /* None */,
    PPtr<InitiativeTrackerVerticalConsoleView> m_InitiativeTrackerView /* None */,
    PPtr<InspectConsoleView> m_InspectConsoleView /* None */,
    PPtr<CombatStartWindowConsoleView> m_CombatStartWindowView /* None */,
    PPtr<CombatLogConsoleView> m_CombatLogConsoleView /* None */,
    PPtr<MoveAnimator> m_CombatLogPositionAnimator /* None */,
    PPtr<ConsoleHint> m_SkipCutsceneHint /* None */,
    PPtr<FadeAnimator> m_SkipCutsceneHintHolderFade /* None */,
    PPtr<ConsoleHint> m_PauseGameHint /* None */,
    PPtr<FadeAnimator> m_AdditionalHintsContainer /* None */,
    float m_HintsDisappearTime /* None */,
    PPtr<ConsoleHint> m_ChangeCameraRotateModeHint /* None */,
    PPtr<ConsoleHint> m_FocusOnCurrentUnitHint /* None */,
    PPtr<ConsoleHint> m_SwitchCursorHint /* None */,
    PPtr<ConsoleHint> m_OpenMapHint /* None */,
    PPtr<ConsoleHint> m_SwitchHighlightHint /* None */,
    PPtr<ConsoleHint> m_CoopRolesHint /* None */,
    PPtr<ConsoleHint> m_FocusOnCurrentUnitCombatHint /* None */,
    PPtr<ConsoleHint> m_HighlightObjectsCombatHint /* None */,
    PPtr<ConsoleHint> m_EndTurnCombatHint /* None */,
    PPtr<ConsoleHint> m_StartBattleHint /* None */,
    PPtr<Image> m_NetRolesAttentionMark /* None */)
{
    public static SurfaceHUDConsoleView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_IngameMenuConsoleView */
        PPtr<IngameMenuConsoleView> _m_IngameMenuConsoleView = PPtr<IngameMenuConsoleView>.Read(reader);
        PPtr<PartyConsoleView> _m_PartyConsoleView = PPtr<PartyConsoleView>.Read(reader);
        PPtr<PartySelectorConsoleView> _m_PartySelectorConsoleView = PPtr<PartySelectorConsoleView>.Read(reader);
        PPtr<SurfaceCombatCurrentUnitView> _m_SurfaceCombatCurrentUnitView = PPtr<SurfaceCombatCurrentUnitView>.Read(reader);
        PPtr<SurfaceActionBarConsoleView> _m_ActionBarConsoleView = PPtr<SurfaceActionBarConsoleView>.Read(reader);
        PPtr<InitiativeTrackerVerticalConsoleView> _m_InitiativeTrackerView = PPtr<InitiativeTrackerVerticalConsoleView>.Read(reader);
        PPtr<InspectConsoleView> _m_InspectConsoleView = PPtr<InspectConsoleView>.Read(reader);
        PPtr<CombatStartWindowConsoleView> _m_CombatStartWindowView = PPtr<CombatStartWindowConsoleView>.Read(reader);
        PPtr<CombatLogConsoleView> _m_CombatLogConsoleView = PPtr<CombatLogConsoleView>.Read(reader);
        PPtr<MoveAnimator> _m_CombatLogPositionAnimator = PPtr<MoveAnimator>.Read(reader);
        PPtr<ConsoleHint> _m_SkipCutsceneHint = PPtr<ConsoleHint>.Read(reader);
        PPtr<FadeAnimator> _m_SkipCutsceneHintHolderFade = PPtr<FadeAnimator>.Read(reader);
        PPtr<ConsoleHint> _m_PauseGameHint = PPtr<ConsoleHint>.Read(reader);
        PPtr<FadeAnimator> _m_AdditionalHintsContainer = PPtr<FadeAnimator>.Read(reader);
        float _m_HintsDisappearTime = reader.ReadF32();
        PPtr<ConsoleHint> _m_ChangeCameraRotateModeHint = PPtr<ConsoleHint>.Read(reader);
        PPtr<ConsoleHint> _m_FocusOnCurrentUnitHint = PPtr<ConsoleHint>.Read(reader);
        PPtr<ConsoleHint> _m_SwitchCursorHint = PPtr<ConsoleHint>.Read(reader);
        PPtr<ConsoleHint> _m_OpenMapHint = PPtr<ConsoleHint>.Read(reader);
        PPtr<ConsoleHint> _m_SwitchHighlightHint = PPtr<ConsoleHint>.Read(reader);
        PPtr<ConsoleHint> _m_CoopRolesHint = PPtr<ConsoleHint>.Read(reader);
        PPtr<ConsoleHint> _m_FocusOnCurrentUnitCombatHint = PPtr<ConsoleHint>.Read(reader);
        PPtr<ConsoleHint> _m_HighlightObjectsCombatHint = PPtr<ConsoleHint>.Read(reader);
        PPtr<ConsoleHint> _m_EndTurnCombatHint = PPtr<ConsoleHint>.Read(reader);
        PPtr<ConsoleHint> _m_StartBattleHint = PPtr<ConsoleHint>.Read(reader);
        PPtr<Image> _m_NetRolesAttentionMark = PPtr<Image>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_IngameMenuConsoleView,
            _m_PartyConsoleView,
            _m_PartySelectorConsoleView,
            _m_SurfaceCombatCurrentUnitView,
            _m_ActionBarConsoleView,
            _m_InitiativeTrackerView,
            _m_InspectConsoleView,
            _m_CombatStartWindowView,
            _m_CombatLogConsoleView,
            _m_CombatLogPositionAnimator,
            _m_SkipCutsceneHint,
            _m_SkipCutsceneHintHolderFade,
            _m_PauseGameHint,
            _m_AdditionalHintsContainer,
            _m_HintsDisappearTime,
            _m_ChangeCameraRotateModeHint,
            _m_FocusOnCurrentUnitHint,
            _m_SwitchCursorHint,
            _m_OpenMapHint,
            _m_SwitchHighlightHint,
            _m_CoopRolesHint,
            _m_FocusOnCurrentUnitCombatHint,
            _m_HighlightObjectsCombatHint,
            _m_EndTurnCombatHint,
            _m_StartBattleHint,
            _m_NetRolesAttentionMark);
    }
}


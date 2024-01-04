namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $SurfaceHUDPCView (20 fields) 10B7FBF36A1EE7AE75B27FED5D171FCF/A175A47066EF5337F967B34FF06AD619 */
public record class SurfaceHUDPCView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<OwlcatMultiButton> m_EndTurnButton /* NeedsAlign */,
    PPtr<MoveAnimator> m_EndTurnButtonAnimator /* None */,
    PPtr<TextMeshProUGUI> m_EndTurnBindText /* None */,
    PPtr<InitiativeTrackerView> m_InitiativeTrackerView /* None */,
    PPtr<CombatStartWindowPCView> m_CombatStartWindowView /* None */,
    PPtr<InspectPCView> m_InspectPCView /* None */,
    PPtr<CombatLogPCView> m_CombatLogPCView /* None */,
    PPtr<IngameMenuNewPCView> m_IngameMenuPCView /* None */,
    PPtr<IngameMenuSettingsButtonPCView> m_IngameMenuSettingsButtonPCView /* None */,
    PPtr<PartyPCView> m_PartyPCView /* None */,
    PPtr<SurfaceCombatCurrentUnitView> m_SurfaceCombatCurrentUnitView /* None */,
    PPtr<SurfaceActionBarPCView> m_ActionBarView /* None */,
    PPtr<TextMeshProUGUI> m_SkipText /* None */,
    ColorRGBA m_SkipHintColor /* None */,
    PPtr<Image> m_FillImage /* None */,
    PPtr<FadeAnimator> m_SkipCutsceneHintHolderFade /* None */)
{
    public static SurfaceHUDPCView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_EndTurnButton */
        PPtr<OwlcatMultiButton> _m_EndTurnButton = PPtr<OwlcatMultiButton>.Read(reader);
        PPtr<MoveAnimator> _m_EndTurnButtonAnimator = PPtr<MoveAnimator>.Read(reader);
        PPtr<TextMeshProUGUI> _m_EndTurnBindText = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<InitiativeTrackerView> _m_InitiativeTrackerView = PPtr<InitiativeTrackerView>.Read(reader);
        PPtr<CombatStartWindowPCView> _m_CombatStartWindowView = PPtr<CombatStartWindowPCView>.Read(reader);
        PPtr<InspectPCView> _m_InspectPCView = PPtr<InspectPCView>.Read(reader);
        PPtr<CombatLogPCView> _m_CombatLogPCView = PPtr<CombatLogPCView>.Read(reader);
        PPtr<IngameMenuNewPCView> _m_IngameMenuPCView = PPtr<IngameMenuNewPCView>.Read(reader);
        PPtr<IngameMenuSettingsButtonPCView> _m_IngameMenuSettingsButtonPCView = PPtr<IngameMenuSettingsButtonPCView>.Read(reader);
        PPtr<PartyPCView> _m_PartyPCView = PPtr<PartyPCView>.Read(reader);
        PPtr<SurfaceCombatCurrentUnitView> _m_SurfaceCombatCurrentUnitView = PPtr<SurfaceCombatCurrentUnitView>.Read(reader);
        PPtr<SurfaceActionBarPCView> _m_ActionBarView = PPtr<SurfaceActionBarPCView>.Read(reader);
        PPtr<TextMeshProUGUI> _m_SkipText = PPtr<TextMeshProUGUI>.Read(reader);
        ColorRGBA _m_SkipHintColor = ColorRGBA.Read(reader);
        PPtr<Image> _m_FillImage = PPtr<Image>.Read(reader);
        PPtr<FadeAnimator> _m_SkipCutsceneHintHolderFade = PPtr<FadeAnimator>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_EndTurnButton,
            _m_EndTurnButtonAnimator,
            _m_EndTurnBindText,
            _m_InitiativeTrackerView,
            _m_CombatStartWindowView,
            _m_InspectPCView,
            _m_CombatLogPCView,
            _m_IngameMenuPCView,
            _m_IngameMenuSettingsButtonPCView,
            _m_PartyPCView,
            _m_SurfaceCombatCurrentUnitView,
            _m_ActionBarView,
            _m_SkipText,
            _m_SkipHintColor,
            _m_FillImage,
            _m_SkipCutsceneHintHolderFade);
    }
}


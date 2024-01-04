namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $SurfaceCombatUnitOrderVerticalConsoleView (39 fields) D49569EAD03A5D24C05D483DD22782B0/118A9139481F02E342413F1C4A47B48E */
public record class SurfaceCombatUnitOrderVerticalConsoleView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<OwlcatMultiButton> Button /* NeedsAlign */,
    PPtr<SurfaceCombatUnitPortraitZone> m_CharacetrPortraitZone /* None */,
    PPtr<GameObject> m_DifficultyBlock /* None */,
    PPtr<TextMeshProUGUI> m_DifficultyText /* None */,
    PPtr<SurfaceCombatUnitPortraitZone> m_NoPortraitZone /* None */,
    PPtr<UnitHealthPartTextPCView> UnitHealthPartTextPCView /* None */,
    PPtr<UnitHealthPartProgressPCView> UnitHealthPartProgressPCView /* None */,
    PPtr<TextMeshProUGUI> m_NameNormal /* None */,
    PPtr<UnitBuffPartPCView> UnitBuffPartPCView /* None */,
    byte HasMarkers /* None */,
    PPtr<GameObject> m_WillLossTurn /* NeedsAlign */,
    PPtr<GameObject> m_HasLossControlEffectsIcon /* None */,
    PPtr<GameObject> m_UnableToActNormaly /* None */,
    PPtr<ColorAnimator>[] m_ColorAnimator /* None */,
    PPtr<CanvasGroup> m_CanvasGroup /* None */,
    Vector2f SizeWithPortrait /* None */,
    Vector2f SizeWithSquad /* None */,
    Vector2f SizeRound /* None */,
    byte HasHitChances /* None */,
    PPtr<InitiativeTrackerUnitHitChanceView> InitiativeTrackerUnitHitChanceView /* NeedsAlign */,
    byte m_HasRoundBlock /* None */,
    PPtr<InitiativeTrackerEndOfRound> m_EndOfRound /* NeedsAlign */,
    PPtr<GameObject> m_UnitContainer /* None */,
    PPtr<FadeAnimator> m_HPLabelAnimator /* None */,
    PPtr<FadeAnimator> m_NameZoneAnimator /* None */,
    byte WillBeDestroyedExternal /* None */,
    PPtr<SurfaceCombatInitiativeOrderSquadUnitView> m_SurfaceCombatInitiativeOrderSquadUnitViewPrefab /* NeedsAlign */,
    PPtr<WidgetList> m_WidgetList /* None */,
    PPtr<OwlcatMultiButton> m_SquadButton /* None */,
    PPtr<GameObject> m_SquadNumContainer /* None */,
    PPtr<TextMeshProUGUI> m_SquadNumber /* None */,
    float m_AnimationTime /* None */,
    float m_Scale /* None */,
    PPtr<DisintegrationAnimator>[] m_DisintegrationAnimator /* None */,
    PPtr<OwlcatMultiButton> m_Button /* None */)
{
    public static SurfaceCombatUnitOrderVerticalConsoleView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* Button */
        PPtr<OwlcatMultiButton> _Button = PPtr<OwlcatMultiButton>.Read(reader);
        PPtr<SurfaceCombatUnitPortraitZone> _m_CharacetrPortraitZone = PPtr<SurfaceCombatUnitPortraitZone>.Read(reader);
        PPtr<GameObject> _m_DifficultyBlock = PPtr<GameObject>.Read(reader);
        PPtr<TextMeshProUGUI> _m_DifficultyText = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<SurfaceCombatUnitPortraitZone> _m_NoPortraitZone = PPtr<SurfaceCombatUnitPortraitZone>.Read(reader);
        PPtr<UnitHealthPartTextPCView> _UnitHealthPartTextPCView = PPtr<UnitHealthPartTextPCView>.Read(reader);
        PPtr<UnitHealthPartProgressPCView> _UnitHealthPartProgressPCView = PPtr<UnitHealthPartProgressPCView>.Read(reader);
        PPtr<TextMeshProUGUI> _m_NameNormal = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<UnitBuffPartPCView> _UnitBuffPartPCView = PPtr<UnitBuffPartPCView>.Read(reader);
        byte _HasMarkers = reader.ReadU8();
        reader.AlignTo(4); /* m_WillLossTurn */
        PPtr<GameObject> _m_WillLossTurn = PPtr<GameObject>.Read(reader);
        PPtr<GameObject> _m_HasLossControlEffectsIcon = PPtr<GameObject>.Read(reader);
        PPtr<GameObject> _m_UnableToActNormaly = PPtr<GameObject>.Read(reader);
        PPtr<ColorAnimator>[] _m_ColorAnimator = BuiltInArray<PPtr<ColorAnimator>>.Read(reader);
        PPtr<CanvasGroup> _m_CanvasGroup = PPtr<CanvasGroup>.Read(reader);
        Vector2f _SizeWithPortrait = Vector2f.Read(reader);
        Vector2f _SizeWithSquad = Vector2f.Read(reader);
        Vector2f _SizeRound = Vector2f.Read(reader);
        byte _HasHitChances = reader.ReadU8();
        reader.AlignTo(4); /* InitiativeTrackerUnitHitChanceView */
        PPtr<InitiativeTrackerUnitHitChanceView> _InitiativeTrackerUnitHitChanceView = PPtr<InitiativeTrackerUnitHitChanceView>.Read(reader);
        byte _m_HasRoundBlock = reader.ReadU8();
        reader.AlignTo(4); /* m_EndOfRound */
        PPtr<InitiativeTrackerEndOfRound> _m_EndOfRound = PPtr<InitiativeTrackerEndOfRound>.Read(reader);
        PPtr<GameObject> _m_UnitContainer = PPtr<GameObject>.Read(reader);
        PPtr<FadeAnimator> _m_HPLabelAnimator = PPtr<FadeAnimator>.Read(reader);
        PPtr<FadeAnimator> _m_NameZoneAnimator = PPtr<FadeAnimator>.Read(reader);
        byte _WillBeDestroyedExternal = reader.ReadU8();
        reader.AlignTo(4); /* m_SurfaceCombatInitiativeOrderSquadUnitViewPrefab */
        PPtr<SurfaceCombatInitiativeOrderSquadUnitView> _m_SurfaceCombatInitiativeOrderSquadUnitViewPrefab = PPtr<SurfaceCombatInitiativeOrderSquadUnitView>.Read(reader);
        PPtr<WidgetList> _m_WidgetList = PPtr<WidgetList>.Read(reader);
        PPtr<OwlcatMultiButton> _m_SquadButton = PPtr<OwlcatMultiButton>.Read(reader);
        PPtr<GameObject> _m_SquadNumContainer = PPtr<GameObject>.Read(reader);
        PPtr<TextMeshProUGUI> _m_SquadNumber = PPtr<TextMeshProUGUI>.Read(reader);
        float _m_AnimationTime = reader.ReadF32();
        float _m_Scale = reader.ReadF32();
        PPtr<DisintegrationAnimator>[] _m_DisintegrationAnimator = BuiltInArray<PPtr<DisintegrationAnimator>>.Read(reader);
        PPtr<OwlcatMultiButton> _m_Button = PPtr<OwlcatMultiButton>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _Button,
            _m_CharacetrPortraitZone,
            _m_DifficultyBlock,
            _m_DifficultyText,
            _m_NoPortraitZone,
            _UnitHealthPartTextPCView,
            _UnitHealthPartProgressPCView,
            _m_NameNormal,
            _UnitBuffPartPCView,
            _HasMarkers,
            _m_WillLossTurn,
            _m_HasLossControlEffectsIcon,
            _m_UnableToActNormaly,
            _m_ColorAnimator,
            _m_CanvasGroup,
            _SizeWithPortrait,
            _SizeWithSquad,
            _SizeRound,
            _HasHitChances,
            _InitiativeTrackerUnitHitChanceView,
            _m_HasRoundBlock,
            _m_EndOfRound,
            _m_UnitContainer,
            _m_HPLabelAnimator,
            _m_NameZoneAnimator,
            _WillBeDestroyedExternal,
            _m_SurfaceCombatInitiativeOrderSquadUnitViewPrefab,
            _m_WidgetList,
            _m_SquadButton,
            _m_SquadNumContainer,
            _m_SquadNumber,
            _m_AnimationTime,
            _m_Scale,
            _m_DisintegrationAnimator,
            _m_Button);
    }
}


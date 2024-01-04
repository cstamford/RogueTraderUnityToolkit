namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $CharGenRoadmapMenuView (25 fields) 4DDEF9692FFE06DFBF3E9D6B41A2426C/1F20280093D657AD58913C966042B4CE */
public record class CharGenRoadmapMenuView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<OwlcatMultiSelectable> m_BackgroundFrame /* NeedsAlign */,
    PPtr<RectTransform> m_FrameStart /* None */,
    PPtr<RectTransform> m_FrameEnd /* None */,
    PPtr<ScrollRectExtended> m_ScrollRectExtended /* None */,
    PPtr<CharGenPregenPhaseRoadmapView> m_PregenPhaseRoadmapView /* None */,
    PPtr<CharGenAppearancePhaseRoadmapView> m_AppearancePhaseRoadmapView /* None */,
    PPtr<CharGenBackgroundBasePhaseRoadmapView> m_SoulMarkPhaseRoadmapView /* None */,
    PPtr<CharGenBackgroundBasePhaseRoadmapView> m_HomeworldPhaseRoadmapView /* None */,
    PPtr<CharGenBackgroundBasePhaseRoadmapView> m_ImperialHomeworldChildPhaseRoadmapView /* None */,
    PPtr<CharGenBackgroundBasePhaseRoadmapView> m_ForgeHomeworldChildPhaseRoadmapView /* None */,
    PPtr<CharGenBackgroundBasePhaseRoadmapView> m_SanctionedPsykerChildPhaseRoadmapView /* None */,
    PPtr<CharGenBackgroundBasePhaseRoadmapView> m_OccupationPhaseRoadmapView /* None */,
    PPtr<CharGenBackgroundBasePhaseRoadmapView> m_NavigatorPhaseRoadmapView /* None */,
    PPtr<CharGenBackgroundBasePhaseRoadmapView> m_MomentOfTriumphPhaseRoadmapView /* None */,
    PPtr<CharGenBackgroundBasePhaseRoadmapView> m_DarkestHourPhaseRoadmapView /* None */,
    PPtr<CharGenCareerPhaseRoadmapView> m_CareerPhaseRoadmapView /* None */,
    PPtr<CharGenAttributesPhaseRoadmapView> m_AttributesPhaseRoadmapView /* None */,
    PPtr<CharGenShipPhaseRoadmapView> m_ShipPhaseRoadmapView /* None */,
    PPtr<CharGenSummaryPhaseRoadmapView> m_SummaryPhaseRoadmapView /* None */,
    PPtr<RectTransform> m_Selector /* None */,
    float m_AnimationDuration /* None */)
{
    public static CharGenRoadmapMenuView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_BackgroundFrame */
        PPtr<OwlcatMultiSelectable> _m_BackgroundFrame = PPtr<OwlcatMultiSelectable>.Read(reader);
        PPtr<RectTransform> _m_FrameStart = PPtr<RectTransform>.Read(reader);
        PPtr<RectTransform> _m_FrameEnd = PPtr<RectTransform>.Read(reader);
        PPtr<ScrollRectExtended> _m_ScrollRectExtended = PPtr<ScrollRectExtended>.Read(reader);
        PPtr<CharGenPregenPhaseRoadmapView> _m_PregenPhaseRoadmapView = PPtr<CharGenPregenPhaseRoadmapView>.Read(reader);
        PPtr<CharGenAppearancePhaseRoadmapView> _m_AppearancePhaseRoadmapView = PPtr<CharGenAppearancePhaseRoadmapView>.Read(reader);
        PPtr<CharGenBackgroundBasePhaseRoadmapView> _m_SoulMarkPhaseRoadmapView = PPtr<CharGenBackgroundBasePhaseRoadmapView>.Read(reader);
        PPtr<CharGenBackgroundBasePhaseRoadmapView> _m_HomeworldPhaseRoadmapView = PPtr<CharGenBackgroundBasePhaseRoadmapView>.Read(reader);
        PPtr<CharGenBackgroundBasePhaseRoadmapView> _m_ImperialHomeworldChildPhaseRoadmapView = PPtr<CharGenBackgroundBasePhaseRoadmapView>.Read(reader);
        PPtr<CharGenBackgroundBasePhaseRoadmapView> _m_ForgeHomeworldChildPhaseRoadmapView = PPtr<CharGenBackgroundBasePhaseRoadmapView>.Read(reader);
        PPtr<CharGenBackgroundBasePhaseRoadmapView> _m_SanctionedPsykerChildPhaseRoadmapView = PPtr<CharGenBackgroundBasePhaseRoadmapView>.Read(reader);
        PPtr<CharGenBackgroundBasePhaseRoadmapView> _m_OccupationPhaseRoadmapView = PPtr<CharGenBackgroundBasePhaseRoadmapView>.Read(reader);
        PPtr<CharGenBackgroundBasePhaseRoadmapView> _m_NavigatorPhaseRoadmapView = PPtr<CharGenBackgroundBasePhaseRoadmapView>.Read(reader);
        PPtr<CharGenBackgroundBasePhaseRoadmapView> _m_MomentOfTriumphPhaseRoadmapView = PPtr<CharGenBackgroundBasePhaseRoadmapView>.Read(reader);
        PPtr<CharGenBackgroundBasePhaseRoadmapView> _m_DarkestHourPhaseRoadmapView = PPtr<CharGenBackgroundBasePhaseRoadmapView>.Read(reader);
        PPtr<CharGenCareerPhaseRoadmapView> _m_CareerPhaseRoadmapView = PPtr<CharGenCareerPhaseRoadmapView>.Read(reader);
        PPtr<CharGenAttributesPhaseRoadmapView> _m_AttributesPhaseRoadmapView = PPtr<CharGenAttributesPhaseRoadmapView>.Read(reader);
        PPtr<CharGenShipPhaseRoadmapView> _m_ShipPhaseRoadmapView = PPtr<CharGenShipPhaseRoadmapView>.Read(reader);
        PPtr<CharGenSummaryPhaseRoadmapView> _m_SummaryPhaseRoadmapView = PPtr<CharGenSummaryPhaseRoadmapView>.Read(reader);
        PPtr<RectTransform> _m_Selector = PPtr<RectTransform>.Read(reader);
        float _m_AnimationDuration = reader.ReadF32();
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_BackgroundFrame,
            _m_FrameStart,
            _m_FrameEnd,
            _m_ScrollRectExtended,
            _m_PregenPhaseRoadmapView,
            _m_AppearancePhaseRoadmapView,
            _m_SoulMarkPhaseRoadmapView,
            _m_HomeworldPhaseRoadmapView,
            _m_ImperialHomeworldChildPhaseRoadmapView,
            _m_ForgeHomeworldChildPhaseRoadmapView,
            _m_SanctionedPsykerChildPhaseRoadmapView,
            _m_OccupationPhaseRoadmapView,
            _m_NavigatorPhaseRoadmapView,
            _m_MomentOfTriumphPhaseRoadmapView,
            _m_DarkestHourPhaseRoadmapView,
            _m_CareerPhaseRoadmapView,
            _m_AttributesPhaseRoadmapView,
            _m_ShipPhaseRoadmapView,
            _m_SummaryPhaseRoadmapView,
            _m_Selector,
            _m_AnimationDuration);
    }
}


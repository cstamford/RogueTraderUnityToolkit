namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $OvertipDestructibleObjectPCView (22 fields) EBCCFCD2D0A09331F14A99A431631FE0/B390C6099F1DA25CDE915A8A8D4334F6 */
public record class OvertipDestructibleObjectPCView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<OvertipUnitHealthBlockView> m_HealthBlockView /* NeedsAlign */,
    PPtr<OvertipUnitNameView> m_NameBlockPCView /* None */,
    PPtr<OvertipHitChanceBlockView> m_HitChanceBlockPCView /* None */,
    PPtr<OvertipCoverBlockView> m_CoverBlockPCView /* None */,
    PPtr<OvertipTargetDefensesView> m_OvertipTargetDefensesPCView /* None */,
    PPtr<OvertipNameView> m_OvertipTargetNameView /* None */,
    PPtr<OvertipAimView> m_OvertipAimView /* None */,
    PPtr<RectTransform> m_RectTransform /* None */,
    PPtr<CanvasGroup> m_InnerCanvasGroup /* None */,
    UnitOvertipVisibilitySettings m_UnitOvertipVisibilitySettings /* None */,
    float m_FarDistance /* None */,
    PPtr<OvertipCombatTextBlockView> m_CombatTextBlockPCView /* None */,
    PPtr<OvertipBarkBlockView> m_BarkBlockPCView /* None */,
    PPtr<UnitBuffPartPCView> m_UnitBuffPartPCView /* None */,
    PPtr<CanvasGroup> m_UnitBuffsCanvasGroup /* None */,
    Vector2f m_UnitBuffUpperPosition /* None */,
    Vector2f m_UnitBuffLowerPosition /* None */,
    float m_BuffsOvertipPositionYCorrection /* None */)
{
    public static OvertipDestructibleObjectPCView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_HealthBlockView */
        PPtr<OvertipUnitHealthBlockView> _m_HealthBlockView = PPtr<OvertipUnitHealthBlockView>.Read(reader);
        PPtr<OvertipUnitNameView> _m_NameBlockPCView = PPtr<OvertipUnitNameView>.Read(reader);
        PPtr<OvertipHitChanceBlockView> _m_HitChanceBlockPCView = PPtr<OvertipHitChanceBlockView>.Read(reader);
        PPtr<OvertipCoverBlockView> _m_CoverBlockPCView = PPtr<OvertipCoverBlockView>.Read(reader);
        PPtr<OvertipTargetDefensesView> _m_OvertipTargetDefensesPCView = PPtr<OvertipTargetDefensesView>.Read(reader);
        PPtr<OvertipNameView> _m_OvertipTargetNameView = PPtr<OvertipNameView>.Read(reader);
        PPtr<OvertipAimView> _m_OvertipAimView = PPtr<OvertipAimView>.Read(reader);
        PPtr<RectTransform> _m_RectTransform = PPtr<RectTransform>.Read(reader);
        PPtr<CanvasGroup> _m_InnerCanvasGroup = PPtr<CanvasGroup>.Read(reader);
        UnitOvertipVisibilitySettings _m_UnitOvertipVisibilitySettings = UnitOvertipVisibilitySettings.Read(reader);
        float _m_FarDistance = reader.ReadF32();
        PPtr<OvertipCombatTextBlockView> _m_CombatTextBlockPCView = PPtr<OvertipCombatTextBlockView>.Read(reader);
        PPtr<OvertipBarkBlockView> _m_BarkBlockPCView = PPtr<OvertipBarkBlockView>.Read(reader);
        PPtr<UnitBuffPartPCView> _m_UnitBuffPartPCView = PPtr<UnitBuffPartPCView>.Read(reader);
        PPtr<CanvasGroup> _m_UnitBuffsCanvasGroup = PPtr<CanvasGroup>.Read(reader);
        Vector2f _m_UnitBuffUpperPosition = Vector2f.Read(reader);
        Vector2f _m_UnitBuffLowerPosition = Vector2f.Read(reader);
        float _m_BuffsOvertipPositionYCorrection = reader.ReadF32();
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_HealthBlockView,
            _m_NameBlockPCView,
            _m_HitChanceBlockPCView,
            _m_CoverBlockPCView,
            _m_OvertipTargetDefensesPCView,
            _m_OvertipTargetNameView,
            _m_OvertipAimView,
            _m_RectTransform,
            _m_InnerCanvasGroup,
            _m_UnitOvertipVisibilitySettings,
            _m_FarDistance,
            _m_CombatTextBlockPCView,
            _m_BarkBlockPCView,
            _m_UnitBuffPartPCView,
            _m_UnitBuffsCanvasGroup,
            _m_UnitBuffUpperPosition,
            _m_UnitBuffLowerPosition,
            _m_BuffsOvertipPositionYCorrection);
    }
}


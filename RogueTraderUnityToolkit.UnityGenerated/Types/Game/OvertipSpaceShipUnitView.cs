namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $OvertipSpaceShipUnitView (21 fields) C6F08253063FB7D7ED31F1AD3EAF5348/651EDC95DE79C78B6C83583BAFC10D4A */
public record class OvertipSpaceShipUnitView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<OvertipShipHealthBlockView> m_HealthBlockPCView /* NeedsAlign */,
    PPtr<OvertipUnitNameView> m_NameBlockPCView /* None */,
    PPtr<OvertipCombatTextBlockView> m_CombatTextBlockPCView /* None */,
    PPtr<OvertipBarkBlockView> m_BarkBlockPCView /* None */,
    PPtr<OvertipVoidshipHealthView> m_VoidshipHealthPCView /* None */,
    PPtr<OvertipHitChanceBlockView> m_HitChanceBlockPCView /* None */,
    PPtr<OvertipSpaceShipEvasionBlockView> m_OvertipSpaceShipEvasionBlockView /* None */,
    PPtr<OvertipNameView> m_OvertipTargetNameView /* None */,
    PPtr<OvertipAimView> m_OvertipAimView /* None */,
    PPtr<RectTransform> m_RectTransform /* None */,
    PPtr<CanvasGroup> m_InnerCanvasGroup /* None */,
    UnitOvertipVisibilitySettings m_UnitOvertipVisibilitySettings /* None */,
    float m_FarDistance /* None */,
    PPtr<UnitBuffPartPCView> m_UnitBuffPartPCView /* None */,
    PPtr<CanvasGroup> m_UnitBuffsCanvasGroup /* None */,
    Vector2f m_UnitBuffUpperPosition /* None */,
    Vector2f m_UnitBuffLowerPosition /* None */)
{
    public static OvertipSpaceShipUnitView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_HealthBlockPCView */
        PPtr<OvertipShipHealthBlockView> _m_HealthBlockPCView = PPtr<OvertipShipHealthBlockView>.Read(reader);
        PPtr<OvertipUnitNameView> _m_NameBlockPCView = PPtr<OvertipUnitNameView>.Read(reader);
        PPtr<OvertipCombatTextBlockView> _m_CombatTextBlockPCView = PPtr<OvertipCombatTextBlockView>.Read(reader);
        PPtr<OvertipBarkBlockView> _m_BarkBlockPCView = PPtr<OvertipBarkBlockView>.Read(reader);
        PPtr<OvertipVoidshipHealthView> _m_VoidshipHealthPCView = PPtr<OvertipVoidshipHealthView>.Read(reader);
        PPtr<OvertipHitChanceBlockView> _m_HitChanceBlockPCView = PPtr<OvertipHitChanceBlockView>.Read(reader);
        PPtr<OvertipSpaceShipEvasionBlockView> _m_OvertipSpaceShipEvasionBlockView = PPtr<OvertipSpaceShipEvasionBlockView>.Read(reader);
        PPtr<OvertipNameView> _m_OvertipTargetNameView = PPtr<OvertipNameView>.Read(reader);
        PPtr<OvertipAimView> _m_OvertipAimView = PPtr<OvertipAimView>.Read(reader);
        PPtr<RectTransform> _m_RectTransform = PPtr<RectTransform>.Read(reader);
        PPtr<CanvasGroup> _m_InnerCanvasGroup = PPtr<CanvasGroup>.Read(reader);
        UnitOvertipVisibilitySettings _m_UnitOvertipVisibilitySettings = UnitOvertipVisibilitySettings.Read(reader);
        float _m_FarDistance = reader.ReadF32();
        PPtr<UnitBuffPartPCView> _m_UnitBuffPartPCView = PPtr<UnitBuffPartPCView>.Read(reader);
        PPtr<CanvasGroup> _m_UnitBuffsCanvasGroup = PPtr<CanvasGroup>.Read(reader);
        Vector2f _m_UnitBuffUpperPosition = Vector2f.Read(reader);
        Vector2f _m_UnitBuffLowerPosition = Vector2f.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_HealthBlockPCView,
            _m_NameBlockPCView,
            _m_CombatTextBlockPCView,
            _m_BarkBlockPCView,
            _m_VoidshipHealthPCView,
            _m_HitChanceBlockPCView,
            _m_OvertipSpaceShipEvasionBlockView,
            _m_OvertipTargetNameView,
            _m_OvertipAimView,
            _m_RectTransform,
            _m_InnerCanvasGroup,
            _m_UnitOvertipVisibilitySettings,
            _m_FarDistance,
            _m_UnitBuffPartPCView,
            _m_UnitBuffsCanvasGroup,
            _m_UnitBuffUpperPosition,
            _m_UnitBuffLowerPosition);
    }
}


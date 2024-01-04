namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $InitiativeTrackerVerticalConsoleView (20 fields) D05FCAEFBB863AF085211E933A705CD3/54FB4646BA9816E78523133F193CFF03 */
public record class InitiativeTrackerVerticalConsoleView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<RectTransform> TrackerContainer /* NeedsAlign */,
    PPtr<RectTransform> OrderContainer /* None */,
    PPtr<TurnVirtualListController> VirtualList /* None */,
    PPtr<SurfaceCombatUnitOrderView> CombatUnitPrefab /* None */,
    PPtr<FadeAnimator> m_OwnAnimation /* None */,
    PPtr<RectTransform> m_VirtualListViewport /* None */,
    PPtr<TextMeshProUGUI> m_StateValue /* None */,
    PPtr<SurfaceCombatUnitOrderVerticalView> m_CurrentUnit /* None */,
    PPtr<ConsoleHintsWidget> m_ConsoleHintsWidget /* None */,
    PPtr<ConsoleHint> m_ActivateHint /* None */,
    PPtr<ConsoleHint> m_DeactivateHint /* None */,
    PPtr<RectTransform> m_TooltipUpperRightPosition /* None */,
    float m_FocusUnitDelay /* None */,
    PPtr<RectTransform> m_TrackerContainer /* None */,
    Vector2f m_TrackerContainerDeltaOnSelect /* None */,
    float m_ContainerAnimationTime /* None */)
{
    public static InitiativeTrackerVerticalConsoleView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* TrackerContainer */
        PPtr<RectTransform> _TrackerContainer = PPtr<RectTransform>.Read(reader);
        PPtr<RectTransform> _OrderContainer = PPtr<RectTransform>.Read(reader);
        PPtr<TurnVirtualListController> _VirtualList = PPtr<TurnVirtualListController>.Read(reader);
        PPtr<SurfaceCombatUnitOrderView> _CombatUnitPrefab = PPtr<SurfaceCombatUnitOrderView>.Read(reader);
        PPtr<FadeAnimator> _m_OwnAnimation = PPtr<FadeAnimator>.Read(reader);
        PPtr<RectTransform> _m_VirtualListViewport = PPtr<RectTransform>.Read(reader);
        PPtr<TextMeshProUGUI> _m_StateValue = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<SurfaceCombatUnitOrderVerticalView> _m_CurrentUnit = PPtr<SurfaceCombatUnitOrderVerticalView>.Read(reader);
        PPtr<ConsoleHintsWidget> _m_ConsoleHintsWidget = PPtr<ConsoleHintsWidget>.Read(reader);
        PPtr<ConsoleHint> _m_ActivateHint = PPtr<ConsoleHint>.Read(reader);
        PPtr<ConsoleHint> _m_DeactivateHint = PPtr<ConsoleHint>.Read(reader);
        PPtr<RectTransform> _m_TooltipUpperRightPosition = PPtr<RectTransform>.Read(reader);
        float _m_FocusUnitDelay = reader.ReadF32();
        PPtr<RectTransform> _m_TrackerContainer = PPtr<RectTransform>.Read(reader);
        Vector2f _m_TrackerContainerDeltaOnSelect = Vector2f.Read(reader);
        float _m_ContainerAnimationTime = reader.ReadF32();
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _TrackerContainer,
            _OrderContainer,
            _VirtualList,
            _CombatUnitPrefab,
            _m_OwnAnimation,
            _m_VirtualListViewport,
            _m_StateValue,
            _m_CurrentUnit,
            _m_ConsoleHintsWidget,
            _m_ActivateHint,
            _m_DeactivateHint,
            _m_TooltipUpperRightPosition,
            _m_FocusUnitDelay,
            _m_TrackerContainer,
            _m_TrackerContainerDeltaOnSelect,
            _m_ContainerAnimationTime);
    }
}


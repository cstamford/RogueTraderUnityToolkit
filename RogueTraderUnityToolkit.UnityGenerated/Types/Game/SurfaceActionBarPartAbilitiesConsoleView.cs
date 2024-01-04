namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $SurfaceActionBarPartAbilitiesConsoleView (15 fields) EC80B2963D8BC28C495863D9F176D317/FD29E5943286301974A77A3FDDEEB767 */
public record class SurfaceActionBarPartAbilitiesConsoleView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<RectTransform> m_TooltipPlace /* NeedsAlign */,
    PPtr<SurfaceActionBarAbilitiesRowView> m_Row /* None */,
    PPtr<SurfaceActionBarSlotAbilityConsoleView> m_SlotView /* None */,
    PPtr<PageNavigationConsole> m_PageNavigation /* None */,
    PPtr<MoveAnimator> m_MoveAnimator /* None */,
    PPtr<ConsoleHint> m_ActivateHint /* None */,
    PPtr<ConsoleHint> m_ActivateInCombatHint /* None */,
    PPtr<ConsoleHintsWidget> m_HintsWidget /* None */,
    PPtr<VeilThicknessConsoleView> m_VeilThicknessConsoleView /* None */,
    PPtr<SurfaceMomentumConsoleView> m_MomentumConsoleView /* None */,
    PPtr<AbilitySelectorWindowConsoleView> m_AbilitySelectorWindowConsoleView /* None */)
{
    public static SurfaceActionBarPartAbilitiesConsoleView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_TooltipPlace */
        PPtr<RectTransform> _m_TooltipPlace = PPtr<RectTransform>.Read(reader);
        PPtr<SurfaceActionBarAbilitiesRowView> _m_Row = PPtr<SurfaceActionBarAbilitiesRowView>.Read(reader);
        PPtr<SurfaceActionBarSlotAbilityConsoleView> _m_SlotView = PPtr<SurfaceActionBarSlotAbilityConsoleView>.Read(reader);
        PPtr<PageNavigationConsole> _m_PageNavigation = PPtr<PageNavigationConsole>.Read(reader);
        PPtr<MoveAnimator> _m_MoveAnimator = PPtr<MoveAnimator>.Read(reader);
        PPtr<ConsoleHint> _m_ActivateHint = PPtr<ConsoleHint>.Read(reader);
        PPtr<ConsoleHint> _m_ActivateInCombatHint = PPtr<ConsoleHint>.Read(reader);
        PPtr<ConsoleHintsWidget> _m_HintsWidget = PPtr<ConsoleHintsWidget>.Read(reader);
        PPtr<VeilThicknessConsoleView> _m_VeilThicknessConsoleView = PPtr<VeilThicknessConsoleView>.Read(reader);
        PPtr<SurfaceMomentumConsoleView> _m_MomentumConsoleView = PPtr<SurfaceMomentumConsoleView>.Read(reader);
        PPtr<AbilitySelectorWindowConsoleView> _m_AbilitySelectorWindowConsoleView = PPtr<AbilitySelectorWindowConsoleView>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_TooltipPlace,
            _m_Row,
            _m_SlotView,
            _m_PageNavigation,
            _m_MoveAnimator,
            _m_ActivateHint,
            _m_ActivateInCombatHint,
            _m_HintsWidget,
            _m_VeilThicknessConsoleView,
            _m_MomentumConsoleView,
            _m_AbilitySelectorWindowConsoleView);
    }
}


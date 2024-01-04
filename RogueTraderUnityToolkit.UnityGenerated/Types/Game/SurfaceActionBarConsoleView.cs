namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $SurfaceActionBarConsoleView (15 fields) C90D861A4EA4EF965F5A87908EDF6F18/353D3C895B57E3887E5CF7A1355CD3D6 */
public record class SurfaceActionBarConsoleView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<FadeAnimator> m_Animator /* NeedsAlign */,
    PPtr<SurfaceActionBarPartQuickAccessConsoleView> m_QuickAccessConsoleView /* None */,
    PPtr<SurfaceActionBarPartAbilitiesConsoleView> m_AbilitiesConsoleView /* None */,
    PPtr<SurfaceMomentumConsoleView> m_MomentumConsoleView /* None */,
    PPtr<VeilThicknessConsoleView> m_VeilThicknessConsoleView /* None */,
    PPtr<Image> m_ClearMPAlertGroup /* None */,
    PPtr<Image> m_AttackAbilityGroupCooldownAlertGroup /* None */,
    PPtr<ConsoleHint> m_InspectHint /* None */,
    PPtr<ConsoleHint> m_HideActionBarHint /* None */,
    PPtr<ConsoleHint> m_ShowActionBarHint /* None */,
    PPtr<GameObject>[] m_ContainersForMarkers /* None */)
{
    public static SurfaceActionBarConsoleView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_Animator */
        PPtr<FadeAnimator> _m_Animator = PPtr<FadeAnimator>.Read(reader);
        PPtr<SurfaceActionBarPartQuickAccessConsoleView> _m_QuickAccessConsoleView = PPtr<SurfaceActionBarPartQuickAccessConsoleView>.Read(reader);
        PPtr<SurfaceActionBarPartAbilitiesConsoleView> _m_AbilitiesConsoleView = PPtr<SurfaceActionBarPartAbilitiesConsoleView>.Read(reader);
        PPtr<SurfaceMomentumConsoleView> _m_MomentumConsoleView = PPtr<SurfaceMomentumConsoleView>.Read(reader);
        PPtr<VeilThicknessConsoleView> _m_VeilThicknessConsoleView = PPtr<VeilThicknessConsoleView>.Read(reader);
        PPtr<Image> _m_ClearMPAlertGroup = PPtr<Image>.Read(reader);
        PPtr<Image> _m_AttackAbilityGroupCooldownAlertGroup = PPtr<Image>.Read(reader);
        PPtr<ConsoleHint> _m_InspectHint = PPtr<ConsoleHint>.Read(reader);
        PPtr<ConsoleHint> _m_HideActionBarHint = PPtr<ConsoleHint>.Read(reader);
        PPtr<ConsoleHint> _m_ShowActionBarHint = PPtr<ConsoleHint>.Read(reader);
        PPtr<GameObject>[] _m_ContainersForMarkers = BuiltInArray<PPtr<GameObject>>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_Animator,
            _m_QuickAccessConsoleView,
            _m_AbilitiesConsoleView,
            _m_MomentumConsoleView,
            _m_VeilThicknessConsoleView,
            _m_ClearMPAlertGroup,
            _m_AttackAbilityGroupCooldownAlertGroup,
            _m_InspectHint,
            _m_HideActionBarHint,
            _m_ShowActionBarHint,
            _m_ContainersForMarkers);
    }
}


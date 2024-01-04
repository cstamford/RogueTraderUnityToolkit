namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $SurfaceActionBarPCView (14 fields) BCD09559C71177F07972BA76356A6FC5/136F4324F8C9E1DA167C8365A272DEBC */
public record class SurfaceActionBarPCView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<FadeAnimator> m_Animator /* NeedsAlign */,
    PPtr<FadeAnimator> m_AdditionalAnimator /* None */,
    PPtr<SurfaceActionBarPartConsumablesPCView> m_ConsumablesView /* None */,
    PPtr<SurfaceActionBarPartWeaponsPCView> m_WeaponsView /* None */,
    PPtr<SurfaceActionBarPartAbilitiesPCView> m_AbilitiesView /* None */,
    PPtr<SurfaceMomentumPCView> m_SurfaceMomentumPCView /* None */,
    PPtr<VeilThicknessPCView> m_VeilThicknessView /* None */,
    PPtr<GameObject> m_ContainerForMarkers /* None */,
    PPtr<Image> m_ClearMPAlertGroup /* None */,
    PPtr<Image> m_AttackAbilityGroupCooldownAlertGroup /* None */)
{
    public static SurfaceActionBarPCView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_Animator */
        PPtr<FadeAnimator> _m_Animator = PPtr<FadeAnimator>.Read(reader);
        PPtr<FadeAnimator> _m_AdditionalAnimator = PPtr<FadeAnimator>.Read(reader);
        PPtr<SurfaceActionBarPartConsumablesPCView> _m_ConsumablesView = PPtr<SurfaceActionBarPartConsumablesPCView>.Read(reader);
        PPtr<SurfaceActionBarPartWeaponsPCView> _m_WeaponsView = PPtr<SurfaceActionBarPartWeaponsPCView>.Read(reader);
        PPtr<SurfaceActionBarPartAbilitiesPCView> _m_AbilitiesView = PPtr<SurfaceActionBarPartAbilitiesPCView>.Read(reader);
        PPtr<SurfaceMomentumPCView> _m_SurfaceMomentumPCView = PPtr<SurfaceMomentumPCView>.Read(reader);
        PPtr<VeilThicknessPCView> _m_VeilThicknessView = PPtr<VeilThicknessPCView>.Read(reader);
        PPtr<GameObject> _m_ContainerForMarkers = PPtr<GameObject>.Read(reader);
        PPtr<Image> _m_ClearMPAlertGroup = PPtr<Image>.Read(reader);
        PPtr<Image> _m_AttackAbilityGroupCooldownAlertGroup = PPtr<Image>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_Animator,
            _m_AdditionalAnimator,
            _m_ConsumablesView,
            _m_WeaponsView,
            _m_AbilitiesView,
            _m_SurfaceMomentumPCView,
            _m_VeilThicknessView,
            _m_ContainerForMarkers,
            _m_ClearMPAlertGroup,
            _m_AttackAbilityGroupCooldownAlertGroup);
    }
}


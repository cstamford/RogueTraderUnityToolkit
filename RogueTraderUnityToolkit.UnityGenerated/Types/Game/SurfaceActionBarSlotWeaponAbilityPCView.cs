namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $SurfaceActionBarSlotWeaponAbilityPCView (27 fields) 460AC9960A4C8CF7EA374EF91BDD8F1D/6CE732B722004A4661FE4B630ACE4235 */
public record class SurfaceActionBarSlotWeaponAbilityPCView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<OwlcatMultiButton> MainButton /* NeedsAlign */,
    PPtr<Image> m_Icon /* None */,
    PPtr<_2dxFX_GrayScale> m_GrayScale /* None */,
    float m_GrayScaleAlpha /* None */,
    PPtr<UICornerCut> m_ForeIcon /* None */,
    PPtr<Image> m_SelectedMark /* None */,
    PPtr<FadeAnimator> m_TargetPingEntity /* None */,
    PPtr<Image> m_AttackAbilityGroupCooldownAlertMark /* None */,
    ColorRGBA m_MinAlertColor /* None */,
    ColorRGBA m_MaxAlertColor /* None */,
    float m_AlertAnimationBlinkTime /* None */,
    PPtr<GameObject> m_ActionPointBlock /* None */,
    PPtr<Slider> m_ActionPoints /* None */,
    int m_ActionPointsMaxValue /* None */,
    PPtr<RectTransform> m_SplashAnim /* None */,
    PPtr<GameObject> m_AmmoCostContainer /* None */,
    PPtr<TextMeshProUGUI> m_AmmoCost /* None */,
    PPtr<GameObject> m_ReloadAmmoContainer /* None */,
    PPtr<TextMeshProUGUI> m_ReloadAmmoText /* None */,
    PPtr<Slider> m_ReloadAmmoBar /* None */,
    PPtr<GameObject> m_CurrentAmmoContainer /* None */,
    PPtr<TextMeshProUGUI> m_CurrentAmmoText /* None */,
    PPtr<ActionBarSlotPCView> m_SlotPCView /* None */)
{
    public static SurfaceActionBarSlotWeaponAbilityPCView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* MainButton */
        PPtr<OwlcatMultiButton> _MainButton = PPtr<OwlcatMultiButton>.Read(reader);
        PPtr<Image> _m_Icon = PPtr<Image>.Read(reader);
        PPtr<_2dxFX_GrayScale> _m_GrayScale = PPtr<_2dxFX_GrayScale>.Read(reader);
        float _m_GrayScaleAlpha = reader.ReadF32();
        PPtr<UICornerCut> _m_ForeIcon = PPtr<UICornerCut>.Read(reader);
        PPtr<Image> _m_SelectedMark = PPtr<Image>.Read(reader);
        PPtr<FadeAnimator> _m_TargetPingEntity = PPtr<FadeAnimator>.Read(reader);
        PPtr<Image> _m_AttackAbilityGroupCooldownAlertMark = PPtr<Image>.Read(reader);
        ColorRGBA _m_MinAlertColor = ColorRGBA.Read(reader);
        ColorRGBA _m_MaxAlertColor = ColorRGBA.Read(reader);
        float _m_AlertAnimationBlinkTime = reader.ReadF32();
        PPtr<GameObject> _m_ActionPointBlock = PPtr<GameObject>.Read(reader);
        PPtr<Slider> _m_ActionPoints = PPtr<Slider>.Read(reader);
        int _m_ActionPointsMaxValue = reader.ReadS32();
        PPtr<RectTransform> _m_SplashAnim = PPtr<RectTransform>.Read(reader);
        PPtr<GameObject> _m_AmmoCostContainer = PPtr<GameObject>.Read(reader);
        PPtr<TextMeshProUGUI> _m_AmmoCost = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<GameObject> _m_ReloadAmmoContainer = PPtr<GameObject>.Read(reader);
        PPtr<TextMeshProUGUI> _m_ReloadAmmoText = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<Slider> _m_ReloadAmmoBar = PPtr<Slider>.Read(reader);
        PPtr<GameObject> _m_CurrentAmmoContainer = PPtr<GameObject>.Read(reader);
        PPtr<TextMeshProUGUI> _m_CurrentAmmoText = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<ActionBarSlotPCView> _m_SlotPCView = PPtr<ActionBarSlotPCView>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _MainButton,
            _m_Icon,
            _m_GrayScale,
            _m_GrayScaleAlpha,
            _m_ForeIcon,
            _m_SelectedMark,
            _m_TargetPingEntity,
            _m_AttackAbilityGroupCooldownAlertMark,
            _m_MinAlertColor,
            _m_MaxAlertColor,
            _m_AlertAnimationBlinkTime,
            _m_ActionPointBlock,
            _m_ActionPoints,
            _m_ActionPointsMaxValue,
            _m_SplashAnim,
            _m_AmmoCostContainer,
            _m_AmmoCost,
            _m_ReloadAmmoContainer,
            _m_ReloadAmmoText,
            _m_ReloadAmmoBar,
            _m_CurrentAmmoContainer,
            _m_CurrentAmmoText,
            _m_SlotPCView);
    }
}


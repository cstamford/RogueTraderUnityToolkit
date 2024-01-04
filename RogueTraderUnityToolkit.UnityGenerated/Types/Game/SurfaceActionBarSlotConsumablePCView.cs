namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $SurfaceActionBarSlotConsumablePCView (23 fields) 5DE0F5250EEC6C2D88DB62DEF65D3B89/D8576EE58FD609AD1436DBC90117FBBA */
public record class SurfaceActionBarSlotConsumablePCView(
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
    PPtr<TextMeshProUGUI> m_ResourceCount /* None */,
    PPtr<Image> m_ResourceCountShadow /* None */,
    PPtr<GameObject> m_LockedContainer /* None */,
    PPtr<ActionBarSlotPCView> m_SlotPCView /* None */)
{
    public static SurfaceActionBarSlotConsumablePCView Read(EndianBinaryReader reader)
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
        PPtr<TextMeshProUGUI> _m_ResourceCount = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<Image> _m_ResourceCountShadow = PPtr<Image>.Read(reader);
        PPtr<GameObject> _m_LockedContainer = PPtr<GameObject>.Read(reader);
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
            _m_ResourceCount,
            _m_ResourceCountShadow,
            _m_LockedContainer,
            _m_SlotPCView);
    }
}


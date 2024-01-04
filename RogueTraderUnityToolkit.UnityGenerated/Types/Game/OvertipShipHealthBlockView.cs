namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $OvertipShipHealthBlockView (25 fields) 543099FAE5B4409DDFD55F031195282F/A0E759F58F19D22474D91DD3448922ED */
public record class OvertipShipHealthBlockView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<RectTransform> m_RectTransform /* NeedsAlign */,
    PPtr<CanvasGroup> m_CanvasGroup /* None */,
    PPtr<CanvasGroup> m_LargeArtBlock /* None */,
    PPtr<CanvasGroup> m_MediumArtBlock /* None */,
    PPtr<OwlcatMultiSelectable> m_MultiSelectable /* None */,
    PPtr<CanvasGroup> m_HealthLabelBlock /* None */,
    PPtr<TextMeshProUGUI> m_HealthLabel /* None */,
    UnitOvertipVisibilitySettings m_UnitOvertipVisibilitySettings /* None */,
    PPtr<Slider> m_HPMaxSlider /* None */,
    PPtr<DelayedSlider> m_HPLeftSlider /* None */,
    PPtr<AdditionalSlider> m_HPTempSlider /* None */,
    PPtr<RangedSlider> m_MinDamageSlider /* None */,
    PPtr<RangedSlider> m_MaxDamageSlider /* None */,
    PPtr<GameObject> m_DeathMark /* None */,
    byte HasShields /* None */,
    PPtr<CanvasGroup> m_ShieldsSliderBlock /* NeedsAlign */,
    PPtr<Slider> m_ShieldsMaxSlider /* None */,
    PPtr<DelayedSlider> m_ShieldsLeftSlider /* None */,
    PPtr<TextMeshProUGUI> m_ShieldLabel /* None */,
    PPtr<RangedSlider> m_ShieldsMaxDamageSlider /* None */,
    PPtr<RangedSlider> m_ShieldsMinDamageSlider /* None */)
{
    public static OvertipShipHealthBlockView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_RectTransform */
        PPtr<RectTransform> _m_RectTransform = PPtr<RectTransform>.Read(reader);
        PPtr<CanvasGroup> _m_CanvasGroup = PPtr<CanvasGroup>.Read(reader);
        PPtr<CanvasGroup> _m_LargeArtBlock = PPtr<CanvasGroup>.Read(reader);
        PPtr<CanvasGroup> _m_MediumArtBlock = PPtr<CanvasGroup>.Read(reader);
        PPtr<OwlcatMultiSelectable> _m_MultiSelectable = PPtr<OwlcatMultiSelectable>.Read(reader);
        PPtr<CanvasGroup> _m_HealthLabelBlock = PPtr<CanvasGroup>.Read(reader);
        PPtr<TextMeshProUGUI> _m_HealthLabel = PPtr<TextMeshProUGUI>.Read(reader);
        UnitOvertipVisibilitySettings _m_UnitOvertipVisibilitySettings = UnitOvertipVisibilitySettings.Read(reader);
        PPtr<Slider> _m_HPMaxSlider = PPtr<Slider>.Read(reader);
        PPtr<DelayedSlider> _m_HPLeftSlider = PPtr<DelayedSlider>.Read(reader);
        PPtr<AdditionalSlider> _m_HPTempSlider = PPtr<AdditionalSlider>.Read(reader);
        PPtr<RangedSlider> _m_MinDamageSlider = PPtr<RangedSlider>.Read(reader);
        PPtr<RangedSlider> _m_MaxDamageSlider = PPtr<RangedSlider>.Read(reader);
        PPtr<GameObject> _m_DeathMark = PPtr<GameObject>.Read(reader);
        byte _HasShields = reader.ReadU8();
        reader.AlignTo(4); /* m_ShieldsSliderBlock */
        PPtr<CanvasGroup> _m_ShieldsSliderBlock = PPtr<CanvasGroup>.Read(reader);
        PPtr<Slider> _m_ShieldsMaxSlider = PPtr<Slider>.Read(reader);
        PPtr<DelayedSlider> _m_ShieldsLeftSlider = PPtr<DelayedSlider>.Read(reader);
        PPtr<TextMeshProUGUI> _m_ShieldLabel = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<RangedSlider> _m_ShieldsMaxDamageSlider = PPtr<RangedSlider>.Read(reader);
        PPtr<RangedSlider> _m_ShieldsMinDamageSlider = PPtr<RangedSlider>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_RectTransform,
            _m_CanvasGroup,
            _m_LargeArtBlock,
            _m_MediumArtBlock,
            _m_MultiSelectable,
            _m_HealthLabelBlock,
            _m_HealthLabel,
            _m_UnitOvertipVisibilitySettings,
            _m_HPMaxSlider,
            _m_HPLeftSlider,
            _m_HPTempSlider,
            _m_MinDamageSlider,
            _m_MaxDamageSlider,
            _m_DeathMark,
            _HasShields,
            _m_ShieldsSliderBlock,
            _m_ShieldsMaxSlider,
            _m_ShieldsLeftSlider,
            _m_ShieldLabel,
            _m_ShieldsMaxDamageSlider,
            _m_ShieldsMinDamageSlider);
    }
}


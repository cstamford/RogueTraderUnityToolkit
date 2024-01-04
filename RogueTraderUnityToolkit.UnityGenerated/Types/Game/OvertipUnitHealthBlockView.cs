namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $OvertipUnitHealthBlockView (18 fields) 9B9CF312A777CFC3FAE2CF69E1900D97/1AB5DECBED64F197025D3AE60F790C52 */
public record class OvertipUnitHealthBlockView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<RectTransform> m_RectTransform /* NeedsAlign */,
    PPtr<CanvasGroup> m_CanvasGroup /* None */,
    UnitOvertipVisibilitySettings m_VisibilitySettings /* None */,
    PPtr<CanvasGroup> m_LargeArtBlock /* None */,
    PPtr<CanvasGroup> m_MediumArtBlock /* None */,
    PPtr<OwlcatMultiSelectable> m_MultiSelectable /* None */,
    PPtr<CanvasGroup> m_HealthLabelBlock /* None */,
    PPtr<TextMeshProUGUI> m_HealthLabel /* None */,
    PPtr<Slider> m_HPMaxSlider /* None */,
    PPtr<DelayedSlider> m_HPLeftSlider /* None */,
    PPtr<AdditionalSlider> m_HPTempSlider /* None */,
    PPtr<RangedSlider> m_MinDamageSlider /* None */,
    PPtr<RangedSlider> m_MaxDamageSlider /* None */,
    PPtr<CanvasGroup> m_DeathMark /* None */)
{
    public static OvertipUnitHealthBlockView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_RectTransform */
        PPtr<RectTransform> _m_RectTransform = PPtr<RectTransform>.Read(reader);
        PPtr<CanvasGroup> _m_CanvasGroup = PPtr<CanvasGroup>.Read(reader);
        UnitOvertipVisibilitySettings _m_VisibilitySettings = UnitOvertipVisibilitySettings.Read(reader);
        PPtr<CanvasGroup> _m_LargeArtBlock = PPtr<CanvasGroup>.Read(reader);
        PPtr<CanvasGroup> _m_MediumArtBlock = PPtr<CanvasGroup>.Read(reader);
        PPtr<OwlcatMultiSelectable> _m_MultiSelectable = PPtr<OwlcatMultiSelectable>.Read(reader);
        PPtr<CanvasGroup> _m_HealthLabelBlock = PPtr<CanvasGroup>.Read(reader);
        PPtr<TextMeshProUGUI> _m_HealthLabel = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<Slider> _m_HPMaxSlider = PPtr<Slider>.Read(reader);
        PPtr<DelayedSlider> _m_HPLeftSlider = PPtr<DelayedSlider>.Read(reader);
        PPtr<AdditionalSlider> _m_HPTempSlider = PPtr<AdditionalSlider>.Read(reader);
        PPtr<RangedSlider> _m_MinDamageSlider = PPtr<RangedSlider>.Read(reader);
        PPtr<RangedSlider> _m_MaxDamageSlider = PPtr<RangedSlider>.Read(reader);
        PPtr<CanvasGroup> _m_DeathMark = PPtr<CanvasGroup>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_RectTransform,
            _m_CanvasGroup,
            _m_VisibilitySettings,
            _m_LargeArtBlock,
            _m_MediumArtBlock,
            _m_MultiSelectable,
            _m_HealthLabelBlock,
            _m_HealthLabel,
            _m_HPMaxSlider,
            _m_HPLeftSlider,
            _m_HPTempSlider,
            _m_MinDamageSlider,
            _m_MaxDamageSlider,
            _m_DeathMark);
    }
}


namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $VeilThicknessPCView (10 fields) DCE5A4B6C91FBB70224A679B0880DAF2/DBC672C37C380E4D04E45A23B84DFC26 */
public record class VeilThicknessPCView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<Image> m_TooltipArea /* NeedsAlign */,
    PPtr<FadeAnimator> m_Animator /* None */,
    PPtr<DelayedSlider> m_ValueSlider /* None */,
    PPtr<Slider> m_PredictedValueSlider /* None */,
    PPtr<Slider> m_CriticalValueSlider /* None */,
    PPtr<OwlcatMultiSelectable>[] m_Effects /* None */)
{
    public static VeilThicknessPCView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_TooltipArea */
        PPtr<Image> _m_TooltipArea = PPtr<Image>.Read(reader);
        PPtr<FadeAnimator> _m_Animator = PPtr<FadeAnimator>.Read(reader);
        PPtr<DelayedSlider> _m_ValueSlider = PPtr<DelayedSlider>.Read(reader);
        PPtr<Slider> _m_PredictedValueSlider = PPtr<Slider>.Read(reader);
        PPtr<Slider> _m_CriticalValueSlider = PPtr<Slider>.Read(reader);
        PPtr<OwlcatMultiSelectable>[] _m_Effects = BuiltInArray<PPtr<OwlcatMultiSelectable>>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_TooltipArea,
            _m_Animator,
            _m_ValueSlider,
            _m_PredictedValueSlider,
            _m_CriticalValueSlider,
            _m_Effects);
    }
}


namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $VeilThicknessConsoleView (11 fields) E97908A27AD458D2872D07AC2AF97B95/878F05B25945974640C4D9F23794B879 */
public record class VeilThicknessConsoleView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<Image> m_TooltipArea /* NeedsAlign */,
    PPtr<FadeAnimator> m_Animator /* None */,
    PPtr<DelayedSlider> m_ValueSlider /* None */,
    PPtr<Slider> m_PredictedValueSlider /* None */,
    PPtr<Slider> m_CriticalValueSlider /* None */,
    PPtr<OwlcatMultiSelectable>[] m_Effects /* None */,
    PPtr<OwlcatMultiButton> m_Button /* None */)
{
    public static VeilThicknessConsoleView Read(EndianBinaryReader reader)
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
        PPtr<OwlcatMultiButton> _m_Button = PPtr<OwlcatMultiButton>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_TooltipArea,
            _m_Animator,
            _m_ValueSlider,
            _m_PredictedValueSlider,
            _m_CriticalValueSlider,
            _m_Effects,
            _m_Button);
    }
}


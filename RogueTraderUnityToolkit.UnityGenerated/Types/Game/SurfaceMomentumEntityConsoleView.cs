namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $SurfaceMomentumEntityConsoleView (10 fields) 6C96419875CAA4A6AAE8651455B40D4D/0FE961EFD93F31A534BE9A5DF5C2694F */
public record class SurfaceMomentumEntityConsoleView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<DelayedSlider> m_CurrentSlider /* NeedsAlign */,
    PPtr<Slider> m_HeroicActSlider /* None */,
    PPtr<Slider> m_DesperateMeasureSlider /* None */,
    PPtr<OwlcatMultiSelectable> m_HeroicActSelectable /* None */,
    PPtr<OwlcatMultiSelectable> m_DesperateMeasureSelectable /* None */,
    PPtr<OwlcatMultiSelectable> m_LabelSelectable /* None */)
{
    public static SurfaceMomentumEntityConsoleView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_CurrentSlider */
        PPtr<DelayedSlider> _m_CurrentSlider = PPtr<DelayedSlider>.Read(reader);
        PPtr<Slider> _m_HeroicActSlider = PPtr<Slider>.Read(reader);
        PPtr<Slider> _m_DesperateMeasureSlider = PPtr<Slider>.Read(reader);
        PPtr<OwlcatMultiSelectable> _m_HeroicActSelectable = PPtr<OwlcatMultiSelectable>.Read(reader);
        PPtr<OwlcatMultiSelectable> _m_DesperateMeasureSelectable = PPtr<OwlcatMultiSelectable>.Read(reader);
        PPtr<OwlcatMultiSelectable> _m_LabelSelectable = PPtr<OwlcatMultiSelectable>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_CurrentSlider,
            _m_HeroicActSlider,
            _m_DesperateMeasureSlider,
            _m_HeroicActSelectable,
            _m_DesperateMeasureSelectable,
            _m_LabelSelectable);
    }
}


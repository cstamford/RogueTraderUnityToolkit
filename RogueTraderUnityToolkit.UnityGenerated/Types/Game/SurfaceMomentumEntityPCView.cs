namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $SurfaceMomentumEntityPCView (11 fields) 3C81A5CF8B69A2D8CA8FA00571762F0C/EF5C6F46976925655F21CD95D9D17D02 */
public record class SurfaceMomentumEntityPCView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<DelayedSlider> m_CurrentSlider /* NeedsAlign */,
    PPtr<Slider> m_HeroicActSlider /* None */,
    PPtr<Slider> m_DesperateMeasureSlider /* None */,
    PPtr<OwlcatMultiSelectable> m_HeroicActSelectable /* None */,
    PPtr<OwlcatMultiSelectable> m_DesperateMeasureSelectable /* None */,
    PPtr<OwlcatMultiSelectable> m_LabelSelectable /* None */,
    PPtr<Image> m_HintPlace /* None */)
{
    public static SurfaceMomentumEntityPCView Read(EndianBinaryReader reader)
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
        PPtr<Image> _m_HintPlace = PPtr<Image>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_CurrentSlider,
            _m_HeroicActSlider,
            _m_DesperateMeasureSlider,
            _m_HeroicActSelectable,
            _m_DesperateMeasureSelectable,
            _m_LabelSelectable,
            _m_HintPlace);
    }
}


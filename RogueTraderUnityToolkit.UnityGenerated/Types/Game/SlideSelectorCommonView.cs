namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $SlideSelectorCommonView (15 fields) 64FC5B07533B1EBCBB4DC6A6E20A3387/2C59DE8B7BDDA8B53E96253F4AB15224 */
public record class SlideSelectorCommonView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<OwlcatMultiSelectable> m_Selectable /* NeedsAlign */,
    PPtr<Slider> m_Slider /* None */,
    byte m_CalculateHandleSize /* None */,
    PPtr<RectTransform> m_SliderRect /* NeedsAlign */,
    PPtr<RectTransform> m_SliderSlideArea /* None */,
    PPtr<OwlcatMultiButton> m_ButtonNext /* None */,
    PPtr<OwlcatMultiButton> m_ButtonPrevious /* None */,
    PPtr<TextMeshProUGUI> m_Value /* None */,
    PPtr<TextMeshProUGUI> m_Counter /* None */,
    PPtr<TextMeshProUGUI> m_Label /* None */,
    VirtualListLayoutElementSettings m_LayoutSettings /* None */)
{
    public static SlideSelectorCommonView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_Selectable */
        PPtr<OwlcatMultiSelectable> _m_Selectable = PPtr<OwlcatMultiSelectable>.Read(reader);
        PPtr<Slider> _m_Slider = PPtr<Slider>.Read(reader);
        byte _m_CalculateHandleSize = reader.ReadU8();
        reader.AlignTo(4); /* m_SliderRect */
        PPtr<RectTransform> _m_SliderRect = PPtr<RectTransform>.Read(reader);
        PPtr<RectTransform> _m_SliderSlideArea = PPtr<RectTransform>.Read(reader);
        PPtr<OwlcatMultiButton> _m_ButtonNext = PPtr<OwlcatMultiButton>.Read(reader);
        PPtr<OwlcatMultiButton> _m_ButtonPrevious = PPtr<OwlcatMultiButton>.Read(reader);
        PPtr<TextMeshProUGUI> _m_Value = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<TextMeshProUGUI> _m_Counter = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<TextMeshProUGUI> _m_Label = PPtr<TextMeshProUGUI>.Read(reader);
        VirtualListLayoutElementSettings _m_LayoutSettings = VirtualListLayoutElementSettings.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_Selectable,
            _m_Slider,
            _m_CalculateHandleSize,
            _m_SliderRect,
            _m_SliderSlideArea,
            _m_ButtonNext,
            _m_ButtonPrevious,
            _m_Value,
            _m_Counter,
            _m_Label,
            _m_LayoutSettings);
    }
}


namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $BrickSliderValueView (9 fields) 0FEBA4F6518A1AD3EB4E5578C65AD74B/CFCE3EEF4CE3531CC9A6B38BBE243097 */
public record class BrickSliderValueView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<Slider> m_Slider /* NeedsAlign */,
    PPtr<TextMeshProUGUI> BottomText /* None */,
    PPtr<TextMeshProUGUI> TopText /* None */,
    PPtr<Image> Image /* None */,
    PPtr<Image> m_FillImage /* None */)
{
    public static BrickSliderValueView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_Slider */
        PPtr<Slider> _m_Slider = PPtr<Slider>.Read(reader);
        PPtr<TextMeshProUGUI> _BottomText = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<TextMeshProUGUI> _TopText = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<Image> _Image = PPtr<Image>.Read(reader);
        PPtr<Image> _m_FillImage = PPtr<Image>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_Slider,
            _BottomText,
            _TopText,
            _Image,
            _m_FillImage);
    }
}


namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $CounterWindowPCView (12 fields) BCB43D24F39299EB61470858D693A2B6/0DD059F2263507D156357E90F8BEFB20 */
public record class CounterWindowPCView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<TextMeshProUGUI> m_ItemName /* NeedsAlign */,
    PPtr<Image> m_ItemIcon /* None */,
    PPtr<Slider> m_CountSlider /* None */,
    PPtr<TextMeshProUGUI> m_CountText /* None */,
    PPtr<OwlcatButton> m_OperationButton /* None */,
    PPtr<TextMeshProUGUI> m_ButtonLabel /* None */,
    PPtr<OwlcatButton> m_CloseButton /* None */,
    PPtr<TextMeshProUGUI> m_CloseButtonLabel /* None */)
{
    public static CounterWindowPCView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_ItemName */
        PPtr<TextMeshProUGUI> _m_ItemName = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<Image> _m_ItemIcon = PPtr<Image>.Read(reader);
        PPtr<Slider> _m_CountSlider = PPtr<Slider>.Read(reader);
        PPtr<TextMeshProUGUI> _m_CountText = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<OwlcatButton> _m_OperationButton = PPtr<OwlcatButton>.Read(reader);
        PPtr<TextMeshProUGUI> _m_ButtonLabel = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<OwlcatButton> _m_CloseButton = PPtr<OwlcatButton>.Read(reader);
        PPtr<TextMeshProUGUI> _m_CloseButtonLabel = PPtr<TextMeshProUGUI>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_ItemName,
            _m_ItemIcon,
            _m_CountSlider,
            _m_CountText,
            _m_OperationButton,
            _m_ButtonLabel,
            _m_CloseButton,
            _m_CloseButtonLabel);
    }
}


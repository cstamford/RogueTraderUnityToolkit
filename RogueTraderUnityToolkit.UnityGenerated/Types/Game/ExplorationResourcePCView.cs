namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $ExplorationResourcePCView (8 fields) B56114EF10741933781A864C2AD0F20B/55579ECF460A5CAA2DD5C047010D088E */
public record class ExplorationResourcePCView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<Image> m_Icon /* NeedsAlign */,
    PPtr<TextMeshProUGUI> m_NameLabel /* None */,
    PPtr<TextMeshProUGUI> m_CountLabel /* None */,
    PPtr<OwlcatMultiButton> m_FocusButton /* None */)
{
    public static ExplorationResourcePCView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_Icon */
        PPtr<Image> _m_Icon = PPtr<Image>.Read(reader);
        PPtr<TextMeshProUGUI> _m_NameLabel = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<TextMeshProUGUI> _m_CountLabel = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<OwlcatMultiButton> _m_FocusButton = PPtr<OwlcatMultiButton>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_Icon,
            _m_NameLabel,
            _m_CountLabel,
            _m_FocusButton);
    }
}


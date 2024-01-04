namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $VendorReputationForItemConsoleView (8 fields) F5FB24B9B77D394554D4A0A6A2F9FCE7/D34ED506EB0A1BBB1FCB4B4102009E8C */
public record class VendorReputationForItemConsoleView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<TextMeshProUGUI> m_NameLabel /* NeedsAlign */,
    PPtr<TextMeshProUGUI> m_ReputationValue /* None */,
    PPtr<Image> m_Image /* None */,
    PPtr<OwlcatMultiButton> m_FocusButton /* None */)
{
    public static VendorReputationForItemConsoleView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_NameLabel */
        PPtr<TextMeshProUGUI> _m_NameLabel = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<TextMeshProUGUI> _m_ReputationValue = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<Image> _m_Image = PPtr<Image>.Read(reader);
        PPtr<OwlcatMultiButton> _m_FocusButton = PPtr<OwlcatMultiButton>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_NameLabel,
            _m_ReputationValue,
            _m_Image,
            _m_FocusButton);
    }
}


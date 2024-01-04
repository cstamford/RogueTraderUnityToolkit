namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $ColonyEventConsoleView (8 fields) 3A55A79B40C9ADB7468ADD17045EDEEF/96F4C8F978D74CD169DDAF11ABBABC61 */
public record class ColonyEventConsoleView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<TextMeshProUGUI> m_NameLabel /* NeedsAlign */,
    PPtr<TextMeshProUGUI> m_MechanicString /* None */,
    PPtr<Image> m_Icon /* None */,
    PPtr<OwlcatButton> m_Button /* None */)
{
    public static ColonyEventConsoleView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_NameLabel */
        PPtr<TextMeshProUGUI> _m_NameLabel = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<TextMeshProUGUI> _m_MechanicString = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<Image> _m_Icon = PPtr<Image>.Read(reader);
        PPtr<OwlcatButton> _m_Button = PPtr<OwlcatButton>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_NameLabel,
            _m_MechanicString,
            _m_Icon,
            _m_Button);
    }
}


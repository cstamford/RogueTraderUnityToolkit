namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $CargoSlotConsoleView (8 fields) BDA055DB70BA5029E29B015DCCF2AFA3/331B413D9B957DF3CEB26F8C21A582A4 */
public record class CargoSlotConsoleView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<OwlcatMultiButton> m_MainButton /* NeedsAlign */,
    PPtr<Image> m_TypeIcon /* None */,
    PPtr<TextMeshProUGUI> m_TypeLabel /* None */,
    PPtr<TextMeshProUGUI> m_FillValue /* None */)
{
    public static CargoSlotConsoleView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_MainButton */
        PPtr<OwlcatMultiButton> _m_MainButton = PPtr<OwlcatMultiButton>.Read(reader);
        PPtr<Image> _m_TypeIcon = PPtr<Image>.Read(reader);
        PPtr<TextMeshProUGUI> _m_TypeLabel = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<TextMeshProUGUI> _m_FillValue = PPtr<TextMeshProUGUI>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_MainButton,
            _m_TypeIcon,
            _m_TypeLabel,
            _m_FillValue);
    }
}


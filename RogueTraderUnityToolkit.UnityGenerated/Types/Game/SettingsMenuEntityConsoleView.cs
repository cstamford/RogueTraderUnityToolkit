namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $SettingsMenuEntityConsoleView (6 fields) 282A54673AE94FACA045FF87AAC3FDEF/C79D0321DDA49677FB5715D02556AFD5 */
public record class SettingsMenuEntityConsoleView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<OwlcatMultiButton> m_MultiButton /* NeedsAlign */,
    PPtr<TextMeshProUGUI> m_Title /* None */)
{
    public static SettingsMenuEntityConsoleView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_MultiButton */
        PPtr<OwlcatMultiButton> _m_MultiButton = PPtr<OwlcatMultiButton>.Read(reader);
        PPtr<TextMeshProUGUI> _m_Title = PPtr<TextMeshProUGUI>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_MultiButton,
            _m_Title);
    }
}


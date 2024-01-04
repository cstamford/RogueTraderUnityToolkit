namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $SettingsEntityHeaderConsoleView (7 fields) 1E775E0C2B84C16B735F33BB01F8691B/238F9D3A4CC4139D836E9A6D410F3E6D */
public record class SettingsEntityHeaderConsoleView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<TextMeshProUGUI> m_Tittle /* NeedsAlign */,
    VirtualListLayoutElementSettings m_LayoutElementSettings /* None */,
    PPtr<OwlcatMultiButton> m_SelectableMultiButton /* NeedsAlign */)
{
    public static SettingsEntityHeaderConsoleView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_Tittle */
        PPtr<TextMeshProUGUI> _m_Tittle = PPtr<TextMeshProUGUI>.Read(reader);
        VirtualListLayoutElementSettings _m_LayoutElementSettings = VirtualListLayoutElementSettings.Read(reader);
        reader.AlignTo(4); /* m_SelectableMultiButton */
        PPtr<OwlcatMultiButton> _m_SelectableMultiButton = PPtr<OwlcatMultiButton>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_Tittle,
            _m_LayoutElementSettings,
            _m_SelectableMultiButton);
    }
}


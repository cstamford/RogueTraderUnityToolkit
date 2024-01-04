namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $GameOverConsoleView (8 fields) 0FD3A86BB001E52EF52D608FD1918E57/4850CF1ABFB3A4F952469D3D240F7C24 */
public record class GameOverConsoleView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<TextMeshProUGUI> m_ResultText /* NeedsAlign */,
    PPtr<OwlcatButton> m_QuickLoadButton /* None */,
    PPtr<OwlcatButton> m_LoadButton /* None */,
    PPtr<OwlcatButton> m_MainMenuButton /* None */)
{
    public static GameOverConsoleView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_ResultText */
        PPtr<TextMeshProUGUI> _m_ResultText = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<OwlcatButton> _m_QuickLoadButton = PPtr<OwlcatButton>.Read(reader);
        PPtr<OwlcatButton> _m_LoadButton = PPtr<OwlcatButton>.Read(reader);
        PPtr<OwlcatButton> _m_MainMenuButton = PPtr<OwlcatButton>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_ResultText,
            _m_QuickLoadButton,
            _m_LoadButton,
            _m_MainMenuButton);
    }
}


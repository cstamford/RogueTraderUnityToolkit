namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $TooltipBrickButtonConsoleView (7 fields) 80319704C878F5395EA2F072E9CFB7BB/0A6A2B3C48CABB0ACC3E0C74FC9D0EEB */
public record class TooltipBrickButtonConsoleView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<OwlcatButton> m_Button /* NeedsAlign */,
    PPtr<TextMeshProUGUI> m_Text /* None */,
    PPtr<OwlcatMultiButton> m_ConsoleButton /* None */)
{
    public static TooltipBrickButtonConsoleView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_Button */
        PPtr<OwlcatButton> _m_Button = PPtr<OwlcatButton>.Read(reader);
        PPtr<TextMeshProUGUI> _m_Text = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<OwlcatMultiButton> _m_ConsoleButton = PPtr<OwlcatMultiButton>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_Button,
            _m_Text,
            _m_ConsoleButton);
    }
}


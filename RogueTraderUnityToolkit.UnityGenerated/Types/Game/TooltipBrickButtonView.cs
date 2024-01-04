namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $TooltipBrickButtonView (6 fields) EE2397CA5A313D87576CDC8299ADCC66/C5846207D0C00CAA9C64F1455E9B08D4 */
public record class TooltipBrickButtonView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<OwlcatButton> m_Button /* NeedsAlign */,
    PPtr<TextMeshProUGUI> m_Text /* None */)
{
    public static TooltipBrickButtonView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_Button */
        PPtr<OwlcatButton> _m_Button = PPtr<OwlcatButton>.Read(reader);
        PPtr<TextMeshProUGUI> _m_Text = PPtr<TextMeshProUGUI>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_Button,
            _m_Text);
    }
}


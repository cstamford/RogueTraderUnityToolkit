namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $DropdownItemView (7 fields) 759855E242462D4B6F5ACFB7D55841F1/4CC5B0ED871BE4F4308482B564AD5496 */
public record class DropdownItemView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<OwlcatToggle> m_Toggle /* NeedsAlign */,
    PPtr<TextMeshProUGUI> m_Text /* None */,
    PPtr<Image> m_Image /* None */)
{
    public static DropdownItemView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_Toggle */
        PPtr<OwlcatToggle> _m_Toggle = PPtr<OwlcatToggle>.Read(reader);
        PPtr<TextMeshProUGUI> _m_Text = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<Image> _m_Image = PPtr<Image>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_Toggle,
            _m_Text,
            _m_Image);
    }
}


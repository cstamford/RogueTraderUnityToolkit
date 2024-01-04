namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $SettingsEntityDisplayImagesConsoleView (11 fields) 1CFFABEDBDE630063560ECE72025E634/10F6EB82EEED0C05AF4F6A04FCB3F479 */
public record class SettingsEntityDisplayImagesConsoleView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<Image> m_DisplayImage_1 /* NeedsAlign */,
    PPtr<Image> m_DisplayImage_2 /* None */,
    PPtr<Image> m_DisplayImage_3 /* None */,
    PPtr<TextMeshProUGUI> m_DisplayImageText_1 /* None */,
    PPtr<TextMeshProUGUI> m_DisplayImageText_2 /* None */,
    PPtr<TextMeshProUGUI> m_DisplayImageText_3 /* None */,
    VirtualListLayoutElementSettings m_LayoutSettings /* None */)
{
    public static SettingsEntityDisplayImagesConsoleView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_DisplayImage_1 */
        PPtr<Image> _m_DisplayImage_1 = PPtr<Image>.Read(reader);
        PPtr<Image> _m_DisplayImage_2 = PPtr<Image>.Read(reader);
        PPtr<Image> _m_DisplayImage_3 = PPtr<Image>.Read(reader);
        PPtr<TextMeshProUGUI> _m_DisplayImageText_1 = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<TextMeshProUGUI> _m_DisplayImageText_2 = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<TextMeshProUGUI> _m_DisplayImageText_3 = PPtr<TextMeshProUGUI>.Read(reader);
        VirtualListLayoutElementSettings _m_LayoutSettings = VirtualListLayoutElementSettings.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_DisplayImage_1,
            _m_DisplayImage_2,
            _m_DisplayImage_3,
            _m_DisplayImageText_1,
            _m_DisplayImageText_2,
            _m_DisplayImageText_3,
            _m_LayoutSettings);
    }
}


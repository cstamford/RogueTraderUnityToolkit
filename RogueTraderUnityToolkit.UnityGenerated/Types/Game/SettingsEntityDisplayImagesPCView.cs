namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $SettingsEntityDisplayImagesPCView (14 fields) F262F066427FFC8DD8537FAFB368E895/A5EC1320ACF9FD0D3C4319B9D9837FA5 */
public record class SettingsEntityDisplayImagesPCView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<GameObject> m_SetConnector /* NeedsAlign */,
    PPtr<GameObject> m_SetConnectorIAmSet /* None */,
    PPtr<TextMeshProUGUI> m_Title /* None */,
    PPtr<Image> m_DisplayImage_1 /* None */,
    PPtr<Image> m_DisplayImage_2 /* None */,
    PPtr<Image> m_DisplayImage_3 /* None */,
    PPtr<TextMeshProUGUI> m_DisplayImageText_1 /* None */,
    PPtr<TextMeshProUGUI> m_DisplayImageText_2 /* None */,
    PPtr<TextMeshProUGUI> m_DisplayImageText_3 /* None */,
    VirtualListLayoutElementSettings m_LayoutSettings /* None */)
{
    public static SettingsEntityDisplayImagesPCView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_SetConnector */
        PPtr<GameObject> _m_SetConnector = PPtr<GameObject>.Read(reader);
        PPtr<GameObject> _m_SetConnectorIAmSet = PPtr<GameObject>.Read(reader);
        PPtr<TextMeshProUGUI> _m_Title = PPtr<TextMeshProUGUI>.Read(reader);
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
            _m_SetConnector,
            _m_SetConnectorIAmSet,
            _m_Title,
            _m_DisplayImage_1,
            _m_DisplayImage_2,
            _m_DisplayImage_3,
            _m_DisplayImageText_1,
            _m_DisplayImageText_2,
            _m_DisplayImageText_3,
            _m_LayoutSettings);
    }
}


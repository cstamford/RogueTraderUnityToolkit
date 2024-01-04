namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $MessageBoxPCView (11 fields) 2FFBE604E331C8331D721E44B7D1941B/A52D84826F2FD6C525149A534F154120 */
public record class MessageBoxPCView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<TextMeshProUGUI> m_MessageText /* NeedsAlign */,
    PPtr<TMPLinkHandler> m_LinkHandler /* None */,
    PPtr<TMP_InputField> m_InputField /* None */,
    PPtr<OwlcatButton> m_AcceptButton /* None */,
    PPtr<OwlcatButton> m_DeclineButton /* None */,
    PPtr<TextMeshProUGUI> m_AcceptText /* None */,
    PPtr<TextMeshProUGUI> m_DeclineText /* None */)
{
    public static MessageBoxPCView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_MessageText */
        PPtr<TextMeshProUGUI> _m_MessageText = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<TMPLinkHandler> _m_LinkHandler = PPtr<TMPLinkHandler>.Read(reader);
        PPtr<TMP_InputField> _m_InputField = PPtr<TMP_InputField>.Read(reader);
        PPtr<OwlcatButton> _m_AcceptButton = PPtr<OwlcatButton>.Read(reader);
        PPtr<OwlcatButton> _m_DeclineButton = PPtr<OwlcatButton>.Read(reader);
        PPtr<TextMeshProUGUI> _m_AcceptText = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<TextMeshProUGUI> _m_DeclineText = PPtr<TextMeshProUGUI>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_MessageText,
            _m_LinkHandler,
            _m_InputField,
            _m_AcceptButton,
            _m_DeclineButton,
            _m_AcceptText,
            _m_DeclineText);
    }
}


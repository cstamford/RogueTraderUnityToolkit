namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $CharGenChangeNameMessageBoxPCView (13 fields) 2152ED6CF3A6A70E426E40EF82CA145F/041930263F9C181682E5819654F25D7F */
public record class CharGenChangeNameMessageBoxPCView(
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
    PPtr<TextMeshProUGUI> m_DeclineText /* None */,
    PPtr<OwlcatButton> m_RandomNameButton /* None */,
    PPtr<TextMeshProUGUI> m_RandomNameLabel /* None */)
{
    public static CharGenChangeNameMessageBoxPCView Read(EndianBinaryReader reader)
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
        PPtr<OwlcatButton> _m_RandomNameButton = PPtr<OwlcatButton>.Read(reader);
        PPtr<TextMeshProUGUI> _m_RandomNameLabel = PPtr<TextMeshProUGUI>.Read(reader);
        
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
            _m_DeclineText,
            _m_RandomNameButton,
            _m_RandomNameLabel);
    }
}


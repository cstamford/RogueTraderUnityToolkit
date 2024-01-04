namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $CharGenChangeNameMessageBoxConsoleView (8 fields) C7014B6BB53ADE83E538AE89DFF5FBB2/C646FC2BB57C7E6F57BCDE76AEAD1272 */
public record class CharGenChangeNameMessageBoxConsoleView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<TextMeshProUGUI> m_MessageText /* NeedsAlign */,
    PPtr<TMPLinkHandler> m_LinkHandler /* None */,
    PPtr<ConsoleInputField> m_InputField /* None */,
    PPtr<ConsoleHintsWidget> m_HintsWidget /* None */)
{
    public static CharGenChangeNameMessageBoxConsoleView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_MessageText */
        PPtr<TextMeshProUGUI> _m_MessageText = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<TMPLinkHandler> _m_LinkHandler = PPtr<TMPLinkHandler>.Read(reader);
        PPtr<ConsoleInputField> _m_InputField = PPtr<ConsoleInputField>.Read(reader);
        PPtr<ConsoleHintsWidget> _m_HintsWidget = PPtr<ConsoleHintsWidget>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_MessageText,
            _m_LinkHandler,
            _m_InputField,
            _m_HintsWidget);
    }
}


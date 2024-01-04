namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $ItemsFilterSearchConsoleView (8 fields) 77E3AE7DC7F4D0FB6D84DA3CDA680054/4A27829281C9CBCEF3028436CC388BF4 */
public record class ItemsFilterSearchConsoleView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<TMP_InputField> m_InputField /* NeedsAlign */,
    PPtr<TextMeshProUGUI> m_Placeholder /* None */,
    PPtr<ConsoleInputField> m_ConsoleInputField /* None */,
    PPtr<ConsoleHint> m_SearchHint /* None */)
{
    public static ItemsFilterSearchConsoleView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_InputField */
        PPtr<TMP_InputField> _m_InputField = PPtr<TMP_InputField>.Read(reader);
        PPtr<TextMeshProUGUI> _m_Placeholder = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<ConsoleInputField> _m_ConsoleInputField = PPtr<ConsoleInputField>.Read(reader);
        PPtr<ConsoleHint> _m_SearchHint = PPtr<ConsoleHint>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_InputField,
            _m_Placeholder,
            _m_ConsoleInputField,
            _m_SearchHint);
    }
}


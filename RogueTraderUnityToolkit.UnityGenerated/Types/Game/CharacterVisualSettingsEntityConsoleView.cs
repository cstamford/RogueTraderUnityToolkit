namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $CharacterVisualSettingsEntityConsoleView (9 fields) 2CE849C5AB7431D5D4A244819E1EE6F9/6B61688B550D48E744326F1B25379A36 */
public record class CharacterVisualSettingsEntityConsoleView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<TextMeshProUGUI> m_Label /* NeedsAlign */,
    PPtr<OwlcatMultiButton> m_Button /* None */,
    PPtr<OwlcatMultiButton> m_FocusButton /* None */,
    PPtr<ConsoleHint> m_LeftHint /* None */,
    PPtr<ConsoleHint> m_RightHint /* None */)
{
    public static CharacterVisualSettingsEntityConsoleView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_Label */
        PPtr<TextMeshProUGUI> _m_Label = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<OwlcatMultiButton> _m_Button = PPtr<OwlcatMultiButton>.Read(reader);
        PPtr<OwlcatMultiButton> _m_FocusButton = PPtr<OwlcatMultiButton>.Read(reader);
        PPtr<ConsoleHint> _m_LeftHint = PPtr<ConsoleHint>.Read(reader);
        PPtr<ConsoleHint> _m_RightHint = PPtr<ConsoleHint>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_Label,
            _m_Button,
            _m_FocusButton,
            _m_LeftHint,
            _m_RightHint);
    }
}


namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $GamepadConnectedInKeyboardModeWindowView (9 fields) 36ED7886FB770DC61CF4BE33E06D6A84/294189CABB196EE6CEF061ADFB4A39A4 */
public record class GamepadConnectedInKeyboardModeWindowView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<ConsoleHint> m_ConfirmHint /* NeedsAlign */,
    PPtr<ConsoleHint> m_DeclineHint /* None */,
    PPtr<WindowAnimator> m_WindowAnimator /* None */,
    PPtr<TextMeshProUGUI> m_HeaderLabel /* None */,
    PPtr<TextMeshProUGUI> m_HintLabel /* None */)
{
    public static GamepadConnectedInKeyboardModeWindowView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_ConfirmHint */
        PPtr<ConsoleHint> _m_ConfirmHint = PPtr<ConsoleHint>.Read(reader);
        PPtr<ConsoleHint> _m_DeclineHint = PPtr<ConsoleHint>.Read(reader);
        PPtr<WindowAnimator> _m_WindowAnimator = PPtr<WindowAnimator>.Read(reader);
        PPtr<TextMeshProUGUI> _m_HeaderLabel = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<TextMeshProUGUI> _m_HintLabel = PPtr<TextMeshProUGUI>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_ConfirmHint,
            _m_DeclineHint,
            _m_WindowAnimator,
            _m_HeaderLabel,
            _m_HintLabel);
    }
}


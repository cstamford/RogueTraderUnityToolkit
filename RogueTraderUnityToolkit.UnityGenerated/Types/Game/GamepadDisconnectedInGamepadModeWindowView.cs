namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $GamepadDisconnectedInGamepadModeWindowView (11 fields) 7F3BC6DB7F7669EDA3659A4D5F6806A9/932B6899FF58F66657958A7F14BBD42B */
public record class GamepadDisconnectedInGamepadModeWindowView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<OwlcatButton> m_ConfirmButton /* NeedsAlign */,
    PPtr<OwlcatButton> m_DeclineButton /* None */,
    PPtr<TextMeshProUGUI> m_ConfirmLabel /* None */,
    PPtr<TextMeshProUGUI> m_DeclineLabel /* None */,
    PPtr<WindowAnimator> m_WindowAnimator /* None */,
    PPtr<TextMeshProUGUI> m_BodyLabel /* None */,
    PPtr<TextMeshProUGUI> m_HintLabel /* None */)
{
    public static GamepadDisconnectedInGamepadModeWindowView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_ConfirmButton */
        PPtr<OwlcatButton> _m_ConfirmButton = PPtr<OwlcatButton>.Read(reader);
        PPtr<OwlcatButton> _m_DeclineButton = PPtr<OwlcatButton>.Read(reader);
        PPtr<TextMeshProUGUI> _m_ConfirmLabel = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<TextMeshProUGUI> _m_DeclineLabel = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<WindowAnimator> _m_WindowAnimator = PPtr<WindowAnimator>.Read(reader);
        PPtr<TextMeshProUGUI> _m_BodyLabel = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<TextMeshProUGUI> _m_HintLabel = PPtr<TextMeshProUGUI>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_ConfirmButton,
            _m_DeclineButton,
            _m_ConfirmLabel,
            _m_DeclineLabel,
            _m_WindowAnimator,
            _m_BodyLabel,
            _m_HintLabel);
    }
}


namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $SettingsControlConsole (21 fields) B3F2F7BBCBED12611E5B85AE53DCDE90/734303D992F79B625A26C30E2F042DAB */
public record class SettingsControlConsole(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<ConsoleHint> LeftStickButtonHint /* NeedsAlign */,
    PPtr<ConsoleHint> DPadRightHint /* None */,
    PPtr<ConsoleHint> DPadDownHint /* None */,
    PPtr<ConsoleHint> DPadLeftHint /* None */,
    PPtr<ConsoleHint> DPadUpHint /* None */,
    PPtr<ConsoleHint> LeftUpHint /* None */,
    PPtr<ConsoleHint> LeftBottomHint /* None */,
    PPtr<ConsoleHint> FuncAdditionalHint /* None */,
    PPtr<ConsoleHint> RightBottomHint /* None */,
    PPtr<ConsoleHint> RightUpHint /* None */,
    PPtr<ConsoleHint> OptionsHint /* None */,
    PPtr<ConsoleHint> Func02Hint /* None */,
    PPtr<ConsoleHint> DeclineHint /* None */,
    PPtr<ConsoleHint> ConfirmHint /* None */,
    PPtr<ConsoleHint> Func01Hint /* None */,
    PPtr<ConsoleHint> RightStickButtonHint /* None */,
    PPtr<TextMeshProUGUI> ConsoleCoopPingHint /* None */)
{
    public static SettingsControlConsole Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* LeftStickButtonHint */
        PPtr<ConsoleHint> _LeftStickButtonHint = PPtr<ConsoleHint>.Read(reader);
        PPtr<ConsoleHint> _DPadRightHint = PPtr<ConsoleHint>.Read(reader);
        PPtr<ConsoleHint> _DPadDownHint = PPtr<ConsoleHint>.Read(reader);
        PPtr<ConsoleHint> _DPadLeftHint = PPtr<ConsoleHint>.Read(reader);
        PPtr<ConsoleHint> _DPadUpHint = PPtr<ConsoleHint>.Read(reader);
        PPtr<ConsoleHint> _LeftUpHint = PPtr<ConsoleHint>.Read(reader);
        PPtr<ConsoleHint> _LeftBottomHint = PPtr<ConsoleHint>.Read(reader);
        PPtr<ConsoleHint> _FuncAdditionalHint = PPtr<ConsoleHint>.Read(reader);
        PPtr<ConsoleHint> _RightBottomHint = PPtr<ConsoleHint>.Read(reader);
        PPtr<ConsoleHint> _RightUpHint = PPtr<ConsoleHint>.Read(reader);
        PPtr<ConsoleHint> _OptionsHint = PPtr<ConsoleHint>.Read(reader);
        PPtr<ConsoleHint> _Func02Hint = PPtr<ConsoleHint>.Read(reader);
        PPtr<ConsoleHint> _DeclineHint = PPtr<ConsoleHint>.Read(reader);
        PPtr<ConsoleHint> _ConfirmHint = PPtr<ConsoleHint>.Read(reader);
        PPtr<ConsoleHint> _Func01Hint = PPtr<ConsoleHint>.Read(reader);
        PPtr<ConsoleHint> _RightStickButtonHint = PPtr<ConsoleHint>.Read(reader);
        PPtr<TextMeshProUGUI> _ConsoleCoopPingHint = PPtr<TextMeshProUGUI>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _LeftStickButtonHint,
            _DPadRightHint,
            _DPadDownHint,
            _DPadLeftHint,
            _DPadUpHint,
            _LeftUpHint,
            _LeftBottomHint,
            _FuncAdditionalHint,
            _RightBottomHint,
            _RightUpHint,
            _OptionsHint,
            _Func02Hint,
            _DeclineHint,
            _ConfirmHint,
            _Func01Hint,
            _RightStickButtonHint,
            _ConsoleCoopPingHint);
    }
}


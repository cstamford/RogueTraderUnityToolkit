namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $OwlcatInputField (7 fields) D978C662230093E58AE0DA4ABE550341/18E6C311B75754DB13F7A7663DDDB9EA */
public record class OwlcatInputField(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<TMP_InputField> m_InputField /* NeedsAlign */,
    PPtr<ConsoleHint> m_ConfirmHint /* None */,
    PPtr<OwlcatMultiButton> m_Button /* None */)
{
    public static OwlcatInputField Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_InputField */
        PPtr<TMP_InputField> _m_InputField = PPtr<TMP_InputField>.Read(reader);
        PPtr<ConsoleHint> _m_ConfirmHint = PPtr<ConsoleHint>.Read(reader);
        PPtr<OwlcatMultiButton> _m_Button = PPtr<OwlcatMultiButton>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_InputField,
            _m_ConfirmHint,
            _m_Button);
    }
}


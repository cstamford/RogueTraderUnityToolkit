namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $ConsoleInputField (7 fields) D07585FA19DC8D26A011B25AF4B0B251/FD2BFFA4A9DC1CB0FC7F42B392E56313 */
public record class ConsoleInputField(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<OwlcatMultiButton> m_Button /* NeedsAlign */,
    PPtr<TMP_InputField> m_InputField /* None */,
    PPtr<GameObject> m_EditGameObject /* None */)
{
    public static ConsoleInputField Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_Button */
        PPtr<OwlcatMultiButton> _m_Button = PPtr<OwlcatMultiButton>.Read(reader);
        PPtr<TMP_InputField> _m_InputField = PPtr<TMP_InputField>.Read(reader);
        PPtr<GameObject> _m_EditGameObject = PPtr<GameObject>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_Button,
            _m_InputField,
            _m_EditGameObject);
    }
}


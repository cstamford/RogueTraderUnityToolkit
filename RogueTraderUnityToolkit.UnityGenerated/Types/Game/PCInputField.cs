namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $PCInputField (9 fields) 75CDDE95D5CA05D511966EE2316A6950/5336E25E11076C07FB2E590D058F42E6 */
public record class PCInputField(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<OwlcatButton> m_InputButton /* NeedsAlign */,
    PPtr<TextMeshProUGUI> m_EditLabel /* None */,
    PPtr<TextMeshProUGUI> m_FieldResult /* None */,
    PPtr<TMP_InputField> m_InputField /* None */,
    PPtr<TextMeshProUGUI> m_InputFieldWhenEmpty /* None */)
{
    public static PCInputField Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_InputButton */
        PPtr<OwlcatButton> _m_InputButton = PPtr<OwlcatButton>.Read(reader);
        PPtr<TextMeshProUGUI> _m_EditLabel = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<TextMeshProUGUI> _m_FieldResult = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<TMP_InputField> _m_InputField = PPtr<TMP_InputField>.Read(reader);
        PPtr<TextMeshProUGUI> _m_InputFieldWhenEmpty = PPtr<TextMeshProUGUI>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_InputButton,
            _m_EditLabel,
            _m_FieldResult,
            _m_InputField,
            _m_InputFieldWhenEmpty);
    }
}


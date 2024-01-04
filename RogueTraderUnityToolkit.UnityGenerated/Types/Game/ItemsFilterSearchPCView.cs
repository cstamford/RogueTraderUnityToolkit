namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $ItemsFilterSearchPCView (8 fields) 7DD01B02C05EA373C2BECE9CF3D027EA/4B3F1C81F49FAFB396504709F5F91100 */
public record class ItemsFilterSearchPCView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<TMP_InputField> m_InputField /* NeedsAlign */,
    PPtr<TextMeshProUGUI> m_Placeholder /* None */,
    PPtr<OwlcatButton> m_DropdownButton /* None */,
    PPtr<TMP_Dropdown> m_Dropdown /* None */)
{
    public static ItemsFilterSearchPCView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_InputField */
        PPtr<TMP_InputField> _m_InputField = PPtr<TMP_InputField>.Read(reader);
        PPtr<TextMeshProUGUI> _m_Placeholder = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<OwlcatButton> _m_DropdownButton = PPtr<OwlcatButton>.Read(reader);
        PPtr<TMP_Dropdown> _m_Dropdown = PPtr<TMP_Dropdown>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_InputField,
            _m_Placeholder,
            _m_DropdownButton,
            _m_Dropdown);
    }
}


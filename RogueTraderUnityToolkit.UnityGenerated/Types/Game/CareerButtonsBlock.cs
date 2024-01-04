namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $CareerButtonsBlock (9 fields) 678665EC9BAB4E50C92F96C613EB6859/47DE1E20DD2DF15FD5CA95E15EBFBF96 */
public record class CareerButtonsBlock(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<OwlcatButton> NextButton /* NeedsAlign */,
    PPtr<TextMeshProUGUI> NextButtonLabel /* None */,
    PPtr<OwlcatButton> BackButton /* None */,
    PPtr<TextMeshProUGUI> BackButtonLabel /* None */,
    PPtr<OwlcatButton> FirstSelectableButton /* None */)
{
    public static CareerButtonsBlock Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* NextButton */
        PPtr<OwlcatButton> _NextButton = PPtr<OwlcatButton>.Read(reader);
        PPtr<TextMeshProUGUI> _NextButtonLabel = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<OwlcatButton> _BackButton = PPtr<OwlcatButton>.Read(reader);
        PPtr<TextMeshProUGUI> _BackButtonLabel = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<OwlcatButton> _FirstSelectableButton = PPtr<OwlcatButton>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _NextButton,
            _NextButtonLabel,
            _BackButton,
            _BackButtonLabel,
            _FirstSelectableButton);
    }
}


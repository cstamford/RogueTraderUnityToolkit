namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $BookEventSkillPCView (7 fields) CD85F496B3CE49421399C6CCA206FD29/B75973CE23A92D0A5C8565972D8F3A9D */
public record class BookEventSkillPCView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<Image> m_Background /* NeedsAlign */,
    PPtr<TextMeshProUGUI> m_Value /* None */,
    PPtr<TextMeshProUGUI> m_HighlightedValue /* None */)
{
    public static BookEventSkillPCView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_Background */
        PPtr<Image> _m_Background = PPtr<Image>.Read(reader);
        PPtr<TextMeshProUGUI> _m_Value = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<TextMeshProUGUI> _m_HighlightedValue = PPtr<TextMeshProUGUI>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_Background,
            _m_Value,
            _m_HighlightedValue);
    }
}


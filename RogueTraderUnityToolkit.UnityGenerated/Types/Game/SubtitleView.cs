namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $SubtitleView (6 fields) 6E8DB24907F3F2892B2CAC8DA29DEF94/D5A4243263C0A6459712A1D6F1953A28 */
public record class SubtitleView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<TextMeshProUGUI> m_SubtitleText /* NeedsAlign */,
    PPtr<CanvasGroup> m_CanvasGroup /* None */)
{
    public static SubtitleView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_SubtitleText */
        PPtr<TextMeshProUGUI> _m_SubtitleText = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<CanvasGroup> _m_CanvasGroup = PPtr<CanvasGroup>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_SubtitleText,
            _m_CanvasGroup);
    }
}


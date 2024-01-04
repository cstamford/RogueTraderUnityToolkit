namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $EncyclopediaPageBlockBookEventPCView (10 fields) C93843D55606BCA0C95CA3BBF08021B1/CB7C2D98B25270A659275F9CFD184CCE */
public record class EncyclopediaPageBlockBookEventPCView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<GameObject> m_CueGroup /* NeedsAlign */,
    PPtr<TextMeshProUGUI> m_CueText /* None */,
    PPtr<GameObject> m_AnswerGroup /* None */,
    PPtr<TextMeshProUGUI> m_AnswerText /* None */,
    float m_DefaultFontSize /* None */,
    float m_DefaultConsoleFontSize /* None */)
{
    public static EncyclopediaPageBlockBookEventPCView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_CueGroup */
        PPtr<GameObject> _m_CueGroup = PPtr<GameObject>.Read(reader);
        PPtr<TextMeshProUGUI> _m_CueText = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<GameObject> _m_AnswerGroup = PPtr<GameObject>.Read(reader);
        PPtr<TextMeshProUGUI> _m_AnswerText = PPtr<TextMeshProUGUI>.Read(reader);
        float _m_DefaultFontSize = reader.ReadF32();
        float _m_DefaultConsoleFontSize = reader.ReadF32();
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_CueGroup,
            _m_CueText,
            _m_AnswerGroup,
            _m_AnswerText,
            _m_DefaultFontSize,
            _m_DefaultConsoleFontSize);
    }
}


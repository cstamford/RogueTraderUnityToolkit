namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $DialogAnswerPCView (9 fields) 425A28A6E2831930D1E46C4C4231E496/3323247C8CB5936AAE62AE22B21A28B5 */
public record class DialogAnswerPCView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<TextMeshProUGUI> m_AnswerText /* NeedsAlign */,
    PPtr<OwlcatMultiButton> m_OwlcatButton /* None */,
    float m_TweenDuration /* None */,
    PPtr<DialogVotesBlockView> m_DialogVotesBlock /* None */,
    float m_DefaultFontSize /* None */)
{
    public static DialogAnswerPCView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_AnswerText */
        PPtr<TextMeshProUGUI> _m_AnswerText = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<OwlcatMultiButton> _m_OwlcatButton = PPtr<OwlcatMultiButton>.Read(reader);
        float _m_TweenDuration = reader.ReadF32();
        PPtr<DialogVotesBlockView> _m_DialogVotesBlock = PPtr<DialogVotesBlockView>.Read(reader);
        float _m_DefaultFontSize = reader.ReadF32();
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_AnswerText,
            _m_OwlcatButton,
            _m_TweenDuration,
            _m_DialogVotesBlock,
            _m_DefaultFontSize);
    }
}


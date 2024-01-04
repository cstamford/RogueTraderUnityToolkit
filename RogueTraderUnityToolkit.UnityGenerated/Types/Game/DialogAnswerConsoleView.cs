namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $DialogAnswerConsoleView (10 fields) DC619170A6A927577166181CB1D5AF7B/6325E82C236B7D18981A2B729D7FB8B2 */
public record class DialogAnswerConsoleView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<TextMeshProUGUI> m_AnswerText /* NeedsAlign */,
    PPtr<OwlcatMultiButton> m_OwlcatButton /* None */,
    float m_TweenDuration /* None */,
    PPtr<DialogVotesBlockView> m_DialogVotesBlock /* None */,
    PPtr<Image> m_ConsoleHint /* None */,
    float m_DefaultConsoleFontSize /* None */)
{
    public static DialogAnswerConsoleView Read(EndianBinaryReader reader)
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
        PPtr<Image> _m_ConsoleHint = PPtr<Image>.Read(reader);
        float _m_DefaultConsoleFontSize = reader.ReadF32();
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_AnswerText,
            _m_OwlcatButton,
            _m_TweenDuration,
            _m_DialogVotesBlock,
            _m_ConsoleHint,
            _m_DefaultConsoleFontSize);
    }
}


namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $DialogVotesBlockView (9 fields) AB33B2FF07658ED4E5D7C86313A011F6/314BE49D03FA44CF51F788A886DE401B */
public record class DialogVotesBlockView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<OwlcatButton> m_VotesBlock /* NeedsAlign */,
    PPtr<Image> m_VotesOnePersonIcon /* None */,
    PPtr<TextMeshProUGUI> m_VotesText /* None */,
    PPtr<FadeAnimator> m_VotesHoverFadeAnimator /* None */,
    PPtr<TextMeshProUGUI> m_VotesHoverText /* None */)
{
    public static DialogVotesBlockView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_VotesBlock */
        PPtr<OwlcatButton> _m_VotesBlock = PPtr<OwlcatButton>.Read(reader);
        PPtr<Image> _m_VotesOnePersonIcon = PPtr<Image>.Read(reader);
        PPtr<TextMeshProUGUI> _m_VotesText = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<FadeAnimator> _m_VotesHoverFadeAnimator = PPtr<FadeAnimator>.Read(reader);
        PPtr<TextMeshProUGUI> _m_VotesHoverText = PPtr<TextMeshProUGUI>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_VotesBlock,
            _m_VotesOnePersonIcon,
            _m_VotesText,
            _m_VotesHoverFadeAnimator,
            _m_VotesHoverText);
    }
}


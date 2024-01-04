namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $CharInfoExperiencePCView (12 fields) 0A7018B34DCEE8861CDC4F3A5BE002EA/35FD42496DBC1A29A60F83A7F8B7348C */
public record class CharInfoExperiencePCView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<FadeAnimator> m_FadeAnimator /* NeedsAlign */,
    PPtr<TextMeshProUGUI> m_LevelLabel /* None */,
    PPtr<TextMeshProUGUI> m_Level /* None */,
    PPtr<GameObject> m_PsyRatingGroup /* None */,
    PPtr<Image> m_PsyRatingBgr /* None */,
    PPtr<TextMeshProUGUI> m_PsyRatingLabel /* None */,
    PPtr<TextMeshProUGUI> m_PsyRating /* None */,
    PPtr<Image> m_ExpRoundImage /* None */)
{
    public static CharInfoExperiencePCView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_FadeAnimator */
        PPtr<FadeAnimator> _m_FadeAnimator = PPtr<FadeAnimator>.Read(reader);
        PPtr<TextMeshProUGUI> _m_LevelLabel = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<TextMeshProUGUI> _m_Level = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<GameObject> _m_PsyRatingGroup = PPtr<GameObject>.Read(reader);
        PPtr<Image> _m_PsyRatingBgr = PPtr<Image>.Read(reader);
        PPtr<TextMeshProUGUI> _m_PsyRatingLabel = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<TextMeshProUGUI> _m_PsyRating = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<Image> _m_ExpRoundImage = PPtr<Image>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_FadeAnimator,
            _m_LevelLabel,
            _m_Level,
            _m_PsyRatingGroup,
            _m_PsyRatingBgr,
            _m_PsyRatingLabel,
            _m_PsyRating,
            _m_ExpRoundImage);
    }
}


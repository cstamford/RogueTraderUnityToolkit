namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $PostsBaseView (22 fields) 94B1873DA894C537ECEF9D435FE5FC39/9B849E8EE7B81B7D8419309EBDF33145 */
public record class PostsBaseView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<FadeAnimator> m_FadeAnimator /* NeedsAlign */,
    PPtr<PostSelectorView> PostSelectorView /* None */,
    PPtr<PostOfficerSelectorView> PostOfficerSelector /* None */,
    PPtr<Image> m_PostImage /* None */,
    PPtr<TextMeshProUGUI> m_PostHeader /* None */,
    PPtr<TextMeshProUGUI> m_PostHeaderName /* None */,
    PPtr<TextMeshProUGUI> m_PostDescription /* None */,
    PPtr<TextMeshProUGUI> m_PostDescriptionSkillHeader /* None */,
    PPtr<TextMeshProUGUI> m_PostDescriptionSkill /* None */,
    PPtr<TextMeshProUGUI> m_PostOfficerHeader /* None */,
    PPtr<TextMeshProUGUI> m_PostOfficerHeaderName /* None */,
    PPtr<Image> m_SkillHintPlace /* None */,
    PPtr<TextMeshProUGUI> m_PostOfficerHeaderSkillValue /* None */,
    PPtr<TextMeshProUGUI> m_PostOfficerHeaderSkillName /* None */,
    PPtr<Image> m_OfficerPortrait /* None */,
    PPtr<GameObject> m_NoOfficerPortrait /* None */,
    PPtr<PostAbilitiesGroupDetailedBaseView> m_PostAbilitiesGroupDetailedBaseView /* None */,
    PPtr<GameObject> m_LockBackground /* None */)
{
    public static PostsBaseView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_FadeAnimator */
        PPtr<FadeAnimator> _m_FadeAnimator = PPtr<FadeAnimator>.Read(reader);
        PPtr<PostSelectorView> _PostSelectorView = PPtr<PostSelectorView>.Read(reader);
        PPtr<PostOfficerSelectorView> _PostOfficerSelector = PPtr<PostOfficerSelectorView>.Read(reader);
        PPtr<Image> _m_PostImage = PPtr<Image>.Read(reader);
        PPtr<TextMeshProUGUI> _m_PostHeader = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<TextMeshProUGUI> _m_PostHeaderName = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<TextMeshProUGUI> _m_PostDescription = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<TextMeshProUGUI> _m_PostDescriptionSkillHeader = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<TextMeshProUGUI> _m_PostDescriptionSkill = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<TextMeshProUGUI> _m_PostOfficerHeader = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<TextMeshProUGUI> _m_PostOfficerHeaderName = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<Image> _m_SkillHintPlace = PPtr<Image>.Read(reader);
        PPtr<TextMeshProUGUI> _m_PostOfficerHeaderSkillValue = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<TextMeshProUGUI> _m_PostOfficerHeaderSkillName = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<Image> _m_OfficerPortrait = PPtr<Image>.Read(reader);
        PPtr<GameObject> _m_NoOfficerPortrait = PPtr<GameObject>.Read(reader);
        PPtr<PostAbilitiesGroupDetailedBaseView> _m_PostAbilitiesGroupDetailedBaseView = PPtr<PostAbilitiesGroupDetailedBaseView>.Read(reader);
        PPtr<GameObject> _m_LockBackground = PPtr<GameObject>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_FadeAnimator,
            _PostSelectorView,
            _PostOfficerSelector,
            _m_PostImage,
            _m_PostHeader,
            _m_PostHeaderName,
            _m_PostDescription,
            _m_PostDescriptionSkillHeader,
            _m_PostDescriptionSkill,
            _m_PostOfficerHeader,
            _m_PostOfficerHeaderName,
            _m_SkillHintPlace,
            _m_PostOfficerHeaderSkillValue,
            _m_PostOfficerHeaderSkillName,
            _m_OfficerPortrait,
            _m_NoOfficerPortrait,
            _m_PostAbilitiesGroupDetailedBaseView,
            _m_LockBackground);
    }
}


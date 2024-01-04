namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $CharInfoStoriesView (9 fields) 0D28D99D546707C8999C7E05F0AC6FDD/0F99D31314CC34972714DA7DD51B4EDE */
public record class CharInfoStoriesView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<FadeAnimator> m_FadeAnimator /* NeedsAlign */,
    PPtr<TextMeshProUGUI> m_BiographyTitle /* None */,
    PPtr<TextMeshProUGUI> m_BiographyText /* None */,
    PPtr<TextMeshProUGUI> m_EmptyBiographyText /* None */,
    PPtr<GameObject> m_EmptyBiographyGroup /* None */)
{
    public static CharInfoStoriesView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_FadeAnimator */
        PPtr<FadeAnimator> _m_FadeAnimator = PPtr<FadeAnimator>.Read(reader);
        PPtr<TextMeshProUGUI> _m_BiographyTitle = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<TextMeshProUGUI> _m_BiographyText = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<TextMeshProUGUI> _m_EmptyBiographyText = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<GameObject> _m_EmptyBiographyGroup = PPtr<GameObject>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_FadeAnimator,
            _m_BiographyTitle,
            _m_BiographyText,
            _m_EmptyBiographyText,
            _m_EmptyBiographyGroup);
    }
}


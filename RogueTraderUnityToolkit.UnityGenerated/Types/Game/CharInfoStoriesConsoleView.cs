namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $CharInfoStoriesConsoleView (10 fields) E5E9150B48F6000259F0FBCA0DA01969/9A8F5F27CA412F26AF554755128ED55B */
public record class CharInfoStoriesConsoleView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<FadeAnimator> m_FadeAnimator /* NeedsAlign */,
    PPtr<TextMeshProUGUI> m_BiographyTitle /* None */,
    PPtr<TextMeshProUGUI> m_BiographyText /* None */,
    PPtr<TextMeshProUGUI> m_EmptyBiographyText /* None */,
    PPtr<GameObject> m_EmptyBiographyGroup /* None */,
    PPtr<ScrollRectExtended> m_ScrollView /* None */)
{
    public static CharInfoStoriesConsoleView Read(EndianBinaryReader reader)
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
        PPtr<ScrollRectExtended> _m_ScrollView = PPtr<ScrollRectExtended>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_FadeAnimator,
            _m_BiographyTitle,
            _m_BiographyText,
            _m_EmptyBiographyText,
            _m_EmptyBiographyGroup,
            _m_ScrollView);
    }
}


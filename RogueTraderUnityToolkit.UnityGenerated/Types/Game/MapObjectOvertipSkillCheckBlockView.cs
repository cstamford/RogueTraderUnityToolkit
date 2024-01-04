namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $MapObjectOvertipSkillCheckBlockView (8 fields) CC262F69BA07D6E66FE5C8E04F1053E6/FFA245B7C2894FE5D215B3078AF0C87C */
public record class MapObjectOvertipSkillCheckBlockView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<CanvasGroup> m_CanvasGroup /* NeedsAlign */,
    PPtr<TextMeshProUGUI> m_DescriptionText /* None */,
    PPtr<TextMeshProUGUI> m_SkillCheckText /* None */,
    PPtr<FadeAnimator> m_FadeAnimator /* None */)
{
    public static MapObjectOvertipSkillCheckBlockView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_CanvasGroup */
        PPtr<CanvasGroup> _m_CanvasGroup = PPtr<CanvasGroup>.Read(reader);
        PPtr<TextMeshProUGUI> _m_DescriptionText = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<TextMeshProUGUI> _m_SkillCheckText = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<FadeAnimator> _m_FadeAnimator = PPtr<FadeAnimator>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_CanvasGroup,
            _m_DescriptionText,
            _m_SkillCheckText,
            _m_FadeAnimator);
    }
}


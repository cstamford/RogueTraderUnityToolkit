namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $CharInfoStatusEffectsConsoleView (11 fields) 0DF6E75D4CB1BAB3486AEFF8C963B0FD/3FBD4E5A2A2C81D8B9CA991BEF4DB7A0 */
public record class CharInfoStatusEffectsConsoleView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<FadeAnimator> m_FadeAnimator /* NeedsAlign */,
    PPtr<TextMeshProUGUI> m_StatusEffectsTitle /* None */,
    PPtr<FadeAnimator> m_NoStatusContainer /* None */,
    PPtr<TextMeshProUGUI> m_NoStatusEffectsLabel /* None */,
    PPtr<ScrollRectExtended> m_Scroll /* None */,
    PPtr<WidgetListMVVM> m_WidgetList /* None */,
    PPtr<CharInfoFeatureBaseView> m_WidgetEntityView /* None */)
{
    public static CharInfoStatusEffectsConsoleView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_FadeAnimator */
        PPtr<FadeAnimator> _m_FadeAnimator = PPtr<FadeAnimator>.Read(reader);
        PPtr<TextMeshProUGUI> _m_StatusEffectsTitle = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<FadeAnimator> _m_NoStatusContainer = PPtr<FadeAnimator>.Read(reader);
        PPtr<TextMeshProUGUI> _m_NoStatusEffectsLabel = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<ScrollRectExtended> _m_Scroll = PPtr<ScrollRectExtended>.Read(reader);
        PPtr<WidgetListMVVM> _m_WidgetList = PPtr<WidgetListMVVM>.Read(reader);
        PPtr<CharInfoFeatureBaseView> _m_WidgetEntityView = PPtr<CharInfoFeatureBaseView>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_FadeAnimator,
            _m_StatusEffectsTitle,
            _m_NoStatusContainer,
            _m_NoStatusEffectsLabel,
            _m_Scroll,
            _m_WidgetList,
            _m_WidgetEntityView);
    }
}


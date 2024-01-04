namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $CharInfoAbilitiesPCView (18 fields) FD87464DFBD4F9FD28D9BADF9D7FD8D7/514C2E01E965ABC7CB4A5AF8F20FEE00 */
public record class CharInfoAbilitiesPCView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<FadeAnimator> m_FadeAnimator /* NeedsAlign */,
    PPtr<WidgetListMVVM> m_WidgetList /* None */,
    PPtr<CharInfoFeatureGroupPCView> m_WidgetEntityView /* None */,
    PPtr<ScrollRectExtended> m_ScrollRect /* None */,
    byte m_ExpandAll /* None */,
    PPtr<GameObject> ActionBarContainer /* NeedsAlign */,
    PPtr<SurfaceActionBarPartAbilitiesBaseView> m_ActionBarPartAbilitiesView /* None */,
    PPtr<TextMeshProUGUI> m_ActionBarLabel /* None */,
    PPtr<OwlcatMultiButton> m_ActiveAbilities /* None */,
    PPtr<TextMeshProUGUI> m_ActiveAbilitiesLabel /* None */,
    PPtr<OwlcatMultiButton> m_PassiveAbilities /* None */,
    PPtr<TextMeshProUGUI> m_PassiveAbilitiesLabel /* None */,
    PPtr<GameObject> m_NoAbilitiesContainer /* None */,
    PPtr<TextMeshProUGUI> m_NoAbilitiesLabel /* None */)
{
    public static CharInfoAbilitiesPCView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_FadeAnimator */
        PPtr<FadeAnimator> _m_FadeAnimator = PPtr<FadeAnimator>.Read(reader);
        PPtr<WidgetListMVVM> _m_WidgetList = PPtr<WidgetListMVVM>.Read(reader);
        PPtr<CharInfoFeatureGroupPCView> _m_WidgetEntityView = PPtr<CharInfoFeatureGroupPCView>.Read(reader);
        PPtr<ScrollRectExtended> _m_ScrollRect = PPtr<ScrollRectExtended>.Read(reader);
        byte _m_ExpandAll = reader.ReadU8();
        reader.AlignTo(4); /* ActionBarContainer */
        PPtr<GameObject> _ActionBarContainer = PPtr<GameObject>.Read(reader);
        PPtr<SurfaceActionBarPartAbilitiesBaseView> _m_ActionBarPartAbilitiesView = PPtr<SurfaceActionBarPartAbilitiesBaseView>.Read(reader);
        PPtr<TextMeshProUGUI> _m_ActionBarLabel = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<OwlcatMultiButton> _m_ActiveAbilities = PPtr<OwlcatMultiButton>.Read(reader);
        PPtr<TextMeshProUGUI> _m_ActiveAbilitiesLabel = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<OwlcatMultiButton> _m_PassiveAbilities = PPtr<OwlcatMultiButton>.Read(reader);
        PPtr<TextMeshProUGUI> _m_PassiveAbilitiesLabel = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<GameObject> _m_NoAbilitiesContainer = PPtr<GameObject>.Read(reader);
        PPtr<TextMeshProUGUI> _m_NoAbilitiesLabel = PPtr<TextMeshProUGUI>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_FadeAnimator,
            _m_WidgetList,
            _m_WidgetEntityView,
            _m_ScrollRect,
            _m_ExpandAll,
            _ActionBarContainer,
            _m_ActionBarPartAbilitiesView,
            _m_ActionBarLabel,
            _m_ActiveAbilities,
            _m_ActiveAbilitiesLabel,
            _m_PassiveAbilities,
            _m_PassiveAbilitiesLabel,
            _m_NoAbilitiesContainer,
            _m_NoAbilitiesLabel);
    }
}


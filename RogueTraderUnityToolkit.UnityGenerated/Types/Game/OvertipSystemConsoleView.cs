namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $OvertipSystemConsoleView (15 fields) 30559E0A8C75A727B511B438F77F687D/21D2AB054FFB07770D38AC9B6A7E0115 */
public record class OvertipSystemConsoleView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<TextMeshProUGUI> m_PlusNavigatorResourceObject /* NeedsAlign */,
    PPtr<FadeAnimator> m_PlusNavigatorResourceAimator /* None */,
    PPtr<OvertipSystemResourceBlockView> m_ResourceBlockView /* None */,
    PPtr<Image> m_ColonizedIcon /* None */,
    PPtr<Image> m_QuestIcon /* None */,
    PPtr<TextMeshProUGUI> m_SystemName /* None */,
    PPtr<FadeAnimator> m_CircleBackgroundAnimator /* None */,
    PPtr<FadeAnimator> m_CircleBackgroundMiniAnimator /* None */,
    PPtr<SpaceSystemNavigationButtonsConsoleView> m_SpaceSystemNavigationButtonsConsoleView /* None */,
    PPtr<OwlcatButton> m_HoverButton /* None */,
    byte IsFocused /* None */)
{
    public static OvertipSystemConsoleView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_PlusNavigatorResourceObject */
        PPtr<TextMeshProUGUI> _m_PlusNavigatorResourceObject = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<FadeAnimator> _m_PlusNavigatorResourceAimator = PPtr<FadeAnimator>.Read(reader);
        PPtr<OvertipSystemResourceBlockView> _m_ResourceBlockView = PPtr<OvertipSystemResourceBlockView>.Read(reader);
        PPtr<Image> _m_ColonizedIcon = PPtr<Image>.Read(reader);
        PPtr<Image> _m_QuestIcon = PPtr<Image>.Read(reader);
        PPtr<TextMeshProUGUI> _m_SystemName = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<FadeAnimator> _m_CircleBackgroundAnimator = PPtr<FadeAnimator>.Read(reader);
        PPtr<FadeAnimator> _m_CircleBackgroundMiniAnimator = PPtr<FadeAnimator>.Read(reader);
        PPtr<SpaceSystemNavigationButtonsConsoleView> _m_SpaceSystemNavigationButtonsConsoleView = PPtr<SpaceSystemNavigationButtonsConsoleView>.Read(reader);
        PPtr<OwlcatButton> _m_HoverButton = PPtr<OwlcatButton>.Read(reader);
        byte _IsFocused = reader.ReadU8();
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_PlusNavigatorResourceObject,
            _m_PlusNavigatorResourceAimator,
            _m_ResourceBlockView,
            _m_ColonizedIcon,
            _m_QuestIcon,
            _m_SystemName,
            _m_CircleBackgroundAnimator,
            _m_CircleBackgroundMiniAnimator,
            _m_SpaceSystemNavigationButtonsConsoleView,
            _m_HoverButton,
            _IsFocused);
    }
}


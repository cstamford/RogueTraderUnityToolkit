namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $NetLobbyTutorialPartPCView (10 fields) 1DC51EA7DE92CD14B955615A489AE83D/7B797E315460F2EFE91DDA5B502E2A33 */
public record class NetLobbyTutorialPartPCView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<WidgetListMVVM> m_WidgetListTutorialBlocks /* NeedsAlign */,
    PPtr<NetLobbyTutorialBlockView> m_NetLobbyTutorialBlockViewPrefab /* None */,
    PPtr<FadeAnimator> m_PartFadeAnimator /* None */,
    PPtr<TextMeshProUGUI> m_TutorialPartLabel /* None */,
    PPtr<OwlcatButton> m_ContinueButton /* None */,
    PPtr<TextMeshProUGUI> m_ContinueButtonLabel /* None */)
{
    public static NetLobbyTutorialPartPCView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_WidgetListTutorialBlocks */
        PPtr<WidgetListMVVM> _m_WidgetListTutorialBlocks = PPtr<WidgetListMVVM>.Read(reader);
        PPtr<NetLobbyTutorialBlockView> _m_NetLobbyTutorialBlockViewPrefab = PPtr<NetLobbyTutorialBlockView>.Read(reader);
        PPtr<FadeAnimator> _m_PartFadeAnimator = PPtr<FadeAnimator>.Read(reader);
        PPtr<TextMeshProUGUI> _m_TutorialPartLabel = PPtr<TextMeshProUGUI>.Read(reader);
        PPtr<OwlcatButton> _m_ContinueButton = PPtr<OwlcatButton>.Read(reader);
        PPtr<TextMeshProUGUI> _m_ContinueButtonLabel = PPtr<TextMeshProUGUI>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_WidgetListTutorialBlocks,
            _m_NetLobbyTutorialBlockViewPrefab,
            _m_PartFadeAnimator,
            _m_TutorialPartLabel,
            _m_ContinueButton,
            _m_ContinueButtonLabel);
    }
}


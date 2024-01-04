namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $SurfaceStaticPartConsoleView (20 fields) 0FBB0C75ECA31E571A86B641C46839F7/41E855C9D13A5392165D31A7E5BEDCE4 */
public record class SurfaceStaticPartConsoleView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<UIVisibilityView> m_UIVisibilityView /* NeedsAlign */,
    PPtr<ServiceWindowsConsoleView> m_ServiceWindowsConsoleView /* None */,
    PPtr<LootContextConsoleView> m_LootContextConsoleView /* None */,
    PPtr<DialogContextConsoleView> m_DialogContextConsoleView /* None */,
    PPtr<GroupChangerContextConsoleView> m_GroupChangerContextConsoleView /* None */,
    UIViewLink_2 m_VendorConsoleViewLink /* None */,
    PPtr<VendorSelectingWindowConsoleView> m_VendorSelectingWindowContextConsoleView /* NeedsAlign */,
    PPtr<SurfaceHUDConsoleView> m_SurfaceHUDConsoleView /* None */,
    PPtr<FormationConsoleView> m_FormationConsoleView /* None */,
    PPtr<CreditsConsoleView> m_CreditsConsoleView /* None */,
    UIViewLink_2 m_TransitionConsoleViewLink /* None */,
    PPtr<EtudeCounterView> m_EtudeCounterView /* NeedsAlign */,
    PPtr<CharGenContextConsoleView> m_CharGenContextConsoleView /* None */,
    PPtr<RespecContextCommonView> m_RespecContextCommonView /* None */,
    PPtr<GameOverConsoleView> m_GameOverConsoleView /* None */,
    PPtr<SubtitleView> m_SubtitleView /* None */)
{
    public static SurfaceStaticPartConsoleView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_UIVisibilityView */
        PPtr<UIVisibilityView> _m_UIVisibilityView = PPtr<UIVisibilityView>.Read(reader);
        PPtr<ServiceWindowsConsoleView> _m_ServiceWindowsConsoleView = PPtr<ServiceWindowsConsoleView>.Read(reader);
        PPtr<LootContextConsoleView> _m_LootContextConsoleView = PPtr<LootContextConsoleView>.Read(reader);
        PPtr<DialogContextConsoleView> _m_DialogContextConsoleView = PPtr<DialogContextConsoleView>.Read(reader);
        PPtr<GroupChangerContextConsoleView> _m_GroupChangerContextConsoleView = PPtr<GroupChangerContextConsoleView>.Read(reader);
        UIViewLink_2 _m_VendorConsoleViewLink = UIViewLink_2.Read(reader);
        reader.AlignTo(4); /* m_VendorSelectingWindowContextConsoleView */
        PPtr<VendorSelectingWindowConsoleView> _m_VendorSelectingWindowContextConsoleView = PPtr<VendorSelectingWindowConsoleView>.Read(reader);
        PPtr<SurfaceHUDConsoleView> _m_SurfaceHUDConsoleView = PPtr<SurfaceHUDConsoleView>.Read(reader);
        PPtr<FormationConsoleView> _m_FormationConsoleView = PPtr<FormationConsoleView>.Read(reader);
        PPtr<CreditsConsoleView> _m_CreditsConsoleView = PPtr<CreditsConsoleView>.Read(reader);
        UIViewLink_2 _m_TransitionConsoleViewLink = UIViewLink_2.Read(reader);
        reader.AlignTo(4); /* m_EtudeCounterView */
        PPtr<EtudeCounterView> _m_EtudeCounterView = PPtr<EtudeCounterView>.Read(reader);
        PPtr<CharGenContextConsoleView> _m_CharGenContextConsoleView = PPtr<CharGenContextConsoleView>.Read(reader);
        PPtr<RespecContextCommonView> _m_RespecContextCommonView = PPtr<RespecContextCommonView>.Read(reader);
        PPtr<GameOverConsoleView> _m_GameOverConsoleView = PPtr<GameOverConsoleView>.Read(reader);
        PPtr<SubtitleView> _m_SubtitleView = PPtr<SubtitleView>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_UIVisibilityView,
            _m_ServiceWindowsConsoleView,
            _m_LootContextConsoleView,
            _m_DialogContextConsoleView,
            _m_GroupChangerContextConsoleView,
            _m_VendorConsoleViewLink,
            _m_VendorSelectingWindowContextConsoleView,
            _m_SurfaceHUDConsoleView,
            _m_FormationConsoleView,
            _m_CreditsConsoleView,
            _m_TransitionConsoleViewLink,
            _m_EtudeCounterView,
            _m_CharGenContextConsoleView,
            _m_RespecContextCommonView,
            _m_GameOverConsoleView,
            _m_SubtitleView);
    }
}


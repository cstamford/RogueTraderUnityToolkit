namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $MainMenuConsoleView (14 fields) 1C4FCFE88560574930BF1005DA04639C/F1076BBEFAFF631AA13FF81DDDF1F3AF */
public record class MainMenuConsoleView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<FadeAnimator> m_FadeAnimator /* NeedsAlign */,
    float m_DelayBeforeShow /* None */,
    PPtr<MainMenuSideBarConsoleView> m_MenuSideBarConsoleView /* None */,
    PPtr<TermsOfUseConsoleView> m_TermsOfUseConsoleView /* None */,
    PPtr<CreditsBaseView> m_CreditsView /* None */,
    PPtr<CharGenContextConsoleView> m_CharGenContextConsoleView /* None */,
    PPtr<NewGameConsoleView> m_NewGameConsoleView /* None */,
    PPtr<FirstLaunchSettingsConsoleView> m_FirstLaunchSettingsConsoleView /* None */,
    PPtr<ConsoleCursor> m_ConsoleCursor /* None */,
    PPtr<UIFirstLaunchFX> m_FirstLaunchFX /* None */)
{
    public static MainMenuConsoleView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_FadeAnimator */
        PPtr<FadeAnimator> _m_FadeAnimator = PPtr<FadeAnimator>.Read(reader);
        float _m_DelayBeforeShow = reader.ReadF32();
        PPtr<MainMenuSideBarConsoleView> _m_MenuSideBarConsoleView = PPtr<MainMenuSideBarConsoleView>.Read(reader);
        PPtr<TermsOfUseConsoleView> _m_TermsOfUseConsoleView = PPtr<TermsOfUseConsoleView>.Read(reader);
        PPtr<CreditsBaseView> _m_CreditsView = PPtr<CreditsBaseView>.Read(reader);
        PPtr<CharGenContextConsoleView> _m_CharGenContextConsoleView = PPtr<CharGenContextConsoleView>.Read(reader);
        PPtr<NewGameConsoleView> _m_NewGameConsoleView = PPtr<NewGameConsoleView>.Read(reader);
        PPtr<FirstLaunchSettingsConsoleView> _m_FirstLaunchSettingsConsoleView = PPtr<FirstLaunchSettingsConsoleView>.Read(reader);
        PPtr<ConsoleCursor> _m_ConsoleCursor = PPtr<ConsoleCursor>.Read(reader);
        PPtr<UIFirstLaunchFX> _m_FirstLaunchFX = PPtr<UIFirstLaunchFX>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_FadeAnimator,
            _m_DelayBeforeShow,
            _m_MenuSideBarConsoleView,
            _m_TermsOfUseConsoleView,
            _m_CreditsView,
            _m_CharGenContextConsoleView,
            _m_NewGameConsoleView,
            _m_FirstLaunchSettingsConsoleView,
            _m_ConsoleCursor,
            _m_FirstLaunchFX);
    }
}


namespace RogueTraderUnityToolkit.UnityGenerated.Types.Game;

using Core;
using Unity;
using Engine;

/* $MainMenuPCView (14 fields) 8CBABAB20C23BBD69E39FB5A328319A3/7B9B945393215286793754AEDA31930E */
public record class MainMenuPCView(
    PPtr<GameObject> m_GameObject /* None */,
    byte m_Enabled /* None */,
    PPtr<MonoScript> m_Script /* NeedsAlign */,
    AsciiString m_Name /* None */,
    PPtr<FadeAnimator> m_FadeAnimator /* NeedsAlign */,
    float m_DelayBeforeShow /* None */,
    PPtr<MainMenuSideBarPCView> m_MainMenuSideBarPCView /* None */,
    PPtr<TermsOfUsePCView> m_TermsOfUsePCView /* None */,
    PPtr<CreditsBaseView> m_CreditsView /* None */,
    PPtr<NewGamePCView> m_NewGamePCView /* None */,
    PPtr<CharGenContextPCView> m_CharGenContextPCView /* None */,
    PPtr<FeedbackPopupPCView> m_FeedbackPopupPCView /* None */,
    PPtr<FirstLaunchSettingsPCView> m_FirstLaunchSettingsPCView /* None */,
    PPtr<UIFirstLaunchFX> m_FirstLaunchFX /* None */)
{
    public static MainMenuPCView Read(EndianBinaryReader reader)
    {
        PPtr<GameObject> _m_GameObject = PPtr<GameObject>.Read(reader);
        byte _m_Enabled = reader.ReadU8();
        reader.AlignTo(4); /* m_Script */
        PPtr<MonoScript> _m_Script = PPtr<MonoScript>.Read(reader);
        AsciiString _m_Name = BuiltInString.Read(reader);
        reader.AlignTo(4); /* m_FadeAnimator */
        PPtr<FadeAnimator> _m_FadeAnimator = PPtr<FadeAnimator>.Read(reader);
        float _m_DelayBeforeShow = reader.ReadF32();
        PPtr<MainMenuSideBarPCView> _m_MainMenuSideBarPCView = PPtr<MainMenuSideBarPCView>.Read(reader);
        PPtr<TermsOfUsePCView> _m_TermsOfUsePCView = PPtr<TermsOfUsePCView>.Read(reader);
        PPtr<CreditsBaseView> _m_CreditsView = PPtr<CreditsBaseView>.Read(reader);
        PPtr<NewGamePCView> _m_NewGamePCView = PPtr<NewGamePCView>.Read(reader);
        PPtr<CharGenContextPCView> _m_CharGenContextPCView = PPtr<CharGenContextPCView>.Read(reader);
        PPtr<FeedbackPopupPCView> _m_FeedbackPopupPCView = PPtr<FeedbackPopupPCView>.Read(reader);
        PPtr<FirstLaunchSettingsPCView> _m_FirstLaunchSettingsPCView = PPtr<FirstLaunchSettingsPCView>.Read(reader);
        PPtr<UIFirstLaunchFX> _m_FirstLaunchFX = PPtr<UIFirstLaunchFX>.Read(reader);
        
        return new(_m_GameObject,
            _m_Enabled,
            _m_Script,
            _m_Name,
            _m_FadeAnimator,
            _m_DelayBeforeShow,
            _m_MainMenuSideBarPCView,
            _m_TermsOfUsePCView,
            _m_CreditsView,
            _m_NewGamePCView,
            _m_CharGenContextPCView,
            _m_FeedbackPopupPCView,
            _m_FirstLaunchSettingsPCView,
            _m_FirstLaunchFX);
    }
}

